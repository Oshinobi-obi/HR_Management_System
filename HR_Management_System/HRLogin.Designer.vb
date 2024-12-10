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
        components = New ComponentModel.Container()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        DateLbl = New Label()
        AmPmLbl = New Label()
        TimeLbl = New Label()
        Panel3 = New Panel()
        StaffLoginPanel = New Panel()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Passtxt = New TextBox()
        StaffIDtxt = New MaskedTextBox()
        ShutdownBtn = New PictureBox()
        LoginBtn = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Clock = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        StaffLoginPanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(70))
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Right
        TableLayoutPanel1.Location = New Point(435, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.Size = New Size(433, 745)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DateLbl)
        Panel2.Controls.Add(AmPmLbl)
        Panel2.Controls.Add(TimeLbl)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(427, 143)
        Panel2.TabIndex = 1
        ' 
        ' DateLbl
        ' 
        DateLbl.Anchor = AnchorStyles.None
        DateLbl.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateLbl.ForeColor = Color.White
        DateLbl.Location = New Point(65, 93)
        DateLbl.Name = "DateLbl"
        DateLbl.Size = New Size(296, 33)
        DateLbl.TabIndex = 2
        DateLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AmPmLbl
        ' 
        AmPmLbl.Anchor = AnchorStyles.None
        AmPmLbl.BackColor = Color.Transparent
        AmPmLbl.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AmPmLbl.ForeColor = Color.White
        AmPmLbl.Location = New Point(244, 41)
        AmPmLbl.Name = "AmPmLbl"
        AmPmLbl.Size = New Size(78, 56)
        AmPmLbl.TabIndex = 1
        AmPmLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TimeLbl
        ' 
        TimeLbl.Anchor = AnchorStyles.None
        TimeLbl.BackColor = Color.Transparent
        TimeLbl.Font = New Font("Arial", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLbl.ForeColor = Color.White
        TimeLbl.Location = New Point(109, 38)
        TimeLbl.Name = "TimeLbl"
        TimeLbl.Size = New Size(159, 56)
        TimeLbl.TabIndex = 0
        TimeLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(StaffLoginPanel)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 152)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(427, 478)
        Panel3.TabIndex = 2
        ' 
        ' StaffLoginPanel
        ' 
        StaffLoginPanel.Anchor = AnchorStyles.None
        StaffLoginPanel.BackColor = Color.White
        StaffLoginPanel.Controls.Add(Label2)
        StaffLoginPanel.Controls.Add(PictureBox4)
        StaffLoginPanel.Controls.Add(PictureBox3)
        StaffLoginPanel.Controls.Add(PictureBox2)
        StaffLoginPanel.Controls.Add(Passtxt)
        StaffLoginPanel.Controls.Add(StaffIDtxt)
        StaffLoginPanel.Controls.Add(ShutdownBtn)
        StaffLoginPanel.Controls.Add(LoginBtn)
        StaffLoginPanel.Location = New Point(38, 29)
        StaffLoginPanel.Name = "StaffLoginPanel"
        StaffLoginPanel.Size = New Size(350, 420)
        StaffLoginPanel.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(125, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 36)
        Label2.TabIndex = 15
        Label2.Text = "HRMS"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Image = My.Resources.Resources.Human_Resources_1
        PictureBox4.Location = New Point(125, 79)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 100)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Image = My.Resources.Resources.Lock_Orientation
        PictureBox3.Location = New Point(25, 257)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 45)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.Male_User
        PictureBox2.Location = New Point(25, 185)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Passtxt
        ' 
        Passtxt.Anchor = AnchorStyles.None
        Passtxt.BackColor = SystemColors.Window
        Passtxt.BorderStyle = BorderStyle.FixedSingle
        Passtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Passtxt.Location = New Point(76, 257)
        Passtxt.Name = "Passtxt"
        Passtxt.PlaceholderText = "Password"
        Passtxt.Size = New Size(250, 45)
        Passtxt.TabIndex = 2
        Passtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' StaffIDtxt
        ' 
        StaffIDtxt.Anchor = AnchorStyles.None
        StaffIDtxt.BorderStyle = BorderStyle.FixedSingle
        StaffIDtxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffIDtxt.Location = New Point(76, 185)
        StaffIDtxt.Mask = "00-00-00-00"
        StaffIDtxt.Name = "StaffIDtxt"
        StaffIDtxt.Size = New Size(250, 45)
        StaffIDtxt.TabIndex = 1
        StaffIDtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' ShutdownBtn
        ' 
        ShutdownBtn.Anchor = AnchorStyles.None
        ShutdownBtn.Cursor = Cursors.Hand
        ShutdownBtn.Image = My.Resources.Resources.Shutdown
        ShutdownBtn.Location = New Point(293, 13)
        ShutdownBtn.Name = "ShutdownBtn"
        ShutdownBtn.Size = New Size(45, 40)
        ShutdownBtn.SizeMode = PictureBoxSizeMode.StretchImage
        ShutdownBtn.TabIndex = 11
        ShutdownBtn.TabStop = False
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Anchor = AnchorStyles.None
        LoginBtn.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(70))
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(100, 320)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(150, 60)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.White
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel2.Size = New Size(435, 745)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(429, 627)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 636)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(429, 106)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(70))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 106)
        Label1.TabIndex = 0
        Label1.Text = "BRGY. STA. MONICA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Clock
        ' 
        ' 
        ' HRLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(868, 745)
        ControlBox = False
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRLogin"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        StaffLoginPanel.ResumeLayout(False)
        StaffLoginPanel.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Clock As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AmPmLbl As Label
    Friend WithEvents TimeLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StaffLoginPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Passtxt As TextBox
    Friend WithEvents StaffIDtxt As MaskedTextBox
    Friend WithEvents ShutdownBtn As PictureBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label

End Class
