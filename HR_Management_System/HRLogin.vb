Imports System.Drawing.Drawing2D
Imports Npgsql


Public Class HRLogin
    Public Shared LoggedInEmployeeID As String

    Private Const SystemID As Integer = 2

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.OpenConnection()
        DatabaseConnection.CloseConnection()

        UserIcon.SizeMode = PictureBoxSizeMode.StretchImage
        PassIcon.SizeMode = PictureBoxSizeMode.StretchImage

        StaffIDtxt.BorderStyle = BorderStyle.None
        Passtxt.BorderStyle = BorderStyle.None

        AddHandler StaffIDPanel.Paint, AddressOf StaffIDPanel_Paint
        AddHandler PassPanel.Paint, AddressOf PassPanel_Paint

        UserIcon.BorderStyle = BorderStyle.None
        PassIcon.BorderStyle = BorderStyle.None

        AddHandler UserIcon.Paint, AddressOf UserIcon_Paint
        AddHandler PassIcon.Paint, AddressOf PassIcon_Paint

        StaffIDtxt.Padding = New Padding(10)
        Passtxt.Padding = New Padding(10)

        Passtxt.PasswordChar = "*"c
        Passtxt.UseSystemPasswordChar = False

        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.BackColor = Color.Transparent
        LoginBtn.Text = "Login"

        AddHandler LoginBtn.Paint, AddressOf LoginBtn_Paint

        StaffLoginPanel.BringToFront()
    End Sub

    Private Sub StaffLoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles StaffLoginPanel.Paint
        DrawRoundedPanelBorder(e.Graphics, StaffLoginPanel, 20, 2)
    End Sub

    Private Sub StaffIDPanel_Paint(sender As Object, e As PaintEventArgs)
        DrawCustomBorder(e.Graphics, StaffIDPanel, 15, 2, roundedRight:=False)
    End Sub

    Private Sub PassPanel_Paint(sender As Object, e As PaintEventArgs)
        DrawCustomBorder(e.Graphics, PassPanel, 15, 2, roundedRight:=False)
    End Sub

    Private Sub UserIcon_Paint(sender As Object, e As PaintEventArgs)
        DrawCustomBorder(e.Graphics, UserIcon, 15, 2, roundedLeft:=False)
    End Sub

    Private Sub PassIcon_Paint(sender As Object, e As PaintEventArgs)
        DrawCustomBorder(e.Graphics, PassIcon, 15, 2, roundedLeft:=False)
    End Sub

    Private Sub DrawCustomBorder(graphics As Graphics, ctrl As Control,
                                 cornerRadius As Integer, borderSize As Integer,
                                 Optional roundedLeft As Boolean = True,
                                 Optional roundedRight As Boolean = True)
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As New GraphicsPath()
            If roundedLeft Then
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
            Else
                path.AddLine(0, 0, cornerRadius, 0)
            End If

            If roundedRight Then
                path.AddArc(ctrl.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90)
            Else
                path.AddLine(ctrl.Width - cornerRadius, 0, ctrl.Width, 0)
            End If

            If roundedRight Then
                path.AddArc(ctrl.Width - cornerRadius - 1, ctrl.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90)
            Else
                path.AddLine(ctrl.Width, cornerRadius, ctrl.Width, ctrl.Height)
            End If

            path.AddLine(ctrl.Width - cornerRadius, ctrl.Height, cornerRadius, ctrl.Height)

            If roundedLeft Then
                path.AddArc(0, ctrl.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90)
            Else
                path.AddLine(0, ctrl.Height, 0, cornerRadius)
            End If

            path.CloseFigure()

            Using pen As New Pen(Color.Black, borderSize)
                graphics.DrawPath(pen, path)
            End Using
        End Using
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

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim employeeID As String = StaffIDtxt.Text.Trim()
        Dim password As String = Passtxt.Text.Trim()
        Dim loginStatus As String = "INCORRECT PASSWORD"

        Try
            If Not System.Text.RegularExpressions.Regex.IsMatch(employeeID, "^02-\d{2}-\d{2}-\d{2}$") Then
                MsgBox("Invalid EmployeeID format.", MsgBoxStyle.Exclamation, "Validation Error")
                LogLoginAttempt(employeeID, password, "NO PERMISSION")
                ResetLoginFields()
                Return
            End If

            Dim isValid As Boolean = ValidateCredentials(employeeID, password)
            If isValid Then
                HRLogin.LoggedInEmployeeID = employeeID
                CType(Me.MdiParent, MDIParent).LoggedInEmployeeID = employeeID

                loginStatus = "SUCCESSFUL"
                Dim adminForm As New HRAdmin(employeeID)
                CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
                Me.Close()
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

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Dim Welcome As New Welcome()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(Welcome)
        Me.Close()
    End Sub
End Class