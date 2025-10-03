Friend Class MySqlCommand
    Private sql As String
    Private conn As Object

    Public Sub New(sql As String, conn As Object)
        Me.sql = sql
        Me.conn = conn
    End Sub
End Class
