Imports System.Data.SqlClient
Public Class inscription_direction
    Public str As String
    Private Sub RetourInscriptionDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourInscriptionDirection.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub NouveauInscriptionDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauInscriptionDirection.Click
        Call viderForm(Me)
        NomInscriptionDirection.Focus()
    End Sub

    Private Sub EnregistrerInscriptionDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerInscriptionDirection.Click
        Dim genre As String
        If MasculinInscriptionDirection.Checked = True Then
            genre = "Masculin"
        End If
        If FemininInscriptionDirection.Checked = True Then
            genre = "Feminin"
        End If
        If NomInscriptionDirection.Text = "" Or PrenomsInscriptionDirection.Text = "" Or DateInscriptionDirection.Text = "" Or LieuInscriptionDirection.Text = "" Or FonctionInscriptionDirection.Text = "" Or SalaireInscriptionDirection.Text = "" Or EmailInscriptionDirection.Text = "" Or ContactInscriptionDirection.Text = "" Or QuartierInscriptionDirection.Text = "" Or (MasculinInscriptionDirection.Checked = False And FemininInscriptionDirection.Checked = False) Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur !!!")
        Else
            Call connecter()
            Dim cmd As New SqlCommand("INSERT INTO Table_Direction(NOM,PRENOMS,DATE_DE_NAISSANCE,LIEU_DE_NAISSANCE,FONCTION,SALAIRE,EMAIL,CONTACT,QUARTIER,GENRE) VALUES (@nom,@prenoms,@date_naissance,@lieu_naissance,@fonction,@salaire,@email,@contact,@quartier,@genre)", con)
            cmd.Parameters.AddWithValue("@nom", NomInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@prenoms", PrenomsInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@date_naissance", DateInscriptionDirection.Value)
            cmd.Parameters.AddWithValue("@lieu_naissance", LieuInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@fonction", FonctionInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@salaire", SalaireInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@email", EmailInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@contact", ContactInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@quartier", QuartierInscriptionDirection.Text)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.ExecuteNonQuery()
            Call deconnecter()
            MessageBox.Show("Inscription éffectuée avec succès !", "Message de confirmation")
        End If
    End Sub

    Private Sub NomInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub PrenomsInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            DateInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub DateInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub LieuInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            FonctionInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub FonctionInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FonctionInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            SalaireInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub SalaireInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalaireInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            EmailInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub EmailInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmailInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactInscriptionDirection.Focus()
        End If
    End Sub

    Private Sub ContactInscriptionDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactInscriptionDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierInscriptionDirection.Focus()
        End If
    End Sub
    Private Sub PhotoInscriptionDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoInscriptionDirection.Click
        Call importerPhoto(str, ImageInscriptionDirection)
    End Sub

    Private Sub SalaireInscriptionDirection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaireInscriptionDirection.TextChanged
        Call soitEntier(SalaireInscriptionDirection)
    End Sub
End Class