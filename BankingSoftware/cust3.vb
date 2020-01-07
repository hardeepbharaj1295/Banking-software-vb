Public Class cust3
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Private Sub custFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        cmd.CommandText = "select custid from cust1"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        If (rs.HasRows = False) Then
            Label23.Text = "Empty Database."
        Else
            While (rs.Read <= rs.HasRows)
                ComboBox1.Items.Add(rs(0))
            End While
            rs.Close()
        End If
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
            If (rs(2) = "father") Then
                Label7.Text = "Father's name:"
            End If
            If (rs(2) = "mother") Then
                Label7.Text = "Mother's name:"
            End If
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
            TextBox33.Text = rs(14)
            TextBox21.Text = rs(15)
            TextBox34.Text = rs(16)
            TextBox22.Text = rs(17)
            TextBox23.Text = rs(18)
            TextBox28.Text = rs(19)
            TextBox29.Text = rs(20)
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class