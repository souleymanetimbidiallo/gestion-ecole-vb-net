Imports System.Data.SqlClient
Public Class inscription_professeurs
    Public str As String
    Public taux_horaire As Integer
    Public salaire_mensuel As Integer
    Public nombre_heures As Integer
    Public valeur_traitement As Integer
    Public genre, traitement As String
    Private Sub PhotoInscriptionProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoInscriptionProfesseurs.Click
        Call importerPhoto(str, ImageInscriptionProfesseurs)
    End Sub

    Private Sub RetourInscriptionProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourInscriptionProfesseurs.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub NouveauInscriptionProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauInscriptionProfesseurs.Click
        Call viderForm(Me)
        NomInscriptionProfesseurs.Focus()
        SalaireMensuelProfesseurs.Text = "0 GNF"
        ContactInscriptionProfesseurs.Text = "(+224) "
    End Sub

    Private Sub EnregistrerInscriptionProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerInscriptionProfesseurs.Click
        If MasculinInscriptionProfesseurs.Checked = True Then
            genre = "Masculin"
        End If
        If FemininInscriptionProfesseurs.Checked = True Then
            genre = "Feminin"
        End If
        If NomInscriptionProfesseurs.Text = "" Or PrenomsInscriptionProfesseurs.Text = "" Or DateInscriptionProfesseurs.Text = "" Or LieuInscriptionProfesseurs.Text = "" Or MatiereInscriptionProfesseurs.Text = "" Or NombreClasseInscriptionProfesseurs.Text = "" Or ClasseInscriptionProfesseurs.Text = "" Or TauxHoraireInscriptionProfesseurs.Text = "" Or NombreHeuresInscriptionProfesseurs.Text = "" Or (MasculinInscriptionProfesseurs.Checked = False And FemininInscriptionProfesseurs.Checked = False) Or (OuiInscriptionProfesseurs.Checked = False And NonInscriptionProfesseurs.Checked = False) Or ContactInscriptionProfesseurs.Text = "" Or QuartierInscriptionProfesseurs.Text = "" Or EmailInscriptionProfesseurs.Text = "" Then
            MsgBox("Erreur ! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur !!!")
        Else
            Call connecter()
            Dim cmd As New SqlCommand("INSERT INTO Table_Professeurs(NOM,PRENOMS,DATE_DE_NAISSANCE,LIEU_DE_NAISSANCE,MATIERE,NOMBRE_CLASSE,CLASSE,TAUX_HORAIRE,NOMBRE_HEURE,GENRE,SALAIRE,CONTACT,QUARTIER,EMAIL) VALUES (@nom,@prenoms,@date_naissance,@lieu_naissance,@matiere,@nombre_classe,@classe,@taux_horaire,@nombre_heure,@genre,@salaire,@contact,@quartier,@email)", con)
            cmd.Parameters.AddWithValue("@nom", NomInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@prenoms", PrenomsInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@date_naissance", DateInscriptionProfesseurs.Value)
            cmd.Parameters.AddWithValue("@lieu_naissance", LieuInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@matiere", MatiereInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@nombre_classe", NombreClasseInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@classe", ClasseInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@taux_horaire", TauxHoraireInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@nombre_heure", NombreHeuresInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.Parameters.AddWithValue("@salaire", salaire_mensuel)
            cmd.Parameters.AddWithValue("@contact", ContactInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@quartier", QuartierInscriptionProfesseurs.Text)
            cmd.Parameters.AddWithValue("@email", EmailInscriptionProfesseurs.Text)
            cmd.ExecuteNonQuery()
            Call deconnecter()
            MessageBox.Show("Inscription éffectuée avec succès !", "Message de confirmation")
        End If
    End Sub

    Private Sub inscription_professeurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SalaireMensuelProfesseurs.Text = salaire_mensuel & " GNF "
    End Sub
    Private Sub ValeurInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValeurInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactInscriptionProfesseurs.Focus()
        End If
    End Sub
    Private Sub ValeurInscriptionProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValeurInscriptionProfesseurs.TextChanged
        Call soitEntier(ValeurInscriptionProfesseurs)
        taux_horaire = Val(TauxHoraireInscriptionProfesseurs.Text)
        nombre_heures = Val(NombreHeuresInscriptionProfesseurs.Text)
        valeur_traitement = Val(ValeurInscriptionProfesseurs.Text)
        salaire_mensuel = (taux_horaire * nombre_heures * 4) + valeur_traitement
        SalaireMensuelProfesseurs.Text = salaire_mensuel & " GNF "
    End Sub
    Private Sub NonInscriptionProfesseurs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NonInscriptionProfesseurs.Click
        If NonInscriptionProfesseurs.Checked = True Then
            ValeurMensuelle.Enabled = False
            ValeurInscriptionProfesseurs.Enabled = False
        End If
        taux_horaire = Val(TauxHoraireInscriptionProfesseurs.Text)
        nombre_heures = Val(NombreHeuresInscriptionProfesseurs.Text)
        salaire_mensuel = (taux_horaire * nombre_heures * 4)
        SalaireMensuelProfesseurs.Text = salaire_mensuel & " GNF "
    End Sub

    Private Sub NomInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub PrenomsInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            DateInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub DateInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub LieuInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            MatiereInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub MatiereInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MatiereInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            NombreClasseInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub NombreClasseInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreClasseInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ClasseInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub ClasseInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ClasseInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            TauxHoraireInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub TauxHoraireInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TauxHoraireInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            NombreHeuresInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub NombreHeuresInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreHeuresInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            MasculinInscriptionProfesseurs.Focus()
        End If
    End Sub
    Private Sub MasculinInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MasculinInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            NonInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub NonInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NonInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub ContactInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub QuartierInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuartierInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            EmailInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub EmailInscriptionProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmailInscriptionProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            EnregistrerInscriptionProfesseurs.Focus()
        End If
    End Sub

    Private Sub NombreClasseInscriptionProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreClasseInscriptionProfesseurs.TextChanged
        Call soitEntier(NombreClasseInscriptionProfesseurs)
    End Sub

    Private Sub TauxHoraireInscriptionProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TauxHoraireInscriptionProfesseurs.TextChanged
        Call soitEntier(TauxHoraireInscriptionProfesseurs)
    End Sub

    Private Sub NombreHeuresInscriptionProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreHeuresInscriptionProfesseurs.TextChanged
        Call soitEntier(NombreHeuresInscriptionProfesseurs)
    End Sub

    Private Sub OuiInscriptionProfesseurs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OuiInscriptionProfesseurs.Click
        If OuiInscriptionProfesseurs.Checked = True Then
            ValeurMensuelle.Enabled = True
            ValeurInscriptionProfesseurs.Enabled = True
        End If
    End Sub
End Class