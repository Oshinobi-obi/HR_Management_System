﻿Imports Npgsql
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
                If Not employeeSessions.ContainsKey(rfid) Then
                    Dim employeeData = FetchEmployeeData(rfid)

                    If employeeData IsNot Nothing Then
                        Dim timeIn As DateTime = DateTime.Now
                        employeeData("TimeIn") = timeIn.ToString("hh:mm tt", CultureInfo.InvariantCulture)
                        employeeData("DateNow") = timeIn.ToString("yyyy-MM-dd")
                        employeeSessions(rfid) = New Dictionary(Of String, String)(employeeData)

                        If Not AttendanceRecordExists(employeeData("EmployeeID"), timeIn) Then
                            InsertAttendanceRecord(employeeData, timeIn)
                            transaction.Commit()
                            ShowAttendancePopUp(employeeData)
                        Else
                            MsgBox("Attendance already recorded for today.")
                            transaction.Rollback()
                        End If
                    Else
                        MsgBox("RFID not recognized or employee not found.")
                        System.Media.SystemSounds.Exclamation.Play()
                        transaction.Rollback()
                    End If
                Else
                    Dim sessionData = employeeSessions(rfid)

                    If sessionData.ContainsKey("TimeIn") Then
                        Dim timeIn As DateTime = DateTime.ParseExact(sessionData("TimeIn"), "hh:mm tt", CultureInfo.InvariantCulture)
                        Dim timeOut As DateTime = DateTime.Now

                        If Not sessionData.ContainsKey("TimeOut") Then
                            Dim hoursWorked As TimeSpan = timeOut - timeIn
                            sessionData("TimeOut") = timeOut.ToString("hh:mm tt", CultureInfo.InvariantCulture)
                            sessionData("EmployeeTotalHour") = hoursWorked.TotalHours.ToString("F2")

                            If UpdateAttendanceRecord(sessionData, timeOut, hoursWorked) > 0 Then
                                transaction.Commit()
                                ShowAttendancePopUp(sessionData)
                                employeeSessions.Remove(rfid)
                            Else
                                MsgBox("Error: No records updated. Please check if the record exists with the matching Date, EmployeeID, and TimeIn.")
                                transaction.Rollback()
                            End If
                        Else
                            MsgBox("Error: TimeOut already recorded for this employee.")
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

    Private Function FetchEmployeeData(rfid As String) As Dictionary(Of String, String)
        Dim employeeData As Dictionary(Of String, String) = Nothing

        Dim query As String = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"" FROM employee WHERE id = @ID"
        Using cmd As New NpgsqlCommand(query, conn)
            Select Case rfid
                Case "2091286169" : cmd.Parameters.AddWithValue("@ID", 1)
                Case "2085555385" : cmd.Parameters.AddWithValue("@ID", 2)
                Case "2092396169" : cmd.Parameters.AddWithValue("@ID", 3)
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
        Dim query As String = "INSERT INTO attendance (""Date"", ""TimeIn"", ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"") " &
                              "VALUES (@Date, @TimeIn, @EmployeeID, @EmployeeName, @EmployeePosition, @EmployeeDaySchedule)"
        Try
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Date", timeIn.Date)
                cmd.Parameters.AddWithValue("@TimeIn", timeIn.TimeOfDay)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeData("EmployeeID"))
                cmd.Parameters.AddWithValue("@EmployeeName", employeeData("EmployeeName"))
                cmd.Parameters.AddWithValue("@EmployeePosition", employeeData("EmployeePosition"))
                cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeData("EmployeeDaySchedule"))
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error inserting attendance record: " & ex.Message)
        End Try
    End Sub

    Private Function UpdateAttendanceRecord(sessionData As Dictionary(Of String, String), timeOut As DateTime, hoursWorked As TimeSpan) As Integer
        Dim rowsAffected As Integer = 0
        Dim updateQuery As String = "UPDATE attendance SET ""TimeOut"" = @TimeOut, ""EmployeeTotalHour"" = @TotalHour " &
                                    "WHERE ""Date"" = @Date AND ""EmployeeID"" = @EmployeeID AND ""TimeIn"" = @TimeIn"

        Using updateCmd As New NpgsqlCommand(updateQuery, conn)
            updateCmd.Parameters.AddWithValue("@TimeOut", timeOut.TimeOfDay)

            If hoursWorked.TotalHours > 0 Then
                updateCmd.Parameters.AddWithValue("@TotalHour", hoursWorked.TotalHours)
            Else
                updateCmd.Parameters.AddWithValue("@TotalHour", DBNull.Value)
            End If

            Dim dateValue As DateTime = DateTime.ParseExact(sessionData("DateNow"), "yyyy-MM-dd", CultureInfo.InvariantCulture)
            updateCmd.Parameters.AddWithValue("@Date", dateValue)

            updateCmd.Parameters.AddWithValue("@EmployeeID", sessionData("EmployeeID"))

            sessionData("TimeIn") = timeOut.TimeOfDay.ToString("hh:mm tt", CultureInfo.InvariantCulture)
            updateCmd.Parameters.AddWithValue("@TimeIn", DateTime.ParseExact(sessionData("TimeIn"), "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay)

            Try
                rowsAffected = updateCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error updating attendance record: " & ex.Message)
            End Try
        End Using

        If rowsAffected = 0 Then
            MsgBox("Error: No matching record found for the given Date, EmployeeID, and TimeIn. Please verify the data.")
        End If

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
            PopUp.Hide()
        End If
    End Sub

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Dim Welcome As New Welcome()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(Welcome)
        Me.Close()
    End Sub
End Class