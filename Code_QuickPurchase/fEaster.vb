Public Class fEaster

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show() 'Retour au menu'
        Dispose()
    End Sub
    Dim priceTot As Double = 0
    Public Sub calculerPrice(price As Double)
        priceTot += price
        lblprice.Text = priceTot.ToString
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbxSearch2.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub fEaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class