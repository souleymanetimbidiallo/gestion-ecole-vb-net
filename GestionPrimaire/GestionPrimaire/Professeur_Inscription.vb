Public Class Professeur_Inscription
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
        Professeur_Accueil.Show()
        Me.Close()
    End Sub
End Class