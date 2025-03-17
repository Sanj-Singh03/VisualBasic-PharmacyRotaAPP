<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployees
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDeLName = New System.Windows.Forms.TextBox()
        Me.txtDeFName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAddGender = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddSkills = New System.Windows.Forms.TextBox()
        Me.txtAddPostC = New System.Windows.Forms.TextBox()
        Me.txtAddAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddPN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddLName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddFName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchLName = New System.Windows.Forms.TextBox()
        Me.txtSearchFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDelete)
        Me.GroupBox4.Controls.Add(Me.txtDeLName)
        Me.GroupBox4.Controls.Add(Me.txtDeFName)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(152, 406)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(177, 98)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(63, 71)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 21)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtDeLName
        '
        Me.txtDeLName.Location = New System.Drawing.Point(75, 45)
        Me.txtDeLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeLName.Name = "txtDeLName"
        Me.txtDeLName.Size = New System.Drawing.Size(86, 22)
        Me.txtDeLName.TabIndex = 5
        '
        'txtDeFName
        '
        Me.txtDeFName.Location = New System.Drawing.Point(75, 22)
        Me.txtDeFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeFName.Name = "txtDeFName"
        Me.txtDeFName.Size = New System.Drawing.Size(86, 22)
        Me.txtDeFName.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(4, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Last Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAddGender)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtAddSkills)
        Me.GroupBox2.Controls.Add(Me.txtAddPostC)
        Me.GroupBox2.Controls.Add(Me.txtAddAddress)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAddPN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAddLName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAddFName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 299)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(455, 205)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add"
        '
        'txtAddGender
        '
        Me.txtAddGender.Location = New System.Drawing.Point(98, 152)
        Me.txtAddGender.Name = "txtAddGender"
        Me.txtAddGender.Size = New System.Drawing.Size(76, 22)
        Me.txtAddGender.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(4, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 14)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Gender:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(86, 181)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 19)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAddSkills
        '
        Me.txtAddSkills.Location = New System.Drawing.Point(222, 17)
        Me.txtAddSkills.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddSkills.Multiline = True
        Me.txtAddSkills.Name = "txtAddSkills"
        Me.txtAddSkills.Size = New System.Drawing.Size(226, 181)
        Me.txtAddSkills.TabIndex = 14
        '
        'txtAddPostC
        '
        Me.txtAddPostC.Location = New System.Drawing.Point(98, 99)
        Me.txtAddPostC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddPostC.Name = "txtAddPostC"
        Me.txtAddPostC.Size = New System.Drawing.Size(76, 22)
        Me.txtAddPostC.TabIndex = 11
        '
        'txtAddAddress
        '
        Me.txtAddAddress.Location = New System.Drawing.Point(98, 73)
        Me.txtAddAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddAddress.Name = "txtAddAddress"
        Me.txtAddAddress.Size = New System.Drawing.Size(76, 22)
        Me.txtAddAddress.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(4, 107)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 14)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Postcode:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Number:"
        '
        'txtAddPN
        '
        Me.txtAddPN.Location = New System.Drawing.Point(98, 125)
        Me.txtAddPN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddPN.Name = "txtAddPN"
        Me.txtAddPN.Size = New System.Drawing.Size(76, 22)
        Me.txtAddPN.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(178, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Skills:"
        '
        'txtAddLName
        '
        Me.txtAddLName.Location = New System.Drawing.Point(98, 47)
        Me.txtAddLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddLName.Name = "txtAddLName"
        Me.txtAddLName.Size = New System.Drawing.Size(76, 22)
        Me.txtAddLName.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(4, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address:"
        '
        'txtAddFName
        '
        Me.txtAddFName.Location = New System.Drawing.Point(98, 21)
        Me.txtAddFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddFName.Name = "txtAddFName"
        Me.txtAddFName.Size = New System.Drawing.Size(76, 22)
        Me.txtAddFName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSearchLName)
        Me.GroupBox1.Controls.Add(Me.txtSearchFname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(152, 299)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(177, 103)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name:"
        '
        'txtSearchLName
        '
        Me.txtSearchLName.Location = New System.Drawing.Point(75, 45)
        Me.txtSearchLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchLName.Name = "txtSearchLName"
        Me.txtSearchLName.Size = New System.Drawing.Size(86, 22)
        Me.txtSearchLName.TabIndex = 2
        '
        'txtSearchFname
        '
        Me.txtSearchFname.Location = New System.Drawing.Point(75, 22)
        Me.txtSearchFname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchFname.Name = "txtSearchFname"
        Me.txtSearchFname.Size = New System.Drawing.Size(86, 22)
        Me.txtSearchFname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(63, 71)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 21)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 13)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(776, 281)
        Me.dgvEmployees.TabIndex = 11
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(12, 446)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 23)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Back to Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(12, 475)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Close and Save"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.Location = New System.Drawing.Point(12, 417)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(110, 23)
        Me.btnMainMenu.TabIndex = 14
        Me.btnMainMenu.Text = "Back to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 515)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmployees"
        Me.Text = "Employees"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDeLName As TextBox
    Friend WithEvents txtDeFName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAddGender As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAddSkills As TextBox
    Friend WithEvents txtAddPostC As TextBox
    Friend WithEvents txtAddAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddPN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddLName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddFName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchLName As TextBox
    Friend WithEvents txtSearchFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMainMenu As Button
End Class
