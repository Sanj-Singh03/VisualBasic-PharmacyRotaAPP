<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnHolidays = New System.Windows.Forms.Button()
        Me.btnRota = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturnToLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(511, 62)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(214, 56)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnHolidays
        '
        Me.btnHolidays.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnHolidays.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHolidays.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHolidays.Location = New System.Drawing.Point(511, 154)
        Me.btnHolidays.Name = "btnHolidays"
        Me.btnHolidays.Size = New System.Drawing.Size(214, 56)
        Me.btnHolidays.TabIndex = 1
        Me.btnHolidays.Text = "Holiday Booking"
        Me.btnHolidays.UseVisualStyleBackColor = False
        '
        'btnRota
        '
        Me.btnRota.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnRota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRota.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRota.Location = New System.Drawing.Point(511, 245)
        Me.btnRota.Name = "btnRota"
        Me.btnRota.Size = New System.Drawing.Size(214, 56)
        Me.btnRota.TabIndex = 2
        Me.btnRota.Text = "Rota"
        Me.btnRota.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(40, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Close and Save"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReturnToLogin
        '
        Me.btnReturnToLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnReturnToLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnToLogin.Location = New System.Drawing.Point(176, 415)
        Me.btnReturnToLogin.Name = "btnReturnToLogin"
        Me.btnReturnToLogin.Size = New System.Drawing.Size(109, 23)
        Me.btnReturnToLogin.TabIndex = 4
        Me.btnReturnToLogin.Text = "Login"
        Me.btnReturnToLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select a section you want to View/Edit."
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(812, 452)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturnToLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRota)
        Me.Controls.Add(Me.btnHolidays)
        Me.Controls.Add(Me.btnEmployees)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnHolidays As Button
    Friend WithEvents btnRota As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReturnToLogin As Button
    Friend WithEvents Label1 As Label
End Class
