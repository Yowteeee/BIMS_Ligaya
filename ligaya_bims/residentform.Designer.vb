<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class residentform
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.pnlIdPicture = New System.Windows.Forms.Panel()
        Me.picIdPicture = New System.Windows.Forms.PictureBox()
        Me.btnChoosePicture = New System.Windows.Forms.Button()
        Me.lblIdPicture = New System.Windows.Forms.Label()
        Me.pnlFields = New System.Windows.Forms.Panel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ofdIdPicture = New System.Windows.Forms.OpenFileDialog()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblVotersStatus = New System.Windows.Forms.Label()
        Me.cmbVotersStatus = New System.Windows.Forms.ComboBox()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.cmbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.lblCitizenship = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSpouse = New System.Windows.Forms.Label()
        Me.lblFathersName = New System.Windows.Forms.Label()
        Me.lblMothersName = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFathersName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSpouse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtHeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMothersName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ButtonCANCEL = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlIdPicture.SuspendLayout()
        CType(Me.picIdPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFields.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlForm)
        Me.pnlMain.Controls.Add(Me.pnlButtons)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(1000, 700)
        Me.pnlMain.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.pnlIdPicture)
        Me.pnlForm.Controls.Add(Me.pnlFields)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(20, 20)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(960, 620)
        Me.pnlForm.TabIndex = 0
        '
        'pnlIdPicture
        '
        Me.pnlIdPicture.BackColor = System.Drawing.Color.White
        Me.pnlIdPicture.Controls.Add(Me.ButtonCANCEL)
        Me.pnlIdPicture.Controls.Add(Me.btnSubmit)
        Me.pnlIdPicture.Controls.Add(Me.picIdPicture)
        Me.pnlIdPicture.Controls.Add(Me.btnChoosePicture)
        Me.pnlIdPicture.Controls.Add(Me.lblIdPicture)
        Me.pnlIdPicture.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlIdPicture.Location = New System.Drawing.Point(660, 0)
        Me.pnlIdPicture.Name = "pnlIdPicture"
        Me.pnlIdPicture.Size = New System.Drawing.Size(300, 620)
        Me.pnlIdPicture.TabIndex = 1
        '
        'picIdPicture
        '
        Me.picIdPicture.BackColor = System.Drawing.Color.White
        Me.picIdPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIdPicture.Location = New System.Drawing.Point(52, 51)
        Me.picIdPicture.Name = "picIdPicture"
        Me.picIdPicture.Size = New System.Drawing.Size(200, 189)
        Me.picIdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIdPicture.TabIndex = 2
        Me.picIdPicture.TabStop = False
        '
        'btnChoosePicture
        '
        Me.btnChoosePicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChoosePicture.FlatAppearance.BorderSize = 0
        Me.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoosePicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePicture.ForeColor = System.Drawing.Color.White
        Me.btnChoosePicture.Location = New System.Drawing.Point(52, 270)
        Me.btnChoosePicture.Name = "btnChoosePicture"
        Me.btnChoosePicture.Size = New System.Drawing.Size(200, 47)
        Me.btnChoosePicture.TabIndex = 1
        Me.btnChoosePicture.Text = "Choose File"
        Me.btnChoosePicture.UseVisualStyleBackColor = False
        '
        'lblIdPicture
        '
        Me.lblIdPicture.AutoSize = True
        Me.lblIdPicture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblIdPicture.Location = New System.Drawing.Point(50, 20)
        Me.lblIdPicture.Name = "lblIdPicture"
        Me.lblIdPicture.Size = New System.Drawing.Size(85, 21)
        Me.lblIdPicture.TabIndex = 0
        Me.lblIdPicture.Text = "ID Picture"
        '
        'pnlFields
        '
        Me.pnlFields.BackColor = System.Drawing.Color.White
        Me.pnlFields.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnlFields.Controls.Add(Me.txtPhoneNumber)
        Me.pnlFields.Controls.Add(Me.txtMothersName)
        Me.pnlFields.Controls.Add(Me.txtEmail)
        Me.pnlFields.Controls.Add(Me.txtHeight)
        Me.pnlFields.Controls.Add(Me.txtSpouse)
        Me.pnlFields.Controls.Add(Me.txtFathersName)
        Me.pnlFields.Controls.Add(Me.txtWeight)
        Me.pnlFields.Controls.Add(Me.txtCitizenship)
        Me.pnlFields.Controls.Add(Me.txtMiddleName)
        Me.pnlFields.Controls.Add(Me.txtFirstName)
        Me.pnlFields.Controls.Add(Me.txtLastName)
        Me.pnlFields.Controls.Add(Me.lblMothersName)
        Me.pnlFields.Controls.Add(Me.lblFathersName)
        Me.pnlFields.Controls.Add(Me.lblSpouse)
        Me.pnlFields.Controls.Add(Me.lblEmail)
        Me.pnlFields.Controls.Add(Me.lblWeight)
        Me.pnlFields.Controls.Add(Me.lblHeight)
        Me.pnlFields.Controls.Add(Me.lblPhoneNumber)
        Me.pnlFields.Controls.Add(Me.lblCitizenship)
        Me.pnlFields.Controls.Add(Me.cmbCivilStatus)
        Me.pnlFields.Controls.Add(Me.lblCivilStatus)
        Me.pnlFields.Controls.Add(Me.cmbVotersStatus)
        Me.pnlFields.Controls.Add(Me.lblVotersStatus)
        Me.pnlFields.Controls.Add(Me.cmbGender)
        Me.pnlFields.Controls.Add(Me.lblGender)
        Me.pnlFields.Controls.Add(Me.txtAge)
        Me.pnlFields.Controls.Add(Me.lblAge)
        Me.pnlFields.Controls.Add(Me.dtpBirthDate)
        Me.pnlFields.Controls.Add(Me.lblBirthDate)
        Me.pnlFields.Controls.Add(Me.lblMiddleName)
        Me.pnlFields.Controls.Add(Me.lblFirstName)
        Me.pnlFields.Controls.Add(Me.lblLastName)
        Me.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFields.Location = New System.Drawing.Point(0, 0)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFields.Size = New System.Drawing.Size(960, 620)
        Me.pnlFields.TabIndex = 0
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(20, 640)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(960, 40)
        Me.pnlButtons.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(800, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(880, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ofdIdPicture
        '
        Me.ofdIdPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
        Me.ofdIdPicture.Title = "Select ID Picture"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(19, 82)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(74, 19)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(19, 152)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(75, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMiddleName.Location = New System.Drawing.Point(19, 213)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(91, 19)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBirthDate.Location = New System.Drawing.Point(23, 349)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(71, 19)
        Me.lblBirthDate.TabIndex = 6
        Me.lblBirthDate.Text = "Birth Date"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(23, 369)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(145, 25)
        Me.dtpBirthDate.TabIndex = 7
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAge.Location = New System.Drawing.Point(23, 406)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 19)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAge.Location = New System.Drawing.Point(23, 426)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(145, 25)
        Me.txtAge.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGender.Location = New System.Drawing.Point(23, 286)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(54, 19)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(23, 306)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(145, 25)
        Me.cmbGender.TabIndex = 11
        '
        'lblVotersStatus
        '
        Me.lblVotersStatus.AutoSize = True
        Me.lblVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblVotersStatus.Location = New System.Drawing.Point(249, 466)
        Me.lblVotersStatus.Name = "lblVotersStatus"
        Me.lblVotersStatus.Size = New System.Drawing.Size(90, 19)
        Me.lblVotersStatus.TabIndex = 12
        Me.lblVotersStatus.Text = "Voters Status"
        '
        'cmbVotersStatus
        '
        Me.cmbVotersStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVotersStatus.FormattingEnabled = True
        Me.cmbVotersStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbVotersStatus.Location = New System.Drawing.Point(249, 486)
        Me.cmbVotersStatus.Name = "cmbVotersStatus"
        Me.cmbVotersStatus.Size = New System.Drawing.Size(180, 25)
        Me.cmbVotersStatus.TabIndex = 13
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        Me.lblCivilStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCivilStatus.Location = New System.Drawing.Point(249, 85)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(76, 19)
        Me.lblCivilStatus.TabIndex = 14
        Me.lblCivilStatus.Text = "Civil Status"
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCivilStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cmbCivilStatus.Location = New System.Drawing.Point(249, 105)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(180, 25)
        Me.cmbCivilStatus.TabIndex = 15
        '
        'lblCitizenship
        '
        Me.lblCitizenship.AutoSize = True
        Me.lblCitizenship.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCitizenship.Location = New System.Drawing.Point(245, 152)
        Me.lblCitizenship.Name = "lblCitizenship"
        Me.lblCitizenship.Size = New System.Drawing.Size(75, 19)
        Me.lblCitizenship.TabIndex = 16
        Me.lblCitizenship.Text = "Citizenship"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(23, 458)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(102, 19)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblHeight.Location = New System.Drawing.Point(487, 152)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(50, 19)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWeight.Location = New System.Drawing.Point(487, 82)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 19)
        Me.lblWeight.TabIndex = 22
        Me.lblWeight.Text = "Weight"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(249, 403)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 19)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "Email"
        '
        'lblSpouse
        '
        Me.lblSpouse.AutoSize = True
        Me.lblSpouse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSpouse.Location = New System.Drawing.Point(249, 333)
        Me.lblSpouse.Name = "lblSpouse"
        Me.lblSpouse.Size = New System.Drawing.Size(53, 19)
        Me.lblSpouse.TabIndex = 26
        Me.lblSpouse.Text = "Spouse"
        '
        'lblFathersName
        '
        Me.lblFathersName.AutoSize = True
        Me.lblFathersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFathersName.Location = New System.Drawing.Point(245, 210)
        Me.lblFathersName.Name = "lblFathersName"
        Me.lblFathersName.Size = New System.Drawing.Size(97, 19)
        Me.lblFathersName.TabIndex = 28
        Me.lblFathersName.Text = "Father's Name"
        '
        'lblMothersName
        '
        Me.lblMothersName.AutoSize = True
        Me.lblMothersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMothersName.Location = New System.Drawing.Point(249, 270)
        Me.lblMothersName.Name = "lblMothersName"
        Me.lblMothersName.Size = New System.Drawing.Size(104, 19)
        Me.lblMothersName.TabIndex = 30
        Me.lblMothersName.Text = "Mother's Name"
        '
        'txtLastName
        '
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(23, 104)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(200, 35)
        Me.txtLastName.TabIndex = 32
        '
        'txtFirstName
        '
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(23, 174)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(200, 36)
        Me.txtFirstName.TabIndex = 33
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Location = New System.Drawing.Point(23, 232)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PlaceholderText = ""
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.Size = New System.Drawing.Size(200, 36)
        Me.txtMiddleName.TabIndex = 34
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCitizenship.DefaultText = ""
        Me.txtCitizenship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCitizenship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCitizenship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCitizenship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Location = New System.Drawing.Point(249, 174)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.PlaceholderText = ""
        Me.txtCitizenship.SelectedText = ""
        Me.txtCitizenship.Size = New System.Drawing.Size(176, 26)
        Me.txtCitizenship.TabIndex = 35
        '
        'txtWeight
        '
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = ""
        Me.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(487, 104)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PlaceholderText = ""
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.Size = New System.Drawing.Size(125, 26)
        Me.txtWeight.TabIndex = 36
        '
        'txtFathersName
        '
        Me.txtFathersName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFathersName.DefaultText = ""
        Me.txtFathersName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFathersName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFathersName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFathersName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFathersName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFathersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFathersName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFathersName.Location = New System.Drawing.Point(249, 232)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.PlaceholderText = ""
        Me.txtFathersName.SelectedText = ""
        Me.txtFathersName.Size = New System.Drawing.Size(176, 26)
        Me.txtFathersName.TabIndex = 37
        '
        'txtSpouse
        '
        Me.txtSpouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpouse.DefaultText = ""
        Me.txtSpouse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSpouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSpouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSpouse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSpouse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSpouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSpouse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSpouse.Location = New System.Drawing.Point(249, 355)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.PlaceholderText = ""
        Me.txtSpouse.SelectedText = ""
        Me.txtSpouse.Size = New System.Drawing.Size(176, 26)
        Me.txtSpouse.TabIndex = 38
        '
        'txtHeight
        '
        Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeight.DefaultText = ""
        Me.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Location = New System.Drawing.Point(487, 174)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PlaceholderText = ""
        Me.txtHeight.SelectedText = ""
        Me.txtHeight.Size = New System.Drawing.Size(125, 26)
        Me.txtHeight.TabIndex = 39
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(249, 425)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(176, 26)
        Me.txtEmail.TabIndex = 40
        '
        'txtMothersName
        '
        Me.txtMothersName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMothersName.DefaultText = ""
        Me.txtMothersName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMothersName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMothersName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMothersName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMothersName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMothersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMothersName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMothersName.Location = New System.Drawing.Point(249, 292)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.PlaceholderText = ""
        Me.txtMothersName.SelectedText = ""
        Me.txtMothersName.Size = New System.Drawing.Size(176, 26)
        Me.txtMothersName.TabIndex = 41
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.DefaultText = ""
        Me.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(23, 486)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PlaceholderText = ""
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.Size = New System.Drawing.Size(157, 26)
        Me.txtPhoneNumber.TabIndex = 42
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 20)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(149, 41)
        Me.Guna2HtmlLabel3.TabIndex = 43
        Me.Guna2HtmlLabel3.Text = "Profiling:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Lime
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(75, 455)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(163, 47)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ButtonCANCEL
        '
        Me.ButtonCANCEL.BackColor = System.Drawing.Color.Red
        Me.ButtonCANCEL.FlatAppearance.BorderSize = 0
        Me.ButtonCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCANCEL.ForeColor = System.Drawing.Color.Black
        Me.ButtonCANCEL.Location = New System.Drawing.Point(85, 535)
        Me.ButtonCANCEL.Name = "ButtonCANCEL"
        Me.ButtonCANCEL.Size = New System.Drawing.Size(141, 40)
        Me.ButtonCANCEL.TabIndex = 4
        Me.ButtonCANCEL.Text = "CANCEL"
        Me.ButtonCANCEL.UseVisualStyleBackColor = False
        '
        'residentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "residentform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resident Information Form"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlIdPicture.ResumeLayout(False)
        Me.pnlIdPicture.PerformLayout()
        CType(Me.picIdPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFields.ResumeLayout(False)
        Me.pnlFields.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlForm As Panel
    Friend WithEvents pnlIdPicture As Panel
    Friend WithEvents picIdPicture As PictureBox
    Friend WithEvents btnChoosePicture As Button
    Friend WithEvents lblIdPicture As Label
    Friend WithEvents pnlFields As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ofdIdPicture As OpenFileDialog
    Friend WithEvents lblMothersName As Label
    Friend WithEvents lblFathersName As Label
    Friend WithEvents lblSpouse As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblCitizenship As Label
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents lblCivilStatus As Label
    Friend WithEvents cmbVotersStatus As ComboBox
    Friend WithEvents lblVotersStatus As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMothersName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtHeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSpouse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFathersName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCitizenship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonCANCEL As Button
    Friend WithEvents btnSubmit As Button
End Class
