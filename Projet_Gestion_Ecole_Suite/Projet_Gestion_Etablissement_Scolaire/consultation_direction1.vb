Imports System.Data.SqlClient
Public Class consultation_direction1
    Public req As String
    Private Sub consultation_direction1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_consultation_direction1, "Table_Direction")
    End Sub
    Private Sub RechercheConsultationDirection1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheConsultationDirection1.TextChanged
        If IdConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE ID LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        ElseIf NomConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE NOM LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        ElseIf PrenomsConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE PRENOMS LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        ElseIf GenreConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE GENRE LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        ElseIf FonctionConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE FONCTION LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        ElseIf SalaireConsultationDirection1.Checked = True Then
            req = "SELECT * FROM Table_Direction WHERE SALAIRE LIKE '" & RechercheConsultationDirection1.Text & "%'"
            Call recherche(dgv_consultation_direction1, "Table_Direction", req)
        Else
            MsgBox("Veuillez choisir au moins une option de recherche!", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub RetourConsultationDirection1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourConsultationDirection1.Click
        Me.Close()
        menu_general.Show()
    End Sub
End Class