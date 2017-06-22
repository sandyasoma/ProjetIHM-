<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fView
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
        Me.pnlTitre1 = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblTitre2 = New System.Windows.Forms.Label()
        Me.pblBoutons2 = New System.Windows.Forms.Panel()
        Me.lstBoxListe = New System.Windows.Forms.ListBox()
        Me.btnCharger = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlTitre1.SuspendLayout()
        Me.pblBoutons2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitre1
        '
        Me.pnlTitre1.BackColor = System.Drawing.Color.Green
        Me.pnlTitre1.Controls.Add(Me.lblTitre)
        Me.pnlTitre1.Controls.Add(Me.lblTitre2)
        Me.pnlTitre1.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre1.Name = "pnlTitre1"
        Me.pnlTitre1.Size = New System.Drawing.Size(285, 75)
        Me.pnlTitre1.TabIndex = 0
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(38, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(206, 38)
        Me.lblTitre.TabIndex = 4
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitre2
        '
        Me.lblTitre2.AutoSize = True
        Me.lblTitre2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre2.ForeColor = System.Drawing.Color.Black
        Me.lblTitre2.Location = New System.Drawing.Point(108, 47)
        Me.lblTitre2.Name = "lblTitre2"
        Me.lblTitre2.Size = New System.Drawing.Size(77, 23)
        Me.lblTitre2.TabIndex = 3
        Me.lblTitre2.Text = "View List"
        Me.lblTitre2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pblBoutons2
        '
        Me.pblBoutons2.Controls.Add(Me.btnDelete)
        Me.pblBoutons2.Controls.Add(Me.btnModify)
        Me.pblBoutons2.Controls.Add(Me.lstBoxListe)
        Me.pblBoutons2.Controls.Add(Me.btnCharger)
        Me.pblBoutons2.Location = New System.Drawing.Point(0, 151)
        Me.pblBoutons2.Name = "pblBoutons2"
        Me.pblBoutons2.Size = New System.Drawing.Size(284, 310)
        Me.pblBoutons2.TabIndex = 1
        '
        'lstBoxListe
        '
        Me.lstBoxListe.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxListe.FormattingEnabled = True
        Me.lstBoxListe.ItemHeight = 23
        Me.lstBoxListe.Location = New System.Drawing.Point(45, 32)
        Me.lstBoxListe.Name = "lstBoxListe"
        Me.lstBoxListe.Size = New System.Drawing.Size(199, 211)
        Me.lstBoxListe.TabIndex = 1
        '
        'btnCharger
        '
        Me.btnCharger.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharger.Location = New System.Drawing.Point(45, 3)
        Me.btnCharger.Name = "btnCharger"
        Me.btnCharger.Size = New System.Drawing.Size(199, 23)
        Me.btnCharger.TabIndex = 0
        Me.btnCharger.Text = "Charge a List"
        Me.btnCharger.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 81)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(205, 270)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(67, 29)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(12, 270)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 29)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'fView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pblBoutons2)
        Me.Controls.Add(Me.pnlTitre1)
        Me.Name = "fView"
        Me.Text = "View your list !"
        Me.pnlTitre1.ResumeLayout(False)
        Me.pnlTitre1.PerformLayout()
        Me.pblBoutons2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitre1 As Panel
    Friend WithEvents pblBoutons2 As Panel
    Friend WithEvents btnCharger As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTitre2 As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents lstBoxListe As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
End Class
