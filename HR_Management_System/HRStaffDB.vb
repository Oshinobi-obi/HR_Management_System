Imports Npgsql
Imports HR_Management_System.HRAdmin

Public Class HRStaffDB
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Private targetPanel As Panel

    Private Sub StaffDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResidentListBtn.FlatStyle = FlatStyle.Flat
        ResidentListBtn.FlatAppearance.BorderSize = 0
        ResidentListBtn.BackColor = Color.Transparent
        ResidentListBtn.Text = "RESIDENT LIST"

        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.BackColor = Color.Transparent
        EditBtn.Text = "EDIT STAFF"

        AddPositionBtn.FlatStyle = FlatStyle.Flat
        AddPositionBtn.FlatAppearance.BorderSize = 0
        AddPositionBtn.BackColor = Color.Transparent
        AddPositionBtn.Text = "ADD POS"

        AddHandler ResidentListBtn.Paint, AddressOf AddBtn_Paint
        AddHandler EditBtn.Paint, AddressOf EditBtn_Paint
        AddHandler AddPositionBtn.Paint, AddressOf AddPositionBtn_Paint

        RefreshTimer.Interval = 5000
        RefreshTimer.Enabled = True
    End Sub

    Private Sub AddPositionBtn_Paint(sender As Object, e As PaintEventArgs)
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
        Try
            FilterBox.Items.Clear()
            FilterBox.Items.Add("All")

            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT positionname FROM public.employeeposition ORDER BY positionname"
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            FilterBox.Items.Add(reader("positionname").ToString().Trim())
                        End While
                    End Using
                End Using
            End Using

            FilterBox.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error loading positions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadEmployeeRecords(Optional positionFilter As String = "")
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String

                If String.IsNullOrEmpty(positionFilter) OrElse positionFilter = "All" Then
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployedDate"" FROM public.employee"
                Else
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployedDate"" FROM public.employee WHERE ""EmployeePosition"" = @position"
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
            MessageBox.Show("Error loading employee records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub New(panel As Panel)
        InitializeComponent()
        targetPanel = panel
    End Sub

    Private Sub LoadFormInPanel(form As Form)
        targetPanel.Controls.Clear()

        form.TopLevel = False
        form.ControlBox = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        targetPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub ResidentListBtn_Click(sender As Object, e As EventArgs) Handles ResidentListBtn.Click
        Dim residentListForm As New HRResidentDB()
        LoadFormInPanel(residentListForm)
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
        Dim editForm As New HREditStaff()
        LoadFormInPanel(editForm)
    End Sub

    Private Sub AddPositionBtn_Click(sender As Object, e As EventArgs) Handles AddPositionBtn.Click
        Dim addPositionForm As New HRAddPosition()
        LoadFormInPanel(addPositionForm)
    End Sub

    Private Function GetNextPositionId() As Integer
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COALESCE(MAX(positionid), 0) FROM public.employeeposition"
                Using cmd As New NpgsqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Return Convert.ToInt32(result) + 1
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving next position ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 1
    End Function

    Private Function GetNextPositionCode() As String
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT MAX(positioncode) FROM public.employeeposition"
                Using cmd As New NpgsqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim maxCode As Integer
                        If Integer.TryParse(result.ToString().Trim(), maxCode) Then
                            Return (maxCode + 1).ToString("D2")
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving next position code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return "01"
    End Function

    Private Sub RefreshPositionComboBox()
        Dim addStaffForm As HRAddStaff = Application.OpenForms.OfType(Of HRAddStaff)().FirstOrDefault()
        If addStaffForm IsNot Nothing Then
            addStaffForm.LoadPositions()
        End If
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        Try
            Dim currentFilter As String = If(FilterBox.SelectedItem IsNot Nothing, FilterBox.SelectedItem.ToString(), "All")
            LoadEmployeeRecords(currentFilter)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class