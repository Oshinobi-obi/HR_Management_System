<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        StaffLoginPanel = New Panel()
        PassPanel = New Panel()
        Passtxt = New TextBox()
        StaffIDPanel = New Panel()
        StaffIDtxt = New MaskedTextBox()
        LoginBtn = New Button()
        Label3 = New Label()
        Label2 = New Label()
        PassIcon = New PictureBox()
        UserIcon = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        StaffLoginPanel.SuspendLayout()
        PassPanel.SuspendLayout()
        StaffIDPanel.SuspendLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StaffLoginPanel
        ' 
        StaffLoginPanel.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        StaffLoginPanel.Controls.Add(PassPanel)
        StaffLoginPanel.Controls.Add(StaffIDPanel)
        StaffLoginPanel.Controls.Add(LoginBtn)
        StaffLoginPanel.Controls.Add(Label3)
        StaffLoginPanel.Controls.Add(Label2)
        StaffLoginPanel.Controls.Add(PassIcon)
        StaffLoginPanel.Controls.Add(UserIcon)
        StaffLoginPanel.Controls.Add(Label1)
        StaffLoginPanel.Location = New Point(84, 84)
        StaffLoginPanel.Margin = New Padding(75)
        StaffLoginPanel.Name = "StaffLoginPanel"
        StaffLoginPanel.Size = New Size(416, 327)
        StaffLoginPanel.TabIndex = 0
        ' 
        ' PassPanel
        ' 
        PassPanel.BackColor = Color.White
        PassPanel.Controls.Add(Passtxt)
        PassPanel.Location = New Point(80, 198)
        PassPanel.Name = "PassPanel"
        PassPanel.Size = New Size(211, 43)
        PassPanel.TabIndex = 8
        ' 
        ' Passtxt
        ' 
        Passtxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Passtxt.BackColor = SystemColors.Window
        Passtxt.BorderStyle = BorderStyle.None
        Passtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Passtxt.Location = New Point(8, 3)
        Passtxt.Name = "Passtxt"
        Passtxt.Size = New Size(195, 38)
        Passtxt.TabIndex = 2
        ' 
        ' StaffIDPanel
        ' 
        StaffIDPanel.BackColor = Color.White
        StaffIDPanel.Controls.Add(StaffIDtxt)
        StaffIDPanel.Location = New Point(80, 120)
        StaffIDPanel.Name = "StaffIDPanel"
        StaffIDPanel.Size = New Size(211, 43)
        StaffIDPanel.TabIndex = 7
        ' 
        ' StaffIDtxt
        ' 
        StaffIDtxt.BorderStyle = BorderStyle.None
        StaffIDtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffIDtxt.Location = New Point(8, 3)
        StaffIDtxt.Mask = "00-00-00-00"
        StaffIDtxt.Name = "StaffIDtxt"
        StaffIDtxt.Size = New Size(195, 38)
        StaffIDtxt.TabIndex = 1
        StaffIDtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Green
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(178, 269)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(75, 38)
        LoginBtn.TabIndex = 10
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(80, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 24)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 24)
        Label2.TabIndex = 5
        Label2.Text = "Employee ID"
        ' 
        ' PassIcon
        ' 
        PassIcon.BackColor = Color.White
        PassIcon.BackgroundImageLayout = ImageLayout.Stretch
        PassIcon.Image = My.Resources.Resources.Lock_1
        PassIcon.InitialImage = Nothing
        PassIcon.Location = New Point(290, 198)
        PassIcon.Name = "PassIcon"
        PassIcon.Size = New Size(50, 43)
        PassIcon.TabIndex = 4
        PassIcon.TabStop = False
        ' 
        ' UserIcon
        ' 
        UserIcon.BackColor = Color.White
        UserIcon.BackgroundImageLayout = ImageLayout.Stretch
        UserIcon.Image = My.Resources.Resources.ID_Verified_1
        UserIcon.Location = New Point(290, 120)
        UserIcon.Name = "UserIcon"
        UserIcon.Size = New Size(50, 43)
        UserIcon.TabIndex = 3
        UserIcon.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoEllipsis = True
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(146, 18)
        Label1.Margin = New Padding(3, 25, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 49)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 60)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = My.Resources.Resources.SPLQ
        PictureBox2.Location = New Point(507, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 60)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(584, 461)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(StaffLoginPanel)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Brgy. Santa Monica"
        StaffLoginPanel.ResumeLayout(False)
        StaffLoginPanel.PerformLayout()
        PassPanel.ResumeLayout(False)
        PassPanel.PerformLayout()
        StaffIDPanel.ResumeLayout(False)
        StaffIDPanel.PerformLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(UserIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents StaffLoginPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UserIcon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StaffIDPanel As Panel
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents PassPanel As Panel
    Friend WithEvents Passtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PassIcon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StaffIDtxt As MaskedTextBox

End Class
