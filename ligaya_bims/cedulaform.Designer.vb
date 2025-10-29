Imports ligaya_bims

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cedulaform
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtCTC = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New ligaya_bims.RoundedButton()
        Me.dtpIssued = New System.Windows.Forms.DateTimePicker()
        Me.lblIssued = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(143, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Cedula Form"
        '
        'txtCTC
        '
        Me.txtCTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCTC.Location = New System.Drawing.Point(25, 60)
        Me.txtCTC.Name = "txtCTC"
        Me.txtCTC.Size = New System.Drawing.Size(300, 23)
        Me.txtCTC.TabIndex = 1
        '
        'txtLast
        '
        Me.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLast.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLast.Location = New System.Drawing.Point(25, 110)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(300, 23)
        Me.txtLast.TabIndex = 2
        '
        'txtFirst
        '
        Me.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirst.Location = New System.Drawing.Point(25, 160)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(300, 23)
        Me.txtFirst.TabIndex = 3
        '
        'txtMiddle
        '
        Me.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddle.Location = New System.Drawing.Point(25, 210)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(300, 23)
        Me.txtMiddle.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(25, 260)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(300, 23)
        Me.txtAddress.TabIndex = 5
        '
        'txtPlace
        '
        Me.txtPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPlace.Location = New System.Drawing.Point(25, 310)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(300, 23)
        Me.txtPlace.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(25, 370)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 32)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        '
        'dtpIssued
        '
        Me.dtpIssued.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpIssued.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpIssued.Location = New System.Drawing.Point(375, 110)
        Me.dtpIssued.Name = "dtpIssued"
        Me.dtpIssued.Size = New System.Drawing.Size(200, 23)
        Me.dtpIssued.TabIndex = 8
        '
        'lblIssued
        '
        Me.lblIssued.AutoSize = True
        Me.lblIssued.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblIssued.Location = New System.Drawing.Point(375, 82)
        Me.lblIssued.Name = "lblIssued"
        Me.lblIssued.Size = New System.Drawing.Size(106, 21)
        Me.lblIssued.TabIndex = 9
        Me.lblIssued.Text = "Date Issued"
        '
        'cedulaform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 440)
        Me.Controls.Add(Me.lblIssued)
        Me.Controls.Add(Me.dtpIssued)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtCTC)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.btnSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cedulaform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cedula Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtCTC As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddle As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As ligaya_bims.RoundedButton
    Friend WithEvents dtpIssued As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIssued As System.Windows.Forms.Label
End Class
