Imports System.Drawing.Drawing2D
Imports Npgsql


Public Class HRLogin
    Public Shared LoggedInEmployeeID As String

    Private Const SystemID As Integer = 2

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.OpenConnection()
        DatabaseConnection.CloseConnection()

        Passtxt.PasswordChar = "*"c
        Passtxt.UseSystemPasswordChar = False

        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.BackColor = Color.Transparent
        LoginBtn.Text = "Login"

        StaffLoginPanel.GetType().InvokeMember("DoubleBuffered",
                                               Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.SetProperty,
                                               Nothing, StaffLoginPanel, New Object() {True})

        AddHandler LoginBtn.Paint, AddressOf LoginBtn_Paint
        Clock.Start()

        StaffLoginPanel.BringToFront()
    End Sub

    Private Sub LoginBtn_Paint(sender As Object, e As PaintEventArgs)
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

        Using brush As New SolidBrush(Color.FromArgb(&HFF, &HF, &HF, &H46))
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

    Private Sub DrawRoundedPanelBorder(graphics As Graphics, panel As Panel, cornerRadius As Integer, borderSize As Integer)
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As New GraphicsPath()
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
            path.AddArc(panel.Width - cornerRadius * 2 - 1, 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
            path.AddArc(panel.Width - cornerRadius * 2 - 1, panel.Height - cornerRadius * 2 - 1, cornerRadius * 2, cornerRadius * 2, 0, 90)
            path.AddArc(0, panel.Height - cornerRadius * 2 - 1, cornerRadius * 2, cornerRadius * 2, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(panel.BackColor)
                graphics.FillPath(brush, path)
            End Using

            Using pen As New Pen(Color.Black, borderSize)
                graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    Private Function ValidateCredentials(employeeID As String, password As String) As Boolean
        Try
            DatabaseConnection.OpenConnection()

            Dim accountQuery As String = "SELECT COUNT(*) FROM ""Account"" WHERE ""EmployeeID"" = @EmployeeID AND ""Password"" = @Password AND ""Status"" = 'ACTIVE'"
            Using accountCmd As New NpgsqlCommand(accountQuery, DatabaseConnection.conn)
                accountCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                accountCmd.Parameters.AddWithValue("@Password", password)

                Dim accountResult As Integer = Convert.ToInt32(accountCmd.ExecuteScalar())
                Return accountResult > 0
            End Using
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message)
            Return False
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Function

    Private Sub LogLoginAttempt(employeeID As String, password As String, loginStatus As String)
        Try
            DatabaseConnection.OpenConnection()

            Dim insertQuery As String = "INSERT INTO ""Login_Attempt"" (""SystemID"", ""EmployeeID"", ""Password"", ""Login_Status"", ""Date_Of_Attempt"", ""Time"") " &
                                        "VALUES (@SystemID, @EmployeeID, @Password, @LoginStatus, CURRENT_DATE, CURRENT_TIME)"
            Using cmd As New NpgsqlCommand(insertQuery, DatabaseConnection.conn)
                cmd.Parameters.AddWithValue("@SystemID", SystemID)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@LoginStatus", loginStatus)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error login attempt: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub

    Private Sub ResetLoginFields()
        StaffIDtxt.Clear()
        Passtxt.Clear()
        StaffIDtxt.Focus()
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        TimeLbl.Text = DateTime.Now.ToString("hh:mm")
        AmPmLbl.Text = DateTime.Now.ToString("tt").ToUpper()
        DateLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to leave the application?",
                                                 "Are you leaving?",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Thank you for using the HRMS!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Me.MdiParent IsNot Nothing Then
                Me.MdiParent.Close()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim employeeID = StaffIDtxt.Text.Trim
        Dim password = Passtxt.Text.Trim
        Dim loginStatus = "INCORRECT PASSWORD"

        Try
            If Not System.Text.RegularExpressions.Regex.IsMatch(employeeID, "^02-\d{2}-\d{2}-\d{2}$") Then
                MsgBox("Invalid EmployeeID format.", MsgBoxStyle.Exclamation, "Validation Error")
                LogLoginAttempt(employeeID, password, "NO PERMISSION")
                ResetLoginFields()
                Return
            End If

            Dim isValid = ValidateCredentials(employeeID, password)
            If isValid Then
                If IsDefaultPassword(employeeID) Then
                    MessageBox.Show("One Time Password has not been changed! Please change your password before proceeding!",
                                "Change Password Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                    Dim changePasswordForm As New outFrmChangePassword(employeeID)
                    CType(Me.MdiParent, MDIParent).LoadFormInMDI(changePasswordForm)
                    Me.Close()
                    Return
                End If

                LoggedInEmployeeID = employeeID
                CType(MdiParent, MDIParent).LoggedInEmployeeID = employeeID

                loginStatus = "SUCCESSFUL"
                Dim adminForm As New HRAdmin(employeeID)
                CType(MdiParent, MDIParent).LoadFormInMDI(adminForm)
                Close()
            Else
                MsgBox("Wrong credentials.", MsgBoxStyle.Exclamation, "Login Failed")
            End If

        Catch ex As Exception
            MsgBox("Error validating credentials: " & ex.Message)
        Finally
            LogLoginAttempt(employeeID, password, loginStatus)
            ResetLoginFields()
        End Try
    End Sub

    Private Function IsDefaultPassword(employeeID As String) As Boolean
        Try
            DatabaseConnection.OpenConnection()

            Dim query As String = "SELECT ""isDefaultPassword"" FROM ""Account"" WHERE ""EmployeeID"" = @EmployeeID"
            Using cmd As New NpgsqlCommand(query, DatabaseConnection.conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Convert.ToBoolean(result) Then
                    Return True
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error checking default password: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try

        Return False
    End Function

    Private Sub StaffLoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles StaffLoginPanel.Paint
        DrawRoundedPanelBorder(e.Graphics, StaffLoginPanel, 20, 2)
    End Sub
End Class