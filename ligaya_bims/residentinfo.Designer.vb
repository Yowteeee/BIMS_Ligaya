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
        Me.panelMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNewResident = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExportResident = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteResident = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblShowEntries = New System.Windows.Forms.Label()
        Me.cmbShowEntries = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvResidents = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.panelMain.BackColor = System.Drawing.Color.White
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
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(23, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resident Information"
        '
        'btnNewResident
        '
        Me.btnNewResident.BackColor = System.Drawing.Color.Transparent
        Me.btnNewResident.BorderRadius = 8
        Me.btnNewResident.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnNewResident.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewResident.ForeColor = System.Drawing.Color.White
        Me.btnNewResident.Location = New System.Drawing.Point(23, 85)
        Me.btnNewResident.Name = "btnNewResident"
        Me.btnNewResident.Size = New System.Drawing.Size(150, 40)
        Me.btnNewResident.TabIndex = 1
        Me.btnNewResident.Text = "New Resident +"
        Me.btnNewResident.TextOffset = New System.Drawing.Point(0, -1)
        '
        'btnExportResident
        '
        Me.btnExportResident.BackColor = System.Drawing.Color.Transparent
        Me.btnExportResident.BorderRadius = 8
        Me.btnExportResident.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnExportResident.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportResident.ForeColor = System.Drawing.Color.White
        Me.btnExportResident.Location = New System.Drawing.Point(185, 85)
        Me.btnExportResident.Name = "btnExportResident"
        Me.btnExportResident.Size = New System.Drawing.Size(150, 40)
        Me.btnExportResident.TabIndex = 2
        Me.btnExportResident.Text = "Export Resident Info"
        Me.btnExportResident.TextOffset = New System.Drawing.Point(0, 7)
        '
        'btnDeleteResident
        '
        Me.btnDeleteResident.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteResident.BorderRadius = 8
        Me.btnDeleteResident.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
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
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(950, 85)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(200, 40)
        Me.txtSearch.TabIndex = 4
        '
        'lblShowEntries
        '
        Me.lblShowEntries.AutoSize = True
        Me.lblShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblShowEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblShowEntries.Location = New System.Drawing.Point(23, 145)
        Me.lblShowEntries.Name = "lblShowEntries"
        Me.lblShowEntries.Size = New System.Drawing.Size(89, 15)
        Me.lblShowEntries.TabIndex = 5
        Me.lblShowEntries.Text = "Show 10 entries"
        '
        'cmbShowEntries
        '
        Me.cmbShowEntries.BackColor = System.Drawing.Color.Transparent
        Me.cmbShowEntries.BorderRadius = 8
        Me.cmbShowEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbShowEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowEntries.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbShowEntries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbShowEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbShowEntries.ItemHeight = 30
        Me.cmbShowEntries.Items.AddRange(New Object() {"10", "25", "50", "100"})
        Me.cmbShowEntries.Location = New System.Drawing.Point(118, 145)
        Me.cmbShowEntries.Name = "cmbShowEntries"
        Me.cmbShowEntries.Size = New System.Drawing.Size(60, 36)
        Me.cmbShowEntries.TabIndex = 6
        '
        'dgvResidents
        '
        Me.dgvResidents.AllowUserToAddRows = False
        Me.dgvResidents.AllowUserToDeleteRows = False
        Me.dgvResidents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResidents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResidents.ColumnHeadersHeight = 40
        Me.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvResidents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelectAll, Me.colAction, Me.colLastName, Me.colFirstName, Me.colMiddleName, Me.colMobileNo, Me.colGender})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.Location = New System.Drawing.Point(23, 187)
        Me.dgvResidents.MultiSelect = False
        Me.dgvResidents.Name = "dgvResidents"
        Me.dgvResidents.ReadOnly = True
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.RowHeadersWidth = 51
        Me.dgvResidents.RowTemplate.Height = 40
        Me.dgvResidents.Size = New System.Drawing.Size(1154, 350)
        Me.dgvResidents.TabIndex = 7
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvResidents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvResidents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvResidents.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvResidents.ThemeStyle.ReadOnly = True
        Me.dgvResidents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvResidents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvResidents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.ThemeStyle.RowsStyle.Height = 40
        Me.dgvResidents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
    Friend WithEvents panelMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNewResident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportResident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteResident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblShowEntries As System.Windows.Forms.Label
    Friend WithEvents cmbShowEntries As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvResidents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents chkSelectAll As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobileNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGender As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
