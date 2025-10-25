Imports MySql.Data.MySqlClient

Public Class dashboard
    Private currentChildForm As Form
    Private isChartsInitialized As Boolean = False

    Private Sub OpenChildForm(child As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
            currentChildForm = Nothing
        End If

        currentChildForm = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        contentHost.Controls.Clear()
        contentHost.Controls.Add(child)
        child.Show()
        child.BringToFront()
    End Sub
    Private Sub topBar_Paint(sender As Object, e As PaintEventArgs) Handles topBar.Paint

    End Sub

    Private Sub navResidents_Click(sender As Object, e As EventArgs) Handles navResidents.Click
        OpenChildForm(New residentinfo())
    End Sub

    Private Sub navReports_Click(sender As Object, e As EventArgs) Handles navReports.Click
        OpenChildForm(New reportsform())
    End Sub

    Private Sub navDashboard_Click(sender As Object, e As EventArgs) Handles navDashboard.Click
        ' Close any child and bring back the dashboard layout
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
            currentChildForm = Nothing
        End If
        RestoreDashboardControls()
        InitializeBottomPanels()
    End Sub

    Private Sub navDocs_Click(sender As Object, e As EventArgs) Handles navDocs.Click
        OpenChildForm(New certissuance())
    End Sub

    Private Sub RestoreDashboardControls()
        ' Ensure the dashboard panels are added back in proper order
        contentHost.Controls.Clear()
        contentHost.Controls.Add(chartsTable)
        contentHost.Controls.Add(statsTable)
        chartsTable.Dock = DockStyle.Fill
        statsTable.Dock = DockStyle.Top
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeBottomPanels()
    End Sub

    Private Sub InitializeBottomPanels()
        If isChartsInitialized Then Return

        ' Configure residents grid columns
        dgvDashboardResidents.AutoGenerateColumns = True
        dgvDashboardResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDashboardResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Configure purok chart
        chartPurok.Series.Clear()
        chartPurok.ChartAreas.Clear()
        Dim area = New DataVisualization.Charting.ChartArea("MainArea")
        area.AxisX.Title = "Purok"
        area.AxisY.Title = "Residents"
        chartPurok.ChartAreas.Add(area)
        Dim series = New DataVisualization.Charting.Series("Residents")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Column
        series.IsValueShownAsLabel = True
        chartPurok.Series.Add(series)

        isChartsInitialized = True
    End Sub

    Public Sub BindResidentsToDashboardGrid(source As Object)
        If Not isChartsInitialized Then InitializeBottomPanels()
        dgvDashboardResidents.DataSource = source
    End Sub

    Public Sub UpdatePurokChart(purokToCount As IDictionary(Of String, Integer))
        If Not isChartsInitialized Then InitializeBottomPanels()
        Dim series = chartPurok.Series("Residents")
        series.Points.Clear()
        For Each kvp In purokToCount
            series.Points.AddXY(kvp.Key, kvp.Value)
        Next
    End Sub

    Private Sub statsTable_Paint(sender As Object, e As PaintEventArgs) Handles statsTable.Paint

    End Sub

    Private Sub dgvDashboardResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDashboardResidents.CellContentClick

    End Sub

    Private Sub navCedula_Click(sender As Object, e As EventArgs) Handles navCedula.Click
        OpenChildForm(New cedulatracker())
    End Sub

    Private Sub leftNav_Paint(sender As Object, e As PaintEventArgs) Handles leftNav.Paint

    End Sub

    Private Sub navLogout_Click(sender As Object, e As EventArgs) Handles navLogout.Click
        ' Show confirmation dialog before logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close all child forms
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
                currentChildForm.Dispose()
                currentChildForm = Nothing
            End If

            ' Close the application
            Application.Exit()
        End If
    End Sub

    Private Sub navBackup_Click(sender As Object, e As EventArgs) Handles navBackup.Click
        Try
            ' Show save file dialog for backup
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"
            saveFileDialog.FileName = $"BIMS_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql"
            saveFileDialog.Title = "Save Database Backup"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Show progress dialog
                Dim progressForm As New Form()
                progressForm.Text = "Database Backup"
                progressForm.Size = New Size(400, 150)
                progressForm.StartPosition = FormStartPosition.CenterParent
                progressForm.FormBorderStyle = FormBorderStyle.FixedDialog
                progressForm.MaximizeBox = False
                progressForm.MinimizeBox = False

                Dim progressLabel As New Label()
                progressLabel.Text = "Creating database backup..."
                progressLabel.Location = New Point(20, 30)
                progressLabel.Size = New Size(350, 20)
                progressForm.Controls.Add(progressLabel)

                Dim progressBar As New ProgressBar()
                progressBar.Style = ProgressBarStyle.Marquee
                progressBar.Location = New Point(20, 60)
                progressBar.Size = New Size(350, 20)
                progressForm.Controls.Add(progressBar)

                progressForm.Show()
                Application.DoEvents()

                ' Create database backup
                CreateDatabaseBackup(saveFileDialog.FileName)

                progressForm.Close()
                MessageBox.Show("Database backup completed successfully!", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error creating backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateDatabaseBackup(filePath As String)
        Try
            Using connection As MySqlConnection = Database.CreateConnection()
                connection.Open()

                ' Get all table names
                Dim tables As New List(Of String)()
                Dim cmd As New MySqlCommand("SHOW TABLES", connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Try
                    While reader.Read()
                        tables.Add(reader(0).ToString())
                    End While
                Finally
                    reader.Close()
                    cmd.Dispose()
                End Try

                ' Create SQL file content
                Dim sqlContent As New System.Text.StringBuilder()
                sqlContent.AppendLine("-- BIMS Database Backup")
                sqlContent.AppendLine($"-- Created: {DateTime.Now}")
                sqlContent.AppendLine("-- Database: capstone")
                sqlContent.AppendLine()
                sqlContent.AppendLine("SET FOREIGN_KEY_CHECKS = 0;")
                sqlContent.AppendLine()

                ' Export each table
                For Each tableName In tables
                    sqlContent.AppendLine($"-- Table: {tableName}")
                    sqlContent.AppendLine($"DROP TABLE IF EXISTS `{tableName}`;")
                    sqlContent.AppendLine()

                    ' Get table structure
                    Dim cmd2 As New MySqlCommand($"SHOW CREATE TABLE `{tableName}`", connection)
                    Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()
                    Try
                        If reader2.Read() Then
                            sqlContent.AppendLine(reader2(1).ToString() & ";")
                            sqlContent.AppendLine()
                        End If
                    Finally
                        reader2.Close()
                        cmd2.Dispose()
                    End Try

                    ' Get table data
                    Dim cmd3 As New MySqlCommand($"SELECT * FROM `{tableName}`", connection)
                    Dim reader3 As MySqlDataReader = cmd3.ExecuteReader()
                    Try
                        If reader3.HasRows Then
                            sqlContent.AppendLine($"-- Data for table: {tableName}")

                            While reader3.Read()
                                Dim values As New List(Of String)()
                                For i As Integer = 0 To reader3.FieldCount - 1
                                    If reader3.IsDBNull(i) Then
                                        values.Add("NULL")
                                    Else
                                        Dim value As String = reader3(i).ToString()
                                        ' Escape single quotes and backslashes
                                        value = value.Replace("\", "\\").Replace("'", "\'")
                                        values.Add($"'{value}'")
                                    End If
                                Next

                                sqlContent.AppendLine($"INSERT INTO `{tableName}` VALUES ({String.Join(", ", values)});")
                            End While
                            sqlContent.AppendLine()
                        End If
                    Finally
                        reader3.Close()
                        cmd3.Dispose()
                    End Try
                Next

                sqlContent.AppendLine("SET FOREIGN_KEY_CHECKS = 1;")

                ' Write to file
                System.IO.File.WriteAllText(filePath, sqlContent.ToString(), System.Text.Encoding.UTF8)
            End Using
        Catch ex As Exception
            Throw New Exception($"Failed to create database backup: {ex.Message}")
        End Try
    End Sub

    Private Sub RestoreDatabaseFromBackup(filePath As String)
        Try
            ' Show confirmation dialog before restore
            Dim result As DialogResult = MessageBox.Show("This will replace all current data in the database. Are you sure you want to continue?", "Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Show progress dialog
                Dim progressForm As New Form()
                progressForm.Text = "Database Restore"
                progressForm.Size = New Size(400, 150)
                progressForm.StartPosition = FormStartPosition.CenterParent
                progressForm.FormBorderStyle = FormBorderStyle.FixedDialog
                progressForm.MaximizeBox = False
                progressForm.MinimizeBox = False

                Dim progressLabel As New Label()
                progressLabel.Text = "Restoring database from backup..."
                progressLabel.Location = New Point(20, 30)
                progressLabel.Size = New Size(350, 20)
                progressForm.Controls.Add(progressLabel)

                Dim progressBar As New ProgressBar()
                progressBar.Style = ProgressBarStyle.Marquee
                progressBar.Location = New Point(20, 60)
                progressBar.Size = New Size(350, 20)
                progressForm.Controls.Add(progressBar)

                progressForm.Show()
                Application.DoEvents()

                ' Read SQL file content
                Dim sqlContent As String = System.IO.File.ReadAllText(filePath, System.Text.Encoding.UTF8)

                ' Split SQL content into individual statements
                Dim statements As String() = sqlContent.Split(New String() {";" & vbCrLf, ";" & vbLf, ";"}, StringSplitOptions.RemoveEmptyEntries)

                Using connection As MySqlConnection = Database.CreateConnection()
                    connection.Open()

                    ' Execute each SQL statement
                    For Each statement In statements
                        statement = statement.Trim()
                        If Not String.IsNullOrEmpty(statement) AndAlso Not statement.StartsWith("--") Then
                            Dim cmd As New MySqlCommand(statement, connection)
                            Try
                                cmd.ExecuteNonQuery()
                            Finally
                                cmd.Dispose()
                            End Try
                        End If
                    Next
                End Using

                progressForm.Close()
                MessageBox.Show("Database restore completed successfully!", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error restoring database: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to handle restore button click (you can add this to a restore button if needed)
    Private Sub RestoreDatabase()
        Try
            ' Show open file dialog for restore
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"
            openFileDialog.Title = "Select Database Backup to Restore"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                RestoreDatabaseFromBackup(openFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error selecting backup file: {ex.Message}", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class