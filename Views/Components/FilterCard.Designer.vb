<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterCard
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
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ValueComboBox = New System.Windows.Forms.ComboBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ColumnComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'RemoveButton
        '
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RemoveButton.Location = New System.Drawing.Point(352, 5)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 7
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ValueComboBox
        '
        Me.ValueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ValueComboBox.FormattingEnabled = True
        Me.ValueComboBox.Location = New System.Drawing.Point(224, 4)
        Me.ValueComboBox.Name = "ValueComboBox"
        Me.ValueComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ValueComboBox.TabIndex = 6
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Location = New System.Drawing.Point(133, 4)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(85, 24)
        Me.TypeComboBox.TabIndex = 5
        '
        'ColumnComboBox
        '
        Me.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColumnComboBox.FormattingEnabled = True
        Me.ColumnComboBox.Location = New System.Drawing.Point(6, 4)
        Me.ColumnComboBox.Name = "ColumnComboBox"
        Me.ColumnComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ColumnComboBox.TabIndex = 4
        '
        'FilterCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ValueComboBox)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.ColumnComboBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FilterCard"
        Me.Size = New System.Drawing.Size(431, 48)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RemoveButton As Button
    Friend WithEvents ValueComboBox As ComboBox
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents ColumnComboBox As ComboBox
End Class
