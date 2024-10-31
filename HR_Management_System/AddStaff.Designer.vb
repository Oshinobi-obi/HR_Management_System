<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        LogOutBtn = New Button()
        ReturnBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 95)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(927, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 95)
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 113)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1015, 225)
        Panel1.TabIndex = 22
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 26
        ComboBox1.Items.AddRange(New Object() {"BPSO", "Lupon Tagapamayapa", "Secretary", "Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV", "BNS", "Medical Aide", "Clerk", "Sangguniang Kabataan"})
        ComboBox1.Location = New Point(770, 54)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(225, 34)
        ComboBox1.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(521, 144)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(225, 35)
        TextBox7.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(521, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 33)
        Label7.TabIndex = 11
        Label7.Text = "Address"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(271, 144)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(225, 35)
        TextBox6.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(271, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 33)
        Label6.TabIndex = 9
        Label6.Text = "Contact"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(21, 144)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(225, 35)
        TextBox5.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 33)
        Label5.TabIndex = 7
        Label5.Text = "Schedule"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(770, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 33)
        Label4.TabIndex = 6
        Label4.Text = "Position"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(521, 54)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(225, 35)
        TextBox3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(521, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 33)
        Label3.TabIndex = 4
        Label3.Text = "Age"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(271, 54)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 35)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(271, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 33)
        Label2.TabIndex = 2
        Label2.Text = "Employee Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(21, 54)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(225, 35)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 33)
        Label1.TabIndex = 0
        Label1.Text = "Employee ID"
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.AutoSize = True
        LogOutBtn.BackColor = Color.Red
        LogOutBtn.BackgroundImageLayout = ImageLayout.Center
        LogOutBtn.Font = New Font("Corbel", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.White
        LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogOutBtn.Location = New Point(871, 368)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(156, 50)
        LogOutBtn.TabIndex = 19
        LogOutBtn.Text = "LOGOUT"
        LogOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBtn.Location = New Point(709, 367)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(156, 50)
        ReturnBtn.TabIndex = 18
        ReturnBtn.Text = "RETURN"
        ReturnBtn.UseVisualStyleBackColor = True
        ' 
        ' AddStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1039, 441)
        Controls.Add(LogOutBtn)
        Controls.Add(ReturnBtn)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddStaff"
        Text = "AddStaff"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents ReturnBtn As Button
End Class
