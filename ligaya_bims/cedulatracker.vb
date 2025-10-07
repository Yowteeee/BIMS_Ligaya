Partial Class cedulatracker
	Public Sub New()
		InitializeComponent()
		cmbFilter.SelectedIndex = 0
	End Sub

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		' Search/filter scaffolding; hook to data when available
	End Sub

	Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
		Dim f As New cedulaform()
		f.StartPosition = FormStartPosition.CenterScreen
		f.ShowDialog(Me)
	End Sub
End Class