Public Class adminreport

    Private Sub adminreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = CInt(Label1.Text) + CInt(Label2.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose() : ManagerMDI.Show()
    End Sub
End Class