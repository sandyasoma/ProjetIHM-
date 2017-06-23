Public Class fQuestionAdd
    Dim priceArticle As Double
    Dim price As Double

    'Si on veut ajouter le produit à une nouvelle liste
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fNameList.Show()

    End Sub
    'Si on veut ajouter le produit à une liste existante
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        fView.BringToFront()
        fView.Show()

    End Sub
    'On retourne a la fenetre look
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fLook.Show()
        Dispose()
    End Sub

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class