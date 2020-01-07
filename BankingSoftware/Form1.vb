Public Class Form1
    Dim st As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox3.Width = st
        st = st + 1
        If (st >= 394) Then
            Timer1.Enabled = False
            Me.Hide()
            welcome.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        st = 0
    End Sub
End Class
