Public Class atmform
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ATMform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If (TextBox1.Text = "") Then
            MsgBox("Empty Field is not Allowed. Enter ID First", MsgBoxStyle.Information, "Empty Field")
            TextBox1.Focus()
            Button1.Enabled = True
            Exit Sub
        End If
        cmd = New SqlClient.SqlCommand("insert into atm1 values('" & TextBox1.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & TextBox10.Text & "')", vcon)
        cmd.ExecuteNonQuery() : cmd.Dispose()
        MsgBox("Added Data.", MsgBoxStyle.MsgBoxRtlReading, "Added Sucessfully")
        adminreport.Label1.Text = adminreport.Label1.Text + 1
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = "" : ComboBox1.Text = "" : ComboBox2.Text = ""
        Button1.Enabled = True
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Then
            MsgBox("Empty Field is not Allowed. Enter ID First", MsgBoxStyle.Information, "Empty Field")
            TextBox1.Focus()
            Button1.Enabled = True
            Exit Sub
        End If
        cmd.CommandText = "select cname,ddate,month,year,address,ocupation,accountno,accounttype,username,password from cust1 where custid='" & TextBox1.Text & "'"
        cmd.Connection = vcon : rs = cmd.ExecuteReader : rs.Read()
        If (rs.HasRows = True) Then
            TextBox2.Text = rs(0)
            TextBox3.Text = rs(1)
            TextBox4.Text = rs(2)
            TextBox5.Text = rs(3)
            TextBox6.Text = rs(4)
            TextBox7.Text = rs(5)
            TextBox8.Text = rs(6)
            TextBox9.Text = rs(7)
            TextBox11.Text = rs(8)
            TextBox12.Text = rs(9)
        End If
        rs.Close()
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

    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
        If (TextBox2.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox2, "Blank is not Allowed.")
            TextBox2.Focus()
        End If
        If (TextBox2.Text <> "") Then
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

    Private Sub TextBox3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Validated
        If (TextBox3.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox3, "Blank is not Allowed.")
            TextBox3.Focus()
        End If
        If (TextBox3.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub


    Private Sub TextBox7_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.Validated
        If (TextBox7.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox7, "Blank is not Allowed.")
            TextBox7.Focus()
        End If
        If (TextBox7.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox8_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Validated
        If (TextBox8.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox8, "Blank is not Allowed.")
            TextBox8.Focus()
        End If
        If (TextBox8.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox9_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.Validated
        If (TextBox9.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox9, "Blank is not Allowed.")
            TextBox9.Focus()
        End If
        If (TextBox9.Text <> "") Then
            Me.ErrorProvider1.Dispose()
        End If
    End Sub
    Private Sub TextBox10_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.Validated
        If (TextBox10.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox10, "Blank is not Allowed.")
            TextBox10.Focus()
        End If
        If (TextBox10.Text <> "") Then
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

    ' Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   If (ComboBox4.SelectedIndex = -1) Then
    '       Exit Sub
    '  End If
    '   If (ComboBox3.SelectedIndex >= 29) Then
    '    If (ComboBox4.SelectedIndex = 1) Then
    '       errorform.Label1.Text = "Date " & ComboBox3.SelectedItem & " is not valid for February."
    '      ComboBox3.SelectedIndex = -1
    '      ComboBox4.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    '      errorform.ShowDialog() : ComboBox3.Focus()
    '    Exit Sub
    ' End If
    '  End If
    ' If (ComboBox3.SelectedIndex = 30) Then
    ' If (ComboBox4.SelectedIndex = 3 Or ComboBox4.SelectedIndex = 5 Or ComboBox4.SelectedIndex = 8 Or ComboBox4.SelectedIndex = 10) Then
    '     errorform.Label1.Text = "Date " & ComboBox3.SelectedItem & " is not valid for " & ComboBox4.SelectedItem
    'ComboBox3.SelectedIndex = -1
    '    ComboBox4.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    '    errorform.ShowDialog() : ComboBox3.Focus() : Exit Sub
    ' Else
    '     Exit Sub
    '  End If
    '   End If
    '  Dim cleap As Integer
    '   cleap = CInt(ComboBox5.SelectedItem)
    '   If (ComboBox3.SelectedIndex = 28 And ComboBox4.SelectedIndex = 1) Then
    ' If (cleap Mod 2 = 0) Then
    '       Exit Sub
    '  Else
    '    errorform.Label1.Text = "Year " & ComboBox5.SelectedItem & " is not Leap Year."
    '     errorform.Label2.Text = "Change date."
    '   ComboBox3.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    '    errorform.ShowDialog() : ComboBox3.Focus()

    ' End If
    '  End If
    'End Sub

    ' Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '  If (ComboBox3.SelectedIndex = -1) Then
    '       Exit Sub
    '  End If
    '    If (ComboBox4.SelectedIndex = 1) Then
    '    If (ComboBox3.SelectedIndex >= 29) Then
    '  errorform.Label1.Text = "Date " & ComboBox3.SelectedItem & " is not valid for February."
    '  ComboBox3.SelectedIndex = -1
    '  ComboBox4.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    ' errorform.ShowDialog() : ComboBox3.Focus()
    '  Exit Sub
    'End If
    '  End If
    ' If (ComboBox3.SelectedIndex = 30) Then
    'If (ComboBox4.SelectedIndex = 3 Or ComboBox4.SelectedIndex = 5 Or ComboBox4.SelectedIndex = 8 Or ComboBox4.SelectedIndex = 10) Then
    ' errorform.Label1.Text = "Date " & ComboBox3.SelectedItem & " is not valid for " & ComboBox4.SelectedItem
    '    ComboBox3.SelectedIndex = -1
    '   ComboBox4.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    '  errorform.ShowDialog() : ComboBox3.Focus() : Exit Sub
    'Else
    '   Exit Sub
    'End If
    ' End If
    '   Dim cleap As Integer
    ' cleap = CInt(ComboBox5.SelectedItem)
    ' If (ComboBox3.SelectedIndex = 28 And ComboBox4.SelectedIndex = 1) Then
    'If (cleap Mod 2 = 0) Then
    '   Exit Sub
    'Else
    '   errorform.Label1.Text = "Year " & ComboBox5.SelectedItem & " is not Leap Year."
    ' errorform.Label2.Text = "Change Feburary date."
    ' ComboBox3.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    ' errorform.ShowDialog() : ComboBox3.Focus()

    ' End If
    'End If
    'End Sub

    '  Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim cleap As Integer
    '   cleap = CInt(ComboBox5.SelectedItem)
    ' If (ComboBox3.SelectedIndex = 28 And ComboBox4.SelectedIndex = 1) Then
    '      If (cleap Mod 2 = 0) Then
    '      Exit Sub
    ''  Else
    '  errorform.Label1.Text = "Year " & ComboBox5.SelectedItem & " is not Leap Year."
    '  errorform.Label2.Text = "Change Feburary date."
    '   ComboBox1.SelectedIndex = -1 : ComboBox5.SelectedIndex = -1
    '    errorform.ShowDialog() : ComboBox1.Focus()

    ' End If
    '     ' End If
    ' End Sub

End Class