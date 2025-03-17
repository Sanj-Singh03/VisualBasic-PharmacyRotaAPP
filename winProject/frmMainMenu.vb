Public Class frmMainMenu

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        frmEmployees.Show()
        Me.Hide()
    End Sub

    Private Sub btnHolidays_Click(sender As Object, e As EventArgs) Handles btnHolidays.Click
        frmHolidays.Show()
        Me.Hide()
    End Sub

    Private Sub btnRota_Click(sender As Object, e As EventArgs) Handles btnRota.Click
        frmRota.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Close()
        frmHolidays.Close()
        frmRota.Close()
        frmEmployees.Close()
        frmHolyBooking.Close()
        frmGivHolidays.Close()
        frmStaffView.Close()
    End Sub

    Private Sub btnReturnToLogin_Click(sender As Object, e As EventArgs) Handles btnReturnToLogin.Click
        frmLogin.Show()
        Me.Hide()

    End Sub
End Class