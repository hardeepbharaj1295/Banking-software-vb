Public Class updatecust
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader

    Public Sub use()
        cmd.CommandText = "select custid from cust1"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        If (rs.HasRows = False) Then
            Label23.Text = " Empty Database."
            Button1.Enabled = False
        Else
            While (rs.Read <= rs.HasRows)
                ComboBox1.Items.Add(rs(0))
            End While
            rs.Close()
        End If
        ComboBox1.Focus()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex < 0) Then
            MsgBox(" Select  Account Number.")
            Exit Sub
        Else
            cmd.CommandText = "select * from cust1 where custid=" & ComboBox1.SelectedItem & ""
            cmd.Connection = vcon
            rs = cmd.ExecuteReader
            rs.Read()
            TextBox1.Text = rs(0)
            TextBox2.Text = rs(1)
            Label7.Text = rs(2)
            TextBox5.Text = rs(3)
            TextBox6.Text = rs(4)
            TextBox7.Text = rs(5)
            TextBox8.Text = rs(6)
            TextBox9.Text = rs(7)
            TextBox11.Text = rs(8)
            TextBox12.Text = rs(9)
            TextBox13.Text = rs(10)
            TextBox18.Text = rs(11)
            TextBox10.Text = rs(12)
            TextBox19.Text = rs(13)
            TextBox21.Text = rs(15)
            TextBox22.Text = rs(17)
            TextBox23.Text = rs(18)
            TextBox28.Text = rs(19)
            TextBox29.Text = rs(20)
            TextBox33.Text = rs(14)
            TextBox34.Text = rs(16)
            TextBox20.Text = rs(21)
            TextBox35.Text = rs(22)
            rs.Close()
            cmd.CommandText = "select * from atm1 where custid=" & ComboBox1.SelectedItem & ""
            cmd.Connection = vcon
            rs = cmd.ExecuteReader
            rs.Read()
            If (rs.HasRows = True) Then
                TextBox3.Text = rs(1)
                TextBox4.Text = rs(2)
                TextBox14.Text = rs(3)
            Else
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox14.Text = ""
            End If
            rs.Close()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("Select One From Box.", MsgBoxStyle.Information, "Empty Search")
            ComboBox1.Focus()
            Exit Sub
        End If
        cmd = New SqlClient.SqlCommand("update cust1 set maritialstatus='" & TextBox10.Text & "',address='" & TextBox13.Text & "', occupation='" & TextBox19.Text & "',nname='" & TextBox22.Text & "',naddress='" & TextBox23.Text & "',username='" & TextBox20.Text & "',password='" & TextBox35.Text & "' where custid='" & TextBox1.Text & "'", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("the data is updated", MsgBoxStyle.Information, "Updated Sucessfully")
        adminreport.Label2.Text = adminreport.Label2.Text + 1
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : TextBox13.Text = "" : TextBox18.Text = "" : TextBox19.Text = "" : TextBox20.Text = "" : TextBox21.Text = "" : TextBox22.Text = "" : TextBox23.Text = "" : TextBox28.Text = "" : TextBox29.Text = "" : TextBox39.Text = "" : TextBox34.Text = "" : TextBox35.Text = ""
        Call use()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub updatecust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        Call use()
        ComboBox1.Focus()
    End Sub

End Class