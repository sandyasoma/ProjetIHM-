<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fQuickpurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fQuickpurchase))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcome2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Green
        Me.lblWelcome.Location = New System.Drawing.Point(68, 81)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(127, 29)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWelcome2
        '
        Me.lblWelcome2.AutoSize = True
        Me.lblWelcome2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome2.ForeColor = System.Drawing.Color.Green
        Me.lblWelcome2.Location = New System.Drawing.Point(37, 134)
        Me.lblWelcome2.Name = "lblWelcome2"
        Me.lblWelcome2.Size = New System.Drawing.Size(197, 35)
        Me.lblWelcome2.TabIndex = 1
        Me.lblWelcome2.Text = "QuickPurchase !"
        Me.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(84, 203)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(111, 135)
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Controls.Add(Me.btnSign)
        Me.Panel1.Location = New System.Drawing.Point(34, 409)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 41)
        Me.Panel1.TabIndex = 3
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(112, 3)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(100, 35)
        Me.btnLog.TabIndex = 1
        Me.btnLog.Text = "Log in"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.Location = New System.Drawing.Point(3, 3)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(100, 35)
        Me.btnSign.TabIndex = 0
        Me.btnSign.Text = "Sign up"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'fQuickpurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblWelcome2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "fQuickpurchase"
        Me.Text = "Welcome to Quickpurchase !"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblWelcome2 As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSign As Button
    Friend WithEvents btnLog As Button
End Class
