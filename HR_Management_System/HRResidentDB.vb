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
        SetupResidentView() ' Set up the columns for ResidentView
        PopulateResidentView() ' Populate the data

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

        ' Updated query with sorting by Resident_ID
        Dim query As String = "
    SELECT 
        ""Resident_ID"",
        ""First_Name"",
        ""Middle_Name"",
        ""Last_Name"",
        EXTRACT(YEAR FROM AGE(CURRENT_DATE, ""Date_Of_Birth"")) AS ""Age"",
        ""Sex"" AS ""Gender"",
        ""Contact_Number"",
        CONCAT(
            COALESCE(""House_Number"", ''), ' ',
            COALESCE(""Street_Name"", ''), ' ',
            COALESCE(""Subdivision"", '')
        ) AS ""Address""
    FROM 
        public.""Residents""
    ORDER BY ""Resident_ID"";"  ' Make sure the order is by Resident_ID

        Try
            Using connection As New NpgsqlConnection(connString)
                connection.Open()
                Using command As New NpgsqlCommand(query, connection)
                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Retrieve values for each column
                            Dim residentId As String = If(reader.IsDBNull(reader.GetOrdinal("Resident_ID")), "N/A", reader("Resident_ID").ToString())
                            Dim firstName As String = If(reader.IsDBNull(reader.GetOrdinal("First_Name")), "N/A", reader("First_Name").ToString())
                            Dim middleName As String = If(reader.IsDBNull(reader.GetOrdinal("Middle_Name")), "N/A", reader("Middle_Name").ToString())
                            Dim lastName As String = If(reader.IsDBNull(reader.GetOrdinal("Last_Name")), "N/A", reader("Last_Name").ToString())
                            Dim age As String = If(reader.IsDBNull(reader.GetOrdinal("Age")), "N/A", reader("Age").ToString())
                            Dim gender As String = If(reader.IsDBNull(reader.GetOrdinal("Gender")), "N/A", reader("Gender").ToString())
                            Dim contactNumber As String = If(reader.IsDBNull(reader.GetOrdinal("Contact_Number")), "N/A", reader("Contact_Number").ToString())
                            Dim address As String = If(reader.IsDBNull(reader.GetOrdinal("Address")), "N/A", reader("Address").ToString())

                            ' Create a new ListView item
                            Dim item As New ListViewItem(residentId)
                            item.SubItems.Add(firstName)
                            item.SubItems.Add(middleName)
                            item.SubItems.Add(lastName)
                            item.SubItems.Add(age)
                            item.SubItems.Add(gender)
                            item.SubItems.Add(contactNumber)
                            item.SubItems.Add(address)

                            ' Add the item to the ResidentView
                            ResidentView.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetupResidentView()
        ResidentView.Columns.Clear()
        ResidentView.Columns.Add("ResidentID", 100)
        ResidentView.Columns.Add("FirstName", 100)
        ResidentView.Columns.Add("MiddleName", 100)
        ResidentView.Columns.Add("LastName", 100)
        ResidentView.Columns.Add("Age", 50)
        ResidentView.Columns.Add("Sex", 50)
        ResidentView.Columns.Add("Contact", 100)
        ResidentView.Columns.Add("Address", 200) ' Combines House_Number, Street_Name, and Subdivision
        ResidentView.View = View.Details
        ResidentView.FullRowSelect = True
        ResidentView.GridLines = True
    End Sub

    Private Sub HireBtn_Click(sender As Object, e As EventArgs) Handles HireBtn.Click
        ' Ensure a row is selected
        If ResidentView.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a resident to hire.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the selected resident data
        Dim selectedItem As ListViewItem = ResidentView.SelectedItems(0)
        Dim residentId As String = selectedItem.SubItems(0).Text
        Dim firstName As String = selectedItem.SubItems(1).Text
        Dim middleName As String = selectedItem.SubItems(2).Text
        Dim lastName As String = selectedItem.SubItems(3).Text
        Dim age As String = selectedItem.SubItems(4).Text
        Dim gender As String = selectedItem.SubItems(5).Text
        Dim contactNumber As String = selectedItem.SubItems(6).Text
        Dim address As String = selectedItem.SubItems(7).Text

        ' Pass the data to HRAddStaff
        Dim addStaffForm As New HRAddStaff()
        addStaffForm.SetResidentData(residentId, firstName, middleName, lastName, age, gender, contactNumber, address)

        ' Display HRAddStaff form
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(addStaffForm)
        Me.Close()
    End Sub
End Class