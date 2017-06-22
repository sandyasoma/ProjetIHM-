<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLog
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
        Me.pnlTitre1 = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPswd = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPswd = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pnlTitre1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitre1
        '
        Me.pnlTitre1.BackColor = System.Drawing.Color.Green
        Me.pnlTitre1.Controls.Add(Me.lblTitre)
        Me.pnlTitre1.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitre1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTitre1.Name = "pnlTitre1"
        Me.pnlTitre1.Size = New System.Drawing.Size(379, 74)
        Me.pnlTitre1.TabIndex = 1
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(40, 0)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(302, 55)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "QuickPurchase"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(16, 225)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(99, 26)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Username"
        '
        'lblPswd
        '
        Me.lblPswd.AutoSize = True
        Me.lblPswd.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPswd.Location = New System.Drawing.Point(20, 274)
        Me.lblPswd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPswd.Name = "lblPswd"
        Me.lblPswd.Size = New System.Drawing.Size(94, 26)
        Me.lblPswd.TabIndex = 4
        Me.lblPswd.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(144, 225)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(217, 22)
        Me.txtUser.TabIndex = 16
        '
        'txtPswd
        '
        Me.txtPswd.Location = New System.Drawing.Point(144, 274)
        Me.txtPswd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPswd.Name = "txtPswd"
        Me.txtPswd.Size = New System.Drawing.Size(217, 22)
        Me.txtPswd.TabIndex = 17
        Me.txtPswd.UseSystemPasswordChar = True
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(39, 487)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(301, 43)
        Me.btnLog.TabIndex = 19
        Me.btnLog.Text = "Log in"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(16, 81)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(89, 36)
        Me.btnReturn.TabIndex = 20
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'fLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 569)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.txtPswd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPswd)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.pnlTitre1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fLog"
        Me.Text = "Log in !"
        Me.pnlTitre1.ResumeLayout(False)
        Me.pnlTitre1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitre1 As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPswd As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPswd As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents btnReturn As Button
End Class
