Public Class Findstaff
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader

    Private Sub Findstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        cmd.CommandText = "select empid from emp"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        If (rs.HasRows = False) Then
            Label18.Text = "Empty Database."
            rs.Close()
        Else
            While (rs.Read <= rs.HasRows)
                ComboBox5.Items.Add(rs(0))
            End While
            rs.Close()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If (ComboBox5.SelectedIndex < 0) Then
            MsgBox(" Select Number.", MsgBoxStyle.Information, "Select Box")
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
            rs.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class