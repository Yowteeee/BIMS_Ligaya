Public Class residentinfo
    Private residentForm As residentform
    Private residentsList As New List(Of ResidentData)

    Public Sub New()
        InitializeComponent()
        LoadResidents()
    End Sub

    Private Sub LoadResidents()
        ' Load sample data for demonstration
        residentsList.Clear()
        
        ' Add sample residents
        residentsList.Add(New ResidentData With {
            .LastName = "Enriquez",
            .FirstName = "Ricardo", 
            .MiddleName = "Saavedra",
            .MobileNo = "09172630847",
            .Gender = "male"
        })
        
        residentsList.Add(New ResidentData With {
            .LastName = "De Lacruz",
            .FirstName = "Juan",
            .MiddleName = "Diamante", 
            .MobileNo = "123123123",
            .Gender = "male"
        })
        
        residentsList.Add(New ResidentData With {
            .LastName = "Hodkiewicz",
            .FirstName = "Emmanuelle",
            .MiddleName = "Javier",
            .MobileNo = "+1-239-598-5809", 
            .Gender = "male"
        })
        
        residentsList.Add(New ResidentData With {
            .LastName = "Johnston",
            .FirstName = "Cordia",
            .MiddleName = "Cristian",
            .MobileNo = "8305130233",
            .Gender = "female"
        })
        
        residentsList.Add(New ResidentData With {
            .LastName = "Howe",
            .FirstName = "Chris",
            .MiddleName = "Hazel",
            .MobileNo = "(201) 476-1215",
            .Gender = "female"
        })
        
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
            dgvResidents.Rows(rowIndex).Cells("chkSelectAll").Value = False
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