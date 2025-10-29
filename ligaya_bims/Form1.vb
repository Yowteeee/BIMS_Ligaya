'Imports MySql.Data.MySqlClient

Public Class Form1



    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Enter your username" And txtUsername.ForeColor = Color.Gray Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            SetPlaceholder(txtUsername, "Enter your username")
        End If
    End Sub

    Private Sub leftPanel_Paint(sender As Object, e As PaintEventArgs) Handles leftPanel.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Basic input validation
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()

                ' Query to check if username and password match
                Dim query As String = "SELECT COUNT(*) FROM tbl_login WHERE username = @u AND password = @p"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    Dim result As Object = cmd.ExecuteScalar()
                    Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

                    If count > 0 Then
                        MessageBox.Show("Login successful! Welcome " & username & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim dashboardForm As New dashboard()
                        dashboardForm.Show()
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

    'Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    '    Dim username As String = txtUsername.Text.Trim()
    '    Dim password As String = txtPassword.Text.Trim()

    '    If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
    '        MessageBox.Show("Please enter username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    End If

    '    Try
    '        Using conn As MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
    '            conn.Open()
    '            Dim query As String = "SELECT COUNT(*) FROM tbl_login WHERE username=@u AND password=@p"
    '            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@u", username)
    '                cmd.Parameters.AddWithValue("@p", password)
    '                Dim result As Object = cmd.ExecuteScalar()
    '                Dim count As Integer = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)

    '                ' Debug information
    '                Dim debugMsg As String = $"Debug Info:" & vbCrLf &
    '                                       $"Username: '{username}'" & vbCrLf &
    '                                       $"Password: '{password}'" & vbCrLf &
    '                                       $"Query Result: {count}" & vbCrLf &
    '                                       $"Database Connected: {conn.State.ToString()}"

    '                If count > 0 Then
    '                    MessageBox.Show("Login successful! Welcome " & username & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Dim dashboardForm As New dashboard()
    '                    dashboardForm.Show()
    '                    Me.Hide()
    '                Else
    '                    MessageBox.Show("Invalid username or password." & vbCrLf & vbCrLf & debugMsg, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Username placeholder
        txtUsername.Text = "Enter your username"
        txtUsername.ForeColor = Color.Gray

        ' Password placeholder - NO PasswordChar initially
        txtPassword.Text = "Enter your password"
        txtPassword.ForeColor = Color.Gray
        txtPassword.PasswordChar = "" ' Keep empty initially!
    End Sub
    Private Sub SetPlaceholder(txt As TextBox, placeholder As String)
        txt.Text = placeholder
        txt.ForeColor = Color.Gray
    End Sub


    Private Sub rightPanel_Paint(sender As Object, e As PaintEventArgs) Handles rightPanel.Paint

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Enter your password" And txtPassword.ForeColor = Color.Gray Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.PasswordChar = ""
            SetPlaceholder(txtPassword, "Enter your password")
        End If
    End Sub
End Class
