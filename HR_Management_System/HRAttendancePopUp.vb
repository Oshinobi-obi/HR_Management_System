Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class HRAttendancePopUp

    Private isEditable As Boolean = False

    Public Sub SetEmployeeData(employeeData As Dictionary(Of String, String))

        If employeeData IsNot Nothing Then
            If employeeData IsNot Nothing Then
                EMIDTxt.Text = employeeData.GetValueOrDefault("EmployeeID", "N/A")
                ENTxt.Text = employeeData.GetValueOrDefault("EmployeeName", "N/A")
                PosTxt.Text = employeeData.GetValueOrDefault("EmployeePosition", "N/A")
                DaySchedTxt.Text = employeeData.GetValueOrDefault("EmployeeDaySchedule", "N/A")
                DateTxt.Text = employeeData.GetValueOrDefault("DateNow", "N/A")
                TimeInTxt.Text = employeeData.GetValueOrDefault("TimeIn", "N/A")
                TimeOutTxt.Text = employeeData.GetValueOrDefault("TimeOut", "N/A")
                HourShiftTxt.Text = employeeData.GetValueOrDefault("EmployeeTotalHour", "0")
            End If

            If employeeData.ContainsKey("TimeOut") Then
                TimeOutTxt.Text = employeeData("TimeOut")
            End If

            If employeeData.ContainsKey("HourShift") Then
                HourShiftTxt.Text = employeeData("EmployeeTotalHour").ToString("F2")
            End If
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = CType(ctrl, TextBox)
                txtBox.ReadOnly = Not isEditable
                txtBox.BackColor = Color.White
                txtBox.ForeColor = Color.Black
            End If
        Next

    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles EMIDTxt.Enter, ENTxt.Enter, PosTxt.Enter, DaySchedTxt.Enter, DateTxt.Enter, TimeInTxt.Enter, TimeOutTxt.Enter, HourShiftTxt.Enter
        If Not isEditable Then
            Me.ActiveControl = Nothing
        End If
    End Sub

    Private Sub AttendancePanel_Paint(sender As Object, e As PaintEventArgs) Handles AttendancePanel.Paint
        DrawRoundedPanelBorder(e.Graphics, AttendancePanel, 20, 2)
    End Sub

    Private Sub DrawRoundedPanelBorder(graphics As Graphics, panel As Panel, cornerRadius As Integer, borderSize As Integer)
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As New GraphicsPath()
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
            path.AddArc(panel.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90)
            path.AddArc(panel.Width - cornerRadius - 1, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90)
            path.AddArc(0, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(panel.BackColor)
                graphics.FillPath(brush, path)
            End Using

            Using pen As New Pen(Color.Black, borderSize)
                graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

End Class