Public Class welcome
    Dim a As Integer
    Private Sub welcome_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Close()
    End Sub

    Private Sub welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call apply()
        PictureBox11.Left = 321 : PictureBox11.Width = 650 : PictureBox11.Top = 260 : PictureBox11.Height = 0
        PictureBox9.Left = 321 : PictureBox9.Width = 650 : PictureBox9.Top = 260 : PictureBox9.Height = 0
        PictureBox10.Left = 321 : PictureBox10.Width = 650 : PictureBox10.Top = 260 : PictureBox10.Height = 0
        PictureBox8.Left = 321 : PictureBox8.Width = 650 : PictureBox8.Top = 260 : PictureBox8.Height = 0
        Timer1.Enabled = True : a = 0
        Label9.Text = ""
        Label9.Text = Now

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mngrLogin.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        stafflogin.ShowDialog()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BankPolicy.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (a = 0) Then
            PictureBox8.Height = 266
        End If
        If (a = 1) Then
            PictureBox9.Height = 266
        End If
        If (a = 2) Then
            PictureBox10.Height = 266
        End If
        If (a = 3) Then
            PictureBox11.Height = 266
        End If
        If (a = 4) Then
            PictureBox11.Height = 0
        End If
        If (a = 5) Then
            PictureBox10.Height = 0
        End If
        If (a = 6) Then
            PictureBox9.Height = 0
        End If
        a = a + 1
        If (a > 6) Then
            a = 1
        End If
    End Sub
End Class