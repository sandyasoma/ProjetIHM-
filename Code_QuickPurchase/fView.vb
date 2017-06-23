Public Class fView
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
    'on retourne à la fenêtre préc
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        fMenu.BringToFront()
    End Sub

    'Si on veut modifier une liste on est directement rediriger vers la fenêtre chercher un article
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        fSearch.Show() ' soit on l'ouvre
        fSearch.BringToFront() 'soit on l'a met en premier plan
    End Sub

    'permet de voir la liste qui correspond à celle séléctionnée dans la listBox de liste.
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

        'si c'est une liste autre que celle chargée on affiche la liste déjà crée
        If (lstBoxListe.SelectedItem <> "Christmas List" Or lstBoxListe.SelectedItem <> "Holidays List" Or lstBoxListe.SelectedItem <> "Easter List" And fList.ScrollStateHScrollVisible = True) Then
            fList.Label1.Text = lstBoxListe.SelectedItem
            fList.BringToFront()
            'si elle n'existe pas encore on affiche un message d'erreur
        Else
            MsgBox("Empty List ! Nothing to view !")
        End If
    End Sub

    'le bouton charger liste ajoute par défaut 3 noms de listes à la listBox liste.
    Private Sub btnCharger_Click(sender As Object, e As EventArgs) Handles btnCharger.Click
        lstBoxListe.Items.Add("Christmas List")
        lstBoxListe.Items.Add("Holidays List")
        lstBoxListe.Items.Add("Easter List")

    End Sub

    'Gérer l'evenement voir une liste 
    Private Sub fView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pour supprimer une liste
        If (lstBoxListe.SelectedItem <> "") Then
            lstBoxListe.Items.Remove(lstBoxListe.SelectedItem)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'message de confirmation avant de supprimer la liste
        If MsgBox("Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            lstBoxListe.Items.Remove(lstBoxListe.SelectedItem)
            'Verifie si la fenetre Liste est ouverte et l'a ferme si c'est le cas
            If (fList.Visible = True) Then
                fList.Dispose()
            End If
        End If
    End Sub


End Class
