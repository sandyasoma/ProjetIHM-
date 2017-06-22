Public Class fQuestionAdd
    Dim priceArticle As Double
    Dim price As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        fNameList.Show()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        fView.Show()
        Dispose()
    End Sub

    Private Sub fQuestionAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim random As New Random
        priceArticle = random.Next(0, 100)
        Label2.Text = Convert.ToString(priceArticle)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fLook.Show()
        Dispose()
    End Sub
End Class