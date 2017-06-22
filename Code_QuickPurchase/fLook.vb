Public Class fLook
    Private Sub lblTitre2_Click(sender As Object, e As EventArgs) 

    End Sub
    'Là on gère la fonctionnalité complémentaire de notre application
    Private Sub fLook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = My.Settings.Username
        'On affiche selon les l'âge et le sexe de l'utilisateur
        If (My.Settings.Age >= 18 And My.Settings.Age <= 60) Then
            'On affiche la bouteille si c'est adulte
            pbxMale2.Visible = True
            If (My.Settings.Gender = "Female") Then
                'Si c'est une femme on affiche des produits de beauté
                pbxFemale.Visible = True
                pbxFemale1.Visible = True
            ElseIf (My.Settings.Gender = "Male") Then
                'Si c'est un homme on affiche un rasoir
                pbxMale.Visible = True
            End If
        Else

            pbxOld.Visible = True
        End If

        'on affiche selon le sexe et l'âge de chaque membre de la famille
        'Ici Si c'est un bébé on affiche la couche
        If (My.Settings.mb1Age <= 3 Or My.Settings.mb2Age <= 3 Or My.Settings.mb3Age <= 3 Or My.Settings.mb4Age <= 3 Or My.Settings.mb5Age <= 3) Then
            pbxbebe.Visible = True
        End If
        'ici si c'est un ado on affiche le hand spinner et le bonbon
        If (My.Settings.mb1Age > 3 And My.Settings.mb1Age < 18 Or My.Settings.mb2Age > 3 And My.Settings.mb2Age < 18 Or My.Settings.mb3Age > 3 And My.Settings.mb3Age < 18 Or My.Settings.mb4Age > 3 And My.Settings.mb4Age < 18 Or My.Settings.mb5Age > 3 And My.Settings.mb5Age < 18) Then
            pbxAdo1.Visible = True
            pbxAdo2.Visible = True
            'Ici si l'ado est uun garcon on affiche le ballon en plus
            If (My.Settings.mb1Gen = "Male" Or My.Settings.mb2Gen = "Male" Or My.Settings.mb3Gen = "Male" Or My.Settings.mb4Gen = "Male" Or My.Settings.mb5Gen = "Male") Then
                pbxAdoM.Visible = True

            End If
            'Sinon si l'ado est une fille on affiche une poupée
            If (My.Settings.mb1Gen = "Female" Or My.Settings.mb2Gen = "Female" Or My.Settings.mb3Gen = "Female" Or My.Settings.mb4Gen = "Female" Or My.Settings.mb5Gen = "Female") Then
                pbxAdoF.Visible = True
            End If
        End If
        'si le membre de la famille est vieux on affcihe le dentier
        If (My.Settings.mb1Age >= 60 Or My.Settings.mb2Age >= 60 Or My.Settings.mb3Age >= 60 Or My.Settings.mb4Age >= 60 Or My.Settings.mb5Age >= 60) Then
            pbxOld1.Visible = True
        End If
        If (My.Settings.mb1Age >= 18 And My.Settings.mb1Age < 60 Or My.Settings.mb2Age >= 18 And My.Settings.mb2Age < 60 Or My.Settings.mb3Age >= 18 And My.Settings.mb3Age < 60 Or My.Settings.mb4Age >= 18 And My.Settings.mb4Age < 60 Or My.Settings.mb5Age >= 18 And My.Settings.mb5Age < 60) Then
            pbxMale4.Visible = True
            If (My.Settings.mb1Gen = "Male" Or My.Settings.mb2Gen = "Male" Or My.Settings.mb3Gen = "Male" Or My.Settings.mb4Gen = "Male" Or My.Settings.mb5Gen = "Male") Then
                pbxmale3.Visible = True

            ElseIf (My.Settings.mb1Gen = "Female" Or My.Settings.mb2Gen = "Female" Or My.Settings.mb3Gen = "Female" Or My.Settings.mb4Gen = "Female" Or My.Settings.mb5Gen = "Female") Then
                pbxFemale2.Visible = True
                pbxFemale3.Visible = True
            End If
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        Dispose()
    End Sub

    Private Sub pbxFemale_Click(sender As Object, e As EventArgs) Handles pbxFemale.Click
        fQuestionAdd.Show()
        Dispose()
    End Sub

    Private Sub pbxMale_Click(sender As Object, e As EventArgs) Handles pbxMale.Click

    End Sub
End Class