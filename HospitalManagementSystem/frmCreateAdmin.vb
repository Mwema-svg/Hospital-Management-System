Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class frmCreateAdmin

    Private Sub btnCreateAdmin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCreateAdmin.Click

        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Validate the required fields.
        If String.IsNullOrWhiteSpace(fullName) OrElse
           String.IsNullOrWhiteSpace(username) OrElse
           String.IsNullOrEmpty(password) Then

            MessageBox.Show(
                "Please enter your full name, username, and password.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        ' Require a reasonably strong initial password.
        If password.Length < 12 Then
            MessageBox.Show(
                "Use a password with at least 12 characters.",
                "Weak Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Try
            ' Generate a secure password hash.
            Dim passwordHash As String =
                PasswordHelper.HashPassword(password)

            Const sql As String =
                "INSERT INTO dbo.Users " &
                "(Username, PasswordHash, FullName, Role, IsActive) " &
                "SELECT @Username, @PasswordHash, @FullName, N'Admin', 1 " &
                "WHERE NOT EXISTS " &
                "(SELECT 1 FROM dbo.Users WHERE Username = @Username);"

            Using con As SqlConnection = DbConnection.GetConnection()
                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 100
                    ).Value = username

                    cmd.Parameters.Add(
                        "@PasswordHash", SqlDbType.NVarChar, 255
                    ).Value = passwordHash

                    cmd.Parameters.Add(
                        "@FullName", SqlDbType.NVarChar, 150
                    ).Value = fullName

                    con.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show(
                            "Administrator account created successfully!" &
                            Environment.NewLine &
                            "You can now log in using your new credentials.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        txtFullName.Clear()
                        txtUsername.Clear()
                        txtPassword.Clear()

                    Else
                        MessageBox.Show(
                            "That username already exists. Please choose another.",
                            "Duplicate Username",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If

                End Using
            End Using

        Catch ex As SqlException
            MessageBox.Show(
                "A database error occurred: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception
            MessageBox.Show(
                "Unable to create the administrator account: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

End Class