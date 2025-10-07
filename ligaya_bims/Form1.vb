Public Class Form1
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub leftPanel_Paint(sender As Object, e As PaintEventArgs) Handles leftPanel.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = Database.CreateConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(1) FROM tbl_login WHERE username=@u AND password=@p"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    Dim result As Object = cmd.ExecuteScalar()
                    Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)
                    If count > 0 Then
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
