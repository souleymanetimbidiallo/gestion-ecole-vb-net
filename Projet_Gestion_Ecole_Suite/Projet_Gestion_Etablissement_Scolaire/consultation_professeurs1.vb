Imports System.Data.SqlClient
Public Class consultation_professeurs1
    Public req As String
  
    Private Sub consultation_professeurs1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call remplirDataGridView(dgv_consultation_professeurs1, "Table_Professeurs")
    End Sub
    Private Sub RechercherConsultationProfesseurs1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercherConsultationProfesseurs1.TextChanged
        If IdConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE ID LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf NomConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE NOM LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf PrenomsConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE PRENOMS LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf GenreConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE GENRE LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf NombreClasseConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE NOMBRE_CLASSE LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf SalaireConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE SALAIRE LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf MatiereConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE MATIERE LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        ElseIf ContactConsultationProfesseurs1.Checked = True Then
            req = "SELECT * FROM Table_Professeurs WHERE CONTACT LIKE '" & RechercherConsultationProfesseurs1.Text & "%'"
            Call recherche(dgv_consultation_professeurs1, "Table_Professeurs", req)
        Else
            MsgBox("Veuillez choisir au moins une option de recherche!", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub RetourConsultationProfesseurs1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourConsultationProfesseurs1.Click
        Me.Close()
        menu_general.Show()
    End Sub
End Class