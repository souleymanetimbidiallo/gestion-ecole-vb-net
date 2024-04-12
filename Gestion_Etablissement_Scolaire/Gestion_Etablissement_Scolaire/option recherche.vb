Public Class option_recherche

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
    Public Sub tri(ByVal Texte_recherche As ToolStripTextBox)
        If nom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE NOM LIKE'%" & Texte_recherche.Text & "%'"
            profile_personnel_direction.filtre(chaine_recherche)
        ElseIf prenom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE [PRENOM(S)] LIKE'%" & Texte_recherche.Text & "%'"
            profile_personnel_direction.filtre(chaine_recherche)
        ElseIf genre.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE GENRE LIKE'%" & Texte_recherche.Text & "%'"
            profile_personnel_direction.filtre(chaine_recherche)
        ElseIf fonction.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE QUARTIER LIKE'%" & Texte_recherche.Text & "%'"
            profile_personnel_direction.filtre(chaine_recherche)
        Else
            MsgBox("VEUILLEZ CHOISIR UNE OPTION DE RECHERCHE", vbOK + MsgBoxStyle.Critical, "ERREUR")
            'recherche.Text = ""
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nom.Checked = True Then
            profile_personnel_direction.recherche_t.Text = "Saisir ici le nom"
            Me.Hide()
        ElseIf prenom.Checked = True Then
            profile_personnel_direction.recherche_t.Text = "Saisir ici le prenom"
            Me.Hide()
        ElseIf genre.Checked = True Then
            profile_personnel_direction.recherche_t.Text = "Saisir ici le genre"
            Me.Hide()
        Else
            profile_personnel_direction.recherche_t.Text = "saisir ici la fonction"
            Me.Hide()
        End If
    End Sub

    Private Sub option_recherche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class