<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HRLogin
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
        TableLayoutPanel1 = New TableLayoutPanel()
        StaffLoginPanel = New Panel()
        ShutdownBtn = New PictureBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PassPanel.SuspendLayout()
        StaffIDPanel.SuspendLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserIcon, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        StaffLoginPanel.SuspendLayout()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PassPanel
        ' 
        PassPanel.Anchor = AnchorStyles.None
        PassPanel.BackColor = Color.White
        PassPanel.Controls.Add(Passtxt)
        PassPanel.Location = New Point(98, 187)
        PassPanel.Name = "PassPanel"
        PassPanel.Size = New Size(300, 45)
        PassPanel.TabIndex = 8
        ' 
        ' Passtxt
        ' 
        Passtxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Passtxt.BackColor = SystemColors.Window
        Passtxt.BorderStyle = BorderStyle.None
        Passtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Passtxt.Location = New Point(4, 3)
        Passtxt.Name = "Passtxt"
        Passtxt.Size = New Size(292, 38)
        Passtxt.TabIndex = 2
        Passtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' StaffIDPanel
        ' 
        StaffIDPanel.Anchor = AnchorStyles.None
        StaffIDPanel.BackColor = Color.White
        StaffIDPanel.Controls.Add(StaffIDtxt)
        StaffIDPanel.Location = New Point(98, 78)
        StaffIDPanel.Name = "StaffIDPanel"
        StaffIDPanel.Size = New Size(300, 45)
        StaffIDPanel.TabIndex = 7
        ' 
        ' StaffIDtxt
        ' 
        StaffIDtxt.BorderStyle = BorderStyle.None
        StaffIDtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffIDtxt.Location = New Point(4, 3)
        StaffIDtxt.Mask = "00-00-00-00"
        StaffIDtxt.Name = "StaffIDtxt"
        StaffIDtxt.Size = New Size(292, 38)
        StaffIDtxt.TabIndex = 1
        StaffIDtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Anchor = AnchorStyles.None
        LoginBtn.BackColor = Color.LightGreen
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(197, 269)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(150, 60)
        LoginBtn.TabIndex = 10
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(98, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 41)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(98, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 41)
        Label2.TabIndex = 5
        Label2.Text = "Employee ID"
        ' 
        ' PassIcon
        ' 
        PassIcon.Anchor = AnchorStyles.None
        PassIcon.BackColor = Color.White
        PassIcon.BackgroundImageLayout = ImageLayout.Stretch
        PassIcon.Image = My.Resources.Resources.Lock_1
        PassIcon.InitialImage = Nothing
        PassIcon.Location = New Point(397, 187)
        PassIcon.Name = "PassIcon"
        PassIcon.Size = New Size(50, 45)
        PassIcon.TabIndex = 4
        PassIcon.TabStop = False
        ' 
        ' UserIcon
        ' 
        UserIcon.Anchor = AnchorStyles.None
        UserIcon.BackColor = Color.White
        UserIcon.BackgroundImageLayout = ImageLayout.Stretch
        UserIcon.Image = My.Resources.Resources.ID_Verified_1
        UserIcon.Location = New Point(397, 78)
        UserIcon.Name = "UserIcon"
        UserIcon.Size = New Size(50, 45)
        UserIcon.TabIndex = 3
        UserIcon.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(3, 25, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(544, 63)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(StaffLoginPanel, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Size = New Size(734, 461)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' StaffLoginPanel
        ' 
        StaffLoginPanel.Controls.Add(ShutdownBtn)
        StaffLoginPanel.Controls.Add(PassPanel)
        StaffLoginPanel.Controls.Add(StaffIDPanel)
        StaffLoginPanel.Controls.Add(UserIcon)
        StaffLoginPanel.Controls.Add(LoginBtn)
        StaffLoginPanel.Controls.Add(PassIcon)
        StaffLoginPanel.Controls.Add(Label3)
        StaffLoginPanel.Controls.Add(Label2)
        StaffLoginPanel.Dock = DockStyle.Fill
        StaffLoginPanel.Location = New Point(94, 72)
        StaffLoginPanel.Name = "StaffLoginPanel"
        StaffLoginPanel.Size = New Size(544, 362)
        StaffLoginPanel.TabIndex = 0
        ' 
        ' ShutdownBtn
        ' 
        ShutdownBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ShutdownBtn.Cursor = Cursors.Hand
        ShutdownBtn.Image = My.Resources.Resources.Shutdown
        ShutdownBtn.Location = New Point(487, 12)
        ShutdownBtn.Name = "ShutdownBtn"
        ShutdownBtn.Size = New Size(45, 40)
        ShutdownBtn.SizeMode = PictureBoxSizeMode.StretchImage
        ShutdownBtn.TabIndex = 11
        ShutdownBtn.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(94, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(544, 63)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(644, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(87, 63)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' HRLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(734, 461)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "HRLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        PassPanel.ResumeLayout(False)
        PassPanel.PerformLayout()
        StaffIDPanel.ResumeLayout(False)
        StaffIDPanel.PerformLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(UserIcon, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        StaffLoginPanel.ResumeLayout(False)
        StaffLoginPanel.PerformLayout()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents StaffIDtxt As MaskedTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents StaffLoginPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ShutdownBtn As PictureBox

End Class
