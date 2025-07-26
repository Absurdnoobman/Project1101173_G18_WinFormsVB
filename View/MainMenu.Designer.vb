<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Me.OpenStaffListButton = New System.Windows.Forms.Button()
        Me.OpenWardButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenStaffListButton
        '
        Me.OpenStaffListButton.Location = New System.Drawing.Point(44, 41)
        Me.OpenStaffListButton.Name = "OpenStaffListButton"
        Me.OpenStaffListButton.Size = New System.Drawing.Size(102, 54)
        Me.OpenStaffListButton.TabIndex = 0
        Me.OpenStaffListButton.Text = "Staff"
        Me.OpenStaffListButton.UseVisualStyleBackColor = True
        '
        'OpenWardButton
        '
        Me.OpenWardButton.Location = New System.Drawing.Point(44, 101)
        Me.OpenWardButton.Name = "OpenWardButton"
        Me.OpenWardButton.Size = New System.Drawing.Size(102, 54)
        Me.OpenWardButton.TabIndex = 1
        Me.OpenWardButton.Text = "Ward"
        Me.OpenWardButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Work in Progress"
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpenWardButton)
        Me.Controls.Add(Me.OpenStaffListButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(724, 525)
        Me.Name = "MainMenuForm"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenStaffListButton As Button
    Friend WithEvents OpenWardButton As Button
    Friend WithEvents Label1 As Label
End Class
