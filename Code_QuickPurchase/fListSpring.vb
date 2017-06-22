Public Class fListe_Spring
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxSpring.Click

    End Sub
    Dim priceTot As Double = 0
    Public Sub calculerPrice(price As Double)
        priceTot += price
        lblprice.Text = priceTot.ToString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        Dispose()
    End Sub

    Private Sub pbxSearch_Click(sender As Object, e As EventArgs) Handles pbxSearch.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

    End Sub
End Class