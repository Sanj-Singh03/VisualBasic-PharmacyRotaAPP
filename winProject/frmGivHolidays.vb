Public Class frmGivHolidays
    Private Sub btnGH_Click(sender As Object, e As EventArgs) Handles btnGH.Click
        Dim n As Integer = Convert.ToInt32(txtID.Text)
        Dim id As Integer = Convert.ToInt32(txtHTG.Text)

        Dim holiaddSQL As String = "UPDATE holidays
SET holidayn = holidayn + " & n & "
WHERE holiemp = " & id & " ;"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class