<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblServer = New System.Windows.Forms.Label()
		Me.cmbServer = New System.Windows.Forms.ComboBox()
		Me.Cancel = New System.Windows.Forms.Button()
		Me.OK = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtUser = New System.Windows.Forms.TextBox()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.lblSuccess = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
		Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(220, 238)
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.lblServer)
		Me.Panel1.Controls.Add(Me.cmbServer)
		Me.Panel1.Controls.Add(Me.Cancel)
		Me.Panel1.Controls.Add(Me.OK)
		Me.Panel1.Controls.Add(Me.txtPassword)
		Me.Panel1.Controls.Add(Me.txtUser)
		Me.Panel1.Controls.Add(Me.PasswordLabel)
		Me.Panel1.Controls.Add(Me.UsernameLabel)
		Me.Panel1.Location = New System.Drawing.Point(228, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(347, 302)
		Me.Panel1.TabIndex = 1
		'
		'lblServer
		'
		Me.lblServer.Location = New System.Drawing.Point(25, 150)
		Me.lblServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblServer.Name = "lblServer"
		Me.lblServer.Size = New System.Drawing.Size(293, 28)
		Me.lblServer.TabIndex = 15
		Me.lblServer.Text = "&Server"
		Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cmbServer
		'
		Me.cmbServer.FormattingEnabled = True
		Me.cmbServer.Items.AddRange(New Object() {"CMAIN1", "ts1"})
		Me.cmbServer.Location = New System.Drawing.Point(29, 182)
		Me.cmbServer.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbServer.Name = "cmbServer"
		Me.cmbServer.Size = New System.Drawing.Size(155, 24)
		Me.cmbServer.TabIndex = 2
		Me.cmbServer.Text = "CMAIN1"
		'
		'Cancel
		'
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.Location = New System.Drawing.Point(164, 233)
		Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(125, 28)
		Me.Cancel.TabIndex = 4
		Me.Cancel.Text = "&Cancel"
		'
		'OK
		'
		Me.OK.Location = New System.Drawing.Point(31, 233)
		Me.OK.Margin = New System.Windows.Forms.Padding(4)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(125, 28)
		Me.OK.TabIndex = 3
		Me.OK.Text = "&OK"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(29, 122)
		Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(292, 22)
		Me.txtPassword.TabIndex = 1
		'
		'txtUser
		'
		Me.txtUser.Location = New System.Drawing.Point(29, 52)
		Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUser.Name = "txtUser"
		Me.txtUser.Size = New System.Drawing.Size(292, 22)
		Me.txtUser.TabIndex = 0
		Me.txtUser.Text = "root"
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(27, 97)
		Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(293, 28)
		Me.PasswordLabel.TabIndex = 10
		Me.PasswordLabel.Text = "&Password"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(27, 27)
		Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(293, 28)
		Me.UsernameLabel.TabIndex = 6
		Me.UsernameLabel.Text = "&User name"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblSuccess
		'
		Me.lblSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSuccess.Location = New System.Drawing.Point(0, 265)
		Me.lblSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSuccess.Name = "lblSuccess"
		Me.lblSuccess.Size = New System.Drawing.Size(575, 47)
		Me.lblSuccess.TabIndex = 2
		Me.lblSuccess.Text = "Login was successful!"
		Me.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblSuccess.Visible = False
		'
		'Timer1
		'
		Me.Timer1.Interval = 2000
		'
		'frmlogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(576, 314)
		Me.Controls.Add(Me.lblSuccess)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmlogin"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents cmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents lblSuccess As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
