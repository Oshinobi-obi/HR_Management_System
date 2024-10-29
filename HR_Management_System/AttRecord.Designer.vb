<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttRecord
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
        AttTable = New DataGridView()
        EName = New DataGridViewTextBoxColumn()
        Position = New DataGridViewTextBoxColumn()
        Schedule = New DataGridViewTextBoxColumn()
        Time_Shift = New DataGridViewTextBoxColumn()
        LogDate = New DataGridViewTextBoxColumn()
        TimeIn = New DataGridViewTextBoxColumn()
        TimeOut = New DataGridViewTextBoxColumn()
        LogOutBtn = New Button()
        Button2 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AttTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(688, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 95)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(149, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 58)
        Label1.TabIndex = 5
        Label1.Text = "ATTENDANCE RECORD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AttTable
        ' 
        AttTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AttTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        AttTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AttTable.Columns.AddRange(New DataGridViewColumn() {EName, Position, Schedule, Time_Shift, LogDate, TimeIn, TimeOut})
        AttTable.GridColor = Color.Black
        AttTable.Location = New Point(12, 113)
        AttTable.Name = "AttTable"
        AttTable.Size = New Size(776, 273)
        AttTable.TabIndex = 6
        ' 
        ' EName
        ' 
        EName.HeaderText = "Name"
        EName.Name = "EName"
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
        ' Time_Shift
        ' 
        Time_Shift.HeaderText = "Time Shift"
        Time_Shift.Name = "Time_Shift"
        ' 
        ' LogDate
        ' 
        LogDate.HeaderText = "Log Date"
        LogDate.Name = "LogDate"
        ' 
        ' TimeIn
        ' 
        TimeIn.HeaderText = "Time In"
        TimeIn.Name = "TimeIn"
        ' 
        ' TimeOut
        ' 
        TimeOut.HeaderText = "Time Out"
        TimeOut.Name = "TimeOut"
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.AutoSize = True
        LogOutBtn.BackColor = Color.Red
        LogOutBtn.BackgroundImageLayout = ImageLayout.Center
        LogOutBtn.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.White
        LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogOutBtn.Location = New Point(632, 392)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(156, 50)
        LogOutBtn.TabIndex = 8
        LogOutBtn.Text = "LOGOUT"
        LogOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(537, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 15
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' AttRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(LogOutBtn)
        Controls.Add(AttTable)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "AttRecord"
        Text = "AttRecord"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(AttTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AttTable As DataGridView
    Friend WithEvents EName As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Schedule As DataGridViewTextBoxColumn
    Friend WithEvents Time_Shift As DataGridViewTextBoxColumn
    Friend WithEvents LogDate As DataGridViewTextBoxColumn
    Friend WithEvents TimeIn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOut As DataGridViewTextBoxColumn
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents Button2 As Button
End Class
