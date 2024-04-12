Imports System.Data.SqlClient
Public Class suppression_encadreurs
    Public table As New DataTable

    Private Sub suppression_encadreurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        remplirDataGridView(dgv_suppression_encadreurs, "Table_Encadreurs")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub RechercheSuppressionEncadreurs_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheSuppressionEncadreurs.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Encadreurs WHERE ID LIKE '" & RechercheSuppressionEncadreurs.Text & "%'"
        Call recherche(dgv_suppression_encadreurs, "Table_Encadreurs", req)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If dgv_suppression_encadreurs.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces encadreur(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_suppression_encadreurs.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Encadreurs WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_suppression_encadreurs, "Table_Encadreurs")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub SUPPRIMERDEFINITIVEMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPRIMERDEFINITIVEMENTToolStripMenuItem.Click
        If dgv_suppression_encadreurs.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces encadreur(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_suppression_encadreurs.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Encadreurs WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_suppression_encadreurs, "Table_Encadreurs")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub
End Class