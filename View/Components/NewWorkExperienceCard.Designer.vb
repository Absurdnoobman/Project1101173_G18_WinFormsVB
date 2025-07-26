<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewWorkExperienceCard
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
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.OrganisationLabel = New System.Windows.Forms.Label()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Location = New System.Drawing.Point(8, 8)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(52, 17)
        Me.PositionLabel.TabIndex = 0
        Me.PositionLabel.Text = "As a ___"
        '
        'OrganisationLabel
        '
        Me.OrganisationLabel.AutoSize = True
        Me.OrganisationLabel.Location = New System.Drawing.Point(8, 30)
        Me.OrganisationLabel.Name = "OrganisationLabel"
        Me.OrganisationLabel.Size = New System.Drawing.Size(18, 17)
        Me.OrganisationLabel.TabIndex = 1
        Me.OrganisationLabel.Text = "In"
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Location = New System.Drawing.Point(8, 53)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(62, 17)
        Me.StartDateLabel.TabIndex = 2
        Me.StartDateLabel.Text = "StartDate"
        '
        'EndDateLabel
        '
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Location = New System.Drawing.Point(8, 74)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(82, 17)
        Me.EndDateLabel.TabIndex = 3
        Me.EndDateLabel.Text = "FinishedDate"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(186, 82)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'NewWorkExperienceCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.EndDateLabel)
        Me.Controls.Add(Me.StartDateLabel)
        Me.Controls.Add(Me.OrganisationLabel)
        Me.Controls.Add(Me.PositionLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "NewWorkExperienceCard"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(268, 112)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PositionLabel As Label
    Friend WithEvents OrganisationLabel As Label
    Friend WithEvents StartDateLabel As Label
    Friend WithEvents EndDateLabel As Label
    Friend WithEvents RemoveButton As Button
End Class
