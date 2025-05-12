Imports System.Data.SqlClient

Public Class DbConnection
    Private Shared ReadOnly connectionString As String = "Server=FELIPECARDOSO\SQLEXPRESS;Database=AgendaDB;Integrated Security=True"

    Public Shared Function GetConnection() As SqlConnection
        Dim conn As New SqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function
End Class