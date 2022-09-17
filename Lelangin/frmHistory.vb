Public Class frmHistory
    Sub tampilData()
        lv_barang.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("SELECT * FROM history_lelang", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0

        Do While reader.Read
            lv_barang.Items.Add(reader!id_history)
            lv_barang.Items(i).SubItems.Add(reader!id_lelang)
            lv_barang.Items(i).SubItems.Add(reader!id_barang)
            lv_barang.Items(i).SubItems.Add(reader!penawaran_harga)

            i = i + 1
        Loop
    End Sub
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmMasyarakat.Show()
        Me.Hide()
    End Sub
End Class