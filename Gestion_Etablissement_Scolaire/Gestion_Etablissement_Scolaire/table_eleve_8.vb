Imports System.Data
Imports System.Data.SqlClient

Public Class table_eleve_8
    Dim co As SqlConnection

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If recherche.Text = "" Then
            MsgBox("LE CHAMP CORRESTPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")
        Else
            MessageBox.Show("nom disponible")


        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If sup.Text = "" Then
            MsgBox("LE CHAMP CORRESTPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")
        Else
            MessageBox.Show("nom disponible")


        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If mj.Text = "" Then
            MsgBox("LE CHAMP CORRESTPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")
        Else
            MessageBox.Show("nom disponible")


        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim c_chaine As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FILIATION,CLASSE,MATRICULE,[CONTACT DU TUTEUR],QUARTIER,PAYEMENT,COMPTE FROM table_eleve WHERE CLASSE='8 eme /A'"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub table_eleve_8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class