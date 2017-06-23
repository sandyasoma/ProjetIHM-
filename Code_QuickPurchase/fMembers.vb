Public Class fMembers
    Enum Genders
        Male
        Female
    End Enum
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitre2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub fMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'permet de choisir entre "Female" et "Male" dans les comboBox
        Dim gende As Array
        gende = System.Enum.GetValues(GetType(Genders))
        For Each gen In gende
            cmbGender1.Items.Add(gen)
            cmbGender2.Items.Add(gen)
            cmbGender3.Items.Add(gen)
            cmbGender4.Items.Add(gen)
            cmbGender5.Items.Add(gen)

        Next
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        'on affecte au valeur par défaut de la config persistante les membres de la famille
        My.Settings.mb1Gen = cmbGender1.Text
        My.Settings.mb2Gen = cmbGender2.Text
        My.Settings.mb3Gen = cmbGender3.Text
        My.Settings.mb4Gen = cmbGender4.Text
        My.Settings.mb5Gen = cmbGender5.Text

        'on convertit les âges entrés par en entier
        If (txtAgeMb1.Text <> "") Then
            My.Settings.mb1Age = (Convert.ToInt16(txtAgeMb1.Text))
        End If
        If (txtAgeMb2.Text <> "") Then
            My.Settings.mb1Age = (Convert.ToInt16(txtAgeMb2.Text))
        End If
        If (txtAgeMb3.Text <> "") Then
            My.Settings.mb1Age = (Convert.ToInt16(txtAgeMb3.Text))
        End If
        If (txtAgeMb4.Text <> "") Then
            My.Settings.mb1Age = (Convert.ToInt16(txtAgeMb4.Text))
        End If
        If (txtAgeMb5.Text <> "") Then
            My.Settings.mb1Age = (Convert.ToInt16(txtAgeMb5.Text))
        End If
        fMenu.Show()
        Dispose()
    End Sub

    Private Sub cmbGender1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender1.SelectedIndexChanged

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fSign.Show()
        Dispose()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblAgeMb2.Click

    End Sub
End Class