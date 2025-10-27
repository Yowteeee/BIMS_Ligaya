Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertResidency
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertResidency))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Txtissued2 = New System.Windows.Forms.TextBox()
        Me.Guna2Txtissued1 = New System.Windows.Forms.TextBox()
        Me.Guna2Txtpurpose = New System.Windows.Forms.TextBox()
        Me.Guna2Txtfullname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Txtissued2)
        Me.Panel1.Controls.Add(Me.Guna2Txtissued1)
        Me.Panel1.Controls.Add(Me.Guna2Txtpurpose)
        Me.Panel1.Controls.Add(Me.Guna2Txtfullname)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(92, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 467)
        Me.Panel1.TabIndex = 1
        '
        'Guna2Txtissued2
        '
        Me.Guna2Txtissued2.BackColor = System.Drawing.Color.White
        Me.Guna2Txtissued2.Location = New System.Drawing.Point(153, 329)
        Me.Guna2Txtissued2.Name = "Guna2Txtissued2"
        Me.Guna2Txtissued2.Size = New System.Drawing.Size(73, 20)
        Me.Guna2Txtissued2.TabIndex = 8
        Me.Guna2Txtissued2.Visible = False
        '
        'Guna2Txtissued1
        '
        Me.Guna2Txtissued1.BackColor = System.Drawing.Color.White
        Me.Guna2Txtissued1.Location = New System.Drawing.Point(104, 329)
        Me.Guna2Txtissued1.Name = "Guna2Txtissued1"
        Me.Guna2Txtissued1.Size = New System.Drawing.Size(19, 20)
        Me.Guna2Txtissued1.TabIndex = 7
        Me.Guna2Txtissued1.Visible = False
        '
        'Guna2Txtpurpose
        '
        Me.Guna2Txtpurpose.BackColor = System.Drawing.Color.White
        Me.Guna2Txtpurpose.Location = New System.Drawing.Point(169, 288)
        Me.Guna2Txtpurpose.Name = "Guna2Txtpurpose"
        Me.Guna2Txtpurpose.Size = New System.Drawing.Size(115, 20)
        Me.Guna2Txtpurpose.TabIndex = 6
        Me.Guna2Txtpurpose.Visible = False
        '
        'Guna2Txtfullname
        '
        Me.Guna2Txtfullname.BackColor = System.Drawing.Color.White
        Me.Guna2Txtfullname.Location = New System.Drawing.Point(201, 185)
        Me.Guna2Txtfullname.Name = "Guna2Txtfullname"
        Me.Guna2Txtfullname.Size = New System.Drawing.Size(83, 20)
        Me.Guna2Txtfullname.TabIndex = 5
        Me.Guna2Txtfullname.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 531)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CertResidency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CertResidency"
        Me.Text = "CertResidency"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtpurpose As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtissued1 As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtissued2 As System.Windows.Forms.TextBox
End Class
