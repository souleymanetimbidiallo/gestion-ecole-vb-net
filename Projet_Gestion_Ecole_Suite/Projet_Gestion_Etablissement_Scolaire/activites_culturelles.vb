Imports System.Data.SqlClient
Public Class activites_culturelles
    Public table As New DataTable
    Private Sub RechercherEvenement_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercherEvenement.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Evenement WHERE ID LIKE '" & RechercherEvenement.Text & "%'"
        Call recherche(dgv_modification_evenement, "Table_Evenement", req)
    End Sub

    Private Sub activites_culturelles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_modification_evenement, "Table_Evenement")
    End Sub

    Private Sub RetourModificationEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourModificationEvenement.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub ModifierModificationEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierModificationEvenement.Click
        If NomModificationEvenement.Text = "" Or DebutModificationEvenement.Text = "" Or FinModificationEvenement.Text = "" Or DureeModificationEvenement.Text = "" Or BudgetModificationEvenement.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_evenement.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet événement ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_evenement.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Evenement SET NOM_EVENEMENT=@nom_evenement,DEBUT_EVENEMENT=@debut_evenement,FIN_EVENEMENT=@fin_evenement,DUREE_EVENEMENT=@duree_evenement,BUDGET_EVENEMENT=@budget_evenement WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom_evenement", NomModificationEvenement.Text)
                cmd.Parameters.AddWithValue("@debut_evenement", DebutModificationEvenement.Value)
                cmd.Parameters.AddWithValue("@fin_evenement", FinModificationEvenement.Value)
                cmd.Parameters.AddWithValue("@duree_evenement", DureeModificationEvenement.Text)
                cmd.Parameters.AddWithValue("@budget_evenement", BudgetModificationEvenement.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_evenement, "Table_Evenement")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        If NomModificationEvenement.Text = "" Or DebutModificationEvenement.Text = "" Or FinModificationEvenement.Text = "" Or DureeModificationEvenement.Text = "" Or BudgetModificationEvenement.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        ElseIf dgv_modification_evenement.SelectedRows.Count > 0 Then
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment modifier cet événement ?", "MODIFICATION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                Dim id As Integer
                id = dgv_modification_evenement.CurrentRow.Cells(0).Value
                Call connecter()
                Dim cmd As New SqlCommand("UPDATE Table_Evenement SET NOM_EVENEMENT=@nom_evenement,DEBUT_EVENEMENT=@debut_evenement,FIN_EVENEMENT=@fin_evenement,DUREE_EVENEMENT=@duree_evenement,BUDGET_EVENEMENT=@budget_evenement WHERE ID=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nom_evenement", NomModificationEvenement.Text)
                cmd.Parameters.AddWithValue("@debut_evenement", DebutModificationEvenement.Value)
                cmd.Parameters.AddWithValue("@fin_evenement", FinModificationEvenement.Value)
                cmd.Parameters.AddWithValue("@duree_evenement", DureeModificationEvenement.Text)
                cmd.Parameters.AddWithValue("@budget_evenement", BudgetModificationEvenement.Text)
                cmd.ExecuteNonQuery()
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_evenement, "Table_Evenement")
                MessageBox.Show("Modification éffectuée avec succès !", "MODIFICATION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

  
    Private Sub dgv_modification_evenement_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_modification_evenement.SelectionChanged
        If dgv_modification_evenement.SelectedRows.Count > 0 Then
            Dim element As DataGridViewRow = dgv_modification_evenement.SelectedRows(0)
            NomModificationEvenement.Text = element.Cells(1).Value
            DebutModificationEvenement.Value = element.Cells(2).Value
            FinModificationEvenement.Value = element.Cells(3).Value
            DureeModificationEvenement.Text = element.Cells(4).Value
            BudgetModificationEvenement.Text = element.Cells(5).Value
        Else
            NomModificationEvenement.Text = ""
            DebutModificationEvenement.Value = Now
            FinModificationEvenement.Value = Now
            DureeModificationEvenement.Text = ""
            BudgetModificationEvenement.Text = ""
        End If
    End Sub

    Private Sub SupprimerModificationEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerModificationEvenement.Click
        If dgv_modification_evenement.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces événement(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_modification_evenement.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Evenement WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_evenement, "Table_Evenement")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        If dgv_modification_evenement.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces événement(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_modification_evenement.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Evenement WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_modification_evenement, "Table_Evenement")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub RetourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourToolStripMenuItem.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub NomModificationEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomModificationEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            DebutModificationEvenement.Focus()
        End If
    End Sub

    Private Sub DebutModificationEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DebutModificationEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            FinModificationEvenement.Focus()
        End If
    End Sub

    Private Sub FinModificationEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FinModificationEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            DureeModificationEvenement.Focus()
        End If
    End Sub

    Private Sub DureeModificationEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DureeModificationEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            BudgetModificationEvenement.Focus()
        End If
    End Sub

    Private Sub BudgetModificationEvenement_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BudgetModificationEvenement.TextChanged
        Call soitEntier(BudgetModificationEvenement)
    End Sub
End Class