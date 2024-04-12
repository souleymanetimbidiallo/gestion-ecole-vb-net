Public Class Eleve_Autre
    Dim Str As String
    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        Eleve_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_CONSULTATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CONSULTATION.Click
        DataGridView1.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub BT_MODIFICATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFICATION.Click
        Panel1.Visible = True
        DataGridView1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub BT_MODIFIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFIER.Click
        Panel1.Visible = False
        MsgBox("Les informations de l'eleve ont ete modifie avec succes !", 64, "Modification")
    End Sub
    Private Sub PAYEMENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYEMENT.Click
        Panel2.Visible = True
        DataGridView1.Visible = False
        Panel1.Visible = False
        BT_VALIDER.Visible = False
    End Sub

    Private Sub BT_VALIDER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VALIDER.Click
        Panel2.Visible = False
        MsgBox("Le payement de la scolarite de l'eleve ont ete effectue avec succes !", 64, "Payement")
    End Sub
    Private Sub BT_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PHOTO.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PB_PHOTO.Image = Image.FromFile(open.FileName)
                Str = open.FileName
            End If
        End Using
    End Sub

    Private Sub BT_SUPPRESSION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SUPPRESSION.Click
        If MsgBox("Souhaitez-vous vraiment supprimer les informations de cet eleve ?", 36, "Quitter") = MsgBoxResult.Yes Then
            MsgBox("Les informations de l'eleve ont ete supprime avec succes !", 64, "Suppression")
        End If
    End Sub

    Private Sub RB_MOIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_MOIS.CheckedChanged
        gm.Visible = True
        ga.Visible = False
        BT_VALIDER.Visible = True
    End Sub

    Private Sub RB_ANNEE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ANNEE.CheckedChanged
        gm.Visible = False
        ga.Visible = True
        BT_VALIDER.Visible = True
    End Sub


End Class