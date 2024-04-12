Public Class Bienvenue

    Private Sub BT_CONTINUER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CONTINUER.Click
        Me.TIM_TIM.Enabled = True
        Me.BT_CONTINUER.Enabled = False
        Me.PGB_TIM.Visible = True
        Me.LBL_CHARGEMENT.Text = "Veuillez patienter! Chargement en cours..."
    End Sub

    Private Sub TIM_TIM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_TIM.Tick
        Me.BT_CONTINUER.Visible = False
        Me.PGB_TIM.Value = PGB_TIM.Value + 1
        If Me.PGB_TIM.Value = 100 Then
            Me.TIM_TIM.Enabled = False
            Pass.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Bienvenue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
