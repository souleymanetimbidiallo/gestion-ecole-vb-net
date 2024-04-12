<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modification_encadreurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modification_encadreurs))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AnnulerModificationEncadreurs = New System.Windows.Forms.Button()
        Me.RetourModificationEncadreurs = New System.Windows.Forms.Button()
        Me.ModifierModificationEncadreurs = New System.Windows.Forms.Button()
        Me.ContactModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuartierModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalaireModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FonctionModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LieuModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateModificationEncadreurs = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrenomsModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomModificationEncadreurs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_modification_encadreurs = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MODIFIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.RechercherModificationEncadreurs = New System.Windows.Forms.ToolStripButton()
        Me.RechercheModificationEncadreurs = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_modification_encadreurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.AnnulerModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.RetourModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.ModifierModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.ContactModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.QuartierModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SalaireModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.FonctionModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LieuModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PrenomsModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NomModificationEncadreurs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 160)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modification"
        '
        'AnnulerModificationEncadreurs
        '
        Me.AnnulerModificationEncadreurs.BackColor = System.Drawing.Color.Maroon
        Me.AnnulerModificationEncadreurs.ForeColor = System.Drawing.Color.Yellow
        Me.AnnulerModificationEncadreurs.Location = New System.Drawing.Point(658, 113)
        Me.AnnulerModificationEncadreurs.Name = "AnnulerModificationEncadreurs"
        Me.AnnulerModificationEncadreurs.Size = New System.Drawing.Size(174, 35)
        Me.AnnulerModificationEncadreurs.TabIndex = 18
        Me.AnnulerModificationEncadreurs.Text = "ANNULER >>"
        Me.AnnulerModificationEncadreurs.UseVisualStyleBackColor = False
        '
        'RetourModificationEncadreurs
        '
        Me.RetourModificationEncadreurs.BackColor = System.Drawing.Color.Maroon
        Me.RetourModificationEncadreurs.ForeColor = System.Drawing.Color.Yellow
        Me.RetourModificationEncadreurs.Location = New System.Drawing.Point(144, 113)
        Me.RetourModificationEncadreurs.Name = "RetourModificationEncadreurs"
        Me.RetourModificationEncadreurs.Size = New System.Drawing.Size(174, 35)
        Me.RetourModificationEncadreurs.TabIndex = 17
        Me.RetourModificationEncadreurs.Text = "<< RETOUR"
        Me.RetourModificationEncadreurs.UseVisualStyleBackColor = False
        '
        'ModifierModificationEncadreurs
        '
        Me.ModifierModificationEncadreurs.BackColor = System.Drawing.Color.Maroon
        Me.ModifierModificationEncadreurs.ForeColor = System.Drawing.Color.Yellow
        Me.ModifierModificationEncadreurs.Location = New System.Drawing.Point(401, 113)
        Me.ModifierModificationEncadreurs.Name = "ModifierModificationEncadreurs"
        Me.ModifierModificationEncadreurs.Size = New System.Drawing.Size(174, 35)
        Me.ModifierModificationEncadreurs.TabIndex = 16
        Me.ModifierModificationEncadreurs.Text = "<< MODIFIER >>"
        Me.ModifierModificationEncadreurs.UseVisualStyleBackColor = False
        '
        'ContactModificationEncadreurs
        '
        Me.ContactModificationEncadreurs.Location = New System.Drawing.Point(597, 78)
        Me.ContactModificationEncadreurs.Name = "ContactModificationEncadreurs"
        Me.ContactModificationEncadreurs.Size = New System.Drawing.Size(156, 20)
        Me.ContactModificationEncadreurs.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(520, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact :"
        '
        'QuartierModificationEncadreurs
        '
        Me.QuartierModificationEncadreurs.Location = New System.Drawing.Point(834, 80)
        Me.QuartierModificationEncadreurs.Name = "QuartierModificationEncadreurs"
        Me.QuartierModificationEncadreurs.Size = New System.Drawing.Size(137, 20)
        Me.QuartierModificationEncadreurs.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(764, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quartier :"
        '
        'SalaireModificationEncadreurs
        '
        Me.SalaireModificationEncadreurs.Location = New System.Drawing.Point(322, 76)
        Me.SalaireModificationEncadreurs.Name = "SalaireModificationEncadreurs"
        Me.SalaireModificationEncadreurs.Size = New System.Drawing.Size(174, 20)
        Me.SalaireModificationEncadreurs.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Salaire :"
        '
        'FonctionModificationEncadreurs
        '
        Me.FonctionModificationEncadreurs.Location = New System.Drawing.Point(83, 78)
        Me.FonctionModificationEncadreurs.Name = "FonctionModificationEncadreurs"
        Me.FonctionModificationEncadreurs.Size = New System.Drawing.Size(146, 20)
        Me.FonctionModificationEncadreurs.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fonction :"
        '
        'LieuModificationEncadreurs
        '
        Me.LieuModificationEncadreurs.Location = New System.Drawing.Point(834, 27)
        Me.LieuModificationEncadreurs.Name = "LieuModificationEncadreurs"
        Me.LieuModificationEncadreurs.Size = New System.Drawing.Size(137, 20)
        Me.LieuModificationEncadreurs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(777, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lieu :"
        '
        'DateModificationEncadreurs
        '
        Me.DateModificationEncadreurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateModificationEncadreurs.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateModificationEncadreurs.Location = New System.Drawing.Point(597, 28)
        Me.DateModificationEncadreurs.Name = "DateModificationEncadreurs"
        Me.DateModificationEncadreurs.Size = New System.Drawing.Size(156, 21)
        Me.DateModificationEncadreurs.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date :"
        '
        'PrenomsModificationEncadreurs
        '
        Me.PrenomsModificationEncadreurs.Location = New System.Drawing.Point(318, 23)
        Me.PrenomsModificationEncadreurs.Name = "PrenomsModificationEncadreurs"
        Me.PrenomsModificationEncadreurs.Size = New System.Drawing.Size(174, 20)
        Me.PrenomsModificationEncadreurs.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénoms :"
        '
        'NomModificationEncadreurs
        '
        Me.NomModificationEncadreurs.Location = New System.Drawing.Point(79, 25)
        Me.NomModificationEncadreurs.Name = "NomModificationEncadreurs"
        Me.NomModificationEncadreurs.Size = New System.Drawing.Size(146, 20)
        Me.NomModificationEncadreurs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'dgv_modification_encadreurs
        '
        Me.dgv_modification_encadreurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_modification_encadreurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_modification_encadreurs.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_modification_encadreurs.Location = New System.Drawing.Point(23, 36)
        Me.dgv_modification_encadreurs.Name = "dgv_modification_encadreurs"
        Me.dgv_modification_encadreurs.Size = New System.Drawing.Size(945, 330)
        Me.dgv_modification_encadreurs.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MODIFIERToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 26)
        '
        'MODIFIERToolStripMenuItem
        '
        Me.MODIFIERToolStripMenuItem.Name = "MODIFIERToolStripMenuItem"
        Me.MODIFIERToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MODIFIERToolStripMenuItem.Text = "MODIFIER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Location = New System.Drawing.Point(1, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 365)
        Me.Panel2.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercherModificationEncadreurs, Me.RechercheModificationEncadreurs, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'RechercherModificationEncadreurs
        '
        Me.RechercherModificationEncadreurs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RechercherModificationEncadreurs.Image = CType(resources.GetObject("RechercherModificationEncadreurs.Image"), System.Drawing.Image)
        Me.RechercherModificationEncadreurs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RechercherModificationEncadreurs.Name = "RechercherModificationEncadreurs"
        Me.RechercherModificationEncadreurs.Size = New System.Drawing.Size(23, 22)
        Me.RechercherModificationEncadreurs.Text = "RECHERCHER"
        '
        'RechercheModificationEncadreurs
        '
        Me.RechercheModificationEncadreurs.Name = "RechercheModificationEncadreurs"
        Me.RechercheModificationEncadreurs.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Veuillez saisir l'id pour la récherche"
        '
        'modification_encadreurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(991, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_modification_encadreurs)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "modification_encadreurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE MODIFICATION DES ENCADREURS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_modification_encadreurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AnnulerModificationEncadreurs As System.Windows.Forms.Button
    Friend WithEvents RetourModificationEncadreurs As System.Windows.Forms.Button
    Friend WithEvents ModifierModificationEncadreurs As System.Windows.Forms.Button
    Friend WithEvents ContactModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents QuartierModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SalaireModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FonctionModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LieuModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateModificationEncadreurs As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrenomsModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomModificationEncadreurs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_modification_encadreurs As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents RechercherModificationEncadreurs As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercheModificationEncadreurs As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MODIFIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
