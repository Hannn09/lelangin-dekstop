Public Class FrmLogin
    Sub clearData()
        txt_username.Text = ""
        txt_password.Text = ""
        cb_log.Text = "Login Sebagai?"
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmRegister.Show()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text <> "" And txt_password.Text <> "" And cb_log.Text <> "Login Sebagai?" Then

            If cb_log.Text = "Admin" Then
                konek_db()
                Dim login_admin As New SqlClient.SqlCommand("SELECT * FROM tb_petugas WHERE username = '" & txt_username.Text & "'AND password = '" & txt_password.Text & "'", koneksi)
                Dim reader_admin As SqlClient.SqlDataReader
                reader_admin = login_admin.ExecuteReader()
                reader_admin.Read()

                Try
                    Dim role As String
                    role = reader_admin!id_level
                    If role = "1" Then
                        MsgBox("Login Succes!", MsgBoxStyle.Information)
                        frmAdmin.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox("Usernaem or Password is Not Valid!", MsgBoxStyle.Critical)
                End Try
            End If

            If cb_log.Text = "Petugas" Then
                konek_db()
                Dim login_petugas As New SqlClient.SqlCommand("SELECT * FROM tb_petugas WHERE username = '" & txt_username.Text & "'AND password = '" & txt_password.Text & "'", koneksi)
                Dim reader_petugas As SqlClient.SqlDataReader
                reader_petugas = login_petugas.ExecuteReader()
                reader_petugas.Read()

                Try
                    Dim role As String
                    role = reader_petugas!id_level
                    If role = "2" Then
                        MsgBox("Login Succes!", MsgBoxStyle.Information)
                        frmPetugas.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            If cb_log.Text = "User" Then
                konek_db()
                Dim login_user As New SqlClient.SqlCommand("SELECT * FROM tb_user WHERE Username = '" & txt_username.Text & "'AND Password = '" & txt_password.Text & "'", koneksi)
                Dim reader_user As SqlClient.SqlDataReader
                reader_user = login_user.ExecuteReader()
                reader_user.Read()

                Try
                    Dim role As String
                    role = reader_user!id_level
                    If role = "1002" Then
                        MsgBox("Login Succes!", MsgBoxStyle.Information)
                        frmMasyarakat.Show()
                        Me.Hide()
                        frmMasyarakat.lbl_user.Text = reader_user!Nama
                    End If
                Catch ex As Exception
                    MsgBox("Usernaem or Password is Not Valid!", MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Username or Password is Not Valid!", MsgBoxStyle.Critical)
        End If
        clearData()
        txt_username.Focus()
    End Sub
    Private Sub txt_password_OnValueChanged(sender As Object, e As EventArgs) Handles txt_password.OnValueChanged
        txt_password.isPassword = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_log.Items.Add("Admin")
        cb_log.Items.Add("Petugas")
        cb_log.Items.Add("User")
        cb_log.Text = "Login Sebagai?"
        txt_username.Focus()
    End Sub
End Class
