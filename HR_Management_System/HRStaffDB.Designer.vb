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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        StaffGrid = New DataGridView()
        FilterBox = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        RefreshTimer = New Timer(components)
        EID = New DataGridViewTextBoxColumn()
        EN = New DataGridViewTextBoxColumn()
        EP = New DataGridViewTextBoxColumn()
        ESCHED = New DataGridViewTextBoxColumn()
        EHRSHIFT = New DataGridViewTextBoxColumn()
        EAGE = New DataGridViewTextBoxColumn()
        ECONTACT = New DataGridViewTextBoxColumn()
        EADD = New DataGridViewTextBoxColumn()
        EDOE = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        StaffGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        StaffGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StaffGrid.Columns.AddRange(New DataGridViewColumn() {EID, EN, EP, ESCHED, EHRSHIFT, EAGE, ECONTACT, EADD, EDOE})
        StaffGrid.Dock = DockStyle.Fill
        StaffGrid.Location = New Point(0, 0)
        StaffGrid.Name = "StaffGrid"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        StaffGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        StaffGrid.Size = New Size(1146, 589)
        StaffGrid.TabIndex = 18
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
        Panel3.Controls.Add(FilterBox)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(67, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1146, 68)
        Panel3.TabIndex = 23
        ' 
        ' RefreshTimer
        ' 
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
        ' EHRSHIFT
        ' 
        EHRSHIFT.HeaderText = "HOUR SHIFT"
        EHRSHIFT.Name = "EHRSHIFT"
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
    Friend WithEvents FilterBox As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents EID As DataGridViewTextBoxColumn
    Friend WithEvents EN As DataGridViewTextBoxColumn
    Friend WithEvents EP As DataGridViewTextBoxColumn
    Friend WithEvents ESCHED As DataGridViewTextBoxColumn
    Friend WithEvents EHRSHIFT As DataGridViewTextBoxColumn
    Friend WithEvents EAGE As DataGridViewTextBoxColumn
    Friend WithEvents ECONTACT As DataGridViewTextBoxColumn
    Friend WithEvents EADD As DataGridViewTextBoxColumn
    Friend WithEvents EDOE As DataGridViewTextBoxColumn
End Class
