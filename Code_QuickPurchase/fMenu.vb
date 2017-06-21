Public Class fMenu

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
        'On choisit le type de liste en fct de la période de l'année'

        If (Date.Now.Month = 4 And Date.Now.Day >= 1 And Date.Now.Day <= 30) Then
            fEaster.Show() 'la fenêtre voulue s'ouvre'
        End If
        If (Date.Now.Month = 6 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fSummer.Show()
        End If
        If (Date.Now.Month = 7 Or Date.Now.Month = 8 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fSummer.Show()
        End If
        If (Date.Now.Month = 9 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fSummer.Show()
        End If
        If (Date.Now.Month = 9 And Date.Now.Day >= 21 And Date.Now.Day <= 30) Then
            fListe_autumn.Show()
        End If
        If (Date.Now.Month = 10 Or Date.Now.Month = 11 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_autumn.Show()
        End If
        If (Date.Now.Month = 12 Or Date.Now.Month = 1 Or Date.Now.Month = 2 And Date.Now.Day = 1 And Date.Now.Day = 31) Then
            fListe_Christmas.Show()
        End If
        If (Date.Now.Month = 3 Or Date.Now.Month = 5 And Date.Now.Day >= 1 And Date.Now.Day <= 31) Then
            fListe_Spring.Show()
        End If
        If (Date.Now.Month = 6 And Date.Now.Day >= 1 And Date.Now.Day <= 21) Then
            fListe_Spring.Show()
        End If
        Dispose()
    End Sub
End Class
