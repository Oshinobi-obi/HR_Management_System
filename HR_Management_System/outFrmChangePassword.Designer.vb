<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outFrmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblPasswordStatus = New Label()
        lblConfirmStatus = New Label()
        Label3 = New Label()
        txtConfirmPassword = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        btnSubmit = New Button()
        txtCurrentPassword = New TextBox()
        lblChangePassword = New Label()
        Label1 = New Label()
        btnExit = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblPasswordStatus)
        Panel1.Controls.Add(lblConfirmStatus)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtConfirmPassword)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(btnSubmit)
        Panel1.Controls.Add(txtCurrentPassword)
        Panel1.Location = New Point(18, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(226, 271)
        Panel1.TabIndex = 9
        ' 
        ' lblPasswordStatus
        ' 
        lblPasswordStatus.AutoSize = True
        lblPasswordStatus.Font = New Font("Segoe UI", 9F)
        lblPasswordStatus.ForeColor = Color.Black
        lblPasswordStatus.Location = New Point(10, 115)
        lblPasswordStatus.Margin = New Padding(2, 0, 2, 0)
        lblPasswordStatus.Name = "lblPasswordStatus"
        lblPasswordStatus.Size = New Size(0, 15)
        lblPasswordStatus.TabIndex = 16
        ' 
        ' lblConfirmStatus
        ' 
        lblConfirmStatus.AutoSize = True
        lblConfirmStatus.Font = New Font("Segoe UI", 9F)
        lblConfirmStatus.ForeColor = Color.Black
        lblConfirmStatus.Location = New Point(10, 188)
        lblConfirmStatus.Margin = New Padding(2, 0, 2, 0)
        lblConfirmStatus.Name = "lblConfirmStatus"
        lblConfirmStatus.Size = New Size(0, 15)
        lblConfirmStatus.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(10, 142)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 14
        Label3.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(12, 158)
        txtConfirmPassword.Margin = New Padding(2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(204, 29)
        txtConfirmPassword.TabIndex = 13
        txtConfirmPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(9, 70)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 12
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(11, 86)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(204, 29)
        txtPassword.TabIndex = 11
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F)
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(10, 11)
        lblPassword.Margin = New Padding(2, 0, 2, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(100, 15)
        lblPassword.TabIndex = 10
        lblPassword.Text = "Current Password"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.Highlight
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Font = New Font("Segoe UI", 10F)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(12, 223)
        btnSubmit.Margin = New Padding(2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(203, 36)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Enabled = False
        txtCurrentPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCurrentPassword.Location = New Point(11, 27)
        txtCurrentPassword.Margin = New Padding(2)
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.Size = New Size(204, 29)
        txtCurrentPassword.TabIndex = 8
        txtCurrentPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblChangePassword
        ' 
        lblChangePassword.AutoSize = True
        lblChangePassword.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChangePassword.ForeColor = Color.Black
        lblChangePassword.Location = New Point(54, 5)
        lblChangePassword.Margin = New Padding(2, 0, 2, 0)
        lblChangePassword.Name = "lblChangePassword"
        lblChangePassword.Size = New Size(181, 30)
        lblChangePassword.TabIndex = 12
        lblChangePassword.Text = "Change Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 8.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(-2, -33)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 15)
        Label1.TabIndex = 11
        Label1.Text = "Admin System | Change Password"
        ' 
        ' btnExit
        ' 
        btnExit.AccessibleName = "btnExit"
        btnExit.BackColor = Color.Red
        btnExit.Cursor = Cursors.Hand
        btnExit.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(242, -33)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(31, 30)
        btnExit.TabIndex = 10
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(-18, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(305, 319)
        Panel2.TabIndex = 13
        ' 
        ' outFrmChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(269, 331)
        Controls.Add(Panel1)
        Controls.Add(lblChangePassword)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(Panel2)
        Name = "outFrmChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "outFrmChangePassword"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPasswordStatus As Label
    Friend WithEvents lblConfirmStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblChangePassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
End Class
