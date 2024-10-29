Imports Npgsql

Module DatabaseConnection
    Public conn As NpgsqlConnection

    Private connString As String = "Host=db-postgresql-sgp1-sbit3f-do-user-13901833-0.l.db.ondigitalocean.com;" &
                                   "Port=25060;" &
                                   "Username=doadmin;" &
                                   "Password=AVNS_TVTvL-Hw2xMPJMthE_2;" &
                                   "Database=defaultdb;" &
                                   "SSL Mode=Require"

    Public Sub OpenConnection()
        Try
            conn = New NpgsqlConnection(connString)
            conn.Open()
            Console.WriteLine("Database connected successfully.")
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
            Console.WriteLine("Database connection closed.")
        End If
    End Sub
End Module
