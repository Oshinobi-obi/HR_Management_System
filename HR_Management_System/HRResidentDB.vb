Imports System.Drawing.Drawing2D
Imports Npgsql

Public Class HRResidentDB
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Public Sub HRResidentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeButton(ReturnBtn, "RETURN", Color.LightCoral)
        InitializeButton(HireBtn, "HIRE", Color.LightGreen)
        LoadResidentData()
    End Sub

    Private Sub InitializeButton(button As Button, text As String, backColor As Color)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.Transparent
        button.Text = text
        AddHandler button.Paint, Sub(sender, e) PaintRoundedButton(button, e, backColor)
    End Sub

    Private Sub PaintRoundedButton(button As Button, e As PaintEventArgs, color As Color)
        Dim graphics As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, button.Width - 1, button.Height - 1)
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As New GraphicsPath()
            Dim radius As Integer = 20
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            Using brush As New SolidBrush(color)
                graphics.FillPath(brush, path)
            End Using

            Using borderPen As New Pen(Color.Black, 2)
                graphics.DrawPath(borderPen, path)
            End Using

            Dim textBrush As New SolidBrush(button.ForeColor)
            Dim textFormat As New StringFormat() With {
                .Alignment = StringAlignment.Center,
                .LineAlignment = StringAlignment.Center
            }
            graphics.DrawString(button.Text, button.Font, textBrush, rect, textFormat)
        End Using
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim StaffDB As New HRStaffDB()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(StaffDB)
        Me.Close()
    End Sub

    Private Sub LoadResidentData()
        Dim query As String = "SELECT ""Resident_ID"", ""First_Name"", ""Middle_Name"", ""Last_Name"", " &
                              "EXTRACT(YEAR FROM AGE(NOW(), ""Date_Of_Birth"")) AS Age, " &
                              """Sex"", ""Contact_Number"", ""House_Number"", ""Street_Name"", ""Subdivision"" " &
                              "FROM ""Residents"";"

        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        ResidentView.Items.Clear()
                        While reader.Read()
                            Dim listItem As New ListViewItem(reader("Resident_ID").ToString())
                            listItem.SubItems.Add(reader("First_Name").ToString())
                            listItem.SubItems.Add(reader("Middle_Name").ToString())
                            listItem.SubItems.Add(reader("Last_Name").ToString())
                            listItem.SubItems.Add(reader("Age").ToString())
                            listItem.SubItems.Add(reader("Sex").ToString())
                            listItem.SubItems.Add(reader("Contact_Number").ToString())
                            listItem.SubItems.Add(reader("House_Number").ToString())
                            listItem.SubItems.Add(reader("Street_Name").ToString())
                            listItem.SubItems.Add(reader("Subdivision").ToString())
                            ResidentView.Items.Add(listItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

End Class