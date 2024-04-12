<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modification_direction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modification_direction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AnnulerModificationDirection = New System.Windows.Forms.Button()
        Me.RetourModificationDirection = New System.Windows.Forms.Button()
        Me.ModifierModificationDirection = New System.Windows.Forms.Button()
        Me.ContactModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuartierModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalaireModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FonctionModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LieuModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateModificationDirection = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrenomsModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomModificationDirection = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_modification_direction = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MODIFIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RechercheModificationDirection = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_modification_direction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Controls.Add(Me.AnnulerModificationDirection)
        Me.GroupBox1.Controls.Add(Me.RetourModificationDirection)
        Me.GroupBox1.Controls.Add(Me.ModifierModificationDirection)
        Me.GroupBox1.Controls.Add(Me.ContactModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.QuartierModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SalaireModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.FonctionModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LieuModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PrenomsModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NomModificationDirection)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 160)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modification"
        '
        'AnnulerModificationDirection
        '
        Me.AnnulerModificationDirection.BackColor = System.Drawing.Color.Maroon
        Me.AnnulerModificationDirection.ForeColor = System.Drawing.Color.Yellow
        Me.AnnulerModificationDirection.Location = New System.Drawing.Point(664, 113)
        Me.AnnulerModificationDirection.Name = "AnnulerModificationDirection"
        Me.AnnulerModificationDirection.Size = New System.Drawing.Size(174, 35)
        Me.AnnulerModificationDirection.TabIndex = 18
        Me.AnnulerModificationDirection.Text = "ANNULER >>"
        Me.AnnulerModificationDirection.UseVisualStyleBackColor = False
        '
        'RetourModificationDirection
        '
        Me.RetourModificationDirection.BackColor = System.Drawing.Color.Maroon
        Me.RetourModificationDirection.ForeColor = System.Drawing.Color.Yellow
        Me.RetourModificationDirection.Location = New System.Drawing.Point(150, 113)
        Me.RetourModificationDirection.Name = "RetourModificationDirection"
        Me.RetourModificationDirection.Size = New System.Drawing.Size(174, 35)
        Me.RetourModificationDirection.TabIndex = 17
        Me.RetourModificationDirection.Text = "<< RETOUR"
        Me.RetourModificationDirection.UseVisualStyleBackColor = False
        '
        'ModifierModificationDirection
        '
        Me.ModifierModificationDirection.BackColor = System.Drawing.Color.Maroon
        Me.ModifierModificationDirection.ForeColor = System.Drawing.Color.Yellow
        Me.ModifierModificationDirection.Location = New System.Drawing.Point(407, 113)
        Me.ModifierModificationDirection.Name = "ModifierModificationDirection"
        Me.ModifierModificationDirection.Size = New System.Drawing.Size(174, 35)
        Me.ModifierModificationDirection.TabIndex = 16
        Me.ModifierModificationDirection.Text = "<< MODIFIER >>"
        Me.ModifierModificationDirection.UseVisualStyleBackColor = False
        '
        'ContactModificationDirection
        '
        Me.ContactModificationDirection.Location = New System.Drawing.Point(597, 78)
        Me.ContactModificationDirection.Name = "ContactModificationDirection"
        Me.ContactModificationDirection.Size = New System.Drawing.Size(156, 20)
        Me.ContactModificationDirection.TabIndex = 6
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
        'QuartierModificationDirection
        '
        Me.QuartierModificationDirection.Location = New System.Drawing.Point(834, 80)
        Me.QuartierModificationDirection.Name = "QuartierModificationDirection"
        Me.QuartierModificationDirection.Size = New System.Drawing.Size(137, 20)
        Me.QuartierModificationDirection.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(765, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quatier :"
        '
        'SalaireModificationDirection
        '
        Me.SalaireModificationDirection.Location = New System.Drawing.Point(322, 76)
        Me.SalaireModificationDirection.Name = "SalaireModificationDirection"
        Me.SalaireModificationDirection.Size = New System.Drawing.Size(174, 20)
        Me.SalaireModificationDirection.TabIndex = 5
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
        'FonctionModificationDirection
        '
        Me.FonctionModificationDirection.Location = New System.Drawing.Point(83, 78)
        Me.FonctionModificationDirection.Name = "FonctionModificationDirection"
        Me.FonctionModificationDirection.Size = New System.Drawing.Size(146, 20)
        Me.FonctionModificationDirection.TabIndex = 4
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
        'LieuModificationDirection
        '
        Me.LieuModificationDirection.Location = New System.Drawing.Point(834, 27)
        Me.LieuModificationDirection.Name = "LieuModificationDirection"
        Me.LieuModificationDirection.Size = New System.Drawing.Size(137, 20)
        Me.LieuModificationDirection.TabIndex = 3
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
        'DateModificationDirection
        '
        Me.DateModificationDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateModificationDirection.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateModificationDirection.Location = New System.Drawing.Point(597, 28)
        Me.DateModificationDirection.Name = "DateModificationDirection"
        Me.DateModificationDirection.Size = New System.Drawing.Size(156, 21)
        Me.DateModificationDirection.TabIndex = 2
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
        'PrenomsModificationDirection
        '
        Me.PrenomsModificationDirection.Location = New System.Drawing.Point(318, 23)
        Me.PrenomsModificationDirection.Name = "PrenomsModificationDirection"
        Me.PrenomsModificationDirection.Size = New System.Drawing.Size(174, 20)
        Me.PrenomsModificationDirection.TabIndex = 1
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
        'NomModificationDirection
        '
        Me.NomModificationDirection.Location = New System.Drawing.Point(83, 23)
        Me.NomModificationDirection.Name = "NomModificationDirection"
        Me.NomModificationDirection.Size = New System.Drawing.Size(146, 20)
        Me.NomModificationDirection.TabIndex = 0
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
        'dgv_modification_direction
        '
        Me.dgv_modification_direction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_modification_direction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_modification_direction.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_modification_direction.Location = New System.Drawing.Point(34, 35)
        Me.dgv_modification_direction.Name = "dgv_modification_direction"
        Me.dgv_modification_direction.Size = New System.Drawing.Size(945, 330)
        Me.dgv_modification_direction.TabIndex = 6
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
        Me.Panel2.Location = New System.Drawing.Point(12, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 365)
        Me.Panel2.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Salmon
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.RechercheModificationDirection, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
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
        'RechercheModificationDirection
        '
        Me.RechercheModificationDirection.Name = "RechercheModificationDirection"
        Me.RechercheModificationDirection.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Veuillez saisir l'id pour la récherche"
        '
        'modification_direction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1012, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_modification_direction)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "modification_direction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICATION DES PERSONNELS DE LA DIRECTION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_modification_direction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_modification_direction As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ContactModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents QuartierModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SalaireModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FonctionModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LieuModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateModificationDirection As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrenomsModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomModificationDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModifierModificationDirection As System.Windows.Forms.Button
    Friend WithEvents AnnulerModificationDirection As System.Windows.Forms.Button
    Friend WithEvents RetourModificationDirection As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RechercheModificationDirection As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MODIFIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
