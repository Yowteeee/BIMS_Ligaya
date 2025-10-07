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
    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub panelRight_Paint(sender As Object, e As PaintEventArgs) Handles panelRight.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlPic_Paint(sender As Object, e As PaintEventArgs) Handles pnlPic.Paint

    End Sub

    Private Sub cmbCertificateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCertificateType.SelectedIndexChanged
        pnlPic.Controls.Clear()
        Dim selected As String = If(cmbCertificateType.SelectedItem, "").ToString()

        Dim sourceForm As Form = Nothing
        Try
            If selected = "Residency" Then
                sourceForm = New CertResidency()
            ElseIf selected = "Indigency" Then
                sourceForm = New CertifcateIndigency()
            ElseIf selected = "Barangay Clearance" Then
                sourceForm = New CertBrgyClearance()
            End If

            If sourceForm Is Nothing Then Return

            Dim sourcePanel As Panel = Nothing
            ' Prefer a Panel1 container when present
            For Each ctrl As Control In sourceForm.Controls
                If TypeOf ctrl Is Panel AndAlso String.Equals(ctrl.Name, "Panel1", StringComparison.OrdinalIgnoreCase) Then
                    sourcePanel = DirectCast(ctrl, Panel)
                    Exit For
                End If
            Next

            Dim container As Control = If(sourcePanel IsNot Nothing, DirectCast(sourcePanel, Control), DirectCast(sourceForm, Control))

            ' Copy all PictureBoxes from the container to pnlPic
            For Each ctrl As Control In container.Controls
                If TypeOf ctrl Is PictureBox Then
                    Dim src As PictureBox = DirectCast(ctrl, PictureBox)
                    Dim pb As New PictureBox()
                    pb.Image = src.Image
                    pb.SizeMode = src.SizeMode
                    pb.Location = src.Location
                    pb.Size = src.Size
                    pb.Anchor = src.Anchor
                    pb.Dock = DockStyle.None
                    pb.BackColor = src.BackColor
                    pb.Margin = src.Margin
                    pnlPic.Controls.Add(pb)
                End If
            Next
        Finally
            If sourceForm IsNot Nothing Then
                sourceForm.Dispose()
            End If
        End Try
    End Sub

    Private Sub panelRightHeader_Paint(sender As Object, e As PaintEventArgs) Handles panelRightHeader.Paint

    End Sub
End Class