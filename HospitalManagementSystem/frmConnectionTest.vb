Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class btnTestConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Using con As SqlConnection = GetConnection()

                con.Open()

                MessageBox.Show(
                    "Database connection successful!",
                    "Connection Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Connection failed: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    End Class