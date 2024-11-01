Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Npgsql ' Make sure you have the Npgsql package installed

Public Class AddStaff
    ' Define your PostgreSQL connection string
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
            ' Clear the textboxes if the input is empty
            StaffAgeTxt.Clear()
            StaffContactTxt.Clear()
            StaffAddressTxt.Clear()
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                ' Update the query to match your actual column names and cases
                Dim query As String = "SELECT ""ResidentAge"", ""ResidentContact"", ""ResidentAddress"" FROM resident WHERE ""ResidentName"" = @name"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", residentName)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the textboxes with resident details
                            StaffAgeTxt.Text = reader("ResidentAge").ToString()
                            StaffContactTxt.Text = reader("ResidentContact").ToString()
                            StaffAddressTxt.Text = reader("ResidentAddress").ToString()
                        Else
                            ' Clear the textboxes if no resident is found
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
        If PosCmb.SelectedItem IsNot Nothing Then ' Check if SelectedItem is not Nothing
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
                    EmIDTxt.Text = employeeID ' Assign to Employee ID TextBox
                Else
                    MessageBox.Show("Please enter a valid age.")
                End If
            Else
                MessageBox.Show("Selected position is not recognized.")
            End If

            ' Default shift for Secretary
            If selectedPosition = "Secretary" Then
                HrShiftTxt.Text = "8:00am - 5:00pm" ' Set default for Secretary
                HrShiftTxt.ForeColor = Color.Black ' Ensure text color is set correctly
            Else
                HrShiftTxt.Text = "" ' Clear for other positions
            End If
        Else
            MessageBox.Show("Please select a position.")
        End If
    End Sub


    Private Function GetAlphabetPosition(letter As String) As String
        ' Convert letter to uppercase and get its alphabetical position (A=01, B=02, ..., Z=26)
        Dim position As Integer = Asc(letter.ToUpper()) - Asc("A"c) + 1
        Return position.ToString("D2") ' Format as two digits (e.g., 01, 02, ..., 26)
    End Function

    Private Function GetNextEmployeeID() As Integer
        Using conn As New NpgsqlConnection(connString)
            conn.Open()
            ' Retrieve the maximum ID from the employee table
            Dim query As String = "SELECT COALESCE(MAX(id), 0) FROM employee" ' Replace 'id' with the actual name of your primary key column
            Using cmd As New NpgsqlCommand(query, conn)
                Dim maxId As Integer = CInt(cmd.ExecuteScalar())
                Return maxId + 1 ' Increment the maximum ID to get the next ID
            End Using
        End Using
    End Function

    Private Sub WorkDayTxt_TextChanged(sender As Object, e As EventArgs) Handles WorkDayTxt.TextChanged

    End Sub

    Private Sub HrShiftTxt_Enter(sender As Object, e As EventArgs) Handles HrShiftTxt.Enter
        ' Allow user to edit without restriction
        If HrShiftTxt.Text = "8:00am - 5:00pm" Then
            HrShiftTxt.Text = "" ' Clear default value for input
            HrShiftTxt.ForeColor = Color.Black ' Change color for input
        End If
    End Sub

    Private Sub HrShiftTxt_Leave(sender As Object, e As EventArgs) Handles HrShiftTxt.Leave
        Dim selectedPosition As String = PosCmb.SelectedItem?.ToString()

        If selectedPosition = "Secretary" Then
            Dim inputText As String = HrShiftTxt.Text.Trim()
            Dim validFormat As String = "^\d{1,2}:\d{2}(am|pm) - \d{1,2}:\d{2}(am|pm)$"

            If Not System.Text.RegularExpressions.Regex.IsMatch(inputText, validFormat, System.Text.RegularExpressions.RegexOptions.IgnoreCase) Then
                HrShiftTxt.Text = "8:00am - 5:00pm" ' Reset to default if input is invalid
                HrShiftTxt.ForeColor = Color.Black ' Reset color
            End If
        End If
    End Sub

    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        ' Retrieve data from input fields
        Dim employeeName As String = StaffNameTxt.Text.Trim()
        Dim employeeAge As String = StaffAgeTxt.Text.Trim()
        Dim employeePosition As String = PosCmb.SelectedItem.ToString()
        Dim employeeDaySchedule As String = WorkDayTxt.Text.Trim() ' Assuming you have this textbox for schedule
        Dim employeeTimeShift As String = HrShiftTxt.Text.Trim()
        Dim employeeMobile As String = StaffContactTxt.Text.Trim()
        Dim employeeAddress As String = StaffAddressTxt.Text.Trim()

        ' Validate input fields
        If String.IsNullOrEmpty(employeeName) OrElse String.IsNullOrEmpty(employeeAge) OrElse String.IsNullOrEmpty(employeePosition) Then
            MessageBox.Show("Please fill all required fields.")
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                ' Fetch the highest EmployeeId
                Dim maxIdQuery As String = "SELECT MAX(CAST(SUBSTRING(""EmployeeID"" FROM '[0-9]+$') AS INTEGER)) FROM ""employee"""
                Dim lastTwoDigits As Integer = 0

                Using maxIdCmd As New NpgsqlCommand(maxIdQuery, conn)
                    Dim maxIdResult = maxIdCmd.ExecuteScalar()
                    If maxIdResult IsNot DBNull.Value Then
                        lastTwoDigits = Convert.ToInt32(maxIdResult) + 1 ' Increment the last two digits
                    Else
                        lastTwoDigits = 1 ' Start from 1 if no EmployeeId exists
                    End If
                End Using

                ' Generate the new EmployeeId
                Dim positionValue As String = GetPositionValue(employeePosition) ' Assuming you have a method to get this
                Dim firstLetter As String = If(employeeName.Length > 0, employeeName.Substring(0, 1).ToUpper(), "A")
                Dim firstLetterNumber As String = GetAlphabetPosition(firstLetter)
                Dim newEmployeeId As String = $"{positionValue}-{firstLetterNumber}-{employeeAge}-{lastTwoDigits:D2}" ' Format: xx-xx-xx-xx

                ' Insert the new staff member
                Dim insertQuery As String = "INSERT INTO ""employee"" (""EmployeeID"", ""EmployeeName"", ""EmployeeAge"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeTimeShift"", ""EmployeeMobile"", ""EmployeeAddress"") " &
                                     "VALUES (@EmployeeId, @EmployeeName, @EmployeeAge, @EmployeePosition, @EmployeeDaySchedule, @EmployeeTimeShift, @EmployeeMobile, @EmployeeAddress)"
                Using insertCmd As New NpgsqlCommand(insertQuery, conn)
                    ' Add parameters to the command
                    insertCmd.Parameters.AddWithValue("@EmployeeId", newEmployeeId)
                    insertCmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    insertCmd.Parameters.AddWithValue("@EmployeeAge", employeeAge)
                    insertCmd.Parameters.AddWithValue("@EmployeePosition", employeePosition)
                    insertCmd.Parameters.AddWithValue("@EmployeeDaySchedule", employeeDaySchedule)
                    insertCmd.Parameters.AddWithValue("@EmployeeTimeShift", employeeTimeShift)
                    insertCmd.Parameters.AddWithValue("@EmployeeMobile", employeeMobile)
                    insertCmd.Parameters.AddWithValue("@EmployeeAddress", employeeAddress)

                    ' Execute the command
                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Staff member added successfully!")

                    ' Clear the input fields
                    ClearInputFields()

                    ' Reload the form to reset EmployeeID and other fields
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
        PosCmb.SelectedIndex = -1 ' Reset the position combo box
    End Sub

    Private Sub ReloadAddStaffForm()
        ' Optionally, you could just clear fields and keep the form open. 
        ' If you want to open a new instance of the form:
        Dim newForm As New AddStaff()
        newForm.Show()
        Me.Close() ' Close the current instance of AddStaff
    End Sub



    Private Function GetPositionValue(position As String) As String
        ' Add your logic to map the position to its respective value
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