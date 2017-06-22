Public Class fSign
    Enum Gender
        Male
        Female
    End Enum
    Private Sub fSign_Initialize()

    End Sub
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        My.Settings.LastName = txtLast.Text
        My.Settings.Save()
        My.Settings.FirstName = txtFirst.Text
        My.Settings.Save()
        My.Settings.Age = (Convert.ToInt16(txtAge.Text))
        My.Settings.Save()
        My.Settings.Address = txtAd.Text
        My.Settings.Save()
        My.Settings.Mail = txtMail.Text
        My.Settings.Save()
        My.Settings.Username = txtUser.Text
        My.Settings.Save()
        My.Settings.Password = txtPswd.Text
        My.Settings.Save()
        fMembers.Show() 'affiche la fenêtre Membres'
        Dispose() 'on ferme la fenêtre courante'
    End Sub

    Private Sub dteNaiss_ValueChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fQuickpurchase.Show()
        Dispose()
    End Sub

    Private Sub txtLast_TextChanged(sender As Object, e As EventArgs) Handles txtLast.TextChanged

    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub fSign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gender As Array
        gender = System.Enum.GetValues(GetType(Gender))
        For Each gen In gender
            cbxGender.Items.Add(gen)
        Next
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub
End Class