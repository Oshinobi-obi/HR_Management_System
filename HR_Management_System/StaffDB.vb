Imports Npgsql

Public Class StaffDb
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Private Sub StaffDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReturnBtn.FlatStyle = FlatStyle.Flat
        ReturnBtn.FlatAppearance.BorderSize = 0
        ReturnBtn.BackColor = Color.Transparent
        ReturnBtn.Text = "RETURN"

        AddBtn.FlatStyle = FlatStyle.Flat
        AddBtn.FlatAppearance.BorderSize = 0
        AddBtn.BackColor = Color.Transparent
        AddBtn.Text = "ADD"

        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.BackColor = Color.Transparent
        EditBtn.Text = "EDIT"

        AddHandler ReturnBtn.Paint, AddressOf ReturnBtn_Paint
        AddHandler AddBtn.Paint, AddressOf AddBtn_Paint
        AddHandler EditBtn.Paint, AddressOf EditBtn_Paint
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

    Private Sub AddBtn_Paint(sender As Object, e As PaintEventArgs)
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

        Using brush As New SolidBrush(Color.LightGreen)
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

    Private Sub EditBtn_Paint(sender As Object, e As PaintEventArgs)
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

        Using brush As New SolidBrush(Color.LightGreen)
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

    Private Sub EmployeeRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFilterBox()
        LoadEmployeeRecords()
    End Sub

    Private Sub PopulateFilterBox()
        Dim positions As String() = {"All", "Admin Staff", "Secretary (HRMO)", "BPSO", "Clerk", "Medical Aide"}
        FilterBox.Items.AddRange(positions)
        FilterBox.SelectedIndex = 0
    End Sub

    Private Sub LoadEmployeeRecords(Optional positionFilter As String = "")
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String
                If String.IsNullOrEmpty(positionFilter) OrElse positionFilter = "All" Then
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployedDate"" FROM ""employee"""
                Else
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployedDate"" FROM ""employee"" WHERE ""EmployeePosition"" = @position"
                End If

                Using cmd As New NpgsqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(positionFilter) AndAlso positionFilter <> "All" Then
                        cmd.Parameters.AddWithValue("@position", positionFilter)
                    End If

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        StaffGrid.Columns.Clear()
                        StaffGrid.DataSource = dt
                        StaffGrid.Columns("EmployeeID").HeaderText = "EMPLOYEE ID"
                        StaffGrid.Columns("EmployeeName").HeaderText = "NAME"
                        StaffGrid.Columns("EmployeePosition").HeaderText = "POSITION"
                        StaffGrid.Columns("EmployeeDaySchedule").HeaderText = "SCHEDULE"
                        StaffGrid.Columns("EmployeeAge").HeaderText = "AGE"
                        StaffGrid.Columns("EmployeeMobile").HeaderText = "CONTACT"
                        StaffGrid.Columns("EmployeeAddress").HeaderText = "ADDRESS"
                        StaffGrid.Columns("EmployedDate").HeaderText = "DOE"
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading employee records: " & ex.Message)
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim addStaffForm As New AddStaff()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(addStaffForm)
        Me.Close()
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim adminForm As New Admin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
        Me.Close()
    End Sub

    Private Sub FilterBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterBox.SelectedIndexChanged
        Dim selectedPosition As String = FilterBox.SelectedItem.ToString()

        If selectedPosition = "All" Then
            LoadEmployeeRecords()
        Else
            LoadEmployeeRecords(selectedPosition)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim editStaffForm As New EditStaff()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(editStaffForm)
        Me.Close()
    End Sub
End Class