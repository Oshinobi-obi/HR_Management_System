﻿Imports Npgsql
Imports System.Data

Public Class HRAttRecord
    Private conn As NpgsqlConnection
    Private RefreshTimer As New Timer()

    Private Sub AttRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceYear.Items.Clear()
        AttendanceYear.Items.AddRange(New String() {"All", "Today", "Yesterday", "This Week", "This Month", "Quarterly", "Semiannual", "Annual"})
        AttendanceYear.SelectedIndex = 0

        LoadAttendanceRecords()

        RefreshTimer.Interval = 5000
        AddHandler RefreshTimer.Tick, AddressOf RefreshTimer_Tick
        RefreshTimer.Enabled = True
    End Sub

    Private Sub ReturnBtn_Paint(sender As Object, e As PaintEventArgs)
        Dim button As Button = CType(sender, Button)
        Dim graphics As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, button.Width - 1, button.Height - 1)

        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Using brush As New SolidBrush(Color.LightCoral)
            graphics.FillPath(brush, path)
        End Using

        Using borderPen As New Pen(Color.Black, 2)
            graphics.DrawPath(borderPen, path)
        End Using

        Dim textBrush As New SolidBrush(button.ForeColor)
        Dim textFormat As New StringFormat() With {
        .Alignment = StringAlignment.Center,
        .LineAlignment = StringAlignment.Center
    }
        graphics.DrawString(button.Text, button.Font, textBrush, rect, textFormat)

        textBrush.Dispose()
        path.Dispose()
    End Sub
    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs)
        Try
            Dim selectedPeriod = If(AttendanceYear.SelectedItem IsNot Nothing, AttendanceYear.SelectedItem.ToString(), "TODAY")
            Dim filterQuery = GetFilterQuery(selectedPeriod)
            LoadAttendanceRecords(filterQuery)
        Catch ex As Exception
            MessageBox.Show("Error refreshing attendance data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetFilterQuery(selectedPeriod As String) As String
        Dim filterQuery As String = ""

        Select Case selectedPeriod
            Case "All"
                filterQuery = ""
            Case "Today"
                filterQuery = "WHERE ""Date"" = CURRENT_DATE"
            Case "Yesterday"
                filterQuery = "WHERE ""Date"" = CURRENT_DATE - INTERVAL '1 day'"
            Case "This Week"
                filterQuery = "WHERE EXTRACT(WEEK FROM ""Date"") = EXTRACT(WEEK FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "This Month"
                filterQuery = "WHERE EXTRACT(MONTH FROM ""Date"") = EXTRACT(MONTH FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "Quarterly"
                filterQuery = "WHERE EXTRACT(QUARTER FROM ""Date"") = EXTRACT(QUARTER FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "Semiannual"
                filterQuery = "WHERE EXTRACT(MONTH FROM ""Date"") IN (1, 2, 3, 4, 5, 6) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "Annual"
                filterQuery = "WHERE EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
        End Select

        Return filterQuery
    End Function

    Private Sub LoadAttendanceRecords(Optional filterQuery As String = "")
        Try
            OpenConnection()
            Dim query As String = "SELECT ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"" AS ""Schedule"", " &
                              """EmployeeTimeShift"" AS ""Time Shift"", ""Date"" AS ""Log Date"", " &
                              """TimeIn"", ""TimeOut"", ""EmployeeTotalHour"" AS ""TotalHours"" " &
                              "FROM public.attendance " & filterQuery & " ORDER BY ""Date"" DESC"
            Dim cmd As New NpgsqlCommand(query, conn)
            Dim adapter As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            AttendanceGrid.DataSource = table

        Catch ex As Exception
            MsgBox("Error loading records: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub OpenConnection()
        Dim connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;Port=25060;Username=doadmin;Password=AVNS_TVTvL-Hw2xMPJMthE_2;Database=defaultdb;SSL Mode=Require"
        conn = New NpgsqlConnection(connString)
        conn.Open()
    End Sub

    Private Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs)
        Dim adminForm As New HRAdmin
        CType(MdiParent, MDIParent).LoadFormInMDI(adminForm)
        Close
    End Sub

    Private Sub AttendanceYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceYear.SelectedIndexChanged
        Dim selectedPeriod As String = AttendanceYear.SelectedItem.ToString()
        Dim filterQuery As String = GetFilterQuery(selectedPeriod)
        LoadAttendanceRecords(filterQuery)
    End Sub
End Class