Public Class Culture_Listes
    Private Sub BT_CLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CLOSE.Click
        aff_fenetre(Culture_Accueil)
    End Sub
    Public Sub aff_fenetre(ByVal fenetre As Form)
        fenetre.Show()
        Me.Close()
    End Sub
End Class