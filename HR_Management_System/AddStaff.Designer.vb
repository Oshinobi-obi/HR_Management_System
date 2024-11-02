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
        HrShiftTxt = New TextBox()
        Label8 = New Label()
        AddStaffBtn = New Button()
        PosCmb = New ComboBox()
        StaffAddressTxt = New TextBox()
        Label7 = New Label()
        StaffContactTxt = New TextBox()
        ReturnBtn = New Button()
        Label6 = New Label()
        WorkDayTxt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        StaffAgeTxt = New TextBox()
        Label3 = New Label()
        StaffNameTxt = New TextBox()
        Label2 = New Label()
        EmIDTxt = New TextBox()
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
        AddStaffPanel.Controls.Add(HrShiftTxt)
        AddStaffPanel.Controls.Add(Label8)
        AddStaffPanel.Controls.Add(AddStaffBtn)
        AddStaffPanel.Controls.Add(PosCmb)
        AddStaffPanel.Controls.Add(StaffAddressTxt)
        AddStaffPanel.Controls.Add(Label7)
        AddStaffPanel.Controls.Add(StaffContactTxt)
        AddStaffPanel.Controls.Add(ReturnBtn)
        AddStaffPanel.Controls.Add(Label6)
        AddStaffPanel.Controls.Add(WorkDayTxt)
        AddStaffPanel.Controls.Add(Label5)
        AddStaffPanel.Controls.Add(Label4)
        AddStaffPanel.Controls.Add(StaffAgeTxt)
        AddStaffPanel.Controls.Add(Label3)
        AddStaffPanel.Controls.Add(StaffNameTxt)
        AddStaffPanel.Controls.Add(Label2)
        AddStaffPanel.Controls.Add(EmIDTxt)
        AddStaffPanel.Controls.Add(Label1)
        AddStaffPanel.Dock = DockStyle.Fill
        AddStaffPanel.Location = New Point(121, 115)
        AddStaffPanel.Name = "AddStaffPanel"
        AddStaffPanel.Size = New Size(941, 386)
        AddStaffPanel.TabIndex = 22
        ' 
        ' HrShiftTxt
        ' 
        HrShiftTxt.Anchor = AnchorStyles.None
        HrShiftTxt.BorderStyle = BorderStyle.FixedSingle
        HrShiftTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        HrShiftTxt.Location = New Point(249, 187)
        HrShiftTxt.Multiline = True
        HrShiftTxt.Name = "HrShiftTxt"
        HrShiftTxt.Size = New Size(200, 50)
        HrShiftTxt.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(249, 142)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 33)
        Label8.TabIndex = 13
        Label8.Text = "Hour Shift"
        ' 
        ' AddStaffBtn
        ' 
        AddStaffBtn.Anchor = AnchorStyles.None
        AddStaffBtn.BackColor = Color.LightGreen
        AddStaffBtn.Cursor = Cursors.Hand
        AddStaffBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffBtn.ForeColor = Color.Black
        AddStaffBtn.Location = New Point(735, 254)
        AddStaffBtn.Name = "AddStaffBtn"
        AddStaffBtn.Size = New Size(200, 50)
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
        PosCmb.Location = New Point(735, 69)
        PosCmb.Name = "PosCmb"
        PosCmb.Size = New Size(200, 45)
        PosCmb.Sorted = True
        PosCmb.TabIndex = 4
        ' 
        ' StaffAddressTxt
        ' 
        StaffAddressTxt.Anchor = AnchorStyles.None
        StaffAddressTxt.BorderStyle = BorderStyle.FixedSingle
        StaffAddressTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        StaffAddressTxt.Location = New Point(735, 187)
        StaffAddressTxt.Multiline = True
        StaffAddressTxt.Name = "StaffAddressTxt"
        StaffAddressTxt.Size = New Size(200, 50)
        StaffAddressTxt.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(735, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 33)
        Label7.TabIndex = 11
        Label7.Text = "Address"
        ' 
        ' StaffContactTxt
        ' 
        StaffContactTxt.Anchor = AnchorStyles.None
        StaffContactTxt.BorderStyle = BorderStyle.FixedSingle
        StaffContactTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        StaffContactTxt.Location = New Point(492, 187)
        StaffContactTxt.Multiline = True
        StaffContactTxt.Name = "StaffContactTxt"
        StaffContactTxt.Size = New Size(200, 50)
        StaffContactTxt.TabIndex = 7
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(735, 319)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(200, 50)
        ReturnBtn.TabIndex = 8
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(492, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 33)
        Label6.TabIndex = 9
        Label6.Text = "Contact"
        ' 
        ' WorkDayTxt
        ' 
        WorkDayTxt.Anchor = AnchorStyles.None
        WorkDayTxt.BorderStyle = BorderStyle.FixedSingle
        WorkDayTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        WorkDayTxt.Location = New Point(6, 187)
        WorkDayTxt.Multiline = True
        WorkDayTxt.Name = "WorkDayTxt"
        WorkDayTxt.Size = New Size(200, 50)
        WorkDayTxt.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 33)
        Label5.TabIndex = 7
        Label5.Text = "Work Day"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(735, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 33)
        Label4.TabIndex = 6
        Label4.Text = "Position"
        ' 
        ' StaffAgeTxt
        ' 
        StaffAgeTxt.Anchor = AnchorStyles.None
        StaffAgeTxt.BorderStyle = BorderStyle.FixedSingle
        StaffAgeTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        StaffAgeTxt.Location = New Point(492, 69)
        StaffAgeTxt.Multiline = True
        StaffAgeTxt.Name = "StaffAgeTxt"
        StaffAgeTxt.Size = New Size(200, 50)
        StaffAgeTxt.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(492, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 33)
        Label3.TabIndex = 4
        Label3.Text = "Age"
        ' 
        ' StaffNameTxt
        ' 
        StaffNameTxt.Anchor = AnchorStyles.None
        StaffNameTxt.BorderStyle = BorderStyle.FixedSingle
        StaffNameTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        StaffNameTxt.Location = New Point(249, 69)
        StaffNameTxt.Multiline = True
        StaffNameTxt.Name = "StaffNameTxt"
        StaffNameTxt.Size = New Size(200, 50)
        StaffNameTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 33)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' EmIDTxt
        ' 
        EmIDTxt.Anchor = AnchorStyles.None
        EmIDTxt.BorderStyle = BorderStyle.FixedSingle
        EmIDTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold)
        EmIDTxt.Location = New Point(6, 69)
        EmIDTxt.Multiline = True
        EmIDTxt.Name = "EmIDTxt"
        EmIDTxt.Size = New Size(200, 50)
        EmIDTxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 23)
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
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
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
    Friend WithEvents StaffAgeTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EmIDTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PosCmb As ComboBox
    Friend WithEvents StaffAddressTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StaffContactTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WorkDayTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents AddStaffBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents HrShiftTxt As TextBox
    Friend WithEvents Label8 As Label
End Class
