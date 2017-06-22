Public Class fResearch
    Dim priceArticle As Double
    Dim price As Double
    Private Sub lblTitre2_Click(sender As Object, e As EventArgs) Handles lblTitre2.Click

    End Sub

    'Appuyer sur la touche entrer pour valider
    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            EventValidatedSub()

        End If
    End Sub

    Private Sub EventValidatedSub()
        'Ta condition
        lblquantity.Visible = True
        txtquan.Visible = True
        btnAdd.Enabled = True
        btnAdd.Visible = True
        If (txtSearch.Text <> "") Then
            Dim random As New Random
            lblArtticle.Text = txtSearch.Text
            priceArticle = random.Next(0, 100)
            lblPrice.Text = Convert.ToString(priceArticle)
        Else
            MsgBox("Please enter a field in the Search Field", MsgBoxStyle.Critical, "Warning !")
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If (txtSearch.Text = "bread") Then
            pbxBraided.Visible = True
            pbxBread.Visible = True
            pbxSoft.Visible = True

            lstBread.Visible = True
            lblquantity.Visible = True
            txtquan.Visible = True
            btnAdd.Visible = True

        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Si la recherche = bread on affiche son résultat coresspondant
        If (txtSearch.Text = "bread") Then
            fSummer.lstArticle.Items.Add(lstBread.SelectedItem)
            If (lstBread.SelectedItem = "Bread") Then
                Dim prixBread As Double = 0
                prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                fSummer.calculerPrice(prixBread)
                fSummer.lstprice.Items.Add(prixBread.ToString)
            End If
            If (lstBread.SelectedItem = "Soft bread") Then
                Dim prixSoftBread As Double = 0
                prixSoftBread = (0.5 * Convert.ToDouble(txtquan.Text))
                fSummer.calculerPrice(prixSoftBread)
                fSummer.lstprice.Items.Add(prixSoftBread.ToString)
            End If
            If (lstBread.SelectedItem = "Braided bread") Then
                Dim prixBraidedBread As Double = 0
                prixBraidedBread = (0.5 * Convert.ToDouble(txtquan.Text))
                fSummer.calculerPrice(prixBraidedBread)
                fSummer.lstprice.Items.Add(prixBraidedBread.ToString)
            End If
            fSummer.Show()
        Else
            'Si on cherche n'importe quel article
            fSummer.lstArticle.Items.Add(lblArtticle.Text)
            price = (priceArticle * Convert.ToDouble(txtquan.Text))
            fSummer.lstprice.Items.Add(price.ToString)
            fSummer.calculerPrice(price)
        End If


    End Sub

    Private Sub lstBread_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBread.SelectedIndexChanged
        If (lstBread.SelectedItem = "") Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub
End Class