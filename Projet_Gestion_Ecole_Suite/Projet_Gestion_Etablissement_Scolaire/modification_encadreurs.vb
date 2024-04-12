Imports System.Data.SqlClient
Public Class modification_encadreurs
    Private Sub modification_encadreurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        remplirDataGridView(dgv_modification_encadreurs, "Table_Encadreurs")
    End Sub
    Private Sub RechercheModificationEncadreurs_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheModificationEncadreurs.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Encadreurs WHERE ID LIKE '" & RechercheModificationEncadreurs.Text & "%'"
        Call recherche(dgv_modification_encadreurs, "Table_Encadreurs", req)
    End Sub

    Private Sub RetourModificationEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourModificationEncadreurs.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub AnnulerModificationEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerModificationEncadreurs.Click
        Call viderForm(Me)
    End Sub

    Private Sub ModifierModificationEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierModificationEncadreurs.Click
        If NomModificationEncadreurs.Text = "" Or PrenomsModificationEncadreurs.Text = "" Or DateModificationEncadreurs.Text = "" Or LieuModificationEncadreurs.Text = "" Or FonctionModificationEncadreurs.Text = "" Or SalaireModificationEncadreurs.Text = "" Or ContactModificationEncadreurs.Text = "" Or QuartierModificationEncadreurs.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_encadreurs.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet encadreur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_encadreurs.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Encadreurs SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,FONCTION=@fonction,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationEncadreurs.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@fonction", FonctionModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationEncadreurs.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_encadreurs, "Table_Encadreurs")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub MODIFIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFIERToolStripMenuItem.Click
        If NomModificationEncadreurs.Text = "" Or PrenomsModificationEncadreurs.Text = "" Or DateModificationEncadreurs.Text = "" Or LieuModificationEncadreurs.Text = "" Or FonctionModificationEncadreurs.Text = "" Or SalaireModificationEncadreurs.Text = "" Or ContactModificationEncadreurs.Text = "" Or QuartierModificationEncadreurs.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_encadreurs.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet encadreur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_encadreurs.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Encadreurs SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,FONCTION=@fonction,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationEncadreurs.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@fonction", FonctionModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationEncadreurs.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationEncadreurs.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_encadreurs, "Table_Encadreurs")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub
    Private Sub dgv_modification_encadreurs_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_modification_encadreurs.SelectionChanged
        If dgv_modification_encadreurs.SelectedRows.Count > 0 Then
            Dim element As DataGridViewRow = dgv_modification_encadreurs.SelectedRows(0)
            NomModificationEncadreurs.Text = element.Cells(1).Value
            PrenomsModificationEncadreurs.Text = element.Cells(2).Value
            DateModificationEncadreurs.Value = element.Cells(3).Value
            LieuModificationEncadreurs.Text = element.Cells(4).Value
            FonctionModificationEncadreurs.Text = element.Cells(5).Value
            SalaireModificationEncadreurs.Text = element.Cells(6).Value
            ContactModificationEncadreurs.Text = element.Cells(8).Value
            QuartierModificationEncadreurs.Text = element.Cells(9).Value
        Else
            NomModificationEncadreurs.Text = ""
            PrenomsModificationEncadreurs.Text = ""
            DateModificationEncadreurs.Value = Now
            LieuModificationEncadreurs.Text = ""
            FonctionModificationEncadreurs.Text = ""
            SalaireModificationEncadreurs.Text = ""
            ContactModificationEncadreurs.Text = ""
            QuartierModificationEncadreurs.Text = ""
        End If
    End Sub

    Private Sub NomModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub PrenomsModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            DateModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub DateModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub LieuModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            FonctionModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub FonctionModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FonctionModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            SalaireModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub SalaireModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalaireModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub ContactModificationEncadreurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactModificationEncadreurs.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierModificationEncadreurs.Focus()
        End If
    End Sub

    Private Sub SalaireModificationEncadreurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaireModificationEncadreurs.TextChanged
        Call soitEntier(SalaireModificationEncadreurs)
    End Sub

    Private Sub RechercheModificationEncadreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheModificationEncadreurs.Click

    End Sub
End Class