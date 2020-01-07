Public Class report1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r1 As New CrystalReport1
        CrystalReportViewer1.ReportSource = r1
    End Sub
End Class