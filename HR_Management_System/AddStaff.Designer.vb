<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        AddStaffPanel = New Panel()
        AddStaffBtn = New Button()
        PosCmb = New ComboBox()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        ReturnBtn = New Button()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        AddStaffPanel.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(1068, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(113, 106)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' AddStaffPanel
        ' 
        AddStaffPanel.Controls.Add(AddStaffBtn)
        AddStaffPanel.Controls.Add(PosCmb)
        AddStaffPanel.Controls.Add(TextBox7)
        AddStaffPanel.Controls.Add(Label7)
        AddStaffPanel.Controls.Add(TextBox6)
        AddStaffPanel.Controls.Add(ReturnBtn)
        AddStaffPanel.Controls.Add(Label6)
        AddStaffPanel.Controls.Add(TextBox5)
        AddStaffPanel.Controls.Add(Label5)
        AddStaffPanel.Controls.Add(Label4)
        AddStaffPanel.Controls.Add(TextBox3)
        AddStaffPanel.Controls.Add(Label3)
        AddStaffPanel.Controls.Add(TextBox2)
        AddStaffPanel.Controls.Add(Label2)
        AddStaffPanel.Controls.Add(TextBox1)
        AddStaffPanel.Controls.Add(Label1)
        AddStaffPanel.Dock = DockStyle.Fill
        AddStaffPanel.Location = New Point(121, 115)
        AddStaffPanel.Name = "AddStaffPanel"
        AddStaffPanel.Size = New Size(941, 443)
        AddStaffPanel.TabIndex = 22
        ' 
        ' AddStaffBtn
        ' 
        AddStaffBtn.Anchor = AnchorStyles.None
        AddStaffBtn.BackColor = Color.LightGreen
        AddStaffBtn.Cursor = Cursors.Hand
        AddStaffBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffBtn.ForeColor = Color.Black
        AddStaffBtn.Location = New Point(735, 275)
        AddStaffBtn.Name = "AddStaffBtn"
        AddStaffBtn.Size = New Size(185, 50)
        AddStaffBtn.TabIndex = 9
        AddStaffBtn.Text = "ADD STAFF"
        AddStaffBtn.UseVisualStyleBackColor = False
        ' 
        ' PosCmb
        ' 
        PosCmb.Anchor = AnchorStyles.None
        PosCmb.Cursor = Cursors.Hand
        PosCmb.DropDownHeight = 200
        PosCmb.DropDownWidth = 400
        PosCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PosCmb.FormattingEnabled = True
        PosCmb.IntegralHeight = False
        PosCmb.ItemHeight = 37
        PosCmb.Items.AddRange(New Object() {"Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV", "BNS", "BPSO", "Clerk", "Lupon Tagapamayapa", "Medical Aide", "Sangguniang Kabataan", "Secretary"})
        PosCmb.Location = New Point(735, 78)
        PosCmb.Name = "PosCmb"
        PosCmb.Size = New Size(200, 45)
        PosCmb.Sorted = True
        PosCmb.TabIndex = 4
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.None
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox7.Location = New Point(492, 196)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(200, 50)
        TextBox7.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(492, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 33)
        Label7.TabIndex = 11
        Label7.Text = "Address"
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox6.Location = New Point(249, 196)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 50)
        TextBox6.TabIndex = 6
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(542, 275)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(150, 50)
        ReturnBtn.TabIndex = 8
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(249, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 33)
        Label6.TabIndex = 9
        Label6.Text = "Contact"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox5.Location = New Point(6, 196)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 50)
        TextBox5.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 33)
        Label5.TabIndex = 7
        Label5.Text = "Schedule"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(735, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 33)
        Label4.TabIndex = 6
        Label4.Text = "Position"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox3.Location = New Point(492, 78)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 50)
        TextBox3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(492, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 33)
        Label3.TabIndex = 4
        Label3.Text = "Age"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox2.Location = New Point(249, 78)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 50)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 33)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        TextBox1.Location = New Point(6, 78)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 50)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 33)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(AddStaffPanel, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1184, 561)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' AddStaff
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(1184, 561)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddStaff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddStaff"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        AddStaffPanel.ResumeLayout(False)
        AddStaffPanel.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AddStaffPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PosCmb As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents AddStaffBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
