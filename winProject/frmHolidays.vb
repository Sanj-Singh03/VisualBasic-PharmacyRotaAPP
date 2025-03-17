Imports System.Data.SQLite

Public Class frmHolidays
    Public holiSQL As String = "SELECT e.efname AS 'First Name', e.elname AS 'Last Name', e.eskills AS 'Skills', h.holidayn AS 'Holidays Remaining', h.hreason AS 'Reason' , e.pnum AS 'Phone Number' FROM holidays AS h, employees AS e 
WHERE e.eid=h.holiemp
ORDER BY h.holidayn ASC;"
    Private Sub btnHoliMakeBooking_Click(sender As Object, e As EventArgs)
        Dim n As Integer = Convert.ToInt32(txtHoliDaysBook.Text)
        Dim id As Integer = Convert.ToInt32(txtHoliEid.Text)

        Dim holiaddSQL As String = "UPDATE holidays 
SET holidayn = holidayn - " & n & "
WHERE holiemp = " & id & " ;"

        add(holiaddSQL)
        dgvHolidays.DataSource = display(holiSQL, "holidays")
    End Sub

    'Gives employees extra holidays if user wants to
    Private Sub btnHoliGive_Click(sender As Object, e As EventArgs) Handles btnHoliGive.Click
        Dim giveholidays As New frmGivHolidays
        giveholidays.Show()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim mainmenu As New frmMainMenu
        mainmenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As New frmLogin
        login.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Close()
        frmMainMenu.Close()
        frmRota.Close()
        frmEmployees.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        frmStaffView.Close()
    End Sub

    Private Sub frmHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvHolidays.DataSource = display(holiSQL, "holidays")
    End Sub


End Class