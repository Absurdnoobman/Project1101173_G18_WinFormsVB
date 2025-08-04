<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickStaffDialog
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
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchByLabel = New System.Windows.Forms.Label()
        Me.SearchByComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search: "
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(75, 15)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(261, 25)
        Me.SearchTextBox.TabIndex = 1
        '
        'SearchByLabel
        '
        Me.SearchByLabel.AutoSize = True
        Me.SearchByLabel.Location = New System.Drawing.Point(352, 18)
        Me.SearchByLabel.Name = "SearchByLabel"
        Me.SearchByLabel.Size = New System.Drawing.Size(64, 17)
        Me.SearchByLabel.TabIndex = 2
        Me.SearchByLabel.Text = "Search By"
        '
        'SearchByComboBox
        '
        Me.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchByComboBox.FormattingEnabled = True
        Me.SearchByComboBox.Location = New System.Drawing.Point(422, 15)
        Me.SearchByComboBox.Name = "SearchByComboBox"
        Me.SearchByComboBox.Size = New System.Drawing.Size(155, 25)
        Me.SearchByComboBox.TabIndex = 3
        '
        'StaffFLP
        '
        Me.StaffFLP.AutoScroll = True
        Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StaffFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.StaffFLP.Location = New System.Drawing.Point(16, 46)
        Me.StaffFLP.Name = "StaffFLP"
        Me.StaffFLP.Size = New System.Drawing.Size(669, 375)
        Me.StaffFLP.TabIndex = 4
        Me.StaffFLP.WrapContents = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(545, 427)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(139, 36)
        Me.ConfirmButton.TabIndex = 5
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'PickStaffDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 478)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.StaffFLP)
        Me.Controls.Add(Me.SearchByComboBox)
        Me.Controls.Add(Me.SearchByLabel)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PickStaffDialog"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Text = "Pick Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchByLabel As Label
    Friend WithEvents SearchByComboBox As ComboBox
    Friend WithEvents StaffFLP As FlowLayoutPanel
    Friend WithEvents ConfirmButton As Button
End Class
