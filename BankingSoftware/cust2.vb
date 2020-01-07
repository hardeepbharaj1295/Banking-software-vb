Public Class cust2
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Public Sub go()
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
            TextBox20.Text = rs(21)
            TextBox21.Text = rs(15)
            TextBox22.Text = rs(17)
            TextBox23.Text = rs(18)
            TextBox28.Text = rs(19)
            TextBox29.Text = rs(20)
            TextBox33.Text = rs(14)
            TextBox34.Text = rs(16)
            TextBox35.Text = rs(22)
            rs.Close()
        End If
    End Sub

    Private Sub delcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        Call go()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("Select One From Box.", MsgBoxStyle.Information, "Empty Search")
            ComboBox1.Focus()
            Exit Sub
        End If
        cmd = New SqlClient.SqlCommand("delete from cust1 where custid=" & ComboBox1.SelectedItem & "", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New SqlClient.SqlCommand("delete from atm1 where custid=" & ComboBox1.SelectedItem & "", vcon)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("The data is deleted sucessfully", MsgBoxStyle.Information, "Delete Data")
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : TextBox13.Text = "" : TextBox18.Text = "" : TextBox19.Text = "" : TextBox20.Text = "" : TextBox21.Text = "" : TextBox22.Text = "" : TextBox23.Text = "" : TextBox28.Text = "" : TextBox29.Text = "" : TextBox33.Text = "" : TextBox34.Text = "" : TextBox35.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox14.Text = ""
        Call go()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class