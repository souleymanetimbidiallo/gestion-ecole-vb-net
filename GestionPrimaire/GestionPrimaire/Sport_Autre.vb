Public Class Sport_Autre
    Dim Str As String
    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        Sport_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_CONSULTATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CONSULTATION.Click
        DataGridView1.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub BT_MODIFICATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFICATION.Click
        Panel1.Visible = True
        DataGridView1.Visible = False
    End Sub

    Private Sub BT_MODIFIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFIER.Click
        Panel1.Visible = False
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
End Class