<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.leftPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.rightPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.card = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lnkForgot = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rightPanel.SuspendLayout()
        Me.card.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftPanel
        '
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.FillColor = System.Drawing.Color.RoyalBlue
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(480, 600)
        Me.leftPanel.TabIndex = 0
        '
        'rightPanel
        '
        Me.rightPanel.Controls.Add(Me.card)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightPanel.FillColor = System.Drawing.Color.White
        Me.rightPanel.Location = New System.Drawing.Point(480, 0)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(480, 600)
        Me.rightPanel.TabIndex = 1
        '
        'card
        '
        Me.card.BackColor = System.Drawing.Color.Transparent
        Me.card.BorderRadius = 18
        Me.card.Controls.Add(Me.btnLogin)
        Me.card.Controls.Add(Me.lnkForgot)
        Me.card.Controls.Add(Me.txtPassword)
        Me.card.Controls.Add(Me.txtUsername)
        Me.card.Controls.Add(Me.lblTitle)
        Me.card.FillColor = System.Drawing.Color.White
        Me.card.Location = New System.Drawing.Point(31, 123)
        Me.card.Name = "card"
        Me.card.ShadowDecoration.Depth = 8
        Me.card.ShadowDecoration.Enabled = True
        Me.card.Size = New System.Drawing.Size(420, 360)
        Me.card.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(120, 232)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(180, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log in"
        '
        'lnkForgot
        '
        Me.lnkForgot.AutoSize = True
        Me.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lnkForgot.Location = New System.Drawing.Point(59, 199)
        Me.lnkForgot.Name = "lnkForgot"
        Me.lnkForgot.Size = New System.Drawing.Size(144, 17)
        Me.lnkForgot.TabIndex = 3
        Me.lnkForgot.TabStop = True
        Me.lnkForgot.Text = "Forgot your password?"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(50, 152)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(320, 44)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(49, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(320, 44)
        Me.txtUsername.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(420, 70)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.MinimumSize = New System.Drawing.Size(960, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.rightPanel.ResumeLayout(False)
        Me.card.ResumeLayout(False)
        Me.card.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rightPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents card As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lnkForgot As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button

End Class
