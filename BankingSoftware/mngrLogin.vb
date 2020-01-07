Public Class mngrLogin
    Dim cmd As New SqlClient.SqlCommand
    Dim rs As SqlClient.SqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            MsgBox("Fill The Fields.", MsgBoxStyle.Critical, "Empty Filled")
            TextBox1.Focus()
            Exit Sub
        End If
        If (TextBox1.Text = "") Then
            MsgBox("Enter Username.", MsgBoxStyle.Information, "Enter Correct Word")
            TextBox1.Focus()
            Exit Sub
        End If
        If (TextBox2.Text = "") Then
            MsgBox("Enter Password.", MsgBoxStyle.Information, "Enter correct Word")
            TextBox2.Focus()
            Exit Sub
        End If
        cmd.CommandText = "select * from manager where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        cmd.Connection = vcon
        rs = cmd.ExecuteReader
        rs.Read()
        If (rs.HasRows = True) Then
            rs.Close()
            MsgBox("sucessfully login", MsgBoxStyle.Information, "Login Sucessed")
            Me.Hide()
            ManagerMDI.ShowDialog()
        Else
            MsgBox("Unauthorized Access", MsgBoxStyle.Critical, "Wrong Entry")
            rs.Close()
            Me.Dispose()
            welcome.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub mngrLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        TextBox1.Text = ""
        TextBox2.Text = ""
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
End Class