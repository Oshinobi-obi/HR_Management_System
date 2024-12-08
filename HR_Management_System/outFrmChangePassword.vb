Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Npgsql

Module ChangePasswordConsoleTest
    Sub Main()
        ' Initialize and run the ChangePassword form with an EmployeeID for testing.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New outFrmChangePassword("02-02-02-01"))
    End Sub
End Module

Public Class outFrmChangePassword
    ' Database connection string
    Private connectionString As New NpgsqlConnection(conn.ConnectionString)

    ' Class-level variables
    Private isValidSyntax As Boolean = False
    Private empID As String

    ' Constructor
    Public Sub New(id As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize EmployeeID and fetch the current password
        empID = id
        Dim currentPassword As String = GetPasswordByAccountID(id)
        txtCurrentPassword.Text = If(String.IsNullOrEmpty(currentPassword), "No password found", currentPassword)
    End Sub

    ' Exit Button Click Event
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0) ' Exit the application
    End Sub

    ' Submit Button Click Event
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Validate password syntax
        If Not isValidSyntax Then
            MessageBox.Show("Invalid password syntax! Password must include:" & Environment.NewLine &
                            "• One Uppercase Letter" & Environment.NewLine &
                            "• One Lowercase Letter" & Environment.NewLine &
                            "• One Number" & Environment.NewLine &
                            "• One Symbol" & Environment.NewLine &
                            "• At least 11 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validate password match
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match." & Environment.NewLine &
                            $"Password: {password}" & Environment.NewLine &
                            $"Confirm Password: {confirmPassword}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Update password and default status
        ChangePassword(password)
        UpdateIsDefaultPassword(empID)

        ' Open MDIParent Form and close this form
        Dim loginForm As New HRLogin()
        CType(Me.MdiParent, MDIParent).LoadFormInMDI(loginForm)
        Me.Close()
    End Sub

    ' Password Validation
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ValidatePassword()
    End Sub

    ' Confirm Password Validation
    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        ValidateConfirmPassword()
    End Sub

    ' Validate Password
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

        ' Update Confirm Password status
        ValidateConfirmPassword()
    End Sub

    ' Validate Confirm Password
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

    ' Update Label for Password Status
    Private Sub SetPasswordStatus(status As String, color As Color, valid As Boolean)
        lblPasswordStatus.Text = status
        lblPasswordStatus.ForeColor = color
        isValidSyntax = valid
    End Sub

    ' Update IsDefaultPassword
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

    ' Change Password
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

    ' Get Password By Account ID
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

    ' Execute Non-Query for Database Updates
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
