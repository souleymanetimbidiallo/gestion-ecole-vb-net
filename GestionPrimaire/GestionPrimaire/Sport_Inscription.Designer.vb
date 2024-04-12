<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sport_Inscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sport_Inscription))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBL_PERSONNEL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_PHOTO = New System.Windows.Forms.Button()
        Me.PB_PHOTO = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.BT_RETOUR = New System.Windows.Forms.Button()
        Me.BT_CONSULTATION = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(255, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(292, 29)
        Me.TextBox2.TabIndex = 32
        '
        'LBL_PERSONNEL
        '
        Me.LBL_PERSONNEL.AutoSize = True
        Me.LBL_PERSONNEL.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PERSONNEL.Location = New System.Drawing.Point(480, 21)
        Me.LBL_PERSONNEL.Name = "LBL_PERSONNEL"
        Me.LBL_PERSONNEL.Size = New System.Drawing.Size(394, 48)
        Me.LBL_PERSONNEL.TabIndex = 13
        Me.LBL_PERSONNEL.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AJOUT D'UN EVENEMENT SPORTIF"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BT_PHOTO)
        Me.Panel1.Controls.Add(Me.PB_PHOTO)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(8, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 308)
        Me.Panel1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Budget :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(255, 119)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(292, 26)
        Me.DateTimePicker2.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(255, 71)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(292, 26)
        Me.DateTimePicker1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date de fin :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Date début :"
        '
        'BT_PHOTO
        '
        Me.BT_PHOTO.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PHOTO.Location = New System.Drawing.Point(909, 225)
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
        Me.PB_PHOTO.Location = New System.Drawing.Point(909, 18)
        Me.PB_PHOTO.Name = "PB_PHOTO"
        Me.PB_PHOTO.Size = New System.Drawing.Size(200, 200)
        Me.PB_PHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_PHOTO.TabIndex = 23
        Me.PB_PHOTO.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(255, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 29)
        Me.TextBox1.TabIndex = 5
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1336, 306)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 665
        Me.LineShape2.X2 = 672
        Me.LineShape2.Y1 = -3
        Me.LineShape2.Y2 = 602
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SAVE.Location = New System.Drawing.Point(594, 538)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(173, 45)
        Me.BT_SAVE.TabIndex = 16
        Me.BT_SAVE.Text = "ENREGISTRER"
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'BT_RETOUR
        '
        Me.BT_RETOUR.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RETOUR.Location = New System.Drawing.Point(12, 665)
        Me.BT_RETOUR.Name = "BT_RETOUR"
        Me.BT_RETOUR.Size = New System.Drawing.Size(101, 47)
        Me.BT_RETOUR.TabIndex = 15
        Me.BT_RETOUR.Text = "RETOUR"
        Me.BT_RETOUR.UseVisualStyleBackColor = True
        '
        'BT_CONSULTATION
        '
        Me.BT_CONSULTATION.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CONSULTATION.Location = New System.Drawing.Point(1185, 665)
        Me.BT_CONSULTATION.Name = "BT_CONSULTATION"
        Me.BT_CONSULTATION.Size = New System.Drawing.Size(157, 47)
        Me.BT_CONSULTATION.TabIndex = 17
        Me.BT_CONSULTATION.Text = "CONSULTATION"
        Me.BT_CONSULTATION.UseVisualStyleBackColor = True
        '
        'Sport_Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.LBL_PERSONNEL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BT_SAVE)
        Me.Controls.Add(Me.BT_RETOUR)
        Me.Controls.Add(Me.BT_CONSULTATION)
        Me.Name = "Sport_Inscription"
        Me.Text = "Sport_Inscription"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LBL_PERSONNEL As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BT_PHOTO As System.Windows.Forms.Button
    Friend WithEvents PB_PHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BT_SAVE As System.Windows.Forms.Button
    Friend WithEvents BT_RETOUR As System.Windows.Forms.Button
    Friend WithEvents BT_CONSULTATION As System.Windows.Forms.Button
End Class
