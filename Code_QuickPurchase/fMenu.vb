Public Class fMenu

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbltestDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        fView.Show()
        fView.BringToFront()
    End Sub


    Private Sub fMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = My.Settings.Username 'permet de mettre le pseudo de l'utilisateur (admin) par défaut
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        fNameList.Show()
        fNameList.BringToFront()

    End Sub

    Private Sub btnLook_Click(sender As Object, e As EventArgs) Handles btnLook.Click
        fLook.Show()
        fLook.BringToFront()
    End Sub
End Class
