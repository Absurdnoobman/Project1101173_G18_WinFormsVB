<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentList
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentList))
		Me.SearchTextBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MakeAppointmentButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SearchByComboBox = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.AppointmentDGV = New System.Windows.Forms.DataGridView()
		Me.RefreshButton = New System.Windows.Forms.Button()
		Me.EditButton = New System.Windows.Forms.Button()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.ExportButton = New System.Windows.Forms.Button()
		CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SearchTextBox
		'
		Me.SearchTextBox.Location = New System.Drawing.Point(65, 47)
		Me.SearchTextBox.Name = "SearchTextBox"
		Me.SearchTextBox.Size = New System.Drawing.Size(223, 25)
		Me.SearchTextBox.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 17)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Search"
		'
		'MakeAppointmentButton
		'
		Me.MakeAppointmentButton.Location = New System.Drawing.Point(587, 13)
		Me.MakeAppointmentButton.Name = "MakeAppointmentButton"
		Me.MakeAppointmentButton.Size = New System.Drawing.Size(154, 28)
		Me.MakeAppointmentButton.TabIndex = 3
		Me.MakeAppointmentButton.Text = "Make An Appointment"
		Me.MakeAppointmentButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(10, 10)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(146, 28)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Appointments"
		'
		'SearchByComboBox
		'
		Me.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SearchByComboBox.FormattingEnabled = True
		Me.SearchByComboBox.Items.AddRange(New Object() {"Patient Number", "Fullname"})
		Me.SearchByComboBox.Location = New System.Drawing.Point(376, 47)
		Me.SearchByComboBox.Name = "SearchByComboBox"
		Me.SearchByComboBox.Size = New System.Drawing.Size(111, 25)
		Me.SearchByComboBox.TabIndex = 10
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(306, 50)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(64, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Search By"
		'
		'AppointmentDGV
		'
		Me.AppointmentDGV.AllowUserToAddRows = False
		Me.AppointmentDGV.AllowUserToDeleteRows = False
		Me.AppointmentDGV.AllowUserToOrderColumns = True
		Me.AppointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.AppointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.AppointmentDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.AppointmentDGV.Location = New System.Drawing.Point(10, 87)
		Me.AppointmentDGV.MultiSelect = False
		Me.AppointmentDGV.Name = "AppointmentDGV"
		Me.AppointmentDGV.ReadOnly = True
		Me.AppointmentDGV.RowHeadersWidth = 51
		Me.AppointmentDGV.RowTemplate.Height = 24
		Me.AppointmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.AppointmentDGV.Size = New System.Drawing.Size(731, 342)
		Me.AppointmentDGV.TabIndex = 12
		'
		'RefreshButton
		'
		Me.RefreshButton.Location = New System.Drawing.Point(10, 436)
		Me.RefreshButton.Name = "RefreshButton"
		Me.RefreshButton.Size = New System.Drawing.Size(90, 33)
		Me.RefreshButton.TabIndex = 13
		Me.RefreshButton.Text = "Refresh"
		Me.RefreshButton.UseVisualStyleBackColor = True
		'
		'EditButton
		'
		Me.EditButton.Enabled = False
		Me.EditButton.Location = New System.Drawing.Point(585, 435)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(75, 33)
		Me.EditButton.TabIndex = 14
		Me.EditButton.Text = "Edit"
		Me.EditButton.UseVisualStyleBackColor = True
		'
		'DeleteButton
		'
		Me.DeleteButton.Enabled = False
		Me.DeleteButton.Location = New System.Drawing.Point(666, 435)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(75, 32)
		Me.DeleteButton.TabIndex = 15
		Me.DeleteButton.Text = "Delete"
		Me.DeleteButton.UseVisualStyleBackColor = True
		'
		'ExportButton
		'
		Me.ExportButton.Location = New System.Drawing.Point(106, 436)
		Me.ExportButton.Name = "ExportButton"
		Me.ExportButton.Size = New System.Drawing.Size(111, 33)
		Me.ExportButton.TabIndex = 16
		Me.ExportButton.Text = "Export To CSV"
		Me.ExportButton.UseVisualStyleBackColor = True
		'
		'AppointmentList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(750, 478)
		Me.Controls.Add(Me.ExportButton)
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.EditButton)
		Me.Controls.Add(Me.RefreshButton)
		Me.Controls.Add(Me.AppointmentDGV)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.SearchByComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MakeAppointmentButton)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.SearchTextBox)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "AppointmentList"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.Text = "Appointments"
		CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents SearchTextBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents MakeAppointmentButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents SearchByComboBox As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents AppointmentDGV As DataGridView
	Friend WithEvents RefreshButton As Button
	Friend WithEvents EditButton As Button
	Friend WithEvents DeleteButton As Button
	Friend WithEvents ExportButton As Button
End Class
