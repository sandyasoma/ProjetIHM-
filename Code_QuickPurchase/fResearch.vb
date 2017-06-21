Public Class fResearch
    Private Sub lblTitre2_Click(sender As Object, e As EventArgs) Handles lblTitre2.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If (txtSearch.Text = "bread") Then
            pbxBraided.Visible = True
            pbxBread.Visible = True
            pbxSoft.Visible = True
            cbBraided.Visible = True
            cbBread.Visible = True
            cbSoft.Visible = True
            cmbQuantity1.Visible = True
            cmbQuantity2.Visible = True
            cmbQuantity3.Visible = True
            btnAdd.Visible = True

        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbBread.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbSoft.CheckedChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class