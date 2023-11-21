Public Class FormListMenu
    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        FormMaster.Show()
        Me.Hide()
    End Sub
End Class