Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertBrgyClearance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertBrgyClearance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2TxtAddress = New System.Windows.Forms.TextBox()
        Me.Guna2Txtpurpose = New System.Windows.Forms.TextBox()
        Me.Guna2TxtFullname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox1 = New System.Windows.Forms.TextBox()
        Me.Guna2ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2TxtAddress)
        Me.Panel1.Controls.Add(Me.Guna2Txtpurpose)
        Me.Panel1.Controls.Add(Me.Guna2TxtFullname)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 712)
        Me.Panel1.TabIndex = 0
        '
        'Guna2TxtAddress
        '
        Me.Guna2TxtAddress.BackColor = System.Drawing.Color.White
        Me.Guna2TxtAddress.Location = New System.Drawing.Point(75, 142)
        Me.Guna2TxtAddress.Name = "Guna2TxtAddress"
        Me.Guna2TxtAddress.Size = New System.Drawing.Size(99, 20)
        Me.Guna2TxtAddress.TabIndex = 5
        Me.Guna2TxtAddress.Visible = False
        '
        'Guna2Txtpurpose
        '
        Me.Guna2Txtpurpose.BackColor = System.Drawing.Color.White
        Me.Guna2Txtpurpose.Location = New System.Drawing.Point(174, 286)
        Me.Guna2Txtpurpose.Name = "Guna2Txtpurpose"
        Me.Guna2Txtpurpose.Size = New System.Drawing.Size(101, 20)
        Me.Guna2Txtpurpose.TabIndex = 4
        Me.Guna2Txtpurpose.Visible = False
        '
        'Guna2TxtFullname
        '
        Me.Guna2TxtFullname.BackColor = System.Drawing.Color.White
        Me.Guna2TxtFullname.Location = New System.Drawing.Point(218, 130)
        Me.Guna2TxtFullname.Name = "Guna2TxtFullname"
        Me.Guna2TxtFullname.Size = New System.Drawing.Size(78, 20)
        Me.Guna2TxtFullname.TabIndex = 2
        Me.Guna2TxtFullname.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(577, 750)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Location = New System.Drawing.Point(75, 86)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Guna2TextBox1.TabIndex = 1
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'CertBrgyClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CertBrgyClearance"
        Me.Text = "CertBrgyClearance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Guna2TxtFullname As System.Windows.Forms.TextBox
    Friend WithEvents Guna2TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Txtpurpose As System.Windows.Forms.TextBox
End Class
