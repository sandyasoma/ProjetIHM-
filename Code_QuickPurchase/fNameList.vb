Public Class fNameList

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        'ajouter le champ du textbox à la liste de la forme View
        fView.lstBoxListe.Items.Add(txtBoxNameList.Text)

        'On affecte la chaine de caractère au titre de la liste'
        fList.Label1.Text = txtBoxNameList.Text
        fList.Show()
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