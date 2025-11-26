Public Class blotterform

    ' Method to handle when form is displayed as child form in dashboard
    Public Sub SetAsChildForm()
        ' Ensure the form is properly configured for child display
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub blotterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default search option
        If cmbSearchBy.Items.Count > 0 Then
            cmbSearchBy.SelectedIndex = 0
        End If

        ' Initialize DataGridViews
        InitializeDataGridViews()

        ' Load data
        LoadBlotterRecords()
        LoadScheduleRecords()
    End Sub

    Private Sub InitializeDataGridViews()
        ' Initialize Blotter Records DGV columns
        dgvBlotterRecords.Columns.Clear()
        dgvBlotterRecords.Columns.Add("CaseNumber", "Brgy. Case #")
        dgvBlotterRecords.Columns.Add("Accusation", "Accusation")
        dgvBlotterRecords.Columns.Add("ComplainantName", "Complainant's Full Name")
        dgvBlotterRecords.Columns.Add("Purok", "Complainant's Purok")

        ' Initialize Schedule DGV columns
        dgvSchedule.Columns.Clear()
        dgvSchedule.Columns.Add("SummonLevel", "Summon Level")
        dgvSchedule.Columns.Add("CaseDate", "Case Date")
        dgvSchedule.Columns.Add("StartTime", "Start Time")
        dgvSchedule.Columns.Add("EndTime", "End")
    End Sub

    Private Sub LoadBlotterRecords()
        Try
            dgvBlotterRecords.Rows.Clear()

            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT case_number, accusation, complainant_name, purok FROM tbl_blotter ORDER BY case_number DESC"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvBlotterRecords.Rows.Add(
                                If(reader.IsDBNull(0), "", reader.GetString(0)),
                                If(reader.IsDBNull(1), "", reader.GetString(1)),
                                If(reader.IsDBNull(2), "", reader.GetString(2)),
                                If(reader.IsDBNull(3), "", reader.GetString(3))
                            )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ' Table might not exist yet, show empty grid
            MessageBox.Show("Blotter table not found. Please create the database table first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error loading blotter records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadScheduleRecords()
        Try
            dgvSchedule.Rows.Clear()

            ' Get selected case number from blotter records
            If dgvBlotterRecords.SelectedRows.Count > 0 Then
                Dim caseNumber As String = dgvBlotterRecords.SelectedRows(0).Cells("CaseNumber").Value.ToString()

                Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                    conn.Open()
                    Dim sql As String = "SELECT summon_level, case_date, start_time, end_time FROM tbl_blotter_schedule WHERE case_number = @caseNumber ORDER BY case_date DESC"
                    Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@caseNumber", caseNumber)
                        Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                dgvSchedule.Rows.Add(
                                    If(reader.IsDBNull(0), "", reader.GetString(0)),
                                    If(reader.IsDBNull(1), "", reader.GetDateTime(1).ToString("MM/dd/yyyy")),
                                    If(reader.IsDBNull(2), "", reader.GetTimeSpan(2).ToString("hh\:mm")),
                                    If(reader.IsDBNull(3), "", reader.GetTimeSpan(3).ToString("hh\:mm"))
                                )
                            End While
                        End Using
                    End Using
                End Using
            End If
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ' Table might not exist yet, show empty grid
        Catch ex As Exception
            ' Silently fail if no schedule data
        End Try
    End Sub

    ' Button Click Handlers for Blotter Records
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            Using incidentForm As New reportsform()
                AddHandler incidentForm.IncidentSubmitted, AddressOf HandleIncidentSubmitted
                incidentForm.StartPosition = FormStartPosition.CenterParent
                incidentForm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Unable to open incident report form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HandleIncidentSubmitted()
        LoadBlotterRecords()
        LoadScheduleRecords()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Open edit blotter record form with selected record data
        Dim caseNumber As String = dgvBlotterRecords.SelectedRows(0).Cells("CaseNumber").Value.ToString()
        MessageBox.Show($"Edit Blotter Record functionality for Case #{caseNumber} will be implemented here.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim caseNumber As String = dgvBlotterRecords.SelectedRows(0).Cells("CaseNumber").Value.ToString()
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete Case #{caseNumber}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_blotter WHERE case_number = @caseNumber"
                    Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@caseNumber", caseNumber)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBlotterRecords()
            Catch ex As Exception
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to print.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Implement print functionality
        MessageBox.Show("Print functionality will be implemented here.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Button Click Handlers for Schedule
    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a blotter record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Open add schedule form
        MessageBox.Show("Add Schedule functionality will be implemented here.", "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEditSchedule_Click(sender As Object, e As EventArgs) Handles btnEditSchedule.Click
        If dgvSchedule.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a schedule to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Open edit schedule form
        MessageBox.Show("Edit Schedule functionality will be implemented here.", "Edit Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteSchedule_Click(sender As Object, e As EventArgs) Handles btnDeleteSchedule.Click
        If dgvSchedule.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a schedule to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' TODO: Implement delete schedule
            MessageBox.Show("Delete Schedule functionality will be implemented here.", "Delete Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadScheduleRecords()
        End If
    End Sub

    Private Sub btnUpdateSettlementStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateSettlementStatus.Click
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a blotter record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Open update settlement status form
        Dim caseNumber As String = dgvBlotterRecords.SelectedRows(0).Cells("CaseNumber").Value.ToString()
        MessageBox.Show($"Update Settlement Status functionality for Case #{caseNumber} will be implemented here.", "Update Settlement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Search functionality
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' TODO: Implement search filtering
        ' For now, just reload all records
        LoadBlotterRecords()
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        ' Reset search when filter changes
        txtSearch.Clear()
    End Sub

    ' DataGridView event handlers
    Private Sub dgvBlotterRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBlotterRecords.SelectionChanged
        ' Load schedule when a blotter record is selected
        If dgvBlotterRecords.SelectedRows.Count > 0 Then
            LoadScheduleRecords()
        End If
    End Sub

    Private Sub dgvSchedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellContentClick

    End Sub
End Class