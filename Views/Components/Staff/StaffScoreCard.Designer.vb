<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffScoreCard
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.StaffNumberLabel = New System.Windows.Forms.Label()
		Me.StaffNameLabel = New System.Windows.Forms.Label()
		Me.ScoreLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'StaffNumberLabel
		'
		Me.StaffNumberLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.StaffNumberLabel.AutoSize = True
		Me.StaffNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNumberLabel.Location = New System.Drawing.Point(22, 20)
		Me.StaffNumberLabel.Name = "StaffNumberLabel"
		Me.StaffNumberLabel.Size = New System.Drawing.Size(40, 23)
		Me.StaffNumberLabel.TabIndex = 0
		Me.StaffNumberLabel.Text = "S---"
		'
		'StaffNameLabel
		'
		Me.StaffNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.StaffNameLabel.AutoSize = True
		Me.StaffNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StaffNameLabel.Location = New System.Drawing.Point(68, 20)
		Me.StaffNameLabel.Name = "StaffNameLabel"
		Me.StaffNameLabel.Size = New System.Drawing.Size(131, 23)
		Me.StaffNameLabel.TabIndex = 1
		Me.StaffNameLabel.Text = "Name Fullname"
		'
		'ScoreLabel
		'
		Me.ScoreLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ScoreLabel.AutoSize = True
		Me.ScoreLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ScoreLabel.Location = New System.Drawing.Point(254, 20)
		Me.ScoreLabel.Name = "ScoreLabel"
		Me.ScoreLabel.Size = New System.Drawing.Size(37, 23)
		Me.ScoreLabel.TabIndex = 2
		Me.ScoreLabel.Text = "800"
		'
		'StaffScoreCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.ScoreLabel)
		Me.Controls.Add(Me.StaffNameLabel)
		Me.Controls.Add(Me.StaffNumberLabel)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "StaffScoreCard"
		Me.Size = New System.Drawing.Size(326, 64)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents StaffNumberLabel As Label
	Friend WithEvents StaffNameLabel As Label
	Friend WithEvents ScoreLabel As Label
End Class
