<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chargement = New System.Windows.Forms.Label()
        Me.BarreDeProgression = New System.Windows.Forms.ProgressBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SeConnecter = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MotDePasse = New System.Windows.Forms.TextBox()
        Me.NomAdministrateur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(802, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONNEXION"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Chargement)
        Me.Panel1.Controls.Add(Me.BarreDeProgression)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.SeConnecter)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.MotDePasse)
        Me.Panel1.Controls.Add(Me.NomAdministrateur)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 413)
        Me.Panel1.TabIndex = 0
        '
        'Chargement
        '
        Me.Chargement.AutoSize = True
        Me.Chargement.Location = New System.Drawing.Point(314, 350)
        Me.Chargement.Name = "Chargement"
        Me.Chargement.Size = New System.Drawing.Size(157, 13)
        Me.Chargement.TabIndex = 16
        Me.Chargement.Text = "CHARGEMENT EN COURS ...."
        Me.Chargement.Visible = False
        '
        'BarreDeProgression
        '
        Me.BarreDeProgression.Location = New System.Drawing.Point(86, 373)
        Me.BarreDeProgression.Name = "BarreDeProgression"
        Me.BarreDeProgression.Size = New System.Drawing.Size(600, 24)
        Me.BarreDeProgression.TabIndex = 15
        Me.BarreDeProgression.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.images__57_
        Me.PictureBox3.Location = New System.Drawing.Point(639, 196)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(98, 97)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(310, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 39)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "PHOTO DE PROFIL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SeConnecter
        '
        Me.SeConnecter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SeConnecter.Location = New System.Drawing.Point(268, 297)
        Me.SeConnecter.Name = "SeConnecter"
        Me.SeConnecter.Size = New System.Drawing.Size(246, 42)
        Me.SeConnecter.TabIndex = 12
        Me.SeConnecter.Text = "SE CONNECTER"
        Me.SeConnecter.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.images__12_
        Me.PictureBox2.Location = New System.Drawing.Point(310, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 149)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'MotDePasse
        '
        Me.MotDePasse.BackColor = System.Drawing.Color.White
        Me.MotDePasse.Location = New System.Drawing.Point(202, 263)
        Me.MotDePasse.Name = "MotDePasse"
        Me.MotDePasse.Size = New System.Drawing.Size(400, 20)
        Me.MotDePasse.TabIndex = 10
        Me.MotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MotDePasse.UseSystemPasswordChar = True
        '
        'NomAdministrateur
        '
        Me.NomAdministrateur.BackColor = System.Drawing.Color.White
        Me.NomAdministrateur.Location = New System.Drawing.Point(202, 221)
        Me.NomAdministrateur.Name = "NomAdministrateur"
        Me.NomAdministrateur.Size = New System.Drawing.Size(400, 20)
        Me.NomAdministrateur.TabIndex = 9
        Me.NomAdministrateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "MOT DE PASSE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NOM D'ADMINISTRATEUR :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Gestion_Etablissement_Scolaire.My.Resources.Resources.gn
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(876, 474)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULAIRE DE CONNEXION"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SeConnecter As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MotDePasse As System.Windows.Forms.TextBox
    Friend WithEvents NomAdministrateur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BarreDeProgression As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chargement As System.Windows.Forms.Label

End Class
