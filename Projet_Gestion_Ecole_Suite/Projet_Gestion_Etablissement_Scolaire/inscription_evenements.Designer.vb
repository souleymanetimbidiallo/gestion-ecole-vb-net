<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enregistrement_evenement
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FinEvenement = New System.Windows.Forms.DateTimePicker()
        Me.DebutEvenement = New System.Windows.Forms.DateTimePicker()
        Me.BudgetEvenement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DureeEvenement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SauvegarderEvenement = New System.Windows.Forms.Button()
        Me.NouveauEvenement = New System.Windows.Forms.Button()
        Me.RetourEvenement = New System.Windows.Forms.Button()
        Me.PhotoEvenement = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageEvenement = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomEvenement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_evenement = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImageEvenement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_evenement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.FinEvenement)
        Me.GroupBox1.Controls.Add(Me.DebutEvenement)
        Me.GroupBox1.Controls.Add(Me.BudgetEvenement)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DureeEvenement)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SauvegarderEvenement)
        Me.GroupBox1.Controls.Add(Me.NouveauEvenement)
        Me.GroupBox1.Controls.Add(Me.RetourEvenement)
        Me.GroupBox1.Controls.Add(Me.PhotoEvenement)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NomEvenement)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 265)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMATIONS SUR L'EVENEMENT"
        '
        'FinEvenement
        '
        Me.FinEvenement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FinEvenement.Location = New System.Drawing.Point(205, 100)
        Me.FinEvenement.Name = "FinEvenement"
        Me.FinEvenement.Size = New System.Drawing.Size(409, 20)
        Me.FinEvenement.TabIndex = 2
        '
        'DebutEvenement
        '
        Me.DebutEvenement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DebutEvenement.Location = New System.Drawing.Point(205, 61)
        Me.DebutEvenement.Name = "DebutEvenement"
        Me.DebutEvenement.Size = New System.Drawing.Size(409, 20)
        Me.DebutEvenement.TabIndex = 1
        '
        'BudgetEvenement
        '
        Me.BudgetEvenement.Location = New System.Drawing.Point(205, 176)
        Me.BudgetEvenement.Name = "BudgetEvenement"
        Me.BudgetEvenement.Size = New System.Drawing.Size(409, 20)
        Me.BudgetEvenement.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(15, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "BUDGET DE L'EVENEMENT :"
        '
        'DureeEvenement
        '
        Me.DureeEvenement.Location = New System.Drawing.Point(205, 138)
        Me.DureeEvenement.Name = "DureeEvenement"
        Me.DureeEvenement.Size = New System.Drawing.Size(409, 20)
        Me.DureeEvenement.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(15, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DUREE DE L'EVENEMENT :"
        '
        'SauvegarderEvenement
        '
        Me.SauvegarderEvenement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SauvegarderEvenement.ForeColor = System.Drawing.Color.Yellow
        Me.SauvegarderEvenement.Location = New System.Drawing.Point(451, 211)
        Me.SauvegarderEvenement.Name = "SauvegarderEvenement"
        Me.SauvegarderEvenement.Size = New System.Drawing.Size(163, 41)
        Me.SauvegarderEvenement.TabIndex = 10
        Me.SauvegarderEvenement.Text = "SAUVEGARDER >>"
        Me.SauvegarderEvenement.UseVisualStyleBackColor = False
        '
        'NouveauEvenement
        '
        Me.NouveauEvenement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NouveauEvenement.ForeColor = System.Drawing.Color.Yellow
        Me.NouveauEvenement.Location = New System.Drawing.Point(233, 211)
        Me.NouveauEvenement.Name = "NouveauEvenement"
        Me.NouveauEvenement.Size = New System.Drawing.Size(163, 41)
        Me.NouveauEvenement.TabIndex = 9
        Me.NouveauEvenement.Text = "<< NOUVEAU >>"
        Me.NouveauEvenement.UseVisualStyleBackColor = False
        '
        'RetourEvenement
        '
        Me.RetourEvenement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RetourEvenement.ForeColor = System.Drawing.Color.Yellow
        Me.RetourEvenement.Location = New System.Drawing.Point(15, 211)
        Me.RetourEvenement.Name = "RetourEvenement"
        Me.RetourEvenement.Size = New System.Drawing.Size(163, 41)
        Me.RetourEvenement.TabIndex = 8
        Me.RetourEvenement.Text = "<< RETOUR"
        Me.RetourEvenement.UseVisualStyleBackColor = False
        '
        'PhotoEvenement
        '
        Me.PhotoEvenement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhotoEvenement.ForeColor = System.Drawing.Color.Yellow
        Me.PhotoEvenement.Location = New System.Drawing.Point(726, 211)
        Me.PhotoEvenement.Name = "PhotoEvenement"
        Me.PhotoEvenement.Size = New System.Drawing.Size(243, 41)
        Me.PhotoEvenement.TabIndex = 7
        Me.PhotoEvenement.Text = "SELECTIONNEZ UNE IMAGE"
        Me.PhotoEvenement.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ImageEvenement)
        Me.Panel1.Location = New System.Drawing.Point(726, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 161)
        Me.Panel1.TabIndex = 6
        '
        'ImageEvenement
        '
        Me.ImageEvenement.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.gn__1_3
        Me.ImageEvenement.Location = New System.Drawing.Point(4, 3)
        Me.ImageEvenement.Name = "ImageEvenement"
        Me.ImageEvenement.Size = New System.Drawing.Size(230, 151)
        Me.ImageEvenement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageEvenement.TabIndex = 0
        Me.ImageEvenement.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FIN DE L'EVENEMENT :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(15, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DEBUT DE L'EVENEMENT :"
        '
        'NomEvenement
        '
        Me.NomEvenement.Location = New System.Drawing.Point(205, 26)
        Me.NomEvenement.Name = "NomEvenement"
        Me.NomEvenement.Size = New System.Drawing.Size(409, 20)
        Me.NomEvenement.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOM DE L'EVENEMENT :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_evenement)
        Me.Panel2.Location = New System.Drawing.Point(12, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 241)
        Me.Panel2.TabIndex = 1
        '
        'dgv_evenement
        '
        Me.dgv_evenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_evenement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_evenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_evenement.Location = New System.Drawing.Point(12, 7)
        Me.dgv_evenement.Name = "dgv_evenement"
        Me.dgv_evenement.Size = New System.Drawing.Size(954, 224)
        Me.dgv_evenement.TabIndex = 0
        '
        'enregistrement_evenement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1006, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "enregistrement_evenement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE D'ENREGISTREMENT DES ACTIVITES CULTURELLES & SPORTIVES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImageEvenement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_evenement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageEvenement As System.Windows.Forms.PictureBox
    Friend WithEvents PhotoEvenement As System.Windows.Forms.Button
    Friend WithEvents FinEvenement As System.Windows.Forms.DateTimePicker
    Friend WithEvents DebutEvenement As System.Windows.Forms.DateTimePicker
    Friend WithEvents BudgetEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DureeEvenement As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SauvegarderEvenement As System.Windows.Forms.Button
    Friend WithEvents NouveauEvenement As System.Windows.Forms.Button
    Friend WithEvents RetourEvenement As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv_evenement As System.Windows.Forms.DataGridView
End Class
