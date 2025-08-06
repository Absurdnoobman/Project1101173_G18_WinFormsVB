<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffList
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffList))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SearchTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.StaffFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.OrderByComboBox = New System.Windows.Forms.ComboBox()
		Me.FilterFLP = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.AddFilterButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 38)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Staff List"
		'
		'SearchTextBox
		'
		Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.SearchTextBox.Location = New System.Drawing.Point(69, 60)
		Me.SearchTextBox.MinimumSize = New System.Drawing.Size(150, 25)
		Me.SearchTextBox.Name = "SearchTextBox"
		Me.SearchTextBox.Size = New System.Drawing.Size(254, 25)
		Me.SearchTextBox.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(16, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(47, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Search"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(628, 24)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(144, 26)
		Me.Button1.TabIndex = 6
		Me.Button1.Text = "Create Staff Record"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ComboBox1
		'
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(406, 60)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
		Me.ComboBox1.TabIndex = 9
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(336, 63)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 17)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Search By"
		'
		'StaffFLP
		'
		Me.StaffFLP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.StaffFLP.AutoScroll = True
		Me.StaffFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.StaffFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.StaffFLP.Location = New System.Drawing.Point(12, 168)
		Me.StaffFLP.Name = "StaffFLP"
		Me.StaffFLP.Padding = New System.Windows.Forms.Padding(2)
		Me.StaffFLP.Size = New System.Drawing.Size(760, 369)
		Me.StaffFLP.TabIndex = 11
		Me.StaffFLP.WrapContents = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(544, 63)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "Order By"
		'
		'OrderByComboBox
		'
		Me.OrderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.OrderByComboBox.FormattingEnabled = True
		Me.OrderByComboBox.Location = New System.Drawing.Point(610, 60)
		Me.OrderByComboBox.Name = "OrderByComboBox"
		Me.OrderByComboBox.Size = New System.Drawing.Size(121, 25)
		Me.OrderByComboBox.TabIndex = 13
		'
		'FilterFLP
		'
		Me.FilterFLP.AutoScroll = True
		Me.FilterFLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.FilterFLP.Location = New System.Drawing.Point(93, 99)
		Me.FilterFLP.Name = "FilterFLP"
		Me.FilterFLP.Padding = New System.Windows.Forms.Padding(3)
		Me.FilterFLP.Size = New System.Drawing.Size(679, 63)
		Me.FilterFLP.TabIndex = 14
		Me.FilterFLP.WrapContents = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(12, 99)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 20)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "filter"
		'
		'AddFilterButton
		'
		Me.AddFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.AddFilterButton.Location = New System.Drawing.Point(12, 122)
		Me.AddFilterButton.Name = "AddFilterButton"
		Me.AddFilterButton.Size = New System.Drawing.Size(75, 23)
		Me.AddFilterButton.TabIndex = 16
		Me.AddFilterButton.Text = "Add"
		Me.AddFilterButton.UseVisualStyleBackColor = True
		'
		'StaffList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(787, 549)
		Me.Controls.Add(Me.AddFilterButton)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.FilterFLP)
		Me.Controls.Add(Me.OrderByComboBox)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.StaffFLP)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.SearchTextBox)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(805, 596)
		Me.Name = "StaffList"
		Me.Text = "Staff List"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffFLP As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents OrderByComboBox As ComboBox
    Friend WithEvents FilterFLP As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents AddFilterButton As Button
End Class
