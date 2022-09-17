Imports System.IO
Public Class frmAddBarang
    Sub clearData()
        txt_id.Text = ""
        txt_namabrg.Text = ""
        txt_harga.Text = ""
        txt_deskripsi.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Sub tampil_data()
        lv_barang.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from tb_barang", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_barang.Items.Add(reader!id_barang)
            lv_barang.Items(i).SubItems.Add(reader!nama_barang)
            lv_barang.Items(i).SubItems.Add(reader!tgl)
            lv_barang.Items(i).SubItems.Add(reader!harga_awal)
            lv_barang.Items(i).SubItems.Add(reader!deskripsi_barang)

            i = i + 1
        Loop
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_namabrg.Text = "" And
            dtp_tgl.Text = "" And
            txt_harga.Text = "" And
            txt_deskripsi.Text = "" Then
            MsgBox("Data tidak lengkap", MsgBoxStyle.Critical, "Failed")

        Else
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            konek_db()
            Dim simpan As New SqlClient.SqlCommand("INSERT INTO tb_barang VALUES('" & txt_namabrg.Text & "','" & dtp_tgl.Text & "','" & txt_harga.Text & "','" & txt_deskripsi.Text & "',@image)", koneksi)
            simpan.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()

            Try
                simpan.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Information")
                tampil_data()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            clearData()
        End If
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_namabrg.Text = "" Then
            MsgBox("Pilih data dahulu", MsgBoxStyle.Information, "Information")
        Else
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            konek_db()
            Dim update As New SqlClient.SqlCommand("UPDATE tb_barang set nama_barang = '" & txt_namabrg.Text & "', tgl = '" & dtp_tgl.Text & "',harga_awal = '" & txt_harga.Text & "', deskripsi_barang = '" & txt_deskripsi.Text & "',foto = @image WHERE id_barang = '" & txt_id.Text & "'", koneksi)
            update.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()

            Try
                update.ExecuteNonQuery()
                MsgBox("Data berhasil di update", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            tampil_data()
            clearData()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_id.Text = "" Then
            MsgBox("Pilih data dulu", MsgBoxStyle.Information, "Information")

        Else
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("DELETE FROM tb_barang where id_barang = '" & txt_id.Text & "'", koneksi)


            Try
                hapus.ExecuteNonQuery()
                MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        tampil_data()
        clearData()
    End Sub
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        txt_id.Text = ""
        txt_namabrg.Text = ""
        txt_harga.Text = ""
        txt_deskripsi.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_data()
    End Sub

    Private Sub lv_barang_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_barang.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_barang WHERE id_barang = '" & lv_barang.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!id_barang
            txt_namabrg.Text = reader!nama_barang
            dtp_tgl.Text = reader!tgl
            txt_harga.Text = reader!harga_awal
            txt_deskripsi.Text = reader!deskripsi_barang
            Dim img() As Byte
            img = reader!foto
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        Loop

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        frmPetugas.Show()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        open_foto.Filter = "images|*.jpg;*.png;*.jpeg;*.bmp;*.gif"

        If open_foto.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open_foto.FileName)
        End If
    End Sub

    Private Sub txt_harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_harga.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0

        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
End Class