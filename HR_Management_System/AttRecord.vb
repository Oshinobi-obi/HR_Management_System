Imports Npgsql
Imports System.Data

Public Class AttRecord
    Private conn As NpgsqlConnection

    Private Sub AttRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendanceRecords()
    End Sub

    Private Sub LoadAttendanceRecords()
        Try
            ' Open connection
            OpenConnection()
            Dim query As String = "SELECT ""EmployeeName"", ""EmployeePosition"", ""EmployeeDaySchedule"" AS ""Schedule"", " &
                                  """EmployeeTimeShift"" AS ""Time Shift"", ""Date"" AS ""Log Date"", " &
                                  """TimeIn"", ""TimeOut"", ""EmployeeTotalHour"" AS ""TotalHours"" " &
                                  "FROM public.attendance ORDER BY ""Date"" DESC"
            Dim cmd As New NpgsqlCommand(query, conn)
            Dim adapter As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the data to the DataGridView
            DataGridView1.DataSource = table

        Catch ex As Exception
            MsgBox("Error loading records: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub OpenConnection()
        ' Initialize your connection string here
        Dim connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;Port=25060;Username=doadmin;Password=AVNS_TVTvL-Hw2xMPJMthE_2;Database=defaultdb;SSL Mode=Require"
        conn = New NpgsqlConnection(connString)
        conn.Open()
    End Sub

    Private Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim adminForm As New Admin()
        adminForm.Show()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Dim loginForm As New Login()
            loginForm.Show()
        End If
    End Sub
End Class
