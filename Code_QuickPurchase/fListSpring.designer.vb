﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fListe_Spring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fListe_Spring))
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pbxSpring = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbxSearch = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstArticle = New System.Windows.Forms.ListBox()
        Me.lstprice = New System.Windows.Forms.ListBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.btnfinish = New System.Windows.Forms.Button()
        Me.pbxPoubelle = New System.Windows.Forms.PictureBox()
        Me.pnlTitre.SuspendLayout()
        CType(Me.pbxSpring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPoubelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitre
        '
        Me.pnlTitre.BackColor = System.Drawing.Color.Green
        Me.pnlTitre.Controls.Add(Me.lblMenu)
        Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.pnlTitre.Location = New System.Drawing.Point(1, 0)
        Me.pnlTitre.Name = "pnlTitre"
        Me.pnlTitre.Size = New System.Drawing.Size(285, 65)
        Me.pnlTitre.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Black
        Me.lblMenu.Location = New System.Drawing.Point(77, 35)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(127, 26)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Purchase List"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(52, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(181, 35)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbxSpring
        '
        Me.pbxSpring.Image = CType(resources.GetObject("pbxSpring.Image"), System.Drawing.Image)
        Me.pbxSpring.Location = New System.Drawing.Point(1, 64)
        Me.pbxSpring.Name = "pbxSpring"
        Me.pbxSpring.Size = New System.Drawing.Size(285, 400)
        Me.pbxSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSpring.TabIndex = 2
        Me.pbxSpring.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 71)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'pbxSearch
        '
        Me.pbxSearch.Image = CType(resources.GetObject("pbxSearch.Image"), System.Drawing.Image)
        Me.pbxSearch.Location = New System.Drawing.Point(222, 71)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(50, 44)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 9
        Me.pbxSearch.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "lblTitre"
        '
        'lstArticle
        '
        Me.lstArticle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArticle.FormattingEnabled = True
        Me.lstArticle.ItemHeight = 23
        Me.lstArticle.Location = New System.Drawing.Point(17, 132)
        Me.lstArticle.Name = "lstArticle"
        Me.lstArticle.Size = New System.Drawing.Size(156, 257)
        Me.lstArticle.TabIndex = 16
        '
        'lstprice
        '
        Me.lstprice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprice.FormattingEnabled = True
        Me.lstprice.ItemHeight = 23
        Me.lstprice.Location = New System.Drawing.Point(190, 132)
        Me.lstprice.Name = "lstprice"
        Me.lstprice.Size = New System.Drawing.Size(82, 257)
        Me.lstprice.TabIndex = 17
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(6, 421)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(67, 29)
        Me.btnSend.TabIndex = 19
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Total : "
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(159, 423)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(34, 23)
        Me.lblprice.TabIndex = 27
        Me.lblprice.Text = "0.0"
        '
        'btnfinish
        '
        Me.btnfinish.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinish.Location = New System.Drawing.Point(211, 421)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(67, 29)
        Me.btnfinish.TabIndex = 28
        Me.btnfinish.Text = "Finish"
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'pbxPoubelle
        '
        Me.pbxPoubelle.Image = CType(resources.GetObject("pbxPoubelle.Image"), System.Drawing.Image)
        Me.pbxPoubelle.Location = New System.Drawing.Point(163, 71)
        Me.pbxPoubelle.Name = "pbxPoubelle"
        Me.pbxPoubelle.Size = New System.Drawing.Size(43, 51)
        Me.pbxPoubelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPoubelle.TabIndex = 30
        Me.pbxPoubelle.TabStop = False
        '
        'fListe_Spring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.pbxPoubelle)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lstprice)
        Me.Controls.Add(Me.lstArticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxSearch)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pbxSpring)
        Me.Controls.Add(Me.pnlTitre)
        Me.Name = "fListe_Spring"
        Me.Text = "Spring List"
        Me.pnlTitre.ResumeLayout(False)
        Me.pnlTitre.PerformLayout()
        CType(Me.pbxSpring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPoubelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents pbxSpring As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbxSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstArticle As ListBox
    Friend WithEvents lstprice As ListBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents btnfinish As Button
    Friend WithEvents pbxPoubelle As PictureBox
End Class
