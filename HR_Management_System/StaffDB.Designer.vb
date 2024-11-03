<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDB
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
        ReturnBtn = New Button()
        StaffGrid = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        AddBtn = New Button()
        FilterBox = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(StaffGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(254, 2)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(150, 43)
        ReturnBtn.TabIndex = 3
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' StaffGrid
        ' 
        StaffGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StaffGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        StaffGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StaffGrid.Dock = DockStyle.Fill
        StaffGrid.Location = New Point(0, 0)
        StaffGrid.Name = "StaffGrid"
        StaffGrid.Size = New Size(657, 351)
        StaffGrid.TabIndex = 18
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(776, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(105, 96)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' AddBtn
        ' 
        AddBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AddBtn.BackColor = Color.LightGreen
        AddBtn.Cursor = Cursors.Hand
        AddBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddBtn.Location = New Point(198, 48)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(100, 42)
        AddBtn.TabIndex = 1
        AddBtn.Text = "ADD"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' FilterBox
        ' 
        FilterBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        FilterBox.Cursor = Cursors.Hand
        FilterBox.DropDownStyle = ComboBoxStyle.DropDownList
        FilterBox.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FilterBox.FormattingEnabled = True
        FilterBox.Location = New Point(304, 49)
        FilterBox.Name = "FilterBox"
        FilterBox.Size = New Size(350, 45)
        FilterBox.TabIndex = 2
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
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 2)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(884, 511)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(StaffGrid)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(113, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(657, 351)
        Panel1.TabIndex = 21
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ReturnBtn)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(113, 462)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(657, 46)
        Panel2.TabIndex = 22
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(FilterBox)
        Panel3.Controls.Add(AddBtn)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(113, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(657, 96)
        Panel3.TabIndex = 23
        ' 
        ' StaffDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 511)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "StaffDB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff List"
        WindowState = FormWindowState.Maximized
        CType(StaffGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ReturnBtn As Button
    Friend WithEvents StaffGrid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents FilterBox As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
