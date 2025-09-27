Public Class certificateform
    Private Sub certificateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form
        cmbCertificateType.SelectedIndex = 0
    End Sub

    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click
        ' Show page setup dialog
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        ' Show print preview dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Show print dialog
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Get form values
        Dim certificateType As String = cmbCertificateType.Text
        Dim name As String = txtName.Text
        Dim age As String = txtAge.Text
        Dim civilStatus As String = If(rbSingle.Checked, "Single", "Married")
        Dim address As String = txtAddress.Text
        Dim yearsStayed As String = txtYearsStayed.Text
        Dim issuedDate As String = dtpIssuedDate.Value.ToString("MMMM dd, yyyy")

        ' Set up fonts
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 14, FontStyle.Bold)
        Dim normalFont As New Font("Arial", 12)
        Dim signatureFont As New Font("Arial", 12, FontStyle.Bold)

        ' Set up graphics
        Dim graphics As Graphics = e.Graphics
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim centerX As Integer = pageWidth / 2
        Dim currentY As Integer = 100
        Dim leftMargin As Integer = 100
        Dim rightMargin As Integer = pageWidth - 100

        ' Draw header
        graphics.DrawString("REPUBLIC OF THE PHILIPPINES", titleFont, Brushes.Black, centerX - 150, currentY)
        currentY += 30
        graphics.DrawString("BARANGAY LIGAYA", titleFont, Brushes.Black, centerX - 100, currentY)
        currentY += 30
        graphics.DrawString("OFFICE OF THE BARANGAY CHAIRMAN", headerFont, Brushes.Black, centerX - 180, currentY)
        currentY += 60

        ' Draw certificate title
        graphics.DrawString("CERTIFICATE OF " & certificateType.ToUpper(), headerFont, Brushes.Black, centerX - 120, currentY)
        currentY += 60

        ' Draw content
        graphics.DrawString("TO WHOM IT MAY CONCERN:", normalFont, Brushes.Black, leftMargin, currentY)
        currentY += 40

        Dim contentText As String = "This is to certify that " & name & ", " & age & " years of age, " & civilStatus & ", "
        contentText &= "is a resident of " & address & ", Barangay Ligaya for " & yearsStayed & " years."

        ' Add specific text based on certificate type
        Select Case certificateType
            Case "Residency"
                contentText &= " This certification is being issued upon the request of the above-named person for whatever legal purpose it may serve."
            Case "Indigency"
                contentText &= " This further certifies that the above-named person belongs to the indigent family in this Barangay."
            Case "Barangay Clearance"
                contentText &= " This certifies that the above-named person has no derogatory record filed in this Barangay."
        End Select

        ' Draw wrapped text
        Dim textWidth As Integer = rightMargin - leftMargin
        Dim textRect As New RectangleF(leftMargin, currentY, textWidth, 300)
        graphics.DrawString(contentText, normalFont, Brushes.Black, textRect)
        currentY += 120

        ' Draw issued date
        graphics.DrawString("Issued this " & issuedDate & " at the Office of the Barangay Chairman, Barangay Ligaya.", normalFont, Brushes.Black, leftMargin, currentY)
        currentY += 80

        ' Draw signature line
        graphics.DrawString("_________________________", signatureFont, Brushes.Black, centerX + 50, currentY)
        currentY += 25
        graphics.DrawString("Barangay Chairman", normalFont, Brushes.Black, centerX + 70, currentY)
    End Sub

    Private Sub cmbCertificateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCertificateType.SelectedIndexChanged
        ' Refresh the print preview when certificate type changes
        PrintPreviewControl1.Invalidate()
    End Sub
End Class