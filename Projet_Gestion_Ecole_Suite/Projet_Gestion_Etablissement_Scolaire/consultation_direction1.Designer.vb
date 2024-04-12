<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultation_direction1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultation_direction1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_consultation_direction1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalaireConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.FonctionConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.GenreConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.PrenomsConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.NomConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.IdConsultationDirection1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.RechercheConsultationDirection1 = New System.Windows.Forms.ToolStripTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RechercherConsultationDirection1 = New System.Windows.Forms.ToolStripButton()
        Me.RetourConsultationDirection1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_consultation_direction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_consultation_direction1)
        Me.Panel2.Location = New System.Drawing.Point(12, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 333)
        Me.Panel2.TabIndex = 3
        '
        'dgv_consultation_direction1
        '
        Me.dgv_consultation_direction1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultation_direction1.Location = New System.Drawing.Point(3, 3)
        Me.dgv_consultation_direction1.Name = "dgv_consultation_direction1"
        Me.dgv_consultation_direction1.Size = New System.Drawing.Size(948, 323)
        Me.dgv_consultation_direction1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.SalaireConsultationDirection1)
        Me.GroupBox1.Controls.Add(Me.FonctionConsultationDirection1)
        Me.GroupBox1.Controls.Add(Me.GenreConsultationDirection1)
        Me.GroupBox1.Controls.Add(Me.PrenomsConsultationDirection1)
        Me.GroupBox1.Controls.Add(Me.NomConsultationDirection1)
        Me.GroupBox1.Controls.Add(Me.IdConsultationDirection1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(138, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 104)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Critères de recherche"
        '
        'SalaireConsultationDirection1
        '
        Me.SalaireConsultationDirection1.AutoSize = True
        Me.SalaireConsultationDirection1.Location = New System.Drawing.Point(583, 66)
        Me.SalaireConsultationDirection1.Name = "SalaireConsultationDirection1"
        Me.SalaireConsultationDirection1.Size = New System.Drawing.Size(89, 20)
        Me.SalaireConsultationDirection1.TabIndex = 5
        Me.SalaireConsultationDirection1.TabStop = True
        Me.SalaireConsultationDirection1.Text = "SALAIRE"
        Me.SalaireConsultationDirection1.UseVisualStyleBackColor = True
        '
        'FonctionConsultationDirection1
        '
        Me.FonctionConsultationDirection1.AutoSize = True
        Me.FonctionConsultationDirection1.Location = New System.Drawing.Point(309, 66)
        Me.FonctionConsultationDirection1.Name = "FonctionConsultationDirection1"
        Me.FonctionConsultationDirection1.Size = New System.Drawing.Size(103, 20)
        Me.FonctionConsultationDirection1.TabIndex = 4
        Me.FonctionConsultationDirection1.TabStop = True
        Me.FonctionConsultationDirection1.Text = "FONCTION"
        Me.FonctionConsultationDirection1.UseVisualStyleBackColor = True
        '
        'GenreConsultationDirection1
        '
        Me.GenreConsultationDirection1.AutoSize = True
        Me.GenreConsultationDirection1.Location = New System.Drawing.Point(34, 66)
        Me.GenreConsultationDirection1.Name = "GenreConsultationDirection1"
        Me.GenreConsultationDirection1.Size = New System.Drawing.Size(79, 20)
        Me.GenreConsultationDirection1.TabIndex = 3
        Me.GenreConsultationDirection1.TabStop = True
        Me.GenreConsultationDirection1.Text = "GENRE"
        Me.GenreConsultationDirection1.UseVisualStyleBackColor = True
        '
        'PrenomsConsultationDirection1
        '
        Me.PrenomsConsultationDirection1.AutoSize = True
        Me.PrenomsConsultationDirection1.Location = New System.Drawing.Point(583, 33)
        Me.PrenomsConsultationDirection1.Name = "PrenomsConsultationDirection1"
        Me.PrenomsConsultationDirection1.Size = New System.Drawing.Size(101, 20)
        Me.PrenomsConsultationDirection1.TabIndex = 2
        Me.PrenomsConsultationDirection1.TabStop = True
        Me.PrenomsConsultationDirection1.Text = "PRENOMS"
        Me.PrenomsConsultationDirection1.UseVisualStyleBackColor = True
        '
        'NomConsultationDirection1
        '
        Me.NomConsultationDirection1.AutoSize = True
        Me.NomConsultationDirection1.Location = New System.Drawing.Point(309, 33)
        Me.NomConsultationDirection1.Name = "NomConsultationDirection1"
        Me.NomConsultationDirection1.Size = New System.Drawing.Size(60, 20)
        Me.NomConsultationDirection1.TabIndex = 1
        Me.NomConsultationDirection1.TabStop = True
        Me.NomConsultationDirection1.Text = "NOM"
        Me.NomConsultationDirection1.UseVisualStyleBackColor = True
        '
        'IdConsultationDirection1
        '
        Me.IdConsultationDirection1.AutoSize = True
        Me.IdConsultationDirection1.Location = New System.Drawing.Point(34, 33)
        Me.IdConsultationDirection1.Name = "IdConsultationDirection1"
        Me.IdConsultationDirection1.Size = New System.Drawing.Size(41, 20)
        Me.IdConsultationDirection1.TabIndex = 0
        Me.IdConsultationDirection1.TabStop = True
        Me.IdConsultationDirection1.Text = "ID"
        Me.IdConsultationDirection1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(26, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 85)
        Me.Panel1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Location = New System.Drawing.Point(376, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(188, 33)
        Me.Panel3.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercherConsultationDirection1, Me.RechercheConsultationDirection1, Me.RetourConsultationDirection1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(188, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'RechercheConsultationDirection1
        '
        Me.RechercheConsultationDirection1.Name = "RechercheConsultationDirection1"
        Me.RechercheConsultationDirection1.Size = New System.Drawing.Size(100, 25)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources._001491_
        Me.PictureBox2.Location = New System.Drawing.Point(825, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.images__41_
        Me.PictureBox1.Location = New System.Drawing.Point(26, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RechercherConsultationDirection1
        '
        Me.RechercherConsultationDirection1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RechercherConsultationDirection1.ForeColor = System.Drawing.Color.Black
        Me.RechercherConsultationDirection1.Image = CType(resources.GetObject("RechercherConsultationDirection1.Image"), System.Drawing.Image)
        Me.RechercherConsultationDirection1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RechercherConsultationDirection1.Name = "RechercherConsultationDirection1"
        Me.RechercherConsultationDirection1.Size = New System.Drawing.Size(23, 22)
        Me.RechercherConsultationDirection1.Text = "RECHERCHER"
        '
        'RetourConsultationDirection1
        '
        Me.RetourConsultationDirection1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RetourConsultationDirection1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.arrow_left_c
        Me.RetourConsultationDirection1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetourConsultationDirection1.Name = "RetourConsultationDirection1"
        Me.RetourConsultationDirection1.Size = New System.Drawing.Size(23, 22)
        Me.RetourConsultationDirection1.Text = "RETOUR"
        '
        'consultation_direction1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(982, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "consultation_direction1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTATION GENERALE DES PERSONNELS DE LA DIRECTION"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_consultation_direction1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PrenomsConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents NomConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents IdConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents SalaireConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents FonctionConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents GenreConsultationDirection1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents RechercherConsultationDirection1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercheConsultationDirection1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RetourConsultationDirection1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgv_consultation_direction1 As System.Windows.Forms.DataGridView
End Class
