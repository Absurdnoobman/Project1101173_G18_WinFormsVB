<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientAllocationList
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAllocationList))
		Me.WardComboBox = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.OnDateComboBox = New System.Windows.Forms.ComboBox()
		Me.WardNameLabel = New System.Windows.Forms.Label()
		Me.EmptyLabel = New System.Windows.Forms.Label()
		Me.LocationLabel = New System.Windows.Forms.Label()
		Me.ChargeNurseLabel = New System.Windows.Forms.Label()
		Me.ChargeNurseFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.ChargeNurseStaffNumLabel = New System.Windows.Forms.Label()
		Me.ChargeNurseFullnameLabel = New System.Windows.Forms.Label()
		Me.RecordsNumberLabel = New System.Windows.Forms.Label()
		Me.AllocationDGV = New System.Windows.Forms.DataGridView()
		Me.EditButton = New System.Windows.Forms.Button()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.ChargeNurseFLP.SuspendLayout()
		CType(Me.AllocationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'WardComboBox
		'
		Me.WardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WardComboBox.FormattingEnabled = True
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
		Me.Label2.Location = New System.Drawing.Point(241, 19)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "on Date"
		'
		'OnDateComboBox
		'
		Me.OnDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.OnDateComboBox.FormattingEnabled = True
		Me.OnDateComboBox.Location = New System.Drawing.Point(301, 16)
		Me.OnDateComboBox.Name = "OnDateComboBox"
		Me.OnDateComboBox.Size = New System.Drawing.Size(147, 25)
		Me.OnDateComboBox.TabIndex = 3
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
		Me.EmptyLabel.Location = New System.Drawing.Point(262, 264)
		Me.EmptyLabel.Name = "EmptyLabel"
		Me.EmptyLabel.Size = New System.Drawing.Size(248, 17)
		Me.EmptyLabel.TabIndex = 5
		Me.EmptyLabel.Text = "Please Select a ward and week beginning"
		'
		'LocationLabel
		'
		Me.LocationLabel.AutoSize = True
		Me.LocationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LocationLabel.Location = New System.Drawing.Point(29, 91)
		Me.LocationLabel.Name = "LocationLabel"
		Me.LocationLabel.Size = New System.Drawing.Size(67, 20)
		Me.LocationLabel.TabIndex = 6
		Me.LocationLabel.Text = "Location"
		'
		'ChargeNurseLabel
		'
		Me.ChargeNurseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.ChargeNurseLabel.AutoSize = True
		Me.ChargeNurseLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChargeNurseLabel.Location = New System.Drawing.Point(406, 60)
		Me.ChargeNurseLabel.Name = "ChargeNurseLabel"
		Me.ChargeNurseLabel.Size = New System.Drawing.Size(91, 17)
		Me.ChargeNurseLabel.TabIndex = 7
		Me.ChargeNurseLabel.Text = "Charge Nurse"
		'
		'ChargeNurseFLP
		'
		Me.ChargeNurseFLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ChargeNurseFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ChargeNurseFLP.Controls.Add(Me.ChargeNurseStaffNumLabel)
		Me.ChargeNurseFLP.Controls.Add(Me.ChargeNurseFullnameLabel)
		Me.ChargeNurseFLP.Location = New System.Drawing.Point(409, 82)
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
		'RecordsNumberLabel
		'
		Me.RecordsNumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.RecordsNumberLabel.AutoSize = True
		Me.RecordsNumberLabel.Location = New System.Drawing.Point(29, 436)
		Me.RecordsNumberLabel.Name = "RecordsNumberLabel"
		Me.RecordsNumberLabel.Size = New System.Drawing.Size(95, 17)
		Me.RecordsNumberLabel.TabIndex = 10
		Me.RecordsNumberLabel.Text = "Record 69 / 69"
		'
		'AllocationDGV
		'
		Me.AllocationDGV.AllowUserToAddRows = False
		Me.AllocationDGV.AllowUserToDeleteRows = False
		Me.AllocationDGV.AllowUserToOrderColumns = True
		Me.AllocationDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.AllocationDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.AllocationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.AllocationDGV.Location = New System.Drawing.Point(20, 138)
		Me.AllocationDGV.MultiSelect = False
		Me.AllocationDGV.Name = "AllocationDGV"
		Me.AllocationDGV.ReadOnly = True
		Me.AllocationDGV.RowHeadersWidth = 51
		Me.AllocationDGV.RowTemplate.Height = 24
		Me.AllocationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.AllocationDGV.Size = New System.Drawing.Size(710, 285)
		Me.AllocationDGV.TabIndex = 11
		'
		'EditButton
		'
		Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.EditButton.Enabled = False
		Me.EditButton.Location = New System.Drawing.Point(652, 430)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(77, 39)
		Me.EditButton.TabIndex = 12
		Me.EditButton.Text = "Edit"
		Me.EditButton.UseVisualStyleBackColor = True
		'
		'DeleteButton
		'
		Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DeleteButton.Enabled = False
		Me.DeleteButton.Location = New System.Drawing.Point(569, 430)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(77, 39)
		Me.DeleteButton.TabIndex = 13
		Me.DeleteButton.Text = "Delete"
		Me.DeleteButton.UseVisualStyleBackColor = True
		'
		'PatientAllocationList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(753, 478)
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.EditButton)
		Me.Controls.Add(Me.AllocationDGV)
		Me.Controls.Add(Me.RecordsNumberLabel)
		Me.Controls.Add(Me.ChargeNurseFLP)
		Me.Controls.Add(Me.ChargeNurseLabel)
		Me.Controls.Add(Me.LocationLabel)
		Me.Controls.Add(Me.EmptyLabel)
		Me.Controls.Add(Me.WardNameLabel)
		Me.Controls.Add(Me.OnDateComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.WardComboBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "PatientAllocationList"
		Me.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
		Me.Text = "Patient Allocation"
		Me.ChargeNurseFLP.ResumeLayout(False)
		Me.ChargeNurseFLP.PerformLayout()
		CType(Me.AllocationDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents WardComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OnDateComboBox As ComboBox
    Friend WithEvents WardNameLabel As Label
    Friend WithEvents EmptyLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ChargeNurseLabel As Label
    Friend WithEvents ChargeNurseFLP As FlowLayoutPanel
    Friend WithEvents ChargeNurseStaffNumLabel As Label
    Friend WithEvents ChargeNurseFullnameLabel As Label
	Friend WithEvents RecordsNumberLabel As Label
	Friend WithEvents AllocationDGV As DataGridView
	Friend WithEvents EditButton As Button
	Friend WithEvents DeleteButton As Button
End Class
