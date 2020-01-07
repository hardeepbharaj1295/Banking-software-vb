Public Class ShowBalance
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub ShowBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("Enter Account Number.", MsgBoxStyle.Critical, "Empty Field")
            TextBox1.Focus() : 
            TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = ""
            Exit Sub

        End If
        cmd.CommandText = "select accountamount,cname,crelation,relativename,address from cust1 where accountno='" & TextBox1.Text & "'"
        cmd.Connection = vcon : rs = cmd.ExecuteReader : rs.Read()
        If (rs.HasRows = True) Then
            TextBox2.Text = rs(0)
            TextBox3.Text = rs(1)
            Label4.Text = rs(2)
            TextBox4.Text = rs(3)
            TextBox5.Text = rs(4)

            TextBox1.Focus()

        Else
            MsgBox("Wrong Account Number", MsgBoxStyle.Exclamation, "Warning")
            TextBox1.Text = ""
            TextBox1.Focus()

            TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = ""
        End If
        rs.Close()


    End Sub

End Class