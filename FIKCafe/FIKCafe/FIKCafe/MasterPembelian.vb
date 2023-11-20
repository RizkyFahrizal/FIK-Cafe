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
    Sub Bersih()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
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

    Private Sub MasterPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        invoice()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class