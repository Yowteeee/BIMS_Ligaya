Public Class residentinfo
    Private residentForm As residentform
    Private residentsList As New List(Of ResidentData)

    Public Sub New()
        InitializeComponent()
        InitializeComboBoxes()
        LoadResidents()
    End Sub

    ' Method to handle when form is displayed as child form in dashboard
    Public Sub SetAsChildForm()
        ' Ensure the form is properly configured for child display
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
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

    Private Sub LoadResidents()
        ' Load residents from database: id, lastname, firstname, middlename, phoneno, gender
        residentsList.Clear()

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT id, lastname, firstname, middlename, phoneno, gender FROM tbl_residentinfo"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim data As New ResidentData()
                            data.Id = If(Not reader.IsDBNull(0), reader.GetInt32(0), 0)
                            data.LastName = If(Not reader.IsDBNull(1), reader.GetString(1), String.Empty)
                            data.FirstName = If(Not reader.IsDBNull(2), reader.GetString(2), String.Empty)
                            data.MiddleName = If(Not reader.IsDBNull(3), reader.GetString(3), String.Empty)
                            data.MobileNo = If(Not reader.IsDBNull(4), reader.GetString(4), String.Empty)
                            data.Gender = If(Not reader.IsDBNull(5), reader.GetString(5), String.Empty)
                            residentsList.Add(data)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Failed to load residents: " & ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try

        RefreshDataGrid()
    End Sub

    Private Sub RefreshDataGrid()
        dgvResidents.Rows.Clear()

        For Each resident In residentsList
            Dim rowIndex = dgvResidents.Rows.Add()
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = False
            dgvResidents.Rows(rowIndex).Cells("colID").Value = resident.Id
            dgvResidents.Rows(rowIndex).Cells("colLastName").Value = resident.LastName
            dgvResidents.Rows(rowIndex).Cells("colFirstName").Value = resident.FirstName
            dgvResidents.Rows(rowIndex).Cells("colMiddleName").Value = resident.MiddleName
            dgvResidents.Rows(rowIndex).Cells("colMobileNo").Value = resident.MobileNo
            dgvResidents.Rows(rowIndex).Cells("colGender").Value = resident.Gender
            dgvResidents.Rows(rowIndex).Cells("colAction").Value = "Edit"
        Next

        lblShowEntries.Text = $"Showing 1 to {residentsList.Count} of {residentsList.Count} entries"
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        residentForm = New residentform()
        AddHandler residentForm.ResidentSaved, AddressOf OnResidentSaved
        residentForm.ShowDialog()
    End Sub

    Private Sub OnResidentSaved(resident As ResidentData)
        ' Reload residents from database to get the proper ID and ensure data consistency
        LoadResidents()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText = txtSearch.Text.ToLower()

        If String.IsNullOrEmpty(searchText) Then
            RefreshDataGrid()
            Return
        End If

        dgvResidents.Rows.Clear()
        Dim filteredResidents = residentsList.Where(Function(r) _
            r.FirstName.ToLower().Contains(searchText) OrElse
            r.LastName.ToLower().Contains(searchText) OrElse
            r.MiddleName.ToLower().Contains(searchText)
        ).ToList()

        For Each resident In filteredResidents
            Dim rowIndex = dgvResidents.Rows.Add()
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = True
            dgvResidents.Rows(rowIndex).Cells("colID").Value = resident.Id
            dgvResidents.Rows(rowIndex).Cells("colLastName").Value = resident.LastName
            dgvResidents.Rows(rowIndex).Cells("colFirstName").Value = resident.FirstName
            dgvResidents.Rows(rowIndex).Cells("colMiddleName").Value = resident.MiddleName
            dgvResidents.Rows(rowIndex).Cells("colMobileNo").Value = resident.MobileNo
            dgvResidents.Rows(rowIndex).Cells("colGender").Value = resident.Gender
            dgvResidents.Rows(rowIndex).Cells("colAction").Value = "Edit"
        Next

        lblShowEntries.Text = $"Showing 1 to {filteredResidents.Count} of {filteredResidents.Count} entries"
    End Sub

    Private Sub btnExportResident_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Export functionality will be implemented here", "Export Residents", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteResident_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Delete functionality will be implemented here", "Delete Residents", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub dgvResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellClick
        If e.RowIndex >= 0 Then
            ' Check if the Edit button in the Action column was clicked
            If e.ColumnIndex = dgvResidents.Columns("colAction").Index Then
                Dim residentId As Integer = CInt(dgvResidents.Rows(e.RowIndex).Cells("colID").Value)
                EditResident(residentId)
            Else
                ' Load and display resident details in the right panel
                Dim residentId As Integer = CInt(dgvResidents.Rows(e.RowIndex).Cells("colID").Value)
                LoadResidentDetails(residentId)
            End If
        End If
    End Sub

    Private Sub EditResident(residentId As Integer)
        Try
            ' Load resident data for editing
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT id, lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, address, religion, idpic FROM tbl_residentinfo WHERE id = @id"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", residentId)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Open resident form in edit mode
                            Dim editForm As New residentform()
                            ' Set the editing resident ID
                            editForm.SetEditingResidentId(residentId)
                            ' Load the existing data into the form
                            If Not reader.IsDBNull(1) Then editForm.txtLastName.Text = reader.GetString(1)
                            If Not reader.IsDBNull(2) Then editForm.txtFirstName.Text = reader.GetString(2)
                            If Not reader.IsDBNull(3) Then editForm.txtMiddleName.Text = reader.GetString(3)

                            ' Set Gender ComboBox
                            If Not reader.IsDBNull(4) Then
                                Dim genderValue As String = reader.GetString(4)
                                Dim genderIndex As Integer = editForm.cmbGender.FindStringExact(genderValue)
                                If genderIndex >= 0 Then
                                    editForm.cmbGender.SelectedIndex = genderIndex
                                Else
                                    editForm.cmbGender.Text = genderValue
                                End If
                            End If

                            If Not reader.IsDBNull(5) Then editForm.dtpBirthDate.Value = reader.GetDateTime(5)
                            If Not reader.IsDBNull(6) Then editForm.txtAge.Text = reader.GetInt32(6).ToString()
                            If Not reader.IsDBNull(7) Then editForm.txtPhoneNumber.Text = reader.GetString(7)

                            ' Set Civil Status ComboBox
                            If Not reader.IsDBNull(8) Then
                                Dim civilStatusValue As String = reader.GetString(8)
                                Dim civilStatusIndex As Integer = editForm.cmbCivilStatus.FindStringExact(civilStatusValue)
                                If civilStatusIndex >= 0 Then
                                    editForm.cmbCivilStatus.SelectedIndex = civilStatusIndex
                                Else
                                    editForm.cmbCivilStatus.Text = civilStatusValue
                                End If
                            End If

                            If Not reader.IsDBNull(9) Then editForm.txtCitizenship.Text = reader.GetString(9)
                            If Not reader.IsDBNull(10) Then editForm.txtFathersName.Text = reader.GetString(10)
                            If Not reader.IsDBNull(11) Then editForm.txtMothersName.Text = reader.GetString(11)
                            If Not reader.IsDBNull(12) Then editForm.txtSpouse.Text = reader.GetString(12)
                            If Not reader.IsDBNull(13) Then editForm.txtEmail.Text = reader.GetString(13)

                            ' Set Voters Status ComboBox
                            If Not reader.IsDBNull(14) Then
                                Dim votersStatusValue As String = reader.GetString(14)
                                Dim votersStatusIndex As Integer = editForm.cmbVotersStatus.FindStringExact(votersStatusValue)
                                If votersStatusIndex >= 0 Then
                                    editForm.cmbVotersStatus.SelectedIndex = votersStatusIndex
                                Else
                                    ' Try to match common variations
                                    Dim status As String = votersStatusValue.ToLower()
                                    If status.Contains("registered") OrElse status.Contains("active") Then
                                        Dim index As Integer = editForm.cmbVotersStatus.FindStringExact("Registered")
                                        If index >= 0 Then editForm.cmbVotersStatus.SelectedIndex = index
                                    ElseIf status.Contains("not") OrElse status.Contains("inactive") Then
                                        Dim index As Integer = editForm.cmbVotersStatus.FindStringExact("Not Registered")
                                        If index >= 0 Then editForm.cmbVotersStatus.SelectedIndex = index
                                    Else
                                        editForm.cmbVotersStatus.Text = votersStatusValue
                                    End If
                                End If
                            End If

                            If Not reader.IsDBNull(15) Then editForm.txtWeight.Text = reader.GetString(15)
                            If Not reader.IsDBNull(16) Then editForm.txtHeight.Text = reader.GetString(16)
                            If Not reader.IsDBNull(17) Then editForm.txtAddress.Text = reader.GetString(17)
                            If Not reader.IsDBNull(18) Then editForm.txtReligion.Text = reader.GetString(18)

                            ' Load existing picture if available
                            If Not reader.IsDBNull(19) Then
                                Try
                                    Dim picValue As Object = reader.GetValue(19)
                                    If TypeOf picValue Is String AndAlso Not String.IsNullOrEmpty(CStr(picValue)) Then
                                        Dim picPath As String = CStr(picValue)
                                        editForm.SetOriginalPicturePath(picPath)
                                        If System.IO.File.Exists(picPath) Then
                                            editForm.picIdPicture.Image = System.Drawing.Image.FromFile(picPath)
                                            editForm.picIdPicture.SizeMode = PictureBoxSizeMode.StretchImage
                                        End If
                                    End If
                                Catch ex As Exception
                                    ' If picture loading fails, continue without picture
                                End Try
                            End If

                            ' Handle the update after save
                            AddHandler editForm.ResidentSaved, Sub(resident As ResidentData)
                                                                   LoadResidents()
                                                                   MessageBox.Show("Resident information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                               End Sub

                            editForm.ShowDialog()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error editing resident: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadResidentDetails(residentId As Integer)
        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT id, lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, address, religion, idpic FROM tbl_residentinfo WHERE id = @id"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", residentId)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim resident As New ResidentData()
                            resident.Id = If(Not reader.IsDBNull(0), reader.GetInt32(0), 0)
                            resident.LastName = If(Not reader.IsDBNull(1), reader.GetString(1), String.Empty)
                            resident.FirstName = If(Not reader.IsDBNull(2), reader.GetString(2), String.Empty)
                            resident.MiddleName = If(Not reader.IsDBNull(3), reader.GetString(3), String.Empty)
                            resident.Gender = If(Not reader.IsDBNull(4), reader.GetString(4), String.Empty)
                            resident.BirthDate = If(Not reader.IsDBNull(5), reader.GetDateTime(5), DateTime.MinValue)
                            resident.Age = If(Not reader.IsDBNull(6), reader.GetInt32(6), 0)
                            resident.PhoneNumber = If(Not reader.IsDBNull(7), reader.GetString(7), String.Empty)
                            resident.CivilStatus = If(Not reader.IsDBNull(8), reader.GetString(8), String.Empty)
                            resident.Citizenship = If(Not reader.IsDBNull(9), reader.GetString(9), String.Empty)
                            resident.FathersName = If(Not reader.IsDBNull(10), reader.GetString(10), String.Empty)
                            resident.MothersName = If(Not reader.IsDBNull(11), reader.GetString(11), String.Empty)
                            resident.Spouse = If(Not reader.IsDBNull(12), reader.GetString(12), String.Empty)
                            resident.Email = If(Not reader.IsDBNull(13), reader.GetString(13), String.Empty)
                            resident.VotersStatus = If(Not reader.IsDBNull(14), reader.GetString(14), String.Empty)
                            resident.Weight = If(Not reader.IsDBNull(15), reader.GetString(15), String.Empty)
                            resident.Height = If(Not reader.IsDBNull(16), reader.GetString(16), String.Empty)
                            resident.Address = If(Not reader.IsDBNull(17), reader.GetString(17), String.Empty)
                            resident.Religion = If(Not reader.IsDBNull(18), reader.GetString(18), String.Empty)
                            ' Handle idpic which can be either a byte array (BLOB) or string
                            If Not reader.IsDBNull(19) Then
                                If TypeOf reader.GetValue(19) Is Byte() Then
                                    ' It's a byte array - convert to string (file path or just leave empty)
                                    resident.IdPicture = String.Empty
                                Else
                                    ' It's a string
                                    resident.IdPicture = reader.GetString(19)
                                End If
                            Else
                                resident.IdPicture = String.Empty
                            End If
                            resident.MobileNo = resident.PhoneNumber

                            ' Populate all controls with resident data
                            txtLastName.Text = resident.LastName
                            txtFirstName.Text = resident.FirstName
                            txtMiddleName.Text = resident.MiddleName

                            ' Set Gender ComboBox
                            If Not String.IsNullOrEmpty(resident.Gender) Then
                                Dim genderIndex As Integer = cmbGender.FindStringExact(resident.Gender)
                                If genderIndex >= 0 Then
                                    cmbGender.SelectedIndex = genderIndex
                                Else
                                    cmbGender.Text = resident.Gender
                                End If
                            End If

                            dtpBirthdate.Value = If(resident.BirthDate <> DateTime.MinValue, resident.BirthDate, DateTime.Now)
                            txtAge.Text = resident.Age.ToString()

                            ' Set Civil Status ComboBox
                            If Not String.IsNullOrEmpty(resident.CivilStatus) Then
                                Dim civilStatusIndex As Integer = cmbCivilStatus.FindStringExact(resident.CivilStatus)
                                If civilStatusIndex >= 0 Then
                                    cmbCivilStatus.SelectedIndex = civilStatusIndex
                                Else
                                    cmbCivilStatus.Text = resident.CivilStatus
                                End If
                            End If

                            txtCitizenship.Text = resident.Citizenship
                            txtPhoneNumber.Text = resident.PhoneNumber
                            txtFathersName.Text = resident.FathersName
                            txtMothersName.Text = resident.MothersName
                            txtSpouse.Text = resident.Spouse

                            ' Set Voters Status ComboBox
                            If Not String.IsNullOrEmpty(resident.VotersStatus) Then
                                Dim votersStatusIndex As Integer = cmbVotersStatus.FindStringExact(resident.VotersStatus)
                                If votersStatusIndex >= 0 Then
                                    cmbVotersStatus.SelectedIndex = votersStatusIndex
                                Else
                                    ' Try to match common variations
                                    Dim status As String = resident.VotersStatus.ToLower()
                                    If status.Contains("registered") OrElse status.Contains("active") Then
                                        cmbVotersStatus.SelectedIndex = cmbVotersStatus.FindStringExact("Registered")
                                    ElseIf status.Contains("not") OrElse status.Contains("inactive") Then
                                        cmbVotersStatus.SelectedIndex = cmbVotersStatus.FindStringExact("Not Registered")
                                    Else
                                        cmbVotersStatus.Text = resident.VotersStatus
                                    End If
                                End If
                            End If

                            txtReligion.Text = resident.Religion
                            txtHeight.Text = resident.Height
                            txtWeight.Text = resident.Weight
                            txtAddress.Text = resident.Address

                            ' Load profile picture if available
                            Try
                                If Not String.IsNullOrEmpty(resident.IdPicture) AndAlso System.IO.File.Exists(resident.IdPicture) Then
                                    picProfile.Image = System.Drawing.Image.FromFile(resident.IdPicture)
                                    picProfile.SizeMode = PictureBoxSizeMode.StretchImage
                                Else
                                    picProfile.Image = Nothing
                                End If
                            Catch ex As Exception
                                picProfile.Image = Nothing
                            End Try
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading resident details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellContentClick

    End Sub

    Private Sub lblShowEntries_Click(sender As Object, e As EventArgs) Handles lblShowEntries.Click

    End Sub
End Class