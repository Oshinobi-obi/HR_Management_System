﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAddPosition
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
        PositionTable = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        AddBtn = New Button()
        PCodeTxt = New TextBox()
        PNameTxt = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(PositionTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(PositionTable, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Size = New Size(984, 611)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PositionTable
        ' 
        PositionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PositionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PositionTable.Dock = DockStyle.Fill
        PositionTable.Location = New Point(52, 64)
        PositionTable.Name = "PositionTable"
        PositionTable.Size = New Size(436, 513)
        PositionTable.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(52, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 55)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 55)
        Label1.TabIndex = 0
        Label1.Text = "MANAGE"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(494, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(436, 55)
        Panel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Corbel", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(436, 55)
        Label2.TabIndex = 0
        Label2.Text = "POSITION"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(AddBtn)
        Panel3.Controls.Add(PCodeTxt)
        Panel3.Controls.Add(PNameTxt)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(494, 64)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(436, 513)
        Panel3.TabIndex = 5
        ' 
        ' AddBtn
        ' 
        AddBtn.Anchor = AnchorStyles.None
        AddBtn.AutoSize = True
        AddBtn.BackColor = Color.LightGreen
        AddBtn.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddBtn.Location = New Point(336, 336)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(81, 43)
        AddBtn.TabIndex = 3
        AddBtn.Text = "ADD"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' PCodeTxt
        ' 
        PCodeTxt.Anchor = AnchorStyles.None
        PCodeTxt.BorderStyle = BorderStyle.FixedSingle
        PCodeTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PCodeTxt.Location = New Point(17, 271)
        PCodeTxt.Name = "PCodeTxt"
        PCodeTxt.Size = New Size(400, 44)
        PCodeTxt.TabIndex = 2
        ' 
        ' PNameTxt
        ' 
        PNameTxt.Anchor = AnchorStyles.None
        PNameTxt.BorderStyle = BorderStyle.FixedSingle
        PNameTxt.Font = New Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PNameTxt.Location = New Point(17, 168)
        PNameTxt.Name = "PNameTxt"
        PNameTxt.Size = New Size(400, 44)
        PNameTxt.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(17, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 33)
        Label4.TabIndex = 1
        Label4.Text = "Position Code"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 33)
        Label3.TabIndex = 1
        Label3.Text = "Position Name"
        ' 
        ' HRAddPosition
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(233), CByte(233))
        ClientSize = New Size(984, 611)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "HRAddPosition"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        TableLayoutPanel1.ResumeLayout(False)
        CType(PositionTable, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PositionTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PNameTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PCodeTxt As TextBox
    Friend WithEvents AddBtn As Button
End Class
