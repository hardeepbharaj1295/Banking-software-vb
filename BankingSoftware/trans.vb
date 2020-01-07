Public Class trans

    Private Sub trans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet17.trans' table. You can move, or remove it, as needed.
        Me.TransTableAdapter.Fill(Me.BankDataSet17.trans)

    End Sub
End Class