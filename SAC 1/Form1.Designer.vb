<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPseudo = New System.Windows.Forms.Button()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(91, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 106)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add to CSV"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(91, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 20)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(88, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "ENTER STUDENT NAME:"
        '
        'btnPseudo
        '
        Me.btnPseudo.Location = New System.Drawing.Point(159, 278)
        Me.btnPseudo.Name = "btnPseudo"
        Me.btnPseudo.Size = New System.Drawing.Size(65, 65)
        Me.btnPseudo.TabIndex = 6
        Me.btnPseudo.Text = "Read CSV"
        Me.btnPseudo.UseVisualStyleBackColor = True
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(265, 278)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(46, 13)
        Me.lblPeople.TabIndex = 7
        Me.lblPeople.Text = "People: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(91, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 65)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear CSV"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(495, 171)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(135, 76)
        Me.btnForm2.TabIndex = 9
        Me.btnForm2.Text = "INTERVIEW MODE"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.btnPseudo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnPseudo As Button
    Friend WithEvents lblPeople As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnForm2 As Button
End Class
