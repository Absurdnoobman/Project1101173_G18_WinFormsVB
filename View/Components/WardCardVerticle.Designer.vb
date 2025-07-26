<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WardCardVerticle
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
        Me.WardTitleLabel = New System.Windows.Forms.Label()
        Me.WardNameLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WardTitleLabel
        '
        Me.WardTitleLabel.AutoSize = True
        Me.WardTitleLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WardTitleLabel.Location = New System.Drawing.Point(15, 12)
        Me.WardTitleLabel.Name = "WardTitleLabel"
        Me.WardTitleLabel.Size = New System.Drawing.Size(84, 28)
        Me.WardTitleLabel.TabIndex = 0
        Me.WardTitleLabel.Text = "Ward N"
        '
        'WardNameLabel
        '
        Me.WardNameLabel.AutoSize = True
        Me.WardNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WardNameLabel.Location = New System.Drawing.Point(15, 45)
        Me.WardNameLabel.Name = "WardNameLabel"
        Me.WardNameLabel.Size = New System.Drawing.Size(58, 23)
        Me.WardNameLabel.TabIndex = 1
        Me.WardNameLabel.Text = "NAME"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 89)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(268, 272)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Edit Ward Detail"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WardCardVerticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.WardNameLabel)
        Me.Controls.Add(Me.WardTitleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WardCardVerticle"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Size = New System.Drawing.Size(298, 415)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WardTitleLabel As Label
    Friend WithEvents WardNameLabel As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
