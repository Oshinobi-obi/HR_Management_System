Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class EditStaff

    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;Username=doadmin;Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;SSL Mode=Require"

    Public Sub EditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeButton(ReturnBtn, "RETURN", Color.LightCoral)
        InitializeButton(UpdateStaffBtn, "UPDATE STAFF", Color.LightGreen)
        InitializeButton(OpenBtn, "OPEN", Color.LightGreen)

        LoadPositionItems()  ' This should be added here
        LoadEmployeeIDs()
    End Sub


    Private Sub LoadPositionItems()
        PosCmb.Items.Clear()
        PosCmb.Items.AddRange(New String() {"Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV",
                                        "BNS", "BPSO", "Clerk", "Lupon Tagapamayapa", "Medical Aide",
                                        "Sangguniang Kabataan", "Secretary"})
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
        If EmIDCmb.SelectedItem IsNot Nothing Then
            Dim selectedID As String = EmIDCmb.SelectedItem.ToString().Trim()
            LoadEmployeeData(selectedID)
        End If
    End Sub

    Private Sub LoadEmployeeData(employeeID As String)
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", " &
                                """EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"", ""EmployeeImage"" " &
                                "FROM employee WHERE ""EmployeeID"" = @EmployeeID"
                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the text fields with data from the database
                            StaffNameTxt.Text = reader("EmployeeName").ToString()
                            StaffAgeTxt.Text = reader("EmployeeAge").ToString()
                            WorkDayTxt.Text = reader("EmployeeDaySchedule").ToString()
                            HrShiftTxt.Text = reader("EmployeeTimeShift").ToString()
                            StaffContactTxt.Text = reader("EmployeeMobile").ToString()
                            StaffAddressTxt.Text = reader("EmployeeAddress").ToString()

                            ' Load position items if not already loaded
                            LoadPositionItems()
                            Dim position As String = reader("EmployeePosition").ToString().Trim()

                            ' Debug: Print out all items in PosCmb to verify they are loaded
                            Console.WriteLine("PosCmb Items:")
                            For Each item As Object In PosCmb.Items
                                Console.WriteLine(item.ToString())
                            Next

                            ' Attempt to set PosCmb based on database position
                            Dim index As Integer = PosCmb.Items.IndexOf(position)
                            If index >= 0 Then
                                PosCmb.SelectedIndex = index
                            Else
                                MessageBox.Show("Position '" & position & "' not found in PosCmb.")
                            End If

                            ' Load image if available
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
        Dim staffDBForm As New StaffDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(staffDBForm)
        Me.Close()
    End Sub

    Private Sub UpdateEmployeeData()
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim sql As String = "UPDATE employee SET ""EmployeeName"" = @EmployeeName, ""EmployeeAge"" = @EmployeeAge, " &
                                """EmployeePosition"" = @EmployeePosition, ""EmployeeDaySchedule"" = @EmployeeDaySchedule, " &
                                """EmployeeTimeShift"" = @EmployeeTimeShift, ""EmployeeMobile"" = @EmployeeMobile, " &
                                """EmployeeAddress"" = @EmployeeAddress, ""EmployeeImage"" = @EmployeeImage " &
                                "WHERE ""EmployeeID"" = @EmployeeID"

                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@EmployeeName", StaffNameTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeAge", Convert.ToInt32(StaffAgeTxt.Text.Trim()))
                    cmd.Parameters.AddWithValue("@EmployeePosition", PosCmb.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@EmployeeDaySchedule", WorkDayTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeTimeShift", HrShiftTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeMobile", StaffContactTxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmployeeAddress", StaffAddressTxt.Text.Trim())

                    If Not String.IsNullOrEmpty(PictureTxt.Text) Then
                        Dim imageBytes As Byte() = System.IO.File.ReadAllBytes(PictureTxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@EmployeeImage", imageBytes)
                    Else
                        cmd.Parameters.AddWithValue("@EmployeeImage", DBNull.Value)
                    End If

                    cmd.Parameters.AddWithValue("@EmployeeID", EmIDCmb.SelectedItem.ToString().Trim())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Employee data updated successfully.")

                    Dim staffDBForm As New StaffDB()
                    CType(Me.MdiParent, MDIParent).LoadFormInMDI(staffDBForm)
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating employee data: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateStaffBtn_Click(sender As Object, e As EventArgs) Handles UpdateStaffBtn.Click
        UpdateEmployeeData()
    End Sub

End Class