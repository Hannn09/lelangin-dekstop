Public Class frmAdmin
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Hide()
        frmAddAdmin.Show()
    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click
        Me.Hide()
        frmDataAdmin.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim message As String
        message = MsgBox("Are you sure want to logout?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_lapor_Click(sender As Object, e As EventArgs) Handles btn_lapor.Click
        frmCetakAdmin.Show()
        Me.Hide()
    End Sub
End Class