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
        pbxBraided.Visible = False
        pbxBread.Visible = False
        pbxSoft.Visible = False

        lstBread.Visible = False
        lstprice.Visible = False
        If (txtSearch.Text <> "") Then
            Dim random As New Random
            lblArtticle.Text = txtSearch.Text
            priceArticle = random.Next(0, 100)
            lblPrice.Text = Convert.ToString(priceArticle)
            lblArtticle.Visible = True
            lblPrice.Visible = True
        Else
            MsgBox("Please enter a field in the Search Field", MsgBoxStyle.Critical, "Warning !")
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If (txtSearch.Text = "bread") Then
            lblArtticle.Visible = False
            lblPrice.Visible = False
            pbxBraided.Visible = True
            pbxBread.Visible = True
            pbxSoft.Visible = True

            lstBread.Visible = True
            lstprice.Visible = True
            lblquantity.Visible = True
            txtquan.Visible = True
            btnAdd.Visible = True

        Else

            pbxBraided.Visible = False
            pbxBread.Visible = False
            pbxSoft.Visible = False

            lstBread.Visible = False
            lstprice.Visible = False



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

        'Si on est en été on ajoute à la liste correspondante
        If (Date.Now.Month = 6 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fSummer.Show()
            fSummer.BringToFront()
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
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixSoftBread)
                    fSummer.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixBraidedBread)
                    fSummer.lstprice.Items.Add(prixBraidedBread.ToString)
                End If
            Else
                'Si on cherche n'importe quel article
                fSummer.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fSummer.lstprice.Items.Add(price.ToString)
                fSummer.calculerPrice(price)
            End If
        End If
        'Si on est en été on ajoute à la liste correspondante
        If (Date.Now.Month = 7 Or Date.Now.Month = 8 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fSummer.Show()
            fSummer.BringToFront()
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
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixSoftBread)
                    fSummer.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixBraidedBread)
                    fSummer.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fSummer.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fSummer.lstprice.Items.Add(price.ToString)
                fSummer.calculerPrice(price)
            End If
        End If
        'Si on est en été on ajoute à la liste correspondante
        If (Date.Now.Month = 9 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fSummer.Show()
            fSummer.BringToFront()
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
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixSoftBread)
                    fSummer.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fSummer.calculerPrice(prixBraidedBread)
                    fSummer.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fSummer.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fSummer.lstprice.Items.Add(price.ToString)
                fSummer.calculerPrice(price)
            End If
        End If


        'Si c'est pacques on affiche
        If (Date.Now.Month = 4 And Date.Now.Day >= 1 And Date.Now.Day <= 30) Then
            fEaster.Show()
            fEaster.BringToFront()
            If (txtSearch.Text = "bread") Then

                fEaster.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fEaster.calculerPrice(prixBread)
                    fEaster.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fEaster.calculerPrice(prixSoftBread)
                    fEaster.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fEaster.calculerPrice(prixBraidedBread)
                    fEaster.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fEaster.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fEaster.lstprice.Items.Add(price.ToString)
                fEaster.calculerPrice(price)
            End If
        End If

        'Si c'est l'automne on affiche
        If (Date.Now.Month = 9 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fListe_autumn.Show()
            fListe_autumn.BringToFront()
            If (txtSearch.Text = "bread") Then

                fListe_autumn.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixBread)
                    fListe_autumn.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixSoftBread)
                    fListe_autumn.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixBraidedBread)
                    fListe_autumn.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fListe_autumn.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fListe_autumn.lstprice.Items.Add(price.ToString)
                fListe_autumn.calculerPrice(price)
            End If
        End If
        'Si c'est l'automne on affiche
        If (Date.Now.Month = 10 Or Date.Now.Month = 11 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_autumn.Show()
            fListe_autumn.BringToFront()
            If (txtSearch.Text = "bread") Then

                fListe_autumn.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixBread)
                    fListe_autumn.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixSoftBread)
                    fListe_autumn.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fListe_autumn.calculerPrice(prixBraidedBread)
                    fListe_autumn.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fListe_autumn.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fListe_autumn.lstprice.Items.Add(price.ToString)
                fListe_autumn.calculerPrice(price)
            End If
        End If

        'Si c'est Noel on affiche
        If (Date.Now.Month = 12 Or Date.Now.Month = 1 Or Date.Now.Month = 2 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_Christmas.Show()
            fListe_Christmas.BringToFront()

            If (txtSearch.Text = "bread") Then

                fListe_Christmas.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fListe_Christmas.calculerPrice(prixBread)
                    fListe_Christmas.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fListe_Christmas.calculerPrice(prixSoftBread)
                    fListe_Christmas.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fListe_Christmas.calculerPrice(prixBraidedBread)
                    fListe_Christmas.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fListe_Christmas.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fListe_Christmas.lstprice.Items.Add(price.ToString)
                fListe_Christmas.calculerPrice(price)
            End If
        End If

        'Si c'est le printemps
        If (Date.Now.Month = 3 Or Date.Now.Month = 5 And Date.Now.Day >= 1 And Date.Now.Day <= 31) Then
            fListe_Spring.Show()
            fListe_Spring.BringToFront()

            If (txtSearch.Text = "bread") Then

                fListe_Spring.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixBread)
                    fListe_Spring.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixSoftBread)
                    fListe_Spring.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixBraidedBread)
                    fListe_Spring.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fListe_Spring.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fListe_Spring.lstprice.Items.Add(price.ToString)
                fListe_Spring.calculerPrice(price)
            End If

        End If
        'Si c'est le printemps
        If (Date.Now.Month = 6 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fListe_Spring.Show()
            fListe_Spring.BringToFront()

            If (txtSearch.Text = "bread") Then

                fListe_Spring.lstArticle.Items.Add(lstBread.SelectedItem)
                If (lstBread.SelectedItem = "Bread") Then
                    Dim prixBread As Double = 0
                    prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixBread)
                    fListe_Spring.lstprice.Items.Add(prixBread.ToString)
                End If
                If (lstBread.SelectedItem = "Soft bread") Then
                    Dim prixSoftBread As Double = 0
                    prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixSoftBread)
                    fListe_Spring.lstprice.Items.Add(prixSoftBread.ToString)
                End If
                If (lstBread.SelectedItem = "Braided bread") Then
                    Dim prixBraidedBread As Double = 0
                    prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                    fListe_Spring.calculerPrice(prixBraidedBread)
                    fListe_Spring.lstprice.Items.Add(prixBraidedBread.ToString)
                End If

            Else
                'Si on cherche n'importe quel article
                fListe_Spring.lstArticle.Items.Add(lblArtticle.Text)
                price = (priceArticle * Convert.ToDouble(txtquan.Text))
                fListe_Spring.lstprice.Items.Add(price.ToString)
                fListe_Spring.calculerPrice(price)
            End If
        End If

    End Sub

    Private Sub lstBread_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBread.SelectedIndexChanged
        If (lstBread.SelectedItem <> "" And txtquan.Text <> "" And txtquan.Text <> "0") Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub fResearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs) Handles txtquan.TextChanged
        If (txtquan.Text <> "" And txtquan.Text <> "0") Then
            btnAdd.Enabled = True
        End If
    End Sub
End Class