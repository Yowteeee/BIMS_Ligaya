Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsform))
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblTypeOfIncident = New System.Windows.Forms.Label()
        Me.txtTypeOfIncident = New System.Windows.Forms.TextBox()
        Me.lblInclusive = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblExactLocation = New System.Windows.Forms.Label()
        Me.txtExactLocation = New System.Windows.Forms.TextBox()
        Me.lblInvolved = New System.Windows.Forms.Label()
        Me.txtInvolved = New System.Windows.Forms.TextBox()
        Me.lblNarrative = New System.Windows.Forms.Label()
        Me.txtNarrative = New System.Windows.Forms.TextBox()
        Me.btnPageSetup = New ligaya_bims.RoundedButton()
        Me.btnPreview = New ligaya_bims.RoundedButton()
        Me.btnPrint = New ligaya_bims.RoundedButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelMain.Controls.Add(Me.lblTypeOfIncident)
        Me.panelMain.Controls.Add(Me.txtTypeOfIncident)
        Me.panelMain.Controls.Add(Me.lblInclusive)
        Me.panelMain.Controls.Add(Me.dtpFrom)
        Me.panelMain.Controls.Add(Me.dtpTo)
        Me.panelMain.Controls.Add(Me.lblExactLocation)
        Me.panelMain.Controls.Add(Me.txtExactLocation)
        Me.panelMain.Controls.Add(Me.lblInvolved)
        Me.panelMain.Controls.Add(Me.txtInvolved)
        Me.panelMain.Controls.Add(Me.lblNarrative)
        Me.panelMain.Controls.Add(Me.txtNarrative)
        Me.panelMain.Controls.Add(Me.btnPageSetup)
        Me.panelMain.Controls.Add(Me.btnPreview)
        Me.panelMain.Controls.Add(Me.btnPrint)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.panelMain.Size = New System.Drawing.Size(771, 520)
        Me.panelMain.TabIndex = 0
        '
        'lblTypeOfIncident
        '
        Me.lblTypeOfIncident.AutoSize = True
        Me.lblTypeOfIncident.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTypeOfIncident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblTypeOfIncident.Location = New System.Drawing.Point(13, 14)
        Me.lblTypeOfIncident.Name = "lblTypeOfIncident"
        Me.lblTypeOfIncident.Size = New System.Drawing.Size(97, 15)
        Me.lblTypeOfIncident.TabIndex = 0
        Me.lblTypeOfIncident.Text = "Type of Incident"
        '
        'txtTypeOfIncident
        '
        Me.txtTypeOfIncident.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTypeOfIncident.Location = New System.Drawing.Point(15, 32)
        Me.txtTypeOfIncident.Name = "txtTypeOfIncident"
        Me.txtTypeOfIncident.Size = New System.Drawing.Size(556, 20)
        Me.txtTypeOfIncident.TabIndex = 1
        '
        'lblInclusive
        '
        Me.lblInclusive.AutoSize = True
        Me.lblInclusive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInclusive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblInclusive.Location = New System.Drawing.Point(13, 62)
        Me.lblInclusive.Name = "lblInclusive"
        Me.lblInclusive.Size = New System.Drawing.Size(198, 15)
        Me.lblInclusive.TabIndex = 0
        Me.lblInclusive.Text = "Inclusive Date and Time (From-To)"
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "MMMM dd, yyyy  hh:mm tt"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(15, 78)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(206, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "MMMM dd, yyyy  hh:mm tt"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(226, 78)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(206, 20)
        Me.dtpTo.TabIndex = 3
        '
        'lblExactLocation
        '
        Me.lblExactLocation.AutoSize = True
        Me.lblExactLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblExactLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblExactLocation.Location = New System.Drawing.Point(13, 114)
        Me.lblExactLocation.Name = "lblExactLocation"
        Me.lblExactLocation.Size = New System.Drawing.Size(151, 15)
        Me.lblExactLocation.TabIndex = 0
        Me.lblExactLocation.Text = "Exact Location of Incident"
        '
        'txtExactLocation
        '
        Me.txtExactLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExactLocation.Location = New System.Drawing.Point(15, 130)
        Me.txtExactLocation.Name = "txtExactLocation"
        Me.txtExactLocation.Size = New System.Drawing.Size(556, 20)
        Me.txtExactLocation.TabIndex = 3
        '
        'lblInvolved
        '
        Me.lblInvolved.AutoSize = True
        Me.lblInvolved.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvolved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblInvolved.Location = New System.Drawing.Point(13, 166)
        Me.lblInvolved.Name = "lblInvolved"
        Me.lblInvolved.Size = New System.Drawing.Size(146, 15)
        Me.lblInvolved.TabIndex = 0
        Me.lblInvolved.Text = "Involved Person / Details"
        '
        'txtInvolved
        '
        Me.txtInvolved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvolved.Location = New System.Drawing.Point(15, 182)
        Me.txtInvolved.Name = "txtInvolved"
        Me.txtInvolved.Size = New System.Drawing.Size(556, 20)
        Me.txtInvolved.TabIndex = 4
        '
        'lblNarrative
        '
        Me.lblNarrative.AutoSize = True
        Me.lblNarrative.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNarrative.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblNarrative.Location = New System.Drawing.Point(13, 218)
        Me.lblNarrative.Name = "lblNarrative"
        Me.lblNarrative.Size = New System.Drawing.Size(124, 15)
        Me.lblNarrative.TabIndex = 0
        Me.lblNarrative.Text = "Narrative of Incident"
        '
        'txtNarrative
        '
        Me.txtNarrative.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNarrative.Location = New System.Drawing.Point(15, 234)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarrative.Size = New System.Drawing.Size(556, 235)
        Me.txtNarrative.TabIndex = 5
        '
        'btnPageSetup
        '
        Me.btnPageSetup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPageSetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPageSetup.FlatAppearance.BorderSize = 0
        Me.btnPageSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnPageSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPageSetup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPageSetup.ForeColor = System.Drawing.Color.White
        Me.btnPageSetup.Location = New System.Drawing.Point(13, 481)
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Size = New System.Drawing.Size(86, 26)
        Me.btnPageSetup.TabIndex = 6
        Me.btnPageSetup.Text = "Page Setup"
        Me.btnPageSetup.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPreview.FlatAppearance.BorderSize = 0
        Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Location = New System.Drawing.Point(104, 481)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(86, 26)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(195, 481)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(86, 26)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Word Documents|*.docx|All Files|*.*"
        '
        'reportsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 520)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "reportsform"
        Me.Text = "Reports"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As System.Windows.Forms.Panel
	Friend WithEvents lblTypeOfIncident As System.Windows.Forms.Label
	Friend WithEvents txtTypeOfIncident As System.Windows.Forms.TextBox
	Friend WithEvents lblInclusive As System.Windows.Forms.Label
	Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblExactLocation As System.Windows.Forms.Label
	Friend WithEvents txtExactLocation As System.Windows.Forms.TextBox
	Friend WithEvents lblInvolved As System.Windows.Forms.Label
	Friend WithEvents txtInvolved As System.Windows.Forms.TextBox
	Friend WithEvents lblNarrative As System.Windows.Forms.Label
	Friend WithEvents txtNarrative As System.Windows.Forms.TextBox
	Friend WithEvents btnPageSetup As ligaya_bims.RoundedButton
	Friend WithEvents btnPreview As ligaya_bims.RoundedButton
	Friend WithEvents btnPrint As ligaya_bims.RoundedButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    


End Class
