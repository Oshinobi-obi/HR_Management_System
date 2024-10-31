﻿Imports Npgsql

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
                If Not employeeSessions.ContainsKey(rfid) Then
                    ' First tap: Insert TimeIn
                    Dim employeeData = FetchEmployeeData(rfid)

                    If employeeData IsNot Nothing Then
                        Dim timeIn As DateTime = DateTime.Now
                        employeeData("TimeIn") = timeIn.ToString("HH:mm:ss")
                        employeeData("DateNow") = timeIn.ToString("yyyy-MM-dd")
                        employeeSessions(rfid) = New Dictionary(Of String, String)(employeeData)

                        InsertAttendanceRecord(employeeData, timeIn)
                        transaction.Commit()
                        ShowAttendancePopUp(employeeData)
                    Else
                        MsgBox("RFID not recognized or employee not found.")
                        System.Media.SystemSounds.Exclamation.Play()
                        transaction.Rollback()
                    End If
                Else
                    ' Second tap: Update TimeOut and Total Hours
                    Dim sessionData = employeeSessions(rfid)

                    If sessionData.ContainsKey("TimeIn") Then
                        Dim timeIn As DateTime = DateTime.Parse(sessionData("TimeIn"))
                        Dim timeOut As DateTime = DateTime.Now
                        Dim hoursWorked As TimeSpan = timeOut - timeIn

                        sessionData("TimeOut") = timeOut.ToString("HH:mm:ss")
                        sessionData("EmployeeTotalHour") = hoursWorked.TotalHours.ToString("F2")

                        If UpdateAttendanceRecord(sessionData, timeOut, hoursWorked) > 0 Then
                            transaction.Commit()
                            ShowAttendancePopUp(sessionData)
                            employeeSessions.Remove(rfid) ' Clear session
                        Else
                            MsgBox("Error: No records updated. Please check if the record exists with the matching Date, EmployeeName, and TimeIn.")
                            transaction.Rollback()
                        End If
                    Else
                        MsgBox("Error: No Time In found for this employee.")
                        transaction.Rollback()
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Function FetchEmployeeData(rfid As String) As Dictionary(Of String, String)
        Dim employeeData As Dictionary(Of String, String) = Nothing

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
                employeeData = New Dictionary(Of String, String) From {
                    {"EmployeeID", reader("EmployeeID").ToString()},
                    {"EmployeeName", reader("EmployeeName").ToString()},
                    {"EmployeePosition", reader("EmployeePosition").ToString()},
                    {"EmployeeDaySchedule", reader("EmployeeDaySchedule").ToString()}
                }
            End If
            reader.Close()
        End Using

        Return employeeData
    End Function

    Private Sub InsertAttendanceRecord(employeeData As Dictionary(Of String, String), timeIn As DateTime)
        Dim query As String = "INSERT INTO attendance (""Date"", ""TimeIn"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"") " &
                              "VALUES (@Date, @TimeIn, @EmployeeName, @EmployeePosition, @EmployeeDaySchedule)"
        Using cmd As New NpgsqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Date", timeIn.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@TimeIn", timeIn.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@EmployeeName", employeeData("EmployeeName"))
            cmd.Parameters.AddWithValue("@EmployeePosition", employeeData("EmployeePosition"))
            cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeData("EmployeeDaySchedule"))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function UpdateAttendanceRecord(sessionData As Dictionary(Of String, String), timeOut As DateTime, hoursWorked As TimeSpan) As Integer
        Dim rowsAffected As Integer = 0
        Dim checkQuery As String = "SELECT COUNT(*) FROM attendance WHERE ""Date"" = @Date AND ""EmployeeName"" = @EmployeeName AND ""TimeIn"" = @TimeIn"

        Console.WriteLine("Matching Data:")
        Console.WriteLine("Date: " & sessionData("DateNow"))
        Console.WriteLine("EmployeeName: " & sessionData("EmployeeName"))
        Console.WriteLine("TimeIn: " & sessionData("TimeIn"))

        Using checkCmd As New NpgsqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@Date", sessionData("DateNow"))
            checkCmd.Parameters.AddWithValue("@EmployeeName", sessionData("EmployeeName"))
            checkCmd.Parameters.AddWithValue("@TimeIn", DateTime.Parse(sessionData("TimeIn")).ToString("HH:mm:ss"))

            Dim recordCount As Integer = CInt(checkCmd.ExecuteScalar())
            If recordCount = 0 Then
                MsgBox("Error: No matching record found for the given Date, EmployeeName, and TimeIn. Please verify the data.")
                Return rowsAffected
            End If
        End Using

        Dim updateQuery As String = "UPDATE attendance SET ""TimeOut"" = @TimeOut, ""EmployeeTotalHour"" = @TotalHour " &
                                "WHERE ""Date"" = @Date AND ""EmployeeName"" = @EmployeeName AND ""TimeIn"" = @TimeIn"
        Using updateCmd As New NpgsqlCommand(updateQuery, conn)
            updateCmd.Parameters.AddWithValue("@TimeOut", timeOut.ToString("HH:mm:ss"))
            updateCmd.Parameters.AddWithValue("@TotalHour", hoursWorked.TotalHours.ToString("F2"))
            updateCmd.Parameters.AddWithValue("@Date", sessionData("DateNow"))
            updateCmd.Parameters.AddWithValue("@EmployeeName", sessionData("EmployeeName"))
            updateCmd.Parameters.AddWithValue("@TimeIn", DateTime.Parse(sessionData("TimeIn")).ToString("HH:mm:ss"))

            rowsAffected = updateCmd.ExecuteNonQuery()
        End Using

        Return rowsAffected
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
