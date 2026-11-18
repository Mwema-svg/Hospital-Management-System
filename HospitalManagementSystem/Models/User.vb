Option Explicit On
Option Strict On

Public Class User

    Public Property UserID As Integer
    Public Property Username As String = String.Empty
    Public Property PasswordHash As String = String.Empty
    Public Property FullName As String = String.Empty
    Public Property Role As String = String.Empty
    Public Property IsActive As Boolean

End Class
