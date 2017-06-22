Public Class fNameList

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        'ajouter le champ du textbox à la liste de la forme View
        fView.lstBoxListe.Items.Add(txtBoxNameList.Text)

        'On choisit le type de liste en fct de la période de l'année'

        If (Date.Now.Month = 4 And Date.Now.Day >= 1 And Date.Now.Day <= 30) Then
            fEaster.Label1.Text = txtBoxNameList.Text
            fEaster.Show() 'la fenêtre voulue s'ouvre'
        End If
        If (Date.Now.Month = 6 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fSummer.Label1.Text = txtBoxNameList.Text
            fSummer.Show()

        End If
        If (Date.Now.Month = 7 Or Date.Now.Month = 8 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fSummer.Label1.Text = txtBoxNameList.Text
            fSummer.Show()
        End If
        If (Date.Now.Month = 9 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fSummer.Label1.Text = txtBoxNameList.Text
            fSummer.Show()
        End If
        If (Date.Now.Month = 9 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fListe_autumn.Label1.Text = txtBoxNameList.Text
            fListe_autumn.Show()
        End If
        If (Date.Now.Month = 10 Or Date.Now.Month = 11 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_autumn.Label1.Text = txtBoxNameList.Text
            fListe_autumn.Show()
        End If
        If (Date.Now.Month = 12 Or Date.Now.Month = 1 Or Date.Now.Month = 2 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_Christmas.Label1.Text = txtBoxNameList.Text
            fListe_Christmas.Show()
        End If
        If (Date.Now.Month = 3 Or Date.Now.Month = 5 And Date.Now.Day >= 1 And Date.Now.Day <= 31) Then
            fListe_Spring.Label1.Text = txtBoxNameList.Text
            fListe_Spring.Show()
        End If
        If (Date.Now.Month = 6 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fListe_Spring.Label1.Text = txtBoxNameList.Text
            fListe_Spring.Show()
        End If
        Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNameList.TextChanged
        If txtBoxNameList.Text = "" Then
            btnValidate.Enabled = False
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If (fQuestionAdd.lblArticle.Text <> "") Then
            fQuestionAdd.Show()
            Dispose()
        Else
            fMenu.BringToFront()
            Dispose()
        End If
    End Sub
End Class