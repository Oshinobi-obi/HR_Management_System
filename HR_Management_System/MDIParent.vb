﻿Public Class MDIParent
    Public Property LoggedInEmployeeID As String
    Private Sub MDIParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Dim loginForm As New HRLogin()
        LoadFormInMDI(loginForm)
    End Sub

    Public Sub LoadFormInMDI(formToLoad As Form)
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        formToLoad.MdiParent = Me
        formToLoad.Show()
    End Sub
End Class