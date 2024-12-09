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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        ReturnBtn = New Button()
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
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ResidentView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 2)
        TableLayoutPanel1.Controls.Add(ResidentView, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(984, 761)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(864, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 108)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ReturnBtn)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(126, 687)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(732, 71)
        Panel1.TabIndex = 3
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(296, 10)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(140, 50)
        ReturnBtn.TabIndex = 2
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
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
        ResidentView.Location = New Point(126, 117)
        ResidentView.Name = "ResidentView"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ResidentView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ResidentView.Size = New Size(732, 564)
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(ResidentView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReturnBtn As Button
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
End Class
