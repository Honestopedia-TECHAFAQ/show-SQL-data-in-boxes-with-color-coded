Imports System.Data
Imports System.Data.SqlClient

Public Class DataAccess
    Private ReadOnly connectionString As String = System.Configuration.ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
    Public Function GetData() As DataTable
        Dim query As String = "SELECT * FROM DataItems"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            Catch ex As Exception
                Throw New ApplicationException("Error retrieving data from the database.", ex)
            Finally
                If connection.State <> ConnectionState.Closed Then
                    connection.Close()
                End If
            End Try
        End Using
        Return dataTable
    End Function
End Class
