Public Class fNameList

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        If txtBoxNameList.Text = "" Then
            MsgBox("Please enter a title for your list ! ")
        Else
            'ajouter le champ du textbox à la liste de la forme View
            fView.lstBoxListe.Items.Add(txtBoxNameList.Text)

            'On affecte la chaine de caractère au titre de la liste'
            fList.Label1.Text = txtBoxNameList.Text
            fList.Show()
            Dispose()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNameList.TextChanged

    End Sub

    'la fenetre courante s'affcihe de 2 facons soit a partir du menu soit a partir de fQuestionAdd donc on vérifie ici de quelle fenêtre est issue fNameList
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Si elle est issue de fQuestionAdd alors on retourne à cette fenetre
        If (fQuestionAdd.lblArticle.Text <> "") Then
            fQuestionAdd.Show()
            Dispose()
            'Sinon on retourne au menu
        Else
            fMenu.BringToFront()
            Dispose()
        End If
    End Sub
End Class