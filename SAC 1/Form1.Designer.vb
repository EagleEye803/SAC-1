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
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnRewards = New System.Windows.Forms.Button()
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
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(159, 268)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(65, 65)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "Calculate Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(239, 278)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(46, 13)
        Me.lblPeople.TabIndex = 7
        Me.lblPeople.Text = "People: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(91, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 65)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear CSV"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(91, 339)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(135, 35)
        Me.btnForm2.TabIndex = 9
        Me.btnForm2.Text = "INTERVIEW MODE"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.Color.White
        Me.lstDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(242, 83)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.ScrollAlwaysVisible = True
        Me.lstDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDisplay.Size = New System.Drawing.Size(192, 186)
        Me.lstDisplay.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTitle.Font = New System.Drawing.Font("Beleren2016 Small Caps", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(107, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(307, 42)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "MARKING SYSTEM"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(242, 307)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(90, 67)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "Alphabetize CSV"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnRewards
        '
        Me.btnRewards.Location = New System.Drawing.Point(338, 307)
        Me.btnRewards.Name = "btnRewards"
        Me.btnRewards.Size = New System.Drawing.Size(96, 66)
        Me.btnRewards.TabIndex = 13
        Me.btnRewards.Text = "Rewards Screen"
        Me.btnRewards.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 450)
        Me.Controls.Add(Me.btnRewards)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.btnAverage)
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
    Friend WithEvents btnAverage As Button
    Friend WithEvents lblPeople As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnForm2 As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents btnRewards As Button
End Class
