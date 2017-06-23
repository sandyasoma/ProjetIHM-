Public Class fList
    Dim priceTot As Double = 0

    Public Sub calculerPrice(price As Double)
        priceTot += price
        lblprice.Text = priceTot.ToString
    End Sub
    Private Sub fList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ici on gère l'affichage de la liste en fonction de la période de l'année
        'Si on est en été :
        If (Date.Now.Month = 6 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            pbxSummer.Visible = True
            pnlTitre.BackColor = Color.Gold
        End If
        'Si on est en été 
        If (Date.Now.Month = 7 Or Date.Now.Month = 8 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            pbxSummer.Visible = True
            pnlTitre.BackColor = Color.Gold
        End If
        'Si on est en été on ajoute à la liste correspondante
        If (Date.Now.Month = 9 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            pbxSummer.Visible = True
            pnlTitre.BackColor = Color.Gold
        End If


        'Si c'est pacques on affiche
        If (Date.Now.Month = 4 And Date.Now.Day >= 1 And Date.Now.Day <= 30) Then
            pbxEaster.Visible = True
            pnlTitre.BackColor = Color.PaleVioletRed
        End If

        'Si c'est l'automne on affiche
        If (Date.Now.Month = 9 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            pbxAutumn.Visible = True
            pnlTitre.BackColor = Color.Chocolate
        End If
        'Si c'est l'automne on affiche
        If (Date.Now.Month = 10 Or Date.Now.Month = 11 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            pbxAutumn.Visible = True
            pnlTitre.BackColor = Color.Chocolate
        End If

        'Si c'est Noel on affiche
        If (Date.Now.Month = 12 Or Date.Now.Month = 1 Or Date.Now.Month = 2 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            pbxChristmas.Visible = True
            pnlTitre.BackColor = Color.Firebrick
        End If

        'Si c'est le printemps
        If (Date.Now.Month = 3 Or Date.Now.Month = 5 And Date.Now.Day >= 1 And Date.Now.Day <= 31) Then
            pbxSpring.Visible = True
            pnlTitre.BackColor = Color.Green

        End If
        'Si c'est le printemps
        If (Date.Now.Month = 6 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            pbxSpring.Visible = True
            pnlTitre.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.BringToFront()
        fResearch.Dispose()
    End Sub

    Private Sub pbxPoubelle_Click(sender As Object, e As EventArgs) Handles pbxPoubelle.Click
        'pour supprimer un article avec son prix
        If (lstArticle.SelectedItem <> "" And lstprice.SelectedItem <> "") Then
            priceTot -= Convert.ToInt32(lstprice.SelectedItem())
            lblprice.Text = priceTot.ToString
            lstprice.Items.RemoveAt(lstArticle.SelectedIndex)
            lstArticle.Items.Remove(lstArticle.SelectedItem)

        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If (lblprice.Text <> "0.0") Then
            MsgBox("Your List has been sent !")
            fResearch.Dispose()
        Else
            MsgBox("Empty List !")
        End If
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        If (lblprice.Text = "0.0" Or lblprice.Text = "0") Then
            MsgBox("Empty List !")
        Else
            fPay.lblValTot.Text = lblprice.Text
            fPay.Show()
            fView.lstBoxListe.Items.Remove(Label1.Text)
            Dispose()
            fResearch.Dispose()
        End If
    End Sub

    Private Sub pbxSearch_Click(sender As Object, e As EventArgs) Handles pbxSearch.Click
        fSearch.Show()
    End Sub

    Private Sub lblTitre_Click(sender As Object, e As EventArgs) Handles lblTitre.Click

    End Sub
End Class