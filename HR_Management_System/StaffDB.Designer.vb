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
        Button2 = New Button()
        LogOutBtn = New Button()
        DataGridView1 = New DataGridView()
        EID = New DataGridViewTextBoxColumn()
        EN = New DataGridViewTextBoxColumn()
        Position = New DataGridViewTextBoxColumn()
        Schedule = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        DOE = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        AddBtn = New Button()
        FilterBox = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(539, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 16
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.AutoSize = True
        LogOutBtn.BackColor = Color.Red
        LogOutBtn.BackgroundImageLayout = ImageLayout.Center
        LogOutBtn.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.White
        LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogOutBtn.Location = New Point(632, 388)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(156, 50)
        LogOutBtn.TabIndex = 17
        LogOutBtn.Text = "LOGOUT"
        LogOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {EID, EN, Position, Schedule, Age, Contact, DOE})
        DataGridView1.Location = New Point(12, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 237)
        DataGridView1.TabIndex = 18
        ' 
        ' EID
        ' 
        EID.HeaderText = "Employee ID"
        EID.Name = "EID"
        ' 
        ' EN
        ' 
        EN.HeaderText = "Name"
        EN.Name = "EN"
        ' 
        ' Position
        ' 
        Position.HeaderText = "Position"
        Position.Name = "Position"
        ' 
        ' Schedule
        ' 
        Schedule.HeaderText = "Schedule"
        Schedule.Name = "Schedule"
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.Name = "Age"
        ' 
        ' Contact
        ' 
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        ' 
        ' DOE
        ' 
        DOE.HeaderText = "DOE"
        DOE.Name = "DOE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(688, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 95)
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(366, 116)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(75, 23)
        AddBtn.TabIndex = 21
        AddBtn.Text = "ADD"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' FilterBox
        ' 
        FilterBox.FormattingEnabled = True
        FilterBox.Items.AddRange(New Object() {"BPSO", "Lupon Tagapamayapa", "Secretary", "Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV", "BNS", "Medical Aide", "Clerk", "Sangguniang Kabataan"})
        FilterBox.Location = New Point(447, 116)
        FilterBox.Name = "FilterBox"
        FilterBox.Size = New Size(121, 23)
        FilterBox.TabIndex = 22
        ' 
        ' StaffDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(FilterBox)
        Controls.Add(AddBtn)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(LogOutBtn)
        Controls.Add(Button2)
        Name = "StaffDB"
        Text = "StaffDB"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EID As DataGridViewTextBoxColumn
    Friend WithEvents EN As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Schedule As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents DOE As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents FilterBox As ComboBox
End Class
