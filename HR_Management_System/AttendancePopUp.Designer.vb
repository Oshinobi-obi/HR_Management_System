﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendancePopUp
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
        AttendancePanel = New Panel()
        EMIDTxt = New TextBox()
        EIDTxt = New TextBox()
        TimeOutTxt = New TextBox()
        TimeInTxt = New TextBox()
        HourShiftTxt = New TextBox()
        DaySchedTxt = New TextBox()
        DateTxt = New TextBox()
        PosTxt = New TextBox()
        ENTxt = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        EPic = New PictureBox()
        ENTxt1 = New TextBox()
        EIDTxt1 = New TextBox()
        alay = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        AttendancePanel.SuspendLayout()
        CType(EPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AttendancePanel
        ' 
        AttendancePanel.Controls.Add(EMIDTxt)
        AttendancePanel.Controls.Add(EIDTxt)
        AttendancePanel.Controls.Add(TimeOutTxt)
        AttendancePanel.Controls.Add(TimeInTxt)
        AttendancePanel.Controls.Add(HourShiftTxt)
        AttendancePanel.Controls.Add(DaySchedTxt)
        AttendancePanel.Controls.Add(DateTxt)
        AttendancePanel.Controls.Add(PosTxt)
        AttendancePanel.Controls.Add(ENTxt)
        AttendancePanel.Controls.Add(Label10)
        AttendancePanel.Controls.Add(Label9)
        AttendancePanel.Controls.Add(Label8)
        AttendancePanel.Controls.Add(Label7)
        AttendancePanel.Controls.Add(Label6)
        AttendancePanel.Controls.Add(Label5)
        AttendancePanel.Controls.Add(Label4)
        AttendancePanel.Controls.Add(Label3)
        AttendancePanel.Controls.Add(Label2)
        AttendancePanel.Controls.Add(EPic)
        AttendancePanel.Controls.Add(ENTxt1)
        AttendancePanel.Controls.Add(EIDTxt1)
        AttendancePanel.Controls.Add(alay)
        AttendancePanel.Dock = DockStyle.Fill
        AttendancePanel.Location = New Point(151, 132)
        AttendancePanel.Margin = New Padding(3, 0, 3, 3)
        AttendancePanel.Name = "AttendancePanel"
        AttendancePanel.Size = New Size(882, 459)
        AttendancePanel.TabIndex = 0
        ' 
        ' EMIDTxt
        ' 
        EMIDTxt.Anchor = AnchorStyles.None
        EMIDTxt.BorderStyle = BorderStyle.FixedSingle
        EMIDTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        EMIDTxt.Location = New Point(401, 125)
        EMIDTxt.Name = "EMIDTxt"
        EMIDTxt.ReadOnly = True
        EMIDTxt.Size = New Size(200, 37)
        EMIDTxt.TabIndex = 33
        ' 
        ' EIDTxt
        ' 
        EIDTxt.Anchor = AnchorStyles.None
        EIDTxt.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        EIDTxt.BorderStyle = BorderStyle.None
        EIDTxt.Font = New Font("Corbel", 34.8F, FontStyle.Bold)
        EIDTxt.Location = New Point(171, 25)
        EIDTxt.Multiline = True
        EIDTxt.Name = "EIDTxt"
        EIDTxt.Size = New Size(550, 55)
        EIDTxt.TabIndex = 26
        EIDTxt.Text = "STAFF INFORMATION"
        EIDTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' TimeOutTxt
        ' 
        TimeOutTxt.Anchor = AnchorStyles.None
        TimeOutTxt.BorderStyle = BorderStyle.FixedSingle
        TimeOutTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        TimeOutTxt.Location = New Point(637, 358)
        TimeOutTxt.Name = "TimeOutTxt"
        TimeOutTxt.ReadOnly = True
        TimeOutTxt.Size = New Size(200, 37)
        TimeOutTxt.TabIndex = 32
        TimeOutTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' TimeInTxt
        ' 
        TimeInTxt.Anchor = AnchorStyles.None
        TimeInTxt.BorderStyle = BorderStyle.FixedSingle
        TimeInTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        TimeInTxt.Location = New Point(400, 359)
        TimeInTxt.Name = "TimeInTxt"
        TimeInTxt.ReadOnly = True
        TimeInTxt.Size = New Size(200, 37)
        TimeInTxt.TabIndex = 31
        TimeInTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' HourShiftTxt
        ' 
        HourShiftTxt.Anchor = AnchorStyles.None
        HourShiftTxt.BorderStyle = BorderStyle.FixedSingle
        HourShiftTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        HourShiftTxt.Location = New Point(635, 280)
        HourShiftTxt.Name = "HourShiftTxt"
        HourShiftTxt.ReadOnly = True
        HourShiftTxt.Size = New Size(200, 37)
        HourShiftTxt.TabIndex = 30
        HourShiftTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' DaySchedTxt
        ' 
        DaySchedTxt.Anchor = AnchorStyles.None
        DaySchedTxt.BorderStyle = BorderStyle.FixedSingle
        DaySchedTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        DaySchedTxt.Location = New Point(400, 280)
        DaySchedTxt.Name = "DaySchedTxt"
        DaySchedTxt.ReadOnly = True
        DaySchedTxt.Size = New Size(200, 37)
        DaySchedTxt.TabIndex = 29
        ' 
        ' DateTxt
        ' 
        DateTxt.Anchor = AnchorStyles.None
        DateTxt.BorderStyle = BorderStyle.FixedSingle
        DateTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        DateTxt.Location = New Point(635, 202)
        DateTxt.Name = "DateTxt"
        DateTxt.ReadOnly = True
        DateTxt.Size = New Size(200, 37)
        DateTxt.TabIndex = 28
        DateTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PosTxt
        ' 
        PosTxt.Anchor = AnchorStyles.None
        PosTxt.BorderStyle = BorderStyle.FixedSingle
        PosTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        PosTxt.Location = New Point(400, 202)
        PosTxt.Name = "PosTxt"
        PosTxt.ReadOnly = True
        PosTxt.Size = New Size(200, 37)
        PosTxt.TabIndex = 27
        ' 
        ' ENTxt
        ' 
        ENTxt.Anchor = AnchorStyles.None
        ENTxt.BorderStyle = BorderStyle.FixedSingle
        ENTxt.Font = New Font("Corbel", 18F, FontStyle.Bold)
        ENTxt.Location = New Point(635, 125)
        ENTxt.Name = "ENTxt"
        ENTxt.ReadOnly = True
        ENTxt.Size = New Size(200, 37)
        ENTxt.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(605, 352)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 41)
        Label10.TabIndex = 17
        Label10.Text = "-"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(635, 328)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 27)
        Label9.TabIndex = 16
        Label9.Text = "TIME-OUT"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(400, 328)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 27)
        Label8.TabIndex = 15
        Label8.Text = "TIME-IN"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(635, 250)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 27)
        Label7.TabIndex = 14
        Label7.Text = "WORK HOURS"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(396, 250)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 27)
        Label6.TabIndex = 13
        Label6.Text = "DAY SCHEDULE"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(635, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 27)
        Label5.TabIndex = 12
        Label5.Text = "DATE"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(396, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 27)
        Label4.TabIndex = 11
        Label4.Text = "POSITION"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(635, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 27)
        Label3.TabIndex = 10
        Label3.Text = "EMPLOYEE NAME"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(396, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 27)
        Label2.TabIndex = 9
        Label2.Text = "EMPLOYEE ID"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EPic
        ' 
        EPic.Anchor = AnchorStyles.None
        EPic.BackColor = Color.Transparent
        EPic.BackgroundImageLayout = ImageLayout.Stretch
        EPic.Location = New Point(45, 95)
        EPic.Name = "EPic"
        EPic.Size = New Size(300, 300)
        EPic.TabIndex = 0
        EPic.TabStop = False
        ' 
        ' ENTxt1
        ' 
        ENTxt1.Anchor = AnchorStyles.None
        ENTxt1.BorderStyle = BorderStyle.FixedSingle
        ENTxt1.Font = New Font("Corbel", 18F, FontStyle.Bold)
        ENTxt1.Location = New Point(540, 37)
        ENTxt1.Name = "ENTxt1"
        ENTxt1.ReadOnly = True
        ENTxt1.Size = New Size(72, 37)
        ENTxt1.TabIndex = 18
        ' 
        ' EIDTxt1
        ' 
        EIDTxt1.Anchor = AnchorStyles.None
        EIDTxt1.BorderStyle = BorderStyle.FixedSingle
        EIDTxt1.Font = New Font("Corbel", 18F, FontStyle.Bold)
        EIDTxt1.Location = New Point(322, 37)
        EIDTxt1.Name = "EIDTxt1"
        EIDTxt1.ReadOnly = True
        EIDTxt1.Size = New Size(73, 37)
        EIDTxt1.TabIndex = 4
        ' 
        ' alay
        ' 
        alay.Anchor = AnchorStyles.None
        alay.BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        alay.BorderStyle = BorderStyle.None
        alay.Font = New Font("Corbel", 18F, FontStyle.Bold)
        alay.ForeColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        alay.Location = New Point(264, 39)
        alay.Name = "alay"
        alay.ReadOnly = True
        alay.Size = New Size(10, 30)
        alay.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Logo_100x95_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 126)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.SPLQ_100x95_
        PictureBox2.Location = New Point(1039, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(142, 126)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(882, 126)
        Label1.TabIndex = 3
        Label1.Text = "ATTENDANCE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(AttendancePanel, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(1184, 661)
        TableLayoutPanel1.TabIndex = 19
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(151, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 126)
        Panel1.TabIndex = 4
        ' 
        ' AttendancePopUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(1184, 661)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AttendancePopUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        WindowState = FormWindowState.Maximized
        AttendancePanel.ResumeLayout(False)
        AttendancePanel.PerformLayout()
        CType(EPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents AttendancePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents alay As TextBox
    Friend WithEvents ENTxt1 As TextBox
    Friend WithEvents EIDTxt1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EMIDTxt As TextBox
    Friend WithEvents EIDTxt As TextBox
    Friend WithEvents TimeOutTxt As TextBox
    Friend WithEvents TimeInTxt As TextBox
    Friend WithEvents HourShiftTxt As TextBox
    Friend WithEvents DaySchedTxt As TextBox
    Friend WithEvents DateTxt As TextBox
    Friend WithEvents PosTxt As TextBox
    Friend WithEvents ENTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EPic As PictureBox
End Class
