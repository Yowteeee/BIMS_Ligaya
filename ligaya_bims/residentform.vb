' Removed Imports MySql.Data.MySqlClient - using fully qualified names to avoid conflicts
Imports System.Drawing.Drawing2D

Public Class residentform
    Public Event ResidentSaved(resident As ResidentData)
    Private idPicturePath As String = ""
    Private editingResidentLastName As String = "" ' Empty means new resident, otherwise it's an edit
    Private editingResidentFirstName As String = ""
    Private editingResidentBirthDate As DateTime = DateTime.MinValue
    Private originalPicturePath As String = "" ' Store original picture path when editing
    Private age As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            ' Validate that all required controls are not null
            If txtLastName Is Nothing OrElse txtFirstName Is Nothing OrElse txtMiddleName Is Nothing Then
                MessageBox.Show("Form controls are not properly initialized. Please restart the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using conn = Database.CreateConnection()
                conn.Open()

                ' Calculate age from birth date
                Dim age As Integer = CalculateAge(If(dtpBirthDate IsNot Nothing, dtpBirthDate.Value, DateTime.Now))
                If txtAge IsNot Nothing Then
                    txtAge.Text = age.ToString()
                End If

                ' Check for duplicate resident (same first name, last name, and birthdate)
                Dim checkSql As String = "SELECT COUNT(*) FROM tbl_residentinfo WHERE lastname=@ln AND firstname=@fn AND birthdate=@bd"
                If Not String.IsNullOrEmpty(editingResidentLastName) Then
                    ' Exclude current resident when updating using composite key
                    checkSql &= " AND NOT (lastname=@oldln AND firstname=@oldfn AND birthdate=@oldbd)"
                End If

                Using checkCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@ln", If(txtLastName IsNot Nothing, txtLastName.Text.Trim(), ""))
                    checkCmd.Parameters.AddWithValue("@fn", If(txtFirstName IsNot Nothing, txtFirstName.Text.Trim(), ""))
                    checkCmd.Parameters.AddWithValue("@bd", If(dtpBirthDate IsNot Nothing, dtpBirthDate.Value, DateTime.Now))
                    If Not String.IsNullOrEmpty(editingResidentLastName) Then
                        checkCmd.Parameters.AddWithValue("@oldln", editingResidentLastName)
                        checkCmd.Parameters.AddWithValue("@oldfn", editingResidentFirstName)
                        checkCmd.Parameters.AddWithValue("@oldbd", editingResidentBirthDate)
                    End If

                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("A resident with the same name and birthdate already exists in the database. Please verify the information.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Determine if this is an INSERT or UPDATE
                Dim sql As String
                If Not String.IsNullOrEmpty(editingResidentLastName) Then
                    ' UPDATE existing resident using composite key
                    ' Only update idpic if a new picture was selected (different from original)
                    Dim pictureChanged As Boolean = Not String.IsNullOrWhiteSpace(idPicturePath) AndAlso idPicturePath <> originalPicturePath
                    If pictureChanged Then
                        ' Update with new picture
                        sql = "UPDATE tbl_residentinfo SET lastname=@ln, firstname=@fn, middlename=@mn, gender=@gender, birthdate=@bd, age=@age, phoneno=@phone, civilstatus=@cstat, citizenship=@cit, fathersname=@father, mothersname=@mother, spouse=@spouse, email=@mail, voterstatus=@vstat, weight=@weight, height=@height, address=@address, religion=@religion, idpic=@idpic WHERE lastname=@oldln AND firstname=@oldfn AND birthdate=@oldbd"
                    Else
                        ' Keep existing picture - don't update idpic field
                        sql = "UPDATE tbl_residentinfo SET lastname=@ln, firstname=@fn, middlename=@mn, gender=@gender, birthdate=@bd, age=@age, phoneno=@phone, civilstatus=@cstat, citizenship=@cit, fathersname=@father, mothersname=@mother, spouse=@spouse, email=@mail, voterstatus=@vstat, weight=@weight, height=@height, address=@address, religion=@religion WHERE lastname=@oldln AND firstname=@oldfn AND birthdate=@oldbd"
                    End If
                Else
                    ' INSERT new resident
                    sql = "INSERT INTO tbl_residentinfo (lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, address, religion, idpic) VALUES (@ln,@fn,@mn,@gender,@bd,@age,@phone,@cstat,@cit,@father,@mother,@spouse,@mail,@vstat,@weight,@height,@address,@religion,@idpic)"
                End If

                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    ' Safe parameter assignments with null checks
                    If Not String.IsNullOrEmpty(editingResidentLastName) Then
                        cmd.Parameters.AddWithValue("@oldln", editingResidentLastName)
                        cmd.Parameters.AddWithValue("@oldfn", editingResidentFirstName)
                        cmd.Parameters.AddWithValue("@oldbd", editingResidentBirthDate)
                    End If
                    cmd.Parameters.AddWithValue("@ln", If(txtLastName IsNot Nothing, txtLastName.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@fn", If(txtFirstName IsNot Nothing, txtFirstName.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@mn", If(txtMiddleName IsNot Nothing, txtMiddleName.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@gender", If(cmbGender IsNot Nothing AndAlso cmbGender.SelectedItem IsNot Nothing, cmbGender.SelectedItem.ToString(), ""))
                    cmd.Parameters.AddWithValue("@bd", If(dtpBirthDate IsNot Nothing, dtpBirthDate.Value, DateTime.Now))
                    cmd.Parameters.AddWithValue("@age", If(txtAge IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtAge.Text), CType(age, Object), DBNull.Value))
                    cmd.Parameters.AddWithValue("@phone", If(txtPhoneNumber IsNot Nothing, txtPhoneNumber.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@cstat", If(cmbCivilStatus IsNot Nothing AndAlso cmbCivilStatus.SelectedItem IsNot Nothing, cmbCivilStatus.SelectedItem.ToString(), ""))
                    cmd.Parameters.AddWithValue("@cit", If(txtCitizenship IsNot Nothing, txtCitizenship.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@father", If(txtFathersName IsNot Nothing, txtFathersName.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@mother", If(txtMothersName IsNot Nothing, txtMothersName.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@spouse", If(txtSpouse IsNot Nothing, txtSpouse.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@mail", If(txtEmail IsNot Nothing, txtEmail.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@vstat", If(cmbVotersStatus IsNot Nothing AndAlso cmbVotersStatus.SelectedItem IsNot Nothing, cmbVotersStatus.SelectedItem.ToString(), ""))
                    cmd.Parameters.AddWithValue("@weight", If(txtWeight IsNot Nothing, txtWeight.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@height", If(txtHeight IsNot Nothing, txtHeight.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@address", If(txtAddress IsNot Nothing, txtAddress.Text.Trim(), ""))
                    cmd.Parameters.AddWithValue("@religion", If(txtReligion IsNot Nothing, txtReligion.Text.Trim(), ""))
                    ' Add the idpic parameter - saves the file path or NULL if no picture
                    ' Only add idpic parameter if we're inserting or updating with a new picture
                    Dim pictureChanged As Boolean = String.IsNullOrEmpty(editingResidentLastName) OrElse (Not String.IsNullOrWhiteSpace(idPicturePath) AndAlso idPicturePath <> originalPicturePath)
                    If pictureChanged Then
                        cmd.Parameters.AddWithValue("@idpic", If(String.IsNullOrWhiteSpace(idPicturePath), DBNull.Value, CType(idPicturePath, Object)))
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Create new resident data with safe property assignments
            Dim newResident As New ResidentData With {
        .FirstName = If(txtFirstName IsNot Nothing, txtFirstName.Text.Trim(), ""),
        .LastName = If(txtLastName IsNot Nothing, txtLastName.Text.Trim(), ""),
        .MiddleName = If(txtMiddleName IsNot Nothing, txtMiddleName.Text.Trim(), ""),
        .BirthDate = If(dtpBirthDate IsNot Nothing, dtpBirthDate.Value, DateTime.Now),
        .Age = age,
        .Gender = If(cmbGender IsNot Nothing AndAlso cmbGender.SelectedItem IsNot Nothing, cmbGender.SelectedItem.ToString().ToLower(), ""),
        .VotersStatus = If(cmbVotersStatus IsNot Nothing AndAlso cmbVotersStatus.SelectedItem IsNot Nothing, cmbVotersStatus.SelectedItem.ToString(), ""),
        .CivilStatus = If(cmbCivilStatus IsNot Nothing AndAlso cmbCivilStatus.SelectedItem IsNot Nothing, cmbCivilStatus.SelectedItem.ToString(), ""),
        .Citizenship = If(txtCitizenship IsNot Nothing, txtCitizenship.Text.Trim(), ""),
        .PhoneNumber = If(txtPhoneNumber IsNot Nothing, txtPhoneNumber.Text.Trim(), ""),
        .Height = If(txtHeight IsNot Nothing, txtHeight.Text.Trim(), ""),
        .Weight = If(txtWeight IsNot Nothing, txtWeight.Text.Trim(), ""),
        .Email = If(txtEmail IsNot Nothing, txtEmail.Text.Trim(), ""),
        .Spouse = If(txtSpouse IsNot Nothing, txtSpouse.Text.Trim(), ""),
        .FathersName = If(txtFathersName IsNot Nothing, txtFathersName.Text.Trim(), ""),
        .MothersName = If(txtMothersName IsNot Nothing, txtMothersName.Text.Trim(), ""),
        .Address = If(txtAddress IsNot Nothing, txtAddress.Text.Trim(), ""),
        .Religion = If(txtReligion IsNot Nothing, txtReligion.Text.Trim(), ""),
        .IdPicture = idPicturePath,
        .MobileNo = If(txtPhoneNumber IsNot Nothing, txtPhoneNumber.Text.Trim(), "")
    }

            ' Raise the event to notify parent form
            RaiseEvent ResidentSaved(newResident)

            ' Show success message
            Dim message As String = If(Not String.IsNullOrEmpty(editingResidentLastName), "Resident information updated successfully!", "Resident information saved successfully!")
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form and reset editing composite key
            ClearForm()
            editingResidentLastName = ""
            editingResidentFirstName = ""
            editingResidentBirthDate = DateTime.MinValue

            ' Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' Public method to set the resident composite key for editing
    Public Sub SetEditingResident(lastName As String, firstName As String, birthDate As DateTime)
        editingResidentLastName = lastName
        editingResidentFirstName = firstName
        editingResidentBirthDate = birthDate
    End Sub
    
    ' Public method to set the original picture path when editing
    Public Sub SetOriginalPicturePath(picturePath As String)
        originalPicturePath = picturePath
        If Not String.IsNullOrWhiteSpace(picturePath) Then
            idPicturePath = picturePath
        End If
    End Sub

    Private Function CalculateAge(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year
        If (birthDate.Date > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub ClearForm()
        ' Clear all form fields with null checks
        If txtLastName IsNot Nothing Then txtLastName.Clear()
        If txtFirstName IsNot Nothing Then txtFirstName.Clear()
        If txtMiddleName IsNot Nothing Then txtMiddleName.Clear()
        If txtPhoneNumber IsNot Nothing Then txtPhoneNumber.Clear()
        If txtCitizenship IsNot Nothing Then txtCitizenship.Clear()
        If txtHeight IsNot Nothing Then txtHeight.Clear()
        If txtWeight IsNot Nothing Then txtWeight.Clear()
        If txtEmail IsNot Nothing Then txtEmail.Clear()
        If txtSpouse IsNot Nothing Then txtSpouse.Clear()
        If txtFathersName IsNot Nothing Then txtFathersName.Clear()
        If txtMothersName IsNot Nothing Then txtMothersName.Clear()
        If cmbGender IsNot Nothing Then cmbGender.SelectedIndex = -1
        If cmbVotersStatus IsNot Nothing Then cmbVotersStatus.SelectedIndex = -1
        If cmbCivilStatus IsNot Nothing Then cmbCivilStatus.SelectedIndex = -1
        If dtpBirthDate IsNot Nothing Then dtpBirthDate.Value = DateTime.Now
        If txtAge IsNot Nothing Then txtAge.Clear()
        If picIdPicture IsNot Nothing Then picIdPicture.Image = Nothing
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
                ' Dispose previous image if exists to prevent memory leaks
                If picIdPicture.Image IsNot Nothing Then
                    picIdPicture.Image.Dispose()
                    picIdPicture.Image = Nothing
                End If

                ' Load the selected image
                Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)

                ' Set the image to the picturebox on the right side panel
                picIdPicture.Image = selectedImage

                ' Set the SizeMode to Zoom to maintain aspect ratio and fill the picturebox nicely
                picIdPicture.SizeMode = PictureBoxSizeMode.Zoom

                ' Store the file path for saving to database
                idPicturePath = openFileDialog.FileName

                ' Refresh the picturebox to ensure image displays immediately
                picIdPicture.Refresh()

            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Clear image if loading failed
                If picIdPicture.Image IsNot Nothing Then
                    picIdPicture.Image.Dispose()
                    picIdPicture.Image = Nothing
                End If
                idPicturePath = ""
            End Try
        End If
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        ' Auto-calculate age when birth date changes
        If dtpBirthDate IsNot Nothing AndAlso txtAge IsNot Nothing Then
            Dim age As Integer = CalculateAge(dtpBirthDate.Value)
            txtAge.Text = age.ToString()
        End If
    End Sub

    Private Sub pnlFields_Paint(sender As Object, e As PaintEventArgs) Handles pnlFields.Paint

    End Sub



    Private Sub picIdPicture_Click(sender As Object, e As EventArgs) Handles picIdPicture.Click

    End Sub

    Private Sub cmbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCivilStatus.SelectedIndexChanged

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub ApplyRoundedCorners()
        ' Apply rounded corners to all textboxes using FlatStyle
        SetRoundedStyle(txtLastName)
        SetRoundedStyle(txtFirstName)
        SetRoundedStyle(txtMiddleName)
        SetRoundedStyle(txtCitizenship)
        SetRoundedStyle(txtPhoneNumber)
        SetRoundedStyle(txtEmail)
        SetRoundedStyle(txtFathersName)
        SetRoundedStyle(txtMothersName)
        SetRoundedStyle(txtSpouse)
        SetRoundedStyle(txtHeight)
        SetRoundedStyle(txtWeight)
        SetRoundedStyle(txtAddress)
        SetRoundedStyle(txtReligion)

        ' Apply rounded corners to all comboboxes
        SetRoundedStyle(cmbGender)
        SetRoundedStyle(cmbCivilStatus)
        SetRoundedStyle(cmbVotersStatus)

        ' Apply rounded corners to all buttons
        SetRoundedStyle(btnSubmit)
        SetRoundedStyle(btnCancel)
        SetRoundedStyle(btnChoosePicture)
    End Sub

    Private Sub SetRoundedStyle(ctrl As Control)
        If ctrl Is Nothing Then Return

        ' Set flat style for modern appearance
        If TypeOf ctrl Is Button Then
            Dim btn As Button = DirectCast(ctrl, Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0

        ElseIf TypeOf ctrl Is TextBox Then
            Dim txt As TextBox = DirectCast(ctrl, TextBox)
            txt.BorderStyle = BorderStyle.FixedSingle

        ElseIf TypeOf ctrl Is ComboBox Then
            Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
            cmb.FlatStyle = FlatStyle.Flat
        End If
    End Sub

    Private Sub residentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComboBoxes()
        ApplyRoundedCorners()
    End Sub

    Private Sub InitializeComboBoxes()
        ' Initialize Gender ComboBox
        cmbGender.Items.Clear()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        
        ' Initialize Civil Status ComboBox
        cmbCivilStatus.Items.Clear()
        cmbCivilStatus.Items.Add("Single")
        cmbCivilStatus.Items.Add("Married")
        cmbCivilStatus.Items.Add("Widowed")
        cmbCivilStatus.Items.Add("Divorced")
        cmbCivilStatus.Items.Add("Separated")
        
        ' Initialize Voters Status ComboBox
        cmbVotersStatus.Items.Clear()
        cmbVotersStatus.Items.Add("Registered")
        cmbVotersStatus.Items.Add("Not Registered")
        cmbVotersStatus.Items.Add("Active")
        cmbVotersStatus.Items.Add("Inactive")
    End Sub

    Private Sub lblBirthDate_Click(sender As Object, e As EventArgs) Handles lblBirthDate.Click

    End Sub

    Private Sub pnlButtons_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub
End Class