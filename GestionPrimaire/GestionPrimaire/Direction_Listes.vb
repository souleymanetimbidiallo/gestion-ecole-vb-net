Imports System.Data
Imports System.Data.SqlClient

Public Class Direction_listes

    Private Sub BT_CLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CLOSE.Click
        aff_fenetre(Direction_Accueil)
    End Sub


    Public Sub aff_fenetre(ByVal fenetre As Form)
        fenetre.Show()
        Me.Close()
    End Sub

    Private Sub Direction_listes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim co As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=GestionPrimaire;Integrated Security=True")
        Try
            co.Open()
            Dim connection_chaine As String = "SELECT * FROM Direction"
            Dim cm As New SqlCommand(connection_chaine, co)
            Dim confirme As New SqlDataAdapter(cm)
            Dim table As New DataTable
            confirme.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class