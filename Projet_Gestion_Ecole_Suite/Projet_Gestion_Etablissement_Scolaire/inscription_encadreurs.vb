Imports System.Data.SqlClient
Public Class inscription_encadreurs
    Public str As String
    Private Sub NomInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub PrenomsInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            DateInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub DateInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub LieuInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            FonctionInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub FonctionInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FonctionInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            SalaireInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub SalaireInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalaireInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            EmailInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub EmailInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmailInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactInscriptionEncadreurs.Focus()
        End If
    End Sub
    Private Sub ContactInscriptionEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactInscriptionEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierInscriptionEncadreurs.Focus()
        End If
    End Sub

    Private Sub RetourInscriptionEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourInscriptionEncadreurs.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub NouveauInscriptionEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauInscriptionEncadreurs.Click
        Call viderForm(Me)
        NomInscriptionEncadreurs.Focus()
    End Sub

    Private Sub PhotoInscriptionEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoInscriptionEncadreurs.Click
        Call importerPhoto(str, ImageInscriptionEncadreurs)
    End Sub

    Private Sub EnregistrerInscriptionEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerInscriptionEncadreurs.Click
        Dim genre As String
        If MasculinInscriptionEncadreurs.Checked = True Then
            genre = "Masculin"
        End If
        If FemininInscriptionEncadreurs.Checked = True Then
            genre = "Feminin"
        End If
        If NomInscriptionEncadreurs.Text = "" Or PrenomsInscriptionEncadreurs.Text = "" Or DateInscriptionEncadreurs.Text = "" Or LieuInscriptionEncadreurs.Text = "" Or FonctionInscriptionEncadreurs.Text = "" Or SalaireInscriptionEncadreurs.Text = "" Or EmailInscriptionEncadreurs.Text = "" Or ContactInscriptionEncadreurs.Text = "" Or QuartierInscriptionEncadreurs.Text = "" Or (MasculinInscriptionEncadreurs.Checked = False And FemininInscriptionEncadreurs.Checked = False) Then
            MsgBox("Erreur ! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur !!!")
        Else
            Call connecter()
            Dim cmd As New SqlCommand("INSERT INTO Table_Encadreurs(NOM,PRENOMS,DATE_DE_NAISSANCE,LIEU_DE_NAISSANCE,FONCTION,SALAIRE,EMAIL,CONTACT,QUARTIER,GENRE) VALUES (@nom,@prenoms,@date_naissance,@lieu_naissance,@fonction,@salaire,@email,@contact,@quartier,@genre)", con)
            cmd.Parameters.AddWithValue("@nom", NomInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@prenoms", PrenomsInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@date_naissance", DateInscriptionEncadreurs.Value)
            cmd.Parameters.AddWithValue("@lieu_naissance", LieuInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@fonction", FonctionInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@salaire", SalaireInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@email", EmailInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@contact", ContactInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@quartier", QuartierInscriptionEncadreurs.Text)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.ExecuteNonQuery()
            Call deconnecter()
            MessageBox.Show("Inscription éffectuée avec succès !", "Message de confirmation")
        End If
    End Sub

    Private Sub SalaireInscriptionEncadreurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaireInscriptionEncadreurs.TextChanged
        Call soitEntier(SalaireInscriptionEncadreurs)
    End Sub
End Class