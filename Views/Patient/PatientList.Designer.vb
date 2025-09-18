<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientList
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SearchByComboBox = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SearchTextBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PatientsDGV = New System.Windows.Forms.DataGridView()
		Me.EditButton = New System.Windows.Forms.Button()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.CreateButton = New System.Windows.Forms.Button()
		CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(336, 63)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 17)
		Me.Label3.TabIndex = 15
		Me.Label3.Text = "Search By"
		'
		'SearchByComboBox
		'
		Me.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.SearchByComboBox.FormattingEnabled = True
		Me.SearchByComboBox.Items.AddRange(New Object() {"Patient Number", "Fullname", "Firstname", "Lastname", "Address"})
		Me.SearchByComboBox.Location = New System.Drawing.Point(406, 60)
		Me.SearchByComboBox.Name = "SearchByComboBox"
		Me.SearchByComboBox.Size = New System.Drawing.Size(121, 25)
		Me.SearchByComboBox.TabIndex = 14
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(16, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(47, 17)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Search"
		'
		'SearchTextBox
		'
		Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.SearchTextBox.Location = New System.Drawing.Point(69, 60)
		Me.SearchTextBox.MinimumSize = New System.Drawing.Size(150, 25)
		Me.SearchTextBox.Name = "SearchTextBox"
		Me.SearchTextBox.Size = New System.Drawing.Size(254, 25)
		Me.SearchTextBox.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(134, 31)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Patient List"
		'
		'PatientsDGV
		'
		Me.PatientsDGV.AllowUserToAddRows = False
		Me.PatientsDGV.AllowUserToDeleteRows = False
		Me.PatientsDGV.AllowUserToOrderColumns = True
		Me.PatientsDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.PatientsDGV.Location = New System.Drawing.Point(12, 101)
		Me.PatientsDGV.MultiSelect = False
		Me.PatientsDGV.Name = "PatientsDGV"
		Me.PatientsDGV.ReadOnly = True
		Me.PatientsDGV.RowHeadersWidth = 51
		Me.PatientsDGV.RowTemplate.Height = 24
		Me.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.PatientsDGV.Size = New System.Drawing.Size(676, 324)
		Me.PatientsDGV.TabIndex = 16
		'
		'EditButton
		'
		Me.EditButton.Location = New System.Drawing.Point(612, 432)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(75, 34)
		Me.EditButton.TabIndex = 17
		Me.EditButton.Text = "Edit"
		Me.EditButton.UseVisualStyleBackColor = True
		'
		'DeleteButton
		'
		Me.DeleteButton.Location = New System.Drawing.Point(531, 432)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(75, 34)
		Me.DeleteButton.TabIndex = 18
		Me.DeleteButton.Text = "Delete"
		Me.DeleteButton.UseVisualStyleBackColor = True
		'
		'CreateButton
		'
		Me.CreateButton.Location = New System.Drawing.Point(521, 9)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(165, 31)
		Me.CreateButton.TabIndex = 19
		Me.CreateButton.Text = "Create a patient record"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'PatientList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 478)
		Me.Controls.Add(Me.CreateButton)
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.EditButton)
		Me.Controls.Add(Me.PatientsDGV)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.SearchByComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.SearchTextBox)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "PatientList"
		Me.Text = "Patient List"
		CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label3 As Label
	Friend WithEvents SearchByComboBox As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents SearchTextBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PatientsDGV As DataGridView
	Friend WithEvents EditButton As Button
	Friend WithEvents DeleteButton As Button
	Friend WithEvents CreateButton As Button
End Class
