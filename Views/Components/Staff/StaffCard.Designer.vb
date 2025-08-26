<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffCard
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
		Me.FirstNameLabel = New System.Windows.Forms.Label()
		Me.SurnameLabel = New System.Windows.Forms.Label()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.EditButton = New System.Windows.Forms.Button()
		Me.StaffIdLabel = New System.Windows.Forms.Label()
		Me.PositionLabel = New System.Windows.Forms.Label()
		Me.AddressLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'FirstNameLabel
		'
		Me.FirstNameLabel.AutoSize = True
		Me.FirstNameLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FirstNameLabel.Location = New System.Drawing.Point(94, 12)
		Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(0)
		Me.FirstNameLabel.Name = "FirstNameLabel"
		Me.FirstNameLabel.Size = New System.Drawing.Size(67, 17)
		Me.FirstNameLabel.TabIndex = 0
		Me.FirstNameLabel.Text = "firstname"
		'
		'SurnameLabel
		'
		Me.SurnameLabel.AutoSize = True
		Me.SurnameLabel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SurnameLabel.Location = New System.Drawing.Point(173, 12)
		Me.SurnameLabel.Margin = New System.Windows.Forms.Padding(0)
		Me.SurnameLabel.Name = "SurnameLabel"
		Me.SurnameLabel.Size = New System.Drawing.Size(61, 17)
		Me.SurnameLabel.TabIndex = 1
		Me.SurnameLabel.Text = "surname"
		'
		'DeleteButton
		'
		Me.DeleteButton.Location = New System.Drawing.Point(637, 26)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
		Me.DeleteButton.TabIndex = 2
		Me.DeleteButton.Text = "Delete"
		Me.DeleteButton.UseVisualStyleBackColor = True
		'
		'EditButton
		'
		Me.EditButton.Location = New System.Drawing.Point(556, 26)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(75, 23)
		Me.EditButton.TabIndex = 3
		Me.EditButton.Text = "Edit"
		Me.EditButton.UseVisualStyleBackColor = True
		'
		'StaffIdLabel
		'
		Me.StaffIdLabel.AutoSize = True
		Me.StaffIdLabel.Font = New System.Drawing.Font("Cascadia Code", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffIdLabel.Location = New System.Drawing.Point(15, 12)
		Me.StaffIdLabel.Name = "StaffIdLabel"
		Me.StaffIdLabel.Size = New System.Drawing.Size(50, 22)
		Me.StaffIdLabel.TabIndex = 4
		Me.StaffIdLabel.Text = "S---"
		'
		'PositionLabel
		'
		Me.PositionLabel.AutoSize = True
		Me.PositionLabel.Location = New System.Drawing.Point(298, 12)
		Me.PositionLabel.Name = "PositionLabel"
		Me.PositionLabel.Size = New System.Drawing.Size(55, 17)
		Me.PositionLabel.TabIndex = 5
		Me.PositionLabel.Text = "position"
		'
		'AddressLabel
		'
		Me.AddressLabel.AutoSize = True
		Me.AddressLabel.Location = New System.Drawing.Point(16, 49)
		Me.AddressLabel.Name = "AddressLabel"
		Me.AddressLabel.Size = New System.Drawing.Size(56, 17)
		Me.AddressLabel.TabIndex = 6
		Me.AddressLabel.Text = "Address"
		'
		'StaffCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.AddressLabel)
		Me.Controls.Add(Me.PositionLabel)
		Me.Controls.Add(Me.StaffIdLabel)
		Me.Controls.Add(Me.EditButton)
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.SurnameLabel)
		Me.Controls.Add(Me.FirstNameLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "StaffCard"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Size = New System.Drawing.Size(752, 80)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents FirstNameLabel As Label
    Friend WithEvents SurnameLabel As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents StaffIdLabel As Label
    Friend WithEvents PositionLabel As Label
	Friend WithEvents AddressLabel As Label
End Class
