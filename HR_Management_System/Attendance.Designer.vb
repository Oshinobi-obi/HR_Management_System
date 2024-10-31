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
        Label1 = New Label()
        RFIDTxt = New TextBox()
        RFIDTap = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(RFIDTap, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(241, 551)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 50)
        Label1.TabIndex = 1
        Label1.Text = "TAP ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RFIDTxt
        ' 
        RFIDTxt.Anchor = AnchorStyles.None
        RFIDTxt.Location = New Point(242, 113)
        RFIDTxt.Multiline = True
        RFIDTxt.Name = "RFIDTxt"
        RFIDTxt.Size = New Size(200, 30)
        RFIDTxt.TabIndex = 2
        ' 
        ' RFIDTap
        ' 
        RFIDTap.BackColor = Color.Transparent
        RFIDTap.BackgroundImageLayout = ImageLayout.Stretch
        RFIDTap.Dock = DockStyle.Fill
        RFIDTap.Image = My.Resources.Resources.Logo_550x500_
        RFIDTap.Location = New Point(71, 3)
        RFIDTap.Name = "RFIDTap"
        RFIDTap.Size = New Size(541, 506)
        RFIDTap.SizeMode = PictureBoxSizeMode.StretchImage
        RFIDTap.TabIndex = 0
        RFIDTap.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(RFIDTap, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(684, 641)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Attendance
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(684, 641)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(RFIDTxt)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        CType(RFIDTap, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RFIDTxt As TextBox
    Friend WithEvents RFIDTap As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
