<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRResidentDB
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        ResidentView = New DataGridView()
        Resident_ID = New DataGridViewTextBoxColumn()
        First_Name = New DataGridViewTextBoxColumn()
        Middle_Name = New DataGridViewTextBoxColumn()
        Last_Name = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        Contact_Number = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Action = New DataGridViewButtonColumn()
        Panel2 = New Panel()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(ResidentView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(Panel1, 1, 2)
        TableLayoutPanel1.Controls.Add(ResidentView, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Size = New Size(984, 761)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(52, 725)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(879, 33)
        Panel1.TabIndex = 3
        ' 
        ' ResidentView
        ' 
        ResidentView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ResidentView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ResidentView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ResidentView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        ResidentView.Columns.AddRange(New DataGridViewColumn() {Resident_ID, First_Name, Middle_Name, Last_Name, Age, Sex, Contact_Number, Address, Action})
        ResidentView.Cursor = Cursors.Hand
        ResidentView.Dock = DockStyle.Fill
        ResidentView.Location = New Point(52, 79)
        ResidentView.Name = "ResidentView"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ResidentView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ResidentView.Size = New Size(879, 640)
        ResidentView.TabIndex = 4
        ' 
        ' Resident_ID
        ' 
        Resident_ID.HeaderText = "Resident ID"
        Resident_ID.Name = "Resident_ID"
        ' 
        ' First_Name
        ' 
        First_Name.HeaderText = "First Name"
        First_Name.Name = "First_Name"
        ' 
        ' Middle_Name
        ' 
        Middle_Name.HeaderText = "Middle Name"
        Middle_Name.Name = "Middle_Name"
        ' 
        ' Last_Name
        ' 
        Last_Name.HeaderText = "Last Name"
        Last_Name.Name = "Last_Name"
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.Name = "Age"
        ' 
        ' Sex
        ' 
        Sex.HeaderText = "Sex"
        Sex.Name = "Sex"
        ' 
        ' Contact_Number
        ' 
        Contact_Number.HeaderText = "Contact Number"
        Contact_Number.Name = "Contact_Number"
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.Name = "Address"
        ' 
        ' Action
        ' 
        Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        Action.DefaultCellStyle = DataGridViewCellStyle2
        Action.HeaderText = "Action"
        Action.Name = "Action"
        Action.Text = "HIRE"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(52, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(879, 70)
        Panel2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(879, 70)
        Label1.TabIndex = 0
        Label1.Text = "RESIDENT LIST VIEW"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HRResidentDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 761)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRResidentDB"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(ResidentView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ResidentView As DataGridView
    Friend WithEvents Resident_ID As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Middle_Name As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Contact_Number As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
