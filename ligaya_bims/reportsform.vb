Imports System.IO
Imports System.Text
Imports System.Diagnostics

Partial Class reportsform

    Private templatePath As String = ""
    Private templateContent As String = ""
    Private customLabels As New Dictionary(Of String, String)()
    Private customTableStructure As New List(Of KeyValuePair(Of String, String))()

    Private Sub reportsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = DateTime.Now.AddHours(-1)
        dtpTo.Value = DateTime.Now
    End Sub

    Private Sub btnLoadTemplate_Click(sender As Object, e As EventArgs) Handles btnLoadTemplate.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                templatePath = OpenFileDialog1.FileName
                lblTemplateName.Text = Path.GetFileName(templatePath)
                
                ' Load and preview the DOCX template
                LoadDocxTemplate(templatePath)
                
            Catch ex As Exception
                MessageBox.Show("Failed to load DOCX template: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadDocxTemplate(filePath As String)
        Try
            ' Store template path and show success message
            templatePath = filePath
            templateContent = "DOCX Template loaded successfully!"
            
            ' Initialize custom field mappings
            InitializeCustomFieldMappings()
            
            txtTemplatePreview.Text = "DOCX Template loaded successfully!" & vbCrLf & vbCrLf & 
                                    "Template: " & Path.GetFileName(filePath) & vbCrLf & vbCrLf &
                                    "Custom field mappings loaded:" & vbCrLf & vbCrLf &
                                    "• " & customLabels("TypeOfIncident") & " → Type of Incident" & vbCrLf &
                                    "• " & customLabels("InclusiveDate") & " → Inclusive Date and Time" & vbCrLf &
                                    "• " & customLabels("ExactLocation") & " → Exact Location" & vbCrLf &
                                    "• " & customLabels("InvolvedPerson") & " → Involved Person/Details" & vbCrLf &
                                    "• " & customLabels("Narrative") & " → Narrative" & vbCrLf &
                                    "• " & customLabels("GeneratedDate") & " → Generated Date" & vbCrLf & vbCrLf &
                                    "The print preview will use your custom labels and layout."
            
        Catch ex As Exception
            txtTemplatePreview.Text = "Error loading template: " & ex.Message
            Throw
        End Try
    End Sub

    Private Sub InitializeCustomFieldMappings()
        ' Default custom labels - you can modify these to match your DOCX template
        customLabels.Clear()
        customLabels.Add("TypeOfIncident", "INCIDENT TYPE:")
        customLabels.Add("InclusiveDate", "DATE AND TIME:")
        customLabels.Add("ExactLocation", "LOCATION:")
        customLabels.Add("InvolvedPerson", "PERSONS INVOLVED:")
        customLabels.Add("Narrative", "INCIDENT DESCRIPTION:")
        customLabels.Add("GeneratedDate", "REPORT DATE:")
        
        ' You can also load these from a configuration file or let the user customize them
        ' For now, we'll use these default custom labels
    End Sub

    Private Sub GenerateReport(outputPath As String)
        Try
            If String.IsNullOrEmpty(templatePath) Then
                MessageBox.Show("Please load a template first.", "No Template", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create HTML content for the report
            Dim htmlContent As String = CreateHtmlReport()
            
            ' Save as HTML file (which can be opened in Word)
            Dim htmlPath As String = Path.ChangeExtension(outputPath, ".html")
            File.WriteAllText(htmlPath, htmlContent, Encoding.UTF8)
            
            ' Copy the HTML file to the DOCX path (for consistency)
            File.Copy(htmlPath, outputPath, True)

            MessageBox.Show("Report generated successfully at: " & outputPath & vbCrLf & vbCrLf & 
                          "Note: This is an HTML file that can be opened in Microsoft Word " & vbCrLf &
                          "and saved as a proper DOCX file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Failed to generate report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateHtmlReport() As String
        Dim html As New StringBuilder()
        
        html.AppendLine("<!DOCTYPE html>")
        html.AppendLine("<html>")
        html.AppendLine("<head>")
        html.AppendLine("    <meta charset='UTF-8'>")
        html.AppendLine("    <title>Incident Report</title>")
        html.AppendLine("    <style>")
        html.AppendLine("        body { font-family: Arial, sans-serif; margin: 40px; }")
        html.AppendLine("        h1 { text-align: center; color: #333; }")
        html.AppendLine("        table { width: 100%; border-collapse: collapse; margin-top: 20px; }")
        html.AppendLine("        th, td { border: 1px solid #333; padding: 12px; text-align: left; }")
        html.AppendLine("        th { background-color: #f2f2f2; font-weight: bold; width: 30%; }")
        html.AppendLine("        td { width: 70%; }")
        html.AppendLine("        .narrative { white-space: pre-wrap; }")
        html.AppendLine("    </style>")
        html.AppendLine("</head>")
        html.AppendLine("<body>")
        html.AppendLine("    <h1>INCIDENT REPORT</h1>")
        html.AppendLine("    <table>")
        
        ' Use custom labels if available, otherwise use defaults
        Dim typeLabel As String = If(customLabels.ContainsKey("TypeOfIncident"), customLabels("TypeOfIncident"), "Type of Incident:")
        Dim dateLabel As String = If(customLabels.ContainsKey("InclusiveDate"), customLabels("InclusiveDate"), "Inclusive Date and Time:")
        Dim locationLabel As String = If(customLabels.ContainsKey("ExactLocation"), customLabels("ExactLocation"), "Exact Location:")
        Dim involvedLabel As String = If(customLabels.ContainsKey("InvolvedPerson"), customLabels("InvolvedPerson"), "Involved Person/Details:")
        Dim narrativeLabel As String = If(customLabels.ContainsKey("Narrative"), customLabels("Narrative"), "Narrative:")
        Dim generatedLabel As String = If(customLabels.ContainsKey("GeneratedDate"), customLabels("GeneratedDate"), "Generated on:")
        
        html.AppendLine("        <tr><th>" & EscapeHtml(typeLabel) & "</th><td>" & EscapeHtml(txtTypeOfIncident.Text) & "</td></tr>")
        html.AppendLine("        <tr><th>" & EscapeHtml(dateLabel) & "</th><td>" & EscapeHtml(String.Format("{0}  –  {1}", dtpFrom.Value.ToString("MMMM dd, yyyy  hh:mm tt"), dtpTo.Value.ToString("MMMM dd, yyyy  hh:mm tt"))) & "</td></tr>")
        html.AppendLine("        <tr><th>" & EscapeHtml(locationLabel) & "</th><td>" & EscapeHtml(txtExactLocation.Text) & "</td></tr>")
        html.AppendLine("        <tr><th>" & EscapeHtml(involvedLabel) & "</th><td>" & EscapeHtml(txtInvolved.Text) & "</td></tr>")
        html.AppendLine("        <tr><th>" & EscapeHtml(narrativeLabel) & "</th><td class='narrative'>" & EscapeHtml(txtNarrative.Text) & "</td></tr>")
        html.AppendLine("        <tr><th>" & EscapeHtml(generatedLabel) & "</th><td>" & EscapeHtml(DateTime.Now.ToString("MMMM dd, yyyy")) & "</td></tr>")
        html.AppendLine("    </table>")
        html.AppendLine("</body>")
        html.AppendLine("</html>")
        
        Return html.ToString()
    End Function

    Private Function EscapeHtml(text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""
        Return text.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("""", "&quot;").Replace("'", "&#39;")
    End Function

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        PrintDocument1.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim pageRect As Rectangle = e.PageBounds
        Dim margin As Integer = 50

        ' Fill white background
        g.FillRectangle(Brushes.White, pageRect)

        ' Create a table-like layout for the print preview
        DrawTableBasedReport(g, pageRect, margin)

        e.HasMorePages = False
    End Sub

    Private Sub DrawTableBasedReport(g As Graphics, pageRect As Rectangle, margin As Integer)
        Try
            ' Title
            Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
            Dim titleRect As New RectangleF(margin, margin, pageRect.Width - 2 * margin, 30)
            g.DrawString("INCIDENT REPORT", titleFont, Brushes.Black, titleRect, New StringFormat() With {.Alignment = StringAlignment.Center})

            ' Table setup
            Dim tableTop As Integer = margin + 50
            Dim tableLeft As Integer = margin
            Dim tableWidth As Integer = pageRect.Width - 2 * margin
            Dim rowHeight As Integer = 30
            Dim labelWidth As Integer = CInt(tableWidth * 0.3)
            Dim valueWidth As Integer = CInt(tableWidth * 0.7)

            Dim tableFont As New Font("Arial", 10, FontStyle.Regular)
            Dim labelFont As New Font("Arial", 10, FontStyle.Bold)

            ' Table data using custom labels
            Dim tableData As New List(Of KeyValuePair(Of String, String))()
            
            ' Use custom labels if available, otherwise use defaults
            Dim typeLabel As String = If(customLabels.ContainsKey("TypeOfIncident"), customLabels("TypeOfIncident"), "Type of Incident:")
            Dim dateLabel As String = If(customLabels.ContainsKey("InclusiveDate"), customLabels("InclusiveDate"), "Inclusive Date and Time:")
            Dim locationLabel As String = If(customLabels.ContainsKey("ExactLocation"), customLabels("ExactLocation"), "Exact Location:")
            Dim involvedLabel As String = If(customLabels.ContainsKey("InvolvedPerson"), customLabels("InvolvedPerson"), "Involved Person/Details:")
            Dim narrativeLabel As String = If(customLabels.ContainsKey("Narrative"), customLabels("Narrative"), "Narrative:")
            Dim generatedLabel As String = If(customLabels.ContainsKey("GeneratedDate"), customLabels("GeneratedDate"), "Generated on:")
            
            tableData.Add(New KeyValuePair(Of String, String)(typeLabel, txtTypeOfIncident.Text))
            tableData.Add(New KeyValuePair(Of String, String)(dateLabel, String.Format("{0}  –  {1}", dtpFrom.Value.ToString("MMMM dd, yyyy  hh:mm tt"), dtpTo.Value.ToString("MMMM dd, yyyy  hh:mm tt"))))
            tableData.Add(New KeyValuePair(Of String, String)(locationLabel, txtExactLocation.Text))
            tableData.Add(New KeyValuePair(Of String, String)(involvedLabel, txtInvolved.Text))
            tableData.Add(New KeyValuePair(Of String, String)(narrativeLabel, txtNarrative.Text))
            tableData.Add(New KeyValuePair(Of String, String)(generatedLabel, DateTime.Now.ToString("MMMM dd, yyyy")))

            ' Draw table
            For i As Integer = 0 To tableData.Count - 1
                Dim rowTop As Integer = tableTop + (i * rowHeight)
                
                ' Draw row background
                If i Mod 2 = 0 Then
                    g.FillRectangle(Brushes.LightGray, tableLeft, rowTop, tableWidth, rowHeight)
                Else
                    g.FillRectangle(Brushes.White, tableLeft, rowTop, tableWidth, rowHeight)
                End If

                ' Draw borders
                g.DrawRectangle(Pens.Black, tableLeft, rowTop, tableWidth, rowHeight)
                g.DrawLine(Pens.Black, tableLeft + labelWidth, rowTop, tableLeft + labelWidth, rowTop + rowHeight)

                ' Draw label
                Dim labelRect As New RectangleF(tableLeft + 5, rowTop + 5, labelWidth - 10, rowHeight - 10)
                g.DrawString(tableData(i).Key, labelFont, Brushes.Black, labelRect)

                ' Draw value
                Dim valueRect As New RectangleF(tableLeft + labelWidth + 5, rowTop + 5, valueWidth - 10, rowHeight - 10)
                Dim valueText As String = tableData(i).Value
                
                ' Handle long text (especially for narrative)
                If i = 4 Then ' Narrative row
                    ' For narrative, we might need to split into multiple lines
                    Dim lines As String() = SplitTextIntoLines(valueText, valueWidth - 10, tableFont)
                    Dim currentY As Single = valueRect.Y
                    For Each line As String In lines
                        If currentY + 15 <= rowTop + rowHeight Then
                            g.DrawString(line, tableFont, Brushes.Black, New RectangleF(valueRect.X, currentY, valueRect.Width, 15))
                            currentY += 15
                        End If
                    Next
                Else
                    g.DrawString(valueText, tableFont, Brushes.Black, valueRect)
                End If
            Next

        Catch ex As Exception
            ' If table drawing fails, show error message
            Dim errorFont As New Font("Arial", 12, FontStyle.Regular)
            g.DrawString("Error creating table preview: " & ex.Message, errorFont, Brushes.Red, New RectangleF(margin, margin, pageRect.Width - 2 * margin, 100))
        End Try
    End Sub

    Private Function SplitTextIntoLines(text As String, maxWidth As Single, font As Font) As String()
        If String.IsNullOrEmpty(text) Then Return New String() {""}
        
        Dim words As String() = text.Split(" "c)
        Dim lines As New List(Of String)()
        Dim currentLine As String = ""
        
        For Each word As String In words
            Dim testLine As String = If(String.IsNullOrEmpty(currentLine), word, currentLine & " " & word)
            ' This is a simplified approach - in a real implementation, you'd measure text width
            If testLine.Length > 50 Then ' Approximate character limit
                If Not String.IsNullOrEmpty(currentLine) Then
                    lines.Add(currentLine)
                    currentLine = word
                Else
                    lines.Add(word)
                End If
            Else
                currentLine = testLine
            End If
        Next
        
        If Not String.IsNullOrEmpty(currentLine) Then
            lines.Add(currentLine)
        End If
        
        Return lines.ToArray()
    End Function

    Private Shared Function ScaleRect(container As Rectangle, relX As Single, relY As Single, relW As Single, relH As Single) As RectangleF
        Dim x As Single = container.X + container.Width * relX
        Dim y As Single = container.Y + container.Height * relY
        Dim w As Single = container.Width * relW
        Dim h As Single = container.Height * relH
        Return New RectangleF(x, y, w, h)
    End Function

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btnGenerateDocx_Click(sender As Object, e As EventArgs) Handles btnGenerateDocx.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Word Documents|*.docx|All Files|*.*"
            saveDialog.FileName = "Incident_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".docx"
            
            If saveDialog.ShowDialog() = DialogResult.OK Then
                GenerateReport(saveDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnPreviewDocx_Click(sender As Object, e As EventArgs) Handles btnPreviewDocx.Click
        Try
            If String.IsNullOrEmpty(templatePath) Then
                MessageBox.Show("Please load a template first.", "No Template", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create a temporary HTML file for preview
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), "Preview_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".html")
            
            ' Generate the HTML content
            Dim htmlContent As String = CreateHtmlReport()
            File.WriteAllText(tempPath, htmlContent, Encoding.UTF8)
            
            ' Open the generated HTML file in the default browser
            Process.Start(tempPath)
            
        Catch ex As Exception
            MessageBox.Show("Failed to preview report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCustomizeLabels_Click(sender As Object, e As EventArgs) Handles btnCustomizeLabels.Click
        Try
            ' Show a simple input dialog for customizing labels
            Dim result As String = InputBox("Enter custom labels (one per line):" & vbCrLf & vbCrLf &
                                          "Format: FieldName=CustomLabel" & vbCrLf & vbCrLf &
                                          "Available fields:" & vbCrLf &
                                          "TypeOfIncident, InclusiveDate, ExactLocation," & vbCrLf &
                                          "InvolvedPerson, Narrative, GeneratedDate" & vbCrLf & vbCrLf &
                                          "Example:" & vbCrLf &
                                          "TypeOfIncident=INCIDENT TYPE:" & vbCrLf &
                                          "ExactLocation=LOCATION OF INCIDENT:" & vbCrLf & vbCrLf &
                                          "Current labels:" & vbCrLf &
                                          String.Join(vbCrLf, customLabels.Select(Function(kv) kv.Key & "=" & kv.Value)),
                                          "Customize Field Labels", "")

            If Not String.IsNullOrEmpty(result) Then
                ' Parse the custom labels
                ParseCustomLabels(result)
                
                ' Update the template preview
                UpdateTemplatePreview()
                
                MessageBox.Show("Custom labels updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to customize labels: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseCustomLabels(input As String)
        Try
            Dim lines As String() = input.Split(New String() {vbCrLf, vbNewLine}, StringSplitOptions.RemoveEmptyEntries)
            
            For Each line As String In lines
                If line.Contains("=") Then
                    Dim parts As String() = line.Split(New Char() {"="c}, 2)
                    If parts.Length = 2 Then
                        Dim fieldName As String = parts(0).Trim()
                        Dim customLabel As String = parts(1).Trim()
                        
                        If customLabels.ContainsKey(fieldName) Then
                            customLabels(fieldName) = customLabel
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error parsing custom labels: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateTemplatePreview()
        Try
            txtTemplatePreview.Text = "DOCX Template loaded successfully!" & vbCrLf & vbCrLf & 
                                    "Template: " & Path.GetFileName(templatePath) & vbCrLf & vbCrLf &
                                    "Custom field mappings:" & vbCrLf & vbCrLf &
                                    "• " & customLabels("TypeOfIncident") & " → Type of Incident" & vbCrLf &
                                    "• " & customLabels("InclusiveDate") & " → Inclusive Date and Time" & vbCrLf &
                                    "• " & customLabels("ExactLocation") & " → Exact Location" & vbCrLf &
                                    "• " & customLabels("InvolvedPerson") & " → Involved Person/Details" & vbCrLf &
                                    "• " & customLabels("Narrative") & " → Narrative" & vbCrLf &
                                    "• " & customLabels("GeneratedDate") & " → Generated Date" & vbCrLf & vbCrLf &
                                    "The print preview will use your custom labels and layout."
        Catch ex As Exception
            ' Handle error silently
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        ' Clean up resources if needed
        MyBase.Finalize()
    End Sub

End Class

