'Main Body of the Code. These are all objects present in the program that are being used directly.

Imports System.Data.SQLite
Public Class frmRota

    'public SQL command that can be used with the display() subroutine to display the table

    Public rSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid=r.employeeid AND r.storeid = st.sid AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift;"

    'Select a date for the rota
    Private Sub btnRotaDate_Click(sender As Object, e As EventArgs) Handles btnRotaDate.Click

        Dim connectiontodatabase As String = ("Data Source=Pharmacy.db")
        Dim connection As New SQLiteConnection(connectiontodatabase)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim cmd As New SQLiteCommand(rSQL, connection)
        Dim da As New SQLiteDataAdapter(cmd)
        Dim cb As New SQLiteCommandBuilder(da)
        Dim n As Integer
        Dim dupe As Boolean
        Dim maxrows As Integer



        connection.Open()
        da = New SQLiteDataAdapter("SELECT * FROM rota;", connection)
        da.Fill(ds, "rota")
        connection.Close()
        maxrows = ds.Tables("rota").Rows.Count

        'MessageBox.Show(maxrows)
        'MessageBox.Show(ds.Tables("rota").Rows(2).Item(0))
    End Sub

    'Button Updates the view of the rota
    Private Sub btnShowRota_Click(sender As Object, e As EventArgs) Handles btnShowRota.Click
        If txtRotaEmployee.Text <> "" Or cmbRotaStoreID.SelectedItem <> "" Then
            If txtRotaEmployee.Text <> "" And cmbRotaStoreID.SelectedItem <> "" Then
                Dim sSQL As String = "Select Case e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
From rota AS r , employees AS e , store As st, startshift AS sh, endshift AS en
WHERE e.eid = " & txtRotaEmployee.Text & " AND st.sid = " & selstore(cmbRotaStoreID.SelectedItem) & "  AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift ;"
                dgvDataShower.DataSource = display(sSQL, "rota")
            ElseIf txtRotaEmployee.Text <> "" And cmbRotaStoreID.SelectedItem = "" Then
                Dim sSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid= " & txtRotaEmployee.Text & " AND r.storeid = st.sid AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift;"
                dgvDataShower.DataSource = display(sSQL, "rota")
            ElseIf txtRotaEmployee.Text = "" And cmbRotaStoreID.SelectedItem <> "" Then
                Dim sSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid=r.employeeid AND r.storeid = st.sid  AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift and r.storeid = " & selstore(cmbRotaStoreID.SelectedItem) & " ;"
                dgvDataShower.DataSource = display(sSQL, "rota")
            End If
        ElseIf txtRotaDate.Text <> "" And txtRotaEmployee.Text <> "" And cmbRotaEndShift.SelectedItem <> "" And cmbRotaStartShift.SelectedItem <> "" And cmbRotaStoreID.SelectedItem <> "" Then
            dgvDataShower.DataSource = display(rSQL, "rota")
        End If

    End Sub

    'Button adds to the rota system
    Private Sub btnRotaAdd_Click(sender As Object, e As EventArgs) Handles btnRotaAdd.Click
        Dim a As Integer
        Dim c As String

        Dim connectiontodatabase As String = ("Data Source=Pharmacy.db")
        Dim connection As New SQLiteConnection(connectiontodatabase)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim cmd As New SQLiteCommand(rSQL, connection)
        Dim da As New SQLiteDataAdapter(cmd)
        Dim cb As New SQLiteCommandBuilder(da)
        Dim n As Integer
        Dim dupe As Boolean

        connection.Open()
        da = New SQLiteDataAdapter("SELECT * FROM rota;", connection)
        da.Fill(ds, "rota")
        connection.Close()

        Dim maxrows As Integer
        maxrows = ds.Tables("rota").Rows.Count

        'conversion of employee id

        If txtRotaEmployee.Text <> "" Then
            a = Convert.ToInt32(txtRotaEmployee.Text)
        Else
            txtRotaEmployee.Text = "Please fill with Employee ID."
        End If

        'creating objects for the double booking, done for tidiness while giving up a little bit of efficiency
        Dim number1 As Integer = seltime(cmbRotaStartShift.SelectedItem)
        Dim number2 As Integer = seltime(cmbRotaEndShift.SelectedItem)
        Dim pdate As String = txtRotaDate.Text
        Dim condition0 As Integer = ds.Tables("rota").Rows(n).Item(0)
        Dim condition1 As Integer = ds.Tables("rota").Rows(n).Item(1)
        Dim condition2 As String = ds.Tables("rota").Rows(n).Item(2)
        Dim condition3 As Integer = ds.Tables("rota").Rows(n).Item(3)
        Dim condition4 As Integer = ds.Tables("rota").Rows(n).Item(4)

        For n = 0 To maxrows - 1

            If txtRotaEmployee.Text = condition0 And selstore(cmbRotaStoreID.SelectedItem) = condition1 And pdate = condition2 And number1 = condition3 And number2 = condition4 Then
                dupe = True
            Else
                dupe = False
                Exit For
            End If
        Next
        If dupe = False Then
            Dim arSQL As String = "INSERT INTO rota(employeeid,storeid,date,rotastartshift,rotaendshift)VALUES
