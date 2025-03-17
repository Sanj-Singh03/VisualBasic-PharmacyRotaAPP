'Import Packets for SQLite

Imports System.Data.SQLite
Module functions

    Dim connectiontodatabase As String = ("Data Source=Pharmacy.db")
    Dim connection As New SQLiteConnection(connectiontodatabase)
    'This piece of code loads in the employees table. Shows how many employees there are and their details
    Function display(ByVal sqlcode As String, ByVal table As String)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim cmd As New SQLiteCommand(sqlcode, connection)
        Dim da As New SQLiteDataAdapter(cmd)
        connection.Open()
        da.Fill(ds, table)
        dt = ds.Tables(table)
        connection.Close()
        Return dt
    End Function
    'Function for SQL SELECT query
    Function funcsearch(ByVal fname As String, ByVal lname As String)
        Dim scode As String
        If lname = "" And fname = "" Then
            scode = "SELECT * FROM employees;"
        ElseIf lname <> "" And fname <> "" Then
            scode = "SELECT * FROM employees WHERE efname = '" & fname & "' OR elname ='" & lname & "';"
        ElseIf lname <> "" Then
            scode = "SELECT * FROM employees WHERE elname = '" & lname & "';"
        ElseIf fname <> "" Then
            scode = "SELECT * FROM employees WHERE efname = '" & fname & "';"
        End If

        Return scode

    End Function
    'Functions used in the main program 
    Sub add(ByVal sqlcode As String)
        Dim da As New SQLiteDataAdapter
        connection.Open()
        da.InsertCommand = New SQLiteCommand(sqlcode, connection)
        da.InsertCommand.ExecuteNonQuery()
        connection.Close()
    End Sub
    Sub delete(ByVal deletioncode As String)
        Dim deda As New SQLiteDataAdapter
        connection.Open()
        deda.InsertCommand = New SQLiteCommand(deletioncode, connection)
        deda.InsertCommand.ExecuteReader()
        connection.Close()
    End Sub

    Sub rota(ByVal rotadditioncode As String)
        Dim adda As New SQLiteDataAdapter
        connection.Open()
        adda.InsertCommand = New SQLiteCommand(rotadditioncode, connection)
        adda.InsertCommand.ExecuteReader()
        connection.Close()
    End Sub
    'Uses the catalogues in the combobox to return string values
    Function selday(ByRef d As String)
        Dim day As String
        If d = "1. Monday" Then
            day = "Monday"
        ElseIf d = "2. Tuesday" Then
            day = "Tuesday"
        ElseIf d = "3. Wednesday" Then
            day = "Wednesday"
        ElseIf d = "4. Thursday" Then
            day = "Thursday"
        ElseIf d = "5. Friday" Then
            day = "Friday"
        ElseIf d = "6. Saturday" Then
            day = "Saturday"
        ElseIf d = "7. Sunday" Then
            day = "Sunday"
        End If

        Return day
    End Function

    'Uses the catalogues in the comboboxes to return a primary key or a Boolean(false), used especially by startshift and endshift tables
    Function seltime(ByRef t As String)
        Dim int As Integer
        If t = "1. 00:00" Then
            int = 1
        ElseIf t = "2. 00:30" Then
            int = 2
        ElseIf t = "3. 01:00" Then
            int = 3
        ElseIf t = "4. 01:30" Then
            int = 4
        ElseIf t = "5. 02:00" Then
            int = 5
        ElseIf t = "6. 02:30" Then
            int = 6
        ElseIf t = "7. 03:00" Then
            int = 7
        ElseIf t = "8. 03:30" Then
            int = 8
        ElseIf t = "9. 04:00" Then
            int = 9
        ElseIf t = "10. 04:30" Then
            int = 10
        ElseIf t = "11. 05:00" Then
            int = 11
        ElseIf t = "12. 05:30" Then
            int = 12
        ElseIf t = "13. 06:00" Then
            int = 13
        ElseIf t = "14. 06:30" Then
            int = 14
        ElseIf t = "15. 07:00" Then
            int = 15
        ElseIf t = "16. 07:30" Then
            int = 16
        ElseIf t = "17. 08:00" Then
            int = 17
        ElseIf t = "18. 08:30" Then
            int = 18
        ElseIf t = "19. 09:00" Then
            int = 19
        ElseIf t = "20. 09:30" Then
            int = 20
        ElseIf t = "21. 10:00" Then
            int = 21
        ElseIf t = "22. 10:30" Then
            int = 22
        ElseIf t = "23. 11:00" Then
            int = 23
        ElseIf t = "24. 11:30" Then
            int = 24
        ElseIf t = "25. 12:00" Then
            int = 25
        ElseIf t = "26. 12:30" Then
            int = 26
        ElseIf t = "27. 13:00" Then
            int = 27
        ElseIf t = "28. 13:30" Then
            int = 28
        ElseIf t = "29. 14:00" Then
            int = 29
        ElseIf t = "30. 14:30" Then
            int = 30
        ElseIf t = "31. 15:00" Then
            int = 31
        ElseIf t = "32. 15:30" Then
            int = 32
        ElseIf t = "33. 16:00" Then
            int = 33
        ElseIf t = "34. 16:30" Then
            int = 34
        ElseIf t = "35. 17:00" Then
            int = 35
        ElseIf t = "36. 17:30" Then
            int = 36
        ElseIf t = "37. 18:00" Then
            int = 37
        ElseIf t = "38. 18:30" Then
            int = 38
        ElseIf t = "39. 19:00" Then
            int = 39
        ElseIf t = "40. 19:30" Then
            int = 40
        ElseIf t = "41. 20:00" Then
            int = 41
        ElseIf t = "42. 20:30" Then
            int = 42
        ElseIf t = "43. 21:00" Then
            int = 43
        ElseIf t = "44. 21:30" Then
            int = 44
        ElseIf t = "45. 22:00" Then
            int = 45
        ElseIf t = "46. 22:30" Then
            int = 46
        ElseIf t = "47. 23:00" Then
            int = 47
        ElseIf t = "48. 23:30" Then
            int = 48
        End If
        Return int
    End Function

    Function selstore(ByRef s As String)
        Dim b As Integer
        If s = "1. Hounslow" Then
            b = 1
        ElseIf s = "2. Twickenham" Then
            b = 2
        ElseIf s = "3. Southall" Then
            b = 3
        Else
            s = "Please select a Store."
        End If
        Return b
    End Function

End Module
