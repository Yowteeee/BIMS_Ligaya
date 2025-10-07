Public Module Database
	Private ReadOnly connectionString As String = "Server=127.0.0.1;Port=3306;Database=capstone;Uid=root;Pwd=johnarbenanguring;SslMode=none;"

	Public Function CreateConnection() As Global.MySql.Data.MySqlClient.MySqlConnection
		Return New Global.MySql.Data.MySqlClient.MySqlConnection(connectionString)
	End Function

	Public Function TestConnection(ByRef errorMessage As String) As Boolean
		Try
			Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = CreateConnection()
				conn.Open()
				Return True
			End Using
		Catch ex As Exception
			errorMessage = ex.Message
			Return False
		End Try
	End Function
End Module

