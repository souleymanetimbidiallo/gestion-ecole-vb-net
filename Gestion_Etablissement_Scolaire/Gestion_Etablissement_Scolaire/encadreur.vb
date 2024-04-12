Imports System.Data
Imports System.Data.SqlClient

Public Class encadreur
    Dim Str As String
    Dim co As Sqlconnection
    Dim message1 = "INSCRIPTION REUSSIE AVEC SUECCES"
    Dim message2 = "MISE A JOUR EFFECTUEE AVEC SUCCESS"
    Dim moi As Boolean
    Dim inb As String


    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mail.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(open.FileName)
                Str = open.FileName
            End If
        End Using
    End Sub

    Public Sub mise_ajour_affiche()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
        inb = b.Cells(0).Value
        Dim cm As New SqlCommand("SELECT NOM,PRENOM,GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],CONTACT,QUARTIER,PHOTO FROM table_en WHERE ID=@ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        Using r As SqlDataReader = cm.ExecuteReader
            While r.Read
                Dim mnom As String = r("NOM")
                Dim mprenom As String = r("PRENOM")
                Dim mgenre As String = r("GENRE")
                Dim mnaissance As String = r("DATE DE NAISSANCE")
                Dim mlnaissance As String = r("LIEU DE NAISSANCE")
                Dim mfonction As String = r("FONCTION")
                Dim msalaire As String = r("SALAIRE")
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
                naissance.Value = mnaissance
                lnaissance.Text = mlnaissance
                fonction.Text = mfonction
                salaire.Text = msalaire
                mail.Text = mmail
                contact.Text = mcontact
                quartier.Text = mquartier
                PictureBox1.Image = Image.FromFile(mphoto)
            End While
            moi = True
        End Using

    End Sub

    Public Sub mise_ajour_table()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        Dim cm As New SqlCommand("UPDATE table_en SET NOM=@nom,PRENOM=@prenom,GENRE=@genre,[DATE DE NAISSANCE]=@naissance,[LIEU DE NAISSANCE]=@lnaissance,FONCTION=@fonction,SALAIRE=@salaire,[E-MAIL]=@mail,CONTACT=@contact,QUARTIER=quartier,PHOTO=@photo WHERE ID=@ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        cm.Parameters.AddWithValue("@nom", nom.Text)
        cm.Parameters.AddWithValue("@prenom", prenom.Text)
        If genre_h.Checked = True Then
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        End If
        cm.Parameters.AddWithValue("@naissance", naissance.Text)
        cm.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
        cm.Parameters.AddWithValue("@fonction", fonction.Text)
        cm.Parameters.AddWithValue("@salaire", salaire.Text)
        cm.Parameters.AddWithValue("@mail", mail.Text)
        cm.Parameters.AddWithValue("@contact", contact.Text)
        cm.Parameters.AddWithValue("@quartier", quartier.Text)
        cm.Parameters.AddWithValue("@photo", Str)
        cm.ExecuteNonQuery()
        cm.Parameters.Clear()
        efface()
        chargement(message2)
        Actualise()
    End Sub
    Public Sub Actualise()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        Dim cm As New SqlCommand("SELECT ID,NOM,PRENOM,GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],CONTACT,QUARTIER FROM table_en", co)
        Dim confirme As New SqlDataAdapter(cm)
        Dim table As New DataTable
        confirme.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Public Sub Ajout()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        Dim cm As New SqlCommand("INSERT INTO table_en (NOM,PRENOM,GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],CONTACT,QUARTIER,PHOTO) VALUES(@nom,@prenom,@genre,@naissance,@lnaissance,@fonction,@salaire,@mail,@contact,@quartier,@photo) ", co)
        cm.Parameters.AddWithValue("@nom", nom.Text)
        cm.Parameters.AddWithValue("@prenom", prenom.Text)
        If genre_h.Checked = True Then
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cm.Parameters.AddWithValue("@genre", genre_f.Text)
        End If
        cm.Parameters.AddWithValue("@naissance", naissance.Text)
        cm.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
        cm.Parameters.AddWithValue("@fonction", fonction.Text)
        cm.Parameters.AddWithValue("@salaire", salaire.Text)
        cm.Parameters.AddWithValue("@mail", mail.Text)
        cm.Parameters.AddWithValue("@contact", contact.Text)
        cm.Parameters.AddWithValue("@quartier", quartier.Text)
        cm.Parameters.AddWithValue("@photo", Str)
        cm.ExecuteNonQuery()
        cm.Parameters.Clear()
        efface()
        chargement(message1)
        Actualise()
    End Sub

    Public Sub supprimer(ByVal connection As SqlConnection)
        Dim table As New DataTable
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            For Each b As DataGridViewRow In DataGridView1.SelectedRows
                Dim cm As New SqlCommand("DELETE FROM table_en WHERE ID =@ib", connection)
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
    Public Sub efface()
        nom.Clear()
        prenom.Clear()
        genre_h.Checked = False
        genre_f.Checked = False
        lnaissance.Clear()
        fonction.Clear()
        salaire.Clear()
        mail.Clear()
        contact.Clear()
        quartier.Clear()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            If moi = True Then
                mise_ajour_table()
            Else
                Ajout()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mgestion.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Public Sub confirme_sup()
        Dim x As Integer = MsgBox("CONFIRMEZ VOUS VRAIMENT CETTE SUPPRESSION", vbYesNo + MsgBoxStyle.Question, "SUPPRESSION")
        If x = 6 Then
            supprimer(co)
        Else
            Exit Sub
        End If
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
    Private Sub encadreur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If moi = True Then
            chargement(message2)
        Else
            chargement(message1)
        End If
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        Actualise()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        mise_ajour_affiche()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mise_ajour_affiche()
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        confirme_sup()
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        Actualise()
    End Sub

    Private Sub MiseÀJourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        mise_ajour_affiche()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        confirme_sup()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub
End Class