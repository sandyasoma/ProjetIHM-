Public Class fLog
    Enum username
        couscous 'sous-secrétaire Anis'
        ananas 'adjointe Anaelle'
        poulet 'admin/ chef de projet/ Boss Sandya'
    End Enum

    Enum mdp
        peugeot
        afterChurch
        curry
    End Enum


    Private Sub fLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = My.Settings.Username
        txtPswd.Text = My.Settings.Password
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If txtUser.Text = My.Settings.Username And txtPswd.Text = My.Settings.Password Then
            fMenu.Show()
            Dispose()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Warning !")

        End If



    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        fQuickpurchase.Show()
        Dispose()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        Dim user As Array
        user = System.Enum.GetValues(GetType(username))
        For Each use In user
            If (txtUser.Text <> use) Then
                MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Warning !")
            End If
        Next

        Dim mp As Array
        mp = System.Enum.GetValues(GetType(mdp))
        For Each mot In mp
            If (txtPswd.Text <> mot) Then
                MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Warning !")
            End If
        Next

    End Sub
End Class