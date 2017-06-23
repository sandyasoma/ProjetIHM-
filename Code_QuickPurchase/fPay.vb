Public Class fPay
    Private Sub lblMenu_Click(sender As Object, e As EventArgs) Handles lblMenu.Click

    End Sub

    Private Sub lblprice_Click(sender As Object, e As EventArgs) Handles lblprice.Click

    End Sub
    'Si la caissière valide le paiement alors on affiche un msgBox
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        MsgBox("Oooh Poor Wallet :(")
        Dispose()
    End Sub
End Class