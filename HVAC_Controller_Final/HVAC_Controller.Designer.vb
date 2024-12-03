<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVAC_Controller
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
        Me.HighTemp1Button = New System.Windows.Forms.Button()
        Me.HighTemp2Button = New System.Windows.Forms.Button()
        Me.CoolingTemp1Button = New System.Windows.Forms.Button()
        Me.CoolingTemp2Button = New System.Windows.Forms.Button()
        Me.HeaterSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.CoolingSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HighTemp1Button
        '
        Me.HighTemp1Button.Location = New System.Drawing.Point(290, 259)
        Me.HighTemp1Button.Name = "HighTemp1Button"
        Me.HighTemp1Button.Size = New System.Drawing.Size(94, 50)
        Me.HighTemp1Button.TabIndex = 0
        Me.HighTemp1Button.Text = "Heater Setpoint ^"
        Me.HighTemp1Button.UseVisualStyleBackColor = True
        '
        'HighTemp2Button
        '
        Me.HighTemp2Button.Location = New System.Drawing.Point(290, 315)
        Me.HighTemp2Button.Name = "HighTemp2Button"
        Me.HighTemp2Button.Size = New System.Drawing.Size(94, 50)
        Me.HighTemp2Button.TabIndex = 1
        Me.HighTemp2Button.Text = "Heater Setpoint -"
        Me.HighTemp2Button.UseVisualStyleBackColor = True
        '
        'CoolingTemp1Button
        '
        Me.CoolingTemp1Button.Location = New System.Drawing.Point(408, 259)
        Me.CoolingTemp1Button.Name = "CoolingTemp1Button"
        Me.CoolingTemp1Button.Size = New System.Drawing.Size(94, 50)
        Me.CoolingTemp1Button.TabIndex = 3
        Me.CoolingTemp1Button.Text = "Cooling Setpoint  ^"
        Me.CoolingTemp1Button.UseVisualStyleBackColor = True
        '
        'CoolingTemp2Button
        '
        Me.CoolingTemp2Button.Location = New System.Drawing.Point(408, 315)
        Me.CoolingTemp2Button.Name = "CoolingTemp2Button"
        Me.CoolingTemp2Button.Size = New System.Drawing.Size(94, 50)
        Me.CoolingTemp2Button.TabIndex = 2
        Me.CoolingTemp2Button.Text = "Cooling Setpoint -"
        Me.CoolingTemp2Button.UseVisualStyleBackColor = True
        '
        'HeaterSetpointTextBox
        '
        Me.HeaterSetpointTextBox.Enabled = False
        Me.HeaterSetpointTextBox.Location = New System.Drawing.Point(284, 231)
        Me.HeaterSetpointTextBox.Name = "HeaterSetpointTextBox"
        Me.HeaterSetpointTextBox.Size = New System.Drawing.Size(100, 22)
        Me.HeaterSetpointTextBox.TabIndex = 4
        '
        'CoolingSetpointTextBox
        '
        Me.CoolingSetpointTextBox.Enabled = False
        Me.CoolingSetpointTextBox.Location = New System.Drawing.Point(402, 231)
        Me.CoolingSetpointTextBox.Name = "CoolingSetpointTextBox"
        Me.CoolingSetpointTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CoolingSetpointTextBox.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(332, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 111)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'HVAC_Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CoolingSetpointTextBox)
        Me.Controls.Add(Me.HeaterSetpointTextBox)
        Me.Controls.Add(Me.CoolingTemp1Button)
        Me.Controls.Add(Me.CoolingTemp2Button)
        Me.Controls.Add(Me.HighTemp2Button)
        Me.Controls.Add(Me.HighTemp1Button)
        Me.Name = "HVAC_Controller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HighTemp1Button As Button
    Friend WithEvents HighTemp2Button As Button
    Friend WithEvents CoolingTemp1Button As Button
    Friend WithEvents CoolingTemp2Button As Button
    Friend WithEvents HeaterSetpointTextBox As TextBox
    Friend WithEvents CoolingSetpointTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
