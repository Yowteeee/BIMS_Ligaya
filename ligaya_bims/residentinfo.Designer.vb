<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class residentinfo
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNewResident = New System.Windows.Forms.Button()
        Me.btnExportResident = New System.Windows.Forms.Button()
        Me.btnDeleteResident = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblShowEntries = New System.Windows.Forms.Label()
        Me.cmbShowEntries = New System.Windows.Forms.ComboBox()
        Me.dgvResidents = New System.Windows.Forms.DataGridView()
        Me.chkSelectAll = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelMain.SuspendLayout()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelMain.Controls.Add(Me.lblTitle)
        Me.panelMain.Controls.Add(Me.btnNewResident)
        Me.panelMain.Controls.Add(Me.btnExportResident)
        Me.panelMain.Controls.Add(Me.btnDeleteResident)
        Me.panelMain.Controls.Add(Me.txtSearch)
        Me.panelMain.Controls.Add(Me.lblShowEntries)
        Me.panelMain.Controls.Add(Me.cmbShowEntries)
        Me.panelMain.Controls.Add(Me.dgvResidents)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(20)
        Me.panelMain.Size = New System.Drawing.Size(1200, 700)
        Me.panelMain.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(23, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resident Information"
        '
        'btnNewResident
        '
        Me.btnNewResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnNewResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewResident.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewResident.ForeColor = System.Drawing.Color.White
        Me.btnNewResident.Location = New System.Drawing.Point(23, 85)
        Me.btnNewResident.Name = "btnNewResident"
        Me.btnNewResident.Size = New System.Drawing.Size(150, 40)
        Me.btnNewResident.TabIndex = 1
        Me.btnNewResident.Text = "New Resident +"
        '
        'btnExportResident
        '
        Me.btnExportResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExportResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportResident.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportResident.ForeColor = System.Drawing.Color.White
        Me.btnExportResident.Location = New System.Drawing.Point(185, 85)
        Me.btnExportResident.Name = "btnExportResident"
        Me.btnExportResident.Size = New System.Drawing.Size(150, 40)
        Me.btnExportResident.TabIndex = 2
        Me.btnExportResident.Text = "Export Resident Info"
        '
        'btnDeleteResident
        '
        Me.btnDeleteResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDeleteResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteResident.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteResident.ForeColor = System.Drawing.Color.White
        Me.btnDeleteResident.Location = New System.Drawing.Point(347, 85)
        Me.btnDeleteResident.Name = "btnDeleteResident"
        Me.btnDeleteResident.Size = New System.Drawing.Size(40, 40)
        Me.btnDeleteResident.TabIndex = 3
        Me.btnDeleteResident.Text = "🗑"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(950, 95)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.TabIndex = 4
        '
        'lblShowEntries
        '
        Me.lblShowEntries.AutoSize = True
        Me.lblShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblShowEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblShowEntries.Location = New System.Drawing.Point(23, 145)
        Me.lblShowEntries.Name = "lblShowEntries"
        Me.lblShowEntries.Size = New System.Drawing.Size(89, 15)
        Me.lblShowEntries.TabIndex = 5
        Me.lblShowEntries.Text = "Show 10 entries"
        '
        'cmbShowEntries
        '
        Me.cmbShowEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbShowEntries.Items.AddRange(New Object() {"10", "25", "50", "100"})
        Me.cmbShowEntries.Location = New System.Drawing.Point(118, 141)
        Me.cmbShowEntries.Name = "cmbShowEntries"
        Me.cmbShowEntries.Size = New System.Drawing.Size(60, 23)
        Me.cmbShowEntries.TabIndex = 6
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
        Me.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
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
        Me.dgvResidents.Location = New System.Drawing.Point(23, 187)
        Me.dgvResidents.MultiSelect = False
        Me.dgvResidents.Name = "dgvResidents"
        Me.dgvResidents.ReadOnly = True
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.RowHeadersWidth = 51
        Me.dgvResidents.RowTemplate.Height = 40
        Me.dgvResidents.Size = New System.Drawing.Size(1154, 350)
        Me.dgvResidents.TabIndex = 7
        ' Apply alternating row coloring
        Me.dgvResidents.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
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
        '
        'colLastName
        '
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.MinimumWidth = 6
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        '
        'colFirstName
        '
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.MinimumWidth = 6
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        '
        'colMiddleName
        '
        Me.colMiddleName.HeaderText = "Middle Name"
        Me.colMiddleName.MinimumWidth = 6
        Me.colMiddleName.Name = "colMiddleName"
        Me.colMiddleName.ReadOnly = True
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
        'residentinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "residentinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resident Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNewResident As System.Windows.Forms.Button
    Friend WithEvents btnExportResident As System.Windows.Forms.Button
    Friend WithEvents btnDeleteResident As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblShowEntries As System.Windows.Forms.Label
    Friend WithEvents cmbShowEntries As System.Windows.Forms.ComboBox
    Friend WithEvents dgvResidents As System.Windows.Forms.DataGridView
    Friend WithEvents chkSelectAll As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobileNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGender As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
