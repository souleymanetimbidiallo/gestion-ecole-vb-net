<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pass))
        Me.LBL_LOGIN = New System.Windows.Forms.Label()
        Me.LBL_MDP = New System.Windows.Forms.Label()
        Me.TXT_LOGIN = New System.Windows.Forms.TextBox()
        Me.TXT_MDP = New System.Windows.Forms.TextBox()
        Me.BT_CONNECT = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_LOGIN
        '
        Me.LBL_LOGIN.AutoSize = True
        Me.LBL_LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LOGIN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LOGIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_LOGIN.Location = New System.Drawing.Point(483, 342)
        Me.LBL_LOGIN.Name = "LBL_LOGIN"
        Me.LBL_LOGIN.Size = New System.Drawing.Size(196, 24)
        Me.LBL_LOGIN.TabIndex = 0
        Me.LBL_LOGIN.Text = "Nom d'utilisateur : "
        '
        'LBL_MDP
        '
        Me.LBL_MDP.AutoSize = True
        Me.LBL_MDP.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MDP.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MDP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_MDP.Location = New System.Drawing.Point(483, 414)
        Me.LBL_MDP.Name = "LBL_MDP"
        Me.LBL_MDP.Size = New System.Drawing.Size(147, 24)
        Me.LBL_MDP.TabIndex = 1
        Me.LBL_MDP.Text = "Mot de passe : "
        '
        'TXT_LOGIN
        '
        Me.TXT_LOGIN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LOGIN.Location = New System.Drawing.Point(693, 340)
        Me.TXT_LOGIN.Name = "TXT_LOGIN"
        Me.TXT_LOGIN.Size = New System.Drawing.Size(184, 30)
        Me.TXT_LOGIN.TabIndex = 0
        '
        'TXT_MDP
        '
        Me.TXT_MDP.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MDP.Location = New System.Drawing.Point(693, 412)
        Me.TXT_MDP.Name = "TXT_MDP"
        Me.TXT_MDP.Size = New System.Drawing.Size(184, 30)
        Me.TXT_MDP.TabIndex = 1
        Me.TXT_MDP.UseSystemPasswordChar = True
        '
        'BT_CONNECT
        '
        Me.BT_CONNECT.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CONNECT.Location = New System.Drawing.Point(580, 464)
        Me.BT_CONNECT.Name = "BT_CONNECT"
        Me.BT_CONNECT.Size = New System.Drawing.Size(156, 36)
        Me.BT_CONNECT.TabIndex = 2
        Me.BT_CONNECT.Text = "Se connecter"
        Me.BT_CONNECT.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(526, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IDENTIFICATION"
        '
        'Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1316, 751)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BT_CONNECT)
        Me.Controls.Add(Me.TXT_MDP)
        Me.Controls.Add(Me.TXT_LOGIN)
        Me.Controls.Add(Me.LBL_MDP)
        Me.Controls.Add(Me.LBL_LOGIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDENTIFICATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_LOGIN As System.Windows.Forms.Label
    Friend WithEvents LBL_MDP As System.Windows.Forms.Label
    Friend WithEvents TXT_LOGIN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MDP As System.Windows.Forms.TextBox
    Friend WithEvents BT_CONNECT As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
