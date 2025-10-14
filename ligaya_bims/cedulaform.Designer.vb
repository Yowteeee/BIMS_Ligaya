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
        Me.txtCTC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLast = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiddle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPlace = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.txtCTC.BorderRadius = 6
        Me.txtCTC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTC.DefaultText = ""
        Me.txtCTC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCTC.Location = New System.Drawing.Point(25, 60)
        Me.txtCTC.Name = "txtCTC"
        Me.txtCTC.SelectedText = ""
        Me.txtCTC.Size = New System.Drawing.Size(300, 36)
        Me.txtCTC.TabIndex = 1
        '
        'txtLast
        '
        Me.txtLast.BorderRadius = 6
        Me.txtLast.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLast.DefaultText = ""
        Me.txtLast.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLast.Location = New System.Drawing.Point(25, 110)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.SelectedText = ""
        Me.txtLast.Size = New System.Drawing.Size(300, 36)
        Me.txtLast.TabIndex = 2
        '
        'txtFirst
        '
        Me.txtFirst.BorderRadius = 6
        Me.txtFirst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirst.DefaultText = ""
        Me.txtFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirst.Location = New System.Drawing.Point(25, 160)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.SelectedText = ""
        Me.txtFirst.Size = New System.Drawing.Size(300, 36)
        Me.txtFirst.TabIndex = 3
        '
        'txtMiddle
        '
        Me.txtMiddle.BorderRadius = 6
        Me.txtMiddle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddle.DefaultText = ""
        Me.txtMiddle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddle.Location = New System.Drawing.Point(25, 210)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.SelectedText = ""
        Me.txtMiddle.Size = New System.Drawing.Size(300, 36)
        Me.txtMiddle.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.BorderRadius = 6
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(25, 260)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(300, 36)
        Me.txtAddress.TabIndex = 5
        '
        'txtPlace
        '
        Me.txtPlace.BorderRadius = 6
        Me.txtPlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlace.DefaultText = ""
        Me.txtPlace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPlace.Location = New System.Drawing.Point(25, 310)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.SelectedText = ""
        Me.txtPlace.Size = New System.Drawing.Size(300, 36)
        Me.txtPlace.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 8
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(25, 370)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 40)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(375, 110)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker1.TabIndex = 8
        Me.Guna2DateTimePicker1.Value = New Date(2025, 10, 9, 23, 9, 33, 717)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(375, 82)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(101, 22)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "Date Issued"
        '
        'cedulaform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 440)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
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
    Friend WithEvents txtCTC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLast As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPlace As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
