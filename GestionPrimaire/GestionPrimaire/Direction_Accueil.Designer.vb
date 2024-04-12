<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Direction_Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Direction_Accueil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_INSCRIPTION = New System.Windows.Forms.Button()
        Me.BT_AUTRE = New System.Windows.Forms.Button()
        Me.BT_LISTE = New System.Windows.Forms.Button()
        Me.BT_RETOUR = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DU PERSONNEL DE LA DIRECTION"
        '
        'BT_INSCRIPTION
        '
        Me.BT_INSCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INSCRIPTION.ForeColor = System.Drawing.Color.Maroon
        Me.BT_INSCRIPTION.Location = New System.Drawing.Point(583, 203)
        Me.BT_INSCRIPTION.Name = "BT_INSCRIPTION"
        Me.BT_INSCRIPTION.Size = New System.Drawing.Size(291, 70)
        Me.BT_INSCRIPTION.TabIndex = 1
        Me.BT_INSCRIPTION.Text = "INSCRIPTION"
        Me.BT_INSCRIPTION.UseVisualStyleBackColor = True
        '
        'BT_AUTRE
        '
        Me.BT_AUTRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_AUTRE.ForeColor = System.Drawing.Color.Maroon
        Me.BT_AUTRE.Location = New System.Drawing.Point(583, 298)
        Me.BT_AUTRE.Name = "BT_AUTRE"
        Me.BT_AUTRE.Size = New System.Drawing.Size(291, 70)
        Me.BT_AUTRE.TabIndex = 3
        Me.BT_AUTRE.Text = "AUTRES OPTIONS"
        Me.BT_AUTRE.UseVisualStyleBackColor = True
        '
        'BT_LISTE
        '
        Me.BT_LISTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LISTE.ForeColor = System.Drawing.Color.Maroon
        Me.BT_LISTE.Location = New System.Drawing.Point(583, 402)
        Me.BT_LISTE.Name = "BT_LISTE"
        Me.BT_LISTE.Size = New System.Drawing.Size(291, 70)
        Me.BT_LISTE.TabIndex = 5
        Me.BT_LISTE.Text = "LISTES DU PERSONNEL"
        Me.BT_LISTE.UseVisualStyleBackColor = True
        '
        'BT_RETOUR
        '
        Me.BT_RETOUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RETOUR.ForeColor = System.Drawing.Color.Maroon
        Me.BT_RETOUR.Location = New System.Drawing.Point(583, 501)
        Me.BT_RETOUR.Name = "BT_RETOUR"
        Me.BT_RETOUR.Size = New System.Drawing.Size(291, 70)
        Me.BT_RETOUR.TabIndex = 7
        Me.BT_RETOUR.Text = "RETOUR"
        Me.BT_RETOUR.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(481, 501)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(96, 70)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(481, 402)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(481, 298)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(481, 203)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Direction_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BT_RETOUR)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BT_LISTE)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BT_AUTRE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BT_INSCRIPTION)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Direction_Accueil"
        Me.Text = "Direction_Accueil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_INSCRIPTION As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_AUTRE As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_LISTE As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_RETOUR As System.Windows.Forms.Button
End Class
