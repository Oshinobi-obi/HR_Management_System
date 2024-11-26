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
        StatusCmb = New ComboBox()
        Label14 = New Label()
        ResidentIDTxt = New TextBox()
        Label13 = New Label()
        LastNameTxt = New TextBox()
        Label11 = New Label()
        MiddleNameTxt = New TextBox()
        Label12 = New Label()
        CardNumberTxt = New TextBox()
        Label10 = New Label()
        PictureTxt = New TextBox()
        Label9 = New Label()
        HrShiftTxt = New TextBox()
        Label8 = New Label()
        PosCmb = New ComboBox()
        AddressTxt = New TextBox()
        Label7 = New Label()
        ContactTxt = New TextBox()
        Label6 = New Label()
        WorkDayTxt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        AgeTxt = New TextBox()
        Label3 = New Label()
        FirstNameTxt = New TextBox()
        Label2 = New Label()
        Label15 = New Label()
        EmIDCmb = New ComboBox()
        OpenBtn = New Button()
        UpdateStaffBtn = New Button()
        ReturnBtn = New Button()
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 79.78597F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2.73483944F))
        TableLayoutPanel1.Size = New Size(1280, 841)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 141)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(1155, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(122, 141)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(StatusCmb)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(ResidentIDTxt)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(LastNameTxt)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(MiddleNameTxt)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(CardNumberTxt)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(PictureTxt)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(HrShiftTxt)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PosCmb)
        Panel1.Controls.Add(AddressTxt)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(ContactTxt)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(WorkDayTxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(AgeTxt)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(FirstNameTxt)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(EmIDCmb)
        Panel1.Controls.Add(OpenBtn)
        Panel1.Controls.Add(UpdateStaffBtn)
        Panel1.Controls.Add(ReturnBtn)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(131, 150)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1018, 664)
        Panel1.TabIndex = 2
        ' 
        ' StatusCmb
        ' 
        StatusCmb.Anchor = AnchorStyles.None
        StatusCmb.Cursor = Cursors.Hand
        StatusCmb.DropDownHeight = 200
        StatusCmb.DropDownStyle = ComboBoxStyle.DropDownList
        StatusCmb.DropDownWidth = 400
        StatusCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusCmb.FormattingEnabled = True
        StatusCmb.IntegralHeight = False
        StatusCmb.ItemHeight = 37
        StatusCmb.Items.AddRange(New Object() {"EMPLOYED", "TERMINATED"})
        StatusCmb.Location = New Point(778, 202)
        StatusCmb.Name = "StatusCmb"
        StatusCmb.Size = New Size(200, 45)
        StatusCmb.Sorted = True
        StatusCmb.TabIndex = 70
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(778, 156)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 33)
        Label14.TabIndex = 69
        Label14.Text = "Status"
        ' 
        ' ResidentIDTxt
        ' 
        ResidentIDTxt.Anchor = AnchorStyles.None
        ResidentIDTxt.BorderStyle = BorderStyle.FixedSingle
        ResidentIDTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        ResidentIDTxt.Location = New Point(41, 92)
        ResidentIDTxt.Name = "ResidentIDTxt"
        ResidentIDTxt.Size = New Size(200, 45)
        ResidentIDTxt.TabIndex = 41
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(41, 46)
        Label13.Name = "Label13"
        Label13.Size = New Size(149, 33)
        Label13.TabIndex = 65
        Label13.Text = "Resident ID"
        ' 
        ' LastNameTxt
        ' 
        LastNameTxt.Anchor = AnchorStyles.None
        LastNameTxt.BackColor = Color.White
        LastNameTxt.BorderStyle = BorderStyle.FixedSingle
        LastNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        LastNameTxt.Location = New Point(778, 91)
        LastNameTxt.Name = "LastNameTxt"
        LastNameTxt.ReadOnly = True
        LastNameTxt.Size = New Size(200, 45)
        LastNameTxt.TabIndex = 62
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(778, 46)
        Label11.Name = "Label11"
        Label11.Size = New Size(142, 33)
        Label11.TabIndex = 64
        Label11.Text = "Last Name"
        ' 
        ' MiddleNameTxt
        ' 
        MiddleNameTxt.Anchor = AnchorStyles.None
        MiddleNameTxt.BackColor = Color.White
        MiddleNameTxt.BorderStyle = BorderStyle.FixedSingle
        MiddleNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        MiddleNameTxt.Location = New Point(535, 91)
        MiddleNameTxt.Name = "MiddleNameTxt"
        MiddleNameTxt.ReadOnly = True
        MiddleNameTxt.Size = New Size(200, 45)
        MiddleNameTxt.TabIndex = 61
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(535, 46)
        Label12.Name = "Label12"
        Label12.Size = New Size(172, 33)
        Label12.TabIndex = 63
        Label12.Text = "Middle Name"
        ' 
        ' CardNumberTxt
        ' 
        CardNumberTxt.Anchor = AnchorStyles.None
        CardNumberTxt.BackColor = Color.White
        CardNumberTxt.BorderStyle = BorderStyle.FixedSingle
        CardNumberTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        CardNumberTxt.ForeColor = Color.Black
        CardNumberTxt.Location = New Point(535, 468)
        CardNumberTxt.Name = "CardNumberTxt"
        CardNumberTxt.Size = New Size(443, 45)
        CardNumberTxt.TabIndex = 50
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(535, 422)
        Label10.Name = "Label10"
        Label10.Size = New Size(171, 33)
        Label10.TabIndex = 60
        Label10.Text = "Card Number"
        ' 
        ' PictureTxt
        ' 
        PictureTxt.Anchor = AnchorStyles.None
        PictureTxt.BackColor = Color.White
        PictureTxt.BorderStyle = BorderStyle.FixedSingle
        PictureTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        PictureTxt.ForeColor = Color.Black
        PictureTxt.Location = New Point(41, 468)
        PictureTxt.Name = "PictureTxt"
        PictureTxt.ReadOnly = True
        PictureTxt.Size = New Size(443, 45)
        PictureTxt.TabIndex = 49
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(41, 422)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 33)
        Label9.TabIndex = 59
        Label9.Text = "Picture"
        ' 
        ' HrShiftTxt
        ' 
        HrShiftTxt.Anchor = AnchorStyles.None
        HrShiftTxt.BorderStyle = BorderStyle.FixedSingle
        HrShiftTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        HrShiftTxt.Location = New Point(535, 350)
        HrShiftTxt.Name = "HrShiftTxt"
        HrShiftTxt.Size = New Size(200, 45)
        HrShiftTxt.TabIndex = 46
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(535, 305)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 33)
        Label8.TabIndex = 58
        Label8.Text = "Hour Shift"
        ' 
        ' PosCmb
        ' 
        PosCmb.Anchor = AnchorStyles.None
        PosCmb.Cursor = Cursors.Hand
        PosCmb.DropDownHeight = 200
        PosCmb.DropDownStyle = ComboBoxStyle.DropDownList
        PosCmb.DropDownWidth = 400
        PosCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PosCmb.FormattingEnabled = True
        PosCmb.IntegralHeight = False
        PosCmb.ItemHeight = 37
        PosCmb.Items.AddRange(New Object() {"Admin Staff", "BPSO", "Clerk", "Medical Aide", "Secretary (HRMO)"})
        PosCmb.Location = New Point(778, 351)
        PosCmb.Name = "PosCmb"
        PosCmb.Size = New Size(200, 45)
        PosCmb.Sorted = True
        PosCmb.TabIndex = 48
        ' 
        ' AddressTxt
        ' 
        AddressTxt.Anchor = AnchorStyles.None
        AddressTxt.BackColor = Color.White
        AddressTxt.BorderStyle = BorderStyle.FixedSingle
        AddressTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        AddressTxt.Location = New Point(527, 201)
        AddressTxt.Name = "AddressTxt"
        AddressTxt.ReadOnly = True
        AddressTxt.Size = New Size(200, 45)
        AddressTxt.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(527, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 33)
        Label7.TabIndex = 57
        Label7.Text = "Address"
        ' 
        ' ContactTxt
        ' 
        ContactTxt.Anchor = AnchorStyles.None
        ContactTxt.BackColor = Color.White
        ContactTxt.BorderStyle = BorderStyle.FixedSingle
        ContactTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        ContactTxt.Location = New Point(284, 201)
        ContactTxt.Name = "ContactTxt"
        ContactTxt.ReadOnly = True
        ContactTxt.Size = New Size(200, 45)
        ContactTxt.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(284, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 33)
        Label6.TabIndex = 56
        Label6.Text = "Contact"
        ' 
        ' WorkDayTxt
        ' 
        WorkDayTxt.Anchor = AnchorStyles.None
        WorkDayTxt.BorderStyle = BorderStyle.FixedSingle
        WorkDayTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        WorkDayTxt.Location = New Point(284, 350)
        WorkDayTxt.Name = "WorkDayTxt"
        WorkDayTxt.Size = New Size(200, 45)
        WorkDayTxt.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(284, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 33)
        Label5.TabIndex = 52
        Label5.Text = "Work Day"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(778, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 33)
        Label4.TabIndex = 51
        Label4.Text = "Position"
        ' 
        ' AgeTxt
        ' 
        AgeTxt.Anchor = AnchorStyles.None
        AgeTxt.BackColor = Color.White
        AgeTxt.BorderStyle = BorderStyle.FixedSingle
        AgeTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        AgeTxt.Location = New Point(41, 202)
        AgeTxt.Name = "AgeTxt"
        AgeTxt.ReadOnly = True
        AgeTxt.Size = New Size(200, 45)
        AgeTxt.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(41, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 33)
        Label3.TabIndex = 47
        Label3.Text = "Age"
        ' 
        ' FirstNameTxt
        ' 
        FirstNameTxt.Anchor = AnchorStyles.None
        FirstNameTxt.BackColor = Color.White
        FirstNameTxt.BorderStyle = BorderStyle.FixedSingle
        FirstNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        FirstNameTxt.Location = New Point(284, 92)
        FirstNameTxt.Name = "FirstNameTxt"
        FirstNameTxt.ReadOnly = True
        FirstNameTxt.Size = New Size(200, 45)
        FirstNameTxt.TabIndex = 43
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(284, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 33)
        Label2.TabIndex = 42
        Label2.Text = "First Name"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.AutoSize = True
        Label15.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(41, 305)
        Label15.Name = "Label15"
        Label15.Size = New Size(164, 33)
        Label15.TabIndex = 40
        Label15.Text = "Employee ID"
        ' 
        ' EmIDCmb
        ' 
        EmIDCmb.Anchor = AnchorStyles.None
        EmIDCmb.Cursor = Cursors.Hand
        EmIDCmb.DropDownHeight = 200
        EmIDCmb.DropDownStyle = ComboBoxStyle.DropDownList
        EmIDCmb.DropDownWidth = 400
        EmIDCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmIDCmb.FormattingEnabled = True
        EmIDCmb.IntegralHeight = False
        EmIDCmb.ItemHeight = 37
        EmIDCmb.Location = New Point(45, 350)
        EmIDCmb.Name = "EmIDCmb"
        EmIDCmb.Size = New Size(200, 45)
        EmIDCmb.Sorted = True
        EmIDCmb.TabIndex = 38
        ' 
        ' OpenBtn
        ' 
        OpenBtn.Anchor = AnchorStyles.None
        OpenBtn.BackColor = Color.LightGreen
        OpenBtn.Cursor = Cursors.Hand
        OpenBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OpenBtn.Location = New Point(41, 530)
        OpenBtn.Name = "OpenBtn"
        OpenBtn.Size = New Size(120, 50)
        OpenBtn.TabIndex = 37
        OpenBtn.Text = "OPEN"
        OpenBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateStaffBtn
        ' 
        UpdateStaffBtn.Anchor = AnchorStyles.None
        UpdateStaffBtn.BackColor = Color.LightGreen
        UpdateStaffBtn.Cursor = Cursors.Hand
        UpdateStaffBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateStaffBtn.ForeColor = Color.Black
        UpdateStaffBtn.Location = New Point(572, 571)
        UpdateStaffBtn.Name = "UpdateStaffBtn"
        UpdateStaffBtn.Size = New Size(200, 50)
        UpdateStaffBtn.TabIndex = 31
        UpdateStaffBtn.Text = "UPDATE"
        UpdateStaffBtn.UseVisualStyleBackColor = False
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(778, 571)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(200, 50)
        ReturnBtn.TabIndex = 29
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' EditStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(1280, 841)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
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
    Friend WithEvents SelectImage As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ResidentIDTxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LastNameTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MiddleNameTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CardNumberTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HrShiftTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PosCmb As ComboBox
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WorkDayTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AgeTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents EmIDCmb As ComboBox
    Friend WithEvents OpenBtn As Button
    Friend WithEvents UpdateStaffBtn As Button
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents StatusCmb As ComboBox
    Friend WithEvents Label14 As Label
End Class
