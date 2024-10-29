<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        RFIDTap = New PictureBox()
        Label1 = New Label()
        RFIDtxt = New TextBox()
        CType(RFIDTap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RFIDTap
        ' 
        RFIDTap.Anchor = AnchorStyles.None
        RFIDTap.BackColor = Color.Transparent
        RFIDTap.BackgroundImageLayout = ImageLayout.Stretch
        RFIDTap.Image = My.Resources.Resources.Logo_550x500_
        RFIDTap.Location = New Point(96, 33)
        RFIDTap.Name = "RFIDTap"
        RFIDTap.Size = New Size(550, 500)
        RFIDTap.TabIndex = 0
        RFIDTap.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(280, 551)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 41)
        Label1.TabIndex = 2
        Label1.Text = "SCAN RFID"
        ' 
        ' RFIDtxt
        ' 
        RFIDtxt.Location = New Point(317, 55)
        RFIDtxt.Name = "RFIDtxt"
        RFIDtxt.Size = New Size(100, 23)
        RFIDtxt.TabIndex = 1
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(734, 611)
        Controls.Add(Label1)
        Controls.Add(RFIDTap)
        Controls.Add(RFIDtxt)
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        CType(RFIDTap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RFIDTap As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RFIDtxt As TextBox
End Class
