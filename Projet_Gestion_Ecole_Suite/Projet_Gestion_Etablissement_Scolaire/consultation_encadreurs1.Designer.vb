<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultation_encadreurs1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultation_encadreurs1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.RechercheConsultationEncadreurs1 = New System.Windows.Forms.ToolStripTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalaireConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.FonctionConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.GenreConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.PrenomsConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.NomConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.IdConsultationEncadreurs1 = New System.Windows.Forms.RadioButton()
        Me.dgv_consultation_encadreurs1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RechercherConsultationEncadreurs1 = New System.Windows.Forms.ToolStripButton()
        Me.RetourConsultationEncadreurs1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_consultation_encadreurs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(21, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 85)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Location = New System.Drawing.Point(374, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 33)
        Me.Panel3.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercherConsultationEncadreurs1, Me.RechercheConsultationEncadreurs1, Me.RetourConsultationEncadreurs1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(193, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'RechercheConsultationEncadreurs1
        '
        Me.RechercheConsultationEncadreurs1.Name = "RechercheConsultationEncadreurs1"
        Me.RechercheConsultationEncadreurs1.Size = New System.Drawing.Size(100, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.SalaireConsultationEncadreurs1)
        Me.GroupBox1.Controls.Add(Me.FonctionConsultationEncadreurs1)
        Me.GroupBox1.Controls.Add(Me.GenreConsultationEncadreurs1)
        Me.GroupBox1.Controls.Add(Me.PrenomsConsultationEncadreurs1)
        Me.GroupBox1.Controls.Add(Me.NomConsultationEncadreurs1)
        Me.GroupBox1.Controls.Add(Me.IdConsultationEncadreurs1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(138, 429)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 104)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Critères de recherche"
        '
        'SalaireConsultationEncadreurs1
        '
        Me.SalaireConsultationEncadreurs1.AutoSize = True
        Me.SalaireConsultationEncadreurs1.Location = New System.Drawing.Point(583, 66)
        Me.SalaireConsultationEncadreurs1.Name = "SalaireConsultationEncadreurs1"
        Me.SalaireConsultationEncadreurs1.Size = New System.Drawing.Size(89, 20)
        Me.SalaireConsultationEncadreurs1.TabIndex = 5
        Me.SalaireConsultationEncadreurs1.TabStop = True
        Me.SalaireConsultationEncadreurs1.Text = "SALAIRE"
        Me.SalaireConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'FonctionConsultationEncadreurs1
        '
        Me.FonctionConsultationEncadreurs1.AutoSize = True
        Me.FonctionConsultationEncadreurs1.Location = New System.Drawing.Point(309, 66)
        Me.FonctionConsultationEncadreurs1.Name = "FonctionConsultationEncadreurs1"
        Me.FonctionConsultationEncadreurs1.Size = New System.Drawing.Size(103, 20)
        Me.FonctionConsultationEncadreurs1.TabIndex = 4
        Me.FonctionConsultationEncadreurs1.TabStop = True
        Me.FonctionConsultationEncadreurs1.Text = "FONCTION"
        Me.FonctionConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'GenreConsultationEncadreurs1
        '
        Me.GenreConsultationEncadreurs1.AutoSize = True
        Me.GenreConsultationEncadreurs1.Location = New System.Drawing.Point(34, 66)
        Me.GenreConsultationEncadreurs1.Name = "GenreConsultationEncadreurs1"
        Me.GenreConsultationEncadreurs1.Size = New System.Drawing.Size(79, 20)
        Me.GenreConsultationEncadreurs1.TabIndex = 3
        Me.GenreConsultationEncadreurs1.TabStop = True
        Me.GenreConsultationEncadreurs1.Text = "GENRE"
        Me.GenreConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'PrenomsConsultationEncadreurs1
        '
        Me.PrenomsConsultationEncadreurs1.AutoSize = True
        Me.PrenomsConsultationEncadreurs1.Location = New System.Drawing.Point(583, 33)
        Me.PrenomsConsultationEncadreurs1.Name = "PrenomsConsultationEncadreurs1"
        Me.PrenomsConsultationEncadreurs1.Size = New System.Drawing.Size(101, 20)
        Me.PrenomsConsultationEncadreurs1.TabIndex = 2
        Me.PrenomsConsultationEncadreurs1.TabStop = True
        Me.PrenomsConsultationEncadreurs1.Text = "PRENOMS"
        Me.PrenomsConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'NomConsultationEncadreurs1
        '
        Me.NomConsultationEncadreurs1.AutoSize = True
        Me.NomConsultationEncadreurs1.Location = New System.Drawing.Point(309, 33)
        Me.NomConsultationEncadreurs1.Name = "NomConsultationEncadreurs1"
        Me.NomConsultationEncadreurs1.Size = New System.Drawing.Size(60, 20)
        Me.NomConsultationEncadreurs1.TabIndex = 1
        Me.NomConsultationEncadreurs1.TabStop = True
        Me.NomConsultationEncadreurs1.Text = "NOM"
        Me.NomConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'IdConsultationEncadreurs1
        '
        Me.IdConsultationEncadreurs1.AutoSize = True
        Me.IdConsultationEncadreurs1.Location = New System.Drawing.Point(34, 33)
        Me.IdConsultationEncadreurs1.Name = "IdConsultationEncadreurs1"
        Me.IdConsultationEncadreurs1.Size = New System.Drawing.Size(41, 20)
        Me.IdConsultationEncadreurs1.TabIndex = 0
        Me.IdConsultationEncadreurs1.TabStop = True
        Me.IdConsultationEncadreurs1.Text = "ID"
        Me.IdConsultationEncadreurs1.UseVisualStyleBackColor = True
        '
        'dgv_consultation_encadreurs1
        '
        Me.dgv_consultation_encadreurs1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_consultation_encadreurs1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultation_encadreurs1.Location = New System.Drawing.Point(19, 93)
        Me.dgv_consultation_encadreurs1.Name = "dgv_consultation_encadreurs1"
        Me.dgv_consultation_encadreurs1.Size = New System.Drawing.Size(945, 330)
        Me.dgv_consultation_encadreurs1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.education1
        Me.PictureBox2.Location = New System.Drawing.Point(803, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.gn__1_
        Me.PictureBox1.Location = New System.Drawing.Point(26, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RechercherConsultationEncadreurs1
        '
        Me.RechercherConsultationEncadreurs1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RechercherConsultationEncadreurs1.Image = CType(resources.GetObject("RechercherConsultationEncadreurs1.Image"), System.Drawing.Image)
        Me.RechercherConsultationEncadreurs1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RechercherConsultationEncadreurs1.Name = "RechercherConsultationEncadreurs1"
        Me.RechercherConsultationEncadreurs1.Size = New System.Drawing.Size(23, 22)
        Me.RechercherConsultationEncadreurs1.Text = "RECHERCHER"
        '
        'RetourConsultationEncadreurs1
        '
        Me.RetourConsultationEncadreurs1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RetourConsultationEncadreurs1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.arrow_left_c2
        Me.RetourConsultationEncadreurs1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetourConsultationEncadreurs1.Name = "RetourConsultationEncadreurs1"
        Me.RetourConsultationEncadreurs1.Size = New System.Drawing.Size(23, 22)
        Me.RetourConsultationEncadreurs1.Text = "RETOUR"
        '
        'consultation_encadreurs1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(983, 540)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_consultation_encadreurs1)
        Me.MaximizeBox = False
        Me.Name = "consultation_encadreurs1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE CONSULTATION GENERALE DES ENCADREURS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_consultation_encadreurs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents RechercherConsultationEncadreurs1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercheConsultationEncadreurs1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RetourConsultationEncadreurs1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SalaireConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents FonctionConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents GenreConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents PrenomsConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents NomConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents IdConsultationEncadreurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_consultation_encadreurs1 As System.Windows.Forms.DataGridView
End Class
