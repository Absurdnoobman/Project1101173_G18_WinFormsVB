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
		Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
		Me.ExtNumberLabel = New System.Windows.Forms.Label()
		Me.WeekBeginingComboBox = New System.Windows.Forms.ComboBox()
		Me.EditAssignmentButton = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.RecordCountLabel = New System.Windows.Forms.Label()
		CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.NameLabel.Location = New System.Drawing.Point(232, 14)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(88, 23)
		Me.NameLabel.TabIndex = 2
		Me.NameLabel.Text = "Name: ---"
		'
		'WeekLabel
		'
		Me.WeekLabel.AutoSize = True
		Me.WeekLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.WeekLabel.Location = New System.Drawing.Point(431, 18)
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
		Me.LocationLabel.Location = New System.Drawing.Point(233, 56)
		Me.LocationLabel.Name = "LocationLabel"
		Me.LocationLabel.Size = New System.Drawing.Size(79, 17)
		Me.LocationLabel.TabIndex = 5
		Me.LocationLabel.Text = "Location: ---"
		'
		'StaffDataGridView
		'
		Me.StaffDataGridView.AllowUserToAddRows = False
		Me.StaffDataGridView.AllowUserToDeleteRows = False
		Me.StaffDataGridView.AllowUserToOrderColumns = True
		Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.StaffDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.StaffDataGridView.Location = New System.Drawing.Point(16, 150)
		Me.StaffDataGridView.Name = "StaffDataGridView"
		Me.StaffDataGridView.ReadOnly = True
		Me.StaffDataGridView.RowHeadersWidth = 51
		Me.StaffDataGridView.RowTemplate.DefaultCellStyle.NullValue = "(none)"
		Me.StaffDataGridView.RowTemplate.Height = 24
		Me.StaffDataGridView.Size = New System.Drawing.Size(669, 275)
		Me.StaffDataGridView.TabIndex = 6
		'
		'ExtNumberLabel
		'
		Me.ExtNumberLabel.AutoSize = True
		Me.ExtNumberLabel.Location = New System.Drawing.Point(431, 56)
		Me.ExtNumberLabel.Name = "ExtNumberLabel"
		Me.ExtNumberLabel.Size = New System.Drawing.Size(136, 17)
		Me.ExtNumberLabel.TabIndex = 7
		Me.ExtNumberLabel.Text = "Extended Number: ---"
		'
		'WeekBeginingComboBox
		'
		Me.WeekBeginingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.WeekBeginingComboBox.FormattingEnabled = True
		Me.WeekBeginingComboBox.Location = New System.Drawing.Point(543, 15)
		Me.WeekBeginingComboBox.Name = "WeekBeginingComboBox"
		Me.WeekBeginingComboBox.Size = New System.Drawing.Size(142, 25)
		Me.WeekBeginingComboBox.TabIndex = 8
		'
		'EditAssignmentButton
		'
		Me.EditAssignmentButton.Location = New System.Drawing.Point(543, 431)
		Me.EditAssignmentButton.Name = "EditAssignmentButton"
		Me.EditAssignmentButton.Size = New System.Drawing.Size(142, 32)
		Me.EditAssignmentButton.TabIndex = 9
		Me.EditAssignmentButton.Text = "Edit Assignment"
		Me.EditAssignmentButton.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(101, 88)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(584, 56)
		Me.FlowLayoutPanel1.TabIndex = 10
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
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Button1.Location = New System.Drawing.Point(20, 109)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 12
		Me.Button1.Text = "add"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'RecordCountLabel
		'
		Me.RecordCountLabel.AutoSize = True
		Me.RecordCountLabel.Location = New System.Drawing.Point(16, 431)
		Me.RecordCountLabel.Name = "RecordCountLabel"
		Me.RecordCountLabel.Size = New System.Drawing.Size(75, 17)
		Me.RecordCountLabel.TabIndex = 13
		Me.RecordCountLabel.Text = "Records ---"
		'
		'WardDetailForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(700, 478)
		Me.Controls.Add(Me.RecordCountLabel)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.EditAssignmentButton)
		Me.Controls.Add(Me.WeekBeginingComboBox)
		Me.Controls.Add(Me.ExtNumberLabel)
		Me.Controls.Add(Me.StaffDataGridView)
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
		CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents WardComboBox As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents WeekLabel As Label
    Friend WithEvents ChargeNurseLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents ExtNumberLabel As Label
    Friend WithEvents WeekBeginingComboBox As ComboBox
    Friend WithEvents EditAssignmentButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RecordCountLabel As Label
End Class
