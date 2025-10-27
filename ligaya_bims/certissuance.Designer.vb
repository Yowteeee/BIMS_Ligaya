Imports ligaya_bims

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCreateCertificate = New ligaya_bims.RoundedButton()
        Me.dgvResidents = New System.Windows.Forms.DataGridView()
        Me.chkSelectAll = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateCertificate
        '
        Me.btnCreateCertificate.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCreateCertificate.BorderRadius = 15
        Me.btnCreateCertificate.FlatAppearance.BorderSize = 0
        Me.btnCreateCertificate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnCreateCertificate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCreateCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateCertificate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreateCertificate.ForeColor = System.Drawing.Color.White
        Me.btnCreateCertificate.Location = New System.Drawing.Point(10, 10)
        Me.btnCreateCertificate.Name = "btnCreateCertificate"
        Me.btnCreateCertificate.Size = New System.Drawing.Size(154, 39)
        Me.btnCreateCertificate.TabIndex = 0
        Me.btnCreateCertificate.Text = "Create Certificate"
        Me.btnCreateCertificate.UseVisualStyleBackColor = False
        '
        'dgvResidents
        '
        Me.dgvResidents.AllowUserToAddRows = False
        Me.dgvResidents.AllowUserToDeleteRows = False
        Me.dgvResidents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResidents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResidents.ColumnHeadersHeight = 40
        Me.dgvResidents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelectAll, Me.colAction, Me.colLastName, Me.colFirstName, Me.colMiddleName, Me.colMobileNo, Me.colGender})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResidents.EnableHeadersVisualStyles = False
        Me.dgvResidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgvResidents.Location = New System.Drawing.Point(6, 90)
        Me.dgvResidents.MultiSelect = False
        Me.dgvResidents.Name = "dgvResidents"
        Me.dgvResidents.ReadOnly = True
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.RowHeadersWidth = 51
        Me.dgvResidents.RowTemplate.Height = 40
        Me.dgvResidents.Size = New System.Drawing.Size(763, 350)
        Me.dgvResidents.TabIndex = 8
        '
        'chkSelectAll
        '
        Me.chkSelectAll.HeaderText = ""
        Me.chkSelectAll.MinimumWidth = 6
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.ReadOnly = True
        '
        'colAction
        '
        Me.colAction.HeaderText = "Action"
        Me.colAction.MinimumWidth = 6
        Me.colAction.Name = "colAction"
        Me.colAction.ReadOnly = True
        Me.colAction.Width = 70
        '
        'colLastName
        '
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.MinimumWidth = 6
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        Me.colLastName.Width = 130
        '
        'colFirstName
        '
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.MinimumWidth = 6
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        Me.colFirstName.Width = 130
        '
        'colMiddleName
        '
        Me.colMiddleName.HeaderText = "Middle Name"
        Me.colMiddleName.MinimumWidth = 6
        Me.colMiddleName.Name = "colMiddleName"
        Me.colMiddleName.ReadOnly = True
        Me.colMiddleName.Width = 130
        '
        'colMobileNo
        '
        Me.colMobileNo.HeaderText = "Mobile No."
        Me.colMobileNo.MinimumWidth = 6
        Me.colMobileNo.Name = "colMobileNo"
        Me.colMobileNo.ReadOnly = True
        '
        'colGender
        '
        Me.colGender.HeaderText = "Gender"
        Me.colGender.MinimumWidth = 6
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        '
        'certissuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 487)
        Me.Controls.Add(Me.dgvResidents)
        Me.Controls.Add(Me.btnCreateCertificate)
        Me.Name = "certissuance"
        Me.Text = "Certificate Issuance"
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateCertificate As ligaya_bims.RoundedButton
    Friend WithEvents dgvResidents As System.Windows.Forms.DataGridView
    Friend WithEvents chkSelectAll As DataGridViewCheckBoxColumn
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents colMobileNo As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
End Class
