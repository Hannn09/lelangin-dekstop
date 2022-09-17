Imports System.IO
Public Class frmTawar
    Sub clearData()
        cb_barang.Text = ""
        nmric_harga.Text = ""
        txt_id_barang.Text = ""
    End Sub
    Sub tampilBarang()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_barang", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        Do While reader.Read
            cb_barang.Items.Add(reader("nama_barang"))
        Loop
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
    Private Sub tawarbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_data()
        tampilBarang()
    End Sub

    Private Sub cb_barang_TextChanged(sender As Object, e As EventArgs) Handles cb_barang.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_barang WHERE nama_barang = '" & cb_barang.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader

        If cb_barang.Text = "" Then
            txt_id_barang.Text = ""
        End If

        Do While reader.Read
            If reader.RecordsAffected <> 0 Then
                txt_id_barang.Text = reader!id_barang
            End If
        Loop
    End Sub

    Private Sub btn_tawar_Click(sender As Object, e As EventArgs) Handles btn_tawar.Click
        If cb_barang.Text = "" And dtp_tgl.Text = "" And nmric_harga.Text = "" Then
            MsgBox("Data harus diisi semua!", vbCritical)

        Else
            konek_db()
            Dim insert As New SqlClient.SqlCommand("INSERT INTO tb_lelang VALUES('" & txt_id_barang.Text & "','" & dtp_tgl.Text & "','" & nmric_harga.Text & "','1','1','')", koneksi)
            Dim insert_history As New SqlClient.SqlCommand("INSERT INTO history_lelang VALUES('4','" & txt_id_barang.Text & "','1','" & nmric_harga.Text & "')", koneksi)

            Try
                insert.ExecuteNonQuery()
                insert_history.ExecuteNonQuery()
                MsgBox("Tawaran berhasil dimasukkan!", vbInformation)
                clearData()
            Catch ex As Exception
                MsgBox("Tawaran gagal dimasukkan karena " + ex.Message)
            End Try
        End If
    End Sub
    Private Sub lv_barang_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_barang.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM tb_barang WHERE id_barang = '" & lv_barang.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            Dim img() As Byte
            img = reader!foto
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        Loop

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmMasyarakat.Show()
        Me.Hide()
    End Sub
End Class