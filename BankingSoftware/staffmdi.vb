Public Class staffmdi

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        addcust.MdiParent = Me
        addcust.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        updatecust.MdiParent = Me
        updatecust.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        atmform.MdiParent = Me
        atmform.Show()
    End Sub

    Private Sub staffmdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        staff1.ShowDialog()
    End Sub

    
    Private Sub CloseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem2.Click
        Me.Dispose()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Refresh()
    End Sub

    Private Sub MaleCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleCustomerToolStripMenuItem.Click
        report3.ShowDialog()
    End Sub

    Private Sub FemaleCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustListToolStripMenuItem.Click
        report1.ShowDialog()
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub PickMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickMoneyToolStripMenuItem.Click
        pickform.Show()
    End Sub

    Private Sub TransferMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferMoneyToolStripMenuItem.Click
        transferform.Show()
    End Sub

    Private Sub AddMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMoneyToolStripMenuItem.Click
        addingform.Show()
    End Sub

    Private Sub CloseToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem4.Click
        Me.Dispose()
    End Sub

    Private Sub CheckBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBalanceToolStripMenuItem.Click
        ShowBalance.Show()
    End Sub

    Private Sub InterestTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterestTimeToolStripMenuItem.Click
        Intrestform.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TimeToolStripMenuItem.Text = Format(Now, "dddd, MMMM d,yyy hh:mm:ss tt")
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class