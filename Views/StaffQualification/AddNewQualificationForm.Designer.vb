<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewQualificationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(15, 30)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(375, 25)
        Me.TypeTextBox.TabIndex = 1
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.Location = New System.Drawing.Point(15, 90)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(375, 25)
        Me.InstitutionTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Institution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(15, 150)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(375, 25)
        Me.DateTimePicker.TabIndex = 5
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(298, 265)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(92, 30)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(15, 265)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(61, 30)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(200, 265)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(92, 30)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddNewQualificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 307)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InstitutionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddNewQualificationForm"
        Me.Text = "Add a New Qualification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents AddButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
End Class
