<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        NameTxt = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(688, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 95)
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
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = My.Resources.Resources.User
        PictureBox3.Location = New Point(370, 81)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(60, 60)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' SecurityBtn
        ' 
        SecurityBtn.AutoSize = True
        SecurityBtn.Font = New Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SecurityBtn.LinkColor = Color.Black
        SecurityBtn.Location = New Point(302, 189)
        SecurityBtn.Name = "SecurityBtn"
        SecurityBtn.Size = New Size(197, 24)
        SecurityBtn.TabIndex = 5
        SecurityBtn.TabStop = True
        SecurityBtn.Text = "SECURITY SETTINGS"
        ' 
        ' AttBtn
        ' 
        AttBtn.AutoSize = True
        AttBtn.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AttBtn.Location = New Point(84, 253)
        AttBtn.Name = "AttBtn"
        AttBtn.Size = New Size(283, 59)
        AttBtn.TabIndex = 6
        AttBtn.Text = "ATTENDANCE"
        AttBtn.UseVisualStyleBackColor = True
        ' 
        ' VSBtn
        ' 
        VSBtn.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VSBtn.Location = New Point(432, 253)
        VSBtn.Name = "VSBtn"
        VSBtn.Size = New Size(283, 59)
        VSBtn.TabIndex = 0
        VSBtn.Text = "VIEW STAFF"
        VSBtn.UseVisualStyleBackColor = True
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.AutoSize = True
        LogOutBtn.BackColor = Color.Red
        LogOutBtn.BackgroundImageLayout = ImageLayout.Center
        LogOutBtn.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.White
        LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogOutBtn.Location = New Point(300, 359)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(201, 51)
        LogOutBtn.TabIndex = 7
        LogOutBtn.Text = "LOGOUT"
        LogOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' NameTxt
        ' 
        NameTxt.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        NameTxt.BorderStyle = BorderStyle.None
        NameTxt.Enabled = False
        NameTxt.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameTxt.Location = New Point(214, 147)
        NameTxt.Multiline = True
        NameTxt.Name = "NameTxt"
        NameTxt.Size = New Size(372, 39)
        NameTxt.TabIndex = 8
        NameTxt.TabStop = False
        NameTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(800, 450)
        Controls.Add(NameTxt)
        Controls.Add(LogOutBtn)
        Controls.Add(VSBtn)
        Controls.Add(AttBtn)
        Controls.Add(SecurityBtn)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Admin"
        Text = "Brgy. Santa Monica"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NameTxt As TextBox
End Class
