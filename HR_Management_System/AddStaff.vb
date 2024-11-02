Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Npgsql

Public Class AddStaff
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"
    Public Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReturnBtn.FlatStyle = FlatStyle.Flat
        ReturnBtn.FlatAppearance.BorderSize = 0
        ReturnBtn.BackColor = Color.Transparent
        ReturnBtn.Text = "RETURN"

        AddStaffBtn.FlatStyle = FlatStyle.Flat
        AddStaffBtn.FlatAppearance.BorderSize = 0
        AddStaffBtn.BackColor = Color.Transparent
        AddStaffBtn.Text = "ADD STAFF"

        AddHandler ReturnBtn.Paint, AddressOf ReturnBtn_Paint
        AddHandler AddStaffBtn.Paint, AddressOf AddStaffBtn_Paint
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

    Private Sub AddStaffBtn_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Close()
        Dim StaffDB As New StaffDB
        StaffDB.Show()
    End Sub

    Private Sub AddStaffPanel_Paint(sender As Object, e As PaintEventArgs) Handles AddStaffPanel.Paint
        DrawRoundedPanelBorder(e.Graphics, AddStaffPanel, 20, 2)
    End Sub

    Private Sub DrawRoundedPanelBorder(graphics As Graphics, panel As Panel, cornerRadius As Integer, borderSize As Integer)
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        Using path As New GraphicsPath()
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
            path.AddArc(panel.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90)
            path.AddArc(panel.Width - cornerRadius - 1, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90)
            path.AddArc(0, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(panel.BackColor)
                graphics.FillPath(brush, path)
            End Using

            Using pen As New Pen(Color.Black, borderSize)
                graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    Private Sub StaffNameTxt_TextChanged(sender As Object, e As EventArgs) Handles StaffNameTxt.TextChanged
        Dim residentName As String = StaffNameTxt.Text.Trim()

        If String.IsNullOrEmpty(residentName) Then
            StaffAgeTxt.Clear()
            StaffContactTxt.Clear()
            StaffAddressTxt.Clear()
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT ""ResidentAge"", ""ResidentContact"", ""ResidentAddress"" FROM resident WHERE ""ResidentName"" = @name"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", residentName)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            StaffAgeTxt.Text = reader("ResidentAge").ToString()
                            StaffContactTxt.Text = reader("ResidentContact").ToString()
                            StaffAddressTxt.Text = reader("ResidentAddress").ToString()
                        Else
                            StaffAgeTxt.Clear()
                            StaffContactTxt.Clear()
                            StaffAddressTxt.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        End Try
    End Sub

    Private PositionValues As New Dictionary(Of String, String) From {
    {"Admin Aide I", "11"},
    {"Admin Aide II", "14"},
    {"Admin Aide III", "12"},
    {"Admin Aide IV", "13"},
    {"BNS", "09"},
    {"BPSO", "03"},
    {"Clerk", "04"},
    {"Lupon Tagapamayapa", "08"},
    {"Medical Aide", "05"},
    {"Sangguniang Kabataan", "06"},
    {"Secretary", "02"}
}

    Private Sub PosCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosCmb.SelectedIndexChanged
        If PosCmb.SelectedItem IsNot Nothing Then
            Dim selectedPosition As String = PosCmb.SelectedItem.ToString()
            Dim positionValue As String = ""

            If PositionValues.TryGetValue(selectedPosition, positionValue) Then
                Dim firstLetter As String = If(StaffNameTxt.Text.Length > 0, StaffNameTxt.Text.Substring(0, 1).ToUpper(), "A") ' Default to 'A' if no name provided
                Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
                Dim age As String = StaffAgeTxt.Text.Trim()
                Dim employeeID As String = ""

                If IsNumeric(age) Then
                    Dim incrementingNumber As Integer = GetNextEmployeeID()
                    Dim formattedIncrementingNumber As String = incrementingNumber.ToString("D2") ' Format as two digits

                    employeeID = $"{positionValue}-{firstLetterNumber}-{age}-{formattedIncrementingNumber}" ' Format: xx-xx-xx-xx
                    EmIDTxt.Text = employeeID
                Else
                    MessageBox.Show("Please enter a valid age.")
                End If
            Else
                MessageBox.Show("Selected position is not recognized.")
            End If

            If selectedPosition = "Secretary" Then
                HrShiftTxt.Text = "8:00am - 5:00pm"
                HrShiftTxt.ForeColor = Color.Black
            Else
                HrShiftTxt.Text = ""
            End If
        Else
            MessageBox.Show("Please select a position.")
        End If
    End Sub


    Private Function GetAlphabetPosition(letter As String) As String
        Dim position As Integer = Asc(letter.ToUpper()) - Asc("A"c) + 1
        Return position.ToString("D2")
    End Function

    Private Function GetNextEmployeeID() As Integer
        Using conn As New NpgsqlConnection(connString)
            conn.Open()
            Dim query As String = "SELECT COALESCE(MAX(id), 0) FROM employee"
            Using cmd As New NpgsqlCommand(query, conn)
                Dim maxId As Integer = CInt(cmd.ExecuteScalar())
                Return maxId + 1
            End Using
        End Using
    End Function

    Private Sub WorkDayTxt_TextChanged(sender As Object, e As EventArgs) Handles WorkDayTxt.TextChanged

    End Sub

    Private Sub HrShiftTxt_Enter(sender As Object, e As EventArgs) Handles HrShiftTxt.Enter
        If HrShiftTxt.Text = "8:00am - 5:00pm" Then
            HrShiftTxt.Text = ""
            HrShiftTxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub HrShiftTxt_Leave(sender As Object, e As EventArgs) Handles HrShiftTxt.Leave
        Dim selectedPosition As String = PosCmb.SelectedItem?.ToString()

        If selectedPosition = "Secretary" Then
            Dim inputText As String = HrShiftTxt.Text.Trim()
            Dim validFormat As String = "^\d{1,2}:\d{2}(am|pm) - \d{1,2}:\d{2}(am|pm)$"

            If Not System.Text.RegularExpressions.Regex.IsMatch(inputText, validFormat, System.Text.RegularExpressions.RegexOptions.IgnoreCase) Then
                HrShiftTxt.Text = "8:00am - 5:00pm"
                HrShiftTxt.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        Dim employeeName As String = StaffNameTxt.Text.Trim()
        Dim employeeAge As String = StaffAgeTxt.Text.Trim()
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim()
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = StaffContactTxt.Text.Trim()
        Dim employeeAddress As String = StaffAddressTxt.Text.Trim()

        If String.IsNullOrEmpty(employeeName) OrElse String.IsNullOrEmpty(employeeAge) OrElse String.IsNullOrEmpty(employeePosition) Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim maxIdQuery As String = "SELECT MAX(CAST(SUBSTRING(""EmployeeID"" FROM '[0-9]+$') AS INTEGER)) FROM ""employee"""
                Dim lastTwoDigits As Integer = 0

                Using maxIdCmd As New NpgsqlCommand(maxIdQuery, conn)
                    Dim maxIdResult = maxIdCmd.ExecuteScalar()
                    If maxIdResult IsNot DBNull.Value Then
                        lastTwoDigits = Convert.ToInt32(maxIdResult) + 1
                    Else
                        lastTwoDigits = 1
                    End If
                End Using

                Dim positionValue As String = GetPositionValue(employeePosition)
                Dim firstLetter As String = If(employeeName.Length > 0, employeeName.Substring(0, 1).ToUpper(), "A")
                Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
                Dim newEmployeeId As String = $"{positionValue}-{firstLetterNumber}-{employeeAge}-{lastTwoDigits:D2}"
                Dim insertQuery As String = "INSERT INTO ""employee"" (""EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"") " &
                                     "VALUES (@EmployeeId, @EmployeeName, @EmployeeAge, @EmployeePosition, @EmployeeDaySchedule, @EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress)"
                Using insertCmd As New NpgsqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@EmployeeId", newEmployeeId)
                    insertCmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    insertCmd.Parameters.AddWithValue("@EmployeeAge", employeeAge)
                    insertCmd.Parameters.AddWithValue("@EmployeePosition", employeePosition)
                    insertCmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeDaySchedule)
                    insertCmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeTimeShift)
                    insertCmd.Parameters.AddWithValue("@EmployeeMobile", employeeMobile)
                    insertCmd.Parameters.AddWithValue("@EmployeeAddress", employeeAddress)
                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Staff member added successfully!")
                    ClearInputFields()
                    ReloadAddStaffForm()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding staff: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearInputFields()
        StaffNameTxt.Clear()
        StaffAgeTxt.Clear()
        StaffContactTxt.Clear()
        StaffAddressTxt.Clear()
        WorkDayTxt.Clear()
        HrShiftTxt.Text = ""
        PosCmb.SelectedIndex = -1
    End Sub

    Private Sub ReloadAddStaffForm()
        Dim newForm As New AddStaff()
        newForm.Show()
        Me.Close()
    End Sub



    Private Function GetPositionValue(position As String) As String
        Dim positionValues As New Dictionary(Of String, String) From {
            {"Admin Aide I", "11"},
            {"Admin Aide II", "14"},
            {"Admin Aide III", "12"},
            {"Admin Aide IV", "13"},
            {"BNS", "09"},
            {"BPSO", "03"},
            {"Clerk", "04"},
            {"Lupon Tagapamayapa", "08"},
            {"Medical Aide", "05"},
            {"Sangguniang Kabataan", "06"},
            {"Secretary", "02"}
        }

        Dim value As String = ""
        If positionValues.TryGetValue(position, value) Then
            Return value
        End If

        Return "00" ' Return a default value if position is not found
    End Function

End Class