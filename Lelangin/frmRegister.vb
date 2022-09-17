Public Class frmRegister
    Public Sub clearData()
        txt_nama.Text = ""
        txt_user.Text = ""
        txt_pass.Text = ""
        txt_telp.Text = ""
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If txt_nama.Text = "" Or
           txt_user.Text = "" Or
           txt_pass.Text = "" Or
           txt_telp.Text = "" Then
            MessageBox.Show("Semua harus diisi!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            konek_db()
            Dim regist As New SqlClient.SqlCommand("INSERT INTO tb_user VALUES('" & txt_nama.Text & "','" & txt_user.Text & "','" & txt_pass.Text & "','" & txt_telp.Text & "','1002')", koneksi)

            Try
                regist.ExecuteNonQuery()
                MsgBox("Registrasi Berhasil", MsgBoxStyle.Information)
                frmLogin.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Registrasi Gagal karena  " + ex.Message)
            End Try
            txt_nama.Focus()
        End If
        clearData()
    End Sub
    Private Sub txt_pass_OnValueChanged(sender As Object, e As EventArgs) Handles txt_pass.OnValueChanged
        txt_pass.isPassword = True
    End Sub

    Private Sub txt_telp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telp.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0

        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nama.Focus()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class