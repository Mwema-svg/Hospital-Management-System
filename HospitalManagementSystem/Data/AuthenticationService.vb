Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Public Class AuthenticationService

    Public Function AuthenticateUser(
        username As String,
        password As String
    ) As User

        If String.IsNullOrWhiteSpace(username) OrElse
           String.IsNullOrEmpty(password) Then

            Return Nothing
        End If

        Const sql As String =
            "SELECT UserID, Username, PasswordHash, FullName, Role, IsActive " &
            "FROM dbo.Users WHERE Username = @Username;"

        Using con As SqlConnection = GetConnection()

            Using cmd As New SqlCommand(sql, con)

                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value =
                    username.Trim()

                con.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    If Not reader.Read() Then
                        Return Nothing
                    End If

                    Dim isActive As Boolean =
                        Not reader.IsDBNull(reader.GetOrdinal("IsActive")) AndAlso
                        Convert.ToBoolean(reader("IsActive"))

                    If Not isActive Then
                        Return Nothing
                    End If

                    Dim storedHash As String =
                        Convert.ToString(reader("PasswordHash"))

                    If Not PasswordHelper.VerifyPassword(password, storedHash) Then
                        Return Nothing
                    End If

                    Dim loggedInUser As New User With {
                        .UserID = Convert.ToInt32(reader("UserID")),
                        .Username = Convert.ToString(reader("Username")),
                        .FullName = If(reader.IsDBNull(reader.GetOrdinal("FullName")),
                                       String.Empty,
                                       Convert.ToString(reader("FullName"))),
                        .Role = Convert.ToString(reader("Role")),
                        .IsActive = True
                    }

                    Return loggedInUser

                End Using
            End Using
        End Using

    End Function

End Class
