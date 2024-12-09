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
        SetupResidentView()
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
        ResidentView.Rows.Clear()

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
        ORDER BY ""Resident_ID"";"

        Try
            Using connection As New NpgsqlConnection(connString)
                connection.Open()
                Using command As New NpgsqlCommand(query, connection)
                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim row As Object() = {
                                If(reader.IsDBNull(reader.GetOrdinal("Resident_ID")), "N/A", reader("Resident_ID").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("First_Name")), "N/A", reader("First_Name").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Middle_Name")), "N/A", reader("Middle_Name").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Last_Name")), "N/A", reader("Last_Name").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Age")), "N/A", reader("Age").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Gender")), "N/A", reader("Gender").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Contact_Number")), "N/A", reader("Contact_Number").ToString()),
                                If(reader.IsDBNull(reader.GetOrdinal("Address")), "N/A", reader("Address").ToString())
                            }
                            ResidentView.Rows.Add(row)
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
        ResidentView.Columns.Add("Resident_ID", "Resident ID")
        ResidentView.Columns.Add("First_Name", "First Name")
        ResidentView.Columns.Add("Middle_Name", "Middle Name")
        ResidentView.Columns.Add("Last_Name", "Last Name")
        ResidentView.Columns.Add("Age", "Age")
        ResidentView.Columns.Add("Sex", "Sex")
        ResidentView.Columns.Add("Contact_Number", "Contact")
        ResidentView.Columns.Add("Address", "Address")

        Dim actionColumn As New DataGridViewButtonColumn()
        actionColumn.HeaderText = "Action"
        actionColumn.Name = "Action"
        actionColumn.Text = "HIRE"
        actionColumn.UseColumnTextForButtonValue = True
        ResidentView.Columns.Add(actionColumn)
    End Sub

    Private Function IsResidentAlreadyEmployed(residentId As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM employee WHERE ""Resident_ID"" = @ResidentID;"

        Try
            Using connection As New NpgsqlConnection(connString)
                connection.Open()
                Using command As New NpgsqlCommand(query, connection)
                    Dim id As Integer = Convert.ToInt32(residentId)
                    command.Parameters.AddWithValue("@ResidentID", id)
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking employment status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Sub ResidentView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentView.CellClick
        If e.ColumnIndex = ResidentView.Columns("Action").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = ResidentView.Rows(e.RowIndex)
            Dim residentId As String = selectedRow.Cells("Resident_ID").Value.ToString()

            If IsResidentAlreadyEmployed(residentId) Then
                MessageBox.Show("This resident is already employed! Please choose another resident.", "Employment Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim firstName As String = selectedRow.Cells("First_Name").Value.ToString()
            Dim middleName As String = selectedRow.Cells("Middle_Name").Value.ToString()
            Dim lastName As String = selectedRow.Cells("Last_Name").Value.ToString()
            Dim ageString As String = selectedRow.Cells("Age").Value.ToString()
            Dim gender As String = selectedRow.Cells("Sex").Value.ToString()
            Dim contactNumber As String = selectedRow.Cells("Contact_Number").Value.ToString()
            Dim address As String = selectedRow.Cells("Address").Value.ToString()

            Dim age As Integer
            If Integer.TryParse(ageString, age) Then
                If age < 18 Then
                    MessageBox.Show("This resident is not of legal age! Unable to hire.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    MessageBox.Show("This resident is of legal age! Proceeding to hiring.", "Age Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Invalid age value for the selected resident. Unable to proceed.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim addStaffForm As New HRAddStaff()
            addStaffForm.SetResidentData(residentId, firstName, middleName, lastName, ageString, gender, contactNumber, address)

            CType(Me.MdiParent, MDIParent).LoadFormInMDI(addStaffForm)
            Me.Close()
        End If
    End Sub

End Class