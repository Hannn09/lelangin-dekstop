Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rep As CrystalReport2 = New CrystalReport2()
        Dim query As New SqlClient.SqlCommand
        Dim data As New DataTable
        Dim reader As SqlClient.SqlDataReader
        konek_db()
        query.CommandText = "SELECT * FROM v_barang"
        query.Connection = koneksi
        reader = query.ExecuteReader()
        data.Load(reader)
        rep.SetDataSource(data)
        Me.CrystalReportViewer1.ReportSource = rep
        Me.Show()
    End Sub
End Class