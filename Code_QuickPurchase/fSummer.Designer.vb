<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSummer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSummer))
        Me.pnlTitre = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbxSearch = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstArticle = New System.Windows.Forms.ListBox()
        Me.lstprice = New System.Windows.Forms.ListBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnfinish = New System.Windows.Forms.Button()
        Me.pnlTitre.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitre
        '
        Me.pnlTitre.BackColor = System.Drawing.Color.Gold
        Me.pnlTitre.Controls.Add(Me.lblMenu)
        Me.pnlTitre.Controls.Add(Me.lblTitre)
        Me.pnlTitre.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTitre.Name = "pnlTitre"
        Me.pnlTitre.Size = New System.Drawing.Size(380, 80)
        Me.pnlTitre.TabIndex = 4
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Black
        Me.lblMenu.Location = New System.Drawing.Point(103, 43)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(163, 33)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Purchase List"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(69, 0)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(226, 41)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 79)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 490)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(16, 87)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(89, 36)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'pbxSearch
        '
        Me.pbxSearch.Image = CType(resources.GetObject("pbxSearch.Image"), System.Drawing.Image)
        Me.pbxSearch.Location = New System.Drawing.Point(296, 87)
        Me.pbxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(67, 54)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 10
        Me.pbxSearch.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(148, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 28)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "lblTitre"
        '
        'lstArticle
        '
        Me.lstArticle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArticle.FormattingEnabled = True
        Me.lstArticle.ItemHeight = 28
        Me.lstArticle.Location = New System.Drawing.Point(32, 170)
        Me.lstArticle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstArticle.Name = "lstArticle"
        Me.lstArticle.Size = New System.Drawing.Size(207, 340)
        Me.lstArticle.TabIndex = 12
        '
        'lstprice
        '
        Me.lstprice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprice.FormattingEnabled = True
        Me.lstprice.ItemHeight = 28
        Me.lstprice.Location = New System.Drawing.Point(253, 170)
        Me.lstprice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstprice.Name = "lstprice"
        Me.lstprice.Size = New System.Drawing.Size(108, 340)
        Me.lstprice.TabIndex = 13
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(209, 529)
        Me.lblprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(40, 28)
        Me.lblprice.TabIndex = 14
        Me.lblprice.Text = "0.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 529)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total : "
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(19, 527)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(89, 36)
        Me.btnSend.TabIndex = 16
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnfinish
        '
        Me.btnfinish.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinish.Location = New System.Drawing.Point(273, 527)
        Me.btnfinish.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(89, 36)
        Me.btnfinish.TabIndex = 17
        Me.btnfinish.Text = "Finish"
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'fSummer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 569)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lstprice)
        Me.Controls.Add(Me.lstArticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxSearch)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlTitre)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fSummer"
        Me.Text = "Summer List"
        Me.pnlTitre.ResumeLayout(False)
        Me.pnlTitre.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbxSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstArticle As ListBox
    Friend WithEvents lstprice As ListBox
    Friend WithEvents lblprice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents btnfinish As Button
End Class
