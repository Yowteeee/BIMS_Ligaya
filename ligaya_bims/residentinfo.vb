Public Class residentinfo
    Private residentForm As residentform
    Private residentsList As New List(Of ResidentData)

    Public Sub New()
        InitializeComponent()
        LoadResidents()
    End Sub

    Private Sub LoadResidents()
        ' Load residents from database: only lastname, firstname, middlename, phoneno, gender
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
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = False
            dgvResidents.Rows(rowIndex).Cells("colAction").Value = "✏️ 👁️ 🗑️"
            dgvResidents.Rows(rowIndex).Cells("colLastName").Value = resident.LastName
            dgvResidents.Rows(rowIndex).Cells("colFirstName").Value = resident.FirstName
            dgvResidents.Rows(rowIndex).Cells("colMiddleName").Value = resident.MiddleName
            dgvResidents.Rows(rowIndex).Cells("colMobileNo").Value = resident.MobileNo
            dgvResidents.Rows(rowIndex).Cells("colGender").Value = resident.Gender
        Next
        
        lblShowingEntries.Text = $"Showing 1 to {residentsList.Count} of {residentsList.Count} entries"
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        residentForm = New residentform()
        AddHandler residentForm.ResidentSaved, AddressOf OnResidentSaved
        residentForm.ShowDialog()
    End Sub

    Private Sub OnResidentSaved(resident As ResidentData)
        residentsList.Add(resident)
        RefreshDataGrid()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText = txtSearch.Text.ToLower()
        
        If String.IsNullOrEmpty(searchText) Then
            RefreshDataGrid()
            Return
        End If
        
        dgvResidents.Rows.Clear()
        Dim filteredResidents = residentsList.Where(Function(r) _
            r.FirstName.ToLower().Contains(searchText) OrElse _
            r.LastName.ToLower().Contains(searchText) OrElse _
            r.MiddleName.ToLower().Contains(searchText) _
        ).ToList()
        
        For Each resident In filteredResidents
            Dim rowIndex = dgvResidents.Rows.Add()
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = True
            dgvResidents.Rows(rowIndex).Cells("colAction").Value = "✏️ 👁️ 🗑️"
            dgvResidents.Rows(rowIndex).Cells("colLastName").Value = resident.LastName
            dgvResidents.Rows(rowIndex).Cells("colFirstName").Value = resident.FirstName
            dgvResidents.Rows(rowIndex).Cells("colMiddleName").Value = resident.MiddleName
            dgvResidents.Rows(rowIndex).Cells("colMobileNo").Value = resident.MobileNo
            dgvResidents.Rows(rowIndex).Cells("colGender").Value = resident.Gender
        Next
        
        lblShowingEntries.Text = $"Showing 1 to {filteredResidents.Count} of {filteredResidents.Count} entries"
    End Sub

    Private Sub btnExportResident_Click(sender As Object, e As EventArgs) Handles btnExportResident.Click
        MessageBox.Show("Export functionality will be implemented here", "Export Residents", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteResident_Click(sender As Object, e As EventArgs) Handles btnDeleteResident.Click
        MessageBox.Show("Delete functionality will be implemented here", "Delete Residents", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Private Sub dgvResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellContentClick

    End Sub
End Class

Public Class ResidentData
    Public Property LastName As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property BirthDate As DateTime
    Public Property Age As Integer
    Public Property Gender As String
    Public Property VotersStatus As String
    Public Property CivilStatus As String
    Public Property Citizenship As String
    Public Property PhoneNumber As String
    Public Property Height As String
    Public Property Weight As String
    Public Property Email As String
    Public Property Spouse As String
    Public Property FathersName As String
    Public Property MothersName As String
    Public Property IdPicture As String
    Public Property MobileNo As String
End Class