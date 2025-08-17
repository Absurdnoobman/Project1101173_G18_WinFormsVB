<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffCardWithCheckBox
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
        Me.SelectCheckBox = New System.Windows.Forms.CheckBox()
        Me.StaffNumberLabel = New System.Windows.Forms.Label()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SelectCheckBox
        '
        Me.SelectCheckBox.AutoSize = True
        Me.SelectCheckBox.Location = New System.Drawing.Point(566, 30)
        Me.SelectCheckBox.Name = "SelectCheckBox"
        Me.SelectCheckBox.Size = New System.Drawing.Size(64, 21)
        Me.SelectCheckBox.TabIndex = 0
        Me.SelectCheckBox.Text = "Select"
        Me.SelectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SelectCheckBox.UseVisualStyleBackColor = True
        '
        'StaffNumberLabel
        '
        Me.StaffNumberLabel.AutoSize = True
        Me.StaffNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffNumberLabel.Location = New System.Drawing.Point(21, 27)
        Me.StaffNumberLabel.Name = "StaffNumberLabel"
        Me.StaffNumberLabel.Size = New System.Drawing.Size(41, 23)
        Me.StaffNumberLabel.TabIndex = 1
        Me.StaffNumberLabel.Text = "S---"
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameLabel.Location = New System.Drawing.Point(94, 30)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(68, 17)
        Me.FirstnameLabel.TabIndex = 2
        Me.FirstnameLabel.Text = "Firstname"
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameLabel.Location = New System.Drawing.Point(189, 30)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(62, 17)
        Me.SurnameLabel.TabIndex = 3
        Me.SurnameLabel.Text = "Surname"
        '
        'StaffCardWithCheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SurnameLabel)
        Me.Controls.Add(Me.FirstnameLabel)
        Me.Controls.Add(Me.StaffNumberLabel)
        Me.Controls.Add(Me.SelectCheckBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StaffCardWithCheckBox"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(637, 78)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectCheckBox As CheckBox
    Friend WithEvents StaffNumberLabel As Label
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents SurnameLabel As Label
End Class
