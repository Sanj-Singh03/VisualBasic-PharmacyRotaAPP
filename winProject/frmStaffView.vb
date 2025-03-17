Public Class frmStaffView
    Public rSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid=r.employeeid AND r.storeid = st.sid AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift;"
    Private Sub frmStaffView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = display(rSQL, "Rota")
    End Sub

    Private Sub btnShowRota_Click(sender As Object, e As EventArgs) Handles btnShowRota.Click
        If txtRotaEmployee.Text <> "" Or cmbRotaStoreID.SelectedItem <> "" Then
            If txtRotaEmployee.Text <> "" And cmbRotaStoreID.SelectedItem <> "" Then
                Dim sSQL As String = "Select Case e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
From rota AS r , employees AS e , store As st, startshift AS sh, endshift AS en
WHERE e.eid = " & txtRotaEmployee.Text & " AND st.sid = " & selstore(cmbRotaStoreID.SelectedItem) & "  AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift ;"
                dgvStaff.DataSource = display(sSQL, "rota")
            ElseIf txtRotaEmployee.Text <> "" And cmbRotaStoreID.SelectedItem = "" Then
                Dim sSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid= " & txtRotaEmployee.Text & " AND r.storeid = st.sid AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift;"
                dgvStaff.DataSource = display(sSQL, "rota")
            ElseIf txtRotaEmployee.Text = "" And cmbRotaStoreID.SelectedItem <> "" Then
                Dim sSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', r.date AS 'Date', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' 
FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en 
WHERE e.eid=r.employeeid AND r.storeid = st.sid  AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift and r.storeid = " & selstore(cmbRotaStoreID.SelectedItem) & " ;"
                dgvStaff.DataSource = display(sSQL, "rota")
            End If
        ElseIf txtRotaEmployee.Text <> "" And cmbRotaStoreID.SelectedItem <> "" Then
            dgvStaff.DataSource = display(rSQL, "rota")
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Close()
        frmMainMenu.Close()
        frmHolidays.Close()
        frmRota.Close()
        frmEmployees.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        Me.Close()
    End Sub
End Class