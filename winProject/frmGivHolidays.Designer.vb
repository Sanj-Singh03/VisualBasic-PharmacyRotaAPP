<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGivHolidays
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtHTG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGH = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(204, 45)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'txtHTG
        '
        Me.txtHTG.Location = New System.Drawing.Point(204, 92)
        Me.txtHTG.Name = "txtHTG"
        Me.txtHTG.Size = New System.Drawing.Size(100, 20)
        Me.txtHTG.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(61, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EmployeeID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(61, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Holidays to give:"
        '
        'btnGH
        '
        Me.btnGH.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnGH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGH.Location = New System.Drawing.Point(204, 155)
        Me.btnGH.Name = "btnGH"
        Me.btnGH.Size = New System.Drawing.Size(75, 37)
        Me.btnGH.TabIndex = 4
        Me.btnGH.Text = "Give Holidays"
        Me.btnGH.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(83, 155)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 37)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Save and Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmGivHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(370, 258)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHTG)
        Me.Controls.Add(Me.txtID)
        Me.Name = "frmGivHolidays"
        Me.Text = "Give Extra Holidays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtHTG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGH As Button
    Friend WithEvents btnClose As Button
End Class
