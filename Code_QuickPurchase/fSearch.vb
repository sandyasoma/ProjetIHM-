Public Class fSearch
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        fScann.Show() 'on ouvre la fScan'
        Dispose() 'dès qu'une autre fenêtre s'ouvre on ferme la précedente.
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        fResearch.Show()
        Dispose()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        Dispose()
    End Sub
End Class