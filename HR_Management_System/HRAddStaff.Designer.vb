<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAddStaff
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
        components = New ComponentModel.Container()
        AddStaffPanel = New Panel()
        EmailTxt = New TextBox()
        Label16 = New Label()
        WorkDayChkBox = New CheckedListBox()
        HrShiftCmb = New ComboBox()
        GenderTxt = New TextBox()
        Label14 = New Label()
        ResidentIDTxt = New TextBox()
        Label13 = New Label()
        LastNameTxt = New TextBox()
        Label11 = New Label()
        MiddleNameTxt = New TextBox()
        Label12 = New Label()
        Label8 = New Label()
        PosCmb = New ComboBox()
        AddressTxt = New TextBox()
        Label7 = New Label()
        ContactTxt = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        AgeTxt = New TextBox()
        Label3 = New Label()
        FirstNameTxt = New TextBox()
        Label2 = New Label()
        EmIDTxt = New TextBox()
        Label1 = New Label()
        CardNumberTxt = New TextBox()
        Label10 = New Label()
        OpenBtn = New Button()
        PictureTxt = New TextBox()
        Label9 = New Label()
        AddStaffBtn = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label15 = New Label()
        SelectImage = New OpenFileDialog()
        NotifyIcon1 = New NotifyIcon(components)
        AddStaffPanel.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddStaffPanel
        ' 
        AddStaffPanel.Controls.Add(EmailTxt)
        AddStaffPanel.Controls.Add(Label16)
        AddStaffPanel.Controls.Add(WorkDayChkBox)
        AddStaffPanel.Controls.Add(HrShiftCmb)
        AddStaffPanel.Controls.Add(GenderTxt)
        AddStaffPanel.Controls.Add(Label14)
        AddStaffPanel.Controls.Add(ResidentIDTxt)
        AddStaffPanel.Controls.Add(Label13)
        AddStaffPanel.Controls.Add(LastNameTxt)
        AddStaffPanel.Controls.Add(Label11)
        AddStaffPanel.Controls.Add(MiddleNameTxt)
        AddStaffPanel.Controls.Add(Label12)
        AddStaffPanel.Controls.Add(Label8)
        AddStaffPanel.Controls.Add(PosCmb)
        AddStaffPanel.Controls.Add(AddressTxt)
        AddStaffPanel.Controls.Add(Label7)
        AddStaffPanel.Controls.Add(ContactTxt)
        AddStaffPanel.Controls.Add(Label6)
        AddStaffPanel.Controls.Add(Label5)
        AddStaffPanel.Controls.Add(Label4)
        AddStaffPanel.Controls.Add(AgeTxt)
        AddStaffPanel.Controls.Add(Label3)
        AddStaffPanel.Controls.Add(FirstNameTxt)
        AddStaffPanel.Controls.Add(Label2)
        AddStaffPanel.Controls.Add(EmIDTxt)
        AddStaffPanel.Controls.Add(Label1)
        AddStaffPanel.Controls.Add(CardNumberTxt)
        AddStaffPanel.Controls.Add(Label10)
        AddStaffPanel.Controls.Add(OpenBtn)
        AddStaffPanel.Controls.Add(PictureTxt)
        AddStaffPanel.Controls.Add(Label9)
        AddStaffPanel.Controls.Add(AddStaffBtn)
        AddStaffPanel.Dock = DockStyle.Fill
        AddStaffPanel.Location = New Point(67, 87)
        AddStaffPanel.Name = "AddStaffPanel"
        AddStaffPanel.Size = New Size(1146, 751)
        AddStaffPanel.TabIndex = 0
        ' 
        ' EmailTxt
        ' 
        EmailTxt.Anchor = AnchorStyles.None
        EmailTxt.BackColor = Color.White
        EmailTxt.BorderStyle = BorderStyle.FixedSingle
        EmailTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        EmailTxt.ForeColor = Color.Black
        EmailTxt.Location = New Point(588, 485)
        EmailTxt.Name = "EmailTxt"
        EmailTxt.Size = New Size(528, 45)
        EmailTxt.TabIndex = 29
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.None
        Label16.AutoSize = True
        Label16.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(588, 449)
        Label16.Name = "Label16"
        Label16.Size = New Size(89, 33)
        Label16.TabIndex = 30
        Label16.Text = "Email:"
        ' 
        ' WorkDayChkBox
        ' 
        WorkDayChkBox.Anchor = AnchorStyles.None
        WorkDayChkBox.BackColor = Color.White
        WorkDayChkBox.BorderStyle = BorderStyle.FixedSingle
        WorkDayChkBox.CheckOnClick = True
        WorkDayChkBox.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WorkDayChkBox.FormattingEnabled = True
        WorkDayChkBox.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        WorkDayChkBox.Location = New Point(309, 348)
        WorkDayChkBox.Name = "WorkDayChkBox"
        WorkDayChkBox.ScrollAlwaysVisible = True
        WorkDayChkBox.Size = New Size(250, 107)
        WorkDayChkBox.TabIndex = 28
        ' 
        ' HrShiftCmb
        ' 
        HrShiftCmb.Anchor = AnchorStyles.None
        HrShiftCmb.BackColor = Color.White
        HrShiftCmb.Cursor = Cursors.Hand
        HrShiftCmb.DropDownHeight = 100
        HrShiftCmb.DropDownStyle = ComboBoxStyle.DropDownList
        HrShiftCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HrShiftCmb.FormattingEnabled = True
        HrShiftCmb.IntegralHeight = False
        HrShiftCmb.Items.AddRange(New Object() {"1 Hour", "2 Hours", "3 Hours", "4 Hours", "5 Hours", "6 Hours", "7 Hours", "8 Hours", "9 Hours", "10 Hours", "11 Hours", "12 Hours"})
        HrShiftCmb.Location = New Point(587, 348)
        HrShiftCmb.Name = "HrShiftCmb"
        HrShiftCmb.Size = New Size(250, 45)
        HrShiftCmb.TabIndex = 27
        ' 
        ' GenderTxt
        ' 
        GenderTxt.Anchor = AnchorStyles.None
        GenderTxt.BackColor = Color.White
        GenderTxt.BorderStyle = BorderStyle.FixedSingle
        GenderTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        GenderTxt.Location = New Point(309, 219)
        GenderTxt.Name = "GenderTxt"
        GenderTxt.ReadOnly = True
        GenderTxt.Size = New Size(250, 45)
        GenderTxt.TabIndex = 7
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(309, 183)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 33)
        Label14.TabIndex = 26
        Label14.Text = "Sex:"
        ' 
        ' ResidentIDTxt
        ' 
        ResidentIDTxt.Anchor = AnchorStyles.None
        ResidentIDTxt.BackColor = Color.White
        ResidentIDTxt.BorderStyle = BorderStyle.FixedSingle
        ResidentIDTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        ResidentIDTxt.Location = New Point(31, 90)
        ResidentIDTxt.Name = "ResidentIDTxt"
        ResidentIDTxt.ReadOnly = True
        ResidentIDTxt.Size = New Size(250, 45)
        ResidentIDTxt.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(31, 54)
        Label13.Name = "Label13"
        Label13.Size = New Size(157, 33)
        Label13.TabIndex = 24
        Label13.Text = "Resident ID:"
        ' 
        ' LastNameTxt
        ' 
        LastNameTxt.Anchor = AnchorStyles.None
        LastNameTxt.BackColor = Color.White
        LastNameTxt.BorderStyle = BorderStyle.FixedSingle
        LastNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        LastNameTxt.Location = New Point(865, 90)
        LastNameTxt.Name = "LastNameTxt"
        LastNameTxt.ReadOnly = True
        LastNameTxt.Size = New Size(250, 45)
        LastNameTxt.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(865, 54)
        Label11.Name = "Label11"
        Label11.Size = New Size(150, 33)
        Label11.TabIndex = 22
        Label11.Text = "Last Name:"
        ' 
        ' MiddleNameTxt
        ' 
        MiddleNameTxt.Anchor = AnchorStyles.None
        MiddleNameTxt.BackColor = Color.White
        MiddleNameTxt.BorderStyle = BorderStyle.FixedSingle
        MiddleNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        MiddleNameTxt.Location = New Point(587, 90)
        MiddleNameTxt.Name = "MiddleNameTxt"
        MiddleNameTxt.ReadOnly = True
        MiddleNameTxt.Size = New Size(250, 45)
        MiddleNameTxt.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(587, 54)
        Label12.Name = "Label12"
        Label12.Size = New Size(180, 33)
        Label12.TabIndex = 21
        Label12.Text = "Middle Name:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(587, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 33)
        Label8.TabIndex = 13
        Label8.Text = "Hour Shift:"
        ' 
        ' PosCmb
        ' 
        PosCmb.Anchor = AnchorStyles.None
        PosCmb.BackColor = Color.White
        PosCmb.Cursor = Cursors.Hand
        PosCmb.DropDownHeight = 100
        PosCmb.DropDownStyle = ComboBoxStyle.DropDownList
        PosCmb.DropDownWidth = 250
        PosCmb.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PosCmb.FormattingEnabled = True
        PosCmb.IntegralHeight = False
        PosCmb.ItemHeight = 37
        PosCmb.Items.AddRange(New Object() {"Admin Staff", "BPSO", "Clerk", "Medical Aide", "Secretary (HRMO)"})
        PosCmb.Location = New Point(865, 348)
        PosCmb.Name = "PosCmb"
        PosCmb.Size = New Size(250, 45)
        PosCmb.Sorted = True
        PosCmb.TabIndex = 12
        ' 
        ' AddressTxt
        ' 
        AddressTxt.Anchor = AnchorStyles.None
        AddressTxt.BackColor = Color.White
        AddressTxt.BorderStyle = BorderStyle.FixedSingle
        AddressTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        AddressTxt.Location = New Point(865, 219)
        AddressTxt.Name = "AddressTxt"
        AddressTxt.ReadOnly = True
        AddressTxt.Size = New Size(250, 45)
        AddressTxt.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(865, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 33)
        Label7.TabIndex = 11
        Label7.Text = "Address:"
        ' 
        ' ContactTxt
        ' 
        ContactTxt.Anchor = AnchorStyles.None
        ContactTxt.BackColor = Color.White
        ContactTxt.BorderStyle = BorderStyle.FixedSingle
        ContactTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        ContactTxt.Location = New Point(587, 219)
        ContactTxt.Name = "ContactTxt"
        ContactTxt.ReadOnly = True
        ContactTxt.Size = New Size(250, 45)
        ContactTxt.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(587, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 33)
        Label6.TabIndex = 9
        Label6.Text = "Contact:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(309, 312)
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
        Label4.Location = New Point(865, 312)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 33)
        Label4.TabIndex = 6
        Label4.Text = "Position:"
        ' 
        ' AgeTxt
        ' 
        AgeTxt.Anchor = AnchorStyles.None
        AgeTxt.BackColor = Color.White
        AgeTxt.BorderStyle = BorderStyle.FixedSingle
        AgeTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        AgeTxt.Location = New Point(31, 219)
        AgeTxt.Name = "AgeTxt"
        AgeTxt.ReadOnly = True
        AgeTxt.Size = New Size(250, 45)
        AgeTxt.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 33)
        Label3.TabIndex = 4
        Label3.Text = "Age:"
        ' 
        ' FirstNameTxt
        ' 
        FirstNameTxt.Anchor = AnchorStyles.None
        FirstNameTxt.BackColor = Color.White
        FirstNameTxt.BorderStyle = BorderStyle.FixedSingle
        FirstNameTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        FirstNameTxt.Location = New Point(309, 90)
        FirstNameTxt.Name = "FirstNameTxt"
        FirstNameTxt.ReadOnly = True
        FirstNameTxt.Size = New Size(250, 45)
        FirstNameTxt.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(309, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 33)
        Label2.TabIndex = 2
        Label2.Text = "First Name:"
        ' 
        ' EmIDTxt
        ' 
        EmIDTxt.Anchor = AnchorStyles.None
        EmIDTxt.BackColor = Color.White
        EmIDTxt.BorderStyle = BorderStyle.FixedSingle
        EmIDTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        EmIDTxt.Location = New Point(31, 348)
        EmIDTxt.Name = "EmIDTxt"
        EmIDTxt.ReadOnly = True
        EmIDTxt.Size = New Size(250, 45)
        EmIDTxt.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 312)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 33)
        Label1.TabIndex = 0
        Label1.Text = "Employee ID:"
        ' 
        ' CardNumberTxt
        ' 
        CardNumberTxt.Anchor = AnchorStyles.None
        CardNumberTxt.BackColor = Color.White
        CardNumberTxt.BorderStyle = BorderStyle.FixedSingle
        CardNumberTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        CardNumberTxt.ForeColor = Color.Black
        CardNumberTxt.Location = New Point(31, 485)
        CardNumberTxt.Name = "CardNumberTxt"
        CardNumberTxt.Size = New Size(528, 45)
        CardNumberTxt.TabIndex = 14
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(31, 449)
        Label10.Name = "Label10"
        Label10.Size = New Size(179, 33)
        Label10.TabIndex = 17
        Label10.Text = "Card Number:"
        ' 
        ' OpenBtn
        ' 
        OpenBtn.Anchor = AnchorStyles.None
        OpenBtn.BackColor = Color.LightGreen
        OpenBtn.Cursor = Cursors.Hand
        OpenBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OpenBtn.Location = New Point(31, 647)
        OpenBtn.Name = "OpenBtn"
        OpenBtn.Size = New Size(120, 50)
        OpenBtn.TabIndex = 16
        OpenBtn.Text = "ADD"
        OpenBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureTxt
        ' 
        PictureTxt.Anchor = AnchorStyles.None
        PictureTxt.BackColor = Color.White
        PictureTxt.BorderStyle = BorderStyle.FixedSingle
        PictureTxt.Font = New Font("Corbel", 22.8000011F, FontStyle.Bold)
        PictureTxt.ForeColor = Color.Black
        PictureTxt.Location = New Point(31, 587)
        PictureTxt.Name = "PictureTxt"
        PictureTxt.ReadOnly = True
        PictureTxt.Size = New Size(528, 45)
        PictureTxt.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 551)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 33)
        Label9.TabIndex = 14
        Label9.Text = "Picture:"
        ' 
        ' AddStaffBtn
        ' 
        AddStaffBtn.Anchor = AnchorStyles.None
        AddStaffBtn.BackColor = Color.LightGreen
        AddStaffBtn.Cursor = Cursors.Hand
        AddStaffBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffBtn.ForeColor = Color.Black
        AddStaffBtn.Location = New Point(916, 587)
        AddStaffBtn.Name = "AddStaffBtn"
        AddStaffBtn.Size = New Size(200, 50)
        AddStaffBtn.TabIndex = 15
        AddStaffBtn.Text = "ADD STAFF"
        AddStaffBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(AddStaffPanel, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.Size = New Size(1280, 841)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label15)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(67, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1146, 78)
        Panel1.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.Dock = DockStyle.Fill
        Label15.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(1146, 78)
        Label15.TabIndex = 1
        Label15.Text = "ADD STAFF"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' HRAddStaff
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(1280, 841)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRAddStaff"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        WindowState = FormWindowState.Maximized
        AddStaffPanel.ResumeLayout(False)
        AddStaffPanel.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents AddStaffPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents AgeTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PosCmb As ComboBox
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddStaffBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenBtn As Button
    Friend WithEvents PictureTxt As TextBox
    Friend WithEvents SelectImage As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents CardNumberTxt As TextBox
    Friend WithEvents LastNameTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MiddleNameTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ResidentIDTxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GenderTxt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents HrShiftCmb As ComboBox
    Friend WithEvents WorkDayChkBox As CheckedListBox
    Friend WithEvents EmIDTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents Label16 As Label
End Class
