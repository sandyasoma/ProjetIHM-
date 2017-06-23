Public Class fView
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        fMenu.BringToFront()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        fSearch.Show()
        fSearch.BringToFront()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (lstBoxListe.SelectedItem = "Christmas List") Then
            fList.pbxChristmas.Visible = True
            fList.pnlTitre.BackColor = Color.Firebrick
            fList.Show()
        End If
        If (lstBoxListe.SelectedItem = "Holidays List") Then
            fList.pbxSummer.Visible = True
            fList.pnlTitre.BackColor = Color.Gold
            fList.Show()
        End If
        If (lstBoxListe.SelectedItem = "Easter List") Then
            fList.pbxEaster.Visible = True
            fList.pnlTitre.BackColor = Color.PaleVioletRed
            fList.Show()
        End If
        If (lstBoxListe.SelectedItem <> "Christmas List" Or lstBoxListe.SelectedItem <> "Holidays List" Or lstBoxListe.SelectedItem <> "Easter List") Then
            fList.Label1.Text = lstBoxListe.SelectedItem
            fList.BringToFront()
        End If
    End Sub

    Private Sub btnCharger_Click(sender As Object, e As EventArgs) Handles btnCharger.Click
        lstBoxListe.Items.Add("Christmas List")
        lstBoxListe.Items.Add("Holidays List")
        lstBoxListe.Items.Add("Easter List")

    End Sub

    Private Sub fView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pour supprimer une liste
        If (lstBoxListe.SelectedItem <> "") Then
            lstBoxListe.Items.Remove(lstBoxListe.SelectedItem)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            lstBoxListe.Items.Remove(lstBoxListe.SelectedItem)
        End If
    End Sub
End Class
