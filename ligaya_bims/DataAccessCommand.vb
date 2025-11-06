' Removed Imports to avoid conflict - using fully qualified names instead

Friend Class MySqlCommand
    Private sql As String
    Private conn As Object

    Public Sub New(sql As String, conn As Object)
        Me.sql = sql
        Me.conn = conn
    End Sub

    Friend Sub Dispose()
        Throw New NotImplementedException()
    End Sub

    Friend Sub ExecuteNonQuery()
        Throw New NotImplementedException()
    End Sub

    Friend Function ExecuteReader() As Global.MySql.Data.MySqlClient.MySqlDataReader
        Throw New NotImplementedException()
    End Function
End Class
