<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkExperienceForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrganisationTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Position"
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Location = New System.Drawing.Point(12, 29)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(378, 25)
        Me.PositionTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Organisation"
        '
        'OrganisationTextBox
        '
        Me.OrganisationTextBox.Location = New System.Drawing.Point(12, 89)
        Me.OrganisationTextBox.Name = "OrganisationTextBox"
        Me.OrganisationTextBox.Size = New System.Drawing.Size(378, 25)
        Me.OrganisationTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Date"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Location = New System.Drawing.Point(12, 155)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(378, 25)
        Me.StartDateTimePicker.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Finish Date"
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Location = New System.Drawing.Point(12, 214)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(378, 25)
        Me.EndDateTimePicker.TabIndex = 7
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(12, 265)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(61, 30)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(298, 265)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(92, 30)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(200, 265)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(92, 30)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddNewWorkExperienceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 307)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StartDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OrganisationTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddNewWorkExperienceForm"
        Me.Text = "Add a New Work Experience"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OrganisationTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents EndDateTimePicker As DateTimePicker
    Friend WithEvents ResetButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
End Class
