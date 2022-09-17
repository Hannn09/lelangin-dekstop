Public Class frmData
    Sub tampilData()
        lv_petugas.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM v_barang", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0

        Do While reader.Read
            lv_petugas.Items.Add(reader!id_barang)
            lv_petugas.Items(i).SubItems.Add(reader!nama_barang)
            lv_petugas.Items(i).SubItems.Add(reader!tgl)
            lv_petugas.Items(i).SubItems.Add(reader!harga_awal)
            lv_petugas.Items(i).SubItems.Add(reader!deskripsi_barang)
            lv_petugas.Items(i).SubItems.Add(reader!tanggal)
            lv_petugas.Items(i).SubItems.Add(reader!harga)
            i = i + 1
        Loop
    End Sub
    Private Sub frmData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        frmPetugas.Show()
    End Sub
End Class