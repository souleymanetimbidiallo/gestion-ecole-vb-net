Imports System.Data
Imports System.Data.SqlClient

Public Class Direction_Autre
    Dim Str As String
    Public inb As String

    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        Direction_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_CONSULTATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CONSULTATION.Click
        DataGridView1.Visible = True
        Panel1.Visible = False
        Dim co As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=GestionPrimaire;Integrated Security=True")
        Try
            co.Open()
            Dim connection_chaine As String = "SELECT * FROM Direction WHERE FONCTION = @fonction AND NOM = @nom AND PRENOM = @prenom"
            Dim cm As New SqlCommand(connection_chaine, co)
            cm.Parameters.AddWithValue("@fonction", Fonction.ValueMember)
            cm.Parameters.AddWithValue("@nom", Nom.Text)
            cm.Parameters.AddWithValue("@prenom", Prenom.Text)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BT_MODIFICATION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFICATION.Click
        Panel1.Visible = True
        DataGridView1.Visible = False
    End Sub

    Private Sub BT_MODIFIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFIER.Click

        Dim co As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=GestionPrimaire;Integrated Security=True")
        Try
            co.Open()
            Dim connection As String = "UPDATE Direction SET NOM=@nom, PRENOM=@prenom, GENRE=@genre, DATE_NAISSANCE=@date, LIEU_NAISSSANCE=@lieu, TELEPHONE=@telephone, EMAIL=@email, QUARTIER=@quartier, FONCTION=@fonction, SALAIRE=@salaire, PHOTO=@photo WHERE ID=@id"
            Dim cm As New SqlCommand(connection, co)
            'cmd.Parameters.AddWithValue("@nom", Nom.Text)
            'cmd.Parameters.AddWithValue("@prenom", Prenom.Text)
            'If genre_homme.Checked = True Then
            'cmd.Parameters.AddWithValue("@genre", genre_homme.Text)
            'Else
            'cmd.Parameters.AddWithValue("@genre", genre_femme.Text)
            'End If
            'cmd.Parameters.AddWithValue("@date", date_naissance.Value)
            'cmd.Parameters.AddWithValue("@lieu", lieu_naissance.Text)
            'cmd.Parameters.AddWithValue("@telephone", telephone.Text)
            'cmd.Parameters.AddWithValue("@email", email.Text)
            'cmd.Parameters.AddWithValue("@quartier", quartier.Text)
            'cmd.Parameters.AddWithValue("@fonction", Fonction.Text)
            'cmd.Parameters.AddWithValue("@salaire", salaire.Text)
            'cmd.Parameters.AddWithValue("@photo", Str)
            'cmd.ExecuteNonQuery()
            'cmd.Parameters.Clear()
            Panel1.Visible = False
            MsgBox("Les informations du personnel ont ete modifie avec succes !", 64, "Modification")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BT_SUPPRESSION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SUPPRESSION.Click
        If MsgBox("Souhaitez-vous vraiment supprimer les informations de cette personne ?", 36, "Quitter") = MsgBoxResult.Yes Then
            MsgBox("Les informations de cette personne ont ete supprime avec succes !", 64, "Suppression")
        End If
    End Sub

    Private Sub BT_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PHOTO.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PB_PHOTO.Image = Image.FromFile(open.FileName)
                Str = open.FileName
            End If
        End Using
    End Sub
End Class