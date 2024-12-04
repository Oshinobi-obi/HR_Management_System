<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAttRecord
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
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ReturnBtn = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        AttendanceYear = New ComboBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        AttendanceGrid = New DataGridView()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(AttendanceGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(819, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(112, 96)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(694, 96)
        Label1.TabIndex = 5
        Label1.Text = "ATTENDANCE RECORD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(397, 463)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(137, 42)
        ReturnBtn.TabIndex = 1
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(ReturnBtn, 1, 3)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 57.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(934, 511)
        TableLayoutPanel1.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(AttendanceYear)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(119, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(694, 57)
        Panel1.TabIndex = 7
        ' 
        ' AttendanceYear
        ' 
        AttendanceYear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AttendanceYear.Cursor = Cursors.Hand
        AttendanceYear.DropDownStyle = ComboBoxStyle.DropDownList
        AttendanceYear.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AttendanceYear.FormattingEnabled = True
        AttendanceYear.Items.AddRange(New Object() {"TODAY", "YESTERDAY", "THIS WEEK", "THIS MONTH", "QUARTERLY", "SEMIANNUAL", "ANNUAL"})
        AttendanceYear.Location = New Point(375, 4)
        AttendanceYear.Name = "AttendanceYear"
        AttendanceYear.Size = New Size(314, 49)
        AttendanceYear.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(119, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(694, 96)
        Panel2.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(AttendanceGrid)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(119, 168)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(694, 287)
        Panel3.TabIndex = 16
        ' 
        ' AttendanceGrid
        ' 
        AttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AttendanceGrid.Dock = DockStyle.Fill
        AttendanceGrid.Location = New Point(0, 0)
        AttendanceGrid.Name = "AttendanceGrid"
        AttendanceGrid.Size = New Size(694, 287)
        AttendanceGrid.TabIndex = 0
        ' 
        ' HRAttRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(934, 511)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "HRAttRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance Record"
        WindowState = FormWindowState.Maximized
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(AttendanceGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AttendanceGrid As DataGridView
    Friend WithEvents AttendanceYear As ComboBox
End Class
