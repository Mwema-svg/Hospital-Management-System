
Option Explicit On
Option Strict On

Public Class frmLogin

    Private Sub btnLogin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then

            MessageBox.Show(
                "Please enter both username and password.",
                "Missing Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Try
            Dim auth As New AuthenticationService()

            Dim loggedInUser As User =
                auth.AuthenticateUser(
                    txtUsername.Text.Trim(),
                    txtPassword.Text
                )

            If loggedInUser Is Nothing Then

                MessageBox.Show(
                    "Invalid username, password, or inactive account.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()
                Exit Sub

            End If

            MessageBox.Show(
                "Welcome, " & loggedInUser.FullName & "!",
                "Login Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Dim dashboard As New frmDashboard()
            dashboard.LoggedInUser = loggedInUser

            AddHandler dashboard.FormClosed,
                Sub(s, args) Me.Show()

            txtPassword.Clear()
            dashboard.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show(
                "Login error: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnExit_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnExit.Click

        Application.Exit()

    End Sub


    Private Sub btnCreateAdmin_Click(
    sender As Object,
    e As EventArgs
) Handles btnCreateAdmin.Click

        Dim adminForm As New frmCreateAdmin()
        adminForm.ShowDialog()

    End Sub

End Class
