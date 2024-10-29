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
        TimeBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
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
        Label1.Font = New Font("Corbel", 45F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(243, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 73)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Anchor = AnchorStyles.None
        LoginBtn.AutoSize = True
        LoginBtn.BackColor = Color.White
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Corbel", 35.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(156, 251)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(204, 68)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "LOGIN"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' TimeBtn
        ' 
        TimeBtn.Anchor = AnchorStyles.None
        TimeBtn.AutoSize = True
        TimeBtn.BackColor = Color.White
        TimeBtn.Cursor = Cursors.Hand
        TimeBtn.Font = New Font("Corbel", 35.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeBtn.Location = New Point(444, 250)
        TimeBtn.Name = "TimeBtn"
        TimeBtn.Size = New Size(204, 68)
        TimeBtn.TabIndex = 4
        TimeBtn.Text = "TIME-IN"
        TimeBtn.UseVisualStyleBackColor = False
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(800, 419)
        Controls.Add(TimeBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Welcome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Brgy. Santa Monica"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents TimeBtn As Button
End Class
