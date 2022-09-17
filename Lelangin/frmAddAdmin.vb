Public Class frmAddAdmin
    Sub clearData()
        txt_id_petugas.Text = ""
        txt_nama.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        cb_level.Text = ""
        txt_id_level.Text = ""
    End Sub
    Sub tampilData()
        konek_db()
        lv_petugas.Items.Clear()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM v_petugas", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0

        Do While reader.Read
            lv_petugas.Items.Add(reader!id_petugas)
            lv_petugas.Items(i).SubItems.Add(reader!nama_petugas)
            lv_petugas.Items(i).SubItems.Add(reader!username)
            lv_petugas.Items(i).SubItems.Add(reader!jenis_level)
            i = i + 1
        Loop
    End Sub
    Sub tampilLevel()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_level", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            cb_level.Items.Add(reader("level"))
        Loop
    End Sub

    Private Sub txt_password_OnValueChanged(sender As Object, e As EventArgs) Handles txt_password.OnValueChanged
        txt_password.isPassword = True
    End Sub

    Private Sub frmAddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        tampilLevel()
    End Sub

    Private Sub cb_level_TextChanged(sender As Object, e As EventArgs) Handles cb_level.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_level WHERE level = '" & cb_level.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If cb_level.Text = "" Then
            txt_id_petugas.Text = ""
        End If

        Do While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_level.Text = reader!id_level
            End If
        Loop
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_nama.Text = "" And txt_username.Text = "" And txt_password.Text = "" And cb_level.Text = "" Then
            MsgBox("Data harus diisi semua!", vbCritical)

        Else
            konek_db()
            Dim insert As New SqlClient.SqlCommand("INSERT INTO tb_petugas VALUES('" & txt_nama.Text & "','" & txt_username.Text & "','" & txt_password.Text & "','" & txt_id_level.Text & "')", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = insert.ExecuteReader

            Try
                insert.Connection = koneksi
                MsgBox("Data berhasil dimasukkan!", vbInformation)
                clearData()
                tampilData()
            Catch ex As Exception
                MsgBox("Data gagal dimasukkan karena " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmAdmin.Show()
        Me.Hide()
    End Sub
End Class