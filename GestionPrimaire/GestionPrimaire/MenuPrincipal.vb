Public Class MenuPrincipal

    Private Sub BT_ELEVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ELEVE.Click
        Eleve_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_PERSONNEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PERSONNEL.Click
        Direction_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_PROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PROF.Click
        Professeur_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_ENCADREUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ENCADREUR.Click
        Encadreur_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_CULTURELLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CULTURELLE.Click
        Culture_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_SPORTIVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SPORTIVE.Click
        Sport_Accueil.Show()
        Me.Close()
    End Sub
End Class