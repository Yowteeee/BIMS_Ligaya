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
        Me.txtMothersName = New System.Windows.Forms.TextBox()
        Me.lblMothersName = New System.Windows.Forms.Label()
        Me.txtFathersName = New System.Windows.Forms.TextBox()
        Me.lblFathersName = New System.Windows.Forms.Label()
        Me.txtSpouse = New System.Windows.Forms.TextBox()
        Me.lblSpouse = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.lblCitizenship = New System.Windows.Forms.Label()
        Me.cmbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.cmbVotersStatus = New System.Windows.Forms.ComboBox()
        Me.lblVotersStatus = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ofdIdPicture = New System.Windows.Forms.OpenFileDialog()
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
        Me.picIdPicture.Location = New System.Drawing.Point(50, 50)
        Me.picIdPicture.Name = "picIdPicture"
        Me.picIdPicture.Size = New System.Drawing.Size(200, 200)
        Me.picIdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIdPicture.TabIndex = 2
        Me.picIdPicture.TabStop = False
        '
        'btnChoosePicture
        '
        Me.btnChoosePicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChoosePicture.FlatAppearance.BorderSize = 0
        Me.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoosePicture.ForeColor = System.Drawing.Color.White
        Me.btnChoosePicture.Location = New System.Drawing.Point(50, 270)
        Me.btnChoosePicture.Name = "btnChoosePicture"
        Me.btnChoosePicture.Size = New System.Drawing.Size(200, 35)
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
        Me.pnlFields.Controls.Add(Me.txtMothersName)
        Me.pnlFields.Controls.Add(Me.lblMothersName)
        Me.pnlFields.Controls.Add(Me.txtFathersName)
        Me.pnlFields.Controls.Add(Me.lblFathersName)
        Me.pnlFields.Controls.Add(Me.txtSpouse)
        Me.pnlFields.Controls.Add(Me.lblSpouse)
        Me.pnlFields.Controls.Add(Me.txtEmail)
        Me.pnlFields.Controls.Add(Me.lblEmail)
        Me.pnlFields.Controls.Add(Me.txtWeight)
        Me.pnlFields.Controls.Add(Me.lblWeight)
        Me.pnlFields.Controls.Add(Me.txtHeight)
        Me.pnlFields.Controls.Add(Me.lblHeight)
        Me.pnlFields.Controls.Add(Me.txtPhoneNumber)
        Me.pnlFields.Controls.Add(Me.lblPhoneNumber)
        Me.pnlFields.Controls.Add(Me.txtCitizenship)
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
        Me.pnlFields.Controls.Add(Me.txtMiddleName)
        Me.pnlFields.Controls.Add(Me.lblMiddleName)
        Me.pnlFields.Controls.Add(Me.txtFirstName)
        Me.pnlFields.Controls.Add(Me.lblFirstName)
        Me.pnlFields.Controls.Add(Me.txtLastName)
        Me.pnlFields.Controls.Add(Me.lblLastName)
        Me.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFields.Location = New System.Drawing.Point(0, 0)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFields.Size = New System.Drawing.Size(660, 620)
        Me.pnlFields.TabIndex = 0
        '
        'txtMothersName
        '
        Me.txtMothersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMothersName.Location = New System.Drawing.Point(450, 550)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.Size = New System.Drawing.Size(180, 25)
        Me.txtMothersName.TabIndex = 31
        '
        'lblMothersName
        '
        Me.lblMothersName.AutoSize = True
        Me.lblMothersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMothersName.Location = New System.Drawing.Point(450, 530)
        Me.lblMothersName.Name = "lblMothersName"
        Me.lblMothersName.Size = New System.Drawing.Size(100, 19)
        Me.lblMothersName.TabIndex = 30
        Me.lblMothersName.Text = "Mother's Name"
        '
        'txtFathersName
        '
        Me.txtFathersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFathersName.Location = New System.Drawing.Point(230, 550)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.Size = New System.Drawing.Size(180, 25)
        Me.txtFathersName.TabIndex = 29
        '
        'lblFathersName
        '
        Me.lblFathersName.AutoSize = True
        Me.lblFathersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFathersName.Location = New System.Drawing.Point(230, 530)
        Me.lblFathersName.Name = "lblFathersName"
        Me.lblFathersName.Size = New System.Drawing.Size(95, 19)
        Me.lblFathersName.TabIndex = 28
        Me.lblFathersName.Text = "Father's Name"
        '
        'txtSpouse
        '
        Me.txtSpouse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSpouse.Location = New System.Drawing.Point(20, 550)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.Size = New System.Drawing.Size(180, 25)
        Me.txtSpouse.TabIndex = 27
        '
        'lblSpouse
        '
        Me.lblSpouse.AutoSize = True
        Me.lblSpouse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSpouse.Location = New System.Drawing.Point(20, 530)
        Me.lblSpouse.Name = "lblSpouse"
        Me.lblSpouse.Size = New System.Drawing.Size(52, 19)
        Me.lblSpouse.TabIndex = 26
        Me.lblSpouse.Text = "Spouse"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(450, 480)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 25)
        Me.txtEmail.TabIndex = 25
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(450, 460)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 19)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "Email"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtWeight.Location = New System.Drawing.Point(230, 480)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(180, 25)
        Me.txtWeight.TabIndex = 23
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWeight.Location = New System.Drawing.Point(230, 460)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 19)
        Me.lblWeight.TabIndex = 22
        Me.lblWeight.Text = "Weight"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHeight.Location = New System.Drawing.Point(20, 480)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(180, 25)
        Me.txtHeight.TabIndex = 21
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblHeight.Location = New System.Drawing.Point(20, 460)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 19)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Height"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(450, 410)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 25)
        Me.txtPhoneNumber.TabIndex = 19
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(450, 390)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(100, 19)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCitizenship.Location = New System.Drawing.Point(230, 410)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(180, 25)
        Me.txtCitizenship.TabIndex = 17
        '
        'lblCitizenship
        '
        Me.lblCitizenship.AutoSize = True
        Me.lblCitizenship.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCitizenship.Location = New System.Drawing.Point(230, 390)
        Me.lblCitizenship.Name = "lblCitizenship"
        Me.lblCitizenship.Size = New System.Drawing.Size(75, 19)
        Me.lblCitizenship.TabIndex = 16
        Me.lblCitizenship.Text = "Citizenship"
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCivilStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cmbCivilStatus.Location = New System.Drawing.Point(20, 410)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(180, 25)
        Me.cmbCivilStatus.TabIndex = 15
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        Me.lblCivilStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCivilStatus.Location = New System.Drawing.Point(20, 390)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(75, 19)
        Me.lblCivilStatus.TabIndex = 14
        Me.lblCivilStatus.Text = "Civil Status"
        '
        'cmbVotersStatus
        '
        Me.cmbVotersStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVotersStatus.FormattingEnabled = True
        Me.cmbVotersStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbVotersStatus.Location = New System.Drawing.Point(450, 340)
        Me.cmbVotersStatus.Name = "cmbVotersStatus"
        Me.cmbVotersStatus.Size = New System.Drawing.Size(180, 25)
        Me.cmbVotersStatus.TabIndex = 13
        '
        'lblVotersStatus
        '
        Me.lblVotersStatus.AutoSize = True
        Me.lblVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblVotersStatus.Location = New System.Drawing.Point(450, 320)
        Me.lblVotersStatus.Name = "lblVotersStatus"
        Me.lblVotersStatus.Size = New System.Drawing.Size(90, 19)
        Me.lblVotersStatus.TabIndex = 12
        Me.lblVotersStatus.Text = "Voters Status"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(230, 340)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(180, 25)
        Me.cmbGender.TabIndex = 11
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGender.Location = New System.Drawing.Point(230, 320)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 19)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAge.Location = New System.Drawing.Point(20, 340)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(180, 25)
        Me.txtAge.TabIndex = 9
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAge.Location = New System.Drawing.Point(20, 320)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 19)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpBirthDate.Location = New System.Drawing.Point(450, 270)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(180, 25)
        Me.dtpBirthDate.TabIndex = 7
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBirthDate.Location = New System.Drawing.Point(450, 250)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(70, 19)
        Me.lblBirthDate.TabIndex = 6
        Me.lblBirthDate.Text = "Birth Date"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(230, 270)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(180, 25)
        Me.txtMiddleName.TabIndex = 5
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMiddleName.Location = New System.Drawing.Point(230, 250)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(90, 19)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(20, 270)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 25)
        Me.txtFirstName.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(20, 250)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(20, 200)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 25)
        Me.txtLastName.TabIndex = 1
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(20, 180)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 19)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
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
    Friend WithEvents txtMothersName As TextBox
    Friend WithEvents lblMothersName As Label
    Friend WithEvents txtFathersName As TextBox
    Friend WithEvents lblFathersName As Label
    Friend WithEvents txtSpouse As TextBox
    Friend WithEvents lblSpouse As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtCitizenship As TextBox
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
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ofdIdPicture As OpenFileDialog
End Class
