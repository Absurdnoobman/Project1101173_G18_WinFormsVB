<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffReviewForm
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
		Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.SelectConsultantButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ScoreTextBox = New System.Windows.Forms.TextBox()
		Me.CommentsTextBox = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CreateButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'StaffFLP
		'
		Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.StaffFLP.Location = New System.Drawing.Point(12, 12)
		Me.StaffFLP.Name = "StaffFLP"
		Me.StaffFLP.Size = New System.Drawing.Size(557, 59)
		Me.StaffFLP.TabIndex = 0
		'
		'SelectConsultantButton
		'
		Me.SelectConsultantButton.Location = New System.Drawing.Point(575, 12)
		Me.SelectConsultantButton.Name = "SelectConsultantButton"
		Me.SelectConsultantButton.Size = New System.Drawing.Size(113, 59)
		Me.SelectConsultantButton.TabIndex = 3
		Me.SelectConsultantButton.Text = "Select a Staff"
		Me.SelectConsultantButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 88)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 17)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Period"
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Location = New System.Drawing.Point(309, 85)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(244, 25)
		Me.DateTimePicker2.TabIndex = 6
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Q1", "Q2", "Q3", "Q4"})
		Me.ComboBox1.Location = New System.Drawing.Point(64, 85)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(75, 25)
		Me.ComboBox1.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(220, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(83, 17)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Review Date "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 142)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(47, 20)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Score"
		'
		'ScoreTextBox
		'
		Me.ScoreTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ScoreTextBox.Location = New System.Drawing.Point(64, 142)
		Me.ScoreTextBox.Name = "ScoreTextBox"
		Me.ScoreTextBox.Size = New System.Drawing.Size(100, 27)
		Me.ScoreTextBox.TabIndex = 10
		'
		'CommentsTextBox
		'
		Me.CommentsTextBox.Location = New System.Drawing.Point(288, 141)
		Me.CommentsTextBox.Multiline = True
		Me.CommentsTextBox.Name = "CommentsTextBox"
		Me.CommentsTextBox.Size = New System.Drawing.Size(379, 89)
		Me.CommentsTextBox.TabIndex = 11
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(211, 145)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 17)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "Comments"
		'
		'CreateButton
		'
		Me.CreateButton.Location = New System.Drawing.Point(592, 253)
		Me.CreateButton.Name = "CreateButton"
		Me.CreateButton.Size = New System.Drawing.Size(75, 28)
		Me.CreateButton.TabIndex = 13
		Me.CreateButton.Text = "Create"
		Me.CreateButton.UseVisualStyleBackColor = True
		'
		'StaffReviewForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 293)
		Me.Controls.Add(Me.CreateButton)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.CommentsTextBox)
		Me.Controls.Add(Me.ScoreTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.DateTimePicker2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.SelectConsultantButton)
		Me.Controls.Add(Me.StaffFLP)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "StaffReviewForm"
		Me.Text = "Review a Staff"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents StaffFLP As FlowLayoutPanel
	Friend WithEvents SelectConsultantButton As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents ScoreTextBox As TextBox
	Friend WithEvents CommentsTextBox As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents CreateButton As Button
End Class
