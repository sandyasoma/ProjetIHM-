Public Class fSign
    Enum Gender
        Male
        Female
    End Enum
    Private Sub fSign_Initialize()

    End Sub
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        If (txtAge.Text = "") Then
            MsgBox("Please, enter fields with a * !", MsgBoxStyle.Critical, "Warning !")
        Else
            My.Settings.LastName = txtLast.Text

            My.Settings.FirstName = txtFirst.Text
            My.Settings.Age = (Convert.ToInt16(txtAge.Text))
            My.Settings.Address = txtAd.Text

            My.Settings.Mail = txtMail.Text

            My.Settings.Username = txtUser.Text

            My.Settings.Password = txtPswd.Text
            If (My.Settings.Age < 18) Then
                MsgBox("You are MINOR !", MsgBoxStyle.Critical, "Warning !")
            Else
                fMembers.Show() 'affiche la fenêtre Membres'
                Dispose() 'on ferme la fenêtre courante'
            End If
        End If

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