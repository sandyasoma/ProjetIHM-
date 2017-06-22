<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fResearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fResearch))
        Me.pnlTitre1 = New System.Windows.Forms.Panel()
        Me.lblTitre2 = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbxSearch2 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbxBread = New System.Windows.Forms.PictureBox()
        Me.pbxSoft = New System.Windows.Forms.PictureBox()
        Me.pbxBraided = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstBread = New System.Windows.Forms.ListBox()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lstprice = New System.Windows.Forms.ListBox()
        Me.pnlTitre1.SuspendLayout()
        CType(Me.pbxSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSoft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBraided, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitre1
        '
        Me.pnlTitre1.BackColor = System.Drawing.Color.Green
        Me.pnlTitre1.Controls.Add(Me.lblTitre2)
        Me.pnlTitre1.Controls.Add(Me.lblTitre)
        Me.pnlTitre1.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre1.Name = "pnlTitre1"
        Me.pnlTitre1.Size = New System.Drawing.Size(284, 60)
        Me.pnlTitre1.TabIndex = 2
        '
        'lblTitre2
        '
        Me.lblTitre2.AutoSize = True
        Me.lblTitre2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre2.ForeColor = System.Drawing.Color.Black
        Me.lblTitre2.Location = New System.Drawing.Point(72, 32)
        Me.lblTitre2.Name = "lblTitre2"
        Me.lblTitre2.Size = New System.Drawing.Size(129, 23)
        Me.lblTitre2.TabIndex = 2
        Me.lblTitre2.Text = "Purchase Search"
        Me.lblTitre2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(42, -1)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(206, 38)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 66)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'pbxSearch2
        '
        Me.pbxSearch2.Image = CType(resources.GetObject("pbxSearch2.Image"), System.Drawing.Image)
        Me.pbxSearch2.Location = New System.Drawing.Point(98, 66)
        Me.pbxSearch2.Name = "pbxSearch2"
        Me.pbxSearch2.Size = New System.Drawing.Size(31, 32)
        Me.pbxSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch2.TabIndex = 22
        Me.pbxSearch2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(136, 72)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 23
        '
        'pbxBread
        '
        Me.pbxBread.Image = CType(resources.GetObject("pbxBread.Image"), System.Drawing.Image)
        Me.pbxBread.Location = New System.Drawing.Point(29, 136)
        Me.pbxBread.Name = "pbxBread"
        Me.pbxBread.Size = New System.Drawing.Size(59, 58)
        Me.pbxBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBread.TabIndex = 24
        Me.pbxBread.TabStop = False
        Me.pbxBread.Visible = False
        '
        'pbxSoft
        '
        Me.pbxSoft.Image = CType(resources.GetObject("pbxSoft.Image"), System.Drawing.Image)
        Me.pbxSoft.Location = New System.Drawing.Point(29, 200)
        Me.pbxSoft.Name = "pbxSoft"
        Me.pbxSoft.Size = New System.Drawing.Size(59, 58)
        Me.pbxSoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSoft.TabIndex = 25
        Me.pbxSoft.TabStop = False
        Me.pbxSoft.Visible = False
        '
        'pbxBraided
        '
        Me.pbxBraided.Image = CType(resources.GetObject("pbxBraided.Image"), System.Drawing.Image)
        Me.pbxBraided.Location = New System.Drawing.Point(29, 264)
        Me.pbxBraided.Name = "pbxBraided"
        Me.pbxBraided.Size = New System.Drawing.Size(59, 58)
        Me.pbxBraided.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBraided.TabIndex = 26
        Me.pbxBraided.TabStop = False
        Me.pbxBraided.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(68, 387)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 31)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add to list"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'lstBread
        '
        Me.lstBread.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBread.FormattingEnabled = True
        Me.lstBread.ItemHeight = 23
        Me.lstBread.Items.AddRange(New Object() {"Bread", "", "", "Soft bread", "", "", "Braided bread"})
        Me.lstBread.Location = New System.Drawing.Point(94, 136)
        Me.lstBread.Name = "lstBread"
        Me.lstBread.Size = New System.Drawing.Size(123, 188)
        Me.lstBread.TabIndex = 34
        Me.lstBread.Visible = False
        '
        'txtquan
        '
        Me.txtquan.Location = New System.Drawing.Point(191, 351)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(57, 20)
        Me.txtquan.TabIndex = 35
        Me.txtquan.Visible = False
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(94, 347)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(91, 23)
        Me.lblquantity.TabIndex = 36
        Me.lblquantity.Text = " Quantity :"
        Me.lblquantity.Visible = False
        '
        'lstprice
        '
        Me.lstprice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprice.FormattingEnabled = True
        Me.lstprice.ItemHeight = 23
        Me.lstprice.Items.AddRange(New Object() {"0.5", "", "", "1", "", "", "2"})
        Me.lstprice.Location = New System.Drawing.Point(223, 136)
        Me.lstprice.Name = "lstprice"
        Me.lstprice.Size = New System.Drawing.Size(49, 188)
        Me.lstprice.TabIndex = 37
        Me.lstprice.Visible = False
        '
        'fResearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.lstprice)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.lstBread)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pbxBraided)
        Me.Controls.Add(Me.pbxSoft)
        Me.Controls.Add(Me.pbxBread)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pbxSearch2)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlTitre1)
        Me.Name = "fResearch"
        Me.Text = "fResearch"
        Me.pnlTitre1.ResumeLayout(False)
        Me.pnlTitre1.PerformLayout()
        CType(Me.pbxSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSoft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBraided, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre1 As Panel
    Friend WithEvents lblTitre2 As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbxSearch2 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pbxBread As PictureBox
    Friend WithEvents pbxSoft As PictureBox
    Friend WithEvents pbxBraided As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstBread As ListBox
    Friend WithEvents txtquan As TextBox
    Friend WithEvents lblquantity As Label
    Friend WithEvents lstprice As ListBox
End Class
