<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.BT_PERSONNEL = New System.Windows.Forms.Button()
        Me.LBL_MENU = New System.Windows.Forms.Label()
        Me.BT_PROF = New System.Windows.Forms.Button()
        Me.BT_ELEVE = New System.Windows.Forms.Button()
        Me.BT_ENCADREUR = New System.Windows.Forms.Button()
        Me.BT_SPORTIVE = New System.Windows.Forms.Button()
        Me.BT_CULTURELLE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_PERSONNEL
        '
        Me.BT_PERSONNEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_PERSONNEL.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PERSONNEL.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_PERSONNEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_PERSONNEL.Location = New System.Drawing.Point(188, 253)
        Me.BT_PERSONNEL.Name = "BT_PERSONNEL"
        Me.BT_PERSONNEL.Size = New System.Drawing.Size(184, 53)
        Me.BT_PERSONNEL.TabIndex = 0
        Me.BT_PERSONNEL.Text = "Personnel de la Direction"
        Me.BT_PERSONNEL.UseVisualStyleBackColor = False
        '
        'LBL_MENU
        '
        Me.LBL_MENU.AutoSize = True
        Me.LBL_MENU.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MENU.Font = New System.Drawing.Font("Trajan Pro 3", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU.ForeColor = System.Drawing.Color.Aqua
        Me.LBL_MENU.Location = New System.Drawing.Point(391, 9)
        Me.LBL_MENU.Name = "LBL_MENU"
        Me.LBL_MENU.Size = New System.Drawing.Size(522, 49)
        Me.LBL_MENU.TabIndex = 1
        Me.LBL_MENU.Text = "GESTION DE LA SCOLARITE"
        '
        'BT_PROF
        '
        Me.BT_PROF.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_PROF.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PROF.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_PROF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_PROF.Location = New System.Drawing.Point(555, 254)
        Me.BT_PROF.Name = "BT_PROF"
        Me.BT_PROF.Size = New System.Drawing.Size(184, 50)
        Me.BT_PROF.TabIndex = 2
        Me.BT_PROF.Text = "Les Professeurs"
        Me.BT_PROF.UseVisualStyleBackColor = False
        '
        'BT_ELEVE
        '
        Me.BT_ELEVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_ELEVE.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ELEVE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_ELEVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_ELEVE.Location = New System.Drawing.Point(919, 254)
        Me.BT_ELEVE.Name = "BT_ELEVE"
        Me.BT_ELEVE.Size = New System.Drawing.Size(184, 50)
        Me.BT_ELEVE.TabIndex = 3
        Me.BT_ELEVE.Text = "Les Elèves"
        Me.BT_ELEVE.UseVisualStyleBackColor = False
        '
        'BT_ENCADREUR
        '
        Me.BT_ENCADREUR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_ENCADREUR.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ENCADREUR.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_ENCADREUR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_ENCADREUR.Location = New System.Drawing.Point(188, 504)
        Me.BT_ENCADREUR.Name = "BT_ENCADREUR"
        Me.BT_ENCADREUR.Size = New System.Drawing.Size(184, 46)
        Me.BT_ENCADREUR.TabIndex = 4
        Me.BT_ENCADREUR.Text = "Les Encadreurs"
        Me.BT_ENCADREUR.UseVisualStyleBackColor = False
        '
        'BT_SPORTIVE
        '
        Me.BT_SPORTIVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_SPORTIVE.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SPORTIVE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_SPORTIVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_SPORTIVE.Location = New System.Drawing.Point(555, 504)
        Me.BT_SPORTIVE.Name = "BT_SPORTIVE"
        Me.BT_SPORTIVE.Size = New System.Drawing.Size(184, 54)
        Me.BT_SPORTIVE.TabIndex = 5
        Me.BT_SPORTIVE.Text = "Les activités sportives"
        Me.BT_SPORTIVE.UseVisualStyleBackColor = False
        '
        'BT_CULTURELLE
        '
        Me.BT_CULTURELLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_CULTURELLE.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CULTURELLE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BT_CULTURELLE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CULTURELLE.Location = New System.Drawing.Point(919, 500)
        Me.BT_CULTURELLE.Name = "BT_CULTURELLE"
        Me.BT_CULTURELLE.Size = New System.Drawing.Size(184, 55)
        Me.BT_CULTURELLE.TabIndex = 6
        Me.BT_CULTURELLE.Text = "Les activités culturelles"
        Me.BT_CULTURELLE.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(188, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(555, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(184, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(919, 103)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(184, 145)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(188, 347)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(184, 151)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(555, 347)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(184, 151)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(919, 347)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(184, 145)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GestionPrimaire.My.Resources.Resources.Rayures01
        Me.ClientSize = New System.Drawing.Size(1304, 589)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BT_CULTURELLE)
        Me.Controls.Add(Me.BT_SPORTIVE)
        Me.Controls.Add(Me.BT_ENCADREUR)
        Me.Controls.Add(Me.BT_ELEVE)
        Me.Controls.Add(Me.BT_PROF)
        Me.Controls.Add(Me.LBL_MENU)
        Me.Controls.Add(Me.BT_PERSONNEL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_PERSONNEL As System.Windows.Forms.Button
    Friend WithEvents LBL_MENU As System.Windows.Forms.Label
    Friend WithEvents BT_PROF As System.Windows.Forms.Button
    Friend WithEvents BT_ELEVE As System.Windows.Forms.Button
    Friend WithEvents BT_ENCADREUR As System.Windows.Forms.Button
    Friend WithEvents BT_SPORTIVE As System.Windows.Forms.Button
    Friend WithEvents BT_CULTURELLE As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
