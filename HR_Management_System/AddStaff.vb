Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class AddStaff
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Public Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeButton(ReturnBtn, "RETURN", Color.LightCoral)
        InitializeButton(AddStaffBtn, "ADD STAFF", Color.LightGreen)
        InitializeButton(OpenBtn, "OPEN", Color.LightGreen)
        ToggleControls(False)
    End Sub

    Private Sub ToggleControls(isEnabled As Boolean)
        FirstNameTxt.Enabled = isEnabled
        MiddleNameTxt.Enabled = isEnabled
        LastNameTxt.Enabled = isEnabled
        AgeTxt.Enabled = isEnabled
        GenderTxt.Enabled = isEnabled
        ContactTxt.Enabled = isEnabled
        AddressTxt.Enabled = isEnabled
        EmIDTxt.Enabled = isEnabled
        WorkDayTxt.Enabled = isEnabled
        HrShiftTxt.Enabled = isEnabled
        PosCmb.Enabled = isEnabled
        PictureTxt.Enabled = isEnabled
        CardNumberTxt.Enabled = isEnabled

        Dim backColor As Color = If(isEnabled, Color.White, Color.LightGray)
        FirstNameTxt.BackColor = backColor
        MiddleNameTxt.BackColor = backColor
        LastNameTxt.BackColor = backColor
        AgeTxt.BackColor = backColor
        GenderTxt.BackColor = backColor
        ContactTxt.BackColor = backColor
        AddressTxt.BackColor = backColor
        EmIDTxt.BackColor = backColor
        WorkDayTxt.BackColor = backColor
        HrShiftTxt.BackColor = backColor
        PosCmb.BackColor = backColor
        PictureTxt.BackColor = backColor
        CardNumberTxt.BackColor = backColor
    End Sub

    Private Sub ClearFields()
        FirstNameTxt.Clear()
        MiddleNameTxt.Clear()
        LastNameTxt.Clear()
        AgeTxt.Clear()
        GenderTxt.Clear()
        ContactTxt.Clear()
        AddressTxt.Clear()
        EmIDTxt.Clear()
        WorkDayTxt.Clear()
        HrShiftTxt.Clear()
        PictureTxt.Clear()
        CardNumberTxt.Clear()
        PosCmb.SelectedIndex = -1
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

    Private Sub CheckIfResident()
        Dim residentID As String = ResidentIDTxt.Text.Trim()

        If String.IsNullOrEmpty(residentID) Then
            MessageBox.Show("Please enter resident ID to check.")
            ClearFields()
            ToggleControls(False)
            Return
        End If

        Try
            Dim parsedResidentID As Long
            If Not Long.TryParse(residentID, parsedResidentID) Then
                MessageBox.Show("Please enter a valid resident ID number.")
                ClearFields()
                ToggleControls(False)
                Return
            End If

            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT ""First_Name"", ""Middle_Name"", ""Last_Name"", ""Date_Of_Birth"", ""Sex"", ""Contact_Number"", " &
                                  "CONCAT(""House_Number"", ' ', ""Street_Name"", ' ', ""Subdivision"") AS ""ResidentAddress"" " &
                                  "FROM ""Residents"" WHERE ""Resident_ID"" = @Resident_ID"

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Resident_ID", parsedResidentID)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            MessageBox.Show("This is a Resident.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            FirstNameTxt.Text = reader("First_Name").ToString()
                            MiddleNameTxt.Text = reader("Middle_Name").ToString()
                            LastNameTxt.Text = reader("Last_Name").ToString()

                            Dim dateOfBirth As DateTime = Convert.ToDateTime(reader("Date_Of_Birth"))
                            Dim age As Integer = DateTime.Now.Year - dateOfBirth.Year
                            If DateTime.Now.Month < dateOfBirth.Month OrElse
                           (DateTime.Now.Month = dateOfBirth.Month AndAlso DateTime.Now.Day < dateOfBirth.Day) Then
                                age -= 1
                            End If
                            AgeTxt.Text = age.ToString()

                            GenderTxt.Text = reader("Sex").ToString()
                            ContactTxt.Text = reader("Contact_Number").ToString()
                            AddressTxt.Text = reader("ResidentAddress").ToString()

                            ToggleControls(True)
                        Else
                            MessageBox.Show("This is not a Resident.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ClearFields()
                            ToggleControls(False)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking resident information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            ToggleControls(False)
        End Try
    End Sub

    Private Sub ResidentIDTxt_LostFocus(sender As Object, e As EventArgs) Handles ResidentIDTxt.LostFocus
        CheckIfResident()
    End Sub

    Private Sub PosCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosCmb.SelectedIndexChanged
        If PosCmb.SelectedItem IsNot Nothing Then
            Dim selectedPosition As String = PosCmb.SelectedItem.ToString()
            Dim positionCode As String = PositionValues(selectedPosition)
            Dim firstLetter As String = If(FirstNameTxt.Text.Length > 0, FirstNameTxt.Text.Substring(0, 1).ToUpper(), "A")
            Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
            Dim age As String = AgeTxt.Text.Trim()

            If IsNumeric(age) Then
                Dim incrementingNumber As Integer = GetNextEmployeeID()
                Dim employeeID As String = $"{positionCode}-{firstLetterNumber}-{age}-{incrementingNumber:D2}"
                EmIDTxt.Text = employeeID
            Else
                MessageBox.Show("Please enter a valid age.")
            End If

            If selectedPosition = "Secretary (HRMO)" Then
                HrShiftTxt.Text = "8:00 AM - 5:00 PM"
                HrShiftTxt.ForeColor = Color.Black
            Else
                HrShiftTxt.Text = ""
            End If
        Else
            MessageBox.Show("Please select a position.")
        End If
    End Sub

    Private Function GetAlphabetPosition(letter As String) As String
        Return (Asc(letter.ToUpper()) - Asc("A"c) + 1).ToString("D2")
    End Function

    Private Function GetNextEmployeeID() As Integer
        Using conn As New NpgsqlConnection(connString)
            conn.Open()
            Dim query As String = "SELECT COALESCE(MAX(CAST(SUBSTRING(""EmployeeID"" FROM '[0-9]+$') AS INTEGER)), 0) + 1 FROM employee"
            Using cmd As New NpgsqlCommand(query, conn)
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        If String.IsNullOrWhiteSpace(FirstNameTxt.Text) OrElse
       String.IsNullOrWhiteSpace(AgeTxt.Text) OrElse
       PosCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim employeeID As String = EmIDTxt.Text.Trim()
        Dim employeeName As String = $"{FirstNameTxt.Text.Trim()} {MiddleNameTxt.Text.Trim()} {LastNameTxt.Text.Trim()}".Trim()
        Dim employeeAge As Integer = Integer.Parse(AgeTxt.Text.Trim())
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim()
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = ContactTxt.Text.Trim()
        Dim employeeAddress As String = AddressTxt.Text.Trim()
        Dim employeeCardNumber As String = CardNumberTxt.Text.Trim()
        Dim employeeStatus As String = "EMPLOYED"
        Dim employeeImage As Byte()

        If Not String.IsNullOrWhiteSpace(PictureTxt.Text) AndAlso IO.File.Exists(PictureTxt.Text) Then
            employeeImage = IO.File.ReadAllBytes(PictureTxt.Text)
        Else
            MessageBox.Show("Please select a valid image file.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM employee WHERE ""EmployeeID"" = @EmployeeID OR ""EmployeeCardNumber"" = @EmployeeCardNumber"
                Using checkCmd As New NpgsqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    checkCmd.Parameters.AddWithValue("@EmployeeCardNumber", employeeCardNumber)

                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This resident is already employed.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim query As String = "INSERT INTO employee (""EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", " &
                                  """EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployeeImage"", ""EmployedDate"", ""EmployeeCardNumber"", ""EmployeeStatus"") " &
                                  "VALUES (@EmployeeID, @EmployeeName, @EmployeeAge, @EmployeePosition, @EmployeeDaySchedule, " &
                                  "@EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress, @EmployeeImage, CURRENT_DATE, @EmployeeCardNumber, @EmployeeStatus)"

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    cmd.Parameters.AddWithValue("@EmployeeAge", employeeAge)
                    cmd.Parameters.AddWithValue("@EmployeePosition", employeePosition)
                    cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeDaySchedule)
                    cmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeTimeShift)
                    cmd.Parameters.AddWithValue("@EmployeeMobile", employeeMobile)
                    cmd.Parameters.AddWithValue("@EmployeeAddress", employeeAddress)
                    cmd.Parameters.AddWithValue("@EmployeeImage", employeeImage)
                    cmd.Parameters.AddWithValue("@EmployeeCardNumber", employeeCardNumber)
                    cmd.Parameters.AddWithValue("@EmployeeStatus", employeeStatus)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private PositionValues As New Dictionary(Of String, String) From {
       {"Admin Staff", "01"}, {"Secretary (HRMO)", "02"}, {"BPSO", "03"}, {"Clerk", "04"}, {"Medical Aide", "05"}
    }

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        SelectImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        SelectImage.Title = "Select an Image"

        If SelectImage.ShowDialog() = DialogResult.OK Then
            PictureTxt.Text = SelectImage.FileName
        End If
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim StaffDB As New StaffDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(StaffDB)
        Me.Close()
    End Sub

End Class