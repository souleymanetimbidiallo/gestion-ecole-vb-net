Imports System.Data
Imports System.Data.SqlClient

Public Class profile_personnel_direction
    Dim str As String
    Dim co As SqlConnection
    Public moi As Boolean = False
    Public inb As String
    Dim table As New DataTable
    Dim message1 As String = "MISE A JOUR EFFECTUEE AVEC SUCCES"
    Dim message2 As String = "INSCRIPTION REUSSIE AVEC SUCCES"
    Public Sub Ajout(ByVal connection As SqlConnection)
        Dim chc As String
        Dim cm As SqlCommand
        chc = "INSERT INTO table_prof(NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER,PHOTO) VALUES(@nom,@prenom,@genre,@naissance,@lieu,@fonction,@salaire,@mail,@phone,@quartier,@photo)"
        cm = New SqlCommand(chc, co)
        cm.Parameters.AddWithValue("@nom", nom.Text)
        cm.Parameters.AddWithValue("@prenom", prenom.Text)
        cm.Parameters.AddWithValue("@naissance", naissance.Value)
        cm.Parameters.AddWithValue("@lieu", lnaissance.Text)
        cm.Parameters.AddWithValue("@fonction", fonction.Text)
        cm.Parameters.AddWithValue("@salaire", salaire.Text)
        cm.Parameters.AddWithValue("@mail", mail.Text)
        cm.Parameters.AddWithValue("@phone", phone.Text)
        cm.Parameters.AddWithValue("@quartier", quartier.Text)
        cm.Parameters.AddWithValue("@photo", str)
        If genre_h.Checked = True Then
            cm.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cm.Parameters.AddWithValue("@genre", genre_f.Text)
        End If
        cm.ExecuteNonQuery()
        cm.Parameters.Clear()
        chargement(message2)
        actualiser()
        efface()

    End Sub
    Public Sub mise_ajour(ByVal connection As SqlConnection)
        Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
        inb = b.Cells(0).Value
        Dim chc As String
        Dim cmi As SqlCommand
        chc = "UPDATE table_prof SET NOM=@nom,[PRENOM(S)]=@prenom,[DATE DE NAISSANCE]=@naissance,[LIEU DE NAISSANCE]=@lnaissance,FONCTION=@fonction,SALAIRE=@salaire,[E-MAIL]=@mail,[NUMERO DE TELEPHONE]=@phone,QUARTIER=@quartier,PHOTO=@photo WHERE ID=@Id"
        cmi = New SqlCommand(chc, co)
        cmi.Parameters.AddWithValue("@id", inb)
        cmi.Parameters.AddWithValue("@nom", nom.Text)
        cmi.Parameters.AddWithValue("@prenom", prenom.Text)
        cmi.Parameters.AddWithValue("@naissance", naissance.Value)
        cmi.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
        cmi.Parameters.AddWithValue("@fonction", fonction.Text)
        cmi.Parameters.AddWithValue("@salaire", salaire.Text)
        cmi.Parameters.AddWithValue("@mail", mail.Text)
        cmi.Parameters.AddWithValue("@phone", phone.Text)
        cmi.Parameters.AddWithValue("@quartier", quartier.Text)
        cmi.Parameters.AddWithValue("@photo", str)
        If genre_h.Checked = True Then
            cmi.Parameters.AddWithValue("@genre", genre_h.Text)
        Else
            cmi.Parameters.AddWithValue("@genre", genre_f.Text)
        End If
        cmi.ExecuteNonQuery()
        cmi.Parameters.Clear()
        chargement(message1)
        actualiser()
        PictureBox1.Visible = False
        efface()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sauve.Click
        'ENREGISTREMENT
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            If moi = True Then
                'mise à jour
                mise_ajour(co)
            Else
                Ajout(co)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        picturebox()
    End Sub
    Sub picturebox()
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(open.FileName)
                Str = open.FileName
            End If
        End Using
    End Sub


    Private Sub profile_personnel_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mgestion.Show()
        Me.Hide()
    End Sub

    Public Sub actualiser()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim connection_chaine As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof"
            Dim cm As New SqlCommand(connection_chaine, co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        actualiser()
    End Sub
    Public Sub mise_ajour()
        'MISE A JOUR POUR L'AFFICHAGE 
        Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
        inb = b.Cells(0).Value
        Dim cm As New SqlCommand("SELECT NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER,PHOTO FROM table_prof WHERE ID = @ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        Using r As SqlDataReader = cm.ExecuteReader()
            While r.Read
                Dim mnom As String = r("NOM")
                Dim mprenom As String = r("PRENOM(S)")
                'Dim naissance As String = r("DATE DE NAISSANCE")
                Dim mlnaissance As String = r("LIEU DE NAISSANCE")
                Dim mfonction As String = r("FONCTION")
                Dim msalaire As String = r("SALAIRE")
                Dim mmail As String = r("E-MAIL")
                Dim mcontact As String = r("NUMERO DE TELEPHONE")
                Dim mquartier As String = r("QUARTIER")
                Dim mphoto As String = r("PHOTO")
                nom.Text = mnom
                prenom.Text = mprenom
                ' profile_personnel_direction.naissance.Text = naissance
                lnaissance.Text = mlnaissance
                fonction.Text = mfonction
                salaire.Text = msalaire
                mail.Text = mmail
                phone.Text = mcontact
                quartier.Text = mquartier
                PictureBox1.Image = Image.FromFile(mphoto)
            End While
        End Using
        moi = True
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mise_ajour()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        mise_ajour()
    End Sub
    Public Sub efface()
        nom.Clear()
        prenom.Clear()
        lnaissance.Clear()
        fonction.Clear()
        naissance.Value = ""
        salaire.Clear()
        mail.Clear()
        phone.Clear()
        quartier.Clear()
        genre_f.Checked = False
        genre_h.Checked = False
    End Sub

    Public Sub supprimer(ByVal connection As SqlConnection)

        Try
            For Each b As DataGridViewRow In DataGridView1.SelectedRows
                Dim cm As New SqlCommand("DELETE FROM table_prof WHERE ID =@ib", connection)
                Dim c As String = b.Cells(0).Value
                cm.Parameters.AddWithValue("@ib", c)
                cm.ExecuteNonQuery()
                Dim confirme As New SqlDataAdapter(cm)
                confirme.Fill(table)
            Next
            MessageBox.Show("SUPPRIME(S) AVEC SUCCES")
            DataGridView1.DataSource = table
            actualiser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        supprimer(co)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
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
   
    Public Sub chargement(ByVal m As String)
        Timer1.Enabled = True
        pg.Visible = True
        If pg.Value = 100 Then

            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(m, vbOK + MsgBoxStyle.Information, "INFORMATION")
            pg.Value = 0
            pg.Visible = False
        Else
            pg.Value = pg.Value + 5

        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If moi = True Then
            chargement(message1)
        Else
            chargement(message2)
        End If
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        actualiser()

    End Sub

    Private Sub MiseÀJourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        mise_ajour()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        supprimer(co)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        option_recherche.Show()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recherche_t.Click
        recherche_t.Text = ""

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles recherche_t.TextChanged
        option_recherche.tri(recherche_t)
    End Sub
End Class