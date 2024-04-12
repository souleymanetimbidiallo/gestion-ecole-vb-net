Imports System.Data.SqlClient
Public Class suppression_direction
    Public table As New DataTable
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheSuppressionDirection.TextChanged
        Dim req As String
        req = "SELECT * FROM Table_Direction WHERE ID LIKE '" & RechercheSuppressionDirection.Text & "%'"
        Call recherche(dgv_suppression_direction, "Table_Direction", req)
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If dgv_suppression_direction.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces directeur(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_suppression_direction.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Direction WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_suppression_direction, "Table_Direction")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
       If dgv_suppression_direction.SelectedRows.Count > 0 Then
            Call connecter()
            Dim rep As MsgBoxResult
            rep = MessageBox.Show("Souhaitez-vous vraiment supprimer de façon définitive cet/ces directeur(s) ?", "SUPPRESSION", MessageBoxButtons.YesNo)
            If rep = MsgBoxResult.Yes Then
                For Each element As DataGridViewRow In dgv_suppression_direction.SelectedRows
                    Dim cmd As New SqlCommand("DELETE FROM Table_Direction WHERE ID=@id", con)
                    Dim id As Integer = element.Cells(0).Value
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    Dim confirme As New SqlDataAdapter(cmd)
                    confirme.Fill(table)
                Next
                Call deconnecter()
                Call remplirDataGridView(dgv_suppression_direction, "Table_Direction")
                MessageBox.Show("Suppression éffectuée avec succès !", "SUPPRESSION REUSSIE")
            End If
        Else
            MsgBox("Erreur ! Veuillez sélectionner au moins une ligne dans la grille.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub suppression_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_suppression_direction, "Table_Direction")
    End Sub
End Class