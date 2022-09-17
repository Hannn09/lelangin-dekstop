Public Class frmMasyarakat
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        frmTawar.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim message As String
        message = MsgBox("Are you sure want to logout?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        frmHistory.Show()
        Me.Hide()
    End Sub
End Class