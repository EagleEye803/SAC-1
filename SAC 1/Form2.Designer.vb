<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblDeco1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(53, 201)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(58, 13)
        Me.lblProcess.TabIndex = 0
        Me.lblProcess.Text = "PROCESS"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(206, 66)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(179, 251)
        Me.lstDisplay.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(56, 66)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(127, 121)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH FOR STUDENT"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblDeco1
        '
        Me.lblDeco1.AutoSize = True
        Me.lblDeco1.Location = New System.Drawing.Point(203, 50)
        Me.lblDeco1.Name = "lblDeco1"
        Me.lblDeco1.Size = New System.Drawing.Size(83, 13)
        Me.lblDeco1.TabIndex = 3
        Me.lblDeco1.Text = "List of Students:"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(168, 343)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 409)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblDeco1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblProcess)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProcess As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblDeco1 As Label
    Friend WithEvents btnHome As Button
End Class
