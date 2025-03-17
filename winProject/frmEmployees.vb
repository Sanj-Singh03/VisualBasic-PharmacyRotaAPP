Imports System.Data.SQLite
Public Class frmEmployees
    Public pSQL As String = "SELECT eid AS 'Employees ID', efname AS 'First Name', elname AS 'Last Name', pnum AS 'Phone Number', egender as Gender, eaddress AS Address, epostcode AS Postcode, eskills AS Skills 
FROM employees;"

    'This button searches any employee that the user want to look up
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sSQL As String = funcsearch(txtSearchFname.Text, txtSearchLName.Text)

        dgvEmployees.DataSource = display(sSQL, "employees")
    End Sub

    'This button deletes any employees from the system
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dSQL As String = "DELETE FROM employees WHERE efname = '" & txtDeFName.Text & "' AND elname = '" & txtDeLName.Text & "';"
        delete(dSQL)
        dgvEmployees.DataSource = display(pSQL, "employees")
    End Sub

    'This button adds new employees by the user
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim aSQL As String = "INSERT INTO employees(efname,elname,pnum,egender,eaddress,epostcode,eskills) VALUES 
('" & txtAddFName.Text & "','" & txtAddLName.Text & "','" & txtAddPN.Text & "', '" & txtAddGender.Text & "', '" & txtAddAddress.Text & "','" & txtAddPostC.Text & "','" & txtAddSkills.Text & "');"
        add(aSQL)
        dgvEmployees.DataSource = display(pSQL, "employees")
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
        frmLogin.Close()
        frmMainMenu.Close()
        frmHolidays.Close()
        frmRota.Close()
        Me.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        frmStaffView.Close()
    End Sub

    'This piece of code loads in the employees table. Shows how many employees there are and their details
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployees.DataSource = display(pSQL, "employees")
    End Sub
End Class