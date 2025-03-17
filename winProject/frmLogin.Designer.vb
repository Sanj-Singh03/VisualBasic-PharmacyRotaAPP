<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLogUsername = New System.Windows.Forms.TextBox()
        Me.txtLogPassword = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnForgPW = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(426, 268)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtLogUsername
        '
        Me.txtLogUsername.Location = New System.Drawing.Point(274, 223)
        Me.txtLogUsername.Name = "txtLogUsername"
        Me.txtLogUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtLogUsername.TabIndex = 1
        '
        'txtLogPassword
        '
        Me.txtLogPassword.Location = New System.Drawing.Point(426, 223)
        Me.txtLogPassword.Name = "txtLogPassword"
        Me.txtLogPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLogPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtLogPassword.TabIndex = 2
        '
        'lblLogin
        '
        Me.lblLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(256, 109)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(292, 35)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Enter Username and Password."
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnForgPW
        '
        Me.btnForgPW.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnForgPW.Location = New System.Drawing.Point(335, 313)
        Me.btnForgPW.Name = "btnForgPW"
        Me.btnForgPW.Size = New System.Drawing.Size(129, 23)
        Me.btnForgPW.TabIndex = 6
        Me.btnForgPW.Text = "Forgot Password"
        Me.btnForgPW.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnStaff.Location = New System.Drawing.Point(12, 452)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(95, 23)
        Me.btnStaff.TabIndex = 9
        Me.btnStaff.Text = "View Rota"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(274, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(815, 487)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnForgPW)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtLogPassword)
        Me.Controls.Add(Me.txtLogUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogUsername As TextBox
    Friend WithEvents txtLogPassword As TextBox
    Friend WithEvents lblLogin As Label
    Private WithEvents btnLogin As Button
    Friend WithEvents btnForgPW As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnExit As Button
End Class
