Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class HRAddStaff
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"


    Private positionMap As New Dictionary(Of String, String)() ' Map to store position names and codes

        Public Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InitializeButton(ReturnBtn, "RETURN", Color.LightCoral)
            InitializeButton(AddStaffBtn, "ADD STAFF", Color.LightGreen)
            InitializeButton(OpenBtn, "ADD", Color.LightGreen)
            ToggleControls(True)
            LoadPositions() ' Load positions dynamically
        End Sub

        Private Sub ToggleControls(isEnabled As Boolean)
            ' Enable or disable controls based on isEnabled
            Dim controls As Control() = {ResidentIDTxt, FirstNameTxt, MiddleNameTxt, LastNameTxt, AgeTxt, GenderTxt, ContactTxt, AddressTxt, EmIDTxt}
            Dim backColor As Color = If(isEnabled, Color.White, Color.LightGray)

            For Each ctrl As Control In controls
                ctrl.Enabled = isEnabled
                ctrl.BackColor = backColor
            Next
        End Sub

        Private Sub ClearFields()
            ' Clear input fields
            Dim controls As Control() = {ResidentIDTxt, FirstNameTxt, MiddleNameTxt, LastNameTxt, AgeTxt, GenderTxt, ContactTxt, AddressTxt, EmIDTxt, WorkDayTxt, HrShiftTxt, PictureTxt, CardNumberTxt}
            For Each ctrl As Control In controls
                ctrl.Text = String.Empty
            Next
            PosCmb.SelectedIndex = -1
        End Sub

        Private Sub EnableWorkDetails()
            ' Enable work-related fields
            Dim controls As Control() = {WorkDayTxt, HrShiftTxt, PosCmb}
            For Each ctrl As Control In controls
                ctrl.Enabled = True
                ctrl.BackColor = Color.White
            Next
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

    Public Sub LoadPositions()
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT positionname, positioncode FROM employeeposition ORDER BY positionname"
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        PosCmb.Items.Clear()
                        positionMap.Clear()

                        While reader.Read()
                            Dim positionName As String = reader("positionname").ToString().Trim()
                            Dim positionCode As String = reader("positioncode").ToString().Trim()

                            ' Add position name to ComboBox and map its code
                            PosCmb.Items.Add(positionName)
                            positionMap(positionName) = positionCode
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading positions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PosCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosCmb.SelectedIndexChanged
        If PosCmb.SelectedItem IsNot Nothing Then
            Dim selectedPositionName As String = PosCmb.SelectedItem.ToString()
            Dim positionCode As String = positionMap(selectedPositionName)

            Dim firstLetter As String = If(FirstNameTxt.Text.Length > 0, FirstNameTxt.Text.Substring(0, 1).ToUpper(), "A")
            Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
            Dim age As String = AgeTxt.Text.Trim()

            If IsNumeric(age) Then
                Dim incrementingNumber As Integer = GetNextEmployeeID()
                Dim employeeID As String = $"{positionCode}-{firstLetterNumber}-{age}-{incrementingNumber:D2}"

                ' Check if the EmployeeID already exists in the database
                If Not EmployeeIDExists(employeeID) Then
                    EmIDTxt.Text = employeeID
                Else
                    MessageBox.Show("Generated EmployeeID already exists. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter a valid age.")
            End If
        End If
    End Sub

    Private Function EmployeeIDExists(employeeID As String) As Boolean
        Using conn As New NpgsqlConnection(connString)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM employee WHERE ""EmployeeID"" = @EmployeeID"
            Using cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function


    Private Function GetAlphabetPosition(letter As String) As String
            Return (Asc(letter.ToUpper()) - Asc("A"c) + 1).ToString("D2")
        End Function

    Private Function GetNextEmployeeID() As Integer
        Using conn As New NpgsqlConnection(connString)
            conn.Open()
            ' Query to get the last numeric part of the EmployeeID
            Dim query As String = "SELECT COALESCE(MAX(CAST(SUBSTRING(""EmployeeID"" FROM '[0-9]+$') AS INTEGER)), 0) + 1 FROM employee"
            Using cmd As New NpgsqlCommand(query, conn)
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function


    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        If String.IsNullOrWhiteSpace(FirstNameTxt.Text) OrElse String.IsNullOrWhiteSpace(AgeTxt.Text) OrElse PosCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure the selected position exists in positionMap
        Dim positionCode As String = If(positionMap.ContainsKey(PosCmb.SelectedItem.ToString()), positionMap(PosCmb.SelectedItem.ToString()), String.Empty)
        If String.IsNullOrEmpty(positionCode) Then
            MessageBox.Show("Selected position is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO employee (" &
                      """EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""Sex"", ""EmployeePosition"", " &
                      """EmployeeDaySchedule"", ""EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", " &
                      """EmployedDate"", ""EmployeeCardNumber"", ""EmployeeStatus"", ""Resident_ID"") " &
                      "VALUES (@EmployeeID, @EmployeeName, @EmployeeAge, @Sex, @EmployeePosition, @EmployeeDaySchedule, " &
                      "@EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress, CURRENT_DATE, @EmployeeCardNumber, " &
                      "'EMPLOYED', @Resident_ID)"



                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", EmIDTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeName", $"{FirstNameTxt.Text.Trim()} {MiddleNameTxt.Text.Trim()} {LastNameTxt.Text.Trim()}")
                    cmd.Parameters.AddWithValue("@EmployeeAge", Integer.Parse(AgeTxt.Text))
                    cmd.Parameters.AddWithValue("@Sex", GenderTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeePosition", PosCmb.SelectedItem.ToString()) ' Store position name
                    cmd.Parameters.AddWithValue("@EmployeeDaySchedule", WorkDayTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeTimeShift", HrShiftTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeMobile", ContactTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeAddress", AddressTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeCardNumber", CardNumberTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@Resident_ID", Integer.Parse(ResidentIDTxt.Text.Trim()))

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetResidentData(residentId As String, firstName As String, middleName As String, lastName As String, age As String, gender As String, contactNumber As String, address As String)
            ResidentIDTxt.Text = residentId
            FirstNameTxt.Text = firstName
            MiddleNameTxt.Text = middleName
            LastNameTxt.Text = lastName
            AgeTxt.Text = age
            GenderTxt.Text = gender
            ContactTxt.Text = contactNumber
            AddressTxt.Text = address
            ToggleControls(False)
            EnableWorkDetails()
        End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        SelectImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        SelectImage.Title = "Select an Image"

        If SelectImage.ShowDialog() = DialogResult.OK Then
            PictureTxt.Text = SelectImage.FileName
        End If
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim residentDBForm As New HRResidentDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(residentDBForm)
        Me.Close()
    End Sub
End Class
