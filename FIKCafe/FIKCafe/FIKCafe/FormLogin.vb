Imports MySql.Data.MySqlClient
Public Class FormLogin
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim ds As New DataSet
    Dim ctr As Control

    Sub koneksi()
        conn = New MySqlConnection("server = localhost" + "; user id=root" + "; password=" + " " + ";database = db_fikcafe")
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan!")
            For Each ctr In Me.Controls
                If TypeOf ctr Is TextBox Then
                    ctr.Enabled = False
                ElseIf TypeOf ctr Is CheckBox Then
                    DirectCast(ctr, CheckBox).Enabled = False
                End If
            Next
        End Try
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            Dim query As String = "SELECT * FROM tbl_user WHERE nama_user = @username AND pwd_user = @password"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)
            conn.Open()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MessageBox.Show("Login Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Bersih()
            Else
                MessageBox.Show("Login gagal! Periksa kembali username dan password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Bersih()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        FormListMenu.Show()
        Me.Hide()
    End Sub

    Sub Bersih()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Bersih()
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If CheckBoxPass.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
        TxtPassword.Focus()
    End Sub
End Class
