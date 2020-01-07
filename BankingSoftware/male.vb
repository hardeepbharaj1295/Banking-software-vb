Public Class male

 


   



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cust1TableAdapter.FillBy1(Me.BankDataSet13.cust1, TextBox1.Text)

    End Sub
End Class