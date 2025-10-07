Partial Class cedulaform
	Public Sub New()
		InitializeComponent()
		' Half-size window relative to typical 1200x700 main: set to 600x440 in designer
	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub
End Class