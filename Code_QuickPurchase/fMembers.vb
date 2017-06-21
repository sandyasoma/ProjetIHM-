Public Class fMembers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitre2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dteNaiss2.ValueChanged

    End Sub

    Private Sub fMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        fMenu.Show()
        Dispose()
    End Sub

    Private Sub cmbGender1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender1.SelectedIndexChanged

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fSign.Show()
        Dispose()
    End Sub
End Class