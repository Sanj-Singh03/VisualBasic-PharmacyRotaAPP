<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHolidays
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnHoliMakeBooking = New System.Windows.Forms.Button()
        Me.btnHoliShow = New System.Windows.Forms.Button()
        Me.btnHoliGive = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtHoliReason = New System.Windows.Forms.TextBox()
        Me.txtHoliDaysBook = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtHoliEid = New System.Windows.Forms.TextBox()
        Me.dgvHolidays = New System.Windows.Forms.DataGridView()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnHoliMakeBooking)
        Me.GroupBox6.Controls.Add(Me.btnHoliShow)
        Me.GroupBox6.Controls.Add(Me.btnHoliGive)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.txtHoliReason)
        Me.GroupBox6.Controls.Add(Me.txtHoliDaysBook)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtHoliEid)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(156, 289)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(632, 214)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Holiday Booking"
        '
        'btnHoliMakeBooking
        '
        Me.btnHoliMakeBooking.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnHoliMakeBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoliMakeBooking.Location = New System.Drawing.Point(19, 138)
        Me.btnHoliMakeBooking.Name = "btnHoliMakeBooking"
        Me.btnHoliMakeBooking.Size = New System.Drawing.Size(167, 50)
        Me.btnHoliMakeBooking.TabIndex = 3
        Me.btnHoliMakeBooking.Text = "Make A Booking"
        Me.btnHoliMakeBooking.UseVisualStyleBackColor = False
        '
        'btnHoliShow
        '
        Me.btnHoliShow.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnHoliShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoliShow.Location = New System.Drawing.Point(227, 139)
        Me.btnHoliShow.Name = "btnHoliShow"
        Me.btnHoliShow.Size = New System.Drawing.Size(167, 48)
        Me.btnHoliShow.TabIndex = 4
        Me.btnHoliShow.Text = "Show Bookings"
        Me.btnHoliShow.UseVisualStyleBackColor = False
        '
        'btnHoliGive
        '
        Me.btnHoliGive.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnHoliGive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoliGive.Location = New System.Drawing.Point(443, 138)
        Me.btnHoliGive.Name = "btnHoliGive"
        Me.btnHoliGive.Size = New System.Drawing.Size(167, 50)
        Me.btnHoliGive.TabIndex = 5
        Me.btnHoliGive.Text = "Give More Holidays"
        Me.btnHoliGive.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(248, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 14)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Reason:"
        '
        'txtHoliReason
        '
        Me.txtHoliReason.AcceptsTab = True
        Me.txtHoliReason.AllowDrop = True
        Me.txtHoliReason.Location = New System.Drawing.Point(301, 23)
        Me.txtHoliReason.Multiline = True
        Me.txtHoliReason.Name = "txtHoliReason"
        Me.txtHoliReason.Size = New System.Drawing.Size(309, 110)
        Me.txtHoliReason.TabIndex = 2
        '
        'txtHoliDaysBook
        '
        Me.txtHoliDaysBook.Location = New System.Drawing.Point(102, 52)
        Me.txtHoliDaysBook.Name = "txtHoliDaysBook"
        Me.txtHoliDaysBook.Size = New System.Drawing.Size(100, 22)
        Me.txtHoliDaysBook.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(6, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 14)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Days Booking:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(6, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 14)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "EmployeeID:"
        '
        'txtHoliEid
        '
        Me.txtHoliEid.Location = New System.Drawing.Point(102, 23)
        Me.txtHoliEid.Name = "txtHoliEid"
        Me.txtHoliEid.Size = New System.Drawing.Size(100, 22)
        Me.txtHoliEid.TabIndex = 0
        '
        'dgvHolidays
        '
        Me.dgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHolidays.Location = New System.Drawing.Point(12, 12)
        Me.dgvHolidays.Name = "dgvHolidays"
        Me.dgvHolidays.Size = New System.Drawing.Size(776, 271)
        Me.dgvHolidays.TabIndex = 19
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.Location = New System.Drawing.Point(12, 422)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(110, 23)
        Me.btnMainMenu.TabIndex = 22
        Me.btnMainMenu.Text = "Back to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(12, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Close and Save"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(12, 451)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 23)
        Me.btnLogin.TabIndex = 20
        Me.btnLogin.Text = "Back to Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 515)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.dgvHolidays)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frmHolidays"
        Me.Text = "Holidays"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvHolidays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnHoliMakeBooking As Button
    Friend WithEvents btnHoliShow As Button
    Friend WithEvents btnHoliGive As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtHoliReason As TextBox
    Friend WithEvents txtHoliDaysBook As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtHoliEid As TextBox
    Friend WithEvents dgvHolidays As DataGridView
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
End Class
