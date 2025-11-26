Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blotterform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlDataArea = New System.Windows.Forms.Panel()
        Me.pnlRightTable = New System.Windows.Forms.Panel()
        Me.lblComplainantVsRespondent = New System.Windows.Forms.Label()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlLeftTable = New System.Windows.Forms.Panel()
        Me.dgvBlotterRecords = New System.Windows.Forms.DataGridView()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.pnlScheduleButtons = New System.Windows.Forms.Panel()
        Me.btnUpdateSettlementStatus = New ligaya_bims.RoundedButton()
        Me.btnDeleteSchedule = New ligaya_bims.RoundedButton()
        Me.btnEditSchedule = New ligaya_bims.RoundedButton()
        Me.btnAddSchedule = New ligaya_bims.RoundedButton()
        Me.pnlBlotterButtons = New System.Windows.Forms.Panel()
        Me.btnPrint = New ligaya_bims.RoundedButton()
        Me.btnDelete = New ligaya_bims.RoundedButton()
        Me.btnEdit = New ligaya_bims.RoundedButton()
        Me.btnAddNew = New ligaya_bims.RoundedButton()
        Me.pnlMain.SuspendLayout()
        Me.pnlDataArea.SuspendLayout()
        Me.pnlRightTable.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeftTable.SuspendLayout()
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlScheduleButtons.SuspendLayout()
        Me.pnlBlotterButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.pnlDataArea)
        Me.pnlMain.Controls.Add(Me.pnlSearch)
        Me.pnlMain.Controls.Add(Me.pnlButtons)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1819, 970)
        Me.pnlMain.TabIndex = 0
        '
        'pnlDataArea
        '
        Me.pnlDataArea.Controls.Add(Me.pnlRightTable)
        Me.pnlDataArea.Controls.Add(Me.pnlLeftTable)
        Me.pnlDataArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataArea.Location = New System.Drawing.Point(0, 74)
        Me.pnlDataArea.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDataArea.Name = "pnlDataArea"
        Me.pnlDataArea.Padding = New System.Windows.Forms.Padding(27, 12, 27, 12)
        Me.pnlDataArea.Size = New System.Drawing.Size(1819, 834)
        Me.pnlDataArea.TabIndex = 2
        '
        'pnlRightTable
        '
        Me.pnlRightTable.Controls.Add(Me.lblComplainantVsRespondent)
        Me.pnlRightTable.Controls.Add(Me.dgvSchedule)
        Me.pnlRightTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRightTable.Location = New System.Drawing.Point(910, 12)
        Me.pnlRightTable.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRightTable.Name = "pnlRightTable"
        Me.pnlRightTable.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.pnlRightTable.Size = New System.Drawing.Size(882, 810)
        Me.pnlRightTable.TabIndex = 1
        '
        'lblComplainantVsRespondent
        '
        Me.lblComplainantVsRespondent.AutoSize = True
        Me.lblComplainantVsRespondent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplainantVsRespondent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblComplainantVsRespondent.Location = New System.Drawing.Point(13, 12)
        Me.lblComplainantVsRespondent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComplainantVsRespondent.Name = "lblComplainantVsRespondent"
        Me.lblComplainantVsRespondent.Size = New System.Drawing.Size(267, 28)
        Me.lblComplainantVsRespondent.TabIndex = 1
        Me.lblComplainantVsRespondent.Text = "Complainant vs Respondent"
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSchedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSchedule.ColumnHeadersHeight = 45
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSchedule.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSchedule.EnableHeadersVisualStyles = False
        Me.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgvSchedule.Location = New System.Drawing.Point(13, 50)
        Me.dgvSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSchedule.MultiSelect = False
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        Me.dgvSchedule.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvSchedule.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSchedule.RowTemplate.Height = 40
        Me.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedule.Size = New System.Drawing.Size(869, 760)
        Me.dgvSchedule.TabIndex = 0
        '
        'pnlLeftTable
        '
        Me.pnlLeftTable.Controls.Add(Me.dgvBlotterRecords)
        Me.pnlLeftTable.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftTable.Location = New System.Drawing.Point(27, 12)
        Me.pnlLeftTable.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeftTable.Name = "pnlLeftTable"
        Me.pnlLeftTable.Size = New System.Drawing.Size(883, 810)
        Me.pnlLeftTable.TabIndex = 0
        '
        'dgvBlotterRecords
        '
        Me.dgvBlotterRecords.AllowUserToAddRows = False
        Me.dgvBlotterRecords.AllowUserToDeleteRows = False
        Me.dgvBlotterRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvBlotterRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBlotterRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBlotterRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvBlotterRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBlotterRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBlotterRecords.ColumnHeadersHeight = 45
        Me.dgvBlotterRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBlotterRecords.Dock = System.Windows.Forms.DockStyle.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBlotterRecords.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBlotterRecords.EnableHeadersVisualStyles = False
        Me.dgvBlotterRecords.GridColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgvBlotterRecords.Location = New System.Drawing.Point(0, 0)
        Me.dgvBlotterRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBlotterRecords.MultiSelect = False
        Me.dgvBlotterRecords.Name = "dgvBlotterRecords"
        Me.dgvBlotterRecords.ReadOnly = True
        Me.dgvBlotterRecords.RowHeadersVisible = False
        Me.dgvBlotterRecords.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgvBlotterRecords.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBlotterRecords.RowTemplate.Height = 40
        Me.dgvBlotterRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBlotterRecords.Size = New System.Drawing.Size(883, 810)
        Me.dgvBlotterRecords.TabIndex = 0
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.cmbSearchBy)
        Me.pnlSearch.Controls.Add(Me.lblSearchBy)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(27, 18, 27, 12)
        Me.pnlSearch.Size = New System.Drawing.Size(1819, 74)
        Me.pnlSearch.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(267, 22)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(399, 30)
        Me.txtSearch.TabIndex = 2
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSearchBy.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"ALL", "Brgy. Case #", "Accusation", "Complainant's Name", "Purok"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(160, 22)
        Me.cmbSearchBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(99, 31)
        Me.cmbSearchBy.TabIndex = 1
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblSearchBy.Location = New System.Drawing.Point(29, 22)
        Me.lblSearchBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(123, 31)
        Me.lblSearchBy.TabIndex = 0
        Me.lblSearchBy.Text = "Search by:"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.pnlScheduleButtons)
        Me.pnlButtons.Controls.Add(Me.pnlBlotterButtons)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 908)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Padding = New System.Windows.Forms.Padding(27, 12, 27, 12)
        Me.pnlButtons.Size = New System.Drawing.Size(1819, 62)
        Me.pnlButtons.TabIndex = 0
        '
        'pnlScheduleButtons
        '
        Me.pnlScheduleButtons.Controls.Add(Me.btnUpdateSettlementStatus)
        Me.pnlScheduleButtons.Controls.Add(Me.btnDeleteSchedule)
        Me.pnlScheduleButtons.Controls.Add(Me.btnEditSchedule)
        Me.pnlScheduleButtons.Controls.Add(Me.btnAddSchedule)
        Me.pnlScheduleButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlScheduleButtons.Location = New System.Drawing.Point(909, 12)
        Me.pnlScheduleButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlScheduleButtons.Name = "pnlScheduleButtons"
        Me.pnlScheduleButtons.Size = New System.Drawing.Size(883, 38)
        Me.pnlScheduleButtons.TabIndex = 1
        '
        'btnUpdateSettlementStatus
        '
        Me.btnUpdateSettlementStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateSettlementStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnUpdateSettlementStatus.BorderRadius = 15
        Me.btnUpdateSettlementStatus.FlatAppearance.BorderSize = 0
        Me.btnUpdateSettlementStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSettlementStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSettlementStatus.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSettlementStatus.Location = New System.Drawing.Point(639, 0)
        Me.btnUpdateSettlementStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateSettlementStatus.Name = "btnUpdateSettlementStatus"
        Me.btnUpdateSettlementStatus.Size = New System.Drawing.Size(240, 37)
        Me.btnUpdateSettlementStatus.TabIndex = 3
        Me.btnUpdateSettlementStatus.Text = "UPDATE SETTLEMENT STATUS"
        Me.btnUpdateSettlementStatus.UseVisualStyleBackColor = False
        '
        'btnDeleteSchedule
        '
        Me.btnDeleteSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnDeleteSchedule.BorderRadius = 15
        Me.btnDeleteSchedule.FlatAppearance.BorderSize = 0
        Me.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSchedule.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSchedule.Location = New System.Drawing.Point(471, 1)
        Me.btnDeleteSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteSchedule.Name = "btnDeleteSchedule"
        Me.btnDeleteSchedule.Size = New System.Drawing.Size(160, 37)
        Me.btnDeleteSchedule.TabIndex = 2
        Me.btnDeleteSchedule.Text = "DELETE SCHEDULE"
        Me.btnDeleteSchedule.UseVisualStyleBackColor = False
        '
        'btnEditSchedule
        '
        Me.btnEditSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnEditSchedule.BorderRadius = 15
        Me.btnEditSchedule.FlatAppearance.BorderSize = 0
        Me.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSchedule.ForeColor = System.Drawing.Color.White
        Me.btnEditSchedule.Location = New System.Drawing.Point(294, 0)
        Me.btnEditSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditSchedule.Name = "btnEditSchedule"
        Me.btnEditSchedule.Size = New System.Drawing.Size(160, 37)
        Me.btnEditSchedule.TabIndex = 1
        Me.btnEditSchedule.Text = "EDIT SCHEDULE"
        Me.btnEditSchedule.UseVisualStyleBackColor = False
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAddSchedule.BorderRadius = 15
        Me.btnAddSchedule.FlatAppearance.BorderSize = 0
        Me.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSchedule.ForeColor = System.Drawing.Color.White
        Me.btnAddSchedule.Location = New System.Drawing.Point(112, 1)
        Me.btnAddSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(160, 37)
        Me.btnAddSchedule.TabIndex = 0
        Me.btnAddSchedule.Text = "ADD SCHEDULE"
        Me.btnAddSchedule.UseVisualStyleBackColor = False
        '
        'pnlBlotterButtons
        '
        Me.pnlBlotterButtons.Controls.Add(Me.btnPrint)
        Me.pnlBlotterButtons.Controls.Add(Me.btnDelete)
        Me.pnlBlotterButtons.Controls.Add(Me.btnEdit)
        Me.pnlBlotterButtons.Controls.Add(Me.btnAddNew)
        Me.pnlBlotterButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBlotterButtons.Location = New System.Drawing.Point(27, 12)
        Me.pnlBlotterButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBlotterButtons.Name = "pnlBlotterButtons"
        Me.pnlBlotterButtons.Size = New System.Drawing.Size(883, 38)
        Me.pnlBlotterButtons.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnPrint.BorderRadius = 15
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(562, 1)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(160, 37)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnDelete.BorderRadius = 15
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(404, 1)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 37)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnEdit.BorderRadius = 15
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(240, 1)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 37)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAddNew.BorderRadius = 15
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(73, 0)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(107, 37)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'blotterform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1819, 970)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "blotterform"
        Me.Text = "Blotter Records"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlDataArea.ResumeLayout(False)
        Me.pnlRightTable.ResumeLayout(False)
        Me.pnlRightTable.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeftTable.ResumeLayout(False)
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlScheduleButtons.ResumeLayout(False)
        Me.pnlBlotterButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlDataArea As Panel
    Friend WithEvents pnlRightTable As Panel
    Friend WithEvents lblComplainantVsRespondent As Label
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents pnlLeftTable As Panel
    Friend WithEvents dgvBlotterRecords As DataGridView
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchBy As ComboBox
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents pnlScheduleButtons As Panel
    Friend WithEvents btnUpdateSettlementStatus As RoundedButton
    Friend WithEvents btnDeleteSchedule As RoundedButton
    Friend WithEvents btnEditSchedule As RoundedButton
    Friend WithEvents btnAddSchedule As RoundedButton
    Friend WithEvents pnlBlotterButtons As Panel
    Friend WithEvents btnPrint As RoundedButton
    Friend WithEvents btnDelete As RoundedButton
    Friend WithEvents btnEdit As RoundedButton
    Friend WithEvents btnAddNew As RoundedButton
End Class
