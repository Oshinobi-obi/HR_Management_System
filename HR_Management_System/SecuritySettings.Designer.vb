<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecuritySettings
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
        OldPassTxt = New TextBox()
        NewPassTxt = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SaveBtn = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(692, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 95)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(200, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 54)
        Label1.TabIndex = 7
        Label1.Text = "SECURITY SETTINGS"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.Security_Lock
        PictureBox3.Location = New Point(371, 102)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(60, 60)
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' OldPassTxt
        ' 
        OldPassTxt.BorderStyle = BorderStyle.FixedSingle
        OldPassTxt.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OldPassTxt.Location = New Point(201, 221)
        OldPassTxt.Name = "OldPassTxt"
        OldPassTxt.Size = New Size(400, 48)
        OldPassTxt.TabIndex = 9
        ' 
        ' NewPassTxt
        ' 
        NewPassTxt.BorderStyle = BorderStyle.FixedSingle
        NewPassTxt.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewPassTxt.Location = New Point(201, 321)
        NewPassTxt.Name = "NewPassTxt"
        NewPassTxt.Size = New Size(400, 48)
        NewPassTxt.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(201, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 33)
        Label2.TabIndex = 11
        Label2.Text = "OLD PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(201, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 33)
        Label3.TabIndex = 12
        Label3.Text = "NEW PASSWORD"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.AutoSize = True
        SaveBtn.BackColor = Color.LimeGreen
        SaveBtn.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.Location = New Point(356, 393)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(90, 43)
        SaveBtn.TabIndex = 13
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(495, 408)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 14
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SecuritySettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(804, 461)
        Controls.Add(Button2)
        Controls.Add(SaveBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NewPassTxt)
        Controls.Add(OldPassTxt)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "SecuritySettings"
        Text = "AttSummary"
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
    Friend WithEvents OldPassTxt As TextBox
    Friend WithEvents NewPassTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Button2 As Button


End Class
