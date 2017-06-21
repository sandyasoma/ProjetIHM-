Public Class fEaster
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show() 'Retour au menu'
        Dispose()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbxSearch2.Click
        fSearch.Show()
        Dispose()
    End Sub
End Class