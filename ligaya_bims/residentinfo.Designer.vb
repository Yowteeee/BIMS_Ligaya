Imports ligaya_bims

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblShowEntries = New System.Windows.Forms.Label()
        Me.btnNewResident = New ligaya_bims.RoundedButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbShowEntries = New System.Windows.Forms.ComboBox()
        Me.dgvResidents = New System.Windows.Forms.DataGridView()
        Me.chkSelectAll = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.lblReligion = New System.Windows.Forms.Label()
        Me.cmbVotersStatus = New System.Windows.Forms.ComboBox()
        Me.lblVotersStatus = New System.Windows.Forms.Label()
        Me.txtSpouse = New System.Windows.Forms.TextBox()
        Me.lblSpouse = New System.Windows.Forms.Label()
        Me.txtMothersName = New System.Windows.Forms.TextBox()
        Me.lblMothersName = New System.Windows.Forms.Label()
        Me.txtFathersName = New System.Windows.Forms.TextBox()
        Me.lblFathersName = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.lblCitizenship = New System.Windows.Forms.Label()
        Me.cmbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.panelLeft.SuspendLayout()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRight.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLeft
        '
        Me.panelLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.lblTitle)
        Me.panelLeft.Controls.Add(Me.lblShowEntries)
        Me.panelLeft.Controls.Add(Me.btnNewResident)
        Me.panelLeft.Controls.Add(Me.txtSearch)
        Me.panelLeft.Controls.Add(Me.cmbShowEntries)
        Me.panelLeft.Controls.Add(Me.dgvResidents)
        Me.panelLeft.Location = New System.Drawing.Point(12, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Padding = New System.Windows.Forms.Padding(20)
        Me.panelLeft.Size = New System.Drawing.Size(575, 700)
        Me.panelLeft.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(15, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resident Information"
        '
        'lblShowEntries
        '
        Me.lblShowEntries.AutoSize = True
        Me.lblShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblShowEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblShowEntries.Location = New System.Drawing.Point(23, 656)
        Me.lblShowEntries.Name = "lblShowEntries"
        Me.lblShowEntries.Size = New System.Drawing.Size(53, 15)
        Me.lblShowEntries.TabIndex = 8
        Me.lblShowEntries.Text = "Showing"
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
        Me.btnNewResident.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(352, 102)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.TabIndex = 4
        '
        'cmbShowEntries
        '
        Me.cmbShowEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbShowEntries.Items.AddRange(New Object() {"10", "25", "50", "100"})
        Me.cmbShowEntries.Location = New System.Drawing.Point(23, 156)
        Me.cmbShowEntries.Name = "cmbShowEntries"
        Me.cmbShowEntries.Size = New System.Drawing.Size(93, 23)
        Me.cmbShowEntries.TabIndex = 6
        '
        'dgvResidents
        '
        Me.dgvResidents.AllowUserToAddRows = False
        Me.dgvResidents.AllowUserToDeleteRows = False
        Me.dgvResidents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResidents.BackgroundColor = System.Drawing.Color.White
        Me.dgvResidents.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResidents.ColumnHeadersHeight = 45
        Me.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResidents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelectAll, Me.colID, Me.colLastName, Me.colFirstName, Me.colMiddleName, Me.colMobileNo, Me.colGender, Me.colAction})
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
        Me.dgvResidents.Location = New System.Drawing.Point(23, 203)
        Me.dgvResidents.MultiSelect = False
        Me.dgvResidents.Name = "dgvResidents"
        Me.dgvResidents.ReadOnly = True
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvResidents.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResidents.RowTemplate.Height = 40
        Me.dgvResidents.Size = New System.Drawing.Size(532, 438)
        Me.dgvResidents.TabIndex = 7
        '
        'chkSelectAll
        '
        Me.chkSelectAll.HeaderText = ""
        Me.chkSelectAll.MinimumWidth = 6
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.ReadOnly = True
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colLastName
        '
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.MinimumWidth = 6
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        Me.colLastName.Width = 200
        '
        'colFirstName
        '
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.MinimumWidth = 6
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        Me.colFirstName.Width = 200
        '
        'colMiddleName
        '
        Me.colMiddleName.HeaderText = "Middle Name"
        Me.colMiddleName.MinimumWidth = 6
        Me.colMiddleName.Name = "colMiddleName"
        Me.colMiddleName.ReadOnly = True
        Me.colMiddleName.Width = 200
        '
        'colMobileNo
        '
        Me.colMobileNo.HeaderText = "Mobile No."
        Me.colMobileNo.MinimumWidth = 6
        Me.colMobileNo.Name = "colMobileNo"
        Me.colMobileNo.ReadOnly = True
        Me.colMobileNo.Width = 210
        '
        'colGender
        '
        Me.colGender.HeaderText = "Gender"
        Me.colGender.MinimumWidth = 6
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.Width = 141
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(891, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SEARCH:"
        '
        'colAction
        '
        Me.colAction.HeaderText = "Action"
        Me.colAction.MinimumWidth = 6
        Me.colAction.Name = "colAction"
        Me.colAction.ReadOnly = True
        '
        'panelRight
        '
        Me.panelRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRight.BackColor = System.Drawing.Color.White
        Me.panelRight.Controls.Add(Me.txtAddress)
        Me.panelRight.Controls.Add(Me.lblAddress)
        Me.panelRight.Controls.Add(Me.txtWeight)
        Me.panelRight.Controls.Add(Me.lblWeight)
        Me.panelRight.Controls.Add(Me.txtHeight)
        Me.panelRight.Controls.Add(Me.lblHeight)
        Me.panelRight.Controls.Add(Me.txtReligion)
        Me.panelRight.Controls.Add(Me.lblReligion)
        Me.panelRight.Controls.Add(Me.cmbVotersStatus)
        Me.panelRight.Controls.Add(Me.lblVotersStatus)
        Me.panelRight.Controls.Add(Me.txtSpouse)
        Me.panelRight.Controls.Add(Me.lblSpouse)
        Me.panelRight.Controls.Add(Me.txtMothersName)
        Me.panelRight.Controls.Add(Me.lblMothersName)
        Me.panelRight.Controls.Add(Me.txtFathersName)
        Me.panelRight.Controls.Add(Me.lblFathersName)
        Me.panelRight.Controls.Add(Me.txtPhoneNumber)
        Me.panelRight.Controls.Add(Me.lblPhoneNumber)
        Me.panelRight.Controls.Add(Me.txtCitizenship)
        Me.panelRight.Controls.Add(Me.lblCitizenship)
        Me.panelRight.Controls.Add(Me.cmbCivilStatus)
        Me.panelRight.Controls.Add(Me.lblCivilStatus)
        Me.panelRight.Controls.Add(Me.txtAge)
        Me.panelRight.Controls.Add(Me.lblAge)
        Me.panelRight.Controls.Add(Me.dtpBirthdate)
        Me.panelRight.Controls.Add(Me.lblBirthdate)
        Me.panelRight.Controls.Add(Me.cmbGender)
        Me.panelRight.Controls.Add(Me.lblGender)
        Me.panelRight.Controls.Add(Me.txtMiddleName)
        Me.panelRight.Controls.Add(Me.lblMiddleName)
        Me.panelRight.Controls.Add(Me.txtFirstName)
        Me.panelRight.Controls.Add(Me.lblFirstName)
        Me.panelRight.Controls.Add(Me.txtLastName)
        Me.panelRight.Controls.Add(Me.lblLastName)
        Me.panelRight.Controls.Add(Me.picProfile)
        Me.panelRight.Controls.Add(Me.lblInfoTitle)
        Me.panelRight.Location = New System.Drawing.Point(600, 0)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(575, 700)
        Me.panelRight.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(300, 568)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(250, 73)
        Me.txtAddress.TabIndex = 35
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(300, 550)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 15)
        Me.lblAddress.TabIndex = 34
        Me.lblAddress.Text = "Address:"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtWeight.Location = New System.Drawing.Point(300, 518)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(250, 23)
        Me.txtWeight.TabIndex = 33
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWeight.Location = New System.Drawing.Point(300, 500)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(48, 15)
        Me.lblWeight.TabIndex = 32
        Me.lblWeight.Text = "Weight:"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHeight.Location = New System.Drawing.Point(300, 468)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(250, 23)
        Me.txtHeight.TabIndex = 31
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHeight.Location = New System.Drawing.Point(300, 450)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(46, 15)
        Me.lblHeight.TabIndex = 30
        Me.lblHeight.Text = "Height:"
        '
        'txtReligion
        '
        Me.txtReligion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReligion.Location = New System.Drawing.Point(300, 418)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.ReadOnly = True
        Me.txtReligion.Size = New System.Drawing.Size(250, 23)
        Me.txtReligion.TabIndex = 29
        '
        'lblReligion
        '
        Me.lblReligion.AutoSize = True
        Me.lblReligion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblReligion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblReligion.Location = New System.Drawing.Point(300, 400)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(53, 15)
        Me.lblReligion.TabIndex = 28
        Me.lblReligion.Text = "Religion:"
        '
        'cmbVotersStatus
        '
        Me.cmbVotersStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVotersStatus.Enabled = False
        Me.cmbVotersStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbVotersStatus.FormattingEnabled = True
        Me.cmbVotersStatus.Items.AddRange(New Object() {"Registered", "Not Registered"})
        Me.cmbVotersStatus.Location = New System.Drawing.Point(300, 368)
        Me.cmbVotersStatus.Name = "cmbVotersStatus"
        Me.cmbVotersStatus.Size = New System.Drawing.Size(250, 23)
        Me.cmbVotersStatus.TabIndex = 27
        '
        'lblVotersStatus
        '
        Me.lblVotersStatus.AutoSize = True
        Me.lblVotersStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVotersStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVotersStatus.Location = New System.Drawing.Point(300, 350)
        Me.lblVotersStatus.Name = "lblVotersStatus"
        Me.lblVotersStatus.Size = New System.Drawing.Size(77, 15)
        Me.lblVotersStatus.TabIndex = 26
        Me.lblVotersStatus.Text = "Voters Status:"
        '
        'txtSpouse
        '
        Me.txtSpouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSpouse.Location = New System.Drawing.Point(300, 318)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.ReadOnly = True
        Me.txtSpouse.Size = New System.Drawing.Size(250, 23)
        Me.txtSpouse.TabIndex = 25
        '
        'lblSpouse
        '
        Me.lblSpouse.AutoSize = True
        Me.lblSpouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSpouse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSpouse.Location = New System.Drawing.Point(300, 300)
        Me.lblSpouse.Name = "lblSpouse"
        Me.lblSpouse.Size = New System.Drawing.Size(48, 15)
        Me.lblSpouse.TabIndex = 24
        Me.lblSpouse.Text = "Spouse:"
        '
        'txtMothersName
        '
        Me.txtMothersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMothersName.Location = New System.Drawing.Point(300, 268)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.ReadOnly = True
        Me.txtMothersName.Size = New System.Drawing.Size(250, 23)
        Me.txtMothersName.TabIndex = 23
        '
        'lblMothersName
        '
        Me.lblMothersName.AutoSize = True
        Me.lblMothersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMothersName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMothersName.Location = New System.Drawing.Point(300, 250)
        Me.lblMothersName.Name = "lblMothersName"
        Me.lblMothersName.Size = New System.Drawing.Size(92, 15)
        Me.lblMothersName.TabIndex = 22
        Me.lblMothersName.Text = "Mother's Name:"
        '
        'txtFathersName
        '
        Me.txtFathersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFathersName.Location = New System.Drawing.Point(300, 218)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.ReadOnly = True
        Me.txtFathersName.Size = New System.Drawing.Size(250, 23)
        Me.txtFathersName.TabIndex = 21
        '
        'lblFathersName
        '
        Me.lblFathersName.AutoSize = True
        Me.lblFathersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFathersName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFathersName.Location = New System.Drawing.Point(300, 200)
        Me.lblFathersName.Name = "lblFathersName"
        Me.lblFathersName.Size = New System.Drawing.Size(86, 15)
        Me.lblFathersName.TabIndex = 20
        Me.lblFathersName.Text = "Father's Name:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(20, 618)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(250, 23)
        Me.txtPhoneNumber.TabIndex = 19
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(20, 600)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(91, 15)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCitizenship.Location = New System.Drawing.Point(20, 568)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.ReadOnly = True
        Me.txtCitizenship.Size = New System.Drawing.Size(250, 23)
        Me.txtCitizenship.TabIndex = 17
        '
        'lblCitizenship
        '
        Me.lblCitizenship.AutoSize = True
        Me.lblCitizenship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCitizenship.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCitizenship.Location = New System.Drawing.Point(20, 550)
        Me.lblCitizenship.Name = "lblCitizenship"
        Me.lblCitizenship.Size = New System.Drawing.Size(68, 15)
        Me.lblCitizenship.TabIndex = 16
        Me.lblCitizenship.Text = "Citizenship:"
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCivilStatus.Enabled = False
        Me.cmbCivilStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced", "Separated"})
        Me.cmbCivilStatus.Location = New System.Drawing.Point(20, 518)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(250, 23)
        Me.cmbCivilStatus.TabIndex = 15
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        Me.lblCivilStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCivilStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCivilStatus.Location = New System.Drawing.Point(20, 500)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(68, 15)
        Me.lblCivilStatus.TabIndex = 14
        Me.lblCivilStatus.Text = "Civil Status:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAge.Location = New System.Drawing.Point(20, 468)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(250, 23)
        Me.txtAge.TabIndex = 13
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(20, 450)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(31, 15)
        Me.lblAge.TabIndex = 12
        Me.lblAge.Text = "Age:"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Enabled = False
        Me.dtpBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(20, 418)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(250, 23)
        Me.dtpBirthdate.TabIndex = 11
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthdate.Location = New System.Drawing.Point(20, 400)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(58, 15)
        Me.lblBirthdate.TabIndex = 10
        Me.lblBirthdate.Text = "Birthdate:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Enabled = False
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(20, 368)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(250, 23)
        Me.cmbGender.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(20, 350)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(48, 15)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(20, 318)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(250, 23)
        Me.txtMiddleName.TabIndex = 7
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(20, 300)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(82, 15)
        Me.lblMiddleName.TabIndex = 6
        Me.lblMiddleName.Text = "Middle Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(20, 268)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(250, 23)
        Me.txtFirstName.TabIndex = 5
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(20, 250)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(67, 15)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.Location = New System.Drawing.Point(20, 218)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(250, 23)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(20, 200)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(66, 15)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfile.Location = New System.Drawing.Point(20, 60)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(120, 120)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 1
        Me.picProfile.TabStop = False
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.AutoSize = True
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblInfoTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(159, 32)
        Me.lblInfoTitle.TabIndex = 0
        Me.lblInfoTitle.Text = "Information:"
        '
        'residentinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1375, 800)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.panelLeft)
        Me.Name = "residentinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resident Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelLeft.ResumeLayout(False)
        Me.panelLeft.PerformLayout()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRight.ResumeLayout(False)
        Me.panelRight.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Function Label1() As Object
        Throw New NotImplementedException()
    End Function

    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents panelRight As System.Windows.Forms.Panel
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblShowEntries As System.Windows.Forms.Label
    Friend WithEvents btnNewResident As ligaya_bims.RoundedButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbShowEntries As System.Windows.Forms.ComboBox
    Friend WithEvents dgvResidents As System.Windows.Forms.DataGridView
    Friend WithEvents chkSelectAll As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobileNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblCivilStatus As System.Windows.Forms.Label
    Friend WithEvents cmbCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblCitizenship As System.Windows.Forms.Label
    Friend WithEvents txtCitizenship As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFathersName As System.Windows.Forms.Label
    Friend WithEvents txtFathersName As System.Windows.Forms.TextBox
    Friend WithEvents lblMothersName As System.Windows.Forms.Label
    Friend WithEvents txtMothersName As System.Windows.Forms.TextBox
    Friend WithEvents lblSpouse As System.Windows.Forms.Label
    Friend WithEvents txtSpouse As System.Windows.Forms.TextBox
    Friend WithEvents lblVotersStatus As System.Windows.Forms.Label
    Friend WithEvents cmbVotersStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblReligion As System.Windows.Forms.Label
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
End Class
