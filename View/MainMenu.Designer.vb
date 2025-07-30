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
        Me.OpenPatientButton = New System.Windows.Forms.Button()
        Me.WardAssignmentButton = New System.Windows.Forms.Button()
        Me.MakeAppointmentButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'OpenPatientButton
        '
        Me.OpenPatientButton.Location = New System.Drawing.Point(44, 161)
        Me.OpenPatientButton.Name = "OpenPatientButton"
        Me.OpenPatientButton.Size = New System.Drawing.Size(102, 54)
        Me.OpenPatientButton.TabIndex = 3
        Me.OpenPatientButton.Text = "Create a Patient Record"
        Me.OpenPatientButton.UseVisualStyleBackColor = True
        '
        'WardAssignmentButton
        '
        Me.WardAssignmentButton.Location = New System.Drawing.Point(152, 101)
        Me.WardAssignmentButton.Name = "WardAssignmentButton"
        Me.WardAssignmentButton.Size = New System.Drawing.Size(102, 54)
        Me.WardAssignmentButton.TabIndex = 4
        Me.WardAssignmentButton.Text = "Assign Staff to Ward"
        Me.WardAssignmentButton.UseVisualStyleBackColor = True
        '
        'MakeAppointmentButton
        '
        Me.MakeAppointmentButton.Location = New System.Drawing.Point(152, 162)
        Me.MakeAppointmentButton.Name = "MakeAppointmentButton"
        Me.MakeAppointmentButton.Size = New System.Drawing.Size(102, 53)
        Me.MakeAppointmentButton.TabIndex = 5
        Me.MakeAppointmentButton.Text = "Make a Appointment"
        Me.MakeAppointmentButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 53)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Appointments"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MakeAppointmentButton)
        Me.Controls.Add(Me.WardAssignmentButton)
        Me.Controls.Add(Me.OpenPatientButton)
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
    Friend WithEvents OpenPatientButton As Button
    Friend WithEvents WardAssignmentButton As Button
    Friend WithEvents MakeAppointmentButton As Button
    Friend WithEvents Button2 As Button
End Class
