﻿Public Class fMenu

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbltestDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        fView.Show()
        Dispose()
    End Sub

    Private Sub fMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        fNameList.Show()
        Dispose()
    End Sub

    Private Sub btnLook_Click(sender As Object, e As EventArgs) Handles btnLook.Click
        fLook.Show()
        Dispose()
    End Sub
End Class
