Public Class residentinfo
    Private residentForm As residentform
    Private residentsList As New List(Of ResidentData)

    Public Sub New()
        InitializeComponent()
        InitializeComboBoxes()
        LoadResidents()
        InitializeSelectAllCheckbox()
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
                Dim sql As String = "SELECT lastname, firstname, middlename, phoneno, gender FROM tbl_residentinfo"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim data As New ResidentData()
                            data.LastName = If(Not reader.IsDBNull(0), reader.GetString(0), String.Empty)
                            data.FirstName = If(Not reader.IsDBNull(1), reader.GetString(1), String.Empty)
                            data.MiddleName = If(Not reader.IsDBNull(2), reader.GetString(2), String.Empty)
                            data.MobileNo = If(Not reader.IsDBNull(3), reader.GetString(3), String.Empty)
                            data.Gender = If(Not reader.IsDBNull(4), reader.GetString(4), String.Empty)
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
            ' Ensure checkbox starts unchecked for accuracy
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = False
            dgvResidents.Rows(rowIndex).Cells("colID").Value = "" ' ID column removed - using composite key instead
            dgvResidents.Rows(rowIndex).Cells("colLastName").Value = resident.LastName
            dgvResidents.Rows(rowIndex).Cells("colFirstName").Value = resident.FirstName
            dgvResidents.Rows(rowIndex).Cells("colMiddleName").Value = resident.MiddleName
            dgvResidents.Rows(rowIndex).Cells("colMobileNo").Value = resident.MobileNo
            dgvResidents.Rows(rowIndex).Cells("colGender").Value = resident.Gender
            dgvResidents.Rows(rowIndex).Cells("colAction").Value = "Edit"
        Next

        lblShowEntries.Text = $"Showing 1 to {residentsList.Count} of {residentsList.Count} entries"
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResidentApp.Click
        residentForm = New residentform()
        AddHandler residentForm.ResidentSaved, AddressOf OnResidentSaved
        residentForm.ShowDialog()
    End Sub

    Private Sub OnResidentSaved(resident As ResidentData)
        ' Reload residents from database to get the proper ID and ensure data consistency
        LoadResidents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            ' Keep checkbox accurate: do not auto-check on filter
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = False
            dgvResidents.Rows(rowIndex).Cells("colID").Value = "" ' ID column removed - using composite key instead
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
            ' Get resident data from the selected row using composite key
            Dim lastName As String = If(dgvResidents.Rows(e.RowIndex).Cells("colLastName").Value IsNot Nothing, dgvResidents.Rows(e.RowIndex).Cells("colLastName").Value.ToString(), "")
            Dim firstName As String = If(dgvResidents.Rows(e.RowIndex).Cells("colFirstName").Value IsNot Nothing, dgvResidents.Rows(e.RowIndex).Cells("colFirstName").Value.ToString(), "")

            ' Check if the Edit button in the Action column was clicked
            If e.ColumnIndex = dgvResidents.Columns("colAction").Index Then
                EditResident(lastName, firstName)
            Else
                ' Load and display resident details in the right panel
                LoadResidentDetails(lastName, firstName)
            End If
        End If
    End Sub

    Private Sub EditResident(lastName As String, firstName As String)
        Try
            ' Load resident data for editing using composite key
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, address, religion, idpic FROM tbl_residentinfo WHERE lastname = @ln AND firstname = @fn"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ln", lastName)
                    cmd.Parameters.AddWithValue("@fn", firstName)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Open resident form in edit mode
                            Dim editForm As New residentform()
                            ' Set the editing resident using composite key (lastname, firstname, birthdate)
                            Dim birthDate As DateTime = If(Not reader.IsDBNull(4), reader.GetDateTime(4), DateTime.Now)
                            editForm.SetEditingResident(lastName, firstName, birthDate)
                            ' Load the existing data into the form
                            If Not reader.IsDBNull(0) Then editForm.txtLastName.Text = reader.GetString(0)
                            If Not reader.IsDBNull(1) Then editForm.txtFirstName.Text = reader.GetString(1)
                            If Not reader.IsDBNull(2) Then editForm.txtMiddleName.Text = reader.GetString(2)

                            ' Set Gender ComboBox
                            If Not reader.IsDBNull(3) Then
                                Dim genderValue As String = reader.GetString(3)
                                Dim genderIndex As Integer = editForm.cmbGender.FindStringExact(genderValue)
                                If genderIndex >= 0 Then
                                    editForm.cmbGender.SelectedIndex = genderIndex
                                Else
                                    editForm.cmbGender.Text = genderValue
                                End If
                            End If

                            If Not reader.IsDBNull(4) Then editForm.dtpBirthDate.Value = reader.GetDateTime(4)
                            If Not reader.IsDBNull(5) Then editForm.txtAge.Text = reader.GetInt32(5).ToString()
                            If Not reader.IsDBNull(6) Then editForm.txtPhoneNumber.Text = reader.GetString(6)

                            ' Set Civil Status ComboBox
                            If Not reader.IsDBNull(7) Then
                                Dim civilStatusValue As String = reader.GetString(7)
                                Dim civilStatusIndex As Integer = editForm.cmbCivilStatus.FindStringExact(civilStatusValue)
                                If civilStatusIndex >= 0 Then
                                    editForm.cmbCivilStatus.SelectedIndex = civilStatusIndex
                                Else
                                    editForm.cmbCivilStatus.Text = civilStatusValue
                                End If
                            End If

                            If Not reader.IsDBNull(8) Then editForm.txtCitizenship.Text = reader.GetString(8)
                            If Not reader.IsDBNull(9) Then editForm.txtFathersName.Text = reader.GetString(9)
                            If Not reader.IsDBNull(10) Then editForm.txtMothersName.Text = reader.GetString(10)
                            If Not reader.IsDBNull(11) Then editForm.txtSpouse.Text = reader.GetString(11)
                            If Not reader.IsDBNull(12) Then editForm.txtEmail.Text = reader.GetString(12)

                            ' Set Voters Status ComboBox
                            If Not reader.IsDBNull(13) Then
                                Dim votersStatusValue As String = reader.GetString(13)
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

                            If Not reader.IsDBNull(14) Then editForm.txtWeight.Text = reader.GetString(14)
                            If Not reader.IsDBNull(15) Then editForm.txtHeight.Text = reader.GetString(15)
                            If Not reader.IsDBNull(16) Then editForm.txtAddress.Text = reader.GetString(16)
                            If Not reader.IsDBNull(17) Then editForm.txtReligion.Text = reader.GetString(17)

                            ' Load existing picture if available (supports file path or BLOB)
                            If Not reader.IsDBNull(18) Then
                                Try
                                    Dim picValue As Object = reader.GetValue(18)
                                    If TypeOf picValue Is Byte() Then
                                        Dim bytes As Byte() = CType(picValue, Byte())
                                        Using ms As New System.IO.MemoryStream(bytes)
                                            Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                            editForm.picIdPicture.Image = img
                                            editForm.picIdPicture.SizeMode = PictureBoxSizeMode.Zoom
                                        End Using
                                    ElseIf TypeOf picValue Is String AndAlso Not String.IsNullOrEmpty(CStr(picValue)) Then
                                        Dim picPath As String = CStr(picValue)
                                        editForm.SetOriginalPicturePath(picPath)
                                        If System.IO.File.Exists(picPath) Then
                                            Using fs As New System.IO.FileStream(picPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                                editForm.picIdPicture.Image = System.Drawing.Image.FromStream(fs)
                                            End Using
                                            editForm.picIdPicture.SizeMode = PictureBoxSizeMode.Zoom
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

    Private Sub LoadResidentDetails(lastName As String, firstName As String)
        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, voterstatus, weight, height, address, religion, idpic FROM tbl_residentinfo WHERE lastname = @ln AND firstname = @fn"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ln", lastName)
                    cmd.Parameters.AddWithValue("@fn", firstName)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim resident As New ResidentData()
                            resident.LastName = If(Not reader.IsDBNull(0), reader.GetString(0), String.Empty)
                            resident.FirstName = If(Not reader.IsDBNull(1), reader.GetString(1), String.Empty)
                            resident.MiddleName = If(Not reader.IsDBNull(2), reader.GetString(2), String.Empty)
                            resident.Gender = If(Not reader.IsDBNull(3), reader.GetString(3), String.Empty)
                            resident.BirthDate = If(Not reader.IsDBNull(4), reader.GetDateTime(4), DateTime.MinValue)
                            resident.Age = If(Not reader.IsDBNull(5), reader.GetInt32(5), 0)
                            resident.PhoneNumber = If(Not reader.IsDBNull(6), reader.GetString(6), String.Empty)
                            resident.CivilStatus = If(Not reader.IsDBNull(7), reader.GetString(7), String.Empty)
                            resident.Citizenship = If(Not reader.IsDBNull(8), reader.GetString(8), String.Empty)
                            resident.FathersName = If(Not reader.IsDBNull(9), reader.GetString(9), String.Empty)
                            resident.MothersName = If(Not reader.IsDBNull(10), reader.GetString(10), String.Empty)
                            resident.Spouse = If(Not reader.IsDBNull(11), reader.GetString(11), String.Empty)
                            resident.Email = If(Not reader.IsDBNull(12), reader.GetString(12), String.Empty)
                            resident.VotersStatus = If(Not reader.IsDBNull(13), reader.GetString(13), String.Empty)
                            resident.Weight = If(Not reader.IsDBNull(14), reader.GetString(14), String.Empty)
                            resident.Height = If(Not reader.IsDBNull(15), reader.GetString(15), String.Empty)
                            resident.Address = If(Not reader.IsDBNull(16), reader.GetString(16), String.Empty)
                            resident.Religion = If(Not reader.IsDBNull(17), reader.GetString(17), String.Empty)
                            ' Handle idpic which can be either a byte array (BLOB) or string
                            If Not reader.IsDBNull(18) Then
                                If TypeOf reader.GetValue(18) Is Byte() Then
                                    ' It's a byte array - convert to string (file path or just leave empty)
                                    resident.IdPicture = String.Empty
                                Else
                                    ' It's a string
                                    resident.IdPicture = reader.GetString(18)
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

                            ' Load profile picture if available (supports path or BLOB)
                            Try
                                If picProfile.Image IsNot Nothing Then
                                    picProfile.Image.Dispose()
                                    picProfile.Image = Nothing
                                End If

                                ' Attempt to read as BLOB (byte array) first
                                Dim picObj As Object = Nothing
                                Try
                                    picObj = reader.GetValue(18)
                                Catch
                                    picObj = Nothing
                                End Try

                                If picObj IsNot Nothing AndAlso TypeOf picObj Is Byte() Then
                                    Dim bytes As Byte() = CType(picObj, Byte())
                                    Dim loaded As Boolean = False
                                    ' Try: bytes are raw image
                                    Try
                                        Using ms As New System.IO.MemoryStream(bytes)
                                            picProfile.Image = System.Drawing.Image.FromStream(ms)
                                            loaded = True
                                        End Using
                                    Catch
                                        loaded = False
                                    End Try

                                    If Not loaded Then
                                        ' Fallback: bytes actually encode a UTF8 path or base64 string
                                        Try
                                            Dim asText As String = System.Text.Encoding.UTF8.GetString(bytes).Trim().Trim(""""c)
                                            If asText.Length > 0 Then
                                                If System.IO.File.Exists(asText) Then
                                                    Using fs As New System.IO.FileStream(asText, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
                                                        picProfile.Image = System.Drawing.Image.FromStream(fs)
                                                    End Using
                                                    loaded = True
                                                Else
                                                    ' Maybe base64
                                                    Dim b As Byte() = Convert.FromBase64String(asText)
                                                    Using ms As New System.IO.MemoryStream(b)
                                                        picProfile.Image = System.Drawing.Image.FromStream(ms)
                                                    End Using
                                                    loaded = True
                                                End If
                                            End If
                                        Catch
                                            loaded = False
                                        End Try
                                    End If

                                    If loaded Then
                                        picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                        picProfile.Refresh()
                                    Else
                                        picProfile.Image = Nothing
                                        picProfile.Refresh()
                                    End If
                                ElseIf Not String.IsNullOrEmpty(resident.IdPicture) Then
                                    If System.IO.File.Exists(resident.IdPicture) Then
                                        Using fs As New System.IO.FileStream(resident.IdPicture, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
                                            picProfile.Image = System.Drawing.Image.FromStream(fs)
                                        End Using
                                        picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                        picProfile.Refresh()
                                    Else
                                        ' Try to decode as Base64-encoded image string
                                        Try
                                            Dim base64 As String = resident.IdPicture.Trim()
                                            Dim bytes As Byte() = Convert.FromBase64String(base64)
                                            Using ms As New System.IO.MemoryStream(bytes)
                                                picProfile.Image = System.Drawing.Image.FromStream(ms)
                                            End Using
                                            picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                            picProfile.Refresh()
                                        Catch
                                            picProfile.Image = Nothing
                                            picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                            picProfile.Refresh()
                                        End Try
                                    End If
                                Else
                                    picProfile.Image = Nothing
                                    picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                    picProfile.Refresh()
                                End If
                            Catch ex As Exception
                                If picProfile.Image IsNot Nothing Then
                                    picProfile.Image.Dispose()
                                    picProfile.Image = Nothing
                                End If
                                picProfile.SizeMode = PictureBoxSizeMode.Zoom
                                picProfile.Refresh()
                            End Try
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading resident details:  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== Select-All Checkbox in DataGridView Header =====
    Private headerCheckBox As CheckBox

    Private Sub InitializeSelectAllCheckbox()
        If dgvResidents Is Nothing OrElse dgvResidents.Columns("chkSelectAll") Is Nothing Then Return
        headerCheckBox = New CheckBox()
        headerCheckBox.Size = New Size(15, 15)
        headerCheckBox.BackColor = Color.Transparent
        AddHandler headerCheckBox.CheckedChanged, AddressOf HeaderCheckBox_CheckedChanged
        dgvResidents.Controls.Add(headerCheckBox)
        PositionHeaderCheckBox()
    End Sub

    Private Sub PositionHeaderCheckBox()
        Try
            If dgvResidents Is Nothing OrElse headerCheckBox Is Nothing Then Return
            Dim col As DataGridViewColumn = Nothing
            Try
                col = dgvResidents.Columns("chkSelectAll")
            Catch
                col = Nothing
            End Try
            If col Is Nothing Then Return
            Dim rect = dgvResidents.GetCellDisplayRectangle(col.Index, -1, True)
            If rect.Width <= 0 OrElse rect.Height <= 0 Then Return
            headerCheckBox.Location = New Point(rect.X + (rect.Width - headerCheckBox.Width) \ 2, rect.Y + (rect.Height - headerCheckBox.Height) \ 2)
        Catch
        End Try
    End Sub

    Private Sub HeaderCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        For Each row As DataGridViewRow In dgvResidents.Rows
            row.Cells("chkSelectAll").Value = headerCheckBox.Checked
        Next
    End Sub

    Private Sub dgvResidents_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
        PositionHeaderCheckBox()
    End Sub

    Private Sub dgvResidents_Scroll(sender As Object, e As ScrollEventArgs)
        PositionHeaderCheckBox()
    End Sub

    Private Sub dgvResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvResidents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResidents.SelectionChanged
        ' Load resident details when a row is selected (supports keyboard navigation)
        If dgvResidents.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvResidents.SelectedRows(0)
            If selectedRow.Index >= 0 Then
                Dim lastName As String = If(selectedRow.Cells("colLastName").Value IsNot Nothing, selectedRow.Cells("colLastName").Value.ToString(), "")
                Dim firstName As String = If(selectedRow.Cells("colFirstName").Value IsNot Nothing, selectedRow.Cells("colFirstName").Value.ToString(), "")

                If Not String.IsNullOrEmpty(lastName) AndAlso Not String.IsNullOrEmpty(firstName) Then
                    ' Only load if not clicking the Action column (to avoid conflicts with CellClick)
                    If dgvResidents.CurrentCell Is Nothing OrElse dgvResidents.CurrentCell.ColumnIndex <> dgvResidents.Columns("colAction").Index Then
                        LoadResidentDetails(lastName, firstName)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lblShowEntries_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvResidents_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellContentClick

    End Sub

    Private Sub panelRight_Paint(sender As Object, e As PaintEventArgs) Handles panelRight.Paint

    End Sub

    Private Sub residentinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure header checkbox is positioned on initial load
        PositionHeaderCheckBox()
    End Sub
End Class