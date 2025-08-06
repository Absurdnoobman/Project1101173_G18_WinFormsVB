<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentList
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.SearchTextBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.AddFilterButton = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.FilterFLP = New System.Windows.Forms.FlowLayoutPanel()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(9, 118)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersWidth = 51
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.Size = New System.Drawing.Size(682, 351)
		Me.DataGridView1.TabIndex = 0
		'
		'SearchTextBox
		'
		Me.SearchTextBox.Location = New System.Drawing.Point(169, 15)
		Me.SearchTextBox.Name = "SearchTextBox"
		Me.SearchTextBox.Size = New System.Drawing.Size(264, 25)
		Me.SearchTextBox.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(9, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(154, 17)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Search by patient's name"
		'
		'AddFilterButton
		'
		Me.AddFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.AddFilterButton.Location = New System.Drawing.Point(11, 72)
		Me.AddFilterButton.Name = "AddFilterButton"
		Me.AddFilterButton.Size = New System.Drawing.Size(75, 23)
		Me.AddFilterButton.TabIndex = 19
		Me.AddFilterButton.Text = "Add"
		Me.AddFilterButton.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(11, 49)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 20)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "filter"
		'
		'FilterFLP
		'
		Me.FilterFLP.AutoScroll = True
		Me.FilterFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FilterFLP.Location = New System.Drawing.Point(92, 49)
		Me.FilterFLP.Name = "FilterFLP"
		Me.FilterFLP.Padding = New System.Windows.Forms.Padding(3)
		Me.FilterFLP.Size = New System.Drawing.Size(599, 63)
		Me.FilterFLP.TabIndex = 17
		Me.FilterFLP.WrapContents = False
		'
		'AppointmentList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 478)
		Me.Controls.Add(Me.AddFilterButton)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.FilterFLP)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.SearchTextBox)
		Me.Controls.Add(Me.DataGridView1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "AppointmentList"
		Me.Padding = New System.Windows.Forms.Padding(6)
		Me.Text = "Appointments"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents SearchTextBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents AddFilterButton As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents FilterFLP As FlowLayoutPanel
End Class
