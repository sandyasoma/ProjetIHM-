﻿Public Class fListe_Spring
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxSpring.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fMenu.Show()
        Dispose()
    End Sub

    Private Sub pbxSearch_Click(sender As Object, e As EventArgs) Handles pbxSearch.Click
        fSearch.Show()
        Dispose()
    End Sub
End Class