<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.leftNav = New System.Windows.Forms.Panel()
        Me.navLogout = New System.Windows.Forms.Button()
        Me.navBackup = New System.Windows.Forms.Button()
        Me.navStaffs = New System.Windows.Forms.Button()
        Me.navDocs = New System.Windows.Forms.Button()
        Me.navCedula = New System.Windows.Forms.Button()
        Me.navReports = New System.Windows.Forms.Button()
        Me.navResidents = New System.Windows.Forms.Button()
        Me.navDashboard = New System.Windows.Forms.Button()
        Me.leftHeader = New System.Windows.Forms.Panel()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.topBar = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.contentHost = New System.Windows.Forms.Panel()
        Me.chartsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.chartLeft = New System.Windows.Forms.Panel()
        Me.dgvDashboardResidents = New System.Windows.Forms.DataGridView()
        Me.lblResidentsList = New System.Windows.Forms.Label()
        Me.chartRight = New System.Windows.Forms.Panel()
        Me.chartPurok = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblPurokChart = New System.Windows.Forms.Label()
        Me.statsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.cardHouseholds = New System.Windows.Forms.Panel()
        Me.lblHouseholdsSub = New System.Windows.Forms.Label()
        Me.lblHouseholds = New System.Windows.Forms.Label()
        Me.cardPopulation = New System.Windows.Forms.Panel()
        Me.lblPopulationSub = New System.Windows.Forms.Label()
        Me.lblPopulation = New System.Windows.Forms.Label()
        Me.cardPending = New System.Windows.Forms.Panel()
        Me.lblPendingSub = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.cardVoters = New System.Windows.Forms.Panel()
        Me.lblVotersSub = New System.Windows.Forms.Label()
        Me.lblVoters = New System.Windows.Forms.Label()
        Me.cardCrime = New System.Windows.Forms.Panel()
        Me.lblCrimeSub = New System.Windows.Forms.Label()
        Me.lblCrime = New System.Windows.Forms.Label()
        Me.cardIndigent = New System.Windows.Forms.Panel()
        Me.lblIndigentSub = New System.Windows.Forms.Label()
        Me.lblIndigent = New System.Windows.Forms.Label()
        Me.leftNav.SuspendLayout()
        Me.leftHeader.SuspendLayout()
        Me.topBar.SuspendLayout()
        Me.contentHost.SuspendLayout()
        Me.chartsTable.SuspendLayout()
        Me.chartLeft.SuspendLayout()
        CType(Me.dgvDashboardResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chartRight.SuspendLayout()
        CType(Me.chartPurok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statsTable.SuspendLayout()
        Me.cardHouseholds.SuspendLayout()
        Me.cardPopulation.SuspendLayout()
        Me.cardPending.SuspendLayout()
        Me.cardVoters.SuspendLayout()
        Me.cardCrime.SuspendLayout()
        Me.cardIndigent.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftNav
        '
        Me.leftNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.leftNav.Controls.Add(Me.navLogout)
        Me.leftNav.Controls.Add(Me.navBackup)
        Me.leftNav.Controls.Add(Me.navStaffs)
        Me.leftNav.Controls.Add(Me.navDocs)
        Me.leftNav.Controls.Add(Me.navCedula)
        Me.leftNav.Controls.Add(Me.navReports)
        Me.leftNav.Controls.Add(Me.navResidents)
        Me.leftNav.Controls.Add(Me.navDashboard)
        Me.leftNav.Controls.Add(Me.leftHeader)
        Me.leftNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftNav.Location = New System.Drawing.Point(0, 0)
        Me.leftNav.Name = "leftNav"
        Me.leftNav.Size = New System.Drawing.Size(200, 861)
        Me.leftNav.TabIndex = 0
        '
        'navLogout
        '
        Me.navLogout.BackColor = System.Drawing.Color.Transparent
        Me.navLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.navLogout.FlatAppearance.BorderSize = 0
        Me.navLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.navLogout.ForeColor = System.Drawing.Color.IndianRed
        Me.navLogout.Location = New System.Drawing.Point(0, 773)
        Me.navLogout.Name = "navLogout"
        Me.navLogout.Size = New System.Drawing.Size(200, 44)
        Me.navLogout.TabIndex = 8
        Me.navLogout.Text = "  Log Out"
        Me.navLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navLogout.UseVisualStyleBackColor = False
        '
        'navBackup
        '
        Me.navBackup.BackColor = System.Drawing.Color.Transparent
        Me.navBackup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.navBackup.FlatAppearance.BorderSize = 0
        Me.navBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navBackup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navBackup.ForeColor = System.Drawing.Color.Gainsboro
        Me.navBackup.Location = New System.Drawing.Point(0, 817)
        Me.navBackup.Name = "navBackup"
        Me.navBackup.Size = New System.Drawing.Size(200, 44)
        Me.navBackup.TabIndex = 7
        Me.navBackup.Text = "  Backup and Restore"
        Me.navBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navBackup.UseVisualStyleBackColor = False
        '
        'navStaffs
        '
        Me.navStaffs.BackColor = System.Drawing.Color.Transparent
        Me.navStaffs.Dock = System.Windows.Forms.DockStyle.Top
        Me.navStaffs.FlatAppearance.BorderSize = 0
        Me.navStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navStaffs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navStaffs.ForeColor = System.Drawing.Color.Gainsboro
        Me.navStaffs.Location = New System.Drawing.Point(0, 290)
        Me.navStaffs.Name = "navStaffs"
        Me.navStaffs.Size = New System.Drawing.Size(200, 44)
        Me.navStaffs.TabIndex = 6
        Me.navStaffs.Text = "  Staffs"
        Me.navStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navStaffs.UseVisualStyleBackColor = False
        '
        'navDocs
        '
        Me.navDocs.BackColor = System.Drawing.Color.Transparent
        Me.navDocs.Dock = System.Windows.Forms.DockStyle.Top
        Me.navDocs.FlatAppearance.BorderSize = 0
        Me.navDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navDocs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navDocs.ForeColor = System.Drawing.Color.Gainsboro
        Me.navDocs.Location = New System.Drawing.Point(0, 246)
        Me.navDocs.Name = "navDocs"
        Me.navDocs.Size = New System.Drawing.Size(200, 44)
        Me.navDocs.TabIndex = 5
        Me.navDocs.Text = "Certificate Issuance"
        Me.navDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navDocs.UseVisualStyleBackColor = False
        '
        'navCedula
        '
        Me.navCedula.BackColor = System.Drawing.Color.Transparent
        Me.navCedula.Dock = System.Windows.Forms.DockStyle.Top
        Me.navCedula.FlatAppearance.BorderSize = 0
        Me.navCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navCedula.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navCedula.ForeColor = System.Drawing.Color.Gainsboro
        Me.navCedula.Location = New System.Drawing.Point(0, 202)
        Me.navCedula.Name = "navCedula"
        Me.navCedula.Size = New System.Drawing.Size(200, 44)
        Me.navCedula.TabIndex = 4
        Me.navCedula.Text = "  Cedula Tracker"
        Me.navCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navCedula.UseVisualStyleBackColor = False
        '
        'navReports
        '
        Me.navReports.BackColor = System.Drawing.Color.Transparent
        Me.navReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.navReports.FlatAppearance.BorderSize = 0
        Me.navReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navReports.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navReports.ForeColor = System.Drawing.Color.Gainsboro
        Me.navReports.Location = New System.Drawing.Point(0, 158)
        Me.navReports.Name = "navReports"
        Me.navReports.Size = New System.Drawing.Size(200, 44)
        Me.navReports.TabIndex = 3
        Me.navReports.Text = "  Reports"
        Me.navReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navReports.UseVisualStyleBackColor = False
        '
        'navResidents
        '
        Me.navResidents.BackColor = System.Drawing.Color.Transparent
        Me.navResidents.Dock = System.Windows.Forms.DockStyle.Top
        Me.navResidents.FlatAppearance.BorderSize = 0
        Me.navResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navResidents.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navResidents.ForeColor = System.Drawing.Color.Gainsboro
        Me.navResidents.Location = New System.Drawing.Point(0, 114)
        Me.navResidents.Name = "navResidents"
        Me.navResidents.Size = New System.Drawing.Size(200, 44)
        Me.navResidents.TabIndex = 2
        Me.navResidents.Text = "  Residents"
        Me.navResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navResidents.UseVisualStyleBackColor = False
        '
        'navDashboard
        '
        Me.navDashboard.BackColor = System.Drawing.Color.Transparent
        Me.navDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.navDashboard.FlatAppearance.BorderSize = 0
        Me.navDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.navDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.navDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navDashboard.Location = New System.Drawing.Point(0, 70)
        Me.navDashboard.Name = "navDashboard"
        Me.navDashboard.Size = New System.Drawing.Size(200, 44)
        Me.navDashboard.TabIndex = 1
        Me.navDashboard.Text = "  Dashboard"
        Me.navDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navDashboard.UseVisualStyleBackColor = False
        '
        'leftHeader
        '
        Me.leftHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.leftHeader.Controls.Add(Me.lblBrand)
        Me.leftHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.leftHeader.Location = New System.Drawing.Point(0, 0)
        Me.leftHeader.Name = "leftHeader"
        Me.leftHeader.Size = New System.Drawing.Size(200, 70)
        Me.leftHeader.TabIndex = 0
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(12, 24)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(115, 21)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "eLIGAYA BIMS"
        '
        'topBar
        '
        Me.topBar.BackColor = System.Drawing.Color.White
        Me.topBar.Controls.Add(Me.lblWelcome)
        Me.topBar.Controls.Add(Me.lblAppTitle)
        Me.topBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBar.Location = New System.Drawing.Point(200, 0)
        Me.topBar.Name = "topBar"
        Me.topBar.Size = New System.Drawing.Size(1224, 48)
        Me.topBar.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(1024, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(200, 48)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, John!"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblAppTitle.Location = New System.Drawing.Point(16, 13)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(103, 21)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "eBaryo v1.1.0"
        '
        'contentHost
        '
        Me.contentHost.BackColor = System.Drawing.Color.White
        Me.contentHost.Controls.Add(Me.chartsTable)
        Me.contentHost.Controls.Add(Me.statsTable)
        Me.contentHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentHost.Location = New System.Drawing.Point(200, 48)
        Me.contentHost.Name = "contentHost"
        Me.contentHost.Padding = New System.Windows.Forms.Padding(12)
        Me.contentHost.Size = New System.Drawing.Size(1224, 813)
        Me.contentHost.TabIndex = 2
        '
        'chartsTable
        '
        Me.chartsTable.ColumnCount = 2
        Me.chartsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.chartsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.chartsTable.Controls.Add(Me.chartLeft, 0, 0)
        Me.chartsTable.Controls.Add(Me.chartRight, 1, 0)
        Me.chartsTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartsTable.Location = New System.Drawing.Point(12, 134)
        Me.chartsTable.Name = "chartsTable"
        Me.chartsTable.RowCount = 1
        Me.chartsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.chartsTable.Size = New System.Drawing.Size(1200, 667)
        Me.chartsTable.TabIndex = 1
        '
        'chartLeft
        '
        Me.chartLeft.BackColor = System.Drawing.Color.White
        Me.chartLeft.Controls.Add(Me.dgvDashboardResidents)
        Me.chartLeft.Controls.Add(Me.lblResidentsList)
        Me.chartLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartLeft.Location = New System.Drawing.Point(3, 3)
        Me.chartLeft.Name = "chartLeft"
        Me.chartLeft.Size = New System.Drawing.Size(594, 661)
        Me.chartLeft.TabIndex = 0
        '
        'dgvDashboardResidents
        '
        Me.dgvDashboardResidents.AllowUserToAddRows = False
        Me.dgvDashboardResidents.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvDashboardResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDashboardResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDashboardResidents.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDashboardResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDashboardResidents.EnableHeadersVisualStyles = False
        Me.dgvDashboardResidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgvDashboardResidents.Location = New System.Drawing.Point(0, 44)
        Me.dgvDashboardResidents.MultiSelect = False
        Me.dgvDashboardResidents.Name = "dgvDashboardResidents"
        Me.dgvDashboardResidents.ReadOnly = True
        Me.dgvDashboardResidents.RowHeadersVisible = False
        Me.dgvDashboardResidents.Size = New System.Drawing.Size(594, 617)
        Me.dgvDashboardResidents.TabIndex = 1
        '
        'lblResidentsList
        '
        Me.lblResidentsList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblResidentsList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblResidentsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblResidentsList.Location = New System.Drawing.Point(0, 0)
        Me.lblResidentsList.Name = "lblResidentsList"
        Me.lblResidentsList.Padding = New System.Windows.Forms.Padding(12, 12, 12, 6)
        Me.lblResidentsList.Size = New System.Drawing.Size(594, 44)
        Me.lblResidentsList.TabIndex = 0
        Me.lblResidentsList.Text = "Residents"
        '
        'chartRight
        '
        Me.chartRight.BackColor = System.Drawing.Color.White
        Me.chartRight.Controls.Add(Me.chartPurok)
        Me.chartRight.Controls.Add(Me.lblPurokChart)
        Me.chartRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartRight.Location = New System.Drawing.Point(603, 3)
        Me.chartRight.Name = "chartRight"
        Me.chartRight.Size = New System.Drawing.Size(594, 661)
        Me.chartRight.TabIndex = 1
        '
        'chartPurok
        '
        Me.chartPurok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartPurok.Location = New System.Drawing.Point(0, 44)
        Me.chartPurok.Name = "chartPurok"
        Me.chartPurok.Size = New System.Drawing.Size(594, 617)
        Me.chartPurok.TabIndex = 1
        Me.chartPurok.Text = "chartPurok"
        '
        'lblPurokChart
        '
        Me.lblPurokChart.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPurokChart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblPurokChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblPurokChart.Location = New System.Drawing.Point(0, 0)
        Me.lblPurokChart.Name = "lblPurokChart"
        Me.lblPurokChart.Padding = New System.Windows.Forms.Padding(12, 12, 12, 6)
        Me.lblPurokChart.Size = New System.Drawing.Size(594, 44)
        Me.lblPurokChart.TabIndex = 0
        Me.lblPurokChart.Text = "Residents by Purok"
        '
        'statsTable
        '
        Me.statsTable.ColumnCount = 6
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.75!))
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.41667!))
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.statsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.statsTable.Controls.Add(Me.cardHouseholds, 0, 0)
        Me.statsTable.Controls.Add(Me.cardPopulation, 1, 0)
        Me.statsTable.Controls.Add(Me.cardPending, 2, 0)
        Me.statsTable.Controls.Add(Me.cardVoters, 3, 0)
        Me.statsTable.Controls.Add(Me.cardCrime, 4, 0)
        Me.statsTable.Controls.Add(Me.cardIndigent, 5, 0)
        Me.statsTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.statsTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.statsTable.Location = New System.Drawing.Point(12, 12)
        Me.statsTable.Name = "statsTable"
        Me.statsTable.Padding = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.statsTable.RowCount = 1
        Me.statsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.statsTable.Size = New System.Drawing.Size(1200, 122)
        Me.statsTable.TabIndex = 0
        '
        'cardHouseholds
        '
        Me.cardHouseholds.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.cardHouseholds.Controls.Add(Me.lblHouseholdsSub)
        Me.cardHouseholds.Controls.Add(Me.lblHouseholds)
        Me.cardHouseholds.Location = New System.Drawing.Point(0, 0)
        Me.cardHouseholds.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cardHouseholds.Name = "cardHouseholds"
        Me.cardHouseholds.Size = New System.Drawing.Size(0, 98)
        Me.cardHouseholds.TabIndex = 0
        '
        'lblHouseholdsSub
        '
        Me.lblHouseholdsSub.AutoSize = True
        Me.lblHouseholdsSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblHouseholdsSub.ForeColor = System.Drawing.Color.White
        Me.lblHouseholdsSub.Location = New System.Drawing.Point(15, 50)
        Me.lblHouseholdsSub.Name = "lblHouseholdsSub"
        Me.lblHouseholdsSub.Size = New System.Drawing.Size(77, 17)
        Me.lblHouseholdsSub.TabIndex = 1
        Me.lblHouseholdsSub.Text = "Households"
        '
        'lblHouseholds
        '
        Me.lblHouseholds.AutoSize = True
        Me.lblHouseholds.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHouseholds.ForeColor = System.Drawing.Color.White
        Me.lblHouseholds.Location = New System.Drawing.Point(12, 10)
        Me.lblHouseholds.Name = "lblHouseholds"
        Me.lblHouseholds.Size = New System.Drawing.Size(66, 32)
        Me.lblHouseholds.TabIndex = 0
        Me.lblHouseholds.Text = "1,310"
        '
        'cardPopulation
        '
        Me.cardPopulation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.cardPopulation.Controls.Add(Me.lblPopulationSub)
        Me.cardPopulation.Controls.Add(Me.lblPopulation)
        Me.cardPopulation.Location = New System.Drawing.Point(213, 0)
        Me.cardPopulation.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cardPopulation.Name = "cardPopulation"
        Me.cardPopulation.Size = New System.Drawing.Size(0, 98)
        Me.cardPopulation.TabIndex = 1
        '
        'lblPopulationSub
        '
        Me.lblPopulationSub.AutoSize = True
        Me.lblPopulationSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblPopulationSub.ForeColor = System.Drawing.Color.White
        Me.lblPopulationSub.Location = New System.Drawing.Point(15, 50)
        Me.lblPopulationSub.Name = "lblPopulationSub"
        Me.lblPopulationSub.Size = New System.Drawing.Size(70, 17)
        Me.lblPopulationSub.TabIndex = 1
        Me.lblPopulationSub.Text = "Population"
        '
        'lblPopulation
        '
        Me.lblPopulation.AutoSize = True
        Me.lblPopulation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblPopulation.ForeColor = System.Drawing.Color.White
        Me.lblPopulation.Location = New System.Drawing.Point(12, 10)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(70, 32)
        Me.lblPopulation.TabIndex = 0
        Me.lblPopulation.Text = "1,640"
        '
        'cardPending
        '
        Me.cardPending.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cardPending.Controls.Add(Me.lblPendingSub)
        Me.cardPending.Controls.Add(Me.lblPending)
        Me.cardPending.Location = New System.Drawing.Point(398, 0)
        Me.cardPending.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cardPending.Name = "cardPending"
        Me.cardPending.Size = New System.Drawing.Size(0, 98)
        Me.cardPending.TabIndex = 2
        '
        'lblPendingSub
        '
        Me.lblPendingSub.AutoSize = True
        Me.lblPendingSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblPendingSub.ForeColor = System.Drawing.Color.White
        Me.lblPendingSub.Location = New System.Drawing.Point(15, 50)
        Me.lblPendingSub.Name = "lblPendingSub"
        Me.lblPendingSub.Size = New System.Drawing.Size(135, 17)
        Me.lblPendingSub.TabIndex = 1
        Me.lblPendingSub.Text = "Total Pending Blotters"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblPending.ForeColor = System.Drawing.Color.White
        Me.lblPending.Location = New System.Drawing.Point(12, 10)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(51, 32)
        Me.lblPending.TabIndex = 0
        Me.lblPending.Text = "514"
        '
        'cardVoters
        '
        Me.cardVoters.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cardVoters.Controls.Add(Me.lblVotersSub)
        Me.cardVoters.Controls.Add(Me.lblVoters)
        Me.cardVoters.Location = New System.Drawing.Point(598, 0)
        Me.cardVoters.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cardVoters.Name = "cardVoters"
        Me.cardVoters.Size = New System.Drawing.Size(0, 98)
        Me.cardVoters.TabIndex = 3
        '
        'lblVotersSub
        '
        Me.lblVotersSub.AutoSize = True
        Me.lblVotersSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblVotersSub.ForeColor = System.Drawing.Color.White
        Me.lblVotersSub.Location = New System.Drawing.Point(15, 50)
        Me.lblVotersSub.Name = "lblVotersSub"
        Me.lblVotersSub.Size = New System.Drawing.Size(112, 17)
        Me.lblVotersSub.TabIndex = 1
        Me.lblVotersSub.Text = "Registered Voters"
        '
        'lblVoters
        '
        Me.lblVoters.AutoSize = True
        Me.lblVoters.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblVoters.ForeColor = System.Drawing.Color.White
        Me.lblVoters.Location = New System.Drawing.Point(12, 10)
        Me.lblVoters.Name = "lblVoters"
        Me.lblVoters.Size = New System.Drawing.Size(63, 32)
        Me.lblVoters.TabIndex = 0
        Me.lblVoters.Text = "1,311"
        '
        'cardCrime
        '
        Me.cardCrime.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.cardCrime.Controls.Add(Me.lblCrimeSub)
        Me.cardCrime.Controls.Add(Me.lblCrime)
        Me.cardCrime.Location = New System.Drawing.Point(798, 0)
        Me.cardCrime.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cardCrime.Name = "cardCrime"
        Me.cardCrime.Size = New System.Drawing.Size(0, 98)
        Me.cardCrime.TabIndex = 4
        '
        'lblCrimeSub
        '
        Me.lblCrimeSub.AutoSize = True
        Me.lblCrimeSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblCrimeSub.ForeColor = System.Drawing.Color.White
        Me.lblCrimeSub.Location = New System.Drawing.Point(15, 50)
        Me.lblCrimeSub.Name = "lblCrimeSub"
        Me.lblCrimeSub.Size = New System.Drawing.Size(92, 17)
        Me.lblCrimeSub.TabIndex = 1
        Me.lblCrimeSub.Text = "Crime Reports"
        '
        'lblCrime
        '
        Me.lblCrime.AutoSize = True
        Me.lblCrime.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblCrime.ForeColor = System.Drawing.Color.White
        Me.lblCrime.Location = New System.Drawing.Point(12, 10)
        Me.lblCrime.Name = "lblCrime"
        Me.lblCrime.Size = New System.Drawing.Size(40, 32)
        Me.lblCrime.TabIndex = 0
        Me.lblCrime.Text = "27"
        '
        'cardIndigent
        '
        Me.cardIndigent.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cardIndigent.Controls.Add(Me.lblIndigentSub)
        Me.cardIndigent.Controls.Add(Me.lblIndigent)
        Me.cardIndigent.Location = New System.Drawing.Point(998, 0)
        Me.cardIndigent.Margin = New System.Windows.Forms.Padding(0)
        Me.cardIndigent.Name = "cardIndigent"
        Me.cardIndigent.Size = New System.Drawing.Size(0, 110)
        Me.cardIndigent.TabIndex = 5
        '
        'lblIndigentSub
        '
        Me.lblIndigentSub.AutoSize = True
        Me.lblIndigentSub.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblIndigentSub.ForeColor = System.Drawing.Color.White
        Me.lblIndigentSub.Location = New System.Drawing.Point(15, 50)
        Me.lblIndigentSub.Name = "lblIndigentSub"
        Me.lblIndigentSub.Size = New System.Drawing.Size(105, 17)
        Me.lblIndigentSub.TabIndex = 1
        Me.lblIndigentSub.Text = "Indigent Families"
        '
        'lblIndigent
        '
        Me.lblIndigent.AutoSize = True
        Me.lblIndigent.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblIndigent.ForeColor = System.Drawing.Color.White
        Me.lblIndigent.Location = New System.Drawing.Point(12, 10)
        Me.lblIndigent.Name = "lblIndigent"
        Me.lblIndigent.Size = New System.Drawing.Size(51, 32)
        Me.lblIndigent.TabIndex = 0
        Me.lblIndigent.Text = "341"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.contentHost)
        Me.Controls.Add(Me.topBar)
        Me.Controls.Add(Me.leftNav)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.leftNav.ResumeLayout(False)
        Me.leftHeader.ResumeLayout(False)
        Me.leftHeader.PerformLayout()
        Me.topBar.ResumeLayout(False)
        Me.topBar.PerformLayout()
        Me.contentHost.ResumeLayout(False)
        Me.chartsTable.ResumeLayout(False)
        Me.chartLeft.ResumeLayout(False)
        CType(Me.dgvDashboardResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chartRight.ResumeLayout(False)
        CType(Me.chartPurok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statsTable.ResumeLayout(False)
        Me.cardHouseholds.ResumeLayout(False)
        Me.cardHouseholds.PerformLayout()
        Me.cardPopulation.ResumeLayout(False)
        Me.cardPopulation.PerformLayout()
        Me.cardPending.ResumeLayout(False)
        Me.cardPending.PerformLayout()
        Me.cardVoters.ResumeLayout(False)
        Me.cardVoters.PerformLayout()
        Me.cardCrime.ResumeLayout(False)
        Me.cardCrime.PerformLayout()
        Me.cardIndigent.ResumeLayout(False)
        Me.cardIndigent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leftNav As System.Windows.Forms.Panel
    Friend WithEvents leftHeader As System.Windows.Forms.Panel
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents navDashboard As System.Windows.Forms.Button
    Friend WithEvents navResidents As System.Windows.Forms.Button
    Friend WithEvents navReports As System.Windows.Forms.Button
    Friend WithEvents navCedula As System.Windows.Forms.Button
    Friend WithEvents navDocs As System.Windows.Forms.Button
    Friend WithEvents navStaffs As System.Windows.Forms.Button
    Friend WithEvents navBackup As System.Windows.Forms.Button
    Friend WithEvents navLogout As System.Windows.Forms.Button
    Friend WithEvents topBar As System.Windows.Forms.Panel
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents contentHost As System.Windows.Forms.Panel
    Friend WithEvents statsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cardHouseholds As System.Windows.Forms.Panel
    Friend WithEvents lblHouseholds As System.Windows.Forms.Label
    Friend WithEvents lblHouseholdsSub As System.Windows.Forms.Label
    Friend WithEvents chartsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chartLeft As System.Windows.Forms.Panel
    Friend WithEvents chartRight As System.Windows.Forms.Panel
		Friend WithEvents dgvDashboardResidents As System.Windows.Forms.DataGridView
		Friend WithEvents lblResidentsList As System.Windows.Forms.Label
		Friend WithEvents chartPurok As System.Windows.Forms.DataVisualization.Charting.Chart
		Friend WithEvents lblPurokChart As System.Windows.Forms.Label
    Friend WithEvents cardPopulation As System.Windows.Forms.Panel
    Friend WithEvents lblPopulationSub As System.Windows.Forms.Label
    Friend WithEvents lblPopulation As System.Windows.Forms.Label
    Friend WithEvents cardPending As System.Windows.Forms.Panel
    Friend WithEvents lblPendingSub As System.Windows.Forms.Label
    Friend WithEvents lblPending As System.Windows.Forms.Label
    Friend WithEvents cardVoters As System.Windows.Forms.Panel
    Friend WithEvents lblVotersSub As System.Windows.Forms.Label
    Friend WithEvents lblVoters As System.Windows.Forms.Label
    Friend WithEvents cardCrime As System.Windows.Forms.Panel
    Friend WithEvents lblCrimeSub As System.Windows.Forms.Label
    Friend WithEvents lblCrime As System.Windows.Forms.Label
    Friend WithEvents cardIndigent As System.Windows.Forms.Panel
    Friend WithEvents lblIndigentSub As System.Windows.Forms.Label
    Friend WithEvents lblIndigent As System.Windows.Forms.Label
End Class
