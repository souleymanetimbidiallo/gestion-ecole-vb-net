﻿Imports System.Data
Imports System.Data.SqlClient

Public Class table_eleve_7
    Dim co As SqlConnection

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If recherche.Text = "" Then
            MsgBox("LE CHAMP CORRESPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")
        Else
            MessageBox.Show("Pas disponible ")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If sup.Text = "" Then
            MsgBox("LE CHAMP CORRESPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")

        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If mj.Text = "" Then
            MsgBox("LE CHAMP CORRESPONDANT NE DOIT PAS ETRE VIDE", vbOK + MsgBoxStyle.Critical, "ERREUR")

        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim c_chaine As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FILIATION,CLASSE,MATRICULE,[CONTACT DU TUTEUR],QUARTIER,PAYEMENT,COMPTE FROM table_eleve WHERE CLASSE='7 eme /A'"

            Dim cm As New SqlCommand(c_chaine, co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        mgestion.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        End
    End Sub
End Class