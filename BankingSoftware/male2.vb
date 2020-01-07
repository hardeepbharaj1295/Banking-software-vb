Public Class male2

    Private Sub male2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet16.cust1' table. You can move, or remove it, as needed.
        Me.Cust1TableAdapter.Fill(Me.BankDataSet16.cust1)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Cust1TableAdapter.FillBy(Me.BankDataSet16.cust1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.Cust1TableAdapter.FillBy1(Me.BankDataSet16.cust1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class