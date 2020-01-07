Public Class Updatestaff
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Public Sub use()
        cmd.CommandText = "select empid from emp"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        ComboBox5.Items.Clear()
        If (rs.HasRows = False) Then
            Label18.Text = " Empty Database."
            Button1.Enabled = False
        Else
            While (rs.Read <= rs.HasRows)
                ComboBox5.Items.Add(rs(0))
            End While
            rs.Close()
        End If
        ComboBox5.Focus()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
    If (ComboBox5.SelectedIndex < 0) Then
            MsgBox(" Select Number.")
            Exit Sub
        Else
            cmd.CommandText = "select * from emp where empid=" & ComboBox5.SelectedItem & ""
            cmd.Connection = vcon
            rs = cmd.ExecuteReader
            rs.Read()
            TextBox1.Text = rs(0)
            TextBox2.Text = rs(1)
            TextBox3.Text = rs(2)
            TextBox4.Text = rs(3)
            TextBox5.Text = rs(4)
            TextBox6.Text = rs(5)
            TextBox7.Text = rs(6)
            TextBox8.Text = rs(7)
            TextBox9.Text = rs(8)
            TextBox10.Text = rs(9)
            TextBox11.Text = rs(10)
            TextBox12.Text = rs(11)
            TextBox13.Text = rs(12)
            TextBox14.Text = rs(13)
            TextBox15.Text = rs(14)
            TextBox16.Text = rs(15)

        End If
        rs.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ComboBox5.SelectedIndex = -1) Then
            MsgBox("Select One From Box.", MsgBoxStyle.Information, "Empty Search")
            ComboBox5.Focus()
            Exit Sub
        End If
        cmd = New SqlClient.SqlCommand("update emp set  eaddress='" & TextBox3.Text & "',ecity='" & TextBox4.Text & "',epincode='" & TextBox6.Text & "', ejob='" & TextBox11.Text & "',esalary='" & TextBox13.Text & "',ecomm='" & TextBox14.Text & "' ,eusername='" & TextBox15.Text & "',epassword='" & TextBox16.Text & "' where empid='" & TextBox1.Text & "'", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
       
        MsgBox("the data is updated", MsgBoxStyle.MsgBoxRtlReading)
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : TextBox13.Text = "" : TextBox14.Text = ""
        Call use()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub updatecust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        Call use()
        ComboBox5.Focus()
    End Sub

    
   
End Class