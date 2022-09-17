Imports System.Drawing.Printing
Public Class frmCetakAdmin
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

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Private Sub FrmCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PPD.Document = PD
        PPD.ShowDialog()
        PD.Print()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "----------------------------------------------------------------"

        e.Graphics.DrawString("Laporan Lelang", f14, Brushes.Black, centermargin, 20, tengah)
        Dim be As New Bitmap(Me.lv_petugas.Width, Me.lv_petugas.Height)
        lv_petugas.DrawToBitmap(be, New Rectangle(10, 30, Me.lv_petugas.Width, Me.lv_petugas.Height))
        e.Graphics.DrawImage(be, 50, 50)

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 900, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frmAdmin.Show()
        Me.Hide()
    End Sub
End Class