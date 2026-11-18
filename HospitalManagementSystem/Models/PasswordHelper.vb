Option Explicit On
Option Strict On

Imports System.Security.Cryptography

Public Class PasswordHelper

    Private Const SaltSize As Integer = 16
    Private Const HashSize As Integer = 32
    Private Const Iterations As Integer = 600000

    Public Shared Function HashPassword(password As String) As String

        If String.IsNullOrWhiteSpace(password) Then
            Throw New ArgumentException("Password cannot be empty.")
        End If

        Dim salt(SaltSize - 1) As Byte
        RandomNumberGenerator.Fill(salt)

        Dim hash As Byte() = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256,
            HashSize
        )

        Return String.Join("$",
            "PBKDF2-SHA256",
            Iterations.ToString(),
            Convert.ToBase64String(salt),
            Convert.ToBase64String(hash))

    End Function

    Public Shared Function VerifyPassword(
        password As String,
        storedHash As String
    ) As Boolean

        If String.IsNullOrEmpty(password) OrElse
           String.IsNullOrWhiteSpace(storedHash) Then

            Return False
        End If

        Dim parts As String() = storedHash.Split("$"c)

        If parts.Length <> 4 OrElse
           parts(0) <> "PBKDF2-SHA256" Then

            Return False
        End If

        Try
            Dim iterations As Integer

            If Not Integer.TryParse(parts(1), iterations) OrElse
               iterations < 100000 OrElse
               iterations > 2000000 Then

                Return False
            End If

            Dim salt As Byte() = Convert.FromBase64String(parts(2))
            Dim expectedHash As Byte() = Convert.FromBase64String(parts(3))

            If salt.Length <> SaltSize OrElse
               expectedHash.Length <> HashSize Then

                Return False
            End If

            Dim actualHash As Byte() = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                HashSize
            )

            Return CryptographicOperations.FixedTimeEquals(
                actualHash,
                expectedHash
            )

        Catch ex As FormatException
            Return False
        Catch ex As ArgumentException
            Return False
        End Try

    End Function

End Class
