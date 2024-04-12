Public Class Eleve_Inscription
    Dim Str As String

    Private Sub BT_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PHOTO.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PB_PHOTO.Image = Image.FromFile(open.FileName)
                Str = open.FileName
                BT_PHOTO.Text = "Modifier la photo"
            End If
        End Using
    End Sub
    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        Eleve_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub RB_MOIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_MOIS.CheckedChanged
        gm.Visible = True
        ga.Visible = False
    End Sub

    Private Sub RB_ANNEE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ANNEE.CheckedChanged
        gm.Visible = False
        ga.Visible = True
    End Sub
End Class