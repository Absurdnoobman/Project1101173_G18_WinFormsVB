<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierList
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(10, 45)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 51
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.Size = New System.Drawing.Size(679, 420)
		Me.DataGridView1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(10, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Label1"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(68, 14)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(262, 25)
		Me.TextBox1.TabIndex = 2
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Button1.Location = New System.Drawing.Point(594, 13)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(94, 23)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "Create"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'SupplierList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 478)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "SupplierList"
		Me.Text = "Supplier List"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button1 As Button
End Class
