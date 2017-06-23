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
        fList.Show()
        fList.BringToFront()
        If (txtSearch.Text = "bread") Then


            fList.lstArticle.Items.Add(lstBread.SelectedItem)
            If (lstBread.SelectedItem = "Bread") Then
                Dim prixBread As Double = 0
                prixBread = (0.5 * Convert.ToDouble(txtquan.Text))
                fList.calculerPrice(prixBread)
                fList.lstprice.Items.Add(prixBread.ToString)
            End If
            If (lstBread.SelectedItem = "Soft bread") Then
                Dim prixSoftBread As Double = 0
                prixSoftBread = (1 * Convert.ToDouble(txtquan.Text))
                fList.calculerPrice(prixSoftBread)
                fList.lstprice.Items.Add(prixSoftBread.ToString)
            End If
            If (lstBread.SelectedItem = "Braided bread") Then
                Dim prixBraidedBread As Double = 0
                prixBraidedBread = (2 * Convert.ToDouble(txtquan.Text))
                fList.calculerPrice(prixBraidedBread)
                fList.lstprice.Items.Add(prixBraidedBread.ToString)
            End If
        Else
            'Si on cherche n'importe quel article
            fList.lstArticle.Items.Add(lblArtticle.Text)
            price = (priceArticle * Convert.ToDouble(txtquan.Text))
            fList.lstprice.Items.Add(price.ToString)
            fList.calculerPrice(price)
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
        If (fQuestionAdd.lblArticle.Text <> "") Then
            txtSearch.Text = fQuestionAdd.lblArticle.Text
        End If
    End Sub

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs) Handles txtquan.TextChanged
        If (txtquan.Text <> "" And txtquan.Text <> "0") Then
            btnAdd.Enabled = True
        End If
    End Sub
End Class