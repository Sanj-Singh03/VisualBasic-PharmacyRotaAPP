<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRota
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
        Me.dgvDataShower = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbRotaEndShift = New System.Windows.Forms.ComboBox()
        Me.btnDelRota = New System.Windows.Forms.Button()
        Me.btnShowRota = New System.Windows.Forms.Button()
        Me.cmbRotaStartShift = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRotaStoreID = New System.Windows.Forms.ComboBox()
        Me.btnRotaAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRotaEmployee = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRotaDate = New System.Windows.Forms.Button()
        Me.dtpRotaDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRotaDate = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbAvaEndShift = New System.Windows.Forms.ComboBox()
        Me.cmbAvaStartShift = New System.Windows.Forms.ComboBox()
        Me.btnAvaDel = New System.Windows.Forms.Button()
        Me.btnAvaShow = New System.Windows.Forms.Button()
        Me.txtAvaReason = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbAvaDay = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAvaEmp = New System.Windows.Forms.TextBox()
        Me.btnAvadd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.dgvDataShower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataShower
        '
        Me.dgvDataShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataShower.Location = New System.Drawing.Point(9, 10)
        Me.dgvDataShower.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDataShower.Name = "dgvDataShower"
        Me.dgvDataShower.RowHeadersWidth = 51
        Me.dgvDataShower.RowTemplate.Height = 24
        Me.dgvDataShower.Size = New System.Drawing.Size(924, 352)
        Me.dgvDataShower.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.cmbRotaEndShift)
        Me.GroupBox3.Controls.Add(Me.btnDelRota)
        Me.GroupBox3.Controls.Add(Me.btnShowRota)
        Me.GroupBox3.Controls.Add(Me.cmbRotaStartShift)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmbRotaStoreID)
        Me.GroupBox3.Controls.Add(Me.btnRotaAdd)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtRotaEmployee)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnRotaDate)
        Me.GroupBox3.Controls.Add(Me.dtpRotaDate)
        Me.GroupBox3.Controls.Add(Me.txtRotaDate)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 366)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(549, 242)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add to Rota"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(307, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 14)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Start Shift:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(312, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 14)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "End Shift:"
        '
        'cmbRotaEndShift
        '
        Me.cmbRotaEndShift.FormattingEnabled = True
        Me.cmbRotaEndShift.ItemHeight = 14
        Me.cmbRotaEndShift.Items.AddRange(New Object() {"1. 00:00", "2. 00:30", "3. 01:00", "4. 01:30", "5. 02:00", "6. 02:30", "7. 03:00", "8. 03:30", "9. 04:00", "10. 04:30", "11. 05:00", "12. 05:30", "13. 06:00", "14. 06:30", "15. 07:00", "16. 07:30", "17. 08:00", "18. 08:30", "19. 09:00", "20. 09:30", "21. 10:00", "22. 10:30", "23. 11:00", "24. 11:30", "25. 12:00", "26. 12:30", "27. 13:00", "28. 13:30", "29. 14:00", "30. 14:30", "31. 15:00", "32. 15:30", "33. 16:00", "34. 16:30", "35. 17:00", "36. 17:30", "37. 18:00", "38. 18:30", "39. 19:00", "40. 19:30", "41. 20:00", "42. 20:30", "43. 21:00", "44. 21:30", "45. 22:00", "46. 22:30", "47. 23:00", "48. 23:30"})
        Me.cmbRotaEndShift.Location = New System.Drawing.Point(373, 67)
        Me.cmbRotaEndShift.Name = "cmbRotaEndShift"
        Me.cmbRotaEndShift.Size = New System.Drawing.Size(168, 22)
        Me.cmbRotaEndShift.TabIndex = 5
        '
        'btnDelRota
        '
        Me.btnDelRota.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelRota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelRota.Location = New System.Drawing.Point(16, 178)
        Me.btnDelRota.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelRota.Name = "btnDelRota"
        Me.btnDelRota.Size = New System.Drawing.Size(168, 50)
        Me.btnDelRota.TabIndex = 8
        Me.btnDelRota.Text = "Delete Shift"
        Me.btnDelRota.UseVisualStyleBackColor = False
        '
        'btnShowRota
        '
        Me.btnShowRota.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnShowRota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowRota.Location = New System.Drawing.Point(188, 178)
        Me.btnShowRota.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowRota.Name = "btnShowRota"
        Me.btnShowRota.Size = New System.Drawing.Size(168, 50)
        Me.btnShowRota.TabIndex = 7
        Me.btnShowRota.Text = "Show Rota"
        Me.btnShowRota.UseVisualStyleBackColor = False
        '
        'cmbRotaStartShift
        '
        Me.cmbRotaStartShift.FormattingEnabled = True
        Me.cmbRotaStartShift.ItemHeight = 14
        Me.cmbRotaStartShift.Items.AddRange(New Object() {"1. 00:00", "2. 00:30", "3. 01:00", "4. 01:30", "5. 02:00", "6. 02:30", "7. 03:00", "8. 03:30", "9. 04:00", "10. 04:30", "11. 05:00", "12. 05:30", "13. 06:00", "14. 06:30", "15. 07:00", "16. 07:30", "17. 08:00", "18. 08:30", "19. 09:00", "20. 09:30", "21. 10:00", "22. 10:30", "23. 11:00", "24. 11:30", "25. 12:00", "26. 12:30", "27. 13:00", "28. 13:30", "29. 14:00", "30. 14:30", "31. 15:00", "32. 15:30", "33. 16:00", "34. 16:30", "35. 17:00", "36. 17:30", "37. 18:00", "38. 18:30", "39. 19:00", "40. 19:30", "41. 20:00", "42. 20:30", "43. 21:00", "44. 21:30", "45. 22:00", "46. 22:30", "47. 23:00", "48. 23:30"})
        Me.cmbRotaStartShift.Location = New System.Drawing.Point(373, 31)
        Me.cmbRotaStartShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRotaStartShift.Name = "cmbRotaStartShift"
        Me.cmbRotaStartShift.Size = New System.Drawing.Size(168, 22)
        Me.cmbRotaStartShift.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(271, 52)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 14)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Shift:"
        '
        'cmbRotaStoreID
        '
        Me.cmbRotaStoreID.FormattingEnabled = True
        Me.cmbRotaStoreID.Items.AddRange(New Object() {"1. Hounslow", "2. Twickenham", "3. Southall"})
        Me.cmbRotaStoreID.Location = New System.Drawing.Point(88, 123)
        Me.cmbRotaStoreID.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRotaStoreID.Name = "cmbRotaStoreID"
        Me.cmbRotaStoreID.Size = New System.Drawing.Size(168, 22)
        Me.cmbRotaStoreID.TabIndex = 2
        '
        'btnRotaAdd
        '
        Me.btnRotaAdd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnRotaAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotaAdd.Location = New System.Drawing.Point(360, 177)
        Me.btnRotaAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRotaAdd.Name = "btnRotaAdd"
        Me.btnRotaAdd.Size = New System.Drawing.Size(168, 51)
        Me.btnRotaAdd.TabIndex = 6
        Me.btnRotaAdd.Text = "Add to Rota"
        Me.btnRotaAdd.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(4, 125)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "StoreID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(4, 150)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "EmployeeID:"
        '
        'txtRotaEmployee
        '
        Me.txtRotaEmployee.Location = New System.Drawing.Point(88, 147)
        Me.txtRotaEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRotaEmployee.Name = "txtRotaEmployee"
        Me.txtRotaEmployee.Size = New System.Drawing.Size(168, 22)
        Me.txtRotaEmployee.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(4, 52)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Date:"
        '
        'btnRotaDate
        '
        Me.btnRotaDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnRotaDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRotaDate.Location = New System.Drawing.Point(176, 68)
        Me.btnRotaDate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRotaDate.Name = "btnRotaDate"
        Me.btnRotaDate.Size = New System.Drawing.Size(80, 23)
        Me.btnRotaDate.TabIndex = 1
        Me.btnRotaDate.Text = "Select Date"
        Me.btnRotaDate.UseVisualStyleBackColor = False
        '
        'dtpRotaDate
        '
        Me.dtpRotaDate.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.dtpRotaDate.Location = New System.Drawing.Point(38, 32)
        Me.dtpRotaDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpRotaDate.Name = "dtpRotaDate"
        Me.dtpRotaDate.Size = New System.Drawing.Size(219, 22)
        Me.dtpRotaDate.TabIndex = 18
        '
        'txtRotaDate
        '
        Me.txtRotaDate.Location = New System.Drawing.Point(38, 68)
        Me.txtRotaDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRotaDate.Name = "txtRotaDate"
        Me.txtRotaDate.Size = New System.Drawing.Size(134, 22)
        Me.txtRotaDate.TabIndex = 17
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.cmbAvaEndShift)
        Me.GroupBox5.Controls.Add(Me.cmbAvaStartShift)
        Me.GroupBox5.Controls.Add(Me.btnAvaDel)
        Me.GroupBox5.Controls.Add(Me.btnAvaShow)
        Me.GroupBox5.Controls.Add(Me.txtAvaReason)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.cmbAvaDay)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtAvaEmp)
        Me.GroupBox5.Controls.Add(Me.btnAvadd)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(564, 366)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(528, 242)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Availability"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(4, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 14)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Start Shift:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label23.Location = New System.Drawing.Point(4, 141)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 14)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "End Shift:"
        '
        'cmbAvaEndShift
        '
        Me.cmbAvaEndShift.FormattingEnabled = True
        Me.cmbAvaEndShift.Items.AddRange(New Object() {"1. 00:00", "2. 00:30", "3. 01:00", "4. 01:30", "5. 02:00", "6. 02:30", "7. 03:00", "8. 03:30", "9. 04:00", "10. 04:30", "11. 05:00", "12. 05:30", "13. 06:00", "14. 06:30", "15. 07:00", "16. 07:30", "17. 08:00", "18. 08:30", "19. 09:00", "20. 09:30", "21. 10:00", "22. 10:30", "23. 11:00", "24. 11:30", "25. 12:00", "26. 12:30", "27. 13:00", "28. 13:30", "29. 14:00", "30. 14:30", "31. 15:00", "32. 15:30", "33. 16:00", "34. 16:30", "35. 17:00", "36. 17:30", "37. 18:00", "38. 18:30", "39. 19:00", "40. 19:30", "41. 20:00", "42. 20:30", "43. 21:00", "44. 21:30", "45. 22:00", "46. 22:30", "47. 23:00", "48. 23:30"})
        Me.cmbAvaEndShift.Location = New System.Drawing.Point(88, 133)
        Me.cmbAvaEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAvaEndShift.Name = "cmbAvaEndShift"
        Me.cmbAvaEndShift.Size = New System.Drawing.Size(168, 22)
        Me.cmbAvaEndShift.TabIndex = 12
        '
        'cmbAvaStartShift
        '
        Me.cmbAvaStartShift.FormattingEnabled = True
        Me.cmbAvaStartShift.Items.AddRange(New Object() {"1. 00:00", "2. 00:30", "3. 01:00", "4. 01:30", "5. 02:00", "6. 02:30", "7. 03:00", "8. 03:30", "9. 04:00", "10. 04:30", "11. 05:00", "12. 05:30", "13. 06:00", "14. 06:30", "15. 07:00", "16. 07:30", "17. 08:00", "18. 08:30", "19. 09:00", "20. 09:30", "21. 10:00", "22. 10:30", "23. 11:00", "24. 11:30", "25. 12:00", "26. 12:30", "27. 13:00", "28. 13:30", "29. 14:00", "30. 14:30", "31. 15:00", "32. 15:30", "33. 16:00", "34. 16:30", "35. 17:00", "36. 17:30", "37. 18:00", "38. 18:30", "39. 19:00", "40. 19:30", "41. 20:00", "42. 20:30", "43. 21:00", "44. 21:30", "45. 22:00", "46. 22:30", "47. 23:00", "48. 23:30"})
        Me.cmbAvaStartShift.Location = New System.Drawing.Point(88, 101)
        Me.cmbAvaStartShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAvaStartShift.Name = "cmbAvaStartShift"
        Me.cmbAvaStartShift.Size = New System.Drawing.Size(168, 22)
        Me.cmbAvaStartShift.TabIndex = 11
        '
        'btnAvaDel
        '
        Me.btnAvaDel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnAvaDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvaDel.Location = New System.Drawing.Point(348, 177)
        Me.btnAvaDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAvaDel.Name = "btnAvaDel"
        Me.btnAvaDel.Size = New System.Drawing.Size(168, 50)
        Me.btnAvaDel.TabIndex = 16
        Me.btnAvaDel.Text = "Delete"
        Me.btnAvaDel.UseVisualStyleBackColor = False
        '
        'btnAvaShow
        '
        Me.btnAvaShow.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnAvaShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvaShow.Location = New System.Drawing.Point(4, 177)
        Me.btnAvaShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAvaShow.Name = "btnAvaShow"
        Me.btnAvaShow.Size = New System.Drawing.Size(168, 50)
        Me.btnAvaShow.TabIndex = 15
        Me.btnAvaShow.Text = "Show Availability"
        Me.btnAvaShow.UseVisualStyleBackColor = False
        '
        'txtAvaReason
        '
        Me.txtAvaReason.Location = New System.Drawing.Point(348, 31)
        Me.txtAvaReason.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAvaReason.Multiline = True
        Me.txtAvaReason.Name = "txtAvaReason"
        Me.txtAvaReason.Size = New System.Drawing.Size(168, 107)
        Me.txtAvaReason.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(287, 38)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 14)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Reason:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(4, 72)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 14)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Day:"
        '
        'cmbAvaDay
        '
        Me.cmbAvaDay.FormattingEnabled = True
        Me.cmbAvaDay.ItemHeight = 14
        Me.cmbAvaDay.Items.AddRange(New Object() {"1. Monday", "2. Tuesday", "3. Wednesday", "4. Thursday", "5. Friday", "6. Saturday", "7. Sunday"})
        Me.cmbAvaDay.Location = New System.Drawing.Point(88, 64)
        Me.cmbAvaDay.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAvaDay.Name = "cmbAvaDay"
        Me.cmbAvaDay.Size = New System.Drawing.Size(168, 22)
        Me.cmbAvaDay.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(1, 43)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 14)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "EmployeeID:"
        '
        'txtAvaEmp
        '
        Me.txtAvaEmp.Location = New System.Drawing.Point(88, 35)
        Me.txtAvaEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAvaEmp.Name = "txtAvaEmp"
        Me.txtAvaEmp.Size = New System.Drawing.Size(168, 22)
        Me.txtAvaEmp.TabIndex = 9
        '
        'btnAvadd
        '
        Me.btnAvadd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnAvadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvadd.Location = New System.Drawing.Point(176, 177)
        Me.btnAvadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAvadd.Name = "btnAvadd"
        Me.btnAvadd.Size = New System.Drawing.Size(168, 50)
        Me.btnAvadd.TabIndex = 14
        Me.btnAvadd.Text = "Add Availability"
        Me.btnAvadd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(989, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Close and Save"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.Location = New System.Drawing.Point(989, 39)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(91, 23)
        Me.btnMainMenu.TabIndex = 18
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(989, 68)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(91, 23)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmRota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1102, 615)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvDataShower)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRota"
        Me.Text = "Rota"
        CType(Me.dgvDataShower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDataShower As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtRotaDate As TextBox
    Friend WithEvents dtpRotaDate As DateTimePicker
    Friend WithEvents btnRotaDate As Button
    Friend WithEvents cmbRotaStoreID As ComboBox
    Friend WithEvents btnRotaAdd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRotaEmployee As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbRotaStartShift As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnShowRota As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbAvaDay As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAvaEmp As TextBox
    Friend WithEvents btnAvadd As Button
    Friend WithEvents btnDelRota As Button
    Friend WithEvents txtAvaReason As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnAvaShow As Button
    Friend WithEvents btnAvaDel As Button
    Friend WithEvents cmbRotaEndShift As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbAvaEndShift As ComboBox
    Friend WithEvents cmbAvaStartShift As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnLogin As Button
End Class
