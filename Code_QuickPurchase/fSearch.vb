Public Class fSearch

    'Si on clique sur l'image scan alors on ouvre la fenêtre scan
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        fScann.Show() 'on ouvre la fScan'
        Dispose() 'on ferme la fenêtre courante.
    End Sub

    'Si on clique sur l'image rechercher alors on ouvre la fenêtre rechercher un article
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        fResearch.Show()
        fResearch.BringToFront()
        Dispose()
    End Sub

    'on retourne au menu
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        fMenu.BringToFront()
        Dispose()
    End Sub
End Class