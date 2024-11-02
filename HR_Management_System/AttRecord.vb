Public Class AttRecord
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim adminForm As New Admin()
        adminForm.Show()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Close
            Dim loginForm As New Login
            loginForm.Show
        End If
    End Sub
End Class