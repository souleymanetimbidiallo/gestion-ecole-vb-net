Imports System.Data
Imports System.Data.SqlClient


Public Class table_direction
    Dim co As SqlConnection
    

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub table_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    
    Dim table As New DataTable
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
            DataGridView1.DataSource = table
            MessageBox.Show("SUPPRIME(S) AVEC SUCCES")
        Catch ex As Exception
            MsgBox("VOUS DEVEZ SELECTIONNEZ AU MOINS UN ELEMENT", vbYesNoCancel + MsgBoxStyle.Critical, "ERREUR")
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        supprimer(co)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        mgestion.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        End
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
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        actualiser()
    End Sub

    Private Sub recherche_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles recherche.TextChanged
        tri(recherche)
    End Sub
    Public Sub filtre(ByVal p_chaine As String)
        Try
            Dim cm As New SqlCommand(p_chaine, co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub tri(ByVal Texte_recherche As ToolStripTextBox)
        If option_recherche.nom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE NOM LIKE'%" & Texte_recherche.Text & "%'"
            filtre(chaine_recherche)
        ElseIf option_recherche.prenom.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE [PRENOM(S)] LIKE'%" & Texte_recherche.Text & "%'"
            filtre(chaine_recherche)
        ElseIf option_recherche.genre.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE GENRE LIKE'%" & Texte_recherche.Text & "%'"
            filtre(chaine_recherche)
        ElseIf option_recherche.fonction.Checked = True Then
            Dim chaine_recherche As String = "SELECT ID,NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER FROM table_prof WHERE QUARTIER LIKE'%" & Texte_recherche.Text & "%'"
            filtre(chaine_recherche)
        Else
            MsgBox("VEUILLEZ CHOISIR UNE OPTION DE RECHERCHE", vbOK + MsgBoxStyle.Critical, "ERREUR")
            'recherche.Text = ""
            Me.Show()
        End If
    End Sub
    
    Public Sub mise_ajour()
        Dim b As DataGridViewRow = DataGridView1.SelectedRows(0)
        ' inb = b.Cells(0).Value
        Dim cm As New SqlCommand("SELECT NOM,[PRENOM(S)],GENRE,[DATE DE NAISSANCE],[LIEU DE NAISSANCE],FONCTION,SALAIRE,[E-MAIL],[NUMERO DE TELEPHONE],QUARTIER,PHOTO FROM table_prof WHERE ID = @ib", co)
        ' cm.Parameters.AddWithValue("@ib", inb)
        Using r As SqlDataReader = cm.ExecuteReader()
            While r.Read
                Dim nom As String = r("NOM")
                Dim prenom As String = r("PRENOM(S)")
                ' Dim naissance As String = r("DATE DE NAISSANCE")
                Dim lnaissance As String = r("LIEU DE NAISSANCE")
                Dim fonction As String = r("FONCTION")
                Dim salaire As String = r("SALAIRE")
                Dim mail As String = r("E-MAIL")
                Dim contact As String = r("NUMERO DE TELEPHONE")
                Dim quartier As String = r("QUARTIER")
                Dim photo As String = r("PHOTO")
                profile_personnel_direction.nom.Text = nom
                profile_personnel_direction.prenom.Text = prenom
                ' profile_personnel_direction.naissance.Text = naissance
                profile_personnel_direction.lnaissance.Text = lnaissance
                profile_personnel_direction.fonction.Text = fonction
                profile_personnel_direction.salaire.Text = salaire
                profile_personnel_direction.mail.Text = mail
                profile_personnel_direction.phone.Text = contact
                profile_personnel_direction.quartier.Text = quartier
                profile_personnel_direction.PictureBox1.Image = Image.FromFile(photo)
            End While
        End Using
        profile_personnel_direction.Show()
        ' moi = True
    End Sub
    'PictureBox1.Image = Image.FromFile(open.FileName)
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        mise_ajour()
    End Sub

    Private Sub MoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        actualiser()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        supprimer(co)
    End Sub

    Private Sub MiseÀJourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        mise_ajour()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class