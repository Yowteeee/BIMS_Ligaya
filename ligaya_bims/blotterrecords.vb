Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class blotterrecords

    Public Sub New()
        InitializeComponent()
    End Sub

    Private editIcon As Image
    Private deleteIcon As Image
    Private printIcon As Image
    Private caseNumberColumnReady As Boolean = False

    ' Robust design-time detection to avoid running runtime logic in VS Designer
    Private Function IsInDesigner() As Boolean
        Try
            If Me IsNot Nothing AndAlso Me.DesignMode Then Return True
        Catch
        End Try
        Try
            If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return True
        Catch
        End Try
        Try
            Dim procName As String = System.Diagnostics.Process.GetCurrentProcess().ProcessName
            If String.Equals(procName, "devenv", StringComparison.OrdinalIgnoreCase) Then Return True
        Catch
        End Try
        Return False
    End Function

    ' Method to handle when form is displayed as child form in dashboard
    Public Sub SetAsChildForm()
        ' Ensure the form is properly configured for child display
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub blotterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Skip runtime logic entirely when opened inside the designer
        If IsInDesigner() Then
            Return
        End If

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

    ' Enable draggable buttons within the schedule action panel
    Private dragStart As Point
    Private Sub ActionButton_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddSchedule.MouseDown, btnEditSchedule.MouseDown, btnDeleteSchedule.MouseDown, btnUpdateSettlementStatus.MouseDown
        If IsInDesigner() Then
            Return
        End If

        dragStart = e.Location
    End Sub

    Private Sub ActionButton_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAddSchedule.MouseMove, btnEditSchedule.MouseMove, btnDeleteSchedule.MouseMove, btnUpdateSettlementStatus.MouseMove
        If IsInDesigner() Then
            Return
        End If

        If e.Button = MouseButtons.Left Then
            Dim btn As Control = DirectCast(sender, Control)
            Dim parent As Control = btn.Parent
            If parent Is Nothing Then
                Return
            End If

            Dim newLocation As Point = btn.Location
            newLocation.X += e.X - dragStart.X
            newLocation.Y += e.Y - dragStart.Y
            ' Constrain within parent padded bounds
            Dim minX As Integer = parent.Padding.Left
            Dim minY As Integer = parent.Padding.Top
            Dim maxX As Integer = parent.ClientSize.Width - btn.Width - parent.Padding.Right
            Dim maxY As Integer = parent.ClientSize.Height - btn.Height - parent.Padding.Bottom
            newLocation.X = Math.Max(minX, Math.Min(maxX, newLocation.X))
            newLocation.Y = Math.Max(minY, Math.Min(maxY, newLocation.Y))
            btn.Location = newLocation
        End If
    End Sub

    Private Sub InitializeDataGridViews()
        LoadActionIcons()

        StyleDataGridView(dgvBlotterRecords)
        StyleDataGridView(dgvSchedule)

        AssignActionIcon("colEdit", editIcon, "Edit record")
        AssignActionIcon("colDelete", deleteIcon, "Delete record")
        AssignActionIcon("colPrint", printIcon, "Print record")
    End Sub

    Private Sub StyleDataGridView(grid As DataGridView)
        grid.AutoGenerateColumns = False
        grid.RowTemplate.Height = 44
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.MultiSelect = False
        grid.ReadOnly = True
        grid.EnableHeadersVisualStyles = False

        grid.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33)
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201)
        grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 33, 33)

        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 248, 246)
        grid.GridColor = Color.FromArgb(189, 189, 189)
    End Sub

    Private Sub AssignActionIcon(columnName As String, icon As Image, toolTip As String)
        Dim column As DataGridViewImageColumn = TryCast(dgvBlotterRecords.Columns(columnName), DataGridViewImageColumn)
        If column Is Nothing Then
            Return
        End If

        column.Image = icon
        column.ToolTipText = toolTip
        column.ValuesAreIcons = True
        column.DefaultCellStyle.NullValue = icon
    End Sub

    Private Sub EnsureBlotterCaseNumberColumn()
        If caseNumberColumnReady Then
            Return
        End If

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim existsSql As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'tbl_blotter' AND COLUMN_NAME = 'case_number'"
                Using existsCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(existsSql, conn)
                    Dim columnExists As Boolean = Convert.ToInt32(existsCmd.ExecuteScalar()) > 0
                    If Not columnExists Then
                        Dim alterSql As String = "ALTER TABLE tbl_blotter ADD COLUMN case_number INT NOT NULL AUTO_INCREMENT PRIMARY KEY FIRST"
                        Using alterCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(alterSql, conn)
                            alterCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
            caseNumberColumnReady = True
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to prepare the case number column. Please ensure the 'case_number' column exists in tbl_blotter. Details: {0}", ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub

    Private Sub LoadBlotterRecords()
        If IsInDesigner() Then
            dgvBlotterRecords.Rows.Clear()
            Return
        End If
        Try
            EnsureBlotterCaseNumberColumn()
            dgvBlotterRecords.Rows.Clear()

            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT case_number, complainant_name, complainant_address, date_time, location_of_incident, involved_person, narrative_incident FROM tbl_blotter ORDER BY case_number DESC"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim caseNumberValue As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            Dim complainantName As String = If(reader.IsDBNull(1), String.Empty, reader.GetString(1))
                            Dim complainantAddress As String = If(reader.IsDBNull(2), String.Empty, reader.GetString(2))
                            Dim complaintName As String = If(reader.IsDBNull(3), String.Empty, reader.GetString(3))
                            Dim incidentDateDisplay As String = String.Empty
                            If Not reader.IsDBNull(4) Then
                                incidentDateDisplay = reader.GetDateTime(4).ToString("MMM dd, yyyy hh:mm tt")
                            End If
                            Dim location As String = If(reader.IsDBNull(5), String.Empty, reader.GetString(5))
                            Dim involvedPerson As String = If(reader.IsDBNull(6), String.Empty, reader.GetString(6))
                            Dim narrative As String = If(reader.IsDBNull(7), String.Empty, reader.GetString(7))

                            Dim rowIndex = dgvBlotterRecords.Rows.Add(
                                FormatCaseNumberValue(caseNumberValue),
                                complainantName,
                                complainantAddress,
                                complaintName,
                                incidentDateDisplay,
                                location,
                                involvedPerson,
                                narrative,
                                editIcon,
                                deleteIcon
                            )
                            Dim rowReference = dgvBlotterRecords.Rows(rowIndex)
                            rowReference.Cells("CaseNumber").Tag = caseNumberValue
                            If Not reader.IsDBNull(4) Then
                                rowReference.Cells("IncidentDate").Tag = reader.GetDateTime(4)
                            Else
                                rowReference.Cells("IncidentDate").Tag = Nothing
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            If ex.Number = 1146 Then ' ER_NO_SUCH_TABLE
                MessageBox.Show("Blotter table not found. Please create the database table first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(String.Format("Unable to load blotter records. Database error: {0}", ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading blotter records: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadScheduleRecords()
        If IsInDesigner() Then
            dgvSchedule.Rows.Clear()
            Return
        End If
        Try
            dgvSchedule.Rows.Clear()

            Dim caseNumberValue As Integer? = GetSelectedCaseNumber(False)
            If Not caseNumberValue.HasValue Then
                Return
            End If

            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT summon_level, case_date, start_time, end_time FROM tbl_blotter_schedule WHERE case_number = @caseNumber ORDER BY case_date DESC"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@caseNumber", caseNumberValue.Value)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim record As New ScheduleRecord() With {
                                .CaseNumber = caseNumberValue.Value,
                                .SummonLevel = If(reader.IsDBNull(0), String.Empty, reader.GetString(0)),
                                .CaseDate = If(reader.IsDBNull(1), Date.MinValue, reader.GetDateTime(1)),
                                .StartTime = If(reader.IsDBNull(2), TimeSpan.Zero, ReadTimeValue(reader, 2)),
                                .EndTime = If(reader.IsDBNull(3), TimeSpan.Zero, ReadTimeValue(reader, 3))
                            }

                            Dim rowIndex = dgvSchedule.Rows.Add(
                                record.SummonLevel,
                                FormatCaseDate(record.CaseDate),
                                FormatTime(record.StartTime),
                                FormatTime(record.EndTime)
                            )

                            dgvSchedule.Rows(rowIndex).Tag = record
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            If ex.Number = 1146 Then
                MessageBox.Show("Schedule table not found. Please create the database table first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(String.Format("Unable to load schedule records. Database error: {0}", ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to load schedule records: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Click Handlers for Blotter Records
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If IsInDesigner() Then
            Return
        End If

        Try
            Using incidentForm As New reportsform()
                AddHandler incidentForm.IncidentSubmitted, AddressOf HandleIncidentSubmitted
                incidentForm.StartPosition = FormStartPosition.CenterParent
                incidentForm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to open incident report form: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HandleIncidentSubmitted()
        LoadBlotterRecords()
        LoadScheduleRecords()
    End Sub


    ' Button Click Handlers for Schedule
    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        If IsInDesigner() Then
            Return
        End If

        Dim caseNumber As Integer? = GetSelectedCaseNumber()
        If Not caseNumber.HasValue Then
            Return
        End If

        Dim scheduleDetails As ScheduleRecord = PromptScheduleRecord()
        If scheduleDetails Is Nothing Then
            Return
        End If

        scheduleDetails.CaseNumber = caseNumber.Value

        Try
            InsertSchedule(scheduleDetails)
            LoadScheduleRecords()
            MessageBox.Show("Schedule added successfully.", "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ShowScheduleDatabaseError("add the schedule", ex)
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to add schedule: {0}", ex.Message), "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditSchedule_Click(sender As Object, e As EventArgs) Handles btnEditSchedule.Click
        If IsInDesigner() Then
            Return
        End If

        Dim selectedRecord As ScheduleRecord = GetSelectedScheduleRecord()
        If selectedRecord Is Nothing Then
            MessageBox.Show("Please select a schedule to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim updatedRecord As ScheduleRecord = PromptScheduleRecord(selectedRecord)
        If updatedRecord Is Nothing Then
            Return
        End If

        updatedRecord.CaseNumber = selectedRecord.CaseNumber

        Try
            UpdateSchedule(selectedRecord, updatedRecord)
            LoadScheduleRecords()
            MessageBox.Show("Schedule updated successfully.", "Edit Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ShowScheduleDatabaseError("update the schedule", ex)
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to update schedule: {0}", ex.Message), "Edit Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteSchedule_Click(sender As Object, e As EventArgs) Handles btnDeleteSchedule.Click
        If IsInDesigner() Then
            Return
        End If

        Dim selectedRecord As ScheduleRecord = GetSelectedScheduleRecord()
        If selectedRecord Is Nothing Then
            MessageBox.Show("Please select a schedule to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Delete Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            DeleteSchedule(selectedRecord)
            LoadScheduleRecords()
            MessageBox.Show("Schedule deleted successfully.", "Delete Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ShowScheduleDatabaseError("delete the schedule", ex)
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to delete schedule: {0}", ex.Message), "Delete Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateSettlementStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateSettlementStatus.Click
        If IsInDesigner() Then
            Return
        End If

        Dim caseNumber As Integer? = GetSelectedCaseNumber()
        If Not caseNumber.HasValue Then
            Return
        End If

        Dim currentStatus As String = GetCurrentSettlementStatus(caseNumber.Value)

        Using dialog As New SettlementStatusDialog(currentStatus)
            If dialog.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            Try
                UpdateSettlementStatus(caseNumber.Value, dialog.SelectedStatus)
                LoadBlotterRecords()
                MessageBox.Show("Settlement status updated.", "Update Settlement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Global.MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(String.Format("Unable to update settlement status. Please ensure the 'settlement_status' column exists in tbl_blotter.{0}Details: {1}", Environment.NewLine, ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(String.Format("Unable to update settlement status: {0}", ex.Message), "Update Settlement", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Search functionality
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If IsInDesigner() Then
            Return
        End If

        ' TODO: Implement search filtering
        ' For now, just reload all records
        LoadBlotterRecords()
    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        If IsInDesigner() Then
            Return
        End If

        ' Reset search when filter changes
        txtSearch.Clear()
    End Sub

    ' DataGridView event handlers
    Private Sub dgvBlotterRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBlotterRecords.SelectionChanged
        If IsInDesigner() Then
            Return
        End If

        ' Load schedule when a blotter record is selected
        If dgvBlotterRecords.SelectedRows.Count > 0 Then
            LoadScheduleRecords()
        End If
    End Sub

    Private Sub dgvBlotterRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBlotterRecords.CellClick
        If IsInDesigner() Then
            Return
        End If

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim columnName As String = dgvBlotterRecords.Columns(e.ColumnIndex).Name
        Dim row As DataGridViewRow = dgvBlotterRecords.Rows(e.RowIndex)

        Select Case columnName
            Case "colEdit"
                EditBlotterRecord(row)
            Case "colDelete"
                DeleteBlotterRecord(row)
            Case "colPrint"
                PrintBlotterRecord(row)
        End Select
    End Sub

    Private Sub dgvSchedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellContentClick

    End Sub

    Private Sub EditBlotterRecord(row As DataGridViewRow)
        Dim caseNumberValue As Integer? = GetCaseNumberFromRow(row)
        If Not caseNumberValue.HasValue Then
            MessageBox.Show("Unable to determine the case number for the selected record.", "Edit Blotter", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim incidentCell As DataGridViewCell = row.Cells("IncidentDate")
        Dim incidentSource As Object = If(incidentCell IsNot Nothing AndAlso incidentCell.Tag IsNot Nothing, incidentCell.Tag, incidentCell.Value)

        Dim record As New BlotterRecord With {
            .CaseNumber = caseNumberValue.Value,
            .ComplainantName = Convert.ToString(row.Cells("ComplainantName").Value),
            .ComplainantAddress = Convert.ToString(row.Cells("ComplainantAddress").Value),
            .ComplaintName = Convert.ToString(row.Cells("ComplaintName").Value),
            .IncidentDate = ReadIncidentDate(incidentSource),
            .LocationOfIncident = Convert.ToString(row.Cells("LocationOfIncident").Value),
            .InvolvedPerson = Convert.ToString(row.Cells("InvolvedPerson").Value),
            .NarrativeIncident = Convert.ToString(row.Cells("NarrativeIncident").Value)
        }

        Using dialog As New BlotterRecordEditorDialog(record)
            If dialog.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            Try
                UpdateBlotterRecord(dialog.RecordData)
                LoadBlotterRecords()
                MessageBox.Show("Blotter record updated successfully.", "Edit Blotter", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Global.MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(String.Format("Unable to update blotter record. Details: {0}", ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(String.Format("Unable to update blotter record: {0}", ex.Message), "Edit Blotter", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub DeleteBlotterRecord(row As DataGridViewRow)
        Dim caseNumberValue As Integer? = GetCaseNumberFromRow(row)
        If Not caseNumberValue.HasValue Then
            MessageBox.Show("Unable to determine the case number for the selected record.", "Delete Blotter", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim displayCaseNumber As String = FormatCaseNumberValue(caseNumberValue.Value)
        Dim confirm = MessageBox.Show(String.Format("Delete blotter record for Case #{0}? This cannot be undone.", displayCaseNumber), "Delete Blotter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "DELETE FROM tbl_blotter WHERE case_number = @caseNumber LIMIT 1"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@caseNumber", caseNumberValue.Value)
                    Dim affected = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("No blotter record was deleted. It may have been removed already.", "Delete Blotter", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                End Using
            End Using

            LoadBlotterRecords()
            MessageBox.Show("Blotter record deleted successfully.", "Delete Blotter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(String.Format("Unable to delete blotter record. Details: {0}", ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(String.Format("Unable to delete blotter record: {0}", ex.Message), "Delete Blotter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintBlotterRecord(row As DataGridViewRow)
        Dim caseNumberValue As Integer? = GetCaseNumberFromRow(row)
        Dim displayCaseNumber As String = If(caseNumberValue.HasValue, FormatCaseNumberValue(caseNumberValue.Value), "N/A")
        MessageBox.Show(String.Format("Print functionality for Case #{0} will be implemented here.", displayCaseNumber), "Print Blotter", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ReadIncidentDate(value As Object) As System.Nullable(Of Date)
        If value Is Nothing OrElse Convert.IsDBNull(value) Then
            Return Nothing
        End If

        If TypeOf value Is Date Then
            Return CType(value, Date)
        End If

        Dim parsed As Date
        If Date.TryParse(Convert.ToString(value), parsed) Then
            Return parsed
        End If

        Return Nothing
    End Function

    Private Function GetSelectedCaseNumber(Optional showWarning As Boolean = True) As Integer?
        If dgvBlotterRecords.SelectedRows.Count = 0 Then
            If showWarning Then
                MessageBox.Show("Please select a blotter record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Return Nothing
        End If

        Dim selectedRow As DataGridViewRow = dgvBlotterRecords.SelectedRows(0)
        Dim caseNumberValue As Integer? = GetCaseNumberFromRow(selectedRow)

        If Not caseNumberValue.HasValue AndAlso showWarning Then
            MessageBox.Show("The selected blotter record does not contain a case number.", "Invalid Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return caseNumberValue
    End Function

    Private Function GetSelectedScheduleRecord() As ScheduleRecord
        If dgvSchedule.SelectedRows.Count = 0 Then
            Return Nothing
        End If

        Dim record As ScheduleRecord = TryCast(dgvSchedule.SelectedRows(0).Tag, ScheduleRecord)
        Return If(record Is Nothing, Nothing, record.Clone())
    End Function

    Private Function PromptScheduleRecord(Optional existing As ScheduleRecord = Nothing) As ScheduleRecord
        Using dialog As New ScheduleEditorDialog(existing)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                Return dialog.ScheduleData
            End If
        End Using

        Return Nothing
    End Function

    Private Sub InsertSchedule(schedule As ScheduleRecord)
        Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO tbl_blotter_schedule (case_number, summon_level, case_date, start_time, end_time) VALUES (@caseNumber, @summonLevel, @caseDate, @startTime, @endTime)"
            Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@caseNumber", schedule.CaseNumber)
                cmd.Parameters.AddWithValue("@summonLevel", schedule.SummonLevel)
                cmd.Parameters.AddWithValue("@caseDate", schedule.CaseDate)
                cmd.Parameters.AddWithValue("@startTime", schedule.StartTime)
                cmd.Parameters.AddWithValue("@endTime", schedule.EndTime)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateSchedule(originalRecord As ScheduleRecord, updatedRecord As ScheduleRecord)
        Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
            conn.Open()
            Dim sql As String =
                "UPDATE tbl_blotter_schedule " &
                "SET summon_level = @newSummonLevel, case_date = @newCaseDate, start_time = @newStartTime, end_time = @newEndTime " &
                "WHERE case_number = @caseNumber AND summon_level = @oldSummonLevel AND case_date = @oldCaseDate AND start_time = @oldStartTime AND end_time = @oldEndTime LIMIT 1"

            Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@newSummonLevel", updatedRecord.SummonLevel)
                cmd.Parameters.AddWithValue("@newCaseDate", updatedRecord.CaseDate)
                cmd.Parameters.AddWithValue("@newStartTime", updatedRecord.StartTime)
                cmd.Parameters.AddWithValue("@newEndTime", updatedRecord.EndTime)
                cmd.Parameters.AddWithValue("@caseNumber", originalRecord.CaseNumber)
                cmd.Parameters.AddWithValue("@oldSummonLevel", originalRecord.SummonLevel)
                cmd.Parameters.AddWithValue("@oldCaseDate", originalRecord.CaseDate)
                cmd.Parameters.AddWithValue("@oldStartTime", originalRecord.StartTime)
                cmd.Parameters.AddWithValue("@oldEndTime", originalRecord.EndTime)

                Dim affected = cmd.ExecuteNonQuery()
                If affected = 0 Then
                    Throw New InvalidOperationException("The selected schedule could not be updated. It may have been removed by another user.")
                End If
            End Using
        End Using
    End Sub

    Private Sub DeleteSchedule(record As ScheduleRecord)
        Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
            conn.Open()
            Dim sql As String =
                "DELETE FROM tbl_blotter_schedule WHERE case_number = @caseNumber AND summon_level = @summonLevel AND case_date = @caseDate AND start_time = @startTime AND end_time = @endTime LIMIT 1"

            Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@caseNumber", record.CaseNumber)
                cmd.Parameters.AddWithValue("@summonLevel", record.SummonLevel)
                cmd.Parameters.AddWithValue("@caseDate", record.CaseDate)
                cmd.Parameters.AddWithValue("@startTime", record.StartTime)
                cmd.Parameters.AddWithValue("@endTime", record.EndTime)

                Dim affected = cmd.ExecuteNonQuery()
                If affected = 0 Then
                    Throw New InvalidOperationException("The selected schedule could not be deleted. It may have been removed already.")
                End If
            End Using
        End Using
    End Sub

    Private Function ReadTimeValue(reader As Global.MySql.Data.MySqlClient.MySqlDataReader, ordinal As Integer) As TimeSpan
        Dim fieldType = reader.GetFieldType(ordinal)
        If fieldType Is GetType(TimeSpan) Then
            Return reader.GetTimeSpan(ordinal)
        End If

        Return reader.GetDateTime(ordinal).TimeOfDay
    End Function

    Private Function FormatTime(value As TimeSpan) As String
        If value = TimeSpan.Zero Then
            Return String.Empty
        End If

        Return value.ToString("hh\:mm")
    End Function

    Private Function FormatCaseNumberValue(value As Integer) As String
        If value <= 0 Then
            Return String.Empty
        End If

        Return value.ToString("0000")
    End Function

    Private Function GetCaseNumberFromRow(row As DataGridViewRow) As Integer?
        If row Is Nothing Then
            Return Nothing
        End If

        Dim cell As DataGridViewCell = row.Cells("CaseNumber")
        If cell IsNot Nothing AndAlso TypeOf cell.Tag Is Integer Then
            Return CType(cell.Tag, Integer)
        End If

        Dim numericValue As Integer
        If cell IsNot Nothing AndAlso Integer.TryParse(Convert.ToString(cell.Value).Trim(), numericValue) Then
            Return numericValue
        End If

        Return Nothing
    End Function

    Private Function FormatCaseDate(value As Date) As String
        If value = Date.MinValue Then
            Return String.Empty
        End If

        Return value.ToString("MMM dd, yyyy hh:mm tt")
    End Function

    Private Function GetCurrentSettlementStatus(caseNumber As Integer) As String
        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT settlement_status FROM tbl_blotter WHERE case_number = @caseNumber LIMIT 1"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@caseNumber", caseNumber)
                    Dim result = cmd.ExecuteScalar()
                    Return If(result Is Nothing OrElse result Is DBNull.Value, String.Empty, result.ToString())
                End Using
            End Using
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            ' Column might not exist yet, fall back to empty
            Return String.Empty
        End Try
    End Function

    Private Sub UpdateSettlementStatus(caseNumber As Integer, newStatus As String)
        Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
            conn.Open()
            Dim sql As String = "UPDATE tbl_blotter SET settlement_status = @status WHERE case_number = @caseNumber LIMIT 1"
            Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@caseNumber", caseNumber)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateBlotterRecord(record As BlotterRecord)
        Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
            conn.Open()
            Dim sql As String = "UPDATE tbl_blotter SET complainant_name = @complainant, complainant_address = @address, complaint_name = @complaint, date_time = @incidentDate, location_of_incident = @location, involved_person = @involved, narrative_incident = @narrative WHERE case_number = @case LIMIT 1"
            Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@complainant", record.ComplainantName)
                cmd.Parameters.AddWithValue("@address", record.ComplainantAddress)
                cmd.Parameters.AddWithValue("@complaint", record.ComplaintName)
                cmd.Parameters.AddWithValue("@incidentDate", If(record.IncidentDate.HasValue, CType(record.IncidentDate.Value, Object), DBNull.Value))
                cmd.Parameters.AddWithValue("@location", record.LocationOfIncident)
                cmd.Parameters.AddWithValue("@involved", record.InvolvedPerson)
                cmd.Parameters.AddWithValue("@narrative", record.NarrativeIncident)
                cmd.Parameters.AddWithValue("@case", record.CaseNumber)
                Dim affected = cmd.ExecuteNonQuery()
                If affected = 0 Then
                    Throw New InvalidOperationException("The selected blotter record could not be updated. It may have been removed by another user.")
                End If
            End Using
        End Using
    End Sub

    Private Sub ShowScheduleDatabaseError(action As String, ex As Global.MySql.Data.MySqlClient.MySqlException)
        MessageBox.Show(String.Format("Unable to {0}. Details: {1}", action, ex.Message), "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LoadActionIcons()
        If editIcon IsNot Nothing Then Return

        editIcon = CreatePencilIcon()
        deleteIcon = CreateDeleteIcon()
        printIcon = CreatePrintIcon()
    End Sub

    Private Function CreateTextColumn(name As String, header As String) As DataGridViewTextBoxColumn
        Dim column As New DataGridViewTextBoxColumn()
        column.Name = name
        column.HeaderText = header
        column.SortMode = DataGridViewColumnSortMode.Programmatic
        Return column
    End Function

    Private Function CreateActionColumn(name As String, icon As Image, tooltip As String) As DataGridViewImageColumn
        Dim column As New DataGridViewImageColumn()
        column.Name = name
        column.HeaderText = ""
        column.Image = icon
        column.ImageLayout = DataGridViewImageCellLayout.Zoom
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        column.ToolTipText = tooltip
        column.SortMode = DataGridViewColumnSortMode.NotSortable
        column.ReadOnly = True
        Return column
    End Function

    Private Function CreatePencilIcon() As Image
        Dim size As Integer = 28
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            Using bodyBrush As New SolidBrush(Color.FromArgb(30, 136, 229))
                Using pen As New Pen(bodyBrush, 6)
                    g.DrawLine(pen, 6, size - 8, size - 4, 6)
                End Using
                Using tipBrush As New SolidBrush(Color.FromArgb(255, 213, 79))
                    Dim tipPoints As Point() = {
                        New Point(size - 5, 5),
                        New Point(size - 1, 1),
                        New Point(size - 1, 9)
                    }
                    g.FillPolygon(tipBrush, tipPoints)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Function CreateDeleteIcon() As Image
        Dim size As Integer = 28
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            Using brush As New SolidBrush(Color.FromArgb(227, 53, 55))
                g.FillEllipse(brush, 2, 2, size - 4, size - 4)
            End Using

            Using pen As New Pen(Color.White, 3)
                g.DrawLine(pen, 8, 8, size - 8, size - 8)
                g.DrawLine(pen, size - 8, 8, 8, size - 8)
            End Using
        End Using
        Return bmp
    End Function

    Private Function CreatePrintIcon() As Image
        Dim size As Integer = 28
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            Using bodyBrush As New SolidBrush(Color.FromArgb(67, 195, 95))
                g.FillRectangle(bodyBrush, 4, 6, size - 8, size - 10)
                g.FillRectangle(bodyBrush, 7, size - 12, size - 14, 8)
            End Using

            Using paperBrush As New SolidBrush(Color.White)
                g.FillRectangle(paperBrush, 8, 10, size - 16, size - 18)
            End Using
        End Using
        Return bmp
    End Function

    Private Sub pnlBlotterButtons_Paint(sender As Object, e As PaintEventArgs) Handles pnlBlotterButtons.Paint

    End Sub

    Private Sub dgvBlotterRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBlotterRecords.CellContentClick

    End Sub

    Private Sub pnlLeftTable_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeftTable.Paint

    End Sub

    Private Sub pnlSearch_Paint(sender As Object, e As PaintEventArgs) Handles pnlSearch.Paint

    End Sub
End Class

Friend Class ScheduleRecord
    Public Property CaseNumber As Integer
    Public Property SummonLevel As String
    Public Property CaseDate As Date
    Public Property StartTime As TimeSpan
    Public Property EndTime As TimeSpan

    Public Function Clone() As ScheduleRecord
        Return CType(Me.MemberwiseClone(), ScheduleRecord)
    End Function
End Class

Friend Class BlotterRecord
    Public Property CaseNumber As Integer
    Public Property ComplainantName As String
    Public Property ComplainantAddress As String
    Public Property ComplaintName As String
    Public Property IncidentDate As System.Nullable(Of Date)
    Public Property LocationOfIncident As String
    Public Property InvolvedPerson As String
    Public Property NarrativeIncident As String
End Class

Friend Class ScheduleEditorDialog
    Inherits Form

    Private ReadOnly txtSummonLevel As TextBox
    Private ReadOnly dtpCaseDate As DateTimePicker
    Private ReadOnly dtpStartTime As DateTimePicker
    Private ReadOnly dtpEndTime As DateTimePicker
    Private ReadOnly btnSave As Button
    Private ReadOnly btnCancel As Button

    Private _scheduleData As ScheduleRecord

    Public ReadOnly Property ScheduleData As ScheduleRecord
        Get
            Return _scheduleData
        End Get
    End Property

    Public Sub New(Optional existing As ScheduleRecord = Nothing)
        Text = If(existing Is Nothing, "Add Schedule", "Edit Schedule")
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterParent
        ClientSize = New Size(430, 300)
        BackColor = Color.White

        Dim layout As New TableLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .RowCount = 5,
            .Padding = New Padding(20),
            .AutoSize = False
        }

        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.0F))
        For i As Integer = 0 To 3
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0F))
        Next
        layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))

        txtSummonLevel = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        }

        dtpCaseDate = New DateTimePicker() With {
            .Dock = DockStyle.Fill,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy hh:mm tt",
            .ShowUpDown = True,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        }

        If existing IsNot Nothing AndAlso existing.CaseDate <> Date.MinValue Then
            dtpCaseDate.Value = existing.CaseDate
        Else
            dtpCaseDate.Value = Date.Now
        End If

        dtpStartTime = New DateTimePicker() With {
            .Dock = DockStyle.Fill,
            .Format = DateTimePickerFormat.Time,
            .ShowUpDown = True,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        }

        dtpEndTime = New DateTimePicker() With {
            .Dock = DockStyle.Fill,
            .Format = DateTimePickerFormat.Time,
            .ShowUpDown = True,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        }

        btnSave = New RoundedButton() With {
            .Text = "Save",
            .Width = 90,
            .Height = 32,
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 12
        }
        btnSave.FlatAppearance.BorderSize = 0

        btnCancel = New RoundedButton() With {
            .Text = "Cancel",
            .Width = 90,
            .Height = 32,
            .BackColor = Color.Gainsboro,
            .ForeColor = Color.Black,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 12,
            .DialogResult = DialogResult.Cancel
        }
        btnCancel.FlatAppearance.BorderSize = 0

        Dim buttonsPanel As New FlowLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.RightToLeft,
            .Padding = New Padding(0, 10, 0, 0)
        }
        buttonsPanel.Controls.Add(btnSave)
        buttonsPanel.Controls.Add(btnCancel)

        layout.Controls.Add(CreateFieldLabel("Summon Level"), 0, 0)
        layout.Controls.Add(txtSummonLevel, 1, 0)
        layout.Controls.Add(CreateFieldLabel("Case Date"), 0, 1)
        layout.Controls.Add(dtpCaseDate, 1, 1)
        layout.Controls.Add(CreateFieldLabel("Start Time"), 0, 2)
        layout.Controls.Add(dtpStartTime, 1, 2)
        layout.Controls.Add(CreateFieldLabel("End Time"), 0, 3)
        layout.Controls.Add(dtpEndTime, 1, 3)
        layout.Controls.Add(buttonsPanel, 0, 4)
        layout.SetColumnSpan(buttonsPanel, 2)

        Controls.Add(layout)

        Dim today As Date = Date.Today
        txtSummonLevel.Text = If(existing Is Nothing, String.Empty, existing.SummonLevel)
        dtpCaseDate.Value = If(existing IsNot Nothing AndAlso existing.CaseDate > Date.MinValue, existing.CaseDate, today)
        dtpStartTime.Value = today.Add(If(existing IsNot Nothing AndAlso existing.StartTime > TimeSpan.Zero, existing.StartTime, TimeSpan.FromHours(8)))
        dtpEndTime.Value = today.Add(If(existing IsNot Nothing AndAlso existing.EndTime > TimeSpan.Zero, existing.EndTime, TimeSpan.FromHours(9)))

        AddHandler btnSave.Click, AddressOf HandleSaveClick

        AcceptButton = btnSave
        CancelButton = btnCancel
    End Sub

    Private Function CreateFieldLabel(text As String) As Label
        Return New Label() With {
            .Text = text,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Regular)
        }
    End Function

    Private Sub HandleSaveClick(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtSummonLevel.Text) Then
            MessageBox.Show("Summon level is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSummonLevel.Focus()
            Return
        End If

        If dtpEndTime.Value.TimeOfDay <= dtpStartTime.Value.TimeOfDay Then
            MessageBox.Show("End time must be later than start time.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndTime.Focus()
            Return
        End If

        _scheduleData = New ScheduleRecord() With {
            .SummonLevel = txtSummonLevel.Text.Trim(),
            .CaseDate = dtpCaseDate.Value,
            .StartTime = dtpStartTime.Value.TimeOfDay,
            .EndTime = dtpEndTime.Value.TimeOfDay
        }

        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class

Friend Class BlotterRecordEditorDialog
    Inherits Form

    Private ReadOnly txtCaseNumber As TextBox
    Private ReadOnly txtComplainant As TextBox
    Private ReadOnly txtComplainantAddress As TextBox
    Private ReadOnly txtComplaint As TextBox
    Private ReadOnly dtpIncidentDate As DateTimePicker
    Private ReadOnly txtLocation As TextBox
    Private ReadOnly txtInvolvedPerson As TextBox
    Private ReadOnly txtNarrative As TextBox
    Private ReadOnly btnSave As RoundedButton
    Private ReadOnly btnCancel As RoundedButton
    Private ReadOnly currentCaseNumber As Integer
    Private _recordData As BlotterRecord

    Public ReadOnly Property RecordData As BlotterRecord
        Get
            Return _recordData
        End Get
    End Property

    Public Sub New(existing As BlotterRecord)
        currentCaseNumber = existing.CaseNumber
        Text = String.Format("Edit Case #{0}", currentCaseNumber.ToString("0000"))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterParent
        ClientSize = New Size(560, 520)
        BackColor = Color.White

        Dim layout As New TableLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .RowCount = 9,
            .Padding = New Padding(20),
            .AutoSize = False
        }

        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
        For i As Integer = 0 To 6
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        Next
        layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 120.0F))
        layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 70.0F))

        txtCaseNumber = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .ReadOnly = True,
            .Text = currentCaseNumber.ToString("0000")
        }

        txtComplainant = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Text = existing.ComplainantName
        }

        txtComplainantAddress = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Text = existing.ComplainantAddress
        }

        txtComplaint = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Text = existing.ComplaintName
        }

        dtpIncidentDate = New DateTimePicker() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy hh:mm tt",
            .ShowCheckBox = True
        }
        If existing.IncidentDate.HasValue Then
            dtpIncidentDate.Value = existing.IncidentDate.Value
            dtpIncidentDate.Checked = True
        Else
            dtpIncidentDate.Checked = False
        End If

        txtLocation = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Text = existing.LocationOfIncident
        }

        txtInvolvedPerson = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Text = existing.InvolvedPerson
        }

        txtNarrative = New TextBox() With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10.0F),
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Text = existing.NarrativeIncident
        }

        btnSave = New RoundedButton() With {
            .Text = "Save",
            .Width = 100,
            .Height = 36,
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 15
        }
        btnSave.FlatAppearance.BorderSize = 0

        btnCancel = New RoundedButton() With {
            .Text = "Cancel",
            .Width = 100,
            .Height = 36,
            .BackColor = Color.Gainsboro,
            .ForeColor = Color.Black,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 15,
            .DialogResult = DialogResult.Cancel
        }
        btnCancel.FlatAppearance.BorderSize = 0

        Dim buttonsPanel As New FlowLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.RightToLeft,
            .Padding = New Padding(0, 10, 0, 0)
        }
        buttonsPanel.Controls.Add(btnSave)
        buttonsPanel.Controls.Add(btnCancel)

        layout.Controls.Add(CreateFieldLabel("Case Number"), 0, 0)
        layout.Controls.Add(txtCaseNumber, 1, 0)
        layout.Controls.Add(CreateFieldLabel("Complainant Name"), 0, 1)
        layout.Controls.Add(txtComplainant, 1, 1)
        layout.Controls.Add(CreateFieldLabel("Complainant Address"), 0, 2)
        layout.Controls.Add(txtComplainantAddress, 1, 2)
        layout.Controls.Add(CreateFieldLabel("Complaint Details"), 0, 3)
        layout.Controls.Add(txtComplaint, 1, 3)
        layout.Controls.Add(CreateFieldLabel("Incident Date/Time"), 0, 4)
        layout.Controls.Add(dtpIncidentDate, 1, 4)
        layout.Controls.Add(CreateFieldLabel("Location of Incident"), 0, 5)
        layout.Controls.Add(txtLocation, 1, 5)
        layout.Controls.Add(CreateFieldLabel("Involved Person(s)"), 0, 6)
        layout.Controls.Add(txtInvolvedPerson, 1, 6)
        layout.Controls.Add(CreateFieldLabel("Narrative"), 0, 7)
        layout.Controls.Add(txtNarrative, 1, 7)
        layout.Controls.Add(buttonsPanel, 0, 8)
        layout.SetColumnSpan(buttonsPanel, 2)

        Controls.Add(layout)

        AddHandler btnSave.Click, AddressOf HandleSaveClick

        AcceptButton = btnSave
        CancelButton = btnCancel
    End Sub

    Private Function CreateFieldLabel(text As String) As Label
        Return New Label() With {
            .Text = text,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Regular)
        }
    End Function

    Private Sub HandleSaveClick(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtComplainant.Text) Then
            MessageBox.Show("Complainant name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtComplainant.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtComplaint.Text) Then
            MessageBox.Show("Complaint details are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtComplaint.Focus()
            Return
        End If

        Dim incidentDateValue As System.Nullable(Of Date) = Nothing
        If dtpIncidentDate.Checked Then
            incidentDateValue = dtpIncidentDate.Value
        End If

        _recordData = New BlotterRecord() With {
            .CaseNumber = currentCaseNumber,
            .ComplainantName = txtComplainant.Text.Trim(),
            .ComplainantAddress = txtComplainantAddress.Text.Trim(),
            .ComplaintName = txtComplaint.Text.Trim(),
            .IncidentDate = incidentDateValue,
            .LocationOfIncident = txtLocation.Text.Trim(),
            .InvolvedPerson = txtInvolvedPerson.Text.Trim(),
            .NarrativeIncident = txtNarrative.Text.Trim()
        }

        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class

Friend Class SettlementStatusDialog
    Inherits Form

    Private ReadOnly cmbStatus As ComboBox
    Private ReadOnly btnSave As Button
    Private ReadOnly btnCancel As Button

    Public ReadOnly Property SelectedStatus As String
        Get
            Return cmbStatus.Text.Trim()
        End Get
    End Property

    Public Sub New(currentStatus As String)
        Text = "Update Settlement Status"
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterParent
        ClientSize = New Size(360, 180)
        BackColor = Color.White

        Dim lblPrompt As New Label() With {
            .Text = "Select the new settlement status:",
            .Dock = DockStyle.Top,
            .Height = 40,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Regular),
            .Padding = New Padding(20, 10, 20, 5)
        }

        cmbStatus = New ComboBox() With {
            .Dock = DockStyle.Top,
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular),
            .DropDownStyle = ComboBoxStyle.DropDownList,
            .Margin = New Padding(20, 0, 20, 0)
        }
        cmbStatus.Items.AddRange(New Object() {"Pending", "For Mediation", "Under Hearing", "Settled", "Dismissed", "For Follow-up"})
        Dim selectedIndex As Integer = -1
        If Not String.IsNullOrWhiteSpace(currentStatus) Then
            For i As Integer = 0 To cmbStatus.Items.Count - 1
                If String.Equals(cmbStatus.Items(i).ToString(), currentStatus, StringComparison.OrdinalIgnoreCase) Then
                    selectedIndex = i
                    Exit For
                End If
            Next
        End If
        cmbStatus.SelectedIndex = If(selectedIndex >= 0, selectedIndex, 0)

        btnSave = New RoundedButton() With {
            .Text = "Save",
            .Width = 90,
            .Height = 32,
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 12
        }
        btnSave.FlatAppearance.BorderSize = 0

        btnCancel = New RoundedButton() With {
            .Text = "Cancel",
            .Width = 90,
            .Height = 32,
            .BackColor = Color.Gainsboro,
            .ForeColor = Color.Black,
            .FlatStyle = FlatStyle.Flat,
            .BorderRadius = 12,
            .DialogResult = DialogResult.Cancel
        }
        btnCancel.FlatAppearance.BorderSize = 0

        Dim buttonsPanel As New FlowLayoutPanel() With {
            .Dock = DockStyle.Bottom,
            .Height = 60,
            .FlowDirection = FlowDirection.RightToLeft,
            .Padding = New Padding(0, 10, 20, 10)
        }
        buttonsPanel.Controls.Add(btnSave)
        buttonsPanel.Controls.Add(btnCancel)

        Controls.Add(buttonsPanel)
        Controls.Add(cmbStatus)
        Controls.Add(lblPrompt)

        AddHandler btnSave.Click, AddressOf HandleSave

        AcceptButton = btnSave
        CancelButton = btnCancel
    End Sub

    Private Sub HandleSave(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(cmbStatus.Text) Then
            MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Return
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class

