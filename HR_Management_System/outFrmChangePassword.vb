Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Npgsql

Module ChangePasswordConsoleTest
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New outFrmChangePassword("02-02-02-01"))
    End Sub
End Module

Public Class outFrmChangePassword
    Private connectionString As New NpgsqlConnection(conn.ConnectionString)

    Private isValidSyntax As Boolean = False
    Private empID As String

    Public Sub New(id As String)
        InitializeComponent()

        empID = id
        Dim currentPassword As String = GetPasswordByAccountID(id)
        txtCurrentPassword.Text = If(String.IsNullOrEmpty(currentPassword), "No password found", currentPassword)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        If Not isValidSyntax Then
            MessageBox.Show("Invalid password syntax! Password must include:" & Environment.NewLine &
                            "• One Uppercase Letter" & Environment.NewLine &
                            "• One Lowercase Letter" & Environment.NewLine &
                            "• One Number" & Environment.NewLine &
                            "• One Symbol" & Environment.NewLine &
                            "• At least 11 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match." & Environment.NewLine &
                            $"Password: {password}" & Environment.NewLine &
                            $"Confirm Password: {confirmPassword}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ChangePassword(password)
        UpdateIsDefaultPassword(empID)

        Dim loginForm As New HRLogin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(loginForm)
        Me.Close()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ValidatePassword()
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        ValidateConfirmPassword()
    End Sub

    Private Sub ValidatePassword()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        Dim upperCase As New Regex("[A-Z]")
        Dim lowerCase As New Regex("[a-z]")
        Dim number As New Regex("\d")
        Dim symbol As New Regex("[^a-zA-Z0-9]")
        Dim minLength As Integer = 11
        Dim maxLength As Integer = 30

        If Not upperCase.IsMatch(password) Then
            SetPasswordStatus("Must contain one Uppercase Letter!", Color.Red, False)
            Exit Sub
        End If
        If Not lowerCase.IsMatch(password) Then
            SetPasswordStatus("Must contain one Lowercase Letter!", Color.Red, False)
            Exit Sub
        End If
        If Not number.IsMatch(password) Then
            SetPasswordStatus("Must contain one Number!", Color.Red, False)
            Exit Sub
        End If
        If Not symbol.IsMatch(password) Then
            SetPasswordStatus("Must contain one Symbol!", Color.Red, False)
            Exit Sub
        End If
        If password.Length < minLength Then
            SetPasswordStatus($"Must be at least {minLength} characters!", Color.Red, False)
            Exit Sub
        End If
        If password.Length > maxLength Then
            SetPasswordStatus($"Must be fewer than {maxLength} characters!", Color.Red, False)
            Exit Sub
        End If

        lblPasswordStatus.Text = "Valid"
        lblPasswordStatus.ForeColor = Color.Green
        isValidSyntax = True

        ValidateConfirmPassword()
    End Sub

    Private Sub ValidateConfirmPassword()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        If confirmPassword = "" Then
            lblConfirmStatus.Text = ""
        ElseIf password <> confirmPassword Then
            lblConfirmStatus.Text = "Must match Password!"
            lblConfirmStatus.ForeColor = Color.Red
        Else
            lblConfirmStatus.Text = "Match"
            lblConfirmStatus.ForeColor = Color.Green
        End If
    End Sub

    Private Sub SetPasswordStatus(status As String, color As Color, valid As Boolean)
        lblPasswordStatus.Text = status
        lblPasswordStatus.ForeColor = color
        isValidSyntax = valid
    End Sub

    Public Sub UpdateIsDefaultPassword(employeeid As String)
        Try
            DatabaseConnection.OpenConnection()
            Dim query As String = "UPDATE public.""Account"" SET ""isDefaultPassword"" = false WHERE ""EmployeeID"" = @EmployeeID;"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@EmployeeID", employeeid)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Console.WriteLine($"{rowsAffected} row(s) updated.")
            End Using
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub

    Public Sub ChangePassword(newPass As String)
        Try
            DatabaseConnection.OpenConnection()
            Dim query As String = "UPDATE public.""Account"" SET ""Password"" = @NewPassword WHERE ""EmployeeID"" = @EmployeeID;"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@NewPassword", newPass)
                command.Parameters.AddWithValue("@EmployeeID", empID)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Console.WriteLine($"{rowsAffected} row(s) updated.")
            End Using
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub

    Public Function GetPasswordByAccountID(employeeid As String) As String
        Dim password As String = Nothing
        Try
            DatabaseConnection.OpenConnection()
            Dim query As String = "SELECT ""Password"" FROM public.""Account"" WHERE ""EmployeeID"" = @EmployeeID;"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@EmployeeID", employeeid)
                Using reader As NpgsqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        password = reader("Password").ToString()
                        Console.WriteLine("Current Password: " & password)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
        Return password
    End Function

    Private Sub ExecuteNonQuery(query As String, ParamArray parameters As NpgsqlParameter())
        Using connection As New NpgsqlConnection(connectionString.ConnectionString)
            connection.Open()
            Using command As New NpgsqlCommand(query, connection)
                command.Parameters.AddRange(parameters)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class