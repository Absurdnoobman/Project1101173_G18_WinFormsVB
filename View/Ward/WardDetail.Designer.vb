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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.WeekLabel = New System.Windows.Forms.Label()
        Me.ChargeNurseLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ExtNumberLabel = New System.Windows.Forms.Label()
        Me.WeekBeginingComboBox = New System.Windows.Forms.ComboBox()
        Me.EditAssignmentButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(59, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(232, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(88, 23)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name: ---"
        '
        'WeekLabel
        '
        Me.WeekLabel.AutoSize = True
        Me.WeekLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekLabel.Location = New System.Drawing.Point(431, 22)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(669, 310)
        Me.DataGridView1.TabIndex = 6
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
        Me.WeekBeginingComboBox.Location = New System.Drawing.Point(543, 19)
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
        'WardDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 478)
        Me.Controls.Add(Me.EditAssignmentButton)
        Me.Controls.Add(Me.WeekBeginingComboBox)
        Me.Controls.Add(Me.ExtNumberLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.ChargeNurseLabel)
        Me.Controls.Add(Me.WeekLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "WardDetailForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Text = "Ward Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents WeekLabel As Label
    Friend WithEvents ChargeNurseLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExtNumberLabel As Label
    Friend WithEvents WeekBeginingComboBox As ComboBox
    Friend WithEvents EditAssignmentButton As Button
End Class
