Public Class fLog
    Private Sub fLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPswd_TextChanged(sender As Object, e As EventArgs) Handles txtPswd.TextChanged

    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If (txtUser.Text = My.Settings.Username And txtPswd.Text = My.Settings.Password) Then
            fMenu.Show()
            Dispose()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Warning !")
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fQuickpurchase.Show()
        Dispose()
    End Sub
End Class