<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Culture_Autre
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
        Me.BT_MODIFIER = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_PHOTO = New System.Windows.Forms.PictureBox()
        Me.BT_PHOTO = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BT_MODIFICATION = New System.Windows.Forms.Button()
        Me.BT_RETOUR = New System.Windows.Forms.Button()
        Me.BT_CONSULTATION = New System.Windows.Forms.Button()
        Me.BT_SUPPRESSION = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_MODIFIER
        '
        Me.BT_MODIFIER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MODIFIER.Location = New System.Drawing.Point(573, 252)
        Me.BT_MODIFIER.Name = "BT_MODIFIER"
        Me.BT_MODIFIER.Size = New System.Drawing.Size(151, 33)
        Me.BT_MODIFIER.TabIndex = 89
        Me.BT_MODIFIER.Text = "MODIFIER"
        Me.BT_MODIFIER.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BT_MODIFIER)
        Me.Panel1.Controls.Add(Me.PB_PHOTO)
        Me.Panel1.Controls.Add(Me.BT_PHOTO)
        Me.Panel1.Location = New System.Drawing.Point(29, 405)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1296, 290)
        Me.Panel1.TabIndex = 87
        Me.Panel1.Visible = False
        '
        'PB_PHOTO
        '
        Me.PB_PHOTO.Location = New System.Drawing.Point(905, 23)
        Me.PB_PHOTO.Name = "PB_PHOTO"
        Me.PB_PHOTO.Size = New System.Drawing.Size(159, 163)
        Me.PB_PHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_PHOTO.TabIndex = 49
        Me.PB_PHOTO.TabStop = False
        '
        'BT_PHOTO
        '
        Me.BT_PHOTO.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PHOTO.Location = New System.Drawing.Point(905, 193)
        Me.BT_PHOTO.Name = "BT_PHOTO"
        Me.BT_PHOTO.Size = New System.Drawing.Size(159, 38)
        Me.BT_PHOTO.TabIndex = 50
        Me.BT_PHOTO.Text = "Entrer la photo"
        Me.BT_PHOTO.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 271)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1296, 128)
        Me.DataGridView1.TabIndex = 86
        Me.DataGridView1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 22)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Nom de l'évènement :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(624, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 29)
        Me.TextBox1.TabIndex = 81
        '
        'BT_MODIFICATION
        '
        Me.BT_MODIFICATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MODIFICATION.Location = New System.Drawing.Point(827, 190)
        Me.BT_MODIFICATION.Name = "BT_MODIFICATION"
        Me.BT_MODIFICATION.Size = New System.Drawing.Size(151, 33)
        Me.BT_MODIFICATION.TabIndex = 85
        Me.BT_MODIFICATION.Text = "MODIFICATION"
        Me.BT_MODIFICATION.UseVisualStyleBackColor = True
        '
        'BT_RETOUR
        '
        Me.BT_RETOUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RETOUR.Location = New System.Drawing.Point(1047, 190)
        Me.BT_RETOUR.Name = "BT_RETOUR"
        Me.BT_RETOUR.Size = New System.Drawing.Size(151, 33)
        Me.BT_RETOUR.TabIndex = 88
        Me.BT_RETOUR.Text = "RETOUR"
        Me.BT_RETOUR.UseVisualStyleBackColor = True
        '
        'BT_CONSULTATION
        '
        Me.BT_CONSULTATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CONSULTATION.Location = New System.Drawing.Point(393, 190)
        Me.BT_CONSULTATION.Name = "BT_CONSULTATION"
        Me.BT_CONSULTATION.Size = New System.Drawing.Size(165, 33)
        Me.BT_CONSULTATION.TabIndex = 83
        Me.BT_CONSULTATION.Text = "CONSULTATION"
        Me.BT_CONSULTATION.UseVisualStyleBackColor = True
        '
        'BT_SUPPRESSION
        '
        Me.BT_SUPPRESSION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SUPPRESSION.Location = New System.Drawing.Point(619, 190)
        Me.BT_SUPPRESSION.Name = "BT_SUPPRESSION"
        Me.BT_SUPPRESSION.Size = New System.Drawing.Size(150, 33)
        Me.BT_SUPPRESSION.TabIndex = 84
        Me.BT_SUPPRESSION.Text = "SUPPRESSION"
        Me.BT_SUPPRESSION.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(277, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(292, 29)
        Me.TextBox2.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Budget :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(277, 124)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(292, 26)
        Me.DateTimePicker2.TabIndex = 95
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(277, 76)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(292, 26)
        Me.DateTimePicker1.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Date de fin :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Date début :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(277, 23)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(292, 29)
        Me.TextBox3.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Nom :"
        '
        'Culture_Autre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BT_MODIFICATION)
        Me.Controls.Add(Me.BT_RETOUR)
        Me.Controls.Add(Me.BT_CONSULTATION)
        Me.Controls.Add(Me.BT_SUPPRESSION)
        Me.Name = "Culture_Autre"
        Me.Text = "Culture_Autre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_PHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_MODIFIER As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PB_PHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents BT_PHOTO As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BT_MODIFICATION As System.Windows.Forms.Button
    Friend WithEvents BT_RETOUR As System.Windows.Forms.Button
    Friend WithEvents BT_CONSULTATION As System.Windows.Forms.Button
    Friend WithEvents BT_SUPPRESSION As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
