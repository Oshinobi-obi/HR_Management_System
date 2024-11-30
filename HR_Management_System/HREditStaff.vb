Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class HREditStaff

    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;Username=doadmin;Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;SSL Mode=Require"

    Public Sub EditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeButton(ReturnBtn, "RETURN", Color.LightCoral)
        InitializeButton(UpdateStaffBtn, "UPDATE", Color.LightGreen)
        InitializeButton(OpenBtn, "ADD", Color.LightGreen)

        LoadPositionItems()
        LoadEmployeeIDs()
        ToggleControls(False)

        AddHandler PosCmb.KeyPress, AddressOf DisableKeyPress
        AddHandler PosCmb.MouseDown, AddressOf DisableMouseClick
        AddHandler PosCmb.MouseWheel, AddressOf DisableMouseWheel
        AddHandler StatusCmb.KeyPress, AddressOf DisableKeyPress
        AddHandler StatusCmb.MouseDown, AddressOf DisableMouseClick
        AddHandler StatusCmb.MouseDown, AddressOf DisableMouseClick
        AddHandler StatusCmb.MouseWheel, AddressOf DisableMouseWheel
    End Sub

    Private Sub DisableKeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub DisableMouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            DirectCast(sender, ComboBox).DroppedDown = False
        End If
    End Sub

    Private Sub DisableMouseWheel(sender As Object, e As MouseEventArgs) Handles PosCmb.MouseWheel, StatusCmb.MouseWheel
        Dim mouseEvent = TryCast(e, HandledMouseEventArgs)
        If mouseEvent IsNot Nothing Then
            mouseEvent.Handled = True
        End If
    End Sub

    Private Sub ToggleControls(isEnabled As Boolean)
        ResidentIDTxt.Enabled = isEnabled
        FirstNameTxt.Enabled = isEnabled
        MiddleNameTxt.Enabled = isEnabled
        LastNameTxt.Enabled = isEnabled
        AgeTxt.Enabled = isEnabled
        ContactTxt.Enabled = isEnabled
        AddressTxt.Enabled = isEnabled
        WorkDayTxt.Enabled = isEnabled
        HrShiftTxt.Enabled = isEnabled
        PictureTxt.Enabled = isEnabled
        StatusCmb.Enabled = isEnabled
        PosCmb.Enabled = isEnabled
        CardNumberTxt.Enabled = isEnabled

        Dim backColor As Color = If(isEnabled, Color.White, Color.LightGray)
        ResidentIDTxt.BackColor = backColor
        FirstNameTxt.BackColor = backColor
        MiddleNameTxt.BackColor = backColor
        LastNameTxt.BackColor = backColor
        AgeTxt.BackColor = backColor
        ContactTxt.BackColor = backColor
        AddressTxt.BackColor = backColor
        WorkDayTxt.BackColor = backColor
        HrShiftTxt.BackColor = backColor
        PictureTxt.BackColor = backColor
        StatusCmb.BackColor = backColor
        PosCmb.BackColor = backColor
        CardNumberTxt.BackColor = backColor
    End Sub

    Private Sub ClearFields()
        FirstNameTxt.Clear()
        MiddleNameTxt.Clear()
        LastNameTxt.Clear()
        AgeTxt.Clear()
        StatusCmb.SelectedIndex = -1
        ContactTxt.Clear()
        AddressTxt.Clear()
        WorkDayTxt.Clear()
        HrShiftTxt.Clear()
        PictureTxt.Clear()
        CardNumberTxt.Clear()
        PosCmb.SelectedIndex = -1
    End Sub

    Private Sub LoadPositionItems()
        PosCmb.Items.Clear()
        PosCmb.Items.AddRange(New String() {"Admin Staff", "Secretary (HRMO)", "BPSO", "Clerk", "Medical Aide"})
    End Sub

    Private Sub LoadEmployeeIDs()
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT ""EmployeeID"" FROM employee"
                Using cmd As New NpgsqlCommand(sql, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        EmIDCmb.Items.Clear()
                        While reader.Read()
                            EmIDCmb.Items.Add(reader("EmployeeID").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Employee IDs: " & ex.Message)
        End Try
    End Sub

    Private Sub EmIDCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmIDCmb.SelectedIndexChanged
        If EmIDCmb.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(EmIDCmb.SelectedItem.ToString().Trim()) Then
            ToggleControls(True)
            Dim selectedID = EmIDCmb.SelectedItem.ToString.Trim
            LoadEmployeeData(selectedID)
        Else
            ToggleControls(False)
        End If
    End Sub

    Private Sub LoadEmployeeData(employeeID As String)
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", " &
                                    """EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployeeImage"", ""EmployeeCardNumber"", ""EmployeeStatus"" " &
                                    "FROM employee WHERE ""EmployeeID"" = @EmployeeID"
                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim fullName As String = reader("EmployeeName").ToString().Trim()
                            Dim nameParts As String() = fullName.Split(" "c)

                            If nameParts.Length > 0 Then FirstNameTxt.Text = nameParts(0)
                            If nameParts.Length > 1 Then MiddleNameTxt.Text = nameParts(1)
                            If nameParts.Length > 2 Then LastNameTxt.Text = nameParts(2)

                            AgeTxt.Text = reader("EmployeeAge").ToString()
                            WorkDayTxt.Text = reader("EmployeeDaySchedule").ToString()
                            HrShiftTxt.Text = reader("EmployeeTimeShift").ToString()
                            ContactTxt.Text = reader("EmployeeMobile").ToString()
                            AddressTxt.Text = reader("EmployeeAddress").ToString()
                            CardNumberTxt.Text = reader("EmployeeCardNumber").ToString()

                            Dim status As String = reader("EmployeeStatus").ToString().Trim()
                            If StatusCmb.Items.Contains(status) Then
                                StatusCmb.SelectedItem = status
                            Else
                                MessageBox.Show("Status '" & status & "' not found in StatusCmb.")
                            End If

                            LoadPositionItems()
                            Dim position As String = reader("EmployeePosition").ToString().Trim()

                            Dim index As Integer = PosCmb.Items.IndexOf(position)
                            If index >= 0 Then
                                PosCmb.SelectedIndex = index
                            Else
                                MessageBox.Show("Position '" & position & "' not found in PosCmb.")
                            End If

                            Dim imageBytes As Byte() = CType(reader("EmployeeImage"), Byte())
                            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                                Dim imageFilePath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "tempImage.png")
                                System.IO.File.WriteAllBytes(imageFilePath, imageBytes)
                                PictureTxt.Text = imageFilePath
                            Else
                                PictureTxt.Text = String.Empty
                            End If
                        Else
                            MessageBox.Show("No data found for the selected EmployeeID.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message)
        End Try
    End Sub

    Private Sub InitializeButton(button As Button, text As String, backColor As Color)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.Transparent
        button.Text = text
        AddHandler button.Paint, Sub(sender, e) PaintRoundedButton(button, e, backColor)
    End Sub

    Private Sub PaintRoundedButton(button As Button, e As PaintEventArgs, color As Color)
        Dim graphics As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, button.Width - 1, button.Height - 1)
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As New GraphicsPath()
            Dim radius As Integer = 20
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(color)
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
        End Using
    End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        SelectImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        SelectImage.Title = "Select an Image"

        If SelectImage.ShowDialog() = DialogResult.OK Then
            PictureTxt.Text = SelectImage.FileName
        End If
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim staffDBForm As New HRStaffDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(staffDBForm)
        Me.Close()
    End Sub

    Private Sub UpdateEmployeeData()
        Dim employeeID As String = EmIDCmb.SelectedItem.ToString().Trim()

        If String.IsNullOrWhiteSpace(FirstNameTxt.Text) OrElse String.IsNullOrWhiteSpace(AgeTxt.Text) OrElse PosCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim employeeName As String = $"{FirstNameTxt.Text.Trim()} {MiddleNameTxt.Text.Trim()} {LastNameTxt.Text.Trim()}".Trim()
        Dim employeeAge As Integer = Integer.Parse(AgeTxt.Text.Trim())
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim()
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = ContactTxt.Text.Trim()
        Dim employeeAddress As String = AddressTxt.Text.Trim()
        Dim employeeCardNumber As String = CardNumberTxt.Text.Trim()
        Dim employeeStatus As String = StatusCmb.SelectedItem.ToString()

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim updateQuery As String = "UPDATE employee SET ""EmployeeName"" = @EmployeeName, ""EmployeeAge"" = @EmployeeAge, " &
                                        """EmployeePosition"" = @EmployeePosition, ""EmployeeDaySchedule"" = @EmployeeDaySchedule, " &
                                        """EmployeeTimeShift"" = @EmployeeTimeShift, ""EmployeeMobile"" = @EmployeeMobile, " &
                                        """EmployeeAddress"" = @EmployeeAddress, ""EmployeeCardNumber"" = @EmployeeCardNumber, ""EmployeeStatus"" = @EmployeeStatus " &
                                        "WHERE ""EmployeeID"" = @EmployeeID"

                Using cmd As New NpgsqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    cmd.Parameters.AddWithValue("@EmployeeAge", employeeAge)
                    cmd.Parameters.AddWithValue("@EmployeePosition", employeePosition)
                    cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeDaySchedule)
                    cmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeTimeShift)
                    cmd.Parameters.AddWithValue("@EmployeeMobile", employeeMobile)
                    cmd.Parameters.AddWithValue("@EmployeeAddress", employeeAddress)
                    cmd.Parameters.AddWithValue("@EmployeeCardNumber", employeeCardNumber)
                    cmd.Parameters.AddWithValue("@EmployeeStatus", employeeStatus)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Employee data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateStaffBtn_Click(sender As Object, e As EventArgs) Handles UpdateStaffBtn.Click
        UpdateEmployeeData()
        Dim staffDBForm As New HRStaffDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(staffDBForm)
        Me.Close()
    End Sub

End Class