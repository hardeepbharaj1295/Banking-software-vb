Public Class addingform
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Dim acont, number1 As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub addingform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox1.Focus() : Label9.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("Enter Account Number.", MsgBoxStyle.Critical, "Empty Field")
            TextBox1.Focus()
            Exit Sub
        End If
        cmd.CommandText = "select custid,cname,crelation,relativename,address,accountamount from cust1 where accountno='" & TextBox1.Text & "'"
        cmd.Connection = vcon : rs = cmd.ExecuteReader : rs.Read()
        If (rs.HasRows = True) Then
            Label9.Text = ""
            TextBox3.Text = rs(0)
            TextBox4.Text = rs(1)
            Label6.Text = rs(2)
            TextBox5.Text = rs(3)
            TextBox6.Text = rs(4)
            TextBox1.Focus()
            acont = rs(5)
        Else
            MsgBox("Wrong Account Number", MsgBoxStyle.Exclamation, "Warning")
            TextBox1.Text = ""
            TextBox1.Focus()   
        End If
        rs.Close()
        cmd.CommandText = "select MAX(num) from trans"
        cmd.Connection = vcon : rs = cmd.ExecuteReader : rs.Read() : number1 = rs(0)
        TextBox8.Text = number1 : rs.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (TextBox2.Text = "" And TextBox2.Text = "") Then
            MsgBox("Enter Information First.", MsgBoxStyle.Critical, "Empty Fields.")
            TextBox1.Focus() : Exit Sub
        End If
        If (TextBox1.Text = "") Then
            MsgBox("Enter Account Number.", MsgBoxStyle.Critical, "Empty Field")
            TextBox1.Focus() : Exit Sub
        End If
        If (TextBox2.Text = "") Then
            MsgBox("Enter Amount.", MsgBoxStyle.Critical, "Empty Field")
            TextBox2.Focus() : Exit Sub
        End If
        Button3.Enabled = False
        acont = acont + TextBox2.Text
        cmd = New SqlClient.SqlCommand("update cust1 set  accountamount='" & acont & "' where accountno='" & TextBox1.Text & "'", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        number1 = number1 + 1
        TextBox8.Text = Format(Now, "dddd, MMMM d,yyy hh:mm:ss tt")
        cmd = New SqlClient.SqlCommand("insert into trans values(" & number1 & ",'Adding Money','" & TextBox8.Text & "','Personal','" & TextBox1.Text & "','" & TextBox2.Text & "')", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("Amount is successfully Added", MsgBoxStyle.Information, "Information")
        Me.Dispose()
    End Sub
End Class