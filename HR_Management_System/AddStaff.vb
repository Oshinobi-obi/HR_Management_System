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
        Dim residentName As String = StaffNameTxt.Text.Trim()

        If String.IsNullOrEmpty(residentName) Then
            MessageBox.Show("Please enter a name to check.")
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT ""ResidentName"", ""ResidentAge"", ""ResidentContact"", ""ResidentAddress"" FROM resident WHERE ""ResidentName"" = @ResidentName"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ResidentName", residentName)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            MessageBox.Show("This person is a resident.")
                            StaffNameTxt.Text = reader("ResidentName").ToString()
                            StaffAgeTxt.Text = reader("ResidentAge").ToString()
                            StaffContactTxt.Text = reader("ResidentContact").ToString()
                            StaffAddressTxt.Text = reader("ResidentAddress").ToString()
                        Else
                            MessageBox.Show("This person is not a resident.")
                            Me.Close()
                            Dim addStaffForm As New AddStaff()
                            addStaffForm.Show()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking resident information: " & ex.Message)
        End Try
    End Sub

    Private Sub StaffNameTxt_LostFocus(sender As Object, e As EventArgs) Handles StaffNameTxt.LostFocus
        CheckIfResident()
    End Sub

    Private Sub PosCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosCmb.SelectedIndexChanged
        If PosCmb.SelectedItem IsNot Nothing Then
            Dim selectedPosition As String = PosCmb.SelectedItem.ToString()
            Dim positionCode As String = PositionValues(selectedPosition)
            Dim firstLetter As String = If(StaffNameTxt.Text.Length > 0, StaffNameTxt.Text.Substring(0, 1).ToUpper(), "A")
            Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
            Dim age As String = StaffAgeTxt.Text.Trim()

            If IsNumeric(age) Then
                Dim incrementingNumber As Integer = GetNextEmployeeID()
                Dim employeeID As String = $"{positionCode}-{firstLetterNumber}-{age}-{incrementingNumber:D2}"
                EmIDTxt.Text = employeeID
            Else
                MessageBox.Show("Please enter a valid age.")
            End If

            If selectedPosition = "Secretary" Then
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
        Dim employeeName As String = StaffNameTxt.Text.Trim()
        Dim employeeAge As String = StaffAgeTxt.Text.Trim()
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim()
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = StaffContactTxt.Text.Trim()
        Dim employeeAddress As String = StaffAddressTxt.Text.Trim()
        Dim employeeImage As String = PictureTxt.Text.Trim()

        If String.IsNullOrEmpty(employeeName) OrElse String.IsNullOrEmpty(employeeAge) OrElse String.IsNullOrEmpty(employeePosition) Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim imageBytes As Byte() = System.IO.File.ReadAllBytes(employeeImage)
                Dim query As String = "INSERT INTO employee (""EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployeeImage"", ""EmployedDate"") " &
                                  "VALUES (@EmployeeID, @EmployeeName, @EmployeeAge, @EmployeePosition, @EmployeeDaySchedule, @EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress, @EmployeeImage, CURRENT_DATE)"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", EmIDTxt.Text)
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    cmd.Parameters.AddWithValue("@EmployeeAge", employeeAge)
                    cmd.Parameters.AddWithValue("@EmployeePosition", employeePosition)
                    cmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeDaySchedule)
                    cmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeTimeShift)
                    cmd.Parameters.AddWithValue("@EmployeeMobile", employeeMobile)
                    cmd.Parameters.AddWithValue("@EmployeeAddress", employeeAddress)
                    cmd.Parameters.AddWithValue("@EmployeeImage", imageBytes)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff added successfully.")

                    EmIDTxt.Text = ""
                    StaffNameTxt.Text = ""
                    StaffAgeTxt.Text = ""
                    PosCmb.SelectedText = ""
                    WorkDayTxt.Text = ""
                    HrShiftTxt.Text = ""
                    StaffContactTxt.Text = ""
                    StaffAddressTxt.Text = ""
                    PictureTxt.Text = ""
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding staff: " & ex.Message)
        End Try
    End Sub

    Private PositionValues As New Dictionary(Of String, String) From {
        {"Admin Aide I", "11"}, {"Admin Aide II", "14"}, {"Admin Aide III", "12"},
        {"Admin Aide IV", "13"}, {"BNS", "09"}, {"BPSO", "03"}, {"Clerk", "04"},
        {"Lupon Tagapamayapa", "08"}, {"Medical Aide", "05"}, {"Sangguniang Kabataan", "06"},
        {"Secretary", "02"}
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