<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffView
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
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.cmbRotaStoreID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRotaEmployee = New System.Windows.Forms.TextBox()
        Me.btnShowRota = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(12, 12)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(776, 301)
        Me.dgvStaff.TabIndex = 0
        '
        'cmbRotaStoreID
        '
        Me.cmbRotaStoreID.FormattingEnabled = True
        Me.cmbRotaStoreID.Items.AddRange(New Object() {"1. Hounslow", "2. Twickenham", "3. Southall"})
        Me.cmbRotaStoreID.Location = New System.Drawing.Point(93, 336)
        Me.cmbRotaStoreID.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRotaStoreID.Name = "cmbRotaStoreID"
        Me.cmbRotaStoreID.Size = New System.Drawing.Size(168, 21)
        Me.cmbRotaStoreID.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(9, 338)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 14)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "StoreID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(9, 363)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "EmployeeID:"
        '
        'txtRotaEmployee
        '
        Me.txtRotaEmployee.Location = New System.Drawing.Point(93, 360)
        Me.txtRotaEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRotaEmployee.Name = "txtRotaEmployee"
        Me.txtRotaEmployee.Size = New System.Drawing.Size(168, 20)
        Me.txtRotaEmployee.TabIndex = 29
        '
        'btnShowRota
        '
        Me.btnShowRota.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnShowRota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowRota.Location = New System.Drawing.Point(12, 401)
        Me.btnShowRota.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowRota.Name = "btnShowRota"
        Me.btnShowRota.Size = New System.Drawing.Size(142, 38)
        Me.btnShowRota.TabIndex = 40
        Me.btnShowRota.Text = "Search"
        Me.btnShowRota.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(678, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "Close and Save"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(678, 392)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 23)
        Me.btnLogin.TabIndex = 41
        Me.btnLogin.Text = "Back to Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmStaffView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnShowRota)
        Me.Controls.Add(Me.cmbRotaStoreID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRotaEmployee)
        Me.Controls.Add(Me.dgvStaff)
        Me.Name = "frmStaffView"
        Me.Text = "Rota System"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents cmbRotaStoreID As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRotaEmployee As TextBox
    Friend WithEvents btnShowRota As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
End Class
