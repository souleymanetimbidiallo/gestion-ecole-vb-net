Imports System.Data.SqlClient
Public Class modification_direction
    Private Sub RetourModificationDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourModificationDirection.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub RechercheModificationDirection_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheModificationDirection.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Direction WHERE ID LIKE '" & RechercheModificationDirection.Text & "%'"
        Call recherche(dgv_modification_direction, "Table_Direction", req)
    End Sub

    Private Sub modification_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_modification_direction, "Table_Direction")
    End Sub

    Private Sub AnnulerModificationDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerModificationDirection.Click
        Call viderForm(Me)
    End Sub

    Private Sub ModifierModificationDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierModificationDirection.Click
        If NomModificationDirection.Text = "" Or PrenomsModificationDirection.Text = "" Or DateModificationDirection.Text = "" Or LieuModificationDirection.Text = "" Or FonctionModificationDirection.Text = "" Or SalaireModificationDirection.Text = "" Or ContactModificationDirection.Text = "" Or QuartierModificationDirection.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_direction.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet directeur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_direction.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Direction SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,FONCTION=@fonction,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationDirection.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationDirection.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationDirection.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationDirection.Text)
                cmd.Parameters.AddWithValue("@fonction", FonctionModificationDirection.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationDirection.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationDirection.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationDirection.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_direction, "Table_Direction")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub dgv_modification_direction_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_modification_direction.SelectionChanged
        If dgv_modification_direction.SelectedRows.Count > 0 Then
            Dim element As DataGridViewRow = dgv_modification_direction.SelectedRows(0)
            NomModificationDirection.Text = element.Cells(1).Value
            PrenomsModificationDirection.Text = element.Cells(2).Value
            DateModificationDirection.Value = element.Cells(3).Value
            LieuModificationDirection.Text = element.Cells(4).Value
            FonctionModificationDirection.Text = element.Cells(5).Value
            SalaireModificationDirection.Text = element.Cells(6).Value
            ContactModificationDirection.Text = element.Cells(8).Value
            QuartierModificationDirection.Text = element.Cells(9).Value
        Else
            NomModificationDirection.Text = ""
            PrenomsModificationDirection.Text = ""
            DateModificationDirection.Value = Now
            LieuModificationDirection.Text = ""
            FonctionModificationDirection.Text = ""
            SalaireModificationDirection.Text = ""
            ContactModificationDirection.Text = ""
            QuartierModificationDirection.Text = ""
        End If
    End Sub

    Private Sub MODIFIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFIERToolStripMenuItem.Click
        If NomModificationDirection.Text = "" Or PrenomsModificationDirection.Text = "" Or DateModificationDirection.Text = "" Or LieuModificationDirection.Text = "" Or FonctionModificationDirection.Text = "" Or SalaireModificationDirection.Text = "" Or ContactModificationDirection.Text = "" Or QuartierModificationDirection.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_direction.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet directeur ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_direction.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Direction SET NOM=@nom,PRENOMS=@prenoms,DATE_DE_NAISSANCE=@date_naissance,LIEU_DE_NAISSANCE=@lieu_naissance,FONCTION=@fonction,SALAIRE=@salaire,CONTACT=@contact,QUARTIER=@quartier WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom", NomModificationDirection.Text)
                cmd.Parameters.AddWithValue("@prenoms", PrenomsModificationDirection.Text)
                cmd.Parameters.AddWithValue("@date_naissance", DateModificationDirection.Value)
                cmd.Parameters.AddWithValue("@lieu_naissance", LieuModificationDirection.Text)
                cmd.Parameters.AddWithValue("@fonction", FonctionModificationDirection.Text)
                cmd.Parameters.AddWithValue("@salaire", SalaireModificationDirection.Text)
                cmd.Parameters.AddWithValue("@contact", ContactModificationDirection.Text)
                cmd.Parameters.AddWithValue("@quartier", QuartierModificationDirection.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_direction, "Table_Direction")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub NomModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            PrenomsModificationDirection.Focus()
        End If
    End Sub

    Private Sub PrenomsModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrenomsModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            DateModificationDirection.Focus()
        End If
    End Sub

    Private Sub DateModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            LieuModificationDirection.Focus()
        End If
    End Sub
    Private Sub LieuModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LieuModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            FonctionModificationDirection.Focus()
        End If
    End Sub

    Private Sub FonctionModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FonctionModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            SalaireModificationDirection.Focus()
        End If
    End Sub
    Private Sub SalaireModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalaireModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            ContactModificationDirection.Focus()
        End If
    End Sub

    Private Sub ContactModificationDirection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactModificationDirection.KeyPress
        If e.KeyChar = Chr(13) Then
            QuartierModificationDirection.Focus()
        End If
    End Sub

    Private Sub SalaireModificationDirection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaireModificationDirection.TextChanged
        Call soitEntier(SalaireModificationDirection)
    End Sub
End Class