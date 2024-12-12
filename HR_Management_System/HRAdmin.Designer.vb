<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAdmin
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
        ButtonsPanel = New Panel()
        AddPositionBtn = New Button()
        ResidentListBtn = New Button()
        EditBtn = New Button()
        LogOutBtn = New Button()
        SecurityBtn = New LinkLabel()
        VSBtn = New Button()
        AttBtn = New Button()
        NameTxt = New Label()
        PictureBox2 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        MainPanel = New Panel()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ButtonsPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(ButtonsPanel, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.Size = New Size(200, 845)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 162)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ButtonsPanel
        ' 
        ButtonsPanel.Controls.Add(AddPositionBtn)
        ButtonsPanel.Controls.Add(ResidentListBtn)
        ButtonsPanel.Controls.Add(EditBtn)
        ButtonsPanel.Controls.Add(LogOutBtn)
        ButtonsPanel.Controls.Add(SecurityBtn)
        ButtonsPanel.Controls.Add(VSBtn)
        ButtonsPanel.Controls.Add(AttBtn)
        ButtonsPanel.Controls.Add(NameTxt)
        ButtonsPanel.Controls.Add(PictureBox2)
        ButtonsPanel.Dock = DockStyle.Fill
        ButtonsPanel.Location = New Point(4, 173)
        ButtonsPanel.Name = "ButtonsPanel"
        ButtonsPanel.Size = New Size(192, 668)
        ButtonsPanel.TabIndex = 1
        ' 
        ' AddPositionBtn
        ' 
        AddPositionBtn.Anchor = AnchorStyles.None
        AddPositionBtn.BackColor = Color.White
        AddPositionBtn.Cursor = Cursors.Hand
        AddPositionBtn.Font = New Font("Corbel", 18F, FontStyle.Bold)
        AddPositionBtn.Location = New Point(21, 515)
        AddPositionBtn.Name = "AddPositionBtn"
        AddPositionBtn.Size = New Size(150, 42)
        AddPositionBtn.TabIndex = 7
        AddPositionBtn.Text = "Position"
        AddPositionBtn.UseVisualStyleBackColor = False
        ' 
        ' ResidentListBtn
        ' 
        ResidentListBtn.Anchor = AnchorStyles.None
        ResidentListBtn.BackColor = Color.White
        ResidentListBtn.Cursor = Cursors.Hand
        ResidentListBtn.Font = New Font("Corbel", 18F, FontStyle.Bold)
        ResidentListBtn.Location = New Point(21, 456)
        ResidentListBtn.Name = "ResidentListBtn"
        ResidentListBtn.Size = New Size(150, 42)
        ResidentListBtn.TabIndex = 6
        ResidentListBtn.Text = "Resident"
        ResidentListBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.Anchor = AnchorStyles.None
        EditBtn.BackColor = Color.White
        EditBtn.Cursor = Cursors.Hand
        EditBtn.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditBtn.Location = New Point(21, 397)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(150, 42)
        EditBtn.TabIndex = 4
        EditBtn.Text = "Edit Staff"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Anchor = AnchorStyles.None
        LogOutBtn.Cursor = Cursors.Hand
        LogOutBtn.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.Image = My.Resources.Resources.Logout_1
        LogOutBtn.Location = New Point(21, 611)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(150, 39)
        LogOutBtn.TabIndex = 5
        LogOutBtn.Text = "Logout"
        LogOutBtn.TextAlign = ContentAlignment.MiddleRight
        LogOutBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        LogOutBtn.UseVisualStyleBackColor = True
        ' 
        ' SecurityBtn
        ' 
        SecurityBtn.Anchor = AnchorStyles.None
        SecurityBtn.Cursor = Cursors.Hand
        SecurityBtn.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SecurityBtn.LinkBehavior = LinkBehavior.NeverUnderline
        SecurityBtn.LinkColor = Color.Black
        SecurityBtn.Location = New Point(21, 245)
        SecurityBtn.Name = "SecurityBtn"
        SecurityBtn.Size = New Size(150, 23)
        SecurityBtn.TabIndex = 4
        SecurityBtn.TabStop = True
        SecurityBtn.Text = "Sec. Settings"
        SecurityBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VSBtn
        ' 
        VSBtn.Anchor = AnchorStyles.None
        VSBtn.Cursor = Cursors.Hand
        VSBtn.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VSBtn.Location = New Point(21, 341)
        VSBtn.Name = "VSBtn"
        VSBtn.Size = New Size(150, 39)
        VSBtn.TabIndex = 3
        VSBtn.Text = "View Staff"
        VSBtn.UseVisualStyleBackColor = True
        ' 
        ' AttBtn
        ' 
        AttBtn.Anchor = AnchorStyles.None
        AttBtn.Cursor = Cursors.Hand
        AttBtn.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AttBtn.Location = New Point(21, 285)
        AttBtn.Name = "AttBtn"
        AttBtn.Size = New Size(150, 39)
        AttBtn.TabIndex = 2
        AttBtn.Text = "Att. Record"
        AttBtn.UseVisualStyleBackColor = True
        ' 
        ' NameTxt
        ' 
        NameTxt.Anchor = AnchorStyles.None
        NameTxt.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameTxt.Location = New Point(21, 188)
        NameTxt.Name = "NameTxt"
        NameTxt.Size = New Size(150, 40)
        NameTxt.TabIndex = 1
        NameTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.Male_User1
        PictureBox2.Location = New Point(21, 21)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 150)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(MainPanel, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(200, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(1340, 845)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' MainPanel
        ' 
        MainPanel.BorderStyle = BorderStyle.FixedSingle
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(3, 3)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1334, 839)
        MainPanel.TabIndex = 0
        ' 
        ' HRAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1540, 845)
        ControlBox = False
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRAdmin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "HR Admin"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ButtonsPanel.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AttBtn As Button
    Friend WithEvents NameTxt As Label
    Friend WithEvents VSBtn As Button
    Friend WithEvents SecurityBtn As LinkLabel
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents ResidentListBtn As Button
    Friend WithEvents AddPositionBtn As Button
End Class
