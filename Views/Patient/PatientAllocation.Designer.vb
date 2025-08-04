<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientAllocation
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
        Me.WardComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WeekComboBox = New System.Windows.Forms.ComboBox()
        Me.WardNameLabel = New System.Windows.Forms.Label()
        Me.EmptyLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ChargeNurseLabel = New System.Windows.Forms.Label()
        Me.ChargeNurseFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChargeNurseStaffNumLabel = New System.Windows.Forms.Label()
        Me.ChargeNurseFullnameLabel = New System.Windows.Forms.Label()
        Me.AllocationFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.RecordsNumberLabel = New System.Windows.Forms.Label()
        Me.ChargeNurseFLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'WardComboBox
        '
        Me.WardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WardComboBox.FormattingEnabled = True
        Me.WardComboBox.Items.AddRange(New Object() {"Seefbgheseh"})
        Me.WardComboBox.Location = New System.Drawing.Point(62, 16)
        Me.WardComboBox.Name = "WardComboBox"
        Me.WardComboBox.Size = New System.Drawing.Size(158, 25)
        Me.WardComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ward"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week Beginning"
        '
        'WeekComboBox
        '
        Me.WeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WeekComboBox.FormattingEnabled = True
        Me.WeekComboBox.Items.AddRange(New Object() {"adsada", "adadasdad", "asfwaeafeafqrfqf"})
        Me.WeekComboBox.Location = New System.Drawing.Point(356, 16)
        Me.WeekComboBox.Name = "WeekComboBox"
        Me.WeekComboBox.Size = New System.Drawing.Size(147, 25)
        Me.WeekComboBox.TabIndex = 3
        '
        'WardNameLabel
        '
        Me.WardNameLabel.AutoSize = True
        Me.WardNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WardNameLabel.Location = New System.Drawing.Point(28, 56)
        Me.WardNameLabel.Name = "WardNameLabel"
        Me.WardNameLabel.Size = New System.Drawing.Size(105, 23)
        Me.WardNameLabel.TabIndex = 4
        Me.WardNameLabel.Text = "Ward Name"
        '
        'EmptyLabel
        '
        Me.EmptyLabel.AutoSize = True
        Me.EmptyLabel.Location = New System.Drawing.Point(219, 250)
        Me.EmptyLabel.Name = "EmptyLabel"
        Me.EmptyLabel.Size = New System.Drawing.Size(248, 17)
        Me.EmptyLabel.TabIndex = 5
        Me.EmptyLabel.Text = "Please Select a ward and week beginning"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel.Location = New System.Drawing.Point(28, 92)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(67, 20)
        Me.LocationLabel.TabIndex = 6
        Me.LocationLabel.Text = "Location"
        '
        'ChargeNurseLabel
        '
        Me.ChargeNurseLabel.AutoSize = True
        Me.ChargeNurseLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeNurseLabel.Location = New System.Drawing.Point(353, 62)
        Me.ChargeNurseLabel.Name = "ChargeNurseLabel"
        Me.ChargeNurseLabel.Size = New System.Drawing.Size(91, 17)
        Me.ChargeNurseLabel.TabIndex = 7
        Me.ChargeNurseLabel.Text = "Charge Nurse"
        '
        'ChargeNurseFLP
        '
        Me.ChargeNurseFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChargeNurseFLP.Controls.Add(Me.ChargeNurseStaffNumLabel)
        Me.ChargeNurseFLP.Controls.Add(Me.ChargeNurseFullnameLabel)
        Me.ChargeNurseFLP.Location = New System.Drawing.Point(356, 82)
        Me.ChargeNurseFLP.Name = "ChargeNurseFLP"
        Me.ChargeNurseFLP.Size = New System.Drawing.Size(248, 37)
        Me.ChargeNurseFLP.TabIndex = 8
        '
        'ChargeNurseStaffNumLabel
        '
        Me.ChargeNurseStaffNumLabel.AutoSize = True
        Me.ChargeNurseStaffNumLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChargeNurseStaffNumLabel.Location = New System.Drawing.Point(4, 8)
        Me.ChargeNurseStaffNumLabel.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.ChargeNurseStaffNumLabel.Name = "ChargeNurseStaffNumLabel"
        Me.ChargeNurseStaffNumLabel.Size = New System.Drawing.Size(30, 17)
        Me.ChargeNurseStaffNumLabel.TabIndex = 0
        Me.ChargeNurseStaffNumLabel.Text = "S---"
        '
        'ChargeNurseFullnameLabel
        '
        Me.ChargeNurseFullnameLabel.AutoSize = True
        Me.ChargeNurseFullnameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChargeNurseFullnameLabel.Location = New System.Drawing.Point(41, 8)
        Me.ChargeNurseFullnameLabel.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.ChargeNurseFullnameLabel.Name = "ChargeNurseFullnameLabel"
        Me.ChargeNurseFullnameLabel.Size = New System.Drawing.Size(59, 17)
        Me.ChargeNurseFullnameLabel.TabIndex = 1
        Me.ChargeNurseFullnameLabel.Text = "Fullname"
        '
        'AllocationFLP
        '
        Me.AllocationFLP.AutoScroll = True
        Me.AllocationFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AllocationFLP.Location = New System.Drawing.Point(20, 135)
        Me.AllocationFLP.Name = "AllocationFLP"
        Me.AllocationFLP.Size = New System.Drawing.Size(659, 284)
        Me.AllocationFLP.TabIndex = 9
        Me.AllocationFLP.WrapContents = False
        '
        'RecordsNumberLabel
        '
        Me.RecordsNumberLabel.AutoSize = True
        Me.RecordsNumberLabel.Location = New System.Drawing.Point(29, 426)
        Me.RecordsNumberLabel.Name = "RecordsNumberLabel"
        Me.RecordsNumberLabel.Size = New System.Drawing.Size(95, 17)
        Me.RecordsNumberLabel.TabIndex = 10
        Me.RecordsNumberLabel.Text = "Record 69 / 69"
        '
        'PatientAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 478)
        Me.Controls.Add(Me.RecordsNumberLabel)
        Me.Controls.Add(Me.AllocationFLP)
        Me.Controls.Add(Me.ChargeNurseFLP)
        Me.Controls.Add(Me.ChargeNurseLabel)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.EmptyLabel)
        Me.Controls.Add(Me.WardNameLabel)
        Me.Controls.Add(Me.WeekComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WardComboBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PatientAllocation"
        Me.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Text = "Patient Allocation"
        Me.ChargeNurseFLP.ResumeLayout(False)
        Me.ChargeNurseFLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WardComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WeekComboBox As ComboBox
    Friend WithEvents WardNameLabel As Label
    Friend WithEvents EmptyLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ChargeNurseLabel As Label
    Friend WithEvents ChargeNurseFLP As FlowLayoutPanel
    Friend WithEvents ChargeNurseStaffNumLabel As Label
    Friend WithEvents ChargeNurseFullnameLabel As Label
    Friend WithEvents AllocationFLP As FlowLayoutPanel
    Friend WithEvents RecordsNumberLabel As Label
End Class
