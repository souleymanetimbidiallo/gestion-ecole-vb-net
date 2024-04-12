Imports System.Data.SqlClient
Public Class consultation_encadreurs1
    Public req As String
    Private Sub consultation_encadreurs1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        remplirDataGridView(dgv_consultation_encadreurs1, "Table_Encadreurs")
    End Sub

    Private Sub RechercheConsultationEncadreurs1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RechercheConsultationEncadreurs1.TextChanged
        If IdConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE ID LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        ElseIf NomConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE NOM LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        ElseIf PrenomsConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE PRENOMS LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        ElseIf GenreConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE GENRE LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        ElseIf FonctionConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE FONCTION LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        ElseIf SalaireConsultationEncadreurs1.Checked = True Then
            req = "SELECT * FROM Table_Encadreurs WHERE SALAIRE LIKE '" & RechercheConsultationEncadreurs1.Text & "%'"
            Call recherche(dgv_consultation_encadreurs1, "Table_Encadreurs", req)
        Else
            MsgBox("Veuillez choisir au moins une option de recherche !", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur")
        End If
    End Sub

    Private Sub RetourConsultationEncadreurs1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourConsultationEncadreurs1.Click
        Me.Close()
        menu_general.Show()
    End Sub
End Class