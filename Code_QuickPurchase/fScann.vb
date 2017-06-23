Public Class fScann

    'on retourne a la fenêtre chercher
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fSearch.Show()
        Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub fScann_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'ici par défaut la recherche prendra "bread" et on selectionne "Soft bread" dans la listbox Article
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        fResearch.Show()
        fResearch.txtSearch.Text = "bread"
        fResearch.lstBread.SelectedItem = "Soft bread"
        Dispose()
    End Sub
End Class