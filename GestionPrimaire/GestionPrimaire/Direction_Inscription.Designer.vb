<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Direction_Inscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Direction_Inscription))
        Me.LBL_PERSONNEL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_PHOTO = New System.Windows.Forms.Button()
        Me.PB_PHOTO = New System.Windows.Forms.PictureBox()
        Me.fonction = New System.Windows.Forms.ComboBox()
        Me.quartier = New System.Windows.Forms.TextBox()
        Me.salaire = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.telephone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.genre_homme = New System.Windows.Forms.RadioButton()
        Me.genre_femme = New System.Windows.Forms.RadioButton()
        Me.date_naissance = New System.Windows.Forms.DateTimePicker()
        Me.lieu_naissance = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BT_RETOUR = New System.Windows.Forms.Button()
        Me.BT_ENREGISTRER = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_PERSONNEL
        '
        Me.LBL_PERSONNEL.AutoSize = True
        Me.LBL_PERSONNEL.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PERSONNEL.Location = New System.Drawing.Point(394, 9)
        Me.LBL_PERSONNEL.Name = "LBL_PERSONNEL"
        Me.LBL_PERSONNEL.Size = New System.Drawing.Size(566, 24)
        Me.LBL_PERSONNEL.TabIndex = 0
        Me.LBL_PERSONNEL.Text = "INSCRIPTION D'UN PERSONNEL DE LA DIRECTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date de naissance :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lieu de naissance :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BT_PHOTO)
        Me.Panel1.Controls.Add(Me.PB_PHOTO)
        Me.Panel1.Controls.Add(Me.fonction)
        Me.Panel1.Controls.Add(Me.quartier)
        Me.Panel1.Controls.Add(Me.salaire)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Controls.Add(Me.telephone)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.date_naissance)
        Me.Panel1.Controls.Add(Me.lieu_naissance)
        Me.Panel1.Controls.Add(Me.prenom)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 483)
        Me.Panel1.TabIndex = 1
        '
        'BT_PHOTO
        '
        Me.BT_PHOTO.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PHOTO.Location = New System.Drawing.Point(965, 238)
        Me.BT_PHOTO.Name = "BT_PHOTO"
        Me.BT_PHOTO.Size = New System.Drawing.Size(200, 38)
        Me.BT_PHOTO.TabIndex = 24
        Me.BT_PHOTO.Text = "Entrer la photo"
        Me.BT_PHOTO.UseVisualStyleBackColor = True
        '
        'PB_PHOTO
        '
        Me.PB_PHOTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_PHOTO.Image = CType(resources.GetObject("PB_PHOTO.Image"), System.Drawing.Image)
        Me.PB_PHOTO.Location = New System.Drawing.Point(965, 32)
        Me.PB_PHOTO.Name = "PB_PHOTO"
        Me.PB_PHOTO.Size = New System.Drawing.Size(200, 200)
        Me.PB_PHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_PHOTO.TabIndex = 23
        Me.PB_PHOTO.TabStop = False
        '
        'fonction
        '
        Me.fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fonction.FormattingEnabled = True
        Me.fonction.Items.AddRange(New Object() {"Fondateur", "Directeur Général", "Directeur du primaire"})
        Me.fonction.Location = New System.Drawing.Point(255, 387)
        Me.fonction.Name = "fonction"
        Me.fonction.Size = New System.Drawing.Size(292, 32)
        Me.fonction.TabIndex = 22
        '
        'quartier
        '
        Me.quartier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quartier.Location = New System.Drawing.Point(255, 342)
        Me.quartier.Name = "quartier"
        Me.quartier.Size = New System.Drawing.Size(292, 29)
        Me.quartier.TabIndex = 21
        '
        'salaire
        '
        Me.salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salaire.Location = New System.Drawing.Point(255, 435)
        Me.salaire.Name = "salaire"
        Me.salaire.Size = New System.Drawing.Size(292, 29)
        Me.salaire.TabIndex = 20
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(255, 303)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(292, 29)
        Me.email.TabIndex = 19
        Me.email.Tag = ""
        '
        'telephone
        '
        Me.telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephone.Location = New System.Drawing.Point(255, 258)
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(292, 29)
        Me.telephone.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Salaire :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Fonction :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Quartier"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Email :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 22)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Numero de telephone :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.genre_homme)
        Me.GroupBox1.Controls.Add(Me.genre_femme)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(255, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 36)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'genre_homme
        '
        Me.genre_homme.AutoSize = True
        Me.genre_homme.Location = New System.Drawing.Point(0, 10)
        Me.genre_homme.Name = "genre_homme"
        Me.genre_homme.Size = New System.Drawing.Size(96, 28)
        Me.genre_homme.TabIndex = 9
        Me.genre_homme.TabStop = True
        Me.genre_homme.Text = "Homme"
        Me.genre_homme.UseVisualStyleBackColor = True
        '
        'genre_femme
        '
        Me.genre_femme.AutoSize = True
        Me.genre_femme.Location = New System.Drawing.Point(171, 10)
        Me.genre_femme.Name = "genre_femme"
        Me.genre_femme.Size = New System.Drawing.Size(94, 28)
        Me.genre_femme.TabIndex = 10
        Me.genre_femme.TabStop = True
        Me.genre_femme.Text = "Femme"
        Me.genre_femme.UseVisualStyleBackColor = True
        '
        'date_naissance
        '
        Me.date_naissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_naissance.Location = New System.Drawing.Point(255, 152)
        Me.date_naissance.Name = "date_naissance"
        Me.date_naissance.Size = New System.Drawing.Size(292, 29)
        Me.date_naissance.TabIndex = 8
        '
        'lieu_naissance
        '
        Me.lieu_naissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lieu_naissance.Location = New System.Drawing.Point(255, 203)
        Me.lieu_naissance.Name = "lieu_naissance"
        Me.lieu_naissance.Size = New System.Drawing.Size(292, 29)
        Me.lieu_naissance.TabIndex = 7
        '
        'prenom
        '
        Me.prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(255, 63)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(292, 29)
        Me.prenom.TabIndex = 6
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(255, 18)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(292, 29)
        Me.nom.TabIndex = 5
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1347, 481)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 842
        Me.LineShape2.X2 = 849
        Me.LineShape2.Y1 = -3
        Me.LineShape2.Y2 = 602
        '
        'BT_RETOUR
        '
        Me.BT_RETOUR.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RETOUR.Location = New System.Drawing.Point(12, 653)
        Me.BT_RETOUR.Name = "BT_RETOUR"
        Me.BT_RETOUR.Size = New System.Drawing.Size(101, 47)
        Me.BT_RETOUR.TabIndex = 3
        Me.BT_RETOUR.Text = "RETOUR"
        Me.BT_RETOUR.UseVisualStyleBackColor = True
        '
        'BT_ENREGISTRER
        '
        Me.BT_ENREGISTRER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ENREGISTRER.Location = New System.Drawing.Point(591, 583)
        Me.BT_ENREGISTRER.Name = "BT_ENREGISTRER"
        Me.BT_ENREGISTRER.Size = New System.Drawing.Size(173, 45)
        Me.BT_ENREGISTRER.TabIndex = 4
        Me.BT_ENREGISTRER.Text = "ENREGISTRER"
        Me.BT_ENREGISTRER.UseVisualStyleBackColor = True
        '
        'Direction_Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 712)
        Me.Controls.Add(Me.BT_ENREGISTRER)
        Me.Controls.Add(Me.BT_RETOUR)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBL_PERSONNEL)
        Me.Name = "Direction_Inscription"
        Me.Text = "personnel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_PERSONNEL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents genre_homme As System.Windows.Forms.RadioButton
    Friend WithEvents genre_femme As System.Windows.Forms.RadioButton
    Friend WithEvents date_naissance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lieu_naissance As System.Windows.Forms.TextBox
    Friend WithEvents prenom As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents salaire As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents telephone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fonction As System.Windows.Forms.ComboBox
    Friend WithEvents quartier As System.Windows.Forms.TextBox
    Friend WithEvents BT_PHOTO As System.Windows.Forms.Button
    Friend WithEvents PB_PHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents BT_RETOUR As System.Windows.Forms.Button
    Friend WithEvents BT_ENREGISTRER As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
