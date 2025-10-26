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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picIdPicture = New System.Windows.Forms.PictureBox()
        Me.btnChoosePicture = New System.Windows.Forms.Button()
        Me.lblIdPicture = New System.Windows.Forms.Label()
        Me.pnlFields = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel3 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtMothersName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtSpouse = New System.Windows.Forms.TextBox()
        Me.txtFathersName = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblReligion = New System.Windows.Forms.Label()
        Me.lblMothersName = New System.Windows.Forms.Label()
        Me.lblFathersName = New System.Windows.Forms.Label()
        Me.lblSpouse = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
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
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.ofdIdPicture = New System.Windows.Forms.OpenFileDialog()
        Me.pnlMain.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlIdPicture.SuspendLayout()
        CType(Me.picIdPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFields.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlForm)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(1006, 669)
        Me.pnlMain.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.pnlIdPicture)
        Me.pnlForm.Controls.Add(Me.pnlFields)
        Me.pnlForm.Location = New System.Drawing.Point(20, 20)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(960, 620)
        Me.pnlForm.TabIndex = 0
        '
        'pnlIdPicture
        '
        Me.pnlIdPicture.BackColor = System.Drawing.Color.White
        Me.pnlIdPicture.Controls.Add(Me.btnCancel)
        Me.pnlIdPicture.Controls.Add(Me.btnSave)
        Me.pnlIdPicture.Controls.Add(Me.picIdPicture)
        Me.pnlIdPicture.Controls.Add(Me.btnChoosePicture)
        Me.pnlIdPicture.Controls.Add(Me.lblIdPicture)
        Me.pnlIdPicture.Location = New System.Drawing.Point(654, 0)
        Me.pnlIdPicture.Name = "pnlIdPicture"
        Me.pnlIdPicture.Size = New System.Drawing.Size(306, 620)
        Me.pnlIdPicture.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(6, 553)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 56)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(152, 553)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 56)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'picIdPicture
        '
        Me.picIdPicture.BackColor = System.Drawing.Color.White
        Me.picIdPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picIdPicture.Location = New System.Drawing.Point(52, 51)
        Me.picIdPicture.Name = "picIdPicture"
        Me.picIdPicture.Size = New System.Drawing.Size(200, 189)
        Me.picIdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIdPicture.TabIndex = 2
        Me.picIdPicture.TabStop = False
        '
        'btnChoosePicture
        '
        Me.btnChoosePicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnChoosePicture.FlatAppearance.BorderSize = 0
        Me.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
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
        Me.pnlFields.Controls.Add(Me.lblId)
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
        Me.pnlFields.Controls.Add(Me.txtAddress)
        Me.pnlFields.Controls.Add(Me.txtReligion)
        Me.pnlFields.Controls.Add(Me.lblAddress)
        Me.pnlFields.Controls.Add(Me.lblReligion)
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
        Me.pnlFields.Location = New System.Drawing.Point(0, 0)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFields.Size = New System.Drawing.Size(960, 620)
        Me.pnlFields.TabIndex = 0
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = True
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 20)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(136, 37)
        Me.Guna2HtmlLabel3.TabIndex = 43
        Me.Guna2HtmlLabel3.Text = "Profiling:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblId.Location = New System.Drawing.Point(19, 40)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 19)
        Me.lblId.TabIndex = 45
        Me.lblId.Text = "ID"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(40, 466)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(273, 23)
        Me.txtPhoneNumber.TabIndex = 42
        '
        'txtMothersName
        '
        Me.txtMothersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMothersName.Location = New System.Drawing.Point(344, 165)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.Size = New System.Drawing.Size(265, 23)
        Me.txtMothersName.TabIndex = 41
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(40, 526)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(273, 23)
        Me.txtEmail.TabIndex = 40
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHeight.Location = New System.Drawing.Point(344, 345)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(134, 23)
        Me.txtHeight.TabIndex = 39
        '
        'txtSpouse
        '
        Me.txtSpouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSpouse.Location = New System.Drawing.Point(344, 225)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.Size = New System.Drawing.Size(265, 23)
        Me.txtSpouse.TabIndex = 38
        '
        'txtFathersName
        '
        Me.txtFathersName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFathersName.Location = New System.Drawing.Point(344, 105)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.Size = New System.Drawing.Size(265, 23)
        Me.txtFathersName.TabIndex = 37
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtWeight.Location = New System.Drawing.Point(484, 345)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(125, 23)
        Me.txtWeight.TabIndex = 36
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCitizenship.Location = New System.Drawing.Point(40, 408)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(273, 23)
        Me.txtCitizenship.TabIndex = 35
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(40, 225)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(273, 23)
        Me.txtMiddleName.TabIndex = 34
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(40, 165)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(273, 23)
        Me.txtFirstName.TabIndex = 33
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.Location = New System.Drawing.Point(40, 105)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(273, 23)
        Me.txtLastName.TabIndex = 32
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(344, 408)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(265, 23)
        Me.txtAddress.TabIndex = 46
        '
        'txtReligion
        '
        Me.txtReligion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReligion.Location = New System.Drawing.Point(475, 285)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(134, 23)
        Me.txtReligion.TabIndex = 47
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAddress.Location = New System.Drawing.Point(344, 386)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 19)
        Me.lblAddress.TabIndex = 48
        Me.lblAddress.Text = "Address"
        '
        'lblReligion
        '
        Me.lblReligion.AutoSize = True
        Me.lblReligion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblReligion.Location = New System.Drawing.Point(480, 260)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(57, 19)
        Me.lblReligion.TabIndex = 49
        Me.lblReligion.Text = "Religion"
        '
        'lblMothersName
        '
        Me.lblMothersName.AutoSize = True
        Me.lblMothersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMothersName.Location = New System.Drawing.Point(344, 140)
        Me.lblMothersName.Name = "lblMothersName"
        Me.lblMothersName.Size = New System.Drawing.Size(104, 19)
        Me.lblMothersName.TabIndex = 30
        Me.lblMothersName.Text = "Mother's Name"
        '
        'lblFathersName
        '
        Me.lblFathersName.AutoSize = True
        Me.lblFathersName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFathersName.Location = New System.Drawing.Point(344, 80)
        Me.lblFathersName.Name = "lblFathersName"
        Me.lblFathersName.Size = New System.Drawing.Size(97, 19)
        Me.lblFathersName.TabIndex = 28
        Me.lblFathersName.Text = "Father's Name"
        '
        'lblSpouse
        '
        Me.lblSpouse.AutoSize = True
        Me.lblSpouse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSpouse.Location = New System.Drawing.Point(344, 200)
        Me.lblSpouse.Name = "lblSpouse"
        Me.lblSpouse.Size = New System.Drawing.Size(53, 19)
        Me.lblSpouse.TabIndex = 26
        Me.lblSpouse.Text = "Spouse"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(41, 504)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 19)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "Email"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWeight.Location = New System.Drawing.Point(487, 320)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 19)
        Me.lblWeight.TabIndex = 22
        Me.lblWeight.Text = "Weight"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblHeight.Location = New System.Drawing.Point(344, 320)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(50, 19)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Height"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(40, 444)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(102, 19)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblCitizenship
        '
        Me.lblCitizenship.AutoSize = True
        Me.lblCitizenship.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCitizenship.Location = New System.Drawing.Point(40, 386)
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
        Me.cmbCivilStatus.Location = New System.Drawing.Point(163, 345)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(150, 25)
        Me.cmbCivilStatus.TabIndex = 15
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        Me.lblCivilStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCivilStatus.Location = New System.Drawing.Point(162, 320)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(76, 19)
        Me.lblCivilStatus.TabIndex = 14
        Me.lblCivilStatus.Text = "Civil Status"
        '
        'cmbVotersStatus
        '
        Me.cmbVotersStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVotersStatus.FormattingEnabled = True
        Me.cmbVotersStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbVotersStatus.Location = New System.Drawing.Point(344, 285)
        Me.cmbVotersStatus.Name = "cmbVotersStatus"
        Me.cmbVotersStatus.Size = New System.Drawing.Size(125, 25)
        Me.cmbVotersStatus.TabIndex = 13
        '
        'lblVotersStatus
        '
        Me.lblVotersStatus.AutoSize = True
        Me.lblVotersStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblVotersStatus.Location = New System.Drawing.Point(344, 260)
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
        Me.cmbGender.Location = New System.Drawing.Point(40, 285)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(136, 25)
        Me.cmbGender.TabIndex = 11
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGender.Location = New System.Drawing.Point(40, 260)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(54, 19)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAge.Location = New System.Drawing.Point(40, 345)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(117, 25)
        Me.txtAge.TabIndex = 9
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAge.Location = New System.Drawing.Point(41, 320)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 19)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(182, 285)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(131, 25)
        Me.dtpBirthDate.TabIndex = 7
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBirthDate.Location = New System.Drawing.Point(184, 260)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(65, 19)
        Me.lblBirthDate.TabIndex = 6
        Me.lblBirthDate.Text = "Birthdate"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMiddleName.Location = New System.Drawing.Point(40, 203)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(91, 19)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(41, 143)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(75, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(40, 83)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(74, 19)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
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
        Me.ClientSize = New System.Drawing.Size(1006, 669)
        Me.Controls.Add(Me.pnlMain)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlForm As Panel
    Friend WithEvents pnlIdPicture As Panel
    Friend WithEvents picIdPicture As PictureBox
    Friend WithEvents btnChoosePicture As Button
    Friend WithEvents lblIdPicture As Label
    Friend WithEvents pnlFields As Panel
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
    Friend WithEvents Guna2HtmlLabel3 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMothersName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtSpouse As System.Windows.Forms.TextBox
    Friend WithEvents txtFathersName As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtCitizenship As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblReligion As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
