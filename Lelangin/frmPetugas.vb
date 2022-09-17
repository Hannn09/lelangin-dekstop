Public Class frmPetugas
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.Hide()
        frmAddBarang.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim message As String
        message = MsgBox("Are you sure want to logout?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Hide()
        frmData.Show()
    End Sub

    Private Sub btn_lapor_Click(sender As Object, e As EventArgs) Handles btn_lapor.Click
        FrmCetak.Show()
        Me.Hide()
    End Sub
End Class