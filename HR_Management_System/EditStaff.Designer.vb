<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStaff
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
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        OpenBtn = New Button()
        PictureTxt = New TextBox()
        Label9 = New Label()
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
        Label1 = New Label()
        EmIDCmb = New ComboBox()
        SelectImage = New OpenFileDialog()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 72.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(1184, 661)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(1068, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(113, 109)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(EmIDCmb)
        Panel1.Controls.Add(OpenBtn)
        Panel1.Controls.Add(PictureTxt)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(HrShiftTxt)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(AddStaffBtn)
        Panel1.Controls.Add(PosCmb)
        Panel1.Controls.Add(StaffAddressTxt)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(StaffContactTxt)
        Panel1.Controls.Add(ReturnBtn)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(WorkDayTxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(StaffAgeTxt)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(StaffNameTxt)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(121, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(941, 473)
        Panel1.TabIndex = 2
        ' 
        ' OpenBtn
        ' 
        OpenBtn.Anchor = AnchorStyles.None
        OpenBtn.BackColor = Color.LightGreen
        OpenBtn.Cursor = Cursors.Hand
        OpenBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OpenBtn.Location = New Point(6, 344)
        OpenBtn.Name = "OpenBtn"
        OpenBtn.Size = New Size(120, 50)
        OpenBtn.TabIndex = 37
        OpenBtn.Text = "OPEN"
        OpenBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureTxt
        ' 
        PictureTxt.Anchor = AnchorStyles.None
        PictureTxt.BackColor = Color.White
        PictureTxt.BorderStyle = BorderStyle.FixedSingle
        PictureTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        PictureTxt.ForeColor = Color.Black
        PictureTxt.Location = New Point(6, 286)
        PictureTxt.Name = "PictureTxt"
        PictureTxt.ReadOnly = True
        PictureTxt.Size = New Size(929, 45)
        PictureTxt.TabIndex = 36
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(6, 240)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 33)
        Label9.TabIndex = 35
        Label9.Text = "Picture"
        ' 
        ' HrShiftTxt
        ' 
        HrShiftTxt.Anchor = AnchorStyles.None
        HrShiftTxt.BorderStyle = BorderStyle.FixedSingle
        HrShiftTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        HrShiftTxt.Location = New Point(249, 178)
        HrShiftTxt.Name = "HrShiftTxt"
        HrShiftTxt.Size = New Size(200, 45)
        HrShiftTxt.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(249, 133)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 33)
        Label8.TabIndex = 34
        Label8.Text = "Hour Shift"
        ' 
        ' AddStaffBtn
        ' 
        AddStaffBtn.Anchor = AnchorStyles.None
        AddStaffBtn.BackColor = Color.LightGreen
        AddStaffBtn.Cursor = Cursors.Hand
        AddStaffBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffBtn.ForeColor = Color.Black
        AddStaffBtn.Location = New Point(529, 409)
        AddStaffBtn.Name = "AddStaffBtn"
        AddStaffBtn.Size = New Size(200, 50)
        AddStaffBtn.TabIndex = 31
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
        PosCmb.Location = New Point(735, 70)
        PosCmb.Name = "PosCmb"
        PosCmb.Size = New Size(200, 45)
        PosCmb.Sorted = True
        PosCmb.TabIndex = 23
        ' 
        ' StaffAddressTxt
        ' 
        StaffAddressTxt.Anchor = AnchorStyles.None
        StaffAddressTxt.BorderStyle = BorderStyle.FixedSingle
        StaffAddressTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        StaffAddressTxt.Location = New Point(735, 178)
        StaffAddressTxt.Name = "StaffAddressTxt"
        StaffAddressTxt.Size = New Size(200, 45)
        StaffAddressTxt.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(735, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 33)
        Label7.TabIndex = 33
        Label7.Text = "Address"
        ' 
        ' StaffContactTxt
        ' 
        StaffContactTxt.Anchor = AnchorStyles.None
        StaffContactTxt.BorderStyle = BorderStyle.FixedSingle
        StaffContactTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        StaffContactTxt.Location = New Point(492, 178)
        StaffContactTxt.Name = "StaffContactTxt"
        StaffContactTxt.Size = New Size(200, 45)
        StaffContactTxt.TabIndex = 28
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(735, 409)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(200, 50)
        ReturnBtn.TabIndex = 29
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(492, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 33)
        Label6.TabIndex = 32
        Label6.Text = "Contact"
        ' 
        ' WorkDayTxt
        ' 
        WorkDayTxt.Anchor = AnchorStyles.None
        WorkDayTxt.BorderStyle = BorderStyle.FixedSingle
        WorkDayTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        WorkDayTxt.Location = New Point(6, 178)
        WorkDayTxt.Name = "WorkDayTxt"
        WorkDayTxt.Size = New Size(200, 45)
        WorkDayTxt.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 33)
        Label5.TabIndex = 27
        Label5.Text = "Work Day"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(735, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 33)
        Label4.TabIndex = 26
        Label4.Text = "Position"
        ' 
        ' StaffAgeTxt
        ' 
        StaffAgeTxt.Anchor = AnchorStyles.None
        StaffAgeTxt.BorderStyle = BorderStyle.FixedSingle
        StaffAgeTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        StaffAgeTxt.Location = New Point(492, 70)
        StaffAgeTxt.Name = "StaffAgeTxt"
        StaffAgeTxt.Size = New Size(200, 45)
        StaffAgeTxt.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(492, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 33)
        Label3.TabIndex = 22
        Label3.Text = "Age"
        ' 
        ' StaffNameTxt
        ' 
        StaffNameTxt.Anchor = AnchorStyles.None
        StaffNameTxt.BorderStyle = BorderStyle.FixedSingle
        StaffNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        StaffNameTxt.Location = New Point(249, 70)
        StaffNameTxt.Name = "StaffNameTxt"
        StaffNameTxt.Size = New Size(200, 45)
        StaffNameTxt.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 33)
        Label2.TabIndex = 19
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 33)
        Label1.TabIndex = 17
        Label1.Text = "ID"
        ' 
        ' EmIDCmb
        ' 
        EmIDCmb.Anchor = AnchorStyles.None
        EmIDCmb.Cursor = Cursors.Hand
        EmIDCmb.DropDownHeight = 200
        EmIDCmb.DropDownWidth = 400
        EmIDCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmIDCmb.FormattingEnabled = True
        EmIDCmb.IntegralHeight = False
        EmIDCmb.ItemHeight = 37
        EmIDCmb.Items.AddRange(New Object() {"Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV", "BNS", "BPSO", "Clerk", "Lupon Tagapamayapa", "Medical Aide", "Sangguniang Kabataan", "Secretary"})
        EmIDCmb.Location = New Point(6, 69)
        EmIDCmb.Name = "EmIDCmb"
        EmIDCmb.Size = New Size(200, 45)
        EmIDCmb.Sorted = True
        EmIDCmb.TabIndex = 38
        ' 
        ' EditStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(1184, 661)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "EditStaff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Staff"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmIDCmb As ComboBox
    Friend WithEvents OpenBtn As Button
    Friend WithEvents PictureTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HrShiftTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AddStaffBtn As Button
    Friend WithEvents PosCmb As ComboBox
    Friend WithEvents StaffAddressTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StaffContactTxt As TextBox
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents WorkDayTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StaffAgeTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectImage As OpenFileDialog
End Class
