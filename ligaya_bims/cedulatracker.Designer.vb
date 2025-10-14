<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cedulatracker
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.dgvCedula = New System.Windows.Forms.DataGridView()
        Me.colAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCTCNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateIssued = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblShowingEntries = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        CType(Me.dgvCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelMain.Controls.Add(Me.lblTitle)
        Me.panelMain.Controls.Add(Me.btnTransaction)
        Me.panelMain.Controls.Add(Me.txtSearch)
        Me.panelMain.Controls.Add(Me.cmbFilter)
        Me.panelMain.Controls.Add(Me.dgvCedula)
        Me.panelMain.Controls.Add(Me.lblShowingEntries)
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
        Me.lblTitle.Size = New System.Drawing.Size(241, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Cedula Tracker"
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnTransaction.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(23, 85)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(150, 40)
        Me.btnTransaction.TabIndex = 1
        Me.btnTransaction.Text = "Transaction"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(950, 95)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.TabIndex = 2
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbFilter.Items.AddRange(New Object() {"CTC Number", "Full Name", "Date Issued"})
        Me.cmbFilter.Location = New System.Drawing.Point(185, 85)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(200, 23)
        Me.cmbFilter.TabIndex = 3
        '
        'dgvCedula
        '
        Me.dgvCedula.AllowUserToAddRows = False
        Me.dgvCedula.AllowUserToDeleteRows = False
        Me.dgvCedula.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCedula.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCedula.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCedula.ColumnHeadersHeight = 40
        Me.dgvCedula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCedula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAction, Me.colCTCNumber, Me.colFullName, Me.colDateIssued})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCedula.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCedula.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCedula.Location = New System.Drawing.Point(23, 187)
        Me.dgvCedula.MultiSelect = False
        Me.dgvCedula.Name = "dgvCedula"
        Me.dgvCedula.ReadOnly = True
        Me.dgvCedula.RowHeadersVisible = False
        Me.dgvCedula.RowHeadersWidth = 51
        Me.dgvCedula.RowTemplate.Height = 40
        Me.dgvCedula.Size = New System.Drawing.Size(1154, 350)
        Me.dgvCedula.TabIndex = 4
        ' ThemeStyle properties removed (Guna-specific)
        '
        'colAction
        '
        Me.colAction.HeaderText = "Action"
        Me.colAction.MinimumWidth = 6
        Me.colAction.Name = "colAction"
        Me.colAction.ReadOnly = True
        '
        'colCTCNumber
        '
        Me.colCTCNumber.HeaderText = "CTC Number"
        Me.colCTCNumber.MinimumWidth = 6
        Me.colCTCNumber.Name = "colCTCNumber"
        Me.colCTCNumber.ReadOnly = True
        '
        'colFullName
        '
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.MinimumWidth = 6
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        '
        'colDateIssued
        '
        Me.colDateIssued.HeaderText = "Date Issued"
        Me.colDateIssued.MinimumWidth = 6
        Me.colDateIssued.Name = "colDateIssued"
        Me.colDateIssued.ReadOnly = True
        '
        'lblShowingEntries
        '
        Me.lblShowingEntries.AutoSize = True
        Me.lblShowingEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblShowingEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblShowingEntries.Location = New System.Drawing.Point(23, 560)
        Me.lblShowingEntries.Name = "lblShowingEntries"
        Me.lblShowingEntries.Size = New System.Drawing.Size(146, 15)
        Me.lblShowingEntries.TabIndex = 5
        Me.lblShowingEntries.Text = "Showing 1 to 0 of 0 entries"
        '
        'cedulatracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "cedulatracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cedula Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        CType(Me.dgvCedula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCedula As System.Windows.Forms.DataGridView
    Friend WithEvents colAction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCTCNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateIssued As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblShowingEntries As System.Windows.Forms.Label
End Class
