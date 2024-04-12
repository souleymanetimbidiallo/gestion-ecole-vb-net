<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultation_professeurs1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultation_professeurs1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RechercherConsultationProfesseurs1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RetourConsultationProfesseurs1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_consultation_professeurs1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContactConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.GenreConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.MatiereConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.SalaireConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.NombreClasseConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.PrenomsConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.NomConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.IdConsultationProfesseurs1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_consultation_professeurs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(19, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(952, 55)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(845, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.gn__1_
        Me.PictureBox1.Location = New System.Drawing.Point(35, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Location = New System.Drawing.Point(380, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 33)
        Me.Panel3.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.RechercherConsultationProfesseurs1, Me.RetourConsultationProfesseurs1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(193, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "RECHERCHER"
        '
        'RechercherConsultationProfesseurs1
        '
        Me.RechercherConsultationProfesseurs1.Name = "RechercherConsultationProfesseurs1"
        Me.RechercherConsultationProfesseurs1.Size = New System.Drawing.Size(100, 25)
        '
        'RetourConsultationProfesseurs1
        '
        Me.RetourConsultationProfesseurs1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RetourConsultationProfesseurs1.Image = CType(resources.GetObject("RetourConsultationProfesseurs1.Image"), System.Drawing.Image)
        Me.RetourConsultationProfesseurs1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetourConsultationProfesseurs1.Name = "RetourConsultationProfesseurs1"
        Me.RetourConsultationProfesseurs1.Size = New System.Drawing.Size(23, 22)
        Me.RetourConsultationProfesseurs1.Text = "RETOUR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_consultation_professeurs1)
        Me.Panel2.Location = New System.Drawing.Point(12, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(967, 336)
        Me.Panel2.TabIndex = 11
        '
        'dgv_consultation_professeurs1
        '
        Me.dgv_consultation_professeurs1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_consultation_professeurs1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultation_professeurs1.Location = New System.Drawing.Point(11, 4)
        Me.dgv_consultation_professeurs1.Name = "dgv_consultation_professeurs1"
        Me.dgv_consultation_professeurs1.Size = New System.Drawing.Size(948, 329)
        Me.dgv_consultation_professeurs1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.ContactConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.GenreConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.MatiereConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.SalaireConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.NombreClasseConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.PrenomsConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.NomConsultationProfesseurs1)
        Me.GroupBox1.Controls.Add(Me.IdConsultationProfesseurs1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 117)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Critères de recherche"
        '
        'ContactConsultationProfesseurs1
        '
        Me.ContactConsultationProfesseurs1.AutoSize = True
        Me.ContactConsultationProfesseurs1.Location = New System.Drawing.Point(837, 66)
        Me.ContactConsultationProfesseurs1.Name = "ContactConsultationProfesseurs1"
        Me.ContactConsultationProfesseurs1.Size = New System.Drawing.Size(98, 20)
        Me.ContactConsultationProfesseurs1.TabIndex = 7
        Me.ContactConsultationProfesseurs1.TabStop = True
        Me.ContactConsultationProfesseurs1.Text = "CONTACT"
        Me.ContactConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'GenreConsultationProfesseurs1
        '
        Me.GenreConsultationProfesseurs1.AutoSize = True
        Me.GenreConsultationProfesseurs1.Location = New System.Drawing.Point(837, 33)
        Me.GenreConsultationProfesseurs1.Name = "GenreConsultationProfesseurs1"
        Me.GenreConsultationProfesseurs1.Size = New System.Drawing.Size(79, 20)
        Me.GenreConsultationProfesseurs1.TabIndex = 6
        Me.GenreConsultationProfesseurs1.TabStop = True
        Me.GenreConsultationProfesseurs1.Text = "GENRE"
        Me.GenreConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'MatiereConsultationProfesseurs1
        '
        Me.MatiereConsultationProfesseurs1.AutoSize = True
        Me.MatiereConsultationProfesseurs1.Location = New System.Drawing.Point(620, 66)
        Me.MatiereConsultationProfesseurs1.Name = "MatiereConsultationProfesseurs1"
        Me.MatiereConsultationProfesseurs1.Size = New System.Drawing.Size(113, 20)
        Me.MatiereConsultationProfesseurs1.TabIndex = 5
        Me.MatiereConsultationProfesseurs1.TabStop = True
        Me.MatiereConsultationProfesseurs1.Text = "MATIERE(S)"
        Me.MatiereConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'SalaireConsultationProfesseurs1
        '
        Me.SalaireConsultationProfesseurs1.AutoSize = True
        Me.SalaireConsultationProfesseurs1.Location = New System.Drawing.Point(419, 66)
        Me.SalaireConsultationProfesseurs1.Name = "SalaireConsultationProfesseurs1"
        Me.SalaireConsultationProfesseurs1.Size = New System.Drawing.Size(89, 20)
        Me.SalaireConsultationProfesseurs1.TabIndex = 4
        Me.SalaireConsultationProfesseurs1.TabStop = True
        Me.SalaireConsultationProfesseurs1.Text = "SALAIRE"
        Me.SalaireConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'NombreClasseConsultationProfesseurs1
        '
        Me.NombreClasseConsultationProfesseurs1.AutoSize = True
        Me.NombreClasseConsultationProfesseurs1.Location = New System.Drawing.Point(45, 66)
        Me.NombreClasseConsultationProfesseurs1.Name = "NombreClasseConsultationProfesseurs1"
        Me.NombreClasseConsultationProfesseurs1.Size = New System.Drawing.Size(251, 20)
        Me.NombreClasseConsultationProfesseurs1.TabIndex = 3
        Me.NombreClasseConsultationProfesseurs1.TabStop = True
        Me.NombreClasseConsultationProfesseurs1.Text = "NBRE DE CLASSE(S) TENUE(S)"
        Me.NombreClasseConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'PrenomsConsultationProfesseurs1
        '
        Me.PrenomsConsultationProfesseurs1.AutoSize = True
        Me.PrenomsConsultationProfesseurs1.Location = New System.Drawing.Point(620, 33)
        Me.PrenomsConsultationProfesseurs1.Name = "PrenomsConsultationProfesseurs1"
        Me.PrenomsConsultationProfesseurs1.Size = New System.Drawing.Size(101, 20)
        Me.PrenomsConsultationProfesseurs1.TabIndex = 2
        Me.PrenomsConsultationProfesseurs1.TabStop = True
        Me.PrenomsConsultationProfesseurs1.Text = "PRENOMS"
        Me.PrenomsConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'NomConsultationProfesseurs1
        '
        Me.NomConsultationProfesseurs1.AutoSize = True
        Me.NomConsultationProfesseurs1.Location = New System.Drawing.Point(419, 33)
        Me.NomConsultationProfesseurs1.Name = "NomConsultationProfesseurs1"
        Me.NomConsultationProfesseurs1.Size = New System.Drawing.Size(60, 20)
        Me.NomConsultationProfesseurs1.TabIndex = 1
        Me.NomConsultationProfesseurs1.TabStop = True
        Me.NomConsultationProfesseurs1.Text = "NOM"
        Me.NomConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'IdConsultationProfesseurs1
        '
        Me.IdConsultationProfesseurs1.AutoSize = True
        Me.IdConsultationProfesseurs1.Location = New System.Drawing.Point(45, 33)
        Me.IdConsultationProfesseurs1.Name = "IdConsultationProfesseurs1"
        Me.IdConsultationProfesseurs1.Size = New System.Drawing.Size(41, 20)
        Me.IdConsultationProfesseurs1.TabIndex = 0
        Me.IdConsultationProfesseurs1.TabStop = True
        Me.IdConsultationProfesseurs1.Text = "ID"
        Me.IdConsultationProfesseurs1.UseVisualStyleBackColor = True
        '
        'consultation_professeurs1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(991, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "consultation_professeurs1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE CONSULTATION GENERALE DES PROFESSEURS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_consultation_professeurs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercherConsultationProfesseurs1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RetourConsultationProfesseurs1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv_consultation_professeurs1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MatiereConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents SalaireConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents NombreClasseConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents PrenomsConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents NomConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents IdConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents ContactConsultationProfesseurs1 As System.Windows.Forms.RadioButton
    Friend WithEvents GenreConsultationProfesseurs1 As System.Windows.Forms.RadioButton
End Class
