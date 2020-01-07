Public Class addcust
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub addcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox27.Text = ""
        cmd.CommandText = "select MAX(custid)from cust1"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        If (rs.HasRows = True) Then
            rs.Read()
            TextBox27.Text = rs(0) + 1
            TextBox1.Focus()
        End If
        rs.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim str1 As String
        If (TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Or TextBox16.Text = "" Or TextBox21.Text = "" Or TextBox22.Text = "" Or TextBox26.Text = "" Or TextBox27.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "") Then
            MsgBox("Empty Field is not Allowed.", MsgBoxStyle.Information, "Empty Field")
            TextBox1.Focus()
            Button1.Enabled = True
            Exit Sub
        End If
        If IsNumeric(TextBox27.Text) = False Then
            MsgBox("Enter numeric Customer Id number.( Space is not allowed.)", MsgBoxStyle.Exclamation, "Not Numeric -Error")
            TextBox27.Text = "" : TextBox27.Focus()
            Exit Sub
        End If
        cmd.CommandText = "select * from cust1 where custid='" & TextBox1.Text & "'"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        rs.Read()
        If (rs.HasRows = True) Then
            MsgBox("Allredy exist.", MsgBoxStyle.Exclamation, "Duplicate Not Allowed.")
            TextBox27.Text = "" : TextBox1.Text = "" : str1 = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : TextBox13.Text = "" : TextBox14.Text = "" : TextBox15.Text = "" : TextBox16.Text = "" : TextBox21.Text = "" : TextBox22.Text = "" : TextBox26.Text = "" : TextBox28.Text = "" : TextBox29.Text = "" : ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = "" : ComboBox4.Text = "" : ComboBox5.Text = "" : ComboBox6.Text = ""
            TextBox1.Focus()
            Button1.Enabled = True
            rs.Close()
            Exit Sub
        End If
        rs.Close()
        If (RadioButton1.Checked = True) Then
            str1 = "Father name"
        Else
            str1 = "Husband name"
        End If
        cmd = New SqlClient.SqlCommand("insert into cust1 values('" & TextBox27.Text & "','" & TextBox1.Text & " ','" & str1 & "','" & TextBox4.Text & "'," & ComboBox1.SelectedItem & ",'" & ComboBox2.SelectedItem & "'," & ComboBox3.SelectedItem & ",'" & ComboBox4.SelectedItem & "','" & TextBox5.Text & "','" & ComboBox6.SelectedItem & "','" & TextBox6.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.SelectedItem & "','" & TextBox26.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox28.Text & "','" & TextBox29.Text & "')", vcon)
        cmd.ExecuteNonQuery()
        MsgBox("Added Data.", MsgBoxStyle.MsgBoxRtlReading, "Added Sucessfully")
        adminreport.Label1.Text = adminreport.Label1.Text + 1
        cmd.Dispose()
        Me.Close()
        '  TextBox27.Text = "" : TextBox1.Text = "" : str1 = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : TextBox13.Text = "" : TextBox14.Text = "" : TextBox15.Text = "" : TextBox16.Text = "" : TextBox21.Text = "" : TextBox22.Text = "" : TextBox26.Text = "" : TextBox28.Text = "" : TextBox29.Text = "" : ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = "" : ComboBox4.Text = "" : ComboBox5.Text = "" : ComboBox6.Text = ""
        ' Button1.Enabled = True
        'TextBox27.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox2.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (ComboBox1.SelectedIndex >= 29) Then
            If (ComboBox2.SelectedIndex = 1) Then
                errorform.Label1.Text = "Date " & ComboBox1.SelectedItem & " is not valid for February."
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus()
                Exit Sub
            End If
        End If
        If (ComboBox1.SelectedIndex = 30) Then
            If (ComboBox2.SelectedIndex = 3 Or ComboBox2.SelectedIndex = 5 Or ComboBox2.SelectedIndex = 8 Or ComboBox2.SelectedIndex = 10) Then
                errorform.Label1.Text = "Date " & ComboBox1.SelectedItem & " is not valid for " & ComboBox2.SelectedItem
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus() : Exit Sub
            Else
                Exit Sub
            End If
        End If
        Dim cleap As Integer
        cleap = CInt(ComboBox3.SelectedItem)
        If (ComboBox1.SelectedIndex = 28 And ComboBox2.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox3.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change date."
                ComboBox1.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus()

            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (ComboBox2.SelectedIndex = 1) Then
            If (ComboBox1.SelectedIndex >= 29) Then
                errorform.Label1.Text = "Date " & ComboBox1.SelectedItem & " is not valid for February."
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus()
                Exit Sub
            End If
        End If
        If (ComboBox1.SelectedIndex = 30) Then
            If (ComboBox2.SelectedIndex = 3 Or ComboBox2.SelectedIndex = 5 Or ComboBox2.SelectedIndex = 8 Or ComboBox2.SelectedIndex = 10) Then
                errorform.Label1.Text = "Date " & ComboBox1.SelectedItem & " is not valid for " & ComboBox2.SelectedItem
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus() : Exit Sub
            Else
                Exit Sub
            End If
        End If
        Dim cleap As Integer
        cleap = CInt(ComboBox3.SelectedItem)
        If (ComboBox1.SelectedIndex = 28 And ComboBox2.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox3.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change Feburary date."
                ComboBox1.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus()

            End If
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim cleap As Integer
        cleap = CInt(ComboBox3.SelectedItem)
        If (ComboBox1.SelectedIndex = 28 And ComboBox2.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox3.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change Feburary date."
                ComboBox1.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox1.Focus()

            End If
        End If
    End Sub


    Private Sub TextBox27_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox27.Validated
        If (TextBox27.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox27, "Blank is not Allowed.")
            TextBox27.Focus()
        End If
        If (TextBox27.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        If (TextBox1.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox1, "Blank is not Allowed.")
            TextBox1.Focus()
        End If
        If (TextBox1.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Validated
        If (TextBox4.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox4, "Blank is not Allowed.")
            TextBox4.Focus()
        End If
        If (TextBox4.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox5_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Validated
        If (TextBox5.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox5, "Blank is not Allowed.")
            TextBox5.Focus()
        End If
        If (TextBox5.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox6_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.Validated
        If (TextBox6.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox6, "Blank is not Allowed.")
            TextBox6.Focus()
        End If
        If (TextBox6.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox11_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.Validated
        If (TextBox11.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox11, "Blank is not Allowed.")
            TextBox11.Focus()
        End If
        If (TextBox11.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox12_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.Validated
        If (TextBox12.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox12, "Blank is not Allowed.")
            TextBox12.Focus()
        End If
        If (TextBox12.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox13_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.Validated
        If (TextBox13.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox13, "Blank is not Allowed.")
            TextBox13.Focus()
        End If
        If (TextBox13.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox14_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.Validated
        If (TextBox14.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox14, "Blank is not Allowed.")
            TextBox14.Focus()
        End If
        If (TextBox14.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox26_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox26.Validated
        If (TextBox26.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox26, "Blank is not Allowed.")
            TextBox26.Focus()
        End If
        If (TextBox26.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox15_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.Validated
        If (TextBox15.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox15, "Blank is not Allowed.")
            TextBox15.Focus()
        End If
        If (TextBox15.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox16_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.Validated
        If (TextBox16.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox16, "Blank is not Allowed.")
            TextBox16.Focus()
        End If
        If (TextBox16.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub


    Private Sub TextBox21_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox21.Validated
        If (TextBox21.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox21, "Blank is not Allowed.")
            TextBox21.Focus()
        End If
        If (TextBox21.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.TextChanged
        If (TextBox22.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox22, "Blank is not Allowed.")
            TextBox22.Focus()
        End If
        If (TextBox22.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub



    Private Sub TextBox28_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox28.Validated
        If (TextBox28.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox28, "Blank is not Allowed.")
            TextBox28.Focus()
        End If
        If (TextBox28.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub TextBox29_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox29.Validated
        If (TextBox29.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox29, "Blank is not Allowed.")
            TextBox29.Focus()
        End If
        If (TextBox29.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub ComboBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Validated
        If (ComboBox1.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox1, "Blank is not Allowed.")
            ComboBox1.Focus()
        End If
        If (ComboBox1.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub ComboBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Validated
        If (ComboBox2.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox2, "Blank is not Allowed.")
            ComboBox2.Focus()
        End If
        If (ComboBox2.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub ComboBox3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.Validated
        If (ComboBox3.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox3, "Blank is not Allowed.")
            ComboBox3.Focus()
        End If
        If (ComboBox3.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub ComboBox4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.Validated
        If (ComboBox4.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox4, "Blank is not Allowed.")
            ComboBox4.Focus()
        End If
        If (ComboBox4.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub ComboBox6_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.Validated
        If (ComboBox6.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox6, "Blank is not Allowed.")
            ComboBox6.Focus()
        End If
        If (ComboBox6.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub ComboBox5_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.Validated
        If (ComboBox5.Text = "") Then
            Me.ErrorProvider1.SetError(ComboBox5, "Blank is not Allowed.")
            ComboBox5.Focus()
        End If
        If (ComboBox5.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub RadioButton1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Validated
        If (RadioButton1.Checked = True) Then
            TextBox4.Focus()
        Else
            RadioButton2.Focus()
        End If
    End Sub
    Private Sub RadioButton2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Validated
        If (RadioButton1.Checked = True) Then
            TextBox4.Focus()
        Else
            If (RadioButton2.Checked = True) Then
                TextBox4.Focus()
            Else
                RadioButton1.Focus()
            End If
        End If
    End Sub
End Class