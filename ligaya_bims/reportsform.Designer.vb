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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblTypeOfIncident = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTypeOfIncident = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblInclusive = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblExactLocation = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtExactLocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblInvolved = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtInvolved = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblNarrative = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNarrative = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPageSetup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPreview = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
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
        Me.panelMain.BackColor = System.Drawing.Color.White
        ' Template controls removed
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
        Me.panelMain.Controls.Add(Me.txtBody)
        Me.panelMain.Controls.Add(Me.lblBody)
        Me.panelMain.Controls.Add(Me.txtSubject)
        Me.panelMain.Controls.Add(Me.lblSubject)
        Me.panelMain.Controls.Add(Me.txtTitle)
        Me.panelMain.Controls.Add(Me.lblTitle)
        '
        'lblTypeOfIncident
        '
        Me.lblTypeOfIncident.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeOfIncident.Location = New System.Drawing.Point(15, 12)
        Me.lblTypeOfIncident.Name = "lblTypeOfIncident"
        Me.lblTypeOfIncident.TabIndex = 0
        Me.lblTypeOfIncident.Text = "Type of Incident"
        '
        'txtTypeOfIncident
        '
        Me.txtTypeOfIncident.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTypeOfIncident.BorderRadius = 6
        Me.txtTypeOfIncident.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTypeOfIncident.DefaultText = ""
        Me.txtTypeOfIncident.Location = New System.Drawing.Point(18, 30)
        Me.txtTypeOfIncident.Name = "txtTypeOfIncident"
        Me.txtTypeOfIncident.Size = New System.Drawing.Size(648, 36)
        Me.txtTypeOfIncident.TabIndex = 1
        '
        'lblInclusive
        '
        Me.lblInclusive.BackColor = System.Drawing.Color.Transparent
        Me.lblInclusive.Location = New System.Drawing.Point(15, 72)
        Me.lblInclusive.Name = "lblInclusive"
        Me.lblInclusive.TabIndex = 0
        Me.lblInclusive.Text = "Inclusive Date and Time (From-To)"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 6
        Me.dtpFrom.Checked = True
        Me.dtpFrom.CustomFormat = "MMMM dd, yyyy  hh:mm tt"
        Me.dtpFrom.FillColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(18, 90)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(240, 36)
        Me.dtpFrom.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 6
        Me.dtpTo.Checked = True
        Me.dtpTo.CustomFormat = "MMMM dd, yyyy  hh:mm tt"
        Me.dtpTo.FillColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(264, 90)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(240, 36)
        Me.dtpTo.TabIndex = 3

        'lblExactLocation
        '
        Me.lblExactLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblExactLocation.Location = New System.Drawing.Point(15, 132)
        Me.lblExactLocation.Name = "lblExactLocation"
        Me.lblExactLocation.TabIndex = 0
        Me.lblExactLocation.Text = "Exact Location of Incident"

        'txtExactLocation
        '
        Me.txtExactLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExactLocation.BorderRadius = 6
        Me.txtExactLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtExactLocation.DefaultText = ""
        Me.txtExactLocation.Location = New System.Drawing.Point(18, 150)
        Me.txtExactLocation.Name = "txtExactLocation"
        Me.txtExactLocation.Size = New System.Drawing.Size(648, 36)
        Me.txtExactLocation.TabIndex = 3
        '
        'lblInvolved
        '
        Me.lblInvolved.BackColor = System.Drawing.Color.Transparent
        Me.lblInvolved.Location = New System.Drawing.Point(15, 192)
        Me.lblInvolved.Name = "lblInvolved"
        Me.lblInvolved.TabIndex = 0
        Me.lblInvolved.Text = "Involved Person / Details"
        '
        'txtInvolved
        '
        Me.txtInvolved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvolved.BorderRadius = 6
        Me.txtInvolved.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvolved.DefaultText = ""
        Me.txtInvolved.Location = New System.Drawing.Point(18, 210)
        Me.txtInvolved.Name = "txtInvolved"
        Me.txtInvolved.Size = New System.Drawing.Size(648, 36)
        Me.txtInvolved.TabIndex = 4
        '
        'lblNarrative
        '
        Me.lblNarrative.BackColor = System.Drawing.Color.Transparent
        Me.lblNarrative.Location = New System.Drawing.Point(15, 252)
        Me.lblNarrative.Name = "lblNarrative"
        Me.lblNarrative.TabIndex = 0
        Me.lblNarrative.Text = "Narrative of Incident"
        '
        'txtNarrative
        '
        Me.txtNarrative.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNarrative.BorderRadius = 6
        Me.txtNarrative.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNarrative.DefaultText = ""
        Me.txtNarrative.Location = New System.Drawing.Point(18, 270)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarrative.Size = New System.Drawing.Size(648, 270)
        Me.txtNarrative.TabIndex = 5
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(12)
        Me.panelMain.Size = New System.Drawing.Size(900, 600)
        Me.panelMain.TabIndex = 0
        '
        'btnPageSetup
        '
        Me.btnPageSetup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPageSetup.BorderRadius = 6
        Me.btnPageSetup.FillColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.btnPageSetup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPageSetup.ForeColor = System.Drawing.Color.White
        Me.btnPageSetup.Location = New System.Drawing.Point(15, 555)
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Size = New System.Drawing.Size(100, 30)
        Me.btnPageSetup.TabIndex = 6
        Me.btnPageSetup.Text = "Page Setup"
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.BorderRadius = 6
        Me.btnPreview.FillColor = System.Drawing.Color.FromArgb(47, 85, 151)
        Me.btnPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Location = New System.Drawing.Point(121, 555)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 30)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "Preview"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BorderRadius = 6
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(0, 158, 73)
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(227, 555)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 30)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        '


        '
        'txtBody (hidden legacy)
        '
        Me.txtBody.Location = New System.Drawing.Point(18, 36)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(10, 10)
        Me.txtBody.TabIndex = 100
        Me.txtBody.Visible = False
        '
        'lblBody (hidden legacy)
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(15, 18)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(69, 15)
        Me.lblBody.TabIndex = 0
        Me.lblBody.Text = "Body/Notes"
        Me.lblBody.Visible = False
        '
        'txtSubject (hidden legacy)
        '
        Me.txtSubject.Location = New System.Drawing.Point(18, 36)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(10, 23)
        Me.txtSubject.TabIndex = 101
        Me.txtSubject.Visible = False
        '
        'lblSubject (hidden legacy)
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(15, 18)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(48, 15)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject"
        Me.lblSubject.Visible = False
        '
        'txtTitle (hidden legacy)
        '
        Me.txtTitle.Location = New System.Drawing.Point(18, 36)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(10, 23)
        Me.txtTitle.TabIndex = 102
        Me.txtTitle.Visible = False
        '
        'lblTitle (hidden legacy)
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(15, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(31, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        Me.lblTitle.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "reportsform"
        Me.Text = "Reports"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents lblTypeOfIncident As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTypeOfIncident As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblInclusive As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblExactLocation As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtExactLocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblInvolved As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtInvolved As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblNarrative As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNarrative As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPageSetup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPreview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    


End Class
