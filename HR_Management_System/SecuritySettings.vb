Imports Npgsql

Public Class SecuritySettings
    Private Sub SecuritySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OldPassTxt.PasswordChar = "*"c
        OldPassTxt.UseSystemPasswordChar = False
        NewPassTxt.PasswordChar = "*"c
        NewPassTxt.UseSystemPasswordChar = False
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim oldPassword As String = OldPassTxt.Text.Trim()
        Dim newPassword As String = NewPassTxt.Text.Trim()

        If String.IsNullOrEmpty(oldPassword) Or String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter both old and new passwords.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UpdatePassword(oldPassword, newPassword) Then
            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim adminForm As New Admin()
            adminForm.Show()
        Else
            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function UpdatePassword(oldPassword As String, newPassword As String) As Boolean
        Dim isSuccess As Boolean = False

        Try
            DatabaseConnection.OpenConnection()
            Dim employeeID As String = "02-10-28-02"
            Dim query As String = "SELECT COUNT(*) FROM accounts WHERE ""EmployeeID"" = @EmployeeID AND ""Password"" = @OldPassword"
            Using cmd As New NpgsqlCommand(query, DatabaseConnection.conn)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                cmd.Parameters.AddWithValue("@OldPassword", oldPassword)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    Dim updateQuery As String = "UPDATE accounts SET ""Password"" = @NewPassword WHERE ""EmployeeID"" = @EmployeeID"
                    Using updateCmd As New NpgsqlCommand(updateQuery, DatabaseConnection.conn)
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword)
                        updateCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                        updateCmd.ExecuteNonQuery()
                        isSuccess = True
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DatabaseConnection.CloseConnection()
        End Try

        Return isSuccess
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim adminForm As New Admin()
        adminForm.Show()
    End Sub
End Class
