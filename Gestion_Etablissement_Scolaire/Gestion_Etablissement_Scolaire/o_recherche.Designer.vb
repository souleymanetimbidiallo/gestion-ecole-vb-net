<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_recherche
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.genre = New System.Windows.Forms.RadioButton()
        Me.matiere = New System.Windows.Forms.RadioButton()
        Me.prenom = New System.Windows.Forms.RadioButton()
        Me.nom = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECTIONNEZ UNE OPTION DE RECHERCHE"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.genre)
        Me.Panel1.Controls.Add(Me.matiere)
        Me.Panel1.Controls.Add(Me.prenom)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Location = New System.Drawing.Point(21, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 79)
        Me.Panel1.TabIndex = 2
        '
        'genre
        '
        Me.genre.AutoSize = True
        Me.genre.Location = New System.Drawing.Point(358, 20)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(63, 17)
        Me.genre.TabIndex = 3
        Me.genre.TabStop = True
        Me.genre.Text = "GENRE"
        Me.genre.UseVisualStyleBackColor = True
        '
        'matiere
        '
        Me.matiere.AutoSize = True
        Me.matiere.Location = New System.Drawing.Point(358, 55)
        Me.matiere.Name = "matiere"
        Me.matiere.Size = New System.Drawing.Size(73, 17)
        Me.matiere.TabIndex = 2
        Me.matiere.TabStop = True
        Me.matiere.Text = "MATIERE"
        Me.matiere.UseVisualStyleBackColor = True
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Location = New System.Drawing.Point(23, 55)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(85, 17)
        Me.prenom.TabIndex = 1
        Me.prenom.TabStop = True
        Me.prenom.Text = "PRENOM(S)"
        Me.prenom.UseVisualStyleBackColor = True
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Location = New System.Drawing.Point(23, 20)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(50, 17)
        Me.nom.TabIndex = 0
        Me.nom.TabStop = True
        Me.nom.Text = "NOM"
        Me.nom.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(21, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 32)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'o_recherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 227)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "o_recherche"
        Me.Text = "o_recherche"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents genre As System.Windows.Forms.RadioButton
    Friend WithEvents matiere As System.Windows.Forms.RadioButton
    Friend WithEvents prenom As System.Windows.Forms.RadioButton
    Friend WithEvents nom As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
