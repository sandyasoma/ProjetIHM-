Public Class fQuestionAdd
    Dim priceArticle As Double
    Dim price As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fNameList.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        fView.BringToFront()
        fView.Show()



    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fLook.Show()
        Dispose()
    End Sub

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class