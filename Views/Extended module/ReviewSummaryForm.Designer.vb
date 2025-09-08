<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewSummaryForm
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
		Me.YearComboBox = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PeriodComboBox = New System.Windows.Forms.ComboBox()
		Me.Top3FLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(25, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Year"
		'
		'YearComboBox
		'
		Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.YearComboBox.FormattingEnabled = True
		Me.YearComboBox.Location = New System.Drawing.Point(62, 21)
		Me.YearComboBox.Name = "YearComboBox"
		Me.YearComboBox.Size = New System.Drawing.Size(106, 25)
		Me.YearComboBox.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(192, 23)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Period"
		'
		'PeriodComboBox
		'
		Me.PeriodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.PeriodComboBox.FormattingEnabled = True
		Me.PeriodComboBox.Location = New System.Drawing.Point(242, 21)
		Me.PeriodComboBox.Name = "PeriodComboBox"
		Me.PeriodComboBox.Size = New System.Drawing.Size(106, 25)
		Me.PeriodComboBox.TabIndex = 3
		'
		'Top3FLP
		'
		Me.Top3FLP.AutoScroll = True
		Me.Top3FLP.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Top3FLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Top3FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.Top3FLP.Location = New System.Drawing.Point(13, 104)
		Me.Top3FLP.Margin = New System.Windows.Forms.Padding(4)
		Me.Top3FLP.Name = "Top3FLP"
		Me.Top3FLP.Size = New System.Drawing.Size(335, 350)
		Me.Top3FLP.TabIndex = 4
		Me.Top3FLP.WrapContents = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(23, 59)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(197, 28)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "TOP 3 Staff by Score"
		'
		'ReviewSummaryForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(826, 470)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Top3FLP)
		Me.Controls.Add(Me.PeriodComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.YearComboBox)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "ReviewSummaryForm"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Review Summary"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents YearComboBox As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents PeriodComboBox As ComboBox
	Friend WithEvents Top3FLP As FlowLayoutPanel
	Friend WithEvents Label3 As Label
End Class
