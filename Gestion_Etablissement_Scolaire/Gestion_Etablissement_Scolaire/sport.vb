Imports System.Data
Imports System.Data.SqlClient

Public Class sport
    Dim co As SqlConnection
    Dim str As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            DataGridView1.Visible = True
            Dim cm As New SqlCommand("INSERT INTO table_sport(NOM,DUREE,BUDGET,IMAGE)VALUES(@nom,@temps,@somme,@image)", co)
            cm.Parameters.AddWithValue("@nom", nom.Text)
            cm.Parameters.AddWithValue("@temps", temps.Text)
            cm.Parameters.AddWithValue("@somme", somme.Text)
            cm.Parameters.AddWithValue("@image", str)
            cm.ExecuteNonQuery()
            cm.Parameters.Clear()
            nom.Clear()
            temps.Clear()
            somme.Clear()
            affiche_table()
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using open As New OpenFileDialog
            open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If open.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(open.FileName)
                str = open.FileName
            End If
        End Using
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mgestion.Show()

    End Sub

    Private Sub sport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub affiche_table()
        co = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_ecole;Integrated Security=True")
        Try
            co.Open()
            Dim chaine_c As String = "SELECT ID,NOM,DUREE,BUDGET FROM table_sport"
            Dim cm As New SqlCommand(chaine_c, co)
            Dim adapter As New SqlDataAdapter(cm)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class