Imports Npgsql

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
        If Not employeeSessions.ContainsKey(rfid) Then
            Dim employeeData = FetchEmployeeData(rfid)

            If employeeData IsNot Nothing Then
                Dim timeIn As DateTime = DateTime.Now
                employeeData("TimeIn") = timeIn.ToString("hh:mm:ss tt")
                employeeData("DateNow") = timeIn.ToString("yyyy-MM-dd")
                employeeSessions(rfid) = New Dictionary(Of String, String)(employeeData)

                ShowAttendancePopUp(employeeData)
            Else
                MsgBox("RFID not recognized or employee not found.")
                System.Media.SystemSounds.Exclamation.Play()
            End If
        Else
            Dim sessionData = employeeSessions(rfid)

            If sessionData.ContainsKey("TimeIn") Then
                Dim timeIn As DateTime = DateTime.Parse(sessionData("TimeIn"))
                Dim timeOut As DateTime = DateTime.Now
                Dim hoursWorked As TimeSpan = timeOut - timeIn

                sessionData("TimeOut") = timeOut.ToString("hh:mm:ss tt")
                sessionData("HourShift") = hoursWorked.TotalHours.ToString("F2") & " hrs"

                ShowAttendancePopUp(sessionData)
                employeeSessions.Remove(rfid)
            Else
                MsgBox("Error: No Time In found for this employee.")
            End If
        End If
    End Sub

    Private Function FetchEmployeeData(rfid As String) As Dictionary(Of String, String)
        Try
            OpenConnection()

            Dim query As String = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"" FROM employee WHERE id = @ID"
            Using cmd As New NpgsqlCommand(query, conn)
                Select Case rfid
                    Case "2091286169" : cmd.Parameters.AddWithValue("@ID", 1)
                    Case "2085555385" : cmd.Parameters.AddWithValue("@ID", 2)
                    Case Else
                        Return Nothing
                End Select

                Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim data As New Dictionary(Of String, String) From {
                        {"EmployeeID", reader("EmployeeID").ToString()},
                        {"EmployeeName", reader("EmployeeName").ToString()},
                        {"EmployeePosition", reader("EmployeePosition").ToString()},
                        {"EmployeeDaySchedule", reader("EmployeeDaySchedule").ToString()}
                    }
                    reader.Close()
                    Return data
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return Nothing
    End Function

    Private Sub ShowAttendancePopUp(employeeData As Dictionary(Of String, String))
        PopUp = New AttendancePopUp()
        PopUp.SetEmployeeData(employeeData)
        PopUp.Show()
        PopUp.AttendancePanel.Select()

        Timer.Interval = 5000
        AddHandler Timer.Tick, AddressOf ClosePopUp
        Timer.Start()
    End Sub

    Private Sub ClosePopUp(sender As Object, e As EventArgs)
        Timer.Stop()
        Timer.Dispose()
        If PopUp IsNot Nothing Then
            PopUp.Close()
            PopUp.Dispose()
        End If
    End Sub
End Class