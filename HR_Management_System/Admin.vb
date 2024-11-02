Imports System.Windows.Forms.VisualStyles

Public Class Admin

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(employeeName As String)
        InitializeComponent()
        NameTxt.Text = employeeName
        NameTxt.TextAlign = ContentAlignment.Center
        NameTxt.TextAlign = HorizontalAlignment.Center
        NameTxt.TextAlign = VerticalAlignment.Center
        NameTxt.BorderStyle = BorderStyle.None
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim loginForm As New Login()
            loginForm.Show()
        End If
    End Sub

    Private Sub SecurityBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SecurityBtn.LinkClicked
        Dim securitySettingsForm As New SecuritySettings()
        securitySettingsForm.Show()
        Me.Hide()
    End Sub

    Private Sub AttBtn_Click(sender As Object, e As EventArgs) Handles AttBtn.Click
        Dim attRecordForm As New AttRecord()
        attRecordForm.Show()
        Me.Hide()
    End Sub

    Private Sub VSBtn_Click(sender As Object, e As EventArgs) Handles VSBtn.Click
        Dim staffDBForm As New StaffDB()
        staffDBForm.Show()
        Me.Hide()
    End Sub
End Class