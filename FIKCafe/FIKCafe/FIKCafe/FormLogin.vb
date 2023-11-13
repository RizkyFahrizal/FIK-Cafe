Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf TxtUsername.Text = "FIKCafe" And TxtPassword.Text = "12345" Then
            MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Akses Berhasil")
            FormListMenu.Show()
            Me.Hide()
        Else
            MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Sub Bersih()
        TxtUsername.Text = ""
        TxtPassword.Text = ""
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

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TxtUsername.Text = "" And TxtPassword.Text = "" Then
                MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
            ElseIf TxtUsername.Text = "FIKCafe" And TxtPassword.Text = "12345" Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Akses Berhasil")
                FormListMenu.Show()
                Me.Hide()
            Else
                MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
                Call Bersih()
                TxtUsername.Focus()
            End If
        End If
    End Sub
End Class
