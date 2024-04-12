Imports System.Data
Imports System.Data.SqlClient
Public Class o_recherche
    Dim co As SqlConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nom.Checked = True Then
            professeur.recherche_e.Text = "Saisir ici le nom"
            Me.Hide()
        ElseIf prenom.Checked = True Then
            professeur.recherche_e.Text = "Saisir ici le prenom"
            Me.Hide()
        ElseIf genre.Checked = True Then
            professeur.recherche_e.Text = "Saisir ici le genre"
            Me.Hide()
        Else
            professeur.recherche_e.Text = "saisir ici la matière"
            Me.Hide()
        End If
    End Sub
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub o_recherche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class