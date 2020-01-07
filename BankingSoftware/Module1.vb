Imports System.Data.SqlClient
Module Module1
    Public vcon As SqlConnection
    Public Sub apply()
        vcon = New SqlConnection("Data Source=ADITYA-PC\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True")
        vcon.Open()
    End Sub
End Module