Public Class FormMaster
    Private Sub btnMasterPembelian_Click(sender As Object, e As EventArgs) Handles btnMasterPembelian.Click
        MasterPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub BerandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerandaToolStripMenuItem.Click
        FormListMenu.Show()
        Me.Hide()
    End Sub
End Class