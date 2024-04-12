<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modification_professeurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modification_professeurs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TauxHoraireModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EmailModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NombreClasseModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClasseModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AnnulerModificationProfesseurs = New System.Windows.Forms.Button()
        Me.RetourModificationProfesseurs = New System.Windows.Forms.Button()
        Me.ModifierModificationProfesseurs = New System.Windows.Forms.Button()
        Me.ContactModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuartierModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalaireModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MatiereModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LieuModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateModificationProfesseurs = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrenomsModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomModificationProfesseurs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_modification_professeurs = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MODIFIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RechercherModificationProfesseurs = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_modification_professeurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgv_modification_professeurs)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 554)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.TauxHoraireModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.EmailModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.NombreClasseModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ClasseModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.AnnulerModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.RetourModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.ModifierModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.ContactModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.QuartierModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SalaireModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MatiereModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LieuModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PrenomsModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NomModificationProfesseurs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 204)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modification"
        '
        'TauxHoraireModificationProfesseurs
        '
        Me.TauxHoraireModificationProfesseurs.Location = New System.Drawing.Point(597, 116)
        Me.TauxHoraireModificationProfesseurs.Name = "TauxHoraireModificationProfesseurs"
        Me.TauxHoraireModificationProfesseurs.Size = New System.Drawing.Size(156, 20)
        Me.TauxHoraireModificationProfesseurs.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(520, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "T Horaire :"
        '
        'EmailModificationProfesseurs
        '
        Me.EmailModificationProfesseurs.Location = New System.Drawing.Point(834, 118)
        Me.EmailModificationProfesseurs.Name = "EmailModificationProfesseurs"
        Me.EmailModificationProfesseurs.Size = New System.Drawing.Size(137, 20)
        Me.EmailModificationProfesseurs.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(764, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "E-mail :"
        '
        'NombreClasseModificationProfesseurs
        '
        Me.NombreClasseModificationProfesseurs.Location = New System.Drawing.Point(337, 114)
        Me.NombreClasseModificationProfesseurs.Name = "NombreClasseModificationProfesseurs"
        Me.NombreClasseModificationProfesseurs.Size = New System.Drawing.Size(174, 20)
        Me.NombreClasseModificationProfesseurs.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Nbre de classe :"
        '
        'ClasseModificationProfesseurs
        '
        Me.ClasseModificationProfesseurs.Location = New System.Drawing.Point(83, 116)
        Me.ClasseModificationProfesseurs.Name = "ClasseModificationProfesseurs"
        Me.ClasseModificationProfesseurs.Size = New System.Drawing.Size(146, 20)
        Me.ClasseModificationProfesseurs.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Classe(s) :"
        '
        'AnnulerModificationProfesseurs
        '
        Me.AnnulerModificationProfesseurs.BackColor = System.Drawing.Color.Maroon
        Me.AnnulerModificationProfesseurs.ForeColor = System.Drawing.Color.Yellow
        Me.AnnulerModificationProfesseurs.Location = New System.Drawing.Point(664, 148)
        Me.AnnulerModificationProfesseurs.Name = "AnnulerModificationProfesseurs"
        Me.AnnulerModificationProfesseurs.Size = New System.Drawing.Size(174, 35)
        Me.AnnulerModificationProfesseurs.TabIndex = 18
        Me.AnnulerModificationProfesseurs.Text = "ANNULER >>"
        Me.AnnulerModificationProfesseurs.UseVisualStyleBackColor = False
        '
        'RetourModificationProfesseurs
        '
        Me.RetourModificationProfesseurs.BackColor = System.Drawing.Color.Maroon
        Me.RetourModificationProfesseurs.ForeColor = System.Drawing.Color.Yellow
        Me.RetourModificationProfesseurs.Location = New System.Drawing.Point(150, 148)
        Me.RetourModificationProfesseurs.Name = "RetourModificationProfesseurs"
        Me.RetourModificationProfesseurs.Size = New System.Drawing.Size(174, 35)
        Me.RetourModificationProfesseurs.TabIndex = 17
        Me.RetourModificationProfesseurs.Text = "<< RETOUR"
        Me.RetourModificationProfesseurs.UseVisualStyleBackColor = False
        '
        'ModifierModificationProfesseurs
        '
        Me.ModifierModificationProfesseurs.BackColor = System.Drawing.Color.Maroon
        Me.ModifierModificationProfesseurs.ForeColor = System.Drawing.Color.Yellow
        Me.ModifierModificationProfesseurs.Location = New System.Drawing.Point(407, 148)
        Me.ModifierModificationProfesseurs.Name = "ModifierModificationProfesseurs"
        Me.ModifierModificationProfesseurs.Size = New System.Drawing.Size(174, 35)
        Me.ModifierModificationProfesseurs.TabIndex = 16
        Me.ModifierModificationProfesseurs.Text = "<< MODIFIER >>"
        Me.ModifierModificationProfesseurs.UseVisualStyleBackColor = False
        '
        'ContactModificationProfesseurs
        '
        Me.ContactModificationProfesseurs.Location = New System.Drawing.Point(597, 71)
        Me.ContactModificationProfesseurs.Name = "ContactModificationProfesseurs"
        Me.ContactModificationProfesseurs.Size = New System.Drawing.Size(156, 20)
        Me.ContactModificationProfesseurs.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(520, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact :"
        '
        'QuartierModificationProfesseurs
        '
        Me.QuartierModificationProfesseurs.Location = New System.Drawing.Point(834, 73)
        Me.QuartierModificationProfesseurs.Name = "QuartierModificationProfesseurs"
        Me.QuartierModificationProfesseurs.Size = New System.Drawing.Size(137, 20)
        Me.QuartierModificationProfesseurs.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(764, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quartier :"
        '
        'SalaireModificationProfesseurs
        '
        Me.SalaireModificationProfesseurs.Location = New System.Drawing.Point(337, 69)
        Me.SalaireModificationProfesseurs.Name = "SalaireModificationProfesseurs"
        Me.SalaireModificationProfesseurs.Size = New System.Drawing.Size(174, 20)
        Me.SalaireModificationProfesseurs.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Salaire :"
        '
        'MatiereModificationProfesseurs
        '
        Me.MatiereModificationProfesseurs.Location = New System.Drawing.Point(83, 71)
        Me.MatiereModificationProfesseurs.Name = "MatiereModificationProfesseurs"
        Me.MatiereModificationProfesseurs.Size = New System.Drawing.Size(146, 20)
        Me.MatiereModificationProfesseurs.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Matière(s) :"
        '
        'LieuModificationProfesseurs
        '
        Me.LieuModificationProfesseurs.Location = New System.Drawing.Point(834, 25)
        Me.LieuModificationProfesseurs.Name = "LieuModificationProfesseurs"
        Me.LieuModificationProfesseurs.Size = New System.Drawing.Size(137, 20)
        Me.LieuModificationProfesseurs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(777, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lieu :"
        '
        'DateModificationProfesseurs
        '
        Me.DateModificationProfesseurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateModificationProfesseurs.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateModificationProfesseurs.Location = New System.Drawing.Point(597, 26)
        Me.DateModificationProfesseurs.Name = "DateModificationProfesseurs"
        Me.DateModificationProfesseurs.Size = New System.Drawing.Size(156, 21)
        Me.DateModificationProfesseurs.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date :"
        '
        'PrenomsModificationProfesseurs
        '
        Me.PrenomsModificationProfesseurs.Location = New System.Drawing.Point(333, 21)
        Me.PrenomsModificationProfesseurs.Name = "PrenomsModificationProfesseurs"
        Me.PrenomsModificationProfesseurs.Size = New System.Drawing.Size(174, 20)
        Me.PrenomsModificationProfesseurs.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénoms :"
        '
        'NomModificationProfesseurs
        '
        Me.NomModificationProfesseurs.Location = New System.Drawing.Point(79, 23)
        Me.NomModificationProfesseurs.Name = "NomModificationProfesseurs"
        Me.NomModificationProfesseurs.Size = New System.Drawing.Size(146, 20)
        Me.NomModificationProfesseurs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'dgv_modification_professeurs
        '
        Me.dgv_modification_professeurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_modification_professeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_modification_professeurs.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_modification_professeurs.Location = New System.Drawing.Point(3, 28)
        Me.dgv_modification_professeurs.Name = "dgv_modification_professeurs"
        Me.dgv_modification_professeurs.Size = New System.Drawing.Size(989, 317)
        Me.dgv_modification_professeurs.TabIndex = 2
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.RechercherModificationProfesseurs, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(991, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'RechercherModificationProfesseurs
        '
        Me.RechercherModificationProfesseurs.Name = "RechercherModificationProfesseurs"
        Me.RechercherModificationProfesseurs.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Veuillez saisir l'id pour la récherche !"
        '
        'modification_professeurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "modification_professeurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE MODIFICATION DES PROFESSEURS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_modification_professeurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercherModificationProfesseurs As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents dgv_modification_professeurs As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TauxHoraireModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmailModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NombreClasseModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ClasseModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AnnulerModificationProfesseurs As System.Windows.Forms.Button
    Friend WithEvents RetourModificationProfesseurs As System.Windows.Forms.Button
    Friend WithEvents ModifierModificationProfesseurs As System.Windows.Forms.Button
    Friend WithEvents ContactModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents QuartierModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SalaireModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MatiereModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LieuModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateModificationProfesseurs As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrenomsModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomModificationProfesseurs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MODIFIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
