<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class residentinfo
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblShowingEntries = New System.Windows.Forms.Label()
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage3 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage4 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage5 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPage6 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
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
        Me.panelMain.Controls.Add(Me.lblShowingEntries)
        Me.panelMain.Controls.Add(Me.btnPrevious)
        Me.panelMain.Controls.Add(Me.btnPage1)
        Me.panelMain.Controls.Add(Me.btnPage2)
        Me.panelMain.Controls.Add(Me.btnPage3)
        Me.panelMain.Controls.Add(Me.btnPage4)
        Me.panelMain.Controls.Add(Me.btnPage5)
        Me.panelMain.Controls.Add(Me.btnPage6)
        Me.panelMain.Controls.Add(Me.btnNext)
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResidents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvResidents.ColumnHeadersHeight = 40
        Me.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvResidents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelectAll, Me.colAction, Me.colLastName, Me.colFirstName, Me.colMiddleName, Me.colMobileNo, Me.colGender})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvResidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.Location = New System.Drawing.Point(23, 190)
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
        'lblShowingEntries
        '
        Me.lblShowingEntries.AutoSize = True
        Me.lblShowingEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblShowingEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblShowingEntries.Location = New System.Drawing.Point(23, 560)
        Me.lblShowingEntries.Name = "lblShowingEntries"
        Me.lblShowingEntries.Size = New System.Drawing.Size(158, 15)
        Me.lblShowingEntries.TabIndex = 8
        Me.lblShowingEntries.Text = "Showing 1 to 10 of 52 entries"
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BorderRadius = 8
        Me.btnPrevious.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(800, 560)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 35)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        '
        'btnPage1
        '
        Me.btnPage1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage1.BackColor = System.Drawing.Color.Transparent
        Me.btnPage1.BorderRadius = 8
        Me.btnPage1.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPage1.ForeColor = System.Drawing.Color.White
        Me.btnPage1.Location = New System.Drawing.Point(870, 560)
        Me.btnPage1.Name = "btnPage1"
        Me.btnPage1.Size = New System.Drawing.Size(35, 35)
        Me.btnPage1.TabIndex = 10
        Me.btnPage1.Text = "1"
        '
        'btnPage2
        '
        Me.btnPage2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage2.BackColor = System.Drawing.Color.Transparent
        Me.btnPage2.BorderRadius = 8
        Me.btnPage2.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPage2.ForeColor = System.Drawing.Color.White
        Me.btnPage2.Location = New System.Drawing.Point(910, 560)
        Me.btnPage2.Name = "btnPage2"
        Me.btnPage2.Size = New System.Drawing.Size(35, 35)
        Me.btnPage2.TabIndex = 11
        Me.btnPage2.Text = "2"
        '
        'btnPage3
        '
        Me.btnPage3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage3.BackColor = System.Drawing.Color.Transparent
        Me.btnPage3.BorderRadius = 8
        Me.btnPage3.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPage3.ForeColor = System.Drawing.Color.White
        Me.btnPage3.Location = New System.Drawing.Point(950, 560)
        Me.btnPage3.Name = "btnPage3"
        Me.btnPage3.Size = New System.Drawing.Size(35, 35)
        Me.btnPage3.TabIndex = 12
        Me.btnPage3.Text = "3"
        '
        'btnPage4
        '
        Me.btnPage4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage4.BackColor = System.Drawing.Color.Transparent
        Me.btnPage4.BorderRadius = 8
        Me.btnPage4.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPage4.ForeColor = System.Drawing.Color.White
        Me.btnPage4.Location = New System.Drawing.Point(990, 560)
        Me.btnPage4.Name = "btnPage4"
        Me.btnPage4.Size = New System.Drawing.Size(35, 35)
        Me.btnPage4.TabIndex = 13
        Me.btnPage4.Text = "4"
        '
        'btnPage5
        '
        Me.btnPage5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage5.BackColor = System.Drawing.Color.Transparent
        Me.btnPage5.BorderRadius = 8
        Me.btnPage5.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPage5.ForeColor = System.Drawing.Color.White
        Me.btnPage5.Location = New System.Drawing.Point(1030, 560)
        Me.btnPage5.Name = "btnPage5"
        Me.btnPage5.Size = New System.Drawing.Size(35, 35)
        Me.btnPage5.TabIndex = 14
        Me.btnPage5.Text = "5"
        '
        'btnPage6
        '
        Me.btnPage6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage6.BackColor = System.Drawing.Color.Transparent
        Me.btnPage6.BorderRadius = 8
        Me.btnPage6.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPage6.ForeColor = System.Drawing.Color.White
        Me.btnPage6.Location = New System.Drawing.Point(1070, 560)
        Me.btnPage6.Name = "btnPage6"
        Me.btnPage6.Size = New System.Drawing.Size(35, 35)
        Me.btnPage6.TabIndex = 15
        Me.btnPage6.Text = "6"
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderRadius = 8
        Me.btnNext.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1110, 560)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 35)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Next"
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
    Friend WithEvents lblShowingEntries As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPage6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
End Class
