Public Class certissuance
    ' Method to handle when form is displayed as child form in dashboard
    Public Sub SetAsChildForm()
        ' Ensure the form is properly configured for child display
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
    End Sub

    Private Sub btnCreateCertificate_Click(sender As Object, e As EventArgs) Handles btnCreateCertificate.Click
        certificateform.Show()

    End Sub

    Private Sub certissuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellContentClick

    End Sub
End Class