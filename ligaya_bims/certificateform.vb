Public Class certificateform
    Private btnPageSetup As Object
    Private btnPreview As Object
    Public Event CertificateSaved()
    Private currentCertForm As Form = Nothing
    Private currentPanel2 As Panel = Nothing
    
    Private Sub SetBaseFieldsVisible(isVisible As Boolean)
        ' Base fields have been removed - form now uses Panel2 controls dynamically
        ' This method is kept for compatibility but no longer needs to do anything
    End Sub


    Private Sub certificateform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Clean up persistent forms when main form is closed
        CertificateFormManager.DisposeAllForms()
    End Sub

    ' Database methods
    Private Function ValidateFormData() As Boolean
        ' Minimal validation: ensure a certificate type is selected
        If cmbCertificateType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a certificate type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCertificateType.Focus()
            Return False
        End If
        Return True
    End Function

    ' Base status controls are removed from UI; try to infer from Panel2 controls when available
    Private Function GetStatus() As String
        Dim cmb As ComboBox = TryCast(FindPanel2Control("cmb3"), ComboBox)
        If cmb IsNot Nothing AndAlso cmb.SelectedItem IsNot Nothing Then
            Return cmb.SelectedItem.ToString()
        End If
        Return String.Empty
    End Function

    Private Function FindPanel2Control(name As String) As Control
        For Each ctrl As Control In panelFormFields.Controls
            If String.Equals(ctrl.Name, name, StringComparison.OrdinalIgnoreCase) Then
                Return ctrl
            End If
        Next
        Return Nothing
    End Function

    Private Function GetPanel2Text(name As String) As String
        Dim c As Control = FindPanel2Control(name)
        If TypeOf c Is TextBox Then
            Return DirectCast(c, TextBox).Text
        ElseIf TypeOf c Is ComboBox Then
            Dim cb = DirectCast(c, ComboBox)
            Return If(cb.SelectedItem IsNot Nothing, cb.SelectedItem.ToString(), String.Empty)
        End If
        Return String.Empty
    End Function

    Private Function GetPanel2Date(name As String) As DateTime
        Dim c As Control = FindPanel2Control(name)
        If TypeOf c Is DateTimePicker Then
            Return DirectCast(c, DateTimePicker).Value
        End If
        Return DateTime.Now
    End Function

    Private Function SaveCertificateToDatabase() As Boolean
        Try
            Using conn As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                conn.Open()

                ' Use INSERT IGNORE or check for duplicates first to avoid duplicate entry errors
                ' Alternatively, use INSERT ... ON DUPLICATE KEY UPDATE if you want to update existing records
                Dim sql As String = "INSERT INTO tbl_certificate (certificate, fullname, age, status, address, purpose, issuedon) VALUES (@certificate, @fullname, @age, @status, @address, @purpose, @issuedon)"

                Using cmd As New Global.MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                    Dim certificateType As String = If(cmbCertificateType.SelectedItem IsNot Nothing, cmbCertificateType.SelectedItem.ToString(), "")
                    If String.IsNullOrWhiteSpace(certificateType) Then
                        MessageBox.Show("Please select a certificate type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                    
                    cmd.Parameters.AddWithValue("@certificate", certificateType)
                    ' Try to source values from Panel2 standard names, fallback to shared data/empty
                    Dim fullName As String = GetPanel2Text("txt1")
                    If String.IsNullOrWhiteSpace(fullName) Then fullName = GetPanel2Text("txtfullname")
                    If String.IsNullOrWhiteSpace(fullName) Then fullName = SharedCertificateData.FullName
                    
                    Dim ageText As String = GetPanel2Text("txt6")
                    If String.IsNullOrWhiteSpace(ageText) Then ageText = GetPanel2Text("txtage")
                    Dim ageVal As Integer = 0
                    Integer.TryParse(ageText, ageVal)
                    
                    Dim addressVal As String = GetPanel2Text("txt4")
                    If String.IsNullOrWhiteSpace(addressVal) Then addressVal = GetPanel2Text("txtaddress")
                    If String.IsNullOrWhiteSpace(addressVal) Then addressVal = SharedCertificateData.Address
                    
                    Dim purposeVal As String = GetPanel2Text("txt5")
                    If String.IsNullOrWhiteSpace(purposeVal) Then purposeVal = GetPanel2Text("txtpurpose")
                    If String.IsNullOrWhiteSpace(purposeVal) Then purposeVal = SharedCertificateData.Purpose
                    
                    Dim issuedOn As DateTime = GetPanel2Date("dtpissueddate")
                    If issuedOn = DateTime.MinValue Then issuedOn = DateTime.Now

                    cmd.Parameters.AddWithValue("@fullname", If(String.IsNullOrWhiteSpace(fullName), String.Empty, fullName))
                    cmd.Parameters.AddWithValue("@age", ageVal)
                    cmd.Parameters.AddWithValue("@status", GetStatus())
                    cmd.Parameters.AddWithValue("@address", If(String.IsNullOrWhiteSpace(addressVal), String.Empty, addressVal))
                    cmd.Parameters.AddWithValue("@purpose", If(String.IsNullOrWhiteSpace(purposeVal), String.Empty, purposeVal))
                    cmd.Parameters.AddWithValue("@issuedon", issuedOn)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        RaiseEvent CertificateSaved()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Global.MySql.Data.MySqlClient.MySqlException
            If ex.Number = 1062 Then
                ' Duplicate entry - allow user to proceed or update existing record
                Dim result As DialogResult = MessageBox.Show(
                    "A certificate with similar information already exists in the database." & vbCrLf &
                    "Would you like to save this as a new certificate anyway? (This may require database administrator assistance)", 
                    "Duplicate Entry", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question)
                
                If result = DialogResult.Yes Then
                    ' Try to insert with a unique identifier or timestamp to make it unique
                    Try
                        Using conn2 As Global.MySql.Data.MySqlClient.MySqlConnection = Database.CreateConnection()
                            conn2.Open()
                            ' Add timestamp or unique identifier to make it different
                            Dim sql2 As String = "INSERT INTO tbl_certificate (certificate, fullname, age, status, address, purpose, issuedon) VALUES (@certificate, @fullname, @age, @status, @address, @purpose, @issuedon)"
                            Using cmd2 As New Global.MySql.Data.MySqlClient.MySqlCommand(sql2, conn2)
                                Dim certificateType As String = If(cmbCertificateType.SelectedItem IsNot Nothing, cmbCertificateType.SelectedItem.ToString(), "")
                                Dim fullName As String = GetPanel2Text("txt1")
                                If String.IsNullOrWhiteSpace(fullName) Then fullName = GetPanel2Text("txtfullname")
                                Dim ageText As String = GetPanel2Text("txt6")
                                Dim ageVal As Integer = 0
                                Integer.TryParse(ageText, ageVal)
                                Dim addressVal As String = GetPanel2Text("txt4")
                                Dim purposeVal As String = GetPanel2Text("txt5")
                                Dim issuedOn As DateTime = GetPanel2Date("dtpissueddate")
                                If issuedOn = DateTime.MinValue Then issuedOn = DateTime.Now

                                cmd2.Parameters.AddWithValue("@certificate", certificateType)
                                cmd2.Parameters.AddWithValue("@fullname", If(String.IsNullOrWhiteSpace(fullName), String.Empty, fullName))
                                cmd2.Parameters.AddWithValue("@age", ageVal)
                                cmd2.Parameters.AddWithValue("@status", GetStatus())
                                cmd2.Parameters.AddWithValue("@address", If(String.IsNullOrWhiteSpace(addressVal), String.Empty, addressVal))
                                cmd2.Parameters.AddWithValue("@purpose", If(String.IsNullOrWhiteSpace(purposeVal), String.Empty, purposeVal))
                                cmd2.Parameters.AddWithValue("@issuedon", issuedOn)
                                cmd2.ExecuteNonQuery()
                                RaiseEvent CertificateSaved()
                                Return True
                            End Using
                        End Using
                    Catch ex2 As Exception
                        MessageBox.Show("Unable to save certificate. The database may have a unique constraint that prevents duplicate entries. Please contact the database administrator.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                Return False
            Else
                MessageBox.Show("Database Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show("Error saving certificate to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ClearForm()
        ' Clear form fields
        cmbCertificateType.SelectedIndex = -1

        ' Hide all pictureboxes
        certResidency.Visible = False
        certAnnual.Visible = False
        certCC.Visible = False
        certSC.Visible = False

        ' Clear Panel2 controls
        ClearPanel2Controls()

        ' Clear shared data
        SharedCertificateData.ClearData()
    End Sub





    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Validate form data first
        If Not ValidateFormData() Then Return

        ' Save to database
        If Not SaveCertificateToDatabase() Then
            MessageBox.Show("Failed to save certificate data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Configure preview similar to provided sample: maximized, antialiasing, zoom controls
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        Try
            With PrintPreviewDialog1.PrintPreviewControl
                .AutoZoom = True
                .UseAntiAlias = True
                .Zoom = 1.0R
            End With
        Catch
        End Try
        PrintPreviewDialog1.ShowDialog()

        ' Optional: clear after preview closes
        Dim result As DialogResult = MessageBox.Show("Finished printing? Clear the form for the next entry?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then ClearForm()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Get the current certificate image
        Dim certImage As Image = Nothing
        If certResidency.Visible Then
            certImage = certResidency.Image
        ElseIf certAnnual.Visible Then
            certImage = certAnnual.Image
        ElseIf certCC.Visible Then
            certImage = certCC.Image
        ElseIf certSC.Visible Then
            certImage = certSC.Image
        End If

        If certImage Is Nothing Then
            e.Cancel = True
            Return
        End If

        ' Calculate the size to fit the page
        Dim pageBounds As Rectangle = e.MarginBounds
        Dim imageSize As Size = certImage.Size
        Dim scaleX As Double = pageBounds.Width / imageSize.Width
        Dim scaleY As Double = pageBounds.Height / imageSize.Height
        Dim scale As Double = Math.Min(scaleX, scaleY)

        Dim scaledWidth As Integer = CInt(imageSize.Width * scale)
        Dim scaledHeight As Integer = CInt(imageSize.Height * scale)
        Dim x As Integer = pageBounds.X + (pageBounds.Width - scaledWidth) \ 2
        Dim y As Integer = pageBounds.Y + (pageBounds.Height - scaledHeight) \ 2

        ' Draw the certificate image
        e.Graphics.DrawImage(certImage, x, y, scaledWidth, scaledHeight)
        e.HasMorePages = False
    End Sub


    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub certificateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide separate page setup and preview controls if present on the form
        Try
            Dim ctrl = Me.Controls.Find("btnPageSetup", True)
            If ctrl IsNot Nothing AndAlso ctrl.Length > 0 Then ctrl(0).Visible = False
        Catch
        End Try
        Try
            Dim ctrl = Me.Controls.Find("btnPreview", True)
            If ctrl IsNot Nothing AndAlso ctrl.Length > 0 Then ctrl(0).Visible = False
        Catch
        End Try

        ' No runtime Save/Cancel injection; rely on existing designer buttons
        ' Hide base fields by default; we now use certificate-specific Panel2 controls
        SetBaseFieldsVisible(False)
    End Sub

    Private Sub panelRight_Paint(sender As Object, e As PaintEventArgs) Handles panelRight.Paint

    End Sub


    Private Sub pnlPic_Paint(sender As Object, e As PaintEventArgs) Handles pnlPic.Paint

    End Sub

    Private Sub cmbCertificateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCertificateType.SelectedIndexChanged
        ' Hide all pictureboxes first
        certResidency.Visible = False
        certAnnual.Visible = False
        certCC.Visible = False
        certSC.Visible = False

        ' Clear existing Panel2 controls
        ClearPanel2Controls()

        ' Show the appropriate picturebox and load Panel2 based on selection
        Dim selected As String = If(cmbCertificateType.SelectedItem, "").ToString()

        If selected = "Certificate of Residency" Then
            certResidency.Visible = True
            LoadPanel2Controls("Residency")
        ElseIf selected = "Certificate of Annual Income" Then
            certAnnual.Visible = True
            LoadPanel2Controls("Annual")
        ElseIf selected = "Certificate of Cohabitation" Then
            certCC.Visible = True
            LoadPanel2Controls("CC")
        ElseIf selected = "Certificate of Senior Citizen" Then
            certSC.Visible = True
            LoadPanel2Controls("SC")
        End If

        ' Hide the base fields once a certificate type is chosen
        SetBaseFieldsVisible(False)
    End Sub

    Private Sub ClearPanel2Controls()
        ' Remove all dynamically added controls (keep only the original form controls)
        Dim controlsToRemove As New List(Of Control)
        For Each ctrl As Control In panelFormFields.Controls
            ' Keep original controls: combobox only (base fields removed, now using Panel2)
            If Not (ctrl Is cmbCertificateType) Then
                controlsToRemove.Add(ctrl)
            End If
        Next
        For Each ctrl As Control In controlsToRemove
            panelFormFields.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
        currentPanel2 = Nothing
        currentCertForm = Nothing
        ' Ensure base fields are visible when nothing is selected / after clear
        If cmbCertificateType.SelectedIndex = -1 Then
            SetBaseFieldsVisible(True)
        End If
    End Sub

    Private Sub LoadPanel2Controls(certType As String)
        Try
            ' Get the appropriate certificate form
            Dim certForm As Form = Nothing
            Select Case certType
                Case "Residency"
                    certForm = CertificateFormManager.GetResidencyForm()
                Case "Annual"
                    certForm = CertificateFormManager.GetAnnualForm()
                Case "CC"
                    certForm = CertificateFormManager.GetCCForm()
                Case "SC"
                    certForm = CertificateFormManager.GetSCForm()
            End Select

            If certForm Is Nothing Then Return

            currentCertForm = certForm
            ' Find Panel2 in the certificate form
            Dim sourcePanel2 As Panel = Nothing
            For Each ctrl As Control In certForm.Controls
                If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Panel2" Then
                    sourcePanel2 = DirectCast(ctrl, Panel)
                    Exit For
                End If
            Next

            If sourcePanel2 Is Nothing Then Return

            currentPanel2 = sourcePanel2
            ' Calculate starting Y position (after combobox and spacing)
            Dim startY As Integer = cmbCertificateType.Bottom + 20
            Dim minY As Integer = Integer.MaxValue

            ' Find the minimum Y position in source Panel2 to preserve relative positioning
            For Each ctrl As Control In sourcePanel2.Controls
                If ctrl.Top < minY Then minY = ctrl.Top
            Next

            ' Clone all controls from Panel2 to panelFormFields, preserving their relative positions
            ' Sort controls by their Y position to maintain order (manual sort to avoid LINQ dependency issues)
            Dim sortedControls As New List(Of Control)
            For Each ctrl As Control In sourcePanel2.Controls
                sortedControls.Add(ctrl)
            Next
            ' Manual bubble sort by Y position, then X position
            For i As Integer = 0 To sortedControls.Count - 2
                For j As Integer = i + 1 To sortedControls.Count - 1
                    If sortedControls(i).Top > sortedControls(j).Top OrElse
                       (sortedControls(i).Top = sortedControls(j).Top AndAlso sortedControls(i).Left > sortedControls(j).Left) Then
                        Dim temp As Control = sortedControls(i)
                        sortedControls(i) = sortedControls(j)
                        sortedControls(j) = temp
                    End If
                Next
            Next

            ' Clone controls maintaining their relative layout
            For Each sourceCtrl As Control In sortedControls
                Dim clonedCtrl As Control = CloneControl(sourceCtrl)
                If clonedCtrl IsNot Nothing Then
                    ' Preserve relative position from source Panel2
                    Dim relativeY As Integer = sourceCtrl.Top - minY
                    Dim newY As Integer = startY + relativeY

                    ' Position relative to panelFormFields left edge (align with combobox)
                    clonedCtrl.Location = New Point(cmbCertificateType.Left, newY)
                    
                    ' Make textboxes editable
                    If TypeOf clonedCtrl Is TextBox Then
                        Dim txt As TextBox = DirectCast(clonedCtrl, TextBox)
                        txt.ReadOnly = False
                        txt.BackColor = Color.White
                        ' Wire up event handler to update preview
                        AddHandler txt.TextChanged, AddressOf Panel2Control_TextChanged
                    ElseIf TypeOf clonedCtrl Is DateTimePicker Then
                        Dim dtp As DateTimePicker = DirectCast(clonedCtrl, DateTimePicker)
                        dtp.Enabled = True
                        AddHandler dtp.ValueChanged, AddressOf Panel2Control_TextChanged
                    ElseIf TypeOf clonedCtrl Is ComboBox Then
                        Dim cmb As ComboBox = DirectCast(clonedCtrl, ComboBox)
                        cmb.Enabled = True
                        AddHandler cmb.SelectedIndexChanged, AddressOf Panel2Control_TextChanged
                    End If

                    panelFormFields.Controls.Add(clonedCtrl)
                End If
            Next

            ' Update preview after loading Panel2 controls
            UpdatePreviewFromPanel2()
        Catch ex As Exception
            MessageBox.Show("Error loading certificate form controls: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CloneControl(source As Control) As Control
        Try
            If TypeOf source Is TextBox Then
                Dim src As TextBox = DirectCast(source, TextBox)
                Dim clone As New TextBox()
                clone.Name = src.Name
                clone.Text = src.Text
                clone.Size = src.Size
                clone.Font = src.Font
                clone.Location = src.Location
                clone.BackColor = src.BackColor
                clone.ForeColor = src.ForeColor
                Return clone
            ElseIf TypeOf source Is Label Then
                Dim src As Label = DirectCast(source, Label)
                Dim clone As New Label()
                clone.Name = src.Name
                clone.Text = src.Text
                clone.Size = src.Size
                clone.Font = src.Font
                clone.ForeColor = src.ForeColor
                clone.AutoSize = src.AutoSize
                clone.Location = src.Location
                Return clone
            ElseIf TypeOf source Is DateTimePicker Then
                Dim src As DateTimePicker = DirectCast(source, DateTimePicker)
                Dim clone As New DateTimePicker()
                clone.Name = src.Name
                clone.Value = src.Value
                clone.Format = src.Format
                clone.Size = src.Size
                clone.Font = src.Font
                clone.Location = src.Location
                Return clone
            ElseIf TypeOf source Is ComboBox Then
                Dim src As ComboBox = DirectCast(source, ComboBox)
                Dim clone As New ComboBox()
                clone.Name = src.Name
                clone.DropDownStyle = src.DropDownStyle
                clone.Items.AddRange(src.Items.Cast(Of Object)().ToArray())
                clone.Size = src.Size
                clone.Font = src.Font
                clone.Location = src.Location
                If src.SelectedIndex >= 0 Then
                    clone.SelectedIndex = src.SelectedIndex
                End If
                Return clone
            End If
        Catch ex As Exception
            ' Return Nothing if cloning fails
        End Try
        Return Nothing
    End Function

    Private Sub Panel2Control_TextChanged(sender As Object, e As EventArgs)
        ' Update the preview display textboxes based on the changed control
        UpdatePreviewFromPanel2()
    End Sub

    Private Sub UpdatePreviewFromPanel2()
        If currentCertForm Is Nothing Then Return

        Try
            ' Find Panel1 in the certificate form (contains display textboxes)
            Dim panel1 As Panel = Nothing
            For Each ctrl As Control In currentCertForm.Controls
                If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Panel1" Then
                    panel1 = DirectCast(ctrl, Panel)
                    Exit For
                End If
            Next

            If panel1 Is Nothing Then Return

            ' Get all Panel2 input controls from panelFormFields
            Dim panel2Controls As New Dictionary(Of String, Control)
            For Each ctrl As Control In panelFormFields.Controls
                Dim ctrlName As String = ctrl.Name
                If (ctrlName.StartsWith("txt") OrElse ctrlName.StartsWith("cmb") OrElse ctrlName.StartsWith("dtp")) AndAlso 
                   Not (ctrl Is cmbCertificateType) Then
                    panel2Controls(ctrlName) = ctrl
                End If
            Next

            ' Update display textboxes based on Panel2 values
            ' Map txt1 -> display1, txt2 -> display2, etc.
            For Each displayCtrl As Control In panel1.Controls
                If TypeOf displayCtrl Is TextBox AndAlso displayCtrl.Name.StartsWith("display") Then
                    Dim displayTxt As TextBox = DirectCast(displayCtrl, TextBox)
                    Dim displayName As String = displayCtrl.Name
                    
                    ' Try to find matching Panel2 control
                    ' Pattern: display1 -> txt1, display2 -> txt2, displayday -> dtp with day, etc.
                    Dim numericPart As String = displayName.Replace("display", "").ToLower()
                    Dim possibleNames As New List(Of String)

                    ' Direct numeric mapping: display1 -> txt1
                    If numericPart.All(AddressOf Char.IsDigit) Then
                    possibleNames.Add("txt" & numericPart)
                        possibleNames.Add("cmb" & numericPart)
                        possibleNames.Add("dtp" & numericPart)
                    End If

                    ' Special cases for date fields
                    If displayName.ToLower().Contains("day") Then
                        ' Find any DateTimePicker in Panel2
                        For Each kvp As KeyValuePair(Of String, Control) In panel2Controls
                            If TypeOf kvp.Value Is DateTimePicker Then
                                Dim dtp As DateTimePicker = DirectCast(kvp.Value, DateTimePicker)
                                displayTxt.Text = dtp.Value.Day.ToString()
                                Exit For
                            End If
                        Next
                    ElseIf displayName.ToLower().Contains("month") Then
                        For Each kvp As KeyValuePair(Of String, Control) In panel2Controls
                            If TypeOf kvp.Value Is DateTimePicker Then
                                Dim dtp As DateTimePicker = DirectCast(kvp.Value, DateTimePicker)
                                displayTxt.Text = dtp.Value.ToString("MMMM")
                                Exit For
                            End If
                        Next
                    ElseIf displayName.ToLower().Contains("year") Then
                        For Each kvp As KeyValuePair(Of String, Control) In panel2Controls
                            If TypeOf kvp.Value Is DateTimePicker Then
                                Dim dtp As DateTimePicker = DirectCast(kvp.Value, DateTimePicker)
                                displayTxt.Text = dtp.Value.Year.ToString()
                                Exit For
                            End If
                        Next
                    Else
                        ' Try numeric mapping first
                        If numericPart.All(AddressOf Char.IsDigit) Then
                            possibleNames.Add("txt" & numericPart)
                            possibleNames.Add("cmb" & numericPart)
                            possibleNames.Add("dtp" & numericPart)
                        End If
                    
                    ' Also try patterns like display1_2 -> txt1_2 or txt1
                    If displayName.Contains("_") Then
                        Dim parts() As String = displayName.Split("_"c)
                        For Each part As String In parts
                                Dim cleanPart As String = part.Replace("display", "").Trim()
                                If cleanPart.All(AddressOf Char.IsDigit) AndAlso Not String.IsNullOrEmpty(cleanPart) Then
                                    possibleNames.Add("txt" & cleanPart)
                                    possibleNames.Add("cmb" & cleanPart)
                                    possibleNames.Add("dtp" & cleanPart)
                            End If
                        Next
                    End If

                    ' Try to find a match
                        Dim foundMatch As Boolean = False
                    For Each possibleName As String In possibleNames
                        If panel2Controls.ContainsKey(possibleName) Then
                            Dim sourceCtrl As Control = panel2Controls(possibleName)
                            If TypeOf sourceCtrl Is TextBox Then
                                    Dim txt As TextBox = DirectCast(sourceCtrl, TextBox)
                                    If Not String.IsNullOrWhiteSpace(txt.Text) Then
                                        displayTxt.Text = txt.Text
                                        foundMatch = True
                                Exit For
                                    End If
                            ElseIf TypeOf sourceCtrl Is DateTimePicker Then
                                Dim dtp As DateTimePicker = DirectCast(sourceCtrl, DateTimePicker)
                                    displayTxt.Text = dtp.Value.ToString("MM/dd/yyyy")
                                    foundMatch = True
                                Exit For
                            ElseIf TypeOf sourceCtrl Is ComboBox Then
                                Dim cmb As ComboBox = DirectCast(sourceCtrl, ComboBox)
                                    If cmb.SelectedItem IsNot Nothing Then
                                        displayTxt.Text = cmb.SelectedItem.ToString()
                                        foundMatch = True
                                Exit For
                                    End If
                            End If
                        End If
                    Next

                        ' If no match found and display textbox is empty, keep it empty
                        If Not foundMatch AndAlso String.IsNullOrWhiteSpace(displayTxt.Text) Then
                            ' Leave empty - don't set placeholder text
                        End If
                    End If
                End If
            Next

            ' Also update based on main form fields (name, age, address, etc.)
            UpdateMainFieldsToPreview(panel1)

            ' Style preview to show only text (transparent labels over the certificate)
            ApplyPreviewStyling(panel1)

            ' Refresh the preview picturebox with overlays
            RefreshPreviewImage(panel1)
        Catch ex As Exception
            ' Silently handle errors to avoid disrupting user input
        End Try
    End Sub

    Private Sub RefreshPreviewImage(panel1 As Panel)
        ' Update the preview by overlaying transparent labels on the certificate image
        ' Find the active certificate picturebox
        Dim activePicBox As PictureBox = Nothing
        If certResidency.Visible Then
            activePicBox = certResidency
        ElseIf certAnnual.Visible Then
            activePicBox = certAnnual
        ElseIf certCC.Visible Then
            activePicBox = certCC
        ElseIf certSC.Visible Then
            activePicBox = certSC
        End If

        If activePicBox Is Nothing OrElse panel1 Is Nothing OrElse activePicBox.Image Is Nothing Then Return

        ' Clear existing overlay labels
        Dim overlaysToRemove As New List(Of Control)
        For Each ctrl As Control In pnlPic.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Name.StartsWith("preview_") Then
                overlaysToRemove.Add(ctrl)
            End If
        Next
        For Each ctrl As Control In overlaysToRemove
            pnlPic.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        ' Get the actual image dimensions
        Dim imageWidth As Integer = activePicBox.Image.Width
        Dim imageHeight As Integer = activePicBox.Image.Height

        ' Get the PictureBox1 from Panel1 (the original certificate image container)
        Dim originalPicBox As PictureBox = Nothing
        For Each ctrl As Control In panel1.Controls
            If TypeOf ctrl Is PictureBox Then
                originalPicBox = DirectCast(ctrl, PictureBox)
                Exit For
            End If
        Next

        If originalPicBox Is Nothing Then Return

        ' Calculate scale factor based on actual image dimensions
        ' Use originalPicBox dimensions if available, otherwise use panel1
        Dim sourceWidth As Integer = If(originalPicBox IsNot Nothing, originalPicBox.Width, panel1.Width)
        Dim sourceHeight As Integer = If(originalPicBox IsNot Nothing, originalPicBox.Height, panel1.Height)

        Dim scaleX As Double = activePicBox.Width / CDbl(sourceWidth)
        Dim scaleY As Double = activePicBox.Height / CDbl(sourceHeight)

        ' Use the average scale for font size to maintain readability
        Dim scale As Double = (scaleX + scaleY) / 2.0

        ' Create overlay labels for each display textbox and overlay label
        For Each displayCtrl As Control In panel1.Controls
            Dim displayText As String = ""
            Dim displayLocation As Point = Point.Empty
            Dim displaySize As Size = Size.Empty
            Dim useFont As Font = Nothing

            If TypeOf displayCtrl Is TextBox AndAlso displayCtrl.Name.StartsWith("display") Then
                Dim displayTxt As TextBox = DirectCast(displayCtrl, TextBox)
                displayText = displayTxt.Text
                displayLocation = displayTxt.Location
                displaySize = displayTxt.Size
                ' Use Times New Roman to match certificate font style
                Dim baseFontSize As Single = 9.5F
                Dim scaledFontSize As Single = baseFontSize * CSng(scale)
                If scaledFontSize < 7.0F Then scaledFontSize = 7.0F
                If scaledFontSize > 16.0F Then scaledFontSize = 16.0F
                useFont = New Font("Times New Roman", scaledFontSize, FontStyle.Regular, GraphicsUnit.Point)
            ElseIf TypeOf displayCtrl Is Label AndAlso displayCtrl.Name.StartsWith("overlay_") Then
                Dim overlayLabel As Label = DirectCast(displayCtrl, Label)
                displayText = overlayLabel.Text
                displayLocation = overlayLabel.Location
                displaySize = overlayLabel.Size
                useFont = overlayLabel.Font
                ' Scale the font
                If useFont IsNot Nothing Then
                    Dim scaledFontSize As Single = useFont.Size * CSng(scale)
                    If scaledFontSize < 7.0F Then scaledFontSize = 7.0F
                    If scaledFontSize > 16.0F Then scaledFontSize = 16.0F
                    useFont = New Font(useFont.FontFamily, scaledFontSize, useFont.Style, GraphicsUnit.Point)
                End If
            End If

            ' Only create overlay if there's text to display
            If Not String.IsNullOrWhiteSpace(displayText) AndAlso useFont IsNot Nothing Then
                ' Create transparent label overlay with proper transparency settings
                Dim overlay As New Label()
                overlay.Name = "preview_" & displayCtrl.Name
                overlay.AutoSize = False
                overlay.BackColor = Color.Transparent
                overlay.ForeColor = Color.Black
                overlay.Text = displayText
                overlay.TextAlign = ContentAlignment.MiddleCenter
                overlay.Font = useFont
                overlay.UseCompatibleTextRendering = True
                
                ' Ensure transparency by setting parent and using proper control hierarchy
                overlay.Parent = pnlPic
                overlay.BackColor = Color.Transparent
                ' Transparency works automatically when BackColor is Transparent and Parent is set correctly

                ' Scale position and size from certificate form Panel1 to preview PictureBox
                ' Account for PictureBox location within pnlPic
                ' Ensure text fits within the blank area only - don't exceed the original size
                Dim scaledWidth As Integer = CInt(displaySize.Width * scaleX)
                Dim scaledHeight As Integer = CInt(displaySize.Height * scaleY)
                
                ' Limit size to fit within the blank area - don't allow text to overflow
                overlay.Location = New Point(
                    activePicBox.Left + CInt(displayLocation.X * scaleX),
                    activePicBox.Top + CInt(displayLocation.Y * scaleY)
                )
                overlay.Size = New Size(scaledWidth, scaledHeight)
                
                ' Iteratively adjust font size to ensure text fits within blank area
                Dim currentFont As Font = useFont
                Dim minFontSize As Single = 6.0F
                Dim maxIterations As Integer = 10
                Dim iteration As Integer = 0
                Dim textFits As Boolean = False
                
                While Not textFits AndAlso iteration < maxIterations AndAlso currentFont.Size >= minFontSize
                    ' Measure text with current font size
                    Dim textSize As Size = TextRenderer.MeasureText(displayText, currentFont, overlay.Size, TextFormatFlags.WordBreak Or TextFormatFlags.NoPadding)
                    
                    ' Check if text fits within the exact blank size (use minimal margin)
                    Dim widthMargin As Integer = Math.Max(1, CInt(scaledWidth * 0.02F))
                    Dim heightMargin As Integer = Math.Max(1, CInt(scaledHeight * 0.02F))
                    
                    If textSize.Width <= (scaledWidth - widthMargin) AndAlso textSize.Height <= (scaledHeight - heightMargin) Then
                        textFits = True
                    Else
                        ' Calculate scale factor needed to fit exactly within blank size
                        Dim widthRatio As Single = (scaledWidth - widthMargin) / CSng(textSize.Width)
                        Dim heightRatio As Single = (scaledHeight - heightMargin) / CSng(textSize.Height)
                        Dim scaleFactor As Single = Math.Min(widthRatio, heightRatio) * 0.98F ' Use 98% to maximize text size while ensuring fit
                        
                        ' Reduce font size
                        Dim newSize As Single = currentFont.Size * scaleFactor
                        If newSize < minFontSize Then
                            newSize = minFontSize
                            textFits = True ' Stop if we hit minimum
                        End If
                        
                        currentFont = New Font(currentFont.FontFamily, newSize, currentFont.Style, GraphicsUnit.Point)
                        iteration += 1
                    End If
                End While
                
                ' Apply the final font that fits
                overlay.Font = currentFont
                
                ' Set clipping to ensure text doesn't overflow the blank area
                overlay.Region = New Region(New Rectangle(0, 0, scaledWidth, scaledHeight))

                pnlPic.Controls.Add(overlay)
                overlay.BringToFront()
            End If
        Next

        ' Ensure picturebox is behind overlays
        activePicBox.SendToBack()
    End Sub

    Private Sub ApplyPreviewStyling(panel1 As Panel)
        ' Replace display TextBoxes with transparent Labels using Times New Roman to match certificate font
        For Each ctrl As Control In panel1.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name.StartsWith("display") Then
                Dim displayTxt As TextBox = DirectCast(ctrl, TextBox)

                ' Find or create overlay label
                Dim overlayName As String = "overlay_" & displayTxt.Name
                Dim overlay As Label = Nothing
                For Each c As Control In panel1.Controls
                    If TypeOf c Is Label AndAlso c.Name = overlayName Then
                        overlay = DirectCast(c, Label)
                        Exit For
                    End If
                Next

                If overlay Is Nothing Then
                    overlay = New Label()
                    overlay.Name = overlayName
                    overlay.AutoSize = False
                    overlay.BackColor = Color.Transparent
                    overlay.TextAlign = ContentAlignment.MiddleCenter
                    panel1.Controls.Add(overlay)
                End If

                ' Sync position/size and content
                overlay.Location = displayTxt.Location
                overlay.Size = displayTxt.Size
                ' Use Times New Roman to match certificate font style, 11pt for body text
                overlay.Font = New Font("Times New Roman", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
                overlay.ForeColor = Color.Black
                overlay.Text = displayTxt.Text
                overlay.BackColor = Color.Transparent
                overlay.UseCompatibleTextRendering = True
                overlay.BringToFront()

                ' Hide original textbox to show only text
                displayTxt.Visible = False
            End If
        Next
    End Sub

    Private Sub UpdateMainFieldsToPreview(panel1 As Panel)
        ' Base form fields have been removed - all data now comes from Panel2 controls
        ' This method is kept for compatibility but no longer needs to do anything
        ' All mapping is now handled in UpdatePreviewFromPanel2()
    End Sub

    Private Sub panelRightHeader_Paint(sender As Object, e As PaintEventArgs) Handles panelRightHeader.Paint

    End Sub

    ' Base form field event handlers removed - form now uses Panel2 controls dynamically
    ' All event handling is done through Panel2Control_TextChanged handlers

    Private Sub panelButtons_Paint(sender As Object, e As PaintEventArgs) Handles panelButtons.Paint

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Clear the form and close
        ClearForm()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate form data first
        If Not ValidateFormData() Then Return

        ' Save to database
        If Not SaveCertificateToDatabase() Then
            MessageBox.Show("Failed to save certificate data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Generate PNG
        Try
            GeneratePNG()
            MessageBox.Show("Certificate saved and PNG generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Ask if user wants to clear the form
            Dim result As DialogResult = MessageBox.Show("Clear the form for the next entry?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ClearForm()
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating PNG: " & ex.Message, "PNG Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GeneratePNG()
        ' Get the active picturebox
        Dim activePicBox As PictureBox = Nothing
        If certResidency.Visible Then
            activePicBox = certResidency
        ElseIf certAnnual.Visible Then
            activePicBox = certAnnual
        ElseIf certCC.Visible Then
            activePicBox = certCC
        ElseIf certSC.Visible Then
            activePicBox = certSC
        End If

        If activePicBox Is Nothing OrElse activePicBox.Image Is Nothing Then
            Throw New Exception("No certificate image selected")
        End If

        ' Create save file dialog
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Image files (*.png)|*.png|All files (*.*)|*.*"
            saveDialog.FilterIndex = 1
            ' Get name from Panel2 if available, otherwise use generic name
            Dim nameForFile As String = "Certificate"
            Dim txtNameCtrl As Control = FindPanel2Control("txt1")
            If txtNameCtrl Is Nothing Then txtNameCtrl = FindPanel2Control("txtfullname")
            If txtNameCtrl IsNot Nothing AndAlso TypeOf txtNameCtrl Is TextBox Then
                Dim nameText As String = DirectCast(txtNameCtrl, TextBox).Text
                If Not String.IsNullOrWhiteSpace(nameText) Then
                    nameForFile = nameText.Replace(" ", "_")
                End If
            End If
            Dim certType As String = If(cmbCertificateType.SelectedItem IsNot Nothing, cmbCertificateType.SelectedItem.ToString().Replace(" ", "_"), "Certificate")
            saveDialog.FileName = $"{certType}_{nameForFile}_{DateTime.Now:yyyyMMdd}"
            saveDialog.Title = "Save Certificate"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim filePath As String = saveDialog.FileName
                    Dim fileExtension As String = System.IO.Path.GetExtension(filePath).ToLower()
                    
                    ' Get the original certificate form to find Panel1 for accurate positioning
                    Dim certForm As Form = currentCertForm
                    Dim panel1 As Panel = Nothing
                    If certForm IsNot Nothing Then
                        For Each ctrl As Control In certForm.Controls
                            If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Panel1" Then
                                panel1 = DirectCast(ctrl, Panel)
                                Exit For
                            End If
                        Next
                    End If
                    
                    ' Get original image dimensions
                    Dim originalImage As Image = activePicBox.Image
                    If originalImage Is Nothing Then
                        Throw New Exception("Certificate image not found")
                    End If
                    
                    ' Create a bitmap using the original image size for best quality
                    Dim bmp As New Bitmap(originalImage.Width, originalImage.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                        
                        ' Draw the certificate image at full size
                        g.DrawImage(originalImage, 0, 0, originalImage.Width, originalImage.Height)
                        
                        ' Draw all overlay labels on top - get values from Panel2 controls and positions from Panel1
                        If panel1 IsNot Nothing Then
                            ' Get Panel2 controls to retrieve actual input values
                            Dim panel2Controls As New Dictionary(Of String, Control)
                            If currentPanel2 IsNot Nothing Then
                                For Each ctrl As Control In currentPanel2.Controls
                                    If Not String.IsNullOrEmpty(ctrl.Name) Then
                                        panel2Controls(ctrl.Name) = ctrl
                                    End If
                                Next
                            End If
                            
                            ' Also get values from cloned Panel2 controls in panelFormFields
                            For Each ctrl As Control In panelFormFields.Controls
                                If Not String.IsNullOrEmpty(ctrl.Name) AndAlso Not panel2Controls.ContainsKey(ctrl.Name) Then
                                    panel2Controls(ctrl.Name) = ctrl
                                End If
                            Next
                            
                            ' Find display textboxes in Panel1 to get original positions, then get values from Panel2
                            For Each displayCtrl As Control In panel1.Controls
                                Dim displayText As String = ""
                                Dim displayLocation As Point = Point.Empty
                                Dim displaySize As Size = Size.Empty
                                Dim useFont As Font = Nothing
                                
                                If TypeOf displayCtrl Is TextBox AndAlso displayCtrl.Name.StartsWith("display") Then
                                    Dim displayTxt As TextBox = DirectCast(displayCtrl, TextBox)
                                    displayLocation = displayTxt.Location
                                    displaySize = displayTxt.Size
                                    
                                    ' Get value from Panel2 control using the same mapping logic as UpdatePreviewFromPanel2
                                    Dim baseName As String = displayTxt.Name.Replace("display", "").ToLower()
                                    Dim possibleNames As New List(Of String)
                                    possibleNames.Add(baseName)
                                    
                                    ' Try common variations
                                    If baseName.Contains("name") OrElse baseName.Contains("fullname") Then
                                        possibleNames.Add("txt1")
                                        possibleNames.Add("txtfullname")
                                        possibleNames.Add("txtname")
                                    End If
                                    If baseName.Contains("age") Then
                                        possibleNames.Add("txtage")
                                    End If
                                    If baseName.Contains("address") Then
                                        possibleNames.Add("txtaddress")
                                    End If
                                    If baseName.Contains("purpose") Then
                                        possibleNames.Add("txtpurpose")
                                    End If
                                    If baseName.Contains("day") Then
                                        possibleNames.Add("displayday")
                                        possibleNames.Add("txtday")
                                    End If
                                    If baseName.Contains("month") Then
                                        possibleNames.Add("displaymonth")
                                        possibleNames.Add("txtmonth")
                                    End If
                                    If baseName.Contains("year") Then
                                        possibleNames.Add("displayyear")
                                        possibleNames.Add("txtyear")
                                    End If
                                    
                                    ' Also try with txt/cmb/dtp prefix
                                    If baseName.Length > 0 Then
                                        Dim cleanPart As String = baseName
                                        If cleanPart.StartsWith("txt") OrElse cleanPart.StartsWith("cmb") OrElse cleanPart.StartsWith("dtp") Then
                                            cleanPart = cleanPart.Substring(3)
                                        End If
                                        If cleanPart.Length > 0 Then
                                            possibleNames.Add("txt" & cleanPart)
                                            possibleNames.Add("cmb" & cleanPart)
                                            possibleNames.Add("dtp" & cleanPart)
                                        End If
                                    End If
                                    
                                    ' Try to find a match in Panel2
                                    For Each possibleName As String In possibleNames
                                        If panel2Controls.ContainsKey(possibleName) Then
                                            Dim sourceCtrl As Control = panel2Controls(possibleName)
                                            If TypeOf sourceCtrl Is TextBox Then
                                                Dim txt As TextBox = DirectCast(sourceCtrl, TextBox)
                                                If Not String.IsNullOrWhiteSpace(txt.Text) Then
                                                    displayText = txt.Text
                                                    Exit For
                                                End If
                                            ElseIf TypeOf sourceCtrl Is DateTimePicker Then
                                                Dim dtp As DateTimePicker = DirectCast(sourceCtrl, DateTimePicker)
                                                displayText = dtp.Value.ToString("MM/dd/yyyy")
                                                Exit For
                                            ElseIf TypeOf sourceCtrl Is ComboBox Then
                                                Dim cmb As ComboBox = DirectCast(sourceCtrl, ComboBox)
                                                If cmb.SelectedItem IsNot Nothing Then
                                                    displayText = cmb.SelectedItem.ToString()
                                                    Exit For
                                                End If
                                            End If
                                        End If
                                    Next
                                    
                                    ' Use smaller font size to match preview
                                    useFont = New Font("Times New Roman", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
                                ElseIf TypeOf displayCtrl Is Label AndAlso displayCtrl.Name.StartsWith("overlay_") Then
                                    Dim overlayLabel As Label = DirectCast(displayCtrl, Label)
                                    displayText = overlayLabel.Text
                                    displayLocation = overlayLabel.Location
                                    displaySize = overlayLabel.Size
                                    useFont = overlayLabel.Font
                                    ' Scale down font if it's too large
                                    If useFont IsNot Nothing AndAlso useFont.Size > 9.5F Then
                                        useFont = New Font(useFont.FontFamily, 9.5F, useFont.Style, GraphicsUnit.Point)
                                    End If
                                End If
                                
                                If Not String.IsNullOrWhiteSpace(displayText) AndAlso useFont IsNot Nothing Then
                                    ' Use original positions from Panel1 (no scaling needed for final image)
                                    Dim textRect As New Rectangle(displayLocation.X, displayLocation.Y, displaySize.Width, displaySize.Height)
                                    
                                    ' Create a clipping region to ensure text doesn't overflow
                                    Dim originalClip As Region = g.Clip
                                    g.SetClip(textRect)
                                    
                                    Dim sf As New StringFormat()
                                    sf.Alignment = StringAlignment.Center
                                    sf.LineAlignment = StringAlignment.Center
                                    sf.Trimming = StringTrimming.EllipsisCharacter
                                    sf.FormatFlags = StringFormatFlags.NoWrap
                                    
                                    ' Iteratively adjust font size to ensure text fits within blank area
                                    Dim currentFont As Font = useFont
                                    Dim minFontSize As Single = 6.0F
                                    Dim maxIterations As Integer = 10
                                    Dim iteration As Integer = 0
                                    Dim textFits As Boolean = False
                                    Dim finalTextSize As SizeF = SizeF.Empty
                                    
                                    While Not textFits AndAlso iteration < maxIterations AndAlso currentFont.Size >= minFontSize
                                        ' Measure text with current font size
                                        finalTextSize = g.MeasureString(displayText, currentFont, textRect.Width, sf)
                                        
                                        ' Check if text fits within the exact blank size (use minimal margin)
                                        Dim widthMargin As Single = Math.Max(1.0F, textRect.Width * 0.02F)
                                        Dim heightMargin As Single = Math.Max(1.0F, textRect.Height * 0.02F)
                                        
                                        If finalTextSize.Width <= (textRect.Width - widthMargin) AndAlso finalTextSize.Height <= (textRect.Height - heightMargin) Then
                                            textFits = True
                                        Else
                                            ' Calculate scale factor needed to fit exactly within blank size
                                            Dim widthRatio As Single = (textRect.Width - widthMargin) / finalTextSize.Width
                                            Dim heightRatio As Single = (textRect.Height - heightMargin) / finalTextSize.Height
                                            Dim scaleFactor As Single = Math.Min(widthRatio, heightRatio) * 0.98F ' Use 98% to maximize text size while ensuring fit
                                            
                                            ' Reduce font size
                                            Dim newSize As Single = currentFont.Size * scaleFactor
                                            If newSize < minFontSize Then
                                                newSize = minFontSize
                                                textFits = True ' Stop if we hit minimum
                                            End If
                                            
                                            currentFont = New Font(currentFont.FontFamily, newSize, currentFont.Style, GraphicsUnit.Point)
                                            iteration += 1
                                        End If
                                    End While
                                    
                                    ' Use the final font that fits
                                    useFont = currentFont
                                    finalTextSize = g.MeasureString(displayText, useFont, textRect.Width, sf)
                                    
                                    ' Draw text within the bounds to prevent overflow
                                    Using brush As New SolidBrush(Color.Black)
                                        g.DrawString(displayText, useFont, brush, textRect, sf)
                                    End Using
                                    
                                    ' Restore original clip
                                    g.Clip = originalClip
                                End If
                            Next
                        End If
                    End Using
                    
                    ' Ensure file has .png extension
                    Dim finalPath As String = filePath
                    If Not fileExtension = ".png" Then
                        finalPath = System.IO.Path.ChangeExtension(filePath, ".png")
                    End If
                    
                    If Not String.IsNullOrEmpty(finalPath) Then
                        ' Ensure directory exists
                        Dim directory As String = System.IO.Path.GetDirectoryName(finalPath)
                        If Not String.IsNullOrEmpty(directory) AndAlso Not System.IO.Directory.Exists(directory) Then
                            System.IO.Directory.CreateDirectory(directory)
                        End If
                        
                        ' Save the image as PNG
                        bmp.Save(finalPath, Imaging.ImageFormat.Png)
                        
                        ' Show success message
                        MessageBox.Show("Certificate saved successfully at: " & finalPath, "Certificate Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Throw New Exception("Invalid file path")
                    End If
                    
                    ' Dispose bitmap after saving
                    bmp.Dispose()
                Catch ex As Exception
                    Throw New Exception("Error saving certificate: " & ex.Message, ex)
                End Try
            End If
        End Using
    End Sub
End Class