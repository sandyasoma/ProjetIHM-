Public Class fView
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        fMenu.BringToFront()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            lstBoxListe.Items.Remove(lstBoxListe.SelectedItem)

        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        fSearch.Show()
        fSearch.BringToFront()
    End Sub
End Class
