Imports ligaya_bims

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
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.card = New System.Windows.Forms.Panel()
        Me.btnLogin = New ligaya_bims.RoundedButton()
        Me.lnkForgot = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.leftPanel.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightPanel.SuspendLayout()
        Me.card.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.leftPanel.Controls.Add(Me.picLogo)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(480, 600)
        Me.leftPanel.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.ligaya_bims.My.Resources.Resources.brgy_ligaya_logo
        Me.picLogo.Location = New System.Drawing.Point(1, 55)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(476, 467)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'rightPanel
        '
        Me.rightPanel.BackColor = System.Drawing.Color.White
        Me.rightPanel.Controls.Add(Me.card)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightPanel.Location = New System.Drawing.Point(480, 0)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(480, 600)
        Me.rightPanel.TabIndex = 1
        '
        'card
        '
        Me.card.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.card.Controls.Add(Me.btnLogin)
        Me.card.Controls.Add(Me.lnkForgot)
        Me.card.Controls.Add(Me.txtPassword)
        Me.card.Controls.Add(Me.txtUsername)
        Me.card.Controls.Add(Me.lblTitle)
        Me.card.Location = New System.Drawing.Point(31, 123)
        Me.card.Name = "card"
        Me.card.Size = New System.Drawing.Size(420, 360)
        Me.card.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(120, 232)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(180, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lnkForgot
        '
        Me.lnkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lnkForgot.AutoSize = True
        Me.lnkForgot.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnkForgot.Location = New System.Drawing.Point(47, 190)
        Me.lnkForgot.Name = "lnkForgot"
        Me.lnkForgot.Size = New System.Drawing.Size(144, 17)
        Me.lnkForgot.TabIndex = 3
        Me.lnkForgot.TabStop = True
        Me.lnkForgot.Text = "Forgot your password?"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(49, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(320, 25)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(49, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(320, 25)
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
        Me.leftPanel.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightPanel.ResumeLayout(False)
        Me.card.ResumeLayout(False)
        Me.card.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As System.Windows.Forms.Panel
    Friend WithEvents rightPanel As System.Windows.Forms.Panel
    Friend WithEvents card As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lnkForgot As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLogin As ligaya_bims.RoundedButton
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
