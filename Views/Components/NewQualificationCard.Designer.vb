<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewQualificationCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.InstitutionLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel.Location = New System.Drawing.Point(7, 4)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(37, 17)
        Me.TypeLabel.TabIndex = 0
        Me.TypeLabel.Text = "Type"
        '
        'InstitutionLabel
        '
        Me.InstitutionLabel.AutoSize = True
        Me.InstitutionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstitutionLabel.Location = New System.Drawing.Point(6, 31)
        Me.InstitutionLabel.Name = "InstitutionLabel"
        Me.InstitutionLabel.Size = New System.Drawing.Size(71, 17)
        Me.InstitutionLabel.TabIndex = 1
        Me.InstitutionLabel.Text = "Institution"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(8, 59)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(36, 17)
        Me.DateLabel.TabIndex = 2
        Me.DateLabel.Text = "Date"
        '
        'RemoveButton
        '
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RemoveButton.Location = New System.Drawing.Point(195, 83)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(66, 24)
        Me.RemoveButton.TabIndex = 3
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'NewQualificationCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.InstitutionLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "NewQualificationCard"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(268, 112)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TypeLabel As Label
    Friend WithEvents InstitutionLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents RemoveButton As Button
End Class
