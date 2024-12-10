Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles

Public Class HRAdmin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.BackColor = Color.Transparent

        AttBtn.FlatStyle = FlatStyle.Flat
        AttBtn.FlatAppearance.BorderSize = 0
        AttBtn.BackColor = Color.Transparent

        VSBtn.FlatStyle = FlatStyle.Flat
        VSBtn.FlatAppearance.BorderSize = 0
        VSBtn.BackColor = Color.Transparent

        AddHandler LogOutBtn.Paint, AddressOf LogOutBtn_Paint
        AddHandler AttBtn.Paint, AddressOf AttBtn_Paint
        AddHandler VSBtn.Paint, AddressOf VSBtn_Paint

    End Sub

    Private Sub LoadFormInPanel(form As Form)
        MainPanel.Controls.Clear()

        form.TopLevel = False
        form.ControlBox = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        MainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub LogOutBtn_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub AttBtn_Paint(sender As Object, e As PaintEventArgs)
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

        Using brush As New SolidBrush(Color.White)
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

    Private Sub VSBtn_Paint(sender As Object, e As PaintEventArgs)
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

        Using brush As New SolidBrush(Color.White)
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

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(employeeName As String)
        InitializeComponent()
        NameTxt.Text = employeeName
        NameTxt.TextAlign = HorizontalAlignment.Center
        NameTxt.BorderStyle = BorderStyle.None
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New HRLogin
            CType(MdiParent, MDIParent).LoadFormInMDI(loginForm)
            Close()
        End If
    End Sub

    Private Sub AttBtn_Click(sender As Object, e As EventArgs) Handles AttBtn.Click
        Dim attRecordForm As New HRAttRecord
        LoadFormInPanel(attRecordForm)
        Me.Close()
    End Sub

    Private Sub VSBtn_Click(sender As Object, e As EventArgs) Handles VSBtn.Click
        Dim staffDBForm As New HRStaffDB(MainPanel)
        LoadFormInPanel(staffDBForm)
        Me.Close()
    End Sub

    Private Sub SecurityBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SecurityBtn.LinkClicked
        Dim securitySettingsForm As New HRSecuritySettings(HRLogin.LoggedInEmployeeID)
        LoadFormInPanel(securitySettingsForm)
    End Sub

End Class