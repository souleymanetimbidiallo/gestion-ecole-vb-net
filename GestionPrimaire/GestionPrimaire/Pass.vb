Public Class Pass

    Private Sub BT_CONNECT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CONNECT.Click
        Verification()
    End Sub
    Sub Verification()
        If TXT_LOGIN.Text = "souleymane" And TXT_MDP.Text = "diallo" Then
            MenuPrincipal.Show()
            Me.Close()
        ElseIf TXT_LOGIN.Text = "" Or TXT_MDP.Text = "" Then
            MsgBox("Veuillez remplir les champs vides  !", MsgBoxStyle.Critical + vbOKOnly, "Erreur")
        Else
            MsgBox("Nom d'utilisateur ou mot de passe incorrecte", MsgBoxStyle.Critical + vbOKOnly, "Erreur")

        End If
        TXT_LOGIN.Clear()
        TXT_MDP.Clear()
        TXT_LOGIN.Focus()
    End Sub

    Private Sub Pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class