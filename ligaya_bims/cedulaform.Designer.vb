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
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(141, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Cedula Form"
        '
        'txtCTC
        '
        Me.txtCTC.BorderRadius = 6
        Me.txtCTC.PlaceholderText = "CTC Number"
        Me.txtCTC.Location = New System.Drawing.Point(25, 60)
        Me.txtCTC.Size = New System.Drawing.Size(300, 36)
        Me.txtCTC.Name = "txtCTC"
        '
        'txtLast
        '
        Me.txtLast.BorderRadius = 6
        Me.txtLast.PlaceholderText = "Last Name"
        Me.txtLast.Location = New System.Drawing.Point(25, 110)
        Me.txtLast.Size = New System.Drawing.Size(300, 36)
        Me.txtLast.Name = "txtLast"
        '
        'txtFirst
        '
        Me.txtFirst.BorderRadius = 6
        Me.txtFirst.PlaceholderText = "First Name"
        Me.txtFirst.Location = New System.Drawing.Point(25, 160)
        Me.txtFirst.Size = New System.Drawing.Size(300, 36)
        Me.txtFirst.Name = "txtFirst"
        '
        'txtMiddle
        '
        Me.txtMiddle.BorderRadius = 6
        Me.txtMiddle.PlaceholderText = "Middle Name"
        Me.txtMiddle.Location = New System.Drawing.Point(25, 210)
        Me.txtMiddle.Size = New System.Drawing.Size(300, 36)
        Me.txtMiddle.Name = "txtMiddle"
        '
        'txtAddress
        '
        Me.txtAddress.BorderRadius = 6
        Me.txtAddress.PlaceholderText = "Address"
        Me.txtAddress.Location = New System.Drawing.Point(25, 260)
        Me.txtAddress.Size = New System.Drawing.Size(450, 36)
        Me.txtAddress.Name = "txtAddress"
        '
        'txtPlace
        '
        Me.txtPlace.BorderRadius = 6
        Me.txtPlace.PlaceholderText = "Place of Issue"
        Me.txtPlace.Location = New System.Drawing.Point(25, 310)
        Me.txtPlace.Size = New System.Drawing.Size(300, 36)
        Me.txtPlace.Name = "txtPlace"
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.Location = New System.Drawing.Point(25, 370)
        Me.btnSubmit.Size = New System.Drawing.Size(120, 40)
        Me.btnSubmit.Name = "btnSubmit"

        'cedulaform
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 440)
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
End Class
