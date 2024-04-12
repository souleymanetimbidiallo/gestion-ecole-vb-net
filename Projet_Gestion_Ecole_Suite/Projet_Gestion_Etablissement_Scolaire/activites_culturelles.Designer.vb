<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activites_culturelles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(activites_culturelles))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RechercherEvenement = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ModifierModificationEvenement = New System.Windows.Forms.ToolStripButton()
        Me.SupprimerModificationEvenement = New System.Windows.Forms.ToolStripButton()
        Me.RetourModificationEvenement = New System.Windows.Forms.ToolStripButton()
        Me.dgv_modification_evenement = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BudgetModificationEvenement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DureeModificationEvenement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FinModificationEvenement = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DebutModificationEvenement = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomModificationEvenement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_modification_evenement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.RechercherEvenement, Me.ToolStripButton5, Me.ModifierModificationEvenement, Me.SupprimerModificationEvenement, Me.RetourModificationEvenement})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip1.TabIndex = 2
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
        'RechercherEvenement
        '
        Me.RechercherEvenement.Name = "RechercherEvenement"
        Me.RechercherEvenement.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Veuillez saisir l'id de l'événement pour éffectuer la récherche"
        '
        'ModifierModificationEvenement
        '
        Me.ModifierModificationEvenement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ModifierModificationEvenement.Image = CType(resources.GetObject("ModifierModificationEvenement.Image"), System.Drawing.Image)
        Me.ModifierModificationEvenement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ModifierModificationEvenement.Name = "ModifierModificationEvenement"
        Me.ModifierModificationEvenement.Size = New System.Drawing.Size(23, 22)
        Me.ModifierModificationEvenement.Text = "Modifier l'événement"
        '
        'SupprimerModificationEvenement
        '
        Me.SupprimerModificationEvenement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupprimerModificationEvenement.Image = CType(resources.GetObject("SupprimerModificationEvenement.Image"), System.Drawing.Image)
        Me.SupprimerModificationEvenement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SupprimerModificationEvenement.Name = "SupprimerModificationEvenement"
        Me.SupprimerModificationEvenement.Size = New System.Drawing.Size(23, 22)
        Me.SupprimerModificationEvenement.Text = "Supprimer définitivement l'événement"
        '
        'RetourModificationEvenement
        '
        Me.RetourModificationEvenement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RetourModificationEvenement.Image = CType(resources.GetObject("RetourModificationEvenement.Image"), System.Drawing.Image)
        Me.RetourModificationEvenement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetourModificationEvenement.Name = "RetourModificationEvenement"
        Me.RetourModificationEvenement.Size = New System.Drawing.Size(23, 22)
        Me.RetourModificationEvenement.Text = "Rétour"
        '
        'dgv_modification_evenement
        '
        Me.dgv_modification_evenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_modification_evenement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_modification_evenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_modification_evenement.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_modification_evenement.Location = New System.Drawing.Point(12, 7)
        Me.dgv_modification_evenement.Name = "dgv_modification_evenement"
        Me.dgv_modification_evenement.Size = New System.Drawing.Size(954, 351)
        Me.dgv_modification_evenement.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.RetourToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 70)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ModifierToolStripMenuItem.Text = "1- Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SupprimerToolStripMenuItem.Text = "2- Supprimer"
        '
        'RetourToolStripMenuItem
        '
        Me.RetourToolStripMenuItem.Name = "RetourToolStripMenuItem"
        Me.RetourToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RetourToolStripMenuItem.Text = "3- Retour"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_modification_evenement)
        Me.Panel2.Location = New System.Drawing.Point(9, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 366)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.BudgetModificationEvenement)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DureeModificationEvenement)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.FinModificationEvenement)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DebutModificationEvenement)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NomModificationEvenement)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 121)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modification"
        '
        'BudgetModificationEvenement
        '
        Me.BudgetModificationEvenement.Location = New System.Drawing.Point(613, 77)
        Me.BudgetModificationEvenement.Name = "BudgetModificationEvenement"
        Me.BudgetModificationEvenement.Size = New System.Drawing.Size(267, 20)
        Me.BudgetModificationEvenement.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(424, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "BUDGET DE L'EVENEMENT :"
        '
        'DureeModificationEvenement
        '
        Me.DureeModificationEvenement.Location = New System.Drawing.Point(180, 77)
        Me.DureeModificationEvenement.Name = "DureeModificationEvenement"
        Me.DureeModificationEvenement.Size = New System.Drawing.Size(219, 20)
        Me.DureeModificationEvenement.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(15, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "DUREE DE L'EVENEMENT :"
        '
        'FinModificationEvenement
        '
        Me.FinModificationEvenement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FinModificationEvenement.Location = New System.Drawing.Point(764, 24)
        Me.FinModificationEvenement.Name = "FinModificationEvenement"
        Me.FinModificationEvenement.Size = New System.Drawing.Size(166, 20)
        Me.FinModificationEvenement.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(701, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "FIN :"
        '
        'DebutModificationEvenement
        '
        Me.DebutModificationEvenement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DebutModificationEvenement.Location = New System.Drawing.Point(502, 24)
        Me.DebutModificationEvenement.Name = "DebutModificationEvenement"
        Me.DebutModificationEvenement.Size = New System.Drawing.Size(154, 20)
        Me.DebutModificationEvenement.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(424, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "DEBUT :"
        '
        'NomModificationEvenement
        '
        Me.NomModificationEvenement.Location = New System.Drawing.Point(180, 24)
        Me.NomModificationEvenement.Name = "NomModificationEvenement"
        Me.NomModificationEvenement.Size = New System.Drawing.Size(219, 20)
        Me.NomModificationEvenement.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NOM DE L'EVENEMENT :"
        '
        'activites_culturelles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "activites_culturelles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE MODIFICATION & SUPPRESSION DES EVENEMENTS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_modification_evenement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercherEvenement As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ModifierModificationEvenement As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupprimerModificationEvenement As System.Windows.Forms.ToolStripButton
    Friend WithEvents RetourModificationEvenement As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgv_modification_evenement As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DebutModificationEvenement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomModificationEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BudgetModificationEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DureeModificationEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FinModificationEvenement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
