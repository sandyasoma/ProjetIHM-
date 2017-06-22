<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblValTot = New System.Windows.Forms.Label()
        Me.pnlTitre.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitre
        '
        Me.pnlTitre.BackColor = System.Drawing.Color.Green
        Me.pnlTitre.Controls.Add(Me.lblMenu)
        Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.pnlTitre.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre.Name = "pnlTitre"
        Me.pnlTitre.Size = New System.Drawing.Size(285, 65)
        Me.pnlTitre.TabIndex = 2
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Black
        Me.lblMenu.Location = New System.Drawing.Point(122, 35)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(47, 26)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "PAY"
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
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 71)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(124, 219)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(68, 18)
        Me.lblprice.TabIndex = 9
        Me.lblprice.Text = "Total :   €"
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(28, 240)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(226, 35)
        Me.btnPay.TabIndex = 20
        Me.btnPay.Text = "Validate And Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblValTot
        '
        Me.lblValTot.AutoSize = True
        Me.lblValTot.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValTot.Location = New System.Drawing.Point(198, 219)
        Me.lblValTot.Name = "lblValTot"
        Me.lblValTot.Size = New System.Drawing.Size(0, 18)
        Me.lblValTot.TabIndex = 21
        '
        'fPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.lblValTot)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlTitre)
        Me.Name = "fPay"
        Me.Text = "Pay !"
        Me.pnlTitre.ResumeLayout(False)
        Me.pnlTitre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblprice As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents lblValTot As Label
End Class
