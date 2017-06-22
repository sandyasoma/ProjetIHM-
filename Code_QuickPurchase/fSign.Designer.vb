<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fSign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitre1 = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPswd = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPswd = New System.Windows.Forms.TextBox()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.pnlTitre1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitre1
        '
        Me.pnlTitre1.BackColor = System.Drawing.Color.Green
        Me.pnlTitre1.Controls.Add(Me.lblTitre)
        Me.pnlTitre1.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre1.Name = "pnlTitre1"
        Me.pnlTitre1.Size = New System.Drawing.Size(284, 60)
        Me.pnlTitre1.TabIndex = 0
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(30, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(242, 45)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(46, 107)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 20)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(31, 138)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(74, 20)
        Me.lblLast.TabIndex = 2
        Me.lblLast.Text = "Lastname"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(27, 178)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(78, 20)
        Me.lblFirst.TabIndex = 3
        Me.lblFirst.Text = "Firstname"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(69, 215)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 20)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Age"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAd.Location = New System.Drawing.Point(38, 255)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(67, 20)
        Me.lblAd.TabIndex = 5
        Me.lblAd.Text = "Address"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(52, 291)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(53, 20)
        Me.lblMail.TabIndex = 6
        Me.lblMail.Text = "E-Mail"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(28, 334)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(77, 20)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Username"
        '
        'lblPswd
        '
        Me.lblPswd.AutoSize = True
        Me.lblPswd.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPswd.Location = New System.Drawing.Point(31, 373)
        Me.lblPswd.Name = "lblPswd"
        Me.lblPswd.Size = New System.Drawing.Size(74, 20)
        Me.lblPswd.TabIndex = 8
        Me.lblPswd.Text = "Password"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(131, 138)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(141, 20)
        Me.txtLast.TabIndex = 10
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(131, 178)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(141, 20)
        Me.txtFirst.TabIndex = 11
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(131, 255)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(141, 20)
        Me.txtAd.TabIndex = 13
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(131, 291)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(141, 20)
        Me.txtMail.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(131, 334)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(141, 20)
        Me.txtUser.TabIndex = 15
        '
        'txtPswd
        '
        Me.txtPswd.Location = New System.Drawing.Point(131, 373)
        Me.txtPswd.Name = "txtPswd"
        Me.txtPswd.Size = New System.Drawing.Size(141, 20)
        Me.txtPswd.TabIndex = 16
        '
        'btnSign
        '
        Me.btnSign.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.Location = New System.Drawing.Point(31, 415)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(226, 35)
        Me.btnSign.TabIndex = 17
        Me.btnSign.Text = "Sign up"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 66)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(67, 29)
        Me.btnReturn.TabIndex = 18
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'cbxGender
        '
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Location = New System.Drawing.Point(131, 107)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(46, 21)
        Me.cbxGender.TabIndex = 19
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(131, 217)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(46, 20)
        Me.txtAge.TabIndex = 20
        '
        'fSign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.txtPswd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.lblPswd)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.pnlTitre1)
        Me.Name = "fSign"
        Me.Text = "Sign up !"
        Me.pnlTitre1.ResumeLayout(False)
        Me.pnlTitre1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre1 As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPswd As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPswd As TextBox
    Friend WithEvents btnSign As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents txtAge As TextBox
End Class
