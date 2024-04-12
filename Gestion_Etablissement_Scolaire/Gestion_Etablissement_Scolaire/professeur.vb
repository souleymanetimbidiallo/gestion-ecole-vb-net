Imports System.Data
Imports System.Data.SqlClient

Public Class professeur
    Dim co As Sqlconnection
    Dim nsalaire As Integer
    Dim Str As String
    Public inb As String
    Public moi As Boolean = False
    Dim message1 As String = "INSCRIPTION REUSSIE AVEC SUCCES"
    Dim message2 As String = "MISE A JOUR EFFECTUEE AVEC SUCCES"


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(open.FileName)
                Str = open.FileName
            End If
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        mgestion.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub
    Public Sub ajout_prof()
        Dim cm As New SqlCommand("INSERT INTO table_profe(NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER,PHOTO) VALUES(@nom,@prenom,@genre,@naissance,@lnaissance,@matiere,@classetenue,@nclassetenue,@heure,@taux,@salaire,@mail,@contact,@quartier,@image)", co)
        cm.Parameters.AddWithValue("@nom", nom.Text)
        cm.Parameters.AddWithValue("@prenom", prenom.Text)
        If genre_h.Checked = True Then
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cm.Parameters.AddWithValue("@genre", genre_f.Text)
        End If
        cm.Parameters.AddWithValue("@naissance", naissance.Text)
        cm.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
        cm.Parameters.AddWithValue("@matiere", matiere.Text)
        cm.Parameters.AddWithValue("@classetenue", classe.Text)
        cm.Parameters.AddWithValue("@nclassetenue", nclasse.Text)
        cm.Parameters.AddWithValue("@heure", heure.Text)
        cm.Parameters.AddWithValue("@taux", taux.Text)
        cm.Parameters.AddWithValue("@salaire", nsalaire)
        cm.Parameters.AddWithValue("@mail", mail.Text)
        cm.Parameters.AddWithValue("@contact", contact.Text)
        cm.Parameters.AddWithValue("@quartier", quartier.Text)
        cm.Parameters.AddWithValue("@image", Str)
        cm.ExecuteNonQuery()
        PictureBox1.Visible = False
        chargement(message1)
        Actualise()
        efface()
    End Sub
    Public Sub mise_ajour_affichage_prof()
        Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
        inb = b.Cells(0).Value
        Dim cm As New SqlCommand("SELECT NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER,PHOTO FROM table_profe WHERE ID=@ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        Using r As SqlDataReader = cm.ExecuteReader
            While r.Read
                Dim mnom As String = r("NOM")
                Dim mprenom As String = r("PRENOM(S)")
                Dim mgenre As String = r("GENRE")
                Dim mnaissance As String = r("DATE DE NAISSANCE")
                Dim mlnaissance As String = r("LIEU DE NAISSANCE")
                Dim mmatiere As String = r("MATIERE")
                Dim mclasse As String = r("CLASSE(S) TENUE(S)")
                Dim mnbclasse As String = r("NOMBRE DE CLASSE TENUE")
                Dim mnbre_heure As String = r("NOMBRE D'HEURES/SEMAINE")
                Dim mtaux As String = r("TAUX HORAIRE")
                Dim msalaire As String = r("SALAIRE MENSUEL")
                Dim mmail As String = r("E-MAIL")
                Dim mcontact As String = r("CONTACT")
                Dim mquartier As String = r("QUARTIER")
                Dim mphoto As String = r("PHOTO")
                nom.Text = mnom
                prenom.Text = mprenom
                If mgenre = "HOMME" Then
                    genre_h.Checked = True
                Else
                    genre_f.Checked = True
                End If
                lnaissance.Text = mlnaissance
                classe.Text = mclasse
                nclasse.Text = mnbclasse
                heure.Text = mnbre_heure
                taux.Text = mtaux
                salaire.Text = msalaire
                mail.Text = mmail
                contact.Text = mcontact
                quartier.Text = mquartier
                naissance.Value = mnaissance
                PictureBox1.Image = Image.FromFile(mphoto)
            End While
            moi = True
        End Using
    End Sub
    Public Sub mise_ajour_table()
        Dim cm As New SqlCommand("UPDATE table_profe SET NOM=@nom,[PRENOM(S)]=@prenom,GENRE=@genre,[DATE DE NAISSANCE]=@naissance,[LIEU DE NAISSANCE]=@lnaissance,MATIERE=@matiere,[CLASSE(S) TENUE(S)]=@classe,[NOMBRE DE CLASSE TENUE]=@nbclasse,[NOMBRE D'HEURES/SEMAINE]=@nb_heure,[TAUX HORAIRE]=@taux,[SALAIRE MENSUEL]=@salaire,[E-MAIL]=@mail,[CONTACT]=@contact,QUARTIER=@quartier,PHOTO=@photo WHERE ID=@ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        cm.Parameters.AddWithValue("@nom", nom.Text)
        cm.Parameters.AddWithValue("@prenom", prenom.Text)
        If genre_h.Checked = True Then
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cm.Parameters.AddWithValue("@genre", genre_f.Text)
        End If
        cm.Parameters.AddWithValue("@naissance", naissance.Text)
        cm.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
        cm.Parameters.AddWithValue("@matiere", matiere.Text)
        cm.Parameters.AddWithValue("@classe", classe.Text)
        cm.Parameters.AddWithValue("nbclasse", nclasse.Text)
        cm.Parameters.AddWithValue("@nb_heure", heure.Text)
        cm.Parameters.AddWithValue("@taux", taux.Text)
        cm.Parameters.AddWithValue("@salaire", salaire.Text)
        cm.Parameters.AddWithValue("@mail", mail.Text)
        cm.Parameters.AddWithValue("@contact", contact.Text)
        cm.Parameters.AddWithValue("@quartier", quartier.Text)
        cm.Parameters.AddWithValue("@photo", Str)
        cm.ExecuteNonQuery()
        cm.Parameters.Clear()
        chargement(message2)
        Actualise()
        efface()
        PictureBox1.Visible = False
    End Sub
    Public Sub efface()
        nom.Clear()
        prenom.Clear()
        genre_h.Checked = False
        genre_f.Checked = False
        lnaissance.Clear()
        classe.Clear()
        nclasse.Clear()
        taux.Clear()
        salaire.Clear()
        mail.Clear()
        contact.Clear()
        quartier.Clear()
        heure.Clear()
    End Sub
    Public Sub Actualise()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim cm As New SqlCommand("SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER FROM table_profe", co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub chargement(ByVal m As String)
        Timer1.Enabled = True
        pg.Visible = True
        If pg.Value = 100 Then
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(m, vbOK + MsgBoxStyle.Information, "IFORMATION")
            pg.Value = 0
            pg.Visible = False
        Else
            pg.Value = pg.Value + 5
        End If
    End Sub
    Dim table As New DataTable
    Public Sub supprimer(ByVal connection As SqlConnection)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            For Each b As DataGridViewRow In DataGridView1.SelectedRows
                Dim cm As New SqlCommand("DELETE FROM table_profe WHERE ID =@ib", connection)
                Dim c As String = b.Cells(0).Value
                cm.Parameters.AddWithValue("@ib", c)
                cm.ExecuteNonQuery()
                Dim confirme As New SqlDataAdapter(cm)
                confirme.Fill(table)
            Next
            MessageBox.Show("SUPPRIME(S) AVEC SUCCES")
            DataGridView1.DataSource = table
            Actualise()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            If moi = True Then
                mise_ajour_table()
            Else
                ajout_prof()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub filtre(ByVal p_chaine As String)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim cm As New SqlCommand(p_chaine, co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub professeur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        salaire.Enabled = False
    End Sub

    Private Sub taux_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taux.TextChanged
        Button4.Enabled = True

    End Sub

    Private Sub lnaissance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnaissance.TextChanged

    End Sub

    Private Sub naissance_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles naissance.ValueChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub mail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mail.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        mise_ajour_affichage_prof()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If moi = True Then
            chargement(message2)
        Else
            chargement(message1)
        End If
    End Sub

   
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Actualise()
    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        confirme_sup()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Dim nheure As Integer
        Dim taux_h As Integer
        nheure = Val(heure.Text)
        taux_h = Val(taux.Text)
        nsalaire = taux_h * nheure * 4
        salaire.Text = nsalaire
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        o_recherche.Show()
    End Sub
    Public Sub confirme_sup()
        Dim x As Integer = MsgBox("CONFIRMEZ VOUS VRAIMENT CETTE SUPPRESSION", vbYesNo + MsgBoxStyle.Question, "SUPPRESSION")
        If x = 6 Then
            supprimer(co)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub recherche_t_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recherche_e.Click
        recherche_e.Text = ""

    End Sub

    Private Sub recherche_t_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles recherche_e.TextChanged
        If o_recherche.nom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER FROM table_profe WHERE NOM LIKE'%" & recherche_e.Text & "%'"
            filtre(chaine_recherche)
        ElseIf o_recherche.prenom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER FROM table_profe WHERE [PRENOM(S)] LIKE'%" & recherche_e.Text & "%'"
            filtre(chaine_recherche)
        ElseIf o_recherche.genre.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER FROM table_profe WHERE GENRE LIKE'%" & recherche_e.Text & "%'"
            filtre(chaine_recherche)
        ElseIf o_recherche.matiere.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],MATIERE,[CLASSE(S) TENUE(S)],[NOMBRE DE CLASSE TENUE],[NOMBRE D'HEURES/SEMAINE],[TAUX HORAIRE],[SALAIRE MENSUEL],[E-MAIL],[CONTACT],QUARTIER FROM table_profe WHERE MATIERE LIKE'%" & recherche_e.Text & "%'"
            filtre(chaine_recherche)
        Else
            MsgBox("VEUILLEZ CHOISIR UNE OPTION DE RECHERCHE", vbOK + MsgBoxStyle.Critical, "ERREUR")
            recherche_e.Text = ""
            'recherche.Text = ""
            Me.Show()
        End If
    End Sub
End Class