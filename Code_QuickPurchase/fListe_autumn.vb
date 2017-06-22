Public Class fListe_autumn
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        Dispose()
    End Sub
    Dim priceTot As Double = 0
    Public Sub calculerPrice(price As Double)
        priceTot += price
        lblprice.Text = priceTot.ToString
    End Sub

    Private Sub pbxSearch_Click(sender As Object, e As EventArgs) Handles pbxSearch.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub fListe_autumn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class