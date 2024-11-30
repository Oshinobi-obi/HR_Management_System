<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAttendance
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
        RFIDTxt = New TextBox()
        RFIDTap = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label1 = New Label()
        ShutdownBtn = New PictureBox()
        CType(RFIDTap, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RFIDTxt
        ' 
        RFIDTxt.Anchor = AnchorStyles.None
        RFIDTxt.Location = New Point(242, 98)
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
        RFIDTap.Location = New Point(105, 3)
        RFIDTap.Name = "RFIDTap"
        RFIDTap.Size = New Size(472, 543)
        RFIDTap.SizeMode = PictureBoxSizeMode.StretchImage
        RFIDTap.TabIndex = 0
        RFIDTap.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Controls.Add(ShutdownBtn, 2, 0)
        TableLayoutPanel1.Controls.Add(RFIDTap, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(684, 611)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(105, 552)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 56)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 56)
        Label1.TabIndex = 2
        Label1.Text = "TAP ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ShutdownBtn
        ' 
        ShutdownBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ShutdownBtn.Cursor = Cursors.Hand
        ShutdownBtn.Image = My.Resources.Resources.Shutdown
        ShutdownBtn.Location = New Point(636, 3)
        ShutdownBtn.Name = "ShutdownBtn"
        ShutdownBtn.Size = New Size(45, 40)
        ShutdownBtn.SizeMode = PictureBoxSizeMode.StretchImage
        ShutdownBtn.TabIndex = 14
        ShutdownBtn.TabStop = False
        ' 
        ' Attendance
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(684, 611)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        Controls.Add(RFIDTxt)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        WindowState = FormWindowState.Maximized
        CType(RFIDTap, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(ShutdownBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RFIDTxt As TextBox
    Friend WithEvents RFIDTap As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ShutdownBtn As PictureBox
End Class
