Public Class Addstaff
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Addstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox1.Text = ""
        cmd.CommandText = "select MAX(empid)from emp"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        If (rs.HasRows = True) Then
            rs.Read()
            TextBox1.Text = rs(0) + 1
            TextBox2.Focus()
        End If
        rs.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "") Then
            MsgBox("Empty Field is not Allowed.", MsgBoxStyle.Information, "Empty Field")
            TextBox1.Focus()
            Button1.Enabled = True
            Exit Sub
        End If
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("Enter numeric Employee Id number.( Space is not allowed.)", MsgBoxStyle.Exclamation, "Not Numeric -Error")
            TextBox1.Text = "" : TextBox1.Focus()
            Exit Sub
        End If
        If IsNumeric(TextBox6.Text) = False Then
            MsgBox("Pin code must be Numeric.", MsgBoxStyle.Exclamation, "Not Numeric -Error")
            TextBox6.Text = "" : TextBox6.Focus()
            Exit Sub
        End If
        cmd.CommandText = "select * from emp where empid='" & TextBox1.Text & "'"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        rs.Read()
        If (rs.HasRows = True) Then
            MsgBox("Allredy exist.", MsgBoxStyle.Exclamation, "Duplicate Not Allowed.")
            TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = "" : ComboBox4.Text = "" : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = ""

            TextBox1.Focus()
            Button1.Enabled = True
            rs.Close()
            Exit Sub
        End If
        rs.Close()
        cmd = New SqlClient.SqlCommand("insert into emp values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & ComboBox3.SelectedItem & "','" & ComboBox4.SelectedItem & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "')", vcon)
        cmd.ExecuteNonQuery() : cmd.Dispose()
        MsgBox("Added Data.", MsgBoxStyle.MsgBoxRtlReading, "Added Successfully")
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = "" : TextBox6.Text = "" : ComboBox1.SelectedIndex = -1 : ComboBox2.SelectedIndex = -1 : ComboBox3.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1 : TextBox7.Text = "" : TextBox8.Text = "" : TextBox9.Text = "" : TextBox10.Text = "" : TextBox11.Text = "" : TextBox12.Text = ""
        Button1.Enabled = True 'Me.Dispose()
        TextBox1.Focus()
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
    Private Sub TextBox3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Validated
        If (TextBox3.Text = "") Then
            Me.ErrorProvider1.SetError(TextBox3, "Blank is not Allowed.")
            TextBox3.Focus()
        End If
        If (TextBox3.Text <> "") Then
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (ComboBox3.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (ComboBox2.SelectedIndex >= 29) Then
            If (ComboBox3.SelectedIndex = 1) Then
                errorform.Label1.Text = "Date " & ComboBox2.SelectedItem & " is not valid for February."
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus()
                Exit Sub
            End If
        End If
        If (ComboBox2.SelectedIndex = 30) Then
            If (ComboBox3.SelectedIndex = 3 Or ComboBox3.SelectedIndex = 5 Or ComboBox3.SelectedIndex = 8 Or ComboBox3.SelectedIndex = 10) Then
                errorform.Label1.Text = "Date " & ComboBox2.SelectedItem & " is not valid for " & ComboBox3.SelectedItem
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus() : Exit Sub
            Else
                Exit Sub
            End If
        End If
        Dim cleap As Integer
        cleap = CInt(ComboBox4.SelectedItem)
        If (ComboBox2.SelectedIndex = 28 And ComboBox3.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox4.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change date."
                ComboBox2.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus()

            End If
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If (ComboBox2.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (ComboBox3.SelectedIndex = 1) Then
            If (ComboBox2.SelectedIndex >= 29) Then
                errorform.Label1.Text = "Date " & ComboBox2.SelectedItem & " is not valid for February."
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus()
                Exit Sub
            End If
        End If
        If (ComboBox2.SelectedIndex = 30) Then
            If (ComboBox3.SelectedIndex = 3 Or ComboBox3.SelectedIndex = 5 Or ComboBox3.SelectedIndex = 8 Or ComboBox3.SelectedIndex = 10) Then
                errorform.Label1.Text = "Date " & ComboBox2.SelectedItem & " is not valid for " & ComboBox3.SelectedItem
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus() : Exit Sub
            Else
                Exit Sub
            End If
        End If
        Dim cleap As Integer
        cleap = CInt(ComboBox4.SelectedItem)
        If (ComboBox2.SelectedIndex = 28 And ComboBox3.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox4.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change date."
                ComboBox2.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus()

            End If
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim cleap As Integer
        cleap = CInt(ComboBox4.SelectedItem)
        If (ComboBox2.SelectedIndex = 28 And ComboBox3.SelectedIndex = 1) Then
            If (cleap Mod 2 = 0) Then
                Exit Sub
            Else
                errorform.Label1.Text = "Year " & ComboBox4.SelectedItem & " is not Leap Year."
                errorform.Label2.Text = "Change date."
                ComboBox2.SelectedIndex = -1 : ComboBox4.SelectedIndex = -1
                errorform.ShowDialog() : ComboBox2.Focus()

            End If
        End If
    End Sub
End Class