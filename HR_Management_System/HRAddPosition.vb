Imports Npgsql

Public Class HRAddPosition
    Private connectionString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Private Sub ReloadPositionTable()
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT positionname, positioncode FROM public.employeeposition ORDER BY datecreated DESC"
                Dim adapter As New NpgsqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                PositionTable.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading positions: " & ex.Message)
        End Try
    End Sub

    Private Sub AddPosition(positionName As String, positionCode As String)
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO public.employeeposition (positionname, positioncode, datecreated) VALUES (@name, @code, CURRENT_DATE)"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", positionName)
                    cmd.Parameters.AddWithValue("@code", positionCode)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Position added successfully!")
            End Using
            ReloadPositionTable()
        Catch ex As Exception
            MessageBox.Show("Error adding position: " & ex.Message)
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim positionName As String = PNameTxt.Text.Trim()
        Dim positionCode As String = PCodeTxt.Text.Trim()

        If String.IsNullOrWhiteSpace(positionName) OrElse String.IsNullOrWhiteSpace(positionCode) Then
            MessageBox.Show("Please enter both position name and code.")
            Return
        End If

        AddPosition(positionName, positionCode)
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        ' Return to HRAdmin form and load in the ButtonPanel or wherever it should appear
        Dim adminForm As New HRAdmin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(adminForm)
        Me.Close()
    End Sub


    Private Sub HRAddPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadPositionTable()
    End Sub
End Class
