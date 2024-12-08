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
        TableLayoutPanel1 = New TableLayoutPanel()
        ResidentView = New ListView()
        Resident_ID = New ColumnHeader()
        First_Name = New ColumnHeader()
        Middle_Name = New ColumnHeader()
        Last_Name = New ColumnHeader()
        Age = New ColumnHeader()
        Gender = New ColumnHeader()
        Contact_Number = New ColumnHeader()
        House_Number = New ColumnHeader()
        Street_Name = New ColumnHeader()
        Subdivision = New ColumnHeader()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        HireBtn = New Button()
        ReturnBtn = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(ResidentView, 1, 1)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Size = New Size(984, 761)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' ResidentView
        ' 
        ResidentView.BorderStyle = BorderStyle.FixedSingle
        ResidentView.Columns.AddRange(New ColumnHeader() {Resident_ID, First_Name, Middle_Name, Last_Name, Age, Gender, Contact_Number, House_Number, Street_Name, Subdivision})
        ResidentView.Dock = DockStyle.Fill
        ResidentView.FullRowSelect = True
        ResidentView.Location = New Point(126, 98)
        ResidentView.Name = "ResidentView"
        ResidentView.Size = New Size(732, 564)
        ResidentView.TabIndex = 0
        ResidentView.UseCompatibleStateImageBehavior = False
        ' 
        ' Resident_ID
        ' 
        Resident_ID.Text = "Resident ID"
        ' 
        ' First_Name
        ' 
        First_Name.Text = "First Name"
        First_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' Middle_Name
        ' 
        Middle_Name.Text = "Middle Name"
        Middle_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' Last_Name
        ' 
        Last_Name.Text = "Last Name"
        Last_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' Age
        ' 
        Age.Text = "Age"
        Age.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gender
        ' 
        Gender.Text = "Sex"
        Gender.TextAlign = HorizontalAlignment.Center
        ' 
        ' Contact_Number
        ' 
        Contact_Number.Text = "Contact Number"
        Contact_Number.TextAlign = HorizontalAlignment.Center
        ' 
        ' House_Number
        ' 
        House_Number.Text = "House Number"
        House_Number.TextAlign = HorizontalAlignment.Center
        ' 
        ' Street_Name
        ' 
        Street_Name.Text = "Street_Name"
        Street_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' Subdivision
        ' 
        Subdivision.Text = "Subdivision"
        Subdivision.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.St__Monica_Logo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 89)
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
        PictureBox2.Size = New Size(117, 89)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(HireBtn)
        Panel1.Controls.Add(ReturnBtn)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(126, 668)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(732, 90)
        Panel1.TabIndex = 3
        ' 
        ' HireBtn
        ' 
        HireBtn.Anchor = AnchorStyles.None
        HireBtn.BackColor = Color.LightGreen
        HireBtn.Cursor = Cursors.Hand
        HireBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HireBtn.ForeColor = Color.Black
        HireBtn.Location = New Point(210, 18)
        HireBtn.Name = "HireBtn"
        HireBtn.Size = New Size(140, 50)
        HireBtn.TabIndex = 16
        HireBtn.Text = "HIRE"
        HireBtn.UseVisualStyleBackColor = False
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Anchor = AnchorStyles.None
        ReturnBtn.BackColor = Color.LightCoral
        ReturnBtn.Cursor = Cursors.Hand
        ReturnBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(382, 18)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(140, 50)
        ReturnBtn.TabIndex = 2
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' HRResidentDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 761)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "HRResidentDB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HRResidentDB"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ResidentView As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Resident_ID As ColumnHeader
    Friend WithEvents First_Name As ColumnHeader
    Friend WithEvents Middle_Name As ColumnHeader
    Friend WithEvents Last_Name As ColumnHeader
    Friend WithEvents Age As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents Contact_Number As ColumnHeader
    Friend WithEvents House_Number As ColumnHeader
    Friend WithEvents Street_Name As ColumnHeader
    Friend WithEvents Subdivision As ColumnHeader
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents HireBtn As Button
End Class
