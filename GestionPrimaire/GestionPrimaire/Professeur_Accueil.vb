Public Class Professeur_Accueil

    Private Sub BT_INSCRIPTION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INSCRIPTION.Click
        Professeur_Inscription.Show()
        Me.Close()
    End Sub

    Private Sub BT_AUTRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_AUTRE.Click
        Professeur_Autre.Show()
        Me.Close()
    End Sub

    Private Sub BT_LISTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LISTE.Click
        Professeur_listes.Show()
        Me.Close()
    End Sub

    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub
End Class