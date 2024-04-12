<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sport_Listes
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
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        Me.LBL_AFFICHAGE = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLOSE.Location = New System.Drawing.Point(25, 663)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(147, 38)
        Me.BT_CLOSE.TabIndex = 11
        Me.BT_CLOSE.Text = "RETOUR"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'LBL_AFFICHAGE
        '
        Me.LBL_AFFICHAGE.AutoSize = True
        Me.LBL_AFFICHAGE.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AFFICHAGE.Location = New System.Drawing.Point(446, 32)
        Me.LBL_AFFICHAGE.Name = "LBL_AFFICHAGE"
        Me.LBL_AFFICHAGE.Size = New System.Drawing.Size(463, 36)
        Me.LBL_AFFICHAGE.TabIndex = 10
        Me.LBL_AFFICHAGE.Text = "Listes des évènements sportifs"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1277, 586)
        Me.DataGridView1.TabIndex = 9
        '
        'Sport_Listes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.LBL_AFFICHAGE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Sport_Listes"
        Me.Text = "Sport_Listes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_CLOSE As System.Windows.Forms.Button
    Friend WithEvents LBL_AFFICHAGE As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
