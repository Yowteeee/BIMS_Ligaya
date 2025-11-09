Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class cedularestore
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0

    Public Sub SetAsChildForm()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub cedularestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRestoreIcon()
        LoadRestoreRecords()
    End Sub

    Private Sub SetRestoreIcon()
        If dgvCedula IsNot Nothing AndAlso dgvCedula.Columns.Contains("DataGridViewImageColumn2") Then
            Dim restoreColumn As DataGridViewImageColumn = TryCast(dgvCedula.Columns("DataGridViewImageColumn2"), DataGridViewImageColumn)
            If restoreColumn IsNot Nothing Then
                restoreColumn.Image = CreateCircularArrowIcon()
            End If
        End If
    End Sub

    Private Function CreateCircularArrowIcon() As Image
        ' Create a 32x32 bitmap for the circular arrow icon (dark grey circular arrow)
        Dim size As Integer = 32
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.Clear(Color.Transparent)

            Dim centerX As Single = size / 2
            Dim centerY As Single = size / 2
            Dim radius As Single = (size - 8) / 2

            ' Dark grey color for the arrow (RGB: 64, 64, 64)
            Using brush As New SolidBrush(Color.FromArgb(64, 64, 64))
                Using pen As New Pen(brush, 3.0F)
                    ' Draw thick circular arc (most of the circle, leaving gap for arrow head)
                    Dim rect As New RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2)
                    ' Draw arc from 225 degrees (bottom-left) sweeping about 315 degrees (counter-clockwise)
                    g.DrawArc(pen, rect, 225, 315)

                    ' Draw arrow head at bottom-left (pointing down and left, counter-clockwise)
                    ' Arrow head angle: 225 degrees (pointing down-left)
                    Dim arrowAngle As Single = 225 * Math.PI / 180.0F
                    Dim arrowTipX As Single = centerX + radius * CSng(Math.Cos(arrowAngle))
                    Dim arrowTipY As Single = centerY + radius * CSng(Math.Sin(arrowAngle))

                    ' Arrow head size and direction
                    Dim arrowSize As Single = 5
                    ' Points for arrow head triangle (pointing in counter-clockwise direction)
                    Dim arrowBase1X As Single = arrowTipX + arrowSize * CSng(Math.Cos(arrowAngle - Math.PI / 3))
                    Dim arrowBase1Y As Single = arrowTipY + arrowSize * CSng(Math.Sin(arrowAngle - Math.PI / 3))
                    Dim arrowBase2X As Single = arrowTipX + arrowSize * CSng(Math.Cos(arrowAngle + Math.PI / 3))
                    Dim arrowBase2Y As Single = arrowTipY + arrowSize * CSng(Math.Sin(arrowAngle + Math.PI / 3))

                    ' Fill arrow head triangle
                    Dim arrowPoints() As PointF = {
                        New PointF(arrowTipX, arrowTipY),
                        New PointF(arrowBase1X, arrowBase1Y),
                        New PointF(arrowBase2X, arrowBase2Y)
                    }
                    g.FillPolygon(brush, arrowPoints)
                End Using
            End Using
        End Using

        Return bmp
    End Function

    Private Sub LoadRestoreRecords()
        dgvCedula.Rows.Clear()

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()

                ' Get total count
                Dim countSql As String = "SELECT COUNT(*) FROM tbl_cedularestore"
                Using countCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(countSql, conn)
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                ' Calculate total pages
                totalPages = If(totalRecords > 0, CInt(Math.Ceiling(totalRecords / CDbl(pageSize))), 1)

                ' Ensure currentPage is valid
                If totalRecords = 0 Then
                    currentPage = 1
                ElseIf currentPage > totalPages Then
                    currentPage = totalPages
                ElseIf currentPage < 1 Then
                    currentPage = 1
                End If

                ' Load data for current page with LIMIT and OFFSET
                Dim offset As Integer = (currentPage - 1) * pageSize
                Dim sql As String = $"SELECT ctcnumber, lastname, firstname, middlename, address, placeissued, dateissued FROM tbl_cedularestore ORDER BY dateissued DESC LIMIT {pageSize} OFFSET {offset}"
                
                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Using reader As Global.MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim metadata As New CedulaRestoreMetadata()
                            metadata.CtcNumber = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            metadata.LastName = If(reader.IsDBNull(1), String.Empty, reader.GetString(1))
                            metadata.FirstName = If(reader.IsDBNull(2), String.Empty, reader.GetString(2))
                            metadata.MiddleName = If(reader.IsDBNull(3), String.Empty, reader.GetString(3))
                            metadata.Address = If(reader.IsDBNull(4), String.Empty, reader.GetString(4))
                            metadata.PlaceIssued = If(reader.IsDBNull(5), String.Empty, reader.GetString(5))
                            metadata.DateIssued = If(reader.IsDBNull(6), DateTime.MinValue, reader.GetDateTime(6))

                            Dim fullName As String = BuildFullName(metadata.FirstName, metadata.MiddleName, metadata.LastName)

                            Dim rowIndex As Integer = dgvCedula.Rows.Add()
                            dgvCedula.Rows(rowIndex).Cells("DataGridViewCheckBoxColumn1").Value = False
                            dgvCedula.Rows(rowIndex).Cells("CTCNumber").Value = metadata.CtcNumber.ToString()
                            dgvCedula.Rows(rowIndex).Cells("DateIssued").Value = metadata.DateIssued.ToString("yyyy-MM-dd")
                            dgvCedula.Rows(rowIndex).Cells("DataGridViewTextBoxColumn1").Value = fullName
                            dgvCedula.Rows(rowIndex).Tag = metadata
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load restore records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdatePaginationControls()
        UpdateEntriesLabel()
    End Sub

    Private Function BuildFullName(firstName As String, middleName As String, lastName As String) As String
        Dim parts As New List(Of String)()
        If Not String.IsNullOrWhiteSpace(firstName) Then parts.Add(firstName.Trim())
        If Not String.IsNullOrWhiteSpace(middleName) Then parts.Add(middleName.Trim())
        If Not String.IsNullOrWhiteSpace(lastName) Then parts.Add(lastName.Trim())

        Return String.Join(" ", parts)
    End Function

    Private Sub dgvCedula_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCedula.CellContentClick
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = dgvCedula.Columns("DataGridViewImageColumn2").Index Then
            RestoreRecord(e.RowIndex)
        End If
    End Sub

    Private Sub RestoreRecord(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= dgvCedula.Rows.Count Then Return

        Dim row As DataGridViewRow = dgvCedula.Rows(rowIndex)
        Dim fullName As String = Convert.ToString(row.Cells("DataGridViewTextBoxColumn1").Value)
        Dim metadata As CedulaRestoreMetadata = TryCast(row.Tag, CedulaRestoreMetadata)
        If metadata Is Nothing Then Return

        Dim confirm = MessageBox.Show($"Restore {fullName} to cedula records?", "Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()
                Using tran = conn.BeginTransaction()
                    Try
                        Dim insertSql As String = "INSERT INTO tbl_cedulatracker (ctcnumber, lastname, firstname, middlename, address, placeissued, dateissued) VALUES (@ctcnumber, @lastname, @firstname, @middlename, @address, @placeissued, @dateissued)"

                        Using insertCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(insertSql, conn, tran)
                            insertCmd.Parameters.AddWithValue("@ctcnumber", metadata.CtcNumber)
                            insertCmd.Parameters.AddWithValue("@lastname", metadata.LastName)
                            insertCmd.Parameters.AddWithValue("@firstname", metadata.FirstName)
                            Dim middleParam As Object = If(String.IsNullOrWhiteSpace(metadata.MiddleName), CType(DBNull.Value, Object), metadata.MiddleName)
                            insertCmd.Parameters.AddWithValue("@middlename", middleParam)
                            insertCmd.Parameters.AddWithValue("@address", If(String.IsNullOrWhiteSpace(metadata.Address), DBNull.Value, metadata.Address))
                            insertCmd.Parameters.AddWithValue("@placeissued", If(String.IsNullOrWhiteSpace(metadata.PlaceIssued), DBNull.Value, metadata.PlaceIssued))
                            insertCmd.Parameters.AddWithValue("@dateissued", metadata.DateIssued)

                            Dim rowsInserted As Integer = insertCmd.ExecuteNonQuery()
                            If rowsInserted = 0 Then
                                Throw New Exception("Unable to restore record. It may have been removed already.")
                            End If
                        End Using

                        Dim deleteSql As String = "DELETE FROM tbl_cedularestore WHERE ctcnumber = @ctcnumber LIMIT 1"

                        Using deleteCmd As New Global.MySql.Data.MySqlClient.MySqlCommand(deleteSql, conn, tran)
                            deleteCmd.Parameters.AddWithValue("@ctcnumber", metadata.CtcNumber)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        tran.Commit()
                    Catch
                        tran.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            ' Reload data after restore (LoadRestoreRecords will handle page adjustment if needed)
            LoadRestoreRecords()
            MessageBox.Show($"Restored {fullName}.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to restore record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePaginationControls()
        ' Update page number label
        lblPageNumber.Text = currentPage.ToString()

        ' Enable/disable Previous button
        btnPrevious.Enabled = currentPage > 1

        ' Enable/disable Next button
        btnNext.Enabled = currentPage < totalPages

        ' If no records, disable both buttons
        If totalRecords = 0 Then
            btnPrevious.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub UpdateEntriesLabel()
        If totalRecords = 0 Then
            lblShowEntries.Text = "Showing 0 entries"
            Return
        End If

        Dim startRecord As Integer = ((currentPage - 1) * pageSize) + 1
        Dim endRecord As Integer = Math.Min(currentPage * pageSize, totalRecords)

        lblShowEntries.Text = $"Showing {startRecord} to {endRecord} of {totalRecords} entries"
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadRestoreRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadRestoreRecords()
        End If
    End Sub

    Private Sub lblPageNumber_Click(sender As Object, e As EventArgs) Handles lblPageNumber.Click
        ' Page number label is read-only, no action needed
    End Sub

    Private Class CedulaRestoreMetadata
        Public Property CtcNumber As Integer
        Public Property LastName As String
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property Address As String
        Public Property PlaceIssued As String
        Public Property DateIssued As DateTime
    End Class
End Class