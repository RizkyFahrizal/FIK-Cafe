Imports MySql.Data.MySqlClient
Public Class Menu_Makanan
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim ds As New DataSet
    Dim ctr As Control
    Public IdMakanan As String
    Public NamaMakanan As String
    Public HargaMakanan As String

    Sub koneksi()
        conn = New MySqlConnection("server = localhost" + "; user id=root" + "; password=" + " " + ";database = db_fikcafe")
    End Sub
    Sub Clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub
    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("select * from tbl_produk where kategori_produk = 'makanan';", conn)
            da.Fill(ds, "menuMakanan")
            dgvMenuMakanan.Rows.Clear()

            For i As Integer = 0 To ds.Tables("menuMakanan").Rows.Count - 1
                dgvMenuMakanan.Rows.Add(ds.Tables("menuMakanan").Rows(i).Item(0).ToString,
                                ds.Tables("menuMakanan").Rows(i).Item(1).ToString,
                                ds.Tables("menuMakanan").Rows(i).Item(2).ToString,
                                ds.Tables("menuMakanan").Rows(i).Item(3).ToString,
                                ds.Tables("menuMakanan").Rows(i).Item(4).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Menu_Makanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil_data()
    End Sub
    Private Sub dgvMenuMakanan_DoubleClick(sender As Object, e As EventArgs) Handles dgvMenuMakanan.DoubleClick
        Try
            If dgvMenuMakanan.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvMenuMakanan.Rows(0)
                IdMakanan = selectedRow.Cells("kode_makanan").Value.ToString()
                NamaMakanan = selectedRow.Cells("nama_makanan").Value.ToString()
                HargaMakanan = Convert.ToInt32(selectedRow.Cells("harga").Value)
                Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Hide()
        MasterPembelian.Show()
        Me.Dispose()
    End Sub
End Class