Option Explicit On
Option Strict On

Imports Microsoft.Data.SqlClient

Module DbConnection

    Public ReadOnly ConnectionString As String =
        "Server=localhost\SQLEXPRESS;" &
        "Database=HospitalManagement;" &
        "Integrated Security=True;" &
        "Encrypt=True;" &
        "TrustServerCertificate=True;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

End Module
