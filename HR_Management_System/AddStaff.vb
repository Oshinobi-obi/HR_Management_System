﻿Imports System.Drawing.Drawing2D
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
        Dim residentID As String = ResidentIDTxt.Text.Trim()

        If String.IsNullOrEmpty(residentID) Then
            MessageBox.Show("Please enter resident ID to check.")
            Return
        End If

        Try
            Dim parsedResidentID As Long
            If Not Long.TryParse(residentID, parsedResidentID) Then
                MessageBox.Show("Please enter a valid resident ID number.")
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
                            MessageBox.Show("This person is a resident.")

                            FirstNameTxt.Text = reader("First_Name").ToString()
                            MiddleNameTxt.Text = reader("Middle_Name").ToString()
                            LastNameTxt.Text = reader("Last_Name").ToString()

                            Dim dateOfBirth As DateTime = Convert.ToDateTime(reader("Date_Of_Birth"))
                            Dim age As Integer = DateTime.Now.Year - dateOfBirth.Year
                            If (DateTime.Now.Month < dateOfBirth.Month OrElse (DateTime.Now.Month = dateOfBirth.Month AndAlso DateTime.Now.Day < dateOfBirth.Day)) Then
                                age -= 1
                            End If
                            StaffAgeTxt.Text = age.ToString()
                            GenderTxt.Text = reader("Sex").ToString()
                            StaffContactTxt.Text = reader("Contact_Number").ToString()
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

    Private Sub ResidentIDTxt_LostFocus(sender As Object, e As EventArgs) Handles ResidentIDTxt.LostFocus
        CheckIfResident()
    End Sub



    Private Sub PosCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosCmb.SelectedIndexChanged
        If PosCmb.SelectedItem IsNot Nothing Then
            Dim selectedPosition As String = PosCmb.SelectedItem.ToString()
            Dim positionCode As String = PositionValues(selectedPosition)
            Dim firstLetter As String = If(FirstNameTxt.Text.Length > 0, FirstNameTxt.Text.Substring(0, 1).ToUpper(), "A")
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
        Dim employeeName As String = FirstNameTxt.Text.Trim()
        Dim employeeAge As String = StaffAgeTxt.Text.Trim()
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim()
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = StaffContactTxt.Text.Trim()
        Dim employeeAddress As String = StaffAddressTxt.Text.Trim()
        Dim employeeImage As String = PictureTxt.Text.Trim()
        Dim employeeCardNumber As String = CardNumberTxt.Text.Trim()

        If String.IsNullOrEmpty(employeeName) OrElse String.IsNullOrEmpty(employeeAge) OrElse String.IsNullOrEmpty(employeePosition) Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim imageBytes As Byte() = System.IO.File.ReadAllBytes(employeeImage)
                Dim query As String = "INSERT INTO employee (""EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployeeImage"", ""EmployedDate"", ""EmployeeCardNumber"") " &
                                  "VALUES (@EmployeeID, @EmployeeName, @EmployeeAge, @EmployeePosition, @EmployeeDaySchedule, @EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress, @EmployeeImage, @EmployeeCardNumber, CURRENT_DATE)"
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
                    cmd.Parameters.AddWithValue("@EmployeeCardNumber", employeeCardNumber)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff added successfully.")

                    Me.Close()
                    Dim AddStaffAgain As New AddStaff()
                    AddStaffAgain.Show()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding staff: " & ex.Message)
        End Try
    End Sub

    Private PositionValues As New Dictionary(Of String, String) From {
        {"Secretary", "02"}, {"BPSO", "03"}, {"Clerk", "04"}, {"Medical Aide", "05"},
        {"Sangguniang Kabataan", "06"}
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