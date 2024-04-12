Imports System.Data.SqlClient
Public Class modification_professeurs

    Private Sub modification_professeurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_modification_professeurs, "Table_Professeurs")
    End Sub

    Private Sub RechercherModificationProfesseurs_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercherModificationProfesseurs.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Professeurs WHERE ID LIKE '" & RechercherModificationProfesseurs.Text & "%'"
        Call recherche(dgv_modification_professeurs, "Table_Professeurs", req)
    End Sub

    Private Sub RetourModificationProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourModificationProfesseurs.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub AnnulerModificationProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerModificationProfesseurs.Click
        Call viderForm(Me)
    End Sub

    Private Sub ModifierModificationProfesseurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierModificationProfesseurs.Click
        If NomModificationProfesseurs.Text = "" Or PrenomsModificationProfesseurs.Text = "" Or DateModificationProfesseurs.Text = "" Or LieuModificationProfesseurs.Text = "" Or MatiereModificationProfesseurs.Text = "" Or SalaireModificationProfesseurs.Text = "" Or ContactModificationProfesseurs.Text = "" Or QuartierModificationProfesseurs.Text = "" Or ClasseModificationProfesseurs.Text = "" Or NombreClasseModificationProfesseurs.Text = "" Or TauxHoraireModificationProfesseurs.Text = "" Or EmailModificationProfesseurs.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_professeurs.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet professeur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_professeurs.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Professeurs SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,MATIERE=@matiere,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier,CLASSE=@classe,NOMBRE_CLASSE=@nombre_classe,TAUX_HORAIRE=@taux_horaire,EMAIL=@email WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationProfesseurs.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@matiere", MatiereModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@classe", ClasseModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@nombre_classe", NombreClasseModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@taux_horaire", TauxHoraireModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@email", EmailModificationProfesseurs.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_professeurs, "Table_Professeurs")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub MODIFIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFIERToolStripMenuItem.Click
        If NomModificationProfesseurs.Text = "" Or PrenomsModificationProfesseurs.Text = "" Or DateModificationProfesseurs.Text = "" Or LieuModificationProfesseurs.Text = "" Or MatiereModificationProfesseurs.Text = "" Or SalaireModificationProfesseurs.Text = "" Or ContactModificationProfesseurs.Text = "" Or QuartierModificationProfesseurs.Text = "" Or ClasseModificationProfesseurs.Text = "" Or NombreClasseModificationProfesseurs.Text = "" Or TauxHoraireModificationProfesseurs.Text = "" Or EmailModificationProfesseurs.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_professeurs.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet professeur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_professeurs.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Professeurs SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,MATIERE=@matiere,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier,CLASSE=@classe,NOMBRE_CLASSE=@nombre_classe,TAUX_HORAIRE=@taux_horaire,EMAIL=@email WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationProfesseurs.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@matiere", MatiereModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@classe", ClasseModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@nombre_classe", NombreClasseModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@taux_horaire", TauxHoraireModificationProfesseurs.Text)
                cmd.Parameters.AddWithValue("@email", EmailModificationProfesseurs.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_professeurs, "Table_Professeurs")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub dgv_modification_professeurs_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_modification_professeurs.SelectionChanged
        If dgv_modification_professeurs.SelectedRows.Count > 0 Then
            Dim element As DataGridViewRow = dgv_modification_professeurs.SelectedRows(0)
            NomModificationProfesseurs.Text = element.Cells(1).Value
            PrenomsModificationProfesseurs.Text = element.Cells(2).Value
            DateModificationProfesseurs.Value = element.Cells(3).Value
            LieuModificationProfesseurs.Text = element.Cells(4).Value
            MatiereModificationProfesseurs.Text = element.Cells(5).Value
            NombreClasseModificationProfesseurs.Text = element.Cells(6).Value
            ClasseModificationProfesseurs.Text = element.Cells(7).Value
            TauxHoraireModificationProfesseurs.Text = element.Cells(8).Value
            SalaireModificationProfesseurs.Text = element.Cells(11).Value
            ContactModificationProfesseurs.Text = element.Cells(12).Value
            QuartierModificationProfesseurs.Text = element.Cells(13).Value
            EmailModificationProfesseurs.Text = element.Cells(14).Value
        Else
            NomModificationProfesseurs.Text = ""
            PrenomsModificationProfesseurs.Text = ""
            DateModificationProfesseurs.Value = Now
            LieuModificationProfesseurs.Text = ""
            MatiereModificationProfesseurs.Text = ""
            SalaireModificationProfesseurs.Text = ""
            ContactModificationProfesseurs.Text = ""
            QuartierModificationProfesseurs.Text = ""
            ClasseModificationProfesseurs.Text = ""
            NombreClasseModificationProfesseurs.Text = ""
            TauxHoraireModificationProfesseurs.Text = ""
            EmailModificationProfesseurs.Text = ""
        End If
    End Sub

    Private Sub NomModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub PrenomsModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            DateModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub DateModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub LieuModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            MatiereModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub MatiereModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MatiereModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            SalaireModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub SalaireModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalaireModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub ContactModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub ClasseModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ClasseModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            NombreClasseModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub NombreClasseModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreClasseModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            TauxHoraireModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub TauxHoraireModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TauxHoraireModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            EmailModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub EmailModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmailModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ModifierModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub QuartierModificationProfesseurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuartierModificationProfesseurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ClasseModificationProfesseurs.Focus()
        End If
    End Sub

    Private Sub SalaireModificationProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaireModificationProfesseurs.TextChanged
        Call soitEntier(SalaireModificationProfesseurs)
    End Sub

    Private Sub NombreClasseModificationProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreClasseModificationProfesseurs.TextChanged
        Call soitEntier(NombreClasseModificationProfesseurs)
    End Sub

    Private Sub TauxHoraireModificationProfesseurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TauxHoraireModificationProfesseurs.TextChanged
        Call soitEntier(TauxHoraireModificationProfesseurs)
    End Sub
End Class