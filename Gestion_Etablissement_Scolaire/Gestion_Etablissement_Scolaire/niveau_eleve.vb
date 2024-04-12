Public Class niveau_eleve

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onzesm.CheckedChanged

    End Sub

    Private Sub niveau_eleve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub verifie_classe()
        If sept.Checked = True Then
            tabletexte.Text = "table_eleve"
            eleve.classe.Text = "7 EME/"
        ElseIf huit.Checked = True Then
            tabletexte.Text = "table_8"
            eleve.classe.Text = "8 EME/"
        ElseIf neuf.Checked = True Then
            tabletexte.Text = "table_9"
            eleve.classe.Text = "9 EME/"
        ElseIf ix.Checked = True Then
            tabletexte.Text = "table_10"
            eleve.classe.Text = "10 EME/"
        ElseIf onzesm.Checked = True Then
            tabletexte.Text = "table_11sm"
            eleve.classe.Text = "11 EME/SM"
        ElseIf ouzese.Checked = True Then
            tabletexte.Text = "table_11se"
            eleve.classe.Text = "11 EME/SE"
        ElseIf onzess.Checked = True Then
            tabletexte.Text = "table_11ss"
            eleve.classe.Text = "11 EME/SS"
        ElseIf ouzesm.Checked = True Then
            tabletexte.Text = "table_12sm"
            eleve.classe.Text = "12 EME/SM"
        ElseIf ouzesse.Checked = True Then
            tabletexte.Text = "table_12se"
            eleve.classe.Text = "12 EME/SE"
        ElseIf ouzess.Checked Then
            tabletexte.Text = "table_12ss"
            eleve.classe.Text = "12 EME/SS"
        ElseIf tsm.Checked = True Then
            tabletexte.Text = "tsm"
            eleve.classe.Text = "TSM"
        ElseIf tse.Checked = True Then
            tabletexte.Text = "tse"
            eleve.classe.Text = "TSE"
        Else
            tabletexte.Text = "tss"
            eleve.classe.Text = "TSS"
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verifie_classe()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class