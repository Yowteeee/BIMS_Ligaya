Public Class Form1
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub leftPanel_Paint(sender As Object, e As PaintEventArgs) Handles leftPanel.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
