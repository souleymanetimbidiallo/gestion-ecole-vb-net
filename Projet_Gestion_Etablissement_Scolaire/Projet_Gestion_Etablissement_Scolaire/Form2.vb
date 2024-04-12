Public Class menu_general

    Private Sub menu_general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Text = "" Then
            Label1.Text = "GROUPE SCOLAIRE AFRIQUE ELITES"
        ElseIf Label1.Text = "GROUPE SCOLAIRE AFRIQUE ELITES" Then
            Label1.Text = ""
        End If
    End Sub

    Private Sub ConsultationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationToolStripMenuItem2.Click

    End Sub
End Class