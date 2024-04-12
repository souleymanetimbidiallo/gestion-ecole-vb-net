Imports System.Data.SqlClient
Module Methodes
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public Sub connecter()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True;Pooling=False"
            con.Open()
        End If
    End Sub
    Public Sub deconnecter()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Public Sub remplirDataGridView(ByVal dgv As DataGridView, ByVal table As String)
        If Not ds.Tables("DT" & table) Is Nothing Then
            ds.Tables("DT" & table).Clear()
        End If
        Call connecter()
        cmd.CommandText = "SELECT * FROM " & table
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds, "DT" & table)
        dgv.DataSource = ds.Tables("DT" & table)
        Call deconnecter()
    End Sub
    Public Sub recherche(ByVal dgv As DataGridView, ByVal table As String, ByVal sql As String)
        If Not ds.Tables("DT" & table) Is Nothing Then
            ds.Tables("DT" & table).Clear()
        End If
        Call connecter()
        cmd.CommandText = sql
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds, "DT" & table)
        dgv.DataSource = ds.Tables("DT" & table)
        Call deconnecter()
    End Sub
    Public Sub viderForm(ByVal fenetre As Control)
        For Each objet As Control In fenetre.Controls
            If TypeOf objet Is TextBox Then
                objet.Text = ""
            End If
            If TypeOf objet Is DateTimePicker Then
                CType(objet, DateTimePicker).Value = Now
            End If
            If TypeOf objet Is RadioButton Then
                CType(objet, RadioButton).Checked = False
            End If
            If TypeOf objet Is CheckBox Then
                CType(objet, CheckBox).Checked = False
            End If
            If TypeOf objet Is GroupBox Or TypeOf objet Is Panel Then
                Call viderForm(objet)
            End If
        Next
    End Sub
    Public Sub importerPhoto(ByVal chaine As String, ByVal photo As PictureBox)
        Using Open As New OpenFileDialog
            Open.Filter = "Les images|*.jpg;*.jpeg;*.png"
            If Open.ShowDialog() = DialogResult.OK Then
                photo.Image = Image.FromFile(Open.FileName)
                chaine = Open.FileName
            End If
        End Using
    End Sub
    Public Sub soitEntier(ByVal Salaire As TextBox)
        Dim k As String
        k = Salaire.Text
        If Not IsNumeric(k) And Salaire.Text <> "" Then
            MsgBox("Erreur ! Veuillez saisir un entier.", MsgBoxStyle.Critical + vbOKOnly, "Message D'erreur !!!")
        End If
    End Sub
End Module
