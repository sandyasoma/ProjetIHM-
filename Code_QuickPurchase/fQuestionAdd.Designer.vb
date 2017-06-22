<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fQuestionAdd
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnExist = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblArticle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnExist
        '
        Me.btnExist.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExist.Location = New System.Drawing.Point(55, 186)
        Me.btnExist.Name = "btnExist"
        Me.btnExist.Size = New System.Drawing.Size(187, 29)
        Me.btnExist.TabIndex = 10
        Me.btnExist.Text = "Add to an existing List"
        Me.btnExist.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(55, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Add to a New List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtquan
        '
        Me.txtquan.Location = New System.Drawing.Point(148, 122)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(57, 20)
        Me.txtquan.TabIndex = 47
        Me.txtquan.Visible = False
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(51, 118)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(91, 23)
        Me.lblquantity.TabIndex = 46
        Me.lblquantity.Text = " Quantity :"
        Me.lblquantity.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "price"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(72, 79)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(57, 23)
        Me.lblPrice.TabIndex = 44
        Me.lblPrice.Text = "Price :"
        '
        'lblArticle
        '
        Me.lblArticle.AutoSize = True
        Me.lblArticle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticle.Location = New System.Drawing.Point(111, 56)
        Me.lblArticle.Name = "lblArticle"
        Me.lblArticle.Size = New System.Drawing.Size(53, 23)
        Me.lblArticle.TabIndex = 43
        Me.lblArticle.Text = "Name"
        '
        'fQuestionAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblArticle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnExist)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "fQuestionAdd"
        Me.Text = "fQuestionAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnExist As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtquan As TextBox
    Friend WithEvents lblquantity As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblArticle As Label
End Class
