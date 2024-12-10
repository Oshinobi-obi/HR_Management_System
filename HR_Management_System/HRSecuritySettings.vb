Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class HRSecuritySettings
    Private loggedInEmployeeID As String
    Private Sub SecuritySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OldPassTxt.PasswordChar = "*"c
        OldPassTxt.UseSystemPasswordChar = False
        NewPassTxt.PasswordChar = "*"c
        NewPassTxt.UseSystemPasswordChar = False

        ReturnBtn.FlatStyle = FlatStyle.Flat
        ReturnBtn.FlatAppearance.BorderSize = 0
        ReturnBtn.BackColor = Color.Transparent
        ReturnBtn.Text = "RETURN"

        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.BackColor = Color.Transparent
        SaveBtn.Text = "SAVE"

        AddHandler ReturnBtn.Paint, AddressOf ReturnBtn_Paint
        AddHandler SaveBtn.Paint, AddressOf SaveBtn_Paint

        SecurityPanel.BringToFront()
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

    Private Sub SaveBtn_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim oldPassword As String = OldPassTxt.Text.Trim()
        Dim newPassword As String = NewPassTxt.Text.Trim()

        If String.IsNullOrEmpty(oldPassword) Or String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter both old and new passwords.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UpdatePassword(oldPassword, newPassword) Then
            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim adminForm As New HRAdmin()
            CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
            Me.Close()
        Else
            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function UpdatePassword(oldPassword As String, newPassword As String) As Boolean
        Dim isSuccess As Boolean = False

        Try
            DatabaseConnection.OpenConnection()

            Dim employeeID As String = GetLoggedInEmployeeID()

            Dim query As String = "SELECT COUNT(*) FROM ""Account"" WHERE ""EmployeeID"" = @EmployeeID AND ""Password"" = @OldPassword"
            Using cmd As New NpgsqlCommand(query, DatabaseConnection.conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                cmd.Parameters.AddWithValue("@OldPassword", oldPassword)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    Dim updateQuery As String = "UPDATE ""Account"" SET ""Password"" = @NewPassword WHERE ""EmployeeID"" = @EmployeeID"
                    Using updateCmd As New NpgsqlCommand(updateQuery, DatabaseConnection.conn)
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword)
                        updateCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                        updateCmd.ExecuteNonQuery()
                        isSuccess = True
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DatabaseConnection.CloseConnection()
        End Try

        Return isSuccess
    End Function

    Public Sub New(employeeID As String)
        InitializeComponent()
        loggedInEmployeeID = employeeID
    End Sub

    Private Function GetLoggedInEmployeeID() As String
        If String.IsNullOrEmpty(HRLogin.LoggedInEmployeeID) Then
            Throw New Exception("No logged-in user found.")
        End If
        Return HRLogin.LoggedInEmployeeID
    End Function

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim adminForm As New HRAdmin(HRLogin.LoggedInEmployeeID)
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
        Me.Close()
    End Sub

    Private Sub SecurityPanel_Paint(sender As Object, e As PaintEventArgs) Handles SecurityPanel.Paint
        DrawRoundedPanelBorder(e.Graphics, SecurityPanel, 20, 2)
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
End Class