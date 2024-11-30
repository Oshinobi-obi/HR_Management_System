Imports Npgsql
Imports System.Data

Public Class HRAttRecord
    Private conn As NpgsqlConnection

    Private Sub AttRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceYear.Items.Clear()
        AttendanceYear.Items.AddRange(New String() {"TODAY", "YESTERDAY", "THIS WEEK", "THIS MONTH", "QUARTERLY", "SEMIANNUAL", "ANNUAL"})
        AttendanceYear.SelectedIndex = 0

        LoadAttendanceRecords()

        ReturnBtn.FlatStyle = FlatStyle.Flat
        ReturnBtn.FlatAppearance.BorderSize = 0
        ReturnBtn.BackColor = Color.Transparent
        ReturnBtn.Text = "RETURN"

        AddHandler ReturnBtn.Paint, AddressOf ReturnBtn_Paint
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

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim adminForm As New HRAdmin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
        Me.Close()
    End Sub

    Private Sub AttendanceYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceYear.SelectedIndexChanged
        Dim selectedPeriod = AttendanceYear.SelectedItem.ToString
        Dim filterQuery = ""

        Select Case selectedPeriod
            Case "TODAY"
                filterQuery = "WHERE ""Date"" = CURRENT_DATE"
            Case "YESTERDAY"
                filterQuery = "WHERE ""Date"" = CURRENT_DATE - INTERVAL '1 day'"
            Case "THIS WEEK"
                filterQuery = "WHERE EXTRACT(WEEK FROM ""Date"") = EXTRACT(WEEK FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "THIS MONTH"
                filterQuery = "WHERE EXTRACT(MONTH FROM ""Date"") = EXTRACT(MONTH FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "QUARTERLY"
                filterQuery = "WHERE EXTRACT(QUARTER FROM ""Date"") = EXTRACT(QUARTER FROM CURRENT_DATE) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "SEMIANNUAL"
                filterQuery = "WHERE EXTRACT(MONTH FROM ""Date"") IN (1, 2, 3, 4, 5, 6) AND EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
            Case "ANNUAL"
                filterQuery = "WHERE EXTRACT(YEAR FROM ""Date"") = EXTRACT(YEAR FROM CURRENT_DATE)"
        End Select

        LoadAttendanceRecords(filterQuery)
    End Sub
End Class