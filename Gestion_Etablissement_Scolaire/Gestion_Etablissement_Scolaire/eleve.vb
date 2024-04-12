Imports System.Data
Imports System.Data.SqlClient

Public Class eleve
    Dim co As SqlConnection
    Dim Str As String
    Public moi As Boolean
    Dim inb As String
    Public m_compte As Integer = 0
    Dim message1 As String = "INSCRIPTION REUSSIE AVEC SUCCESS"
    Dim message2 As String = "MISE AJOUR EFFECTUEE AVEC SUCCESS"
    Public Sub payement_compte(ByVal table As ToolStripTextBox)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        co.Open()
        Dim cm As New SqlCommand("SELECT COMPTE FROM " & table.Text & " WHERE ID=@ib", co)
        cm.Parameters.AddWithValue("@ib", inb)
        Using r As SqlDataReader = cm.ExecuteReader
            While r.Read
                m_compte = r("COMPTE")
            End While

        End Using
    End Sub
    Public Sub mise_ajour_table(ByVal table As ToolStripTextBox)
        payement_compte(table)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim cm As New SqlCommand("UPDATE " & table.Text & "SET NOM=@nom,PRENOM=@prenom,GENRE=@genre,[DATE DE NAISSANCE]=@naissance,[LIEU DE NAISSANCE]=@lnaissance,FILIATION=@filiation,CLASSE=@classe,MATRICULE=@matricule,[CONTACT DU TUTEUR]=@contact,QUARTIER=@quartier,PAYEMENT=@payement,COMPTE=@compte,PHOTO=@photo", co)
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
            cm.Parameters.AddWithValue("@filiation", filiation.Text)
            cm.Parameters.AddWithValue("@matricule", matricule.Text)
            cm.Parameters.AddWithValue("@classe", classe.Text)
            cm.Parameters.AddWithValue("@contact", contact.Text)
            cm.Parameters.AddWithValue("@quartier", quartier.Text)
            If gm.Visible = True Then
                cm.Parameters.AddWithValue("@payement", nmoi.Text)
            Else
                cm.Parameters.AddWithValue("@payement", ga.Text)
            End If
            m_compte = m_compte + Val(somme_moi.Text)
            cm.Parameters.AddWithValue("@compte", m_compte)
            cm.Parameters.AddWithValue("@photo", Str)
            cm.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub chargement(ByVal message As String)

    End Sub
    Public Sub mise_ajour_affiche_table(ByVal table As ToolStripTextBox)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
            inb = b.Cells(0).Value
            co.Open()
            Dim cm As New SqlCommand("SELECT NOM,PRENOM,GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FILIATION,CLASSE,MATRICULE,[CONTACT DU TUTEUR],QUARTIER,PAYEMENT,COMPTE,PHOTO FROM " & table.Text & "WHERE ID=@ib", co)
            cm.Parameters.AddWithValue("@ib", inb)
            Using r As SqlDataReader = cm.ExecuteReader
                While r.Read
                    Dim mnom As String = r("NOM")
                    Dim mprenom As String = r("PRENOM")
                    Dim mgenre As String = r("GENRE")
                    Dim mnaissance As String = r("DATE DE NAISSANCE")
                    Dim mlnaissance As String = r("LIEU DE NAISSANCE")
                    Dim mfiliation As String = r("FILIATION")
                    Dim mclasse As String = r("CLASSE")
                    Dim mmatricule As String = r("MATRICULE")
                    Dim mcontact As String = r("CONTACT DU TUTEUR")
                    Dim mquartier As String = r("QUARTEIR")
                    Dim mpayement As String = r("PAYEMENT")
                    Dim mcompte As String = r("COMPTE")
                    Dim mphoto As String = r("PHOTO")
                    nom.Text = mnom
                    prenom.Text = mprenom
                    If mgenre = "HOMME" Then
                        genre_h.Checked = True
                    Else
                        genre_f.Checked = True
                    End If
                    naissance.Text = mnaissance
                    lnaissance.Text = mlnaissance
                    filiation.Text = mfiliation
                    classe.Text = mclasse
                    matricule.Text = mmatricule
                    contact.Text = mcontact
                    quartier.Text = mquartier
                    If mpayement = "ANNUEL" Then
                        somme_a.Text = mcompte
                    Else
                        nmoi.Text = mpayement
                        somme_moi.Text = mcompte
                    End If
                    PictureBox1.Image = Image.FromFile(Str)
                End While
                moi = True
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Ajout(ByVal table As ToolStripTextBox)
        m_compte = 0

        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim cm As New SqlCommand("INSERT INTO" & table.Text & " (NOM,PRENOM,GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FILIATION,CLASSE,MATRICULE,[CONTACT DU TUTEUR],QUARTIER,PAYEMENT,COMPTE,PHOTO) VALUES(@nom,@prenom,@genre,@naissance,@lnaissance,@filiation,@classe,@matricule,@contact,@quartier,@payement,@compte,@photo)", co)
            cm.Parameters.AddWithValue("@nom", nom.Text)
            cm.Parameters.AddWithValue("@prenom", prenom.Text)
            If genre_h.Checked = True Then
                cm.Parameters.AddWithValue("@genre", genre_h.Text)
            Else
                cm.Parameters.AddWithValue("@genre", genre_f.Text)
            End If
            cm.Parameters.AddWithValue("@naissance", naissance.Text)
            cm.Parameters.AddWithValue("@lnaissance", lnaissance.Text)
            cm.Parameters.AddWithValue("@filiation", filiation.Text)
            cm.Parameters.AddWithValue("@matricule", matricule.Text)
            cm.Parameters.AddWithValue("@classe", classe.Text)
            cm.Parameters.AddWithValue("@contact", contact.Text)
            cm.Parameters.AddWithValue("@quartier", quartier.Text)
            If gm.Enabled = True Then
                m_compte = m_compte + Val(somme_moi.Text)
                cm.Parameters.AddWithValue("@payement", nmoi.Text)
                cm.Parameters.AddWithValue("@compte", m_compte)
            Else
                cm.Parameters.AddWithValue("@payement", ga.Text)
                m_compte = m_compte + Val(somme_a.Text)
                cm.Parameters.AddWithValue("@compte", m_compte)
            End If
            cm.Parameters.AddWithValue("@photo", Str)
            cm.ExecuteNonQuery()
            MessageBox.Show("INSCRIPTION REUSSIE AVEC SUCCES")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub mise_ajour_affiche()
        Ajout(niveau_eleve.tabletexte)
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Dim cm As New SqlCommand("UPDATE table")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If gm.Visible = True And ga.Visible = True Then
            MsgBox("VOUS DEVEZ CHOISIR UNE OPTION", vbOK + MsgBoxStyle.Critical, "ERREUR")
            Me.Show()
        Else

        End If




    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ga.Visible = False
        gm.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gm.Visible = False
        ga.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mgestion.Show()
    End Sub

    Private Sub eleve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ga.Enabled = True
        gm.Enabled = True
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

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub mensuel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mensuel.CheckedChanged
        ga.Enabled = False
    End Sub

    Private Sub annuel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles annuel.CheckedChanged
        gm.Enabled = True

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class