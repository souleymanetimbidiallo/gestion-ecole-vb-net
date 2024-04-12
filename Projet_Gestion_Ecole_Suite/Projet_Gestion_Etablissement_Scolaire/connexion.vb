Public Class connexion
    Public str As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using Open As New OpenFileDialog
            Open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If Open.ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(Open.FileName)
                Str = Open.FileName
            End If
        End Using
    End Sub
    Private Sub NomAdministrateur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomAdministrateur.KeyPress
        If e.KeyChar = Chr(13) Then
            MotDePasse.Focus()
        End If
    End Sub

   

    Private Sub SeConnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeConnecter.Click
        If NomAdministrateur.Text = "" Or MotDePasse.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Champ Vide")
            NomAdministrateur.Clear()
            MotDePasse.Clear()
            NomAdministrateur.Focus()
        ElseIf NomAdministrateur.Text <> "djimsbarry04@gmail.com" And MotDePasse.Text <> "$@frique.10$" Then
            MsgBox("Erreur! Saisie Invalide.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
            NomAdministrateur.Clear()
            MotDePasse.Clear()
            NomAdministrateur.Focus()
        ElseIf NomAdministrateur.Text <> "djimsbarry04@gmail.com" And MotDePasse.Text = "$@frique.10$" Then
            MsgBox("Erreur! Nom d'administrateur incorrect.", MsgBoxStyle.Critical + vbOKOnly, "Message d'erreur au niveau du nom d'administrateur")
            NomAdministrateur.Clear()
            MotDePasse.Clear()
            NomAdministrateur.Focus()
        ElseIf NomAdministrateur.Text = "djimsbarry04@gmail.com" And MotDePasse.Text <> "$@frique.10$" Then
            MsgBox("Erreur! Mot de passe incorrect.", MsgBoxStyle.Critical + vbOKOnly, "Message d'erreur au niveau du mot de passe")
            MotDePasse.Clear()
            MotDePasse.Focus()
        ElseIf NomAdministrateur.Text = "djimsbarry04@gmail.com" And MotDePasse.Text = "$@frique.10$" Then
            BarreDeProgression.Value = 0
            Chargement.Visible = True
            BarreDeProgression.Visible = True
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub MotDePasse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MotDePasse.KeyPress
        If e.KeyChar = Chr(13) Then
            SeConnecter.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If BarreDeProgression.Value = 100 Then
            Timer1.Enabled = False
            NomAdministrateur.Clear()
            MotDePasse.Clear()
            NomAdministrateur.Focus()
            menu_general.Show()
            BarreDeProgression.Visible = False
            Chargement.Visible = False

        Else
            BarreDeProgression.Value = BarreDeProgression.Value + 1
        End If
    End Sub
End Class
