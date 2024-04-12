Public Class Encadreur_Accueil
    Private Sub BT_INSCRIPTION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INSCRIPTION.Click
        Encadreur_Inscription.Show()
        Me.Close()
    End Sub

    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BT_AUTRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_AUTRE.Click
        Encadreur_Autre.Show()
        Me.Close()
    End Sub

    Private Sub BT_LISTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LISTE.Click
        Encadreur_Listes.Show()
        Me.Close()
    End Sub
End Class