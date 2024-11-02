Imports Npgsql

Public Class StaffDb
    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Private Sub EmployeeRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFilterBox()
        LoadEmployeeRecords()
    End Sub

    Private Sub PopulateFilterBox()
        Dim positions As String() = {"All", "BPSO", "Lupon Tagapamayapa", "Secretary", "Admin Aide I", "Admin Aide II", "Admin Aide III", "Admin Aide IV", "BNS", "Medical Aide", "Clerk", "Sangguniang Kabataan"}
        FilterBox.Items.AddRange(positions)
        FilterBox.SelectedIndex = 0 ' Set default to "All"
    End Sub

    Private Sub LoadEmployeeRecords(Optional positionFilter As String = "")
        Try
            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String
                If String.IsNullOrEmpty(positionFilter) OrElse positionFilter = "All" Then
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"" FROM ""employee"""
                Else
                    query = "SELECT ""EmployeeID"", ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"", ""EmployeeAge"", ""EmployeeMobile"", ""EmployeeAddress"" FROM ""employee"" WHERE ""EmployeePosition"" = @position"
                End If

                Using cmd As New NpgsqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(positionFilter) AndAlso positionFilter <> "All" Then
                        cmd.Parameters.AddWithValue("@position", positionFilter)
                    End If

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading employee records: " & ex.Message)
        End Try
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Dim loginForm As New Login()
            loginForm.Show()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Me.Close()
        Dim addStaffForm As New AddStaff()
        addStaffForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim adminForm As New Admin()
        adminForm.Show()
    End Sub

    Private Sub FilterBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterBox.SelectedIndexChanged
        Dim selectedPosition As String = FilterBox.SelectedItem.ToString()

        If selectedPosition = "All" Then
            LoadEmployeeRecords() ' Load all employee records
        Else
            LoadEmployeeRecords(selectedPosition) ' Load filtered records
        End If
    End Sub
End Class
