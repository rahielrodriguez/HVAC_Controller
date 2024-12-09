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
        Me.components = New System.ComponentModel.Container()
        Me.HighTemp1Button = New System.Windows.Forms.Button()
        Me.HighTemp2Button = New System.Windows.Forms.Button()
        Me.CoolingTemp1Button = New System.Windows.Forms.Button()
        Me.CoolingTemp2Button = New System.Windows.Forms.Button()
        Me.HeaterSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.CoolingSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.AlertPictureBox = New System.Windows.Forms.PictureBox()
        Me.QYBoardSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.RoomTempLabel = New System.Windows.Forms.Label()
        Me.SystemTempLabel = New System.Windows.Forms.Label()
        Me.TempTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HeaterRadioButton = New System.Windows.Forms.RadioButton()
        Me.ACRadioButton = New System.Windows.Forms.RadioButton()
        Me.OffRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HVACPictureBox = New System.Windows.Forms.PictureBox()
        Me.FanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FanPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.AlertPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HVACPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'AlertPictureBox
        '
        Me.AlertPictureBox.BackColor = System.Drawing.Color.Silver
        Me.AlertPictureBox.Location = New System.Drawing.Point(12, 42)
        Me.AlertPictureBox.Name = "AlertPictureBox"
        Me.AlertPictureBox.Size = New System.Drawing.Size(29, 26)
        Me.AlertPictureBox.TabIndex = 6
        Me.AlertPictureBox.TabStop = False
        '
        'PortsComboBox
        '
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(12, 12)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(166, 24)
        Me.PortsComboBox.TabIndex = 7
        '
        'ComButton
        '
        Me.ComButton.Location = New System.Drawing.Point(662, 369)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(126, 69)
        Me.ComButton.TabIndex = 8
        Me.ComButton.Text = "Com"
        Me.ComButton.UseVisualStyleBackColor = True
        '
        'ClockTimer
        '
        Me.ClockTimer.Interval = 1000
        '
        'ClockLabel
        '
        Me.ClockLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockLabel.AutoSize = True
        Me.ClockLabel.Location = New System.Drawing.Point(737, 9)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(41, 16)
        Me.ClockLabel.TabIndex = 9
        Me.ClockLabel.Text = "Clock"
        '
        'RoomTempLabel
        '
        Me.RoomTempLabel.AutoSize = True
        Me.RoomTempLabel.Location = New System.Drawing.Point(681, 157)
        Me.RoomTempLabel.Name = "RoomTempLabel"
        Me.RoomTempLabel.Size = New System.Drawing.Size(83, 16)
        Me.RoomTempLabel.TabIndex = 10
        Me.RoomTempLabel.Text = "Room Temp"
        '
        'SystemTempLabel
        '
        Me.SystemTempLabel.AutoSize = True
        Me.SystemTempLabel.Location = New System.Drawing.Point(681, 179)
        Me.SystemTempLabel.Name = "SystemTempLabel"
        Me.SystemTempLabel.Size = New System.Drawing.Size(91, 16)
        Me.SystemTempLabel.TabIndex = 11
        Me.SystemTempLabel.Text = "System Temp"
        '
        'TempTimer
        '
        Me.TempTimer.Interval = 50
        '
        'HeaterRadioButton
        '
        Me.HeaterRadioButton.AutoSize = True
        Me.HeaterRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.HeaterRadioButton.Name = "HeaterRadioButton"
        Me.HeaterRadioButton.Size = New System.Drawing.Size(69, 20)
        Me.HeaterRadioButton.TabIndex = 12
        Me.HeaterRadioButton.Text = "Heater"
        Me.HeaterRadioButton.UseVisualStyleBackColor = True
        '
        'ACRadioButton
        '
        Me.ACRadioButton.AutoSize = True
        Me.ACRadioButton.Location = New System.Drawing.Point(6, 47)
        Me.ACRadioButton.Name = "ACRadioButton"
        Me.ACRadioButton.Size = New System.Drawing.Size(50, 20)
        Me.ACRadioButton.TabIndex = 13
        Me.ACRadioButton.Text = "A/C"
        Me.ACRadioButton.UseVisualStyleBackColor = True
        '
        'OffRadioButton
        '
        Me.OffRadioButton.AutoSize = True
        Me.OffRadioButton.Checked = True
        Me.OffRadioButton.Location = New System.Drawing.Point(6, 73)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(44, 20)
        Me.OffRadioButton.TabIndex = 14
        Me.OffRadioButton.TabStop = True
        Me.OffRadioButton.Text = "Off"
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OffRadioButton)
        Me.GroupBox1.Controls.Add(Me.ACRadioButton)
        Me.GroupBox1.Controls.Add(Me.HeaterRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 104)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'HVACPictureBox
        '
        Me.HVACPictureBox.BackColor = System.Drawing.Color.Silver
        Me.HVACPictureBox.Location = New System.Drawing.Point(335, 88)
        Me.HVACPictureBox.Name = "HVACPictureBox"
        Me.HVACPictureBox.Size = New System.Drawing.Size(117, 107)
        Me.HVACPictureBox.TabIndex = 16
        Me.HVACPictureBox.TabStop = False
        '
        'FanTimer
        '
        Me.FanTimer.Interval = 5000
        '
        'FanPictureBox
        '
        Me.FanPictureBox.BackColor = System.Drawing.Color.Silver
        Me.FanPictureBox.Location = New System.Drawing.Point(458, 169)
        Me.FanPictureBox.Name = "FanPictureBox"
        Me.FanPictureBox.Size = New System.Drawing.Size(29, 26)
        Me.FanPictureBox.TabIndex = 17
        Me.FanPictureBox.TabStop = False
        '
        'HVAC_Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 447)
        Me.Controls.Add(Me.FanPictureBox)
        Me.Controls.Add(Me.HVACPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SystemTempLabel)
        Me.Controls.Add(Me.RoomTempLabel)
        Me.Controls.Add(Me.ClockLabel)
        Me.Controls.Add(Me.ComButton)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.AlertPictureBox)
        Me.Controls.Add(Me.CoolingSetpointTextBox)
        Me.Controls.Add(Me.HeaterSetpointTextBox)
        Me.Controls.Add(Me.CoolingTemp1Button)
        Me.Controls.Add(Me.CoolingTemp2Button)
        Me.Controls.Add(Me.HighTemp2Button)
        Me.Controls.Add(Me.HighTemp1Button)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "HVAC_Controller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.AlertPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.HVACPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HighTemp1Button As Button
    Friend WithEvents HighTemp2Button As Button
    Friend WithEvents CoolingTemp1Button As Button
    Friend WithEvents CoolingTemp2Button As Button
    Friend WithEvents HeaterSetpointTextBox As TextBox
    Friend WithEvents CoolingSetpointTextBox As TextBox
    Friend WithEvents AlertPictureBox As PictureBox
    Friend WithEvents QYBoardSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents ComButton As Button
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents ClockLabel As Label
    Friend WithEvents RoomTempLabel As Label
    Friend WithEvents SystemTempLabel As Label
    Friend WithEvents TempTimer As Timer
    Friend WithEvents HeaterRadioButton As RadioButton
    Friend WithEvents ACRadioButton As RadioButton
    Friend WithEvents OffRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HVACPictureBox As PictureBox
    Friend WithEvents FanTimer As Timer
    Friend WithEvents FanPictureBox As PictureBox
End Class