(" & a & ", " & selstore(cmbRotaStoreID.SelectedItem) & ",'" & txtRotaDate.Text & "'," & number1 & "," & number2 & " );"
            rota(arSQL)

            connection.Open()
            da = New SQLiteDataAdapter("SELECT * FROM rota;", connection)
            da.Fill(ds, "rota")
            connection.Close()
            maxrows = ds.Tables("rota").Rows.Count

            MessageBox.Show("Rota booking made.")
            txtRotaDate.Text = ""
            txtRotaEmployee.Text = ""
            cmbRotaEndShift.Text = ""
            cmbRotaStartShift.Text = ""
            cmbRotaStoreID.Text = ""

        ElseIf dupe = True Then
            MessageBox.Show("Rota is already booked.")
        End If

        dgvDataShower.DataSource = display(rSQL, "rota")

    End Sub

    'Deletes from the rota by using the same textboxes 
    Private Sub btnDelRota_Click(sender As Object, e As EventArgs) Handles btnDelRota.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As String

        If txtRotaEmployee.Text <> "" Then
            a = Convert.ToInt32(txtRotaEmployee.Text)
        Else
            txtRotaEmployee.Text = "Please fill with Employee ID."
        End If




        'Select store
        If cmbRotaStoreID.SelectedItem = "1. Hounslow" Then
            b = 1
        ElseIf cmbRotaStoreID.SelectedItem = "2. Twickenham" Then
            b = 2
        ElseIf cmbRotaStoreID.SelectedItem = "3. Southall" Then
            b = 3
        Else
            cmbRotaStoreID.Text = "Please select a Store."
        End If

        'Select date

        If txtRotaDate.Text <> "" Then
            txtRotaDate.Text = dtpRotaDate.Value.Date.ToString("dd-MM-yyyy")
        Else
            txtRotaDate.Text = "Please select a Date."
        End If
        'Use the same textboxes to create a delete from rota query to use with the delete() subroutine
        Dim rdSQL As String = "DELETE FROM rota WHERE employeeid = " & a & " AND storeid = " & b & " AND date = '" & txtRotaDate.Text & "' AND rotastartshift = " & seltime(cmbRotaStartShift.SelectedItem) & " AND rotaendshift = " & seltime(cmbRotaEndShift.SelectedItem) & ";"

        delete(rdSQL)

        dgvDataShower.DataSource = display(rSQL, "rota")
    End Sub

    'add to availability
    Private Sub btnAvadd_Click(sender As Object, e As EventArgs) Handles btnAvadd.Click
        Dim a, c, st, en As Integer
        a = Convert.ToInt32(txtAvaEmp.Text)

        'select start and end time using seltime() subroutine, if False is returned then a text in the combobox will show up
        If seltime(cmbAvaStartShift.SelectedItem) <> False Then
            st = seltime(cmbAvaStartShift.SelectedItem)
        Else
            cmbRotaStartShift.Text = "Please Select a Start of the Shift."
        End If

        If seltime(cmbAvaEndShift.SelectedItem) <> False Then
            en = seltime(cmbAvaEndShift.SelectedItem)
        Else
            cmbRotaEndShift.Text = "Please Select a End of the Shift."
        End If

        'insert into query using selday() and add() subroutines
        Dim avaSQL As String = "INSERT INTO availability(empid,dayname,stshid,enshid,reason)VALUES 
(" & a & ", '" & selday(cmbAvaDay.SelectedItem) & "', " & st & ", " & en & ", '" & txtAvaReason.Text & "');"
        add(avaSQL)

    End Sub

    'Shows availability table
    Private Sub btnAvaShow_Click(sender As Object, e As EventArgs) Handles btnAvaShow.Click
        Dim avaSQL As String = "SELECT e.efname AS 'Firstname', e.elname AS 'Lastname', e.eskills AS 'Skills', a.dayname AS 'Day', sh.starthour AS 'Start of the Shift', en.endhour AS 'End of the Shift' , a.reason AS 'Reason' 
FROM availability AS a, employees AS e, startshift AS sh, endshift AS en 
WHERE e.eid = a.empid  AND a.stshid = sh.startid AND a.enshid = en.endid;"
        dgvDataShower.DataSource = display(avaSQL, "availability")
    End Sub

    'Deleted from availability table using selday(), seltime(), delete() and display subroutines
    Private Sub btnAvaDel_Click(sender As Object, e As EventArgs) Handles btnAvaDel.Click
        Dim a, c As Integer

        a = Convert.ToInt32(txtAvaEmp.Text)


        Dim b As String = cmbAvaDay.SelectedItem

        Dim avaSQL As String = "DELETE FROM availability WHERE empid = " & a & " AND dayname = '" & selday(b) & "' AND stshid = " & seltime(cmbAvaStartShift.SelectedItem) & " AND enshid = " & seltime(cmbAvaEndShift.SelectedItem) & "  ;"
        delete(avaSQL)

        Dim avsSQL As String = "SELECT e.efname AS Firstname,e.elname AS Lastname ,e.eskills AS Skills ,a.dayname AS Day, h.hours AS Shift, a.reason AS Reason 
FROM availability as a ,employees as e, hours as h WHERE e.eid = a.empid  AND h.hid = a.hoid;"
        dgvDataShower.DataSource = display(avsSQL, "availability")
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Close()
        frmMainMenu.Close()
        frmHolidays.Close()
        frmEmployees.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        frmStaffView.Close()
    End Sub

    Private Sub frmRota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDataShower.DataSource = display(rSQL, "rota")
    End Sub

    Private Sub dtpRotaDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpRotaDate.ValueChanged
        txtRotaDate.Text = dtpRotaDate.Value.Date.ToString("dd-MM-yyyy")
    End Sub
End Class