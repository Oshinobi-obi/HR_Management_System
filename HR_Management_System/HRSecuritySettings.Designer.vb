<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRSecuritySettings
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
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        OldPassTxt = New TextBox()
        NewPassTxt = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SaveBtn = New Button()
        ReturnBtn = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        SecurityPanel = New Panel()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SecurityPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(789, 44)
        Label1.TabIndex = 7
        Label1.Text = "SECURITY SETTINGS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.Security_Lock
        PictureBox3.Location = New Point(334, 33)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(120, 120)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' OldPassTxt
        ' 
        OldPassTxt.Anchor = AnchorStyles.None
        OldPassTxt.BorderStyle = BorderStyle.FixedSingle
        OldPassTxt.Font = New Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OldPassTxt.Location = New Point(94, 206)
        OldPassTxt.Name = "OldPassTxt"
        OldPassTxt.Size = New Size(600, 53)
        OldPassTxt.TabIndex = 9
        ' 
        ' NewPassTxt
        ' 
        NewPassTxt.Anchor = AnchorStyles.None
        NewPassTxt.BorderStyle = BorderStyle.FixedSingle
        NewPassTxt.Font = New Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewPassTxt.Location = New Point(94, 318)
        NewPassTxt.Name = "NewPassTxt"
        NewPassTxt.Size = New Size(600, 53)
        NewPassTxt.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 33)
        Label2.TabIndex = 11
        Label2.Text = "OLD PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(94, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 33)
        Label3.TabIndex = 12
        Label3.Text = "NEW PASSWORD"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Anchor = AnchorStyles.None
        SaveBtn.AutoSize = True
        SaveBtn.BackColor = Color.LightGreen
        SaveBtn.Cursor = Cursors.Hand
        SaveBtn.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.Location = New Point(210, 397)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(110, 43)
        SaveBtn.TabIndex = 13
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(481, 398)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(150, 43)
        ReturnBtn.TabIndex = 14
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(SecurityPanel, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 86.36364F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.5454545F))
        TableLayoutPanel1.Size = New Size(884, 557)
        TableLayoutPanel1.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(47, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(789, 44)
        Panel1.TabIndex = 7
        ' 
        ' SecurityPanel
        ' 
        SecurityPanel.Controls.Add(ReturnBtn)
        SecurityPanel.Controls.Add(PictureBox3)
        SecurityPanel.Controls.Add(SaveBtn)
        SecurityPanel.Controls.Add(OldPassTxt)
        SecurityPanel.Controls.Add(Label3)
        SecurityPanel.Controls.Add(NewPassTxt)
        SecurityPanel.Controls.Add(Label2)
        SecurityPanel.Dock = DockStyle.Fill
        SecurityPanel.Location = New Point(47, 53)
        SecurityPanel.Name = "SecurityPanel"
        SecurityPanel.Size = New Size(789, 475)
        SecurityPanel.TabIndex = 8
        ' 
        ' HRSecuritySettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(884, 557)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRSecuritySettings"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        SecurityPanel.ResumeLayout(False)
        SecurityPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents OldPassTxt As TextBox
    Friend WithEvents NewPassTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SecurityPanel As Panel


End Class
