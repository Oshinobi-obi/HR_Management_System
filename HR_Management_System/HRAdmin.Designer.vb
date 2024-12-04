<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAdmin
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        SecurityBtn = New LinkLabel()
        AttBtn = New Button()
        VSBtn = New Button()
        LogOutBtn = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        NameTxt = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(703, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 84)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(257, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = My.Resources.Resources.User
        PictureBox3.Location = New Point(269, 14)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(60, 60)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' SecurityBtn
        ' 
        SecurityBtn.Anchor = AnchorStyles.None
        SecurityBtn.AutoSize = True
        SecurityBtn.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SecurityBtn.LinkColor = Color.Black
        SecurityBtn.Location = New Point(201, 137)
        SecurityBtn.Name = "SecurityBtn"
        SecurityBtn.Size = New Size(197, 24)
        SecurityBtn.TabIndex = 5
        SecurityBtn.TabStop = True
        SecurityBtn.Text = "SECURITY SETTINGS"
        ' 
        ' AttBtn
        ' 
        AttBtn.Anchor = AnchorStyles.None
        AttBtn.AutoSize = True
        AttBtn.Cursor = Cursors.Hand
        AttBtn.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AttBtn.Location = New Point(22, 185)
        AttBtn.Name = "AttBtn"
        AttBtn.Size = New Size(255, 55)
        AttBtn.TabIndex = 6
        AttBtn.Text = "ATTENDANCE"
        AttBtn.UseVisualStyleBackColor = True
        ' 
        ' VSBtn
        ' 
        VSBtn.Anchor = AnchorStyles.None
        VSBtn.Cursor = Cursors.Hand
        VSBtn.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VSBtn.Location = New Point(318, 185)
        VSBtn.Name = "VSBtn"
        VSBtn.Size = New Size(255, 55)
        VSBtn.TabIndex = 0
        VSBtn.Text = "VIEW STAFF"
        VSBtn.UseVisualStyleBackColor = True
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Anchor = AnchorStyles.None
        LogOutBtn.AutoSize = True
        LogOutBtn.BackColor = Color.LightCoral
        LogOutBtn.BackgroundImageLayout = ImageLayout.Center
        LogOutBtn.Cursor = Cursors.Hand
        LogOutBtn.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.Black
        LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogOutBtn.Location = New Point(199, 269)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(201, 51)
        LogOutBtn.TabIndex = 7
        LogOutBtn.Text = "LOGOUT"
        LogOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(NameTxt)
        Panel1.Controls.Add(LogOutBtn)
        Panel1.Controls.Add(VSBtn)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(AttBtn)
        Panel1.Controls.Add(SecurityBtn)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(103, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(594, 354)
        Panel1.TabIndex = 2
        ' 
        ' NameTxt
        ' 
        NameTxt.Anchor = AnchorStyles.None
        NameTxt.BackColor = Color.Transparent
        NameTxt.Font = New Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameTxt.Location = New Point(201, 86)
        NameTxt.Name = "NameTxt"
        NameTxt.Size = New Size(197, 40)
        NameTxt.TabIndex = 9
        NameTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HRAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "HRAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SecurityBtn As LinkLabel
    Friend WithEvents AttBtn As Button
    Friend WithEvents VSBtn As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NameTxt As Label
End Class
