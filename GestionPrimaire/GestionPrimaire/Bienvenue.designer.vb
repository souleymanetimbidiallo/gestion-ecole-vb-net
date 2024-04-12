<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenue
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenue))
        Me.LBL_BIENVENUE = New System.Windows.Forms.Label()
        Me.BT_CONTINUER = New System.Windows.Forms.Button()
        Me.TIM_TIM = New System.Windows.Forms.Timer(Me.components)
        Me.PGB_TIM = New System.Windows.Forms.ProgressBar()
        Me.LBL_CHARGEMENT = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_BIENVENUE
        '
        Me.LBL_BIENVENUE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LBL_BIENVENUE.AutoSize = True
        Me.LBL_BIENVENUE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_BIENVENUE.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BIENVENUE.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.LBL_BIENVENUE.Location = New System.Drawing.Point(244, 25)
        Me.LBL_BIENVENUE.MinimumSize = New System.Drawing.Size(867, 36)
        Me.LBL_BIENVENUE.Name = "LBL_BIENVENUE"
        Me.LBL_BIENVENUE.Size = New System.Drawing.Size(867, 36)
        Me.LBL_BIENVENUE.TabIndex = 0
        Me.LBL_BIENVENUE.Text = "BIENVENUE DANS LA SCOLARITE DU PRIMAIRE"
        '
        'BT_CONTINUER
        '
        Me.BT_CONTINUER.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_CONTINUER.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CONTINUER.Location = New System.Drawing.Point(616, 289)
        Me.BT_CONTINUER.Name = "BT_CONTINUER"
        Me.BT_CONTINUER.Size = New System.Drawing.Size(123, 36)
        Me.BT_CONTINUER.TabIndex = 1
        Me.BT_CONTINUER.Text = "Continuer"
        Me.BT_CONTINUER.UseVisualStyleBackColor = True
        '
        'TIM_TIM
        '
        Me.TIM_TIM.Interval = 50
        '
        'PGB_TIM
        '
        Me.PGB_TIM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PGB_TIM.Location = New System.Drawing.Point(441, 389)
        Me.PGB_TIM.Name = "PGB_TIM"
        Me.PGB_TIM.Size = New System.Drawing.Size(473, 31)
        Me.PGB_TIM.TabIndex = 2
        Me.PGB_TIM.Visible = False
        '
        'LBL_CHARGEMENT
        '
        Me.LBL_CHARGEMENT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_CHARGEMENT.AutoSize = True
        Me.LBL_CHARGEMENT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CHARGEMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CHARGEMENT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LBL_CHARGEMENT.Location = New System.Drawing.Point(478, 301)
        Me.LBL_CHARGEMENT.Name = "LBL_CHARGEMENT"
        Me.LBL_CHARGEMENT.Size = New System.Drawing.Size(0, 24)
        Me.LBL_CHARGEMENT.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(594, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Bienvenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBL_CHARGEMENT)
        Me.Controls.Add(Me.PGB_TIM)
        Me.Controls.Add(Me.BT_CONTINUER)
        Me.Controls.Add(Me.LBL_BIENVENUE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(867, 36)
        Me.Name = "Bienvenue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenue"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_BIENVENUE As System.Windows.Forms.Label
    Friend WithEvents BT_CONTINUER As System.Windows.Forms.Button
    Friend WithEvents TIM_TIM As System.Windows.Forms.Timer
    Friend WithEvents PGB_TIM As System.Windows.Forms.ProgressBar
    Friend WithEvents LBL_CHARGEMENT As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
