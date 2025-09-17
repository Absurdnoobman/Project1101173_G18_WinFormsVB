<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WardDetailForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.WardComboBox = New System.Windows.Forms.ComboBox()
		Me.NameLabel = New System.Windows.Forms.Label()
		Me.WeekLabel = New System.Windows.Forms.Label()
		Me.ChargeNurseLabel = New System.Windows.Forms.Label()
		Me.LocationLabel = New System.Windows.Forms.Label()
		Me.WorkInDGV = New System.Windows.Forms.DataGridView()
		Me.ExtNumberLabel = New System.Windows.Forms.Label()
		Me.WeekBeginingComboBox = New System.Windows.Forms.ComboBox()
		Me.EditAssignmentButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.AddFilterButton = New System.Windows.Forms.Button()
		Me.RecordCountLabel = New System.Windows.Forms.Label()
		Me.FilterFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.RefreshButton = New System.Windows.Forms.Button()
		Me.ApplyFilterButton = New System.Windows.Forms.Button()
		Me.RemoveRecordButton = New System.Windows.Forms.Button()
		CType(Me.WorkInDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(17, 18)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Ward"
		'
		'WardComboBox
		'
		Me.WardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WardComboBox.FormattingEnabled = True
		Me.WardComboBox.Location = New System.Drawing.Point(59, 15)
		Me.WardComboBox.Name = "WardComboBox"
		Me.WardComboBox.Size = New System.Drawing.Size(121, 25)
		Me.WardComboBox.TabIndex = 1
		'
		'NameLabel
		'
		Me.NameLabel.AutoSize = True
		Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NameLabel.Location = New System.Drawing.Point(267, 14)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(88, 23)
		Me.NameLabel.TabIndex = 2
		Me.NameLabel.Text = "Name: ---"
		'
		'WeekLabel
		'
		Me.WeekLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WeekLabel.AutoSize = True
		Me.WeekLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.WeekLabel.Location = New System.Drawing.Point(498, 18)
		Me.WeekLabel.Name = "WeekLabel"
		Me.WeekLabel.Size = New System.Drawing.Size(106, 17)
		Me.WeekLabel.TabIndex = 3
		Me.WeekLabel.Text = "Week begining: "
		'
		'ChargeNurseLabel
		'
		Me.ChargeNurseLabel.AutoSize = True
		Me.ChargeNurseLabel.Location = New System.Drawing.Point(20, 56)
		Me.ChargeNurseLabel.Name = "ChargeNurseLabel"
		Me.ChargeNurseLabel.Size = New System.Drawing.Size(111, 17)
		Me.ChargeNurseLabel.TabIndex = 4
		Me.ChargeNurseLabel.Text = "Charge Nurse: ---"
		'
		'LocationLabel
		'
		Me.LocationLabel.AutoSize = True
		Me.LocationLabel.Location = New System.Drawing.Point(268, 56)
		Me.LocationLabel.Name = "LocationLabel"
		Me.LocationLabel.Size = New System.Drawing.Size(79, 17)
		Me.LocationLabel.TabIndex = 5
		Me.LocationLabel.Text = "Location: ---"
		'
		'WorkInDGV
		'
		Me.WorkInDGV.AllowUserToAddRows = False
		Me.WorkInDGV.AllowUserToDeleteRows = False
		Me.WorkInDGV.AllowUserToOrderColumns = True
		Me.WorkInDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WorkInDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.WorkInDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.WorkInDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.WorkInDGV.Location = New System.Drawing.Point(16, 157)
		Me.WorkInDGV.MultiSelect = False
		Me.WorkInDGV.Name = "WorkInDGV"
		Me.WorkInDGV.ReadOnly = True
		Me.WorkInDGV.RowHeadersWidth = 51
		Me.WorkInDGV.RowTemplate.DefaultCellStyle.NullValue = "(none)"
		Me.WorkInDGV.RowTemplate.Height = 24
		Me.WorkInDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.WorkInDGV.Size = New System.Drawing.Size(736, 296)
		Me.WorkInDGV.TabIndex = 6
		'
		'ExtNumberLabel
		'
		Me.ExtNumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ExtNumberLabel.AutoSize = True
		Me.ExtNumberLabel.Location = New System.Drawing.Point(498, 56)
		Me.ExtNumberLabel.Name = "ExtNumberLabel"
		Me.ExtNumberLabel.Size = New System.Drawing.Size(136, 17)
		Me.ExtNumberLabel.TabIndex = 7
		Me.ExtNumberLabel.Text = "Extended Number: ---"
		'
		'WeekBeginingComboBox
		'
		Me.WeekBeginingComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WeekBeginingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WeekBeginingComboBox.FormattingEnabled = True
		Me.WeekBeginingComboBox.Location = New System.Drawing.Point(610, 15)
		Me.WeekBeginingComboBox.Name = "WeekBeginingComboBox"
		Me.WeekBeginingComboBox.Size = New System.Drawing.Size(142, 25)
		Me.WeekBeginingComboBox.TabIndex = 8
		'
		'EditAssignmentButton
		'
		Me.EditAssignmentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.EditAssignmentButton.Location = New System.Drawing.Point(610, 459)
		Me.EditAssignmentButton.Name = "EditAssignmentButton"
		Me.EditAssignmentButton.Size = New System.Drawing.Size(142, 32)
		Me.EditAssignmentButton.TabIndex = 9
		Me.EditAssignmentButton.Text = "Edit Assignment"
		Me.EditAssignmentButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(20, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(38, 17)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Filter"
		'
		'AddFilterButton
		'
		Me.AddFilterButton.Enabled = False
		Me.AddFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.AddFilterButton.Location = New System.Drawing.Point(16, 121)
		Me.AddFilterButton.Name = "AddFilterButton"
		Me.AddFilterButton.Size = New System.Drawing.Size(75, 23)
		Me.AddFilterButton.TabIndex = 12
		Me.AddFilterButton.Text = "add"
		Me.AddFilterButton.UseVisualStyleBackColor = True
		'
		'RecordCountLabel
		'
		Me.RecordCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.RecordCountLabel.AutoSize = True
		Me.RecordCountLabel.Location = New System.Drawing.Point(13, 467)
		Me.RecordCountLabel.Name = "RecordCountLabel"
		Me.RecordCountLabel.Size = New System.Drawing.Size(75, 17)
		Me.RecordCountLabel.TabIndex = 13
		Me.RecordCountLabel.Text = "Records ---"
		'
		'FilterFLP
		'
		Me.FilterFLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FilterFLP.AutoScroll = True
		Me.FilterFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FilterFLP.Location = New System.Drawing.Point(97, 88)
		Me.FilterFLP.Name = "FilterFLP"
		Me.FilterFLP.Padding = New System.Windows.Forms.Padding(3)
		Me.FilterFLP.Size = New System.Drawing.Size(541, 63)
		Me.FilterFLP.TabIndex = 16
		Me.FilterFLP.WrapContents = False
		'
		'RefreshButton
		'
		Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RefreshButton.Enabled = False
		Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.RefreshButton.Location = New System.Drawing.Point(644, 120)
		Me.RefreshButton.Name = "RefreshButton"
		Me.RefreshButton.Size = New System.Drawing.Size(108, 31)
		Me.RefreshButton.TabIndex = 19
		Me.RefreshButton.Text = "Refresh"
		Me.RefreshButton.UseVisualStyleBackColor = True
		'
		'ApplyFilterButton
		'
		Me.ApplyFilterButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ApplyFilterButton.Enabled = False
		Me.ApplyFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.ApplyFilterButton.Location = New System.Drawing.Point(644, 88)
		Me.ApplyFilterButton.Name = "ApplyFilterButton"
		Me.ApplyFilterButton.Size = New System.Drawing.Size(108, 31)
		Me.ApplyFilterButton.TabIndex = 18
		Me.ApplyFilterButton.Text = "Apply"
		Me.ApplyFilterButton.UseVisualStyleBackColor = True
		'
		'RemoveRecordButton
		'
		Me.RemoveRecordButton.Location = New System.Drawing.Point(501, 459)
		Me.RemoveRecordButton.Name = "RemoveRecordButton"
		Me.RemoveRecordButton.Size = New System.Drawing.Size(102, 32)
		Me.RemoveRecordButton.TabIndex = 20
		Me.RemoveRecordButton.Text = "Delete Record"
		Me.RemoveRecordButton.UseVisualStyleBackColor = True
		'
		'WardDetailForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(767, 506)
		Me.Controls.Add(Me.RemoveRecordButton)
		Me.Controls.Add(Me.RefreshButton)
		Me.Controls.Add(Me.ApplyFilterButton)
		Me.Controls.Add(Me.FilterFLP)
		Me.Controls.Add(Me.RecordCountLabel)
		Me.Controls.Add(Me.AddFilterButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.EditAssignmentButton)
		Me.Controls.Add(Me.WeekBeginingComboBox)
		Me.Controls.Add(Me.ExtNumberLabel)
		Me.Controls.Add(Me.WorkInDGV)
		Me.Controls.Add(Me.LocationLabel)
		Me.Controls.Add(Me.ChargeNurseLabel)
		Me.Controls.Add(Me.WeekLabel)
		Me.Controls.Add(Me.NameLabel)
		Me.Controls.Add(Me.WardComboBox)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "WardDetailForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Ward Details"
		CType(Me.WorkInDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents WardComboBox As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents WeekLabel As Label
    Friend WithEvents ChargeNurseLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents WorkInDGV As DataGridView
    Friend WithEvents ExtNumberLabel As Label
    Friend WithEvents WeekBeginingComboBox As ComboBox
    Friend WithEvents EditAssignmentButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents AddFilterButton As Button
	Friend WithEvents RecordCountLabel As Label
	Friend WithEvents FilterFLP As FlowLayoutPanel
	Friend WithEvents RefreshButton As Button
	Friend WithEvents ApplyFilterButton As Button
	Friend WithEvents RemoveRecordButton As Button
End Class
