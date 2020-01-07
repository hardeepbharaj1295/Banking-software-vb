Public Class Loan_form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Loan_form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        loan_form.Dispose()
    End Sub

End Class