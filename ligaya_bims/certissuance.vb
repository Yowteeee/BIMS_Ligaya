Public Class certissuance
    Private residentsList As New List(Of ResidentData)

    ' Method to handle when form is displayed as child form in dashboard
    Public Sub SetAsChildForm()
        ' Ensure the form is properly configured for child display
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub btnCreateCertificate_Click(sender As Object, e As EventArgs) Handles btnCreateCertificate.Click
        Dim f As New certificateform()
        AddHandler f.CertificateSaved, Sub()
                                           ' Hook for refreshing lists after save if needed
                                           ' Currently left empty as grid shows residents
                                       End Sub
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowDialog(Me)

    End Sub

    Private Sub certissuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidents()
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
        DataGridView1.Rows.Clear()

        For Each resident In residentsList
            Dim rowIndex = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn1").Value = "Select"
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn2").Value = resident.LastName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn3").Value = resident.FirstName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn4").Value = resident.MiddleName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn5").Value = resident.MobileNo
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn6").Value = resident.Gender
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchText = TextBox1.Text.ToLower()

        If String.IsNullOrEmpty(searchText) Then
            RefreshDataGrid()
            Return
        End If

        DataGridView1.Rows.Clear()
        Dim filteredResidents = residentsList.Where(Function(r) _
            r.FirstName.ToLower().Contains(searchText) OrElse
            r.LastName.ToLower().Contains(searchText) OrElse
            r.MiddleName.ToLower().Contains(searchText)
        ).ToList()

        For Each resident In filteredResidents
            Dim rowIndex = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn1").Value = "Select"
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn2").Value = resident.LastName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn3").Value = resident.FirstName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn4").Value = resident.MiddleName
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn5").Value = resident.MobileNo
            DataGridView1.Rows(rowIndex).Cells("DataGridViewTextBoxColumn6").Value = resident.Gender
        Next
    End Sub

    Private Sub dgvResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class