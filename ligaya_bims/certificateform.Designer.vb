<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class certificateform
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.panelFormFields = New System.Windows.Forms.Panel()
        Me.dtpIssuedDate = New System.Windows.Forms.DateTimePicker()
        Me.txtYearsStayed = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.rbMarried = New System.Windows.Forms.RadioButton()
        Me.rbSingle = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbCertificateType = New System.Windows.Forms.ComboBox()
        Me.panelLeftHeader = New System.Windows.Forms.Panel()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPageSetup = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.panelPreview = New System.Windows.Forms.Panel()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.panelRightHeader = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        
        Me.panelMain.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        Me.panelFormFields.SuspendLayout()
        Me.panelRight.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.panelPreview.SuspendLayout()
        Me.SuspendLayout()
        
        'panelMain
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1000, 600)
        Me.panelMain.TabIndex = 0
        
        'panelLeft
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(500, 600)
        Me.panelLeft.TabIndex = 0
        Me.panelLeft.BackColor = System.Drawing.Color.White
        
        'panelLeftHeader
        Me.panelLeftHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLeftHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelLeftHeader.Name = "panelLeftHeader"
        Me.panelLeftHeader.Size = New System.Drawing.Size(500, 50)
        Me.panelLeftHeader.TabIndex = 0
        Me.panelLeftHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        
        'panelFormFields
        Me.panelFormFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFormFields.Location = New System.Drawing.Point(0, 50)
        Me.panelFormFields.Name = "panelFormFields"
        Me.panelFormFields.Size = New System.Drawing.Size(500, 550)
        Me.panelFormFields.TabIndex = 1
        Me.panelFormFields.Padding = New System.Windows.Forms.Padding(20)
        
        'cmbCertificateType
        Me.cmbCertificateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCertificateType.FormattingEnabled = True
        Me.cmbCertificateType.Items.AddRange(New Object() {"Residency", "Indigency", "Barangay Clearance"})
        Me.cmbCertificateType.Location = New System.Drawing.Point(30, 50)
        Me.cmbCertificateType.Name = "cmbCertificateType"
        Me.cmbCertificateType.Size = New System.Drawing.Size(400, 24)
        Me.cmbCertificateType.TabIndex = 0
        
        'txtName
        Me.txtName.Location = New System.Drawing.Point(30, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Full Name"
        
        'txtAge
        Me.txtAge.Location = New System.Drawing.Point(30, 150)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 22)
        Me.txtAge.TabIndex = 2
        Me.txtAge.Text = "Age"
        
        'rbSingle
        Me.rbSingle.AutoSize = True
        Me.rbSingle.Checked = True
        Me.rbSingle.Location = New System.Drawing.Point(150, 150)
        Me.rbSingle.Name = "rbSingle"
        Me.rbSingle.Size = New System.Drawing.Size(68, 21)
        Me.rbSingle.TabIndex = 3
        Me.rbSingle.TabStop = True
        Me.rbSingle.Text = "Single"
        Me.rbSingle.UseVisualStyleBackColor = True
        
        'rbMarried
        Me.rbMarried.AutoSize = True
        Me.rbMarried.Location = New System.Drawing.Point(250, 150)
        Me.rbMarried.Name = "rbMarried"
        Me.rbMarried.Size = New System.Drawing.Size(77, 21)
        Me.rbMarried.TabIndex = 4
        Me.rbMarried.Text = "Married"
        Me.rbMarried.UseVisualStyleBackColor = True
        
        'txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(30, 200)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(400, 22)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = "Address"
        
        'txtYearsStayed
        Me.txtYearsStayed.Location = New System.Drawing.Point(30, 250)
        Me.txtYearsStayed.Name = "txtYearsStayed"
        Me.txtYearsStayed.Size = New System.Drawing.Size(100, 22)
        Me.txtYearsStayed.TabIndex = 6
        Me.txtYearsStayed.Text = "Years Stayed"
        
        'dtpIssuedDate
        Me.dtpIssuedDate.Location = New System.Drawing.Point(30, 300)
        Me.dtpIssuedDate.Name = "dtpIssuedDate"
        Me.dtpIssuedDate.Size = New System.Drawing.Size(250, 22)
        Me.dtpIssuedDate.TabIndex = 7
        
        'panelRight
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelRight.Location = New System.Drawing.Point(500, 0)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(500, 600)
        Me.panelRight.TabIndex = 1
        Me.panelRight.BackColor = System.Drawing.Color.WhiteSmoke
        
        'panelRightHeader
        Me.panelRightHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelRightHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelRightHeader.Name = "panelRightHeader"
        Me.panelRightHeader.Size = New System.Drawing.Size(500, 50)
        Me.panelRightHeader.TabIndex = 0
        Me.panelRightHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        
        'panelPreview
        Me.panelPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPreview.Location = New System.Drawing.Point(0, 50)
        Me.panelPreview.Name = "panelPreview"
        Me.panelPreview.Size = New System.Drawing.Size(500, 500)
        Me.panelPreview.TabIndex = 1
        
        'PrintPreviewControl1
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(500, 500)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        
        'panelButtons
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 550)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(500, 50)
        Me.panelButtons.TabIndex = 2
        
        'btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(350, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 30)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        
        'btnPageSetup
        Me.btnPageSetup.Location = New System.Drawing.Point(50, 10)
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Size = New System.Drawing.Size(100, 30)
        Me.btnPageSetup.TabIndex = 1
        Me.btnPageSetup.Text = "Page Setup"
        Me.btnPageSetup.UseVisualStyleBackColor = True
        
        'btnPreview
        Me.btnPreview.Location = New System.Drawing.Point(200, 10)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 30)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        
        'PrintDocument1
        '
        AddHandler Me.PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        
        'PrintPreviewDialog1
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        
        'PrintDialog1
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        
        'PageSetupDialog1
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        
        'certificateform
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "certificateform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Certificate Form"
        
        Me.panelMain.Controls.Add(Me.panelRight)
        Me.panelMain.Controls.Add(Me.panelLeft)
        Me.panelLeft.Controls.Add(Me.panelFormFields)
        Me.panelLeft.Controls.Add(Me.panelLeftHeader)
        Me.panelRight.Controls.Add(Me.panelPreview)
        Me.panelRight.Controls.Add(Me.panelButtons)
        Me.panelRight.Controls.Add(Me.panelRightHeader)
        Me.panelPreview.Controls.Add(Me.PrintPreviewControl1)
        Me.panelButtons.Controls.Add(Me.btnPrint)
        Me.panelButtons.Controls.Add(Me.btnPreview)
        Me.panelButtons.Controls.Add(Me.btnPageSetup)
        Me.panelFormFields.Controls.Add(Me.dtpIssuedDate)
        Me.panelFormFields.Controls.Add(Me.txtYearsStayed)
        Me.panelFormFields.Controls.Add(Me.txtAddress)
        Me.panelFormFields.Controls.Add(Me.rbMarried)
        Me.panelFormFields.Controls.Add(Me.rbSingle)
        Me.panelFormFields.Controls.Add(Me.txtAge)
        Me.panelFormFields.Controls.Add(Me.txtName)
        Me.panelFormFields.Controls.Add(Me.cmbCertificateType)
        
        Me.panelMain.ResumeLayout(False)
        Me.panelLeft.ResumeLayout(False)
        Me.panelFormFields.ResumeLayout(False)
        Me.panelFormFields.PerformLayout()
        Me.panelRight.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.panelPreview.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents panelFormFields As System.Windows.Forms.Panel
    Friend WithEvents panelLeftHeader As System.Windows.Forms.Panel
    Friend WithEvents panelRight As System.Windows.Forms.Panel
    Friend WithEvents panelPreview As System.Windows.Forms.Panel
    Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents panelRightHeader As System.Windows.Forms.Panel
    Friend WithEvents cmbCertificateType As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents rbSingle As System.Windows.Forms.RadioButton
    Friend WithEvents rbMarried As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtYearsStayed As System.Windows.Forms.TextBox
    Friend WithEvents dtpIssuedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPageSetup As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
End Class
