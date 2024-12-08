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
        PopulateResidentView()
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

    Private Sub PopulateResidentView()
        ResidentView.Items.Clear()

        Dim query As String = "
        SELECT 
            \"Resident_ID\",
            \"First_Name\",
            \"Middle_Name\",
            \"Last_Name\",
            EXTRACT(YEAR FROM AGE(CURRENT_DATE, \"Date_Of_Birth\")) AS \"Age\",
            \"Sex\" AS \"Gender\",
            \"Contact_Number\",
            \"House_Number\",
            \"Street_Name\",
            \"Subdivision\"
        FROM 
            public.\"Residents\";"

    Try
            Using connection As New NpgsqlConnection(connString)
                connection.Open()
                Using command As New NpgsqlCommand(query, connection)
                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim residentId As String = If(reader.IsDBNull(reader.GetOrdinal("Resident_ID")), "N/A", reader("Resident_ID").ToString())
                            Dim firstName As String = If(reader.IsDBNull(reader.GetOrdinal("First_Name")), "N/A", reader("First_Name").ToString())
                            Dim middleName As String = If(reader.IsDBNull(reader.GetOrdinal("Middle_Name")), "N/A", reader("Middle_Name").ToString())
                            Dim lastName As String = If(reader.IsDBNull(reader.GetOrdinal("Last_Name")), "N/A", reader("Last_Name").ToString())
                            Dim age As String = If(reader.IsDBNull(reader.GetOrdinal("Age")), "N/A", reader("Age").ToString())
                            Dim gender As String = If(reader.IsDBNull(reader.GetOrdinal("Gender")), "N/A", reader("Gender").ToString())
                            Dim contactNumber As String = If(reader.IsDBNull(reader.GetOrdinal("Contact_Number")), "N/A", reader("Contact_Number").ToString())
                            Dim houseNumber As String = If(reader.IsDBNull(reader.GetOrdinal("House_Number")), "N/A", reader("House_Number").ToString())
                            Dim streetName As String = If(reader.IsDBNull(reader.GetOrdinal("Street_Name")), "N/A", reader("Street_Name").ToString())
                            Dim subdivision As String = If(reader.IsDBNull(reader.GetOrdinal("Subdivision")), "N/A", reader("Subdivision").ToString())

                            Dim item As New ListViewItem(residentId)
                            item.SubItems.Add(firstName)
                            item.SubItems.Add(middleName)
                            item.SubItems.Add(lastName)
                            item.SubItems.Add(age)
                            item.SubItems.Add(gender)
                            item.SubItems.Add(contactNumber)
                            item.SubItems.Add(houseNumber)
                            item.SubItems.Add(streetName)
                            item.SubItems.Add(subdivision)

                            ResidentView.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class