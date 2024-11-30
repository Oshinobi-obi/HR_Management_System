Imports System.Drawing.Drawing2D

Public Class Welcome

    Public Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.BackColor = Color.Transparent
        LoginBtn.Text = "LOGIN"

        TimeBtn.FlatStyle = FlatStyle.Flat
        TimeBtn.FlatAppearance.BorderSize = 0
        TimeBtn.BackColor = Color.Transparent
        TimeBtn.Text = "TIME-IN"

        AddHandler LoginBtn.Paint, AddressOf LoginBtn_Paint
        AddHandler TimeBtn.Paint, AddressOf TimeBtn_Paint
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

    Private Sub TimeBtn_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim loginForm As New HRLogin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(loginForm)
        Me.Close()
    End Sub

    Private Sub TimeBtn_Click(sender As Object, e As EventArgs) Handles TimeBtn.Click
        Dim attendanceForm As New HRAttendance()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(attendanceForm)
    End Sub

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to shut down the program?", "Shutdown Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If Me.MdiParent IsNot Nothing Then
                Me.MdiParent.Close()
            End If
            Me.Close()
        End If
    End Sub
End Class