<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class certissuance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCreateCertificate = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnCreateCertificate
        '
        Me.btnCreateCertificate.BorderRadius = 6
        Me.btnCreateCertificate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateCertificate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateCertificate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateCertificate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateCertificate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCreateCertificate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreateCertificate.ForeColor = System.Drawing.Color.White
        Me.btnCreateCertificate.Location = New System.Drawing.Point(10, 10)
        Me.btnCreateCertificate.Name = "btnCreateCertificate"
        Me.btnCreateCertificate.Size = New System.Drawing.Size(154, 39)
        Me.btnCreateCertificate.TabIndex = 0
        Me.btnCreateCertificate.Text = "Create Certificate"
        '
        'certissuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.btnCreateCertificate)
        Me.Name = "certissuance"
        Me.Text = "Certificate Issuance"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateCertificate As Guna.UI2.WinForms.Guna2Button
End Class
