Imports System.Data.SqlClient
Public Class enregistrement_evenement
    Public str As String
    Private Sub RetourEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourEvenement.Click
        Me.Close()
        menu_general.Show()
    End Sub

    Private Sub NouveauEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauEvenement.Click
        Call viderForm(Me)
        NomEvenement.Focus()
    End Sub

    Private Sub SauvegarderEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SauvegarderEvenement.Click
        If NomEvenement.Text = "" Or DebutEvenement.Text = "" Or FinEvenement.Text = "" Or DureeEvenement.Text = "" Or BudgetEvenement.Text = "" Then
            MsgBox("Erreur! Tous les champs sont obligatoires.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur !!!")
        Else
            Call connecter()
            Dim cmd As New SqlCommand("INSERT INTO Table_Evenement(NOM_EVENEMENT,DEBUT_EVENEMENT,FIN_EVENEMENT,DUREE_EVENEMENT,BUDGET_EVENEMENT) VALUES (@nom_evenement,@debut_evenement,@fin_evenement,@duree_evenement,@budget_evenement)", con)
            cmd.Parameters.AddWithValue("@nom_evenement", NomEvenement.Text)
            cmd.Parameters.AddWithValue("@debut_evenement", DebutEvenement.Value)
            cmd.Parameters.AddWithValue("@fin_evenement", FinEvenement.Value)
            cmd.Parameters.AddWithValue("@duree_evenement", DureeEvenement.Text)
            cmd.Parameters.AddWithValue("@budget_evenement", BudgetEvenement.Text)
            cmd.ExecuteNonQuery()
            Call deconnecter()
            MessageBox.Show("Enrégistrement éffectuée avec succès !", "Message de confirmation")
        End If
    End Sub

    Private Sub PhotoEvenement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoEvenement.Click
        Call importerPhoto(str, ImageEvenement)
    End Sub

    Private Sub enregistrement_evenement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_evenement, "Table_Evenement")
    End Sub

    Private Sub NomEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            DebutEvenement.Focus()
        End If
    End Sub

    Private Sub DebutEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DebutEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            FinEvenement.Focus()
        End If
    End Sub

    Private Sub FinEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FinEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            DureeEvenement.Focus()
        End If
    End Sub

    Private Sub DureeEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DureeEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            BudgetEvenement.Focus()
        End If
    End Sub

    Private Sub BudgetEvenement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BudgetEvenement.KeyPress
        If e.KeyChar = Chr(13) Then
            NouveauEvenement.Focus()
        End If
    End Sub
End Class