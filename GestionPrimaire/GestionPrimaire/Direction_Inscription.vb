Imports System.Data
Imports System.Data.SqlClient

Public Class Direction_Inscription
    Dim Str As String
    Public chaine_de_connection As String = ""


    Private Sub BT_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PHOTO.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PB_PHOTO.Image = Image.FromFile(open.FileName)
                Str = open.FileName
                BT_PHOTO.Text = "Modifier la photo"
            End If
        End Using
    End Sub

    Private Sub BT_RETOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RETOUR.Click
        Direction_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BT_ENREGISTRER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ENREGISTRER.Click
        Dim co As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=GestionPrimaire;Integrated Security=True")
        Try
            co.Open()
            Dim cmd As New SqlCommand("INSERT INTO Direction(NOM, PRENOM, GENRE, DATE_NAISSANCE,LIEU,TELEPHONE, EMAIL, QUARTIER, FONCTION, SALAIRE, PHOTO) VALUES(@nom,@prenom,@genre,@date,@lieu,@telephone,@email,@quartier,@fonction,@salaire,@photo)", co)
            cmd.Parameters.AddWithValue("@nom", nom.Text)
            cmd.Parameters.AddWithValue("@prenom", prenom.Text)
            If genre_homme.Checked = True Then
                cmd.Parameters.AddWithValue("@genre", genre_homme.Text)
            Else
                cmd.Parameters.AddWithValue("@genre", genre_femme.Text)
            End If
            cmd.Parameters.AddWithValue("@date", date_naissance.Value)
            cmd.Parameters.AddWithValue("@lieu", lieu_naissance.Text)
            cmd.Parameters.AddWithValue("@telephone", telephone.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@quartier", quartier.Text)
            cmd.Parameters.AddWithValue("@fonction", fonction.ValueMember)
            cmd.Parameters.AddWithValue("@salaire", salaire.Text)
            cmd.Parameters.AddWithValue("@photo", Str)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES !")
            nom.Clear()
            prenom.Clear()
            genre_femme.Checked = False
            genre_homme.Checked = False
            date_naissance.Value = ""
            lieu_naissance.Clear()
            telephone.Clear()
            email.Clear()
            quartier.Clear()
            fonction.ValueMember = ""
            salaire.Clear()
            PB_PHOTO.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lieu_naissance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lieu_naissance.TextChanged

    End Sub
End Class