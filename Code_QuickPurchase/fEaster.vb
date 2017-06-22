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

    Private Sub pbxPoubelle_Click(sender As Object, e As EventArgs) Handles pbxPoubelle.Click
        'pour supprimer un article avec son prix
        If (lstArticle.SelectedItem <> "" And lstprice.SelectedItem <> "") Then
            lstprice.Items.RemoveAt(lstArticle.SelectedIndex)
            lstArticle.Items.Remove(lstArticle.SelectedItem)
        End If
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        If (lblprice.Text <> "0.0") Then
            fPay.lblValTot.Text = lblprice.Text
            fPay.Show()
            Dispose()
        Else
            MsgBox("Empty List !")
        End If

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        MsgBox("Your List is send !")
    End Sub
End Class