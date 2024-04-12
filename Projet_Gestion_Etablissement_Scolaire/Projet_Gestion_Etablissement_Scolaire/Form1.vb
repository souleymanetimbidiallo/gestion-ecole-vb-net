Public Class connexion

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using Open As New OpenFileDialog
            Open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If Open.ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(Open.FileName)
                'Str = Open.FileName
            End If
        End Using
    End Sub

    Private Sub connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
