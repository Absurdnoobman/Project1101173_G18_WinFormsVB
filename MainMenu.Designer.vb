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
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 478)
        Me.Controls.Add(Me.OpenStaffListButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(724, 525)
        Me.Name = "MainMenuForm"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenStaffListButton As Button
End Class
