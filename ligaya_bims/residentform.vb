Imports MySql.Data.MySqlClient

Public Class residentform
    Public Event ResidentSaved(resident As ResidentData)
    Private idPicturePath As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using conn = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "INSERT INTO tbl_residentinfo (lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, idpic) VALUES (@ln,@fn,@mn,@gender,@bd,@age,@phone,@cstat,@cit,@father,@mother,@spouse,@mail,@vstat,@weight,@height,@idpic)"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@mn", txtMiddleName.Text.Trim())
                    cmd.Parameters.AddWithValue("@gender", If(TryCast(cmbGender.SelectedItem, String), ""))
                    cmd.Parameters.AddWithValue("@bd", dtpBirthDate.Value)
                    cmd.Parameters.AddWithValue("@age", If(String.IsNullOrWhiteSpace(txtAge.Text), DBNull.Value, CType(txtAge.Text, Object)))
                    cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@cstat", If(TryCast(cmbCivilStatus.SelectedItem, String), ""))
                    cmd.Parameters.AddWithValue("@cit", txtCitizenship.Text.Trim())
                    cmd.Parameters.AddWithValue("@father", txtFathersName.Text.Trim())
                    cmd.Parameters.AddWithValue("@mother", txtMothersName.Text.Trim())
                    cmd.Parameters.AddWithValue("@spouse", txtSpouse.Text.Trim())
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@vstat", If(TryCast(cmbVotersStatus.SelectedItem, String), ""))
                    cmd.Parameters.AddWithValue("@weight", txtWeight.Text.Trim())
                    cmd.Parameters.AddWithValue("@height", txtHeight.Text.Trim())
                    ' Add the idpic parameter - saves the file path or NULL if no picture
                    cmd.Parameters.AddWithValue("@idpic", If(String.IsNullOrWhiteSpace(idPicturePath), DBNull.Value, CType(idPicturePath, Object)))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Calculate age from birth date
            Dim age As Integer = CalculateAge(dtpBirthDate.Value)
            txtAge.Text = age.ToString()

            ' Create new resident data
            Dim newResident As New ResidentData With {
            .FirstName = txtFirstName.Text.Trim(),
            .LastName = txtLastName.Text.Trim(),
            .MiddleName = txtMiddleName.Text.Trim(),
            .BirthDate = dtpBirthDate.Value,
            .Age = age,
            .Gender = If(cmbGender.SelectedItem IsNot Nothing, cmbGender.SelectedItem.ToString().ToLower(), ""),
            .VotersStatus = If(cmbVotersStatus.SelectedItem IsNot Nothing, cmbVotersStatus.SelectedItem.ToString(), ""),
            .CivilStatus = If(cmbCivilStatus.SelectedItem IsNot Nothing, cmbCivilStatus.SelectedItem.ToString(), ""),
            .Citizenship = txtCitizenship.Text.Trim(),
            .PhoneNumber = txtPhoneNumber.Text.Trim(),
            .Height = txtHeight.Text.Trim(),
            .Weight = txtWeight.Text.Trim(),
            .Email = txtEmail.Text.Trim(),
            .Spouse = txtSpouse.Text.Trim(),
            .FathersName = txtFathersName.Text.Trim(),
            .MothersName = txtMothersName.Text.Trim(),
            .IdPicture = idPicturePath,
            .MobileNo = txtPhoneNumber.Text.Trim()
        }

            ' Raise the event to notify parent form
            RaiseEvent ResidentSaved(newResident)

            ' Show success message
            MessageBox.Show("Resident information saved successfully!", "Success",
                      MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form
            ClearForm()

            ' Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CalculateAge(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year
        If (birthDate.Date > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub ClearForm()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtPhoneNumber.Clear()
        txtCitizenship.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        txtEmail.Clear()
        txtSpouse.Clear()
        txtFathersName.Clear()
        txtMothersName.Clear()
        cmbGender.SelectedIndex = -1
        cmbVotersStatus.SelectedIndex = -1
        cmbCivilStatus.SelectedIndex = -1
        dtpBirthDate.Value = DateTime.Now
        txtAge.Clear()
        picIdPicture.Image = Nothing
        idPicturePath = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChoosePicture_Click(sender As Object, e As EventArgs) Handles btnChoosePicture.Click
        ' Open file dialog to select an image
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter for image files
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg; *.jpeg; *.png; *.bmp; *.gif|All Files (*.*)|*.*"
        openFileDialog.Title = "Select Resident Photo"

        ' Set initial directory to Pictures folder
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        ' Show dialog and check if user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the selected image
                Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)

                ' Set the image to the picturebox
                picIdPicture.Image = selectedImage

                ' Set the SizeMode to StretchImage to fill all gaps in the picturebox
                picIdPicture.SizeMode = PictureBoxSizeMode.StretchImage

                ' Store the file path for saving to database
                idPicturePath = openFileDialog.FileName

            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        ' Auto-calculate age when birth date changes
        Dim age As Integer = CalculateAge(dtpBirthDate.Value)
        txtAge.Text = age.ToString()
    End Sub

    Private Sub pnlFields_Paint(sender As Object, e As PaintEventArgs) Handles pnlFields.Paint

    End Sub



    Private Sub picIdPicture_Click(sender As Object, e As EventArgs) Handles picIdPicture.Click

    End Sub

    Private Sub residentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCivilStatus.SelectedIndexChanged

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class