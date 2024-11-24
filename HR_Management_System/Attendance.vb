Imports Npgsql
Imports System.Globalization

Public Class Attendance
    Private Timer As New Timer()
    Private PopUp As AttendancePopUp
    Private employeeSessions As New Dictionary(Of String, Dictionary(Of String, String))()

    Public Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RFIDTxt.Focus()
    End Sub

    Public Sub RFIDTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles RFIDTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim tappedRFID As String = RFIDTxt.Text.Trim()
            If tappedRFID.Length > 0 Then
                Try
                    HandleRFIDTap(tappedRFID)
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
                RFIDTxt.Clear()
            End If
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub HandleRFIDTap(rfid As String)
        Try
            OpenConnection()
            Using transaction As NpgsqlTransaction = conn.BeginTransaction()
                Dim employeeData = FetchEmployeeDataByCardNumber(rfid)

                If employeeData IsNot Nothing Then
                    Dim currentDate As DateTime = DateTime.Now
                    Dim currentTime As TimeSpan = currentDate.TimeOfDay

                    employeeData("DateNow") = currentDate.ToString("yyyy-MM-dd")
                    employeeData("TimeIn") = currentTime.ToString("hh\:mm\:ss")

                    If Not AttendanceRecordExists(employeeData("EmployeeID"), currentDate.Date) Then
                        InsertAttendanceRecord(employeeData, currentDate)
                        transaction.Commit()
                        ShowAttendancePopUp(employeeData)
                    Else
                        If UpdateAttendanceRecord(employeeData("EmployeeID"), currentDate) Then
                            transaction.Commit()
                            MsgBox("Time-Out recorded successfully.")
                        Else
                            MsgBox("Failed to record Time-Out. Please check the records.")
                            transaction.Rollback()
                        End If
                    End If
                Else
                    MsgBox("RFID not recognized or employee not found.")
                    System.Media.SystemSounds.Exclamation.Play()
                    transaction.Rollback()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Function AttendanceRecordExists(employeeID As String, dateValue As DateTime) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM attendance WHERE ""Date"" = @Date AND ""EmployeeID"" = @EmployeeID"
        Using cmd As New NpgsqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Date", dateValue.Date)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
            exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
        Return exists
    End Function

    Private Function FetchEmployeeDataByCardNumber(rfid As String) As Dictionary(Of String, String)
        Dim employeeData As New Dictionary(Of String, String)
        Dim query As String = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"" " &
                              "FROM employee WHERE ""EmployeeCardNumber"" = @RFID"
        Using cmd As New NpgsqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RFID", rfid)
            Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    employeeData("EmployeeID") = reader("EmployeeID").ToString()
                    employeeData("EmployeeName") = reader("EmployeeName").ToString()
                    employeeData("EmployeePosition") = reader("EmployeePosition").ToString()
                    employeeData("EmployeeDaySchedule") = reader("EmployeeDaySchedule").ToString()
                    employeeData("EmployeeTimeShift") = reader("EmployeeTimeShift").ToString()
                End If
            End Using
        End Using
        Return If(employeeData.Count > 0, employeeData, Nothing)
    End Function

    Private Sub InsertAttendanceRecord(employeeData As Dictionary(Of String, String), timeIn As DateTime)
        Dim query As String = "INSERT INTO attendance (""Date"", ""TimeIn"", ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"") " &
                              "VALUES (@Date, @TimeIn, @EmployeeID, @EmployeeName, @EmployeePosition, @EmployeeDaySchedule, @EmployeeTimeShift)"
        Using cmd As New NpgsqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Date", timeIn.Date)
            cmd.Parameters.AddWithValue("@TimeIn", timeIn.TimeOfDay)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeData("EmployeeID"))
            cmd.Parameters.AddWithValue("@EmployeeName", employeeData("EmployeeName"))
            cmd.Parameters.AddWithValue("@EmployeePosition", employeeData("EmployeePosition"))
            cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeData("EmployeeDaySchedule"))
            cmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeData("EmployeeTimeShift"))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function UpdateAttendanceRecord(employeeID As String, timeOut As DateTime) As Boolean
        Dim rowsAffected As Integer
        Dim query As String = "UPDATE attendance SET ""TimeOut"" = @TimeOut, ""EmployeeTotalHour"" = EXTRACT(EPOCH FROM (@TimeOut - ""TimeIn"")) / 3600 " &
                              "WHERE ""Date"" = @Date AND ""EmployeeID"" = @EmployeeID AND ""TimeOut"" IS NULL"
        Using cmd As New NpgsqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TimeOut", timeOut.TimeOfDay)
            cmd.Parameters.AddWithValue("@Date", timeOut.Date)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
            rowsAffected = cmd.ExecuteNonQuery()
        End Using
        Return rowsAffected > 0
    End Function

    Private Sub ShowAttendancePopUp(employeeData As Dictionary(Of String, String))
        PopUp = New AttendancePopUp()
        PopUp.SetEmployeeData(employeeData)
        PopUp.Show()
        Timer.Interval = 5000
        AddHandler Timer.Tick, AddressOf ClosePopUp
        Timer.Start()
    End Sub

    Private Sub ClosePopUp(sender As Object, e As EventArgs)
        Timer.Stop()
        Timer.Dispose()
        If PopUp IsNot Nothing Then
            PopUp.Hide()
        End If
    End Sub

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Dim Welcome As New Welcome()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(Welcome)
        Me.Close()
    End Sub
End Class
