<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        LoginBtn = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        ShutdownBtn = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(669, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 93)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Corbel", 45F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(350, 73)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Anchor = AnchorStyles.None
        LoginBtn.AutoSize = True
        LoginBtn.BackColor = Color.White
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Corbel", 35.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(161, 126)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(204, 68)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "LOGIN"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.6666641F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.62983F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 76.37017F))
        TableLayoutPanel1.Size = New Size(800, 419)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ShutdownBtn)
        Panel2.Controls.Add(LoginBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(136, 102)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(527, 314)
        Panel2.TabIndex = 6
        ' 
        ' ShutdownBtn
        ' 
        ShutdownBtn.Anchor = AnchorStyles.None
        ShutdownBtn.Cursor = Cursors.Hand
        ShutdownBtn.Image = My.Resources.Resources.Shutdown
        ShutdownBtn.Location = New Point(231, 221)
        ShutdownBtn.Name = "ShutdownBtn"
        ShutdownBtn.Size = New Size(65, 60)
        ShutdownBtn.SizeMode = PictureBoxSizeMode.StretchImage
        ShutdownBtn.TabIndex = 12
        ShutdownBtn.TabStop = False
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(800, 419)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Welcome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Brgy. Santa Monica"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShutdownBtn As PictureBox
End Class
