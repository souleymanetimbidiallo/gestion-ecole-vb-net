<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suppression_professeurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(suppression_professeurs))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenoms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_de_naissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lieu_de_naissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_classe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.classe_tenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taux_horaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_heures = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quartier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.e_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SUPPRIMERDEFINITIVEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripTextBox1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(996, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(8, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 491)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nom, Me.prenoms, Me.genre, Me.date_de_naissance, Me.lieu_de_naissance, Me.matiere, Me.nombre_classe, Me.classe_tenue, Me.taux_horaire, Me.nombre_heures, Me.salaire, Me.contact, Me.quartier, Me.e_mail})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(17, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(946, 475)
        Me.DataGridView1.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'nom
        '
        Me.nom.HeaderText = "NOM"
        Me.nom.Name = "nom"
        '
        'prenoms
        '
        Me.prenoms.HeaderText = "PRENOMS"
        Me.prenoms.Name = "prenoms"
        '
        'genre
        '
        Me.genre.HeaderText = "GENRE"
        Me.genre.Name = "genre"
        '
        'date_de_naissance
        '
        Me.date_de_naissance.HeaderText = "DATE DE NAISSANCE"
        Me.date_de_naissance.Name = "date_de_naissance"
        '
        'lieu_de_naissance
        '
        Me.lieu_de_naissance.HeaderText = "LIEU DE NAISSANCE"
        Me.lieu_de_naissance.Name = "lieu_de_naissance"
        '
        'matiere
        '
        Me.matiere.HeaderText = "MATIERE(S)"
        Me.matiere.Name = "matiere"
        '
        'nombre_classe
        '
        Me.nombre_classe.HeaderText = "NOMBRE DE CLASSE(S) TENUE(S)"
        Me.nombre_classe.Name = "nombre_classe"
        '
        'classe_tenue
        '
        Me.classe_tenue.HeaderText = "CLASSE(S) TENUE(S)"
        Me.classe_tenue.Name = "classe_tenue"
        '
        'taux_horaire
        '
        Me.taux_horaire.HeaderText = "TAUX HORAIRE"
        Me.taux_horaire.Name = "taux_horaire"
        '
        'nombre_heures
        '
        Me.nombre_heures.HeaderText = "NOMBRE D'HEURES/S"
        Me.nombre_heures.Name = "nombre_heures"
        '
        'salaire
        '
        Me.salaire.HeaderText = "SALAIRE MENSUEL"
        Me.salaire.Name = "salaire"
        '
        'contact
        '
        Me.contact.HeaderText = "CONTACT"
        Me.contact.Name = "contact"
        '
        'quartier
        '
        Me.quartier.HeaderText = "QUARTIER"
        Me.quartier.Name = "quartier"
        '
        'e_mail
        '
        Me.e_mail.HeaderText = "E-MAIL"
        Me.e_mail.Name = "e_mail"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUPPRIMERDEFINITIVEMENTToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(231, 26)
        '
        'SUPPRIMERDEFINITIVEMENTToolStripMenuItem
        '
        Me.SUPPRIMERDEFINITIVEMENTToolStripMenuItem.Name = "SUPPRIMERDEFINITIVEMENTToolStripMenuItem"
        Me.SUPPRIMERDEFINITIVEMENTToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SUPPRIMERDEFINITIVEMENTToolStripMenuItem.Text = "SUPPRIMER DEFINITIVEMENT"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "SUPPRIMER"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "RETOUR"
        '
        'suppression_professeurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(996, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "suppression_professeurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE SUPPRESSION DES PROFESSEURS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prenoms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_de_naissance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lieu_de_naissance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matiere As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_classe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents classe_tenue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taux_horaire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_heures As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salaire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quartier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents e_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SUPPRIMERDEFINITIVEMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
