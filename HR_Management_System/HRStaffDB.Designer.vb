<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRStaffDB
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        StaffGrid = New DataGridView()
        EID = New DataGridViewTextBoxColumn()
        EN = New DataGridViewTextBoxColumn()
        EP = New DataGridViewTextBoxColumn()
        ESCHED = New DataGridViewTextBoxColumn()
        EAGE = New DataGridViewTextBoxColumn()
        ECONTACT = New DataGridViewTextBoxColumn()
        EADD = New DataGridViewTextBoxColumn()
        EDOE = New DataGridViewTextBoxColumn()
        ResidentListBtn = New Button()
        FilterBox = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        AddPositionBtn = New Button()
        EditBtn = New Button()
        RefreshTimer = New Timer(components)
        CType(StaffGrid, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' StaffGrid
        ' 
        StaffGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StaffGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        StaffGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        StaffGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        StaffGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StaffGrid.Columns.AddRange(New DataGridViewColumn() {EID, EN, EP, ESCHED, EAGE, ECONTACT, EADD, EDOE})
        StaffGrid.Dock = DockStyle.Fill
        StaffGrid.Location = New Point(0, 0)
        StaffGrid.Name = "StaffGrid"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        StaffGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        StaffGrid.Size = New Size(1146, 589)
        StaffGrid.TabIndex = 18
        ' 
        ' EID
        ' 
        EID.HeaderText = "EMPLOYEE ID"
        EID.Name = "EID"
        ' 
        ' EN
        ' 
        EN.HeaderText = "NAME"
        EN.Name = "EN"
        ' 
        ' EP
        ' 
        EP.HeaderText = "POSITION"
        EP.Name = "EP"
        ' 
        ' ESCHED
        ' 
        ESCHED.HeaderText = "SCHEDULE"
        ESCHED.Name = "ESCHED"
        ' 
        ' EAGE
        ' 
        EAGE.HeaderText = "AGE"
        EAGE.Name = "EAGE"
        ' 
        ' ECONTACT
        ' 
        ECONTACT.HeaderText = "CONTACT"
        ECONTACT.Name = "ECONTACT"
        ' 
        ' EADD
        ' 
        EADD.HeaderText = "ADDRESS"
        EADD.Name = "EADD"
        ' 
        ' EDOE
        ' 
        EDOE.HeaderText = "DOE"
        EDOE.Name = "EDOE"
        ' 
        ' ResidentListBtn
        ' 
        ResidentListBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ResidentListBtn.BackColor = Color.LightGreen
        ResidentListBtn.Cursor = Cursors.Hand
        ResidentListBtn.Font = New Font("Corbel", 18F, FontStyle.Bold)
        ResidentListBtn.Location = New Point(438, 21)
        ResidentListBtn.Name = "ResidentListBtn"
        ResidentListBtn.Size = New Size(200, 42)
        ResidentListBtn.TabIndex = 1
        ResidentListBtn.Text = "RESIDENT LIST"
        ResidentListBtn.UseVisualStyleBackColor = False
        ' 
        ' FilterBox
        ' 
        FilterBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        FilterBox.Cursor = Cursors.Hand
        FilterBox.DropDownStyle = ComboBoxStyle.DropDownList
        FilterBox.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FilterBox.FormattingEnabled = True
        FilterBox.Location = New Point(796, 20)
        FilterBox.Name = "FilterBox"
        FilterBox.Size = New Size(350, 45)
        FilterBox.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.5263157F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 84.2105255F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.263158F))
        TableLayoutPanel1.Size = New Size(1280, 707)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(StaffGrid)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(67, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1146, 589)
        Panel1.TabIndex = 21
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(AddPositionBtn)
        Panel3.Controls.Add(EditBtn)
        Panel3.Controls.Add(FilterBox)
        Panel3.Controls.Add(ResidentListBtn)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(67, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1146, 68)
        Panel3.TabIndex = 23
        ' 
        ' AddPositionBtn
        ' 
        AddPositionBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AddPositionBtn.BackColor = Color.LightGreen
        AddPositionBtn.Cursor = Cursors.Hand
        AddPositionBtn.Font = New Font("Corbel", 18F, FontStyle.Bold)
        AddPositionBtn.Location = New Point(644, 21)
        AddPositionBtn.Name = "AddPositionBtn"
        AddPositionBtn.Size = New Size(143, 42)
        AddPositionBtn.TabIndex = 4
        AddPositionBtn.Text = "ADD POS"
        AddPositionBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        EditBtn.BackColor = Color.LightGreen
        EditBtn.Cursor = Cursors.Hand
        EditBtn.Font = New Font("Corbel", 18F, FontStyle.Bold)
        EditBtn.Location = New Point(232, 21)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(200, 42)
        EditBtn.TabIndex = 3
        EditBtn.Text = "EDIT STAFF"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' RefreshTimer
        ' 
        ' 
        ' HRStaffDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 707)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRStaffDB"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        WindowState = FormWindowState.Maximized
        CType(StaffGrid, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents StaffGrid As DataGridView
    Friend WithEvents ResidentListBtn As Button
    Friend WithEvents FilterBox As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents EID As DataGridViewTextBoxColumn
    Friend WithEvents EN As DataGridViewTextBoxColumn
    Friend WithEvents EP As DataGridViewTextBoxColumn
    Friend WithEvents ESCHED As DataGridViewTextBoxColumn
    Friend WithEvents EAGE As DataGridViewTextBoxColumn
    Friend WithEvents ECONTACT As DataGridViewTextBoxColumn
    Friend WithEvents EADD As DataGridViewTextBoxColumn
    Friend WithEvents EDOE As DataGridViewTextBoxColumn
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddPositionBtn As Button
    Friend WithEvents RefreshTimer As Timer
End Class
