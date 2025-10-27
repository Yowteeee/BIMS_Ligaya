Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CertifcateIndigency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertifcateIndigency))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Txtissued2 = New System.Windows.Forms.TextBox()
        Me.Guna2Txtissued1 = New System.Windows.Forms.TextBox()
        Me.Guna2Txtfullname = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 700)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2Txtissued2)
        Me.Panel1.Controls.Add(Me.Guna2Txtissued1)
        Me.Panel1.Controls.Add(Me.Guna2Txtfullname)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(23, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 704)
        Me.Panel1.TabIndex = 1
        '
        'Guna2Txtissued2
        '
        Me.Guna2Txtissued2.BackColor = System.Drawing.Color.White
        Me.Guna2Txtissued2.Location = New System.Drawing.Point(221, 327)
        Me.Guna2Txtissued2.Name = "Guna2Txtissued2"
        Me.Guna2Txtissued2.Size = New System.Drawing.Size(80, 20)
        Me.Guna2Txtissued2.TabIndex = 6
        Me.Guna2Txtissued2.Visible = False
        '
        'Guna2Txtissued1
        '
        Me.Guna2Txtissued1.BackColor = System.Drawing.Color.White
        Me.Guna2Txtissued1.Location = New System.Drawing.Point(160, 327)
        Me.Guna2Txtissued1.Name = "Guna2Txtissued1"
        Me.Guna2Txtissued1.Size = New System.Drawing.Size(22, 20)
        Me.Guna2Txtissued1.TabIndex = 5
        Me.Guna2Txtissued1.Visible = False
        '
        'Guna2Txtfullname
        '
        Me.Guna2Txtfullname.BackColor = System.Drawing.Color.White
        Me.Guna2Txtfullname.Location = New System.Drawing.Point(207, 245)
        Me.Guna2Txtfullname.Name = "Guna2Txtfullname"
        Me.Guna2Txtfullname.Size = New System.Drawing.Size(102, 20)
        Me.Guna2Txtfullname.TabIndex = 4
        Me.Guna2Txtfullname.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(578, 735)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'CertifcateIndigency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 763)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CertifcateIndigency"
        Me.Text = "CertifcateIndigency"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2Txtissued1 As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtissued2 As System.Windows.Forms.TextBox
End Class
