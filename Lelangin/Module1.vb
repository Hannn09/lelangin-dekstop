Imports System.Data.SqlClient
Module Module1
    Public koneksi As SqlConnection = Nothing
    Public Sub konek_db()
        Dim server As String
        server = "server=Hannn\SQLEXPRESS;database=Lelangin;Integrated Security = True"
        koneksi = New SqlConnection(server)
        koneksi.Open()
    End Sub
    Public Function daftar(ByVal nama_lengkap As String, ByVal username As String, ByVal password As String, ByVal telp As String)
        konek_db()
        Dim cmd As New SqlCommand("Insert into tb_masyarakat(nama_lengkap,username,password,telp,id_level)values (@1,@2,@3,@4,@5)", koneksi)
        With cmd
            .Parameters.AddWithValue("@1", nama_lengkap)
            .Parameters.AddWithValue("@2", username)
            .Parameters.AddWithValue("@3", password)
            .Parameters.AddWithValue("@4", telp)

            .ExecuteNonQuery()
        End With
        Return True
    End Function
    Public Function masuk(ByVal username As String, ByVal password As String)
        konek_db()
        Dim cmd As New SqlCommand("select * from tb_masyarakat where username= @1 and password=@2", koneksi)
        cmd.Parameters.AddWithValue("@1", username)
        cmd.Parameters.AddWithValue("@2", password)
        Dim dt As New DataTable
        Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function
End Module
