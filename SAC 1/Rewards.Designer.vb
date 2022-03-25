<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rewards
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnPE = New System.Windows.Forms.Button()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(337, 143)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(117, 13)
        Me.lblHeading.TabIndex = 8
        Me.lblHeading.Text = "↓ SELECT SUBJECT ↓"
        '
        'btnPE
        '
        Me.btnPE.Location = New System.Drawing.Point(484, 176)
        Me.btnPE.Name = "btnPE"
        Me.btnPE.Size = New System.Drawing.Size(114, 100)
        Me.btnPE.TabIndex = 7
        Me.btnPE.Text = "PE"
        Me.btnPE.UseVisualStyleBackColor = True
        '
        'btnMath
        '
        Me.btnMath.Location = New System.Drawing.Point(340, 176)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(114, 100)
        Me.btnMath.TabIndex = 6
        Me.btnMath.Text = "MATHS"
        Me.btnMath.UseVisualStyleBackColor = True
        '
        'btnEnglish
        '
        Me.btnEnglish.Location = New System.Drawing.Point(203, 176)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(114, 100)
        Me.btnEnglish.TabIndex = 5
        Me.btnEnglish.Text = "ENGLISH"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(341, 333)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(113, 41)
        Me.btnHome.TabIndex = 9
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Rewards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnPE)
        Me.Controls.Add(Me.btnMath)
        Me.Controls.Add(Me.btnEnglish)
        Me.Name = "Rewards"
        Me.Text = "Rewards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnPE As Button
    Friend WithEvents btnMath As Button
    Friend WithEvents btnEnglish As Button
    Friend WithEvents btnHome As Button
End Class
