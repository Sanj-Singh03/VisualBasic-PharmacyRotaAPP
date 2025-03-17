Imports System.Data.SQLite

Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'creating objects for the login
        'creating objects for the connection to the database
        Dim sqlconnection As New SQLiteConnection()
        Dim connectiontodatabase As String = ("Data Source=Pharmacy.db")
        Dim connection As New SQLiteConnection(connectiontodatabase)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim sqlcode As String = "SELECT * FROM login;"
        Dim cmd As New SQLiteCommand(sqlcode, connection)
        Dim da As New SQLiteDataAdapter
        Dim scb As New SQLiteCommandBuilder(da)
        Dim checker As Boolean
        Dim username As String = txtLogUsername.Text
        Dim password As String = txtLogPassword.Text
        'I need to open the connection to edit the dataset, which can be done by using datatable.Fill() command
        connection.Open()
        da = New SQLiteDataAdapter(sqlcode, connection)
        da.Fill(ds, "login")
        connection.Close()

        If txtLogUsername.Text = ds.Tables("login").Rows(0).Item(0) And txtLogPassword.Text = ds.Tables("login").Rows(0).Item(1) Then
            checker = True
        Else
            checker = False
        End If

        If checker = True Then
            frmMainMenu.Show()
            Me.Hide()
        ElseIf username = "" Or password = "" Then
            lblLogin.ForeColor = Color.Red
            lblLogin.Text = "Please enter Username or Password."
        ElseIf checker = False Then
            lblLogin.ForeColor = Color.Red
            lblLogin.Text = "Username or Password is wrong."
        End If
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmStaffView.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMainMenu.Close()
        frmHolidays.Close()
        frmRota.Close()
        frmEmployees.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        frmStaffView.Close()
        Me.Close()
    End Sub
End Class