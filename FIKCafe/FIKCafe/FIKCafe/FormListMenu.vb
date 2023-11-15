Public Class FormListMenu
    Private Sub btnDetail1_Click(sender As Object, e As EventArgs) Handles btnDetail1.Click
        MessageBox.Show("Hot Cappucino adalah minuman kopi klasik yang terdiri dari espresso kuat yang dicampur dengan busa susu yang lembut, menciptakan harmoni cita rasa kopi yang kental dan kelembutan susu yang menggoda.", "Hot Cappucino", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDetail2_Click(sender As Object, e As EventArgs) Handles btnDetail2.Click
        MessageBox.Show("Cupcake adalah kudapan kecil berbentuk kue yang lembut dan ringan, dihiasi dengan beragam topping seperti krim keju, glasir, atau hiasan manis lainnya. Rasanya yang lezat dan ukurannya yang pas membuat cupcake menjadi pilihan populer untuk memanjakan lidah dalam sajian makanan ringan.", "Cupcake", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDetail3_Click(sender As Object, e As EventArgs) Handles btnDetail3.Click
        MessageBox.Show("Beef Burger adalah sajian gurih yang terdiri dari patty daging sapi panggang yang juicy, ditemani dengan sayuran segar dan saus, semuanya diapit oleh roti burger lembut. Kombinasi tekstur dan rasa yang memikat menjadikan beef burger favorit yang memuaskan selera.", "Beef Burger", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        FormMaster.Show()
        Me.Hide()
    End Sub
End Class