Imports MySql.Data.MySqlClient
Public Class MasterPembelian
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim ds As New DataSet
    Dim ctr As Control

    Sub koneksi()
        conn = New MySqlConnection("server = localhost" + "; user id=root" + "; password=" + " " + ";database = db_fikcafe")
    End Sub
    Sub Clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox AndAlso ctr.Name <> "tbInvoice" Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Sub invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(kode_transaksi, 5, 3) AS UNSIGNED)) IS NULL THEN 1
                                    ELSE MAX(CAST(SUBSTRING(kode_transaksi, 5, 3) AS UNSIGNED)) + 1
                                    END AS nomor
                                    FROM (
                                    SELECT
                                    MAX(CAST(SUBSTRING(kode_transaksi, 9, 2) AS UNSIGNED)) AS bln,
                                    MAX(CAST(SUBSTRING(kode_transaksi, 12, 4) AS UNSIGNED)) AS thn,
                                    kode_transaksi
                                    FROM tbl_transaksi
                                    GROUP BY kode_transaksi) a
                                    WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        tbKodeTransaksi.Text = "FCF/" & Format(nom, "0##") & "/" & Now.Year
    End Sub

    Dim id_produk As String = Menu_Makanan.IdMakanan
    Dim namaMakanan As String = Menu_Makanan.NamaMakanan
    Dim hargaMakanan As String = Menu_Makanan.HargaMakanan

    Sub tampil_data()
        koneksi()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT * FROM tbl_produk WHERE id_produk= '" & id_produk & "'", conn)
        tbMenu.Text = namaMakanan
        tbHarga.Text = hargaMakanan
    End Sub
    Private Sub MasterPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil_data()
        invoice()
    End Sub
    Private Sub tbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        Try
            ds.Clear()
            da = New MySqlDataAdapter("select harga_produk from tbl_produk where nama_produk='" & hargaMakanan & "'", conn)
            da.Fill(ds, "harga")
            Dim harga As Integer = Integer.Parse(tbHarga.Text)
            Dim jumlah As Integer = Integer.Parse(tbJumlah.Text)

            If Integer.TryParse(tbJumlah.Text, jumlah) Then
                Dim total As Integer = jumlah * harga
                tbTotal.Text = total.ToString()
            Else
                tbTotal.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim nama_customer As String = tbCustomer.Text
            Dim menuAlreadyExists As Boolean = False
            Dim existingRowIndex As Integer = -1

            For Each row As DataGridViewRow In dgvPembelian.Rows
                If row.Cells("menu").Value IsNot Nothing AndAlso row.Cells("menu").Value.ToString() = namaMakanan Then
                    menuAlreadyExists = True
                    existingRowIndex = row.Index
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormMaster.Show()
        Me.Hide()
        Clear()
    End Sub

    Private Sub btnMenuMakanan_Click(sender As Object, e As EventArgs) Handles btnMenuMakanan.Click
        Menu_Makanan.Show()
        Me.Close()
    End Sub
End Class