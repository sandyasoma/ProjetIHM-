Public Class fQuickpurchase
    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub lblWelcome2_Click(sender As Object, e As EventArgs) Handles lblWelcome2.Click

    End Sub

    Private Sub pbxLogo_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click

    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        fSign.Show() 'on ouvre la fenêtre fSign'

        'pas de Dispose() car on ne ferme jamais la fenêtre principale sinon le prg s'arrête'
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        fLog.Show() 'on ouvre la fenêtre fLog'
        'pas de Dispose() car on ne ferme jamais la fenêtre principale sinon le prg s'arrête'
    End Sub

    Private Sub fQuickpurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
