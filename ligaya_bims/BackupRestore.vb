Public Class BackupRestore

    Public Sub New()
        InitializeComponent()
        ConfigureGrid()
    End Sub

    Public Sub SetAsChildForm()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub BackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRestoreRecords()
    End Sub

    Private Sub ConfigureGrid()
        If dgvProfiles Is Nothing Then Return
        dgvProfiles.AutoGenerateColumns = False
        dgvProfiles.MultiSelect = False
        dgvProfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProfiles.Columns("colSelect").ReadOnly = False
        dgvProfiles.Columns("colFullName").ReadOnly = True
    End Sub

    Private Sub LoadRestoreRecords()
        dgvProfiles.Rows.Clear()

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = "SELECT lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, religion, voterstatus, weight, height, idpic, address FROM tbl_restore ORDER BY lastname, firstname"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim metadata As New RestoreMetadata()
                            metadata.LastName = If(reader.IsDBNull(0), String.Empty, reader.GetString(0))
                            metadata.FirstName = If(reader.IsDBNull(1), String.Empty, reader.GetString(1))
                            metadata.MiddleName = If(reader.IsDBNull(2), String.Empty, reader.GetString(2))
                            metadata.Gender = If(reader.IsDBNull(3), String.Empty, reader.GetString(3))
                            metadata.BirthDate = If(reader.IsDBNull(4), CType(Nothing, DateTime?), reader.GetDateTime(4))
                            metadata.Age = If(reader.IsDBNull(5), String.Empty, reader.GetString(5))
                            metadata.Phoneno = If(reader.IsDBNull(6), String.Empty, reader.GetString(6))
                            metadata.Civilstatus = If(reader.IsDBNull(7), String.Empty, reader.GetString(7))
                            metadata.Citizenship = If(reader.IsDBNull(8), String.Empty, reader.GetString(8))
                            metadata.Fathersname = If(reader.IsDBNull(9), String.Empty, reader.GetString(9))
                            metadata.Mothersname = If(reader.IsDBNull(10), String.Empty, reader.GetString(10))
                            metadata.Spouse = If(reader.IsDBNull(11), String.Empty, reader.GetString(11))
                            metadata.Email = If(reader.IsDBNull(12), String.Empty, reader.GetString(12))
                            metadata.Religion = If(reader.IsDBNull(13), String.Empty, reader.GetString(13))
                            metadata.Voterstatus = If(reader.IsDBNull(14), String.Empty, reader.GetString(14))
                            metadata.Weight = If(reader.IsDBNull(15), String.Empty, reader.GetString(15))
                            metadata.Height = If(reader.IsDBNull(16), String.Empty, reader.GetString(16))
                            metadata.Address = If(reader.IsDBNull(18), String.Empty, reader.GetString(18))

                            ' Handle idpic (can be byte array or null)
                            If Not reader.IsDBNull(17) Then
                                metadata.Idpic = reader.GetValue(17)
                            Else
                                metadata.Idpic = DBNull.Value
                            End If

                            Dim rowIndex As Integer = dgvProfiles.Rows.Add()
                            dgvProfiles.Rows(rowIndex).Cells("colSelect").Value = False
                            dgvProfiles.Rows(rowIndex).Cells("colFullName").Value = BuildFullName(metadata.FirstName, metadata.MiddleName, metadata.LastName)
                            dgvProfiles.Rows(rowIndex).Tag = metadata
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load restore records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateEntriesLabel()
    End Sub

    Private Function BuildFullName(firstName As String, middleName As String, lastName As String) As String
        Dim parts As New List(Of String)()
        If Not String.IsNullOrWhiteSpace(firstName) Then parts.Add(firstName.Trim())
        If Not String.IsNullOrWhiteSpace(middleName) Then parts.Add(middleName.Trim())
        If Not String.IsNullOrWhiteSpace(lastName) Then parts.Add(lastName.Trim())

        Return String.Join(" ", parts)
    End Function

    Private Sub dgvProfiles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfiles.CellClick
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = dgvProfiles.Columns("colRestore").Index Then
            RestoreRecord(e.RowIndex)
        End If
    End Sub

    Private Sub RestoreRecord(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= dgvProfiles.Rows.Count Then Return

        Dim row As DataGridViewRow = dgvProfiles.Rows(rowIndex)
        Dim metadata As RestoreMetadata = TryCast(row.Tag, RestoreMetadata)
        If metadata Is Nothing Then Return

        Dim fullName As String = Convert.ToString(row.Cells("colFullName").Value)
        Dim confirm = MessageBox.Show($"Restore {fullName} to resident records?", "Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Using tran = conn.BeginTransaction()
                    Try
                        Dim insertSql As String = "INSERT INTO tbl_residentinfo (lastname, firstname, middlename, gender, birthdate, age, phoneno, civilstatus, citizenship, fathersname, mothersname, spouse, email, religion, voterstatus, weight, height, idpic, address) VALUES (@ln, @fn, @mn, @gender, @birthdate, @age, @phoneno, @civilstatus, @citizenship, @fathersname, @mothersname, @spouse, @email, @religion, @voterstatus, @weight, @height, @idpic, @address)"

                        Using insertCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(insertSql, conn, tran)
                            insertCmd.Parameters.AddWithValue("@ln", metadata.LastName)
                            insertCmd.Parameters.AddWithValue("@fn", metadata.FirstName)
                            Dim middleParam As Object = If(String.IsNullOrWhiteSpace(metadata.MiddleName), CType(DBNull.Value, Object), metadata.MiddleName)
                            insertCmd.Parameters.AddWithValue("@mn", middleParam)
                            insertCmd.Parameters.AddWithValue("@gender", If(String.IsNullOrWhiteSpace(metadata.Gender), DBNull.Value, metadata.Gender))
                            Dim birthParam As Object = If(metadata.BirthDate.HasValue, CType(metadata.BirthDate.Value, Object), DBNull.Value)
                            insertCmd.Parameters.AddWithValue("@birthdate", birthParam)
                            insertCmd.Parameters.AddWithValue("@age", If(String.IsNullOrWhiteSpace(metadata.Age), DBNull.Value, metadata.Age))
                            insertCmd.Parameters.AddWithValue("@phoneno", If(String.IsNullOrWhiteSpace(metadata.Phoneno), DBNull.Value, metadata.Phoneno))
                            insertCmd.Parameters.AddWithValue("@civilstatus", If(String.IsNullOrWhiteSpace(metadata.Civilstatus), DBNull.Value, metadata.Civilstatus))
                            insertCmd.Parameters.AddWithValue("@citizenship", If(String.IsNullOrWhiteSpace(metadata.Citizenship), DBNull.Value, metadata.Citizenship))
                            insertCmd.Parameters.AddWithValue("@fathersname", If(String.IsNullOrWhiteSpace(metadata.Fathersname), DBNull.Value, metadata.Fathersname))
                            insertCmd.Parameters.AddWithValue("@mothersname", If(String.IsNullOrWhiteSpace(metadata.Mothersname), DBNull.Value, metadata.Mothersname))
                            insertCmd.Parameters.AddWithValue("@spouse", If(String.IsNullOrWhiteSpace(metadata.Spouse), DBNull.Value, metadata.Spouse))
                            insertCmd.Parameters.AddWithValue("@email", If(String.IsNullOrWhiteSpace(metadata.Email), DBNull.Value, metadata.Email))
                            insertCmd.Parameters.AddWithValue("@religion", If(String.IsNullOrWhiteSpace(metadata.Religion), DBNull.Value, metadata.Religion))
                            insertCmd.Parameters.AddWithValue("@voterstatus", If(String.IsNullOrWhiteSpace(metadata.Voterstatus), DBNull.Value, metadata.Voterstatus))
                            insertCmd.Parameters.AddWithValue("@weight", If(String.IsNullOrWhiteSpace(metadata.Weight), DBNull.Value, metadata.Weight))
                            insertCmd.Parameters.AddWithValue("@height", If(String.IsNullOrWhiteSpace(metadata.Height), DBNull.Value, metadata.Height))
                            insertCmd.Parameters.AddWithValue("@idpic", metadata.Idpic)
                            insertCmd.Parameters.AddWithValue("@address", If(String.IsNullOrWhiteSpace(metadata.Address), DBNull.Value, metadata.Address))

                            Dim rowsInserted As Integer = insertCmd.ExecuteNonQuery()
                            If rowsInserted = 0 Then
                                Throw New Exception("Unable to restore record. It may have been removed already.")
                            End If
                        End Using

                        Dim deleteSql As String = "DELETE FROM tbl_restore WHERE lastname = @ln AND firstname = @fn AND ((@mn IS NULL AND (middlename IS NULL OR TRIM(middlename) = '')) OR middlename = @mn) " &
                                                 "AND ((@birthdate IS NULL AND birthdate IS NULL) OR birthdate = @birthdate) LIMIT 1"

                        Using deleteCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(deleteSql, conn, tran)
                            deleteCmd.Parameters.AddWithValue("@ln", metadata.LastName)
                            deleteCmd.Parameters.AddWithValue("@fn", metadata.FirstName)
                            Dim middleParam As Object = If(String.IsNullOrWhiteSpace(metadata.MiddleName), CType(DBNull.Value, Object), metadata.MiddleName)
                            deleteCmd.Parameters.AddWithValue("@mn", middleParam)
                            Dim birthParam As Object = If(metadata.BirthDate.HasValue, CType(metadata.BirthDate.Value, Object), DBNull.Value)
                            deleteCmd.Parameters.AddWithValue("@birthdate", birthParam)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        tran.Commit()
                    Catch
                        tran.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            LoadRestoreRecords()
            UpdateEntriesLabel()
            MessageBox.Show($"Restored {fullName}.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to restore record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Class RestoreMetadata
        Public Property LastName As String
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property BirthDate As Nullable(Of DateTime)
        Public Property Gender As String
        Public Property Age As String
        Public Property Phoneno As String
        Public Property Civilstatus As String
        Public Property Citizenship As String
        Public Property Fathersname As String
        Public Property Mothersname As String
        Public Property Spouse As String
        Public Property Email As String
        Public Property Religion As String
        Public Property Voterstatus As String
        Public Property Weight As String
        Public Property Height As String
        Public Property Idpic As Object
        Public Property Address As String
    End Class

    Private Sub dgvProfiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfiles.CellContentClick

    End Sub

    Private Sub UpdateEntriesLabel()
        Dim visibleRows As Integer = 0
        Dim totalRows As Integer = dgvProfiles.Rows.Count

        For Each row As DataGridViewRow In dgvProfiles.Rows
            If row.Visible Then visibleRows += 1
        Next

        If visibleRows > 0 Then
            lblShowEntries.Text = $"Showing 1 to {visibleRows} of {totalRows} entries"
        Else
            lblShowEntries.Text = "Showing 0 entries"
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.ToLower().Trim()

        If String.IsNullOrEmpty(searchText) Then
            ' Show all rows
            For Each row As DataGridViewRow In dgvProfiles.Rows
                row.Visible = True
            Next
        Else
            ' Filter rows
            For Each row As DataGridViewRow In dgvProfiles.Rows
                Dim fullName As String = If(row.Cells("colFullName").Value IsNot Nothing, row.Cells("colFullName").Value.ToString().ToLower(), "")
                row.Visible = fullName.Contains(searchText)
            Next
        End If

        UpdateEntriesLabel()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Pagination functionality can be added here if needed
        ' For now, just a placeholder
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Pagination functionality can be added here if needed
        ' For now, just a placeholder
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            ' Let user choose where to save the backup file
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "ZIP Files (*.zip)|*.zip"
                saveDialog.FileName = $"BIMS_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.zip"
                saveDialog.Title = "Save Backup File"

                If saveDialog.ShowDialog() <> DialogResult.OK Then
                    Return
                End If

                Dim zipFilePath As String = saveDialog.FileName
                Dim tempDir As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"BIMS_Backup_{Guid.NewGuid()}")

                Try
                    ' Create temporary directory for CSV files
                    System.IO.Directory.CreateDirectory(tempDir)

                    ' Show progress
                    Me.Cursor = Cursors.WaitCursor
                    btnBackup.Enabled = False

                    ' List of all tables to backup
                    Dim tables As New List(Of String) From {
                        "tbl_residentinfo",
                        "tbl_restore",
                        "tbl_certificate",
                        "tbl_cedulatracker",
                        "tbl_login"
                    }

                    ' Export each table to CSV
                    Dim exportedTables As New List(Of String)()
                    For Each tableName As String In tables
                        Try
                            Dim csvPath As String = System.IO.Path.Combine(tempDir, $"{tableName}.csv")
                            ExportTableToCsv(tableName, csvPath)
                            exportedTables.Add(tableName)
                        Catch ex As Exception
                            ' Log error but continue with other tables
                            System.Diagnostics.Debug.WriteLine($"Failed to export {tableName}: {ex.Message}")
                        End Try
                    Next

                    If exportedTables.Count = 0 Then
                        MessageBox.Show("No tables were exported. Please check database connection.", "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Create ZIP file
                    If System.IO.File.Exists(zipFilePath) Then
                        System.IO.File.Delete(zipFilePath)
                    End If

                    System.IO.Compression.ZipFile.CreateFromDirectory(tempDir, zipFilePath)

                    MessageBox.Show($"Backup completed successfully!{vbCrLf}{vbCrLf}Exported {exportedTables.Count} table(s):{vbCrLf}{String.Join(vbCrLf, exportedTables)}{vbCrLf}{vbCrLf}Saved to:{vbCrLf}{zipFilePath}",
                                    "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open the folder containing the backup file
                    Try
                        System.Diagnostics.Process.Start("explorer.exe", $"/select,""{zipFilePath}""")
                    Catch
                        ' If explorer fails, just open the folder
                        System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(zipFilePath))
                    End Try

                Finally
                    ' Clean up temporary directory
                    Try
                        If System.IO.Directory.Exists(tempDir) Then
                            System.IO.Directory.Delete(tempDir, True)
                        End If
                    Catch
                        ' Ignore cleanup errors
                    End Try

                    Me.Cursor = Cursors.Default
                    btnBackup.Enabled = True
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show($"Backup failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Default
            btnBackup.Enabled = True
        End Try
    End Sub

    Private Sub ExportTableToCsv(tableName As String, outputPath As String)
        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Dim sql As String = $"SELECT * FROM {tableName}"
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        Using writer As New System.IO.StreamWriter(outputPath, False, System.Text.Encoding.UTF8)
                            ' Write headers
                            Dim headers As New List(Of String)()
                            For i As Integer = 0 To reader.FieldCount - 1
                                headers.Add(reader.GetName(i))
                            Next
                            writer.WriteLine(String.Join(",", headers.Select(Function(h) EscapeCsvField(h))))

                            ' Write rows
                            While reader.Read()
                                Dim values As New List(Of String)()
                                For i As Integer = 0 To reader.FieldCount - 1
                                    If reader.IsDBNull(i) Then
                                        values.Add("")
                                    Else
                                        Dim value As String = reader.GetValue(i).ToString()
                                        values.Add(EscapeCsvField(value))
                                    End If
                                Next
                                writer.WriteLine(String.Join(",", values))
                            End While
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception($"Failed to export {tableName}: {ex.Message}")
        End Try
    End Sub

    Private Function EscapeCsvField(field As String) As String
        If String.IsNullOrEmpty(field) Then Return ""

        ' If field contains comma, quote, or newline, wrap in quotes and escape quotes
        If field.Contains(",") OrElse field.Contains("""") OrElse field.Contains(vbCrLf) OrElse field.Contains(vbCr) OrElse field.Contains(vbLf) Then
            Return """" & field.Replace("""", """""") & """"
        End If

        Return field
    End Function
End Class