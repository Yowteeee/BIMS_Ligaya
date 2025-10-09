Partial Class cedulaform
	Public Sub New()
		InitializeComponent()
		' Half-size window relative to typical 1200x700 main: set to 600x440 in designer
	End Sub

	Private Function ValidateInputs() As Boolean
		' Middlename is optional; all other fields required
		If String.IsNullOrWhiteSpace(txtCTC.Text) Then
			MessageBox.Show("Please enter CTC Number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		If String.IsNullOrWhiteSpace(txtLast.Text) Then
			MessageBox.Show("Please enter Last Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		If String.IsNullOrWhiteSpace(txtFirst.Text) Then
			MessageBox.Show("Please enter First Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		If String.IsNullOrWhiteSpace(txtAddress.Text) Then
			MessageBox.Show("Please enter Address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		If String.IsNullOrWhiteSpace(txtPlace.Text) Then
			MessageBox.Show("Please enter Place of Issue.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If

		Return True
	End Function

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
		If Not ValidateInputs() Then Return

		Dim ctcNumberInt As Integer
		If Not Integer.TryParse(txtCTC.Text.Trim(), ctcNumberInt) Then
			MessageBox.Show("CTC Number must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		Try
			Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
				conn.Open()
				Dim sql As String = "INSERT INTO tbl_cedulatracker (ctcnumber, lastname, firstname, middlename, address, placeissued, dateissued) VALUES (@ctc, @ln, @fn, @mn, @addr, @place, @date)"
				Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
					cmd.Parameters.AddWithValue("@ctc", ctcNumberInt)
					cmd.Parameters.AddWithValue("@ln", txtLast.Text.Trim())
					cmd.Parameters.AddWithValue("@fn", txtFirst.Text.Trim())
					Dim middle As Object = If(String.IsNullOrWhiteSpace(txtMiddle.Text), DBNull.Value, CType(txtMiddle.Text.Trim(), Object))
					cmd.Parameters.AddWithValue("@mn", middle)
					cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim())
					cmd.Parameters.AddWithValue("@place", txtPlace.Text.Trim())
					cmd.Parameters.AddWithValue("@date", DateTime.Now)

					cmd.ExecuteNonQuery()
				End Using
			End Using

			MessageBox.Show("Cedula record saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		Catch ex As Global.MySql.Data.MySqlClient.MySqlException
			MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Catch ex As Exception
			MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub
End Class