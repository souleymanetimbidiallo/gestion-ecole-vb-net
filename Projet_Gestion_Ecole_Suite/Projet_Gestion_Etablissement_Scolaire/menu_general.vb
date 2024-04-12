Imports System.Data.SqlClient
Public Class menu_general

    Private Sub menu_general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Text = "" Then
            Label1.Text = "GROUPE SCOLAIRE AFRIQUE ELITES"
        ElseIf Label1.Text = "GROUPE SCOLAIRE AFRIQUE ELITES" Then
            Label1.Text = ""
        End If
    End Sub
    Private Sub NouvelleInscriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleInscriptionToolStripMenuItem.Click
        inscription_direction.Show()
    End Sub

    Private Sub ConsultationGénéraleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationGénéraleToolStripMenuItem.Click
        consultation_direction1.Show()
    End Sub

    Private Sub ModificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem.Click
        modification_direction.Show()
    End Sub

    Private Sub SuppressionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionToolStripMenuItem.Click
        suppression_direction.Show()
    End Sub

    Private Sub NouvelleInscriptionToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleInscriptionToolStripMenuItem3.Click
        inscription_encadreurs.Show()
    End Sub

    Private Sub ConsultationGénéraleToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationGénéraleToolStripMenuItem2.Click
        consultation_encadreurs1.Show()
    End Sub

    Private Sub ModificationToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem3.Click
        modification_encadreurs.Show()
    End Sub

    Private Sub SuppressionToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionToolStripMenuItem3.Click
        suppression_encadreurs.Show()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        Dim rep As MsgBoxResult
        rep = MessageBox.Show("Souhaitez-vous vraiment vous déconnecter ?", "DECONNEXION", MessageBoxButtons.YesNo)
        If rep = MsgBoxResult.Yes Then
            Me.Close()
            connexion.Show()
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Dim rep As MsgBoxResult
        rep = MessageBox.Show("Souhaitez-vous vraiment quitter l'application ?", "FERMETURE DE L'APPLICATION", MessageBoxButtons.YesNo)
        If rep = MsgBoxResult.Yes Then
            Me.Close()
            connexion.Close()
            End
        End If
    End Sub

    Private Sub NouvelleInscriptionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleInscriptionToolStripMenuItem1.Click
        inscription_professeurs.Show()
    End Sub

    Private Sub ConsultationGénéraleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationGénéraleToolStripMenuItem1.Click
        consultation_professeurs1.Show()
    End Sub

    Private Sub ModificationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem1.Click
        modification_professeurs.Show()
    End Sub

    Private Sub SuppressionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionToolStripMenuItem1.Click
        suppression_professeurs.Show()
    End Sub

    Private Sub NouvelleInscriptionToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleInscriptionToolStripMenuItem4.Click
        enregistrement_evenement.Show()
    End Sub

    Private Sub ModificationSuppressionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationSuppressionToolStripMenuItem.Click
        activites_culturelles.Show()
    End Sub
End Class