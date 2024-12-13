<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HVAC_Controller
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
        Me.components = New System.ComponentModel.Container()
        Me.HeaterSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.CoolingSetpointTextBox = New System.Windows.Forms.TextBox()
        Me.QYBoardSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.SystemTempLabel = New System.Windows.Forms.Label()
        Me.TempTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HeaterRadioButton = New System.Windows.Forms.RadioButton()
        Me.ACRadioButton = New System.Windows.Forms.RadioButton()
        Me.OffRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HeaterButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.HeaterUpPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeaterDownPictureBox = New System.Windows.Forms.PictureBox()
        Me.ACButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ACUpPictureBox = New System.Windows.Forms.PictureBox()
        Me.ACDownPictureBox = New System.Windows.Forms.PictureBox()
        Me.RoomTempLabel = New System.Windows.Forms.Label()
        Me.HeaterSetpointLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PressureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.FanPictureBox = New System.Windows.Forms.PictureBox()
        Me.ACPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeaterPictureBox = New System.Windows.Forms.PictureBox()
        Me.AlertPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.HeaterButtonsGroupBox.SuspendLayout()
        CType(Me.HeaterUpPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaterDownPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ACButtonsGroupBox.SuspendLayout()
        CType(Me.ACUpPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACDownPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlertPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaterSetpointTextBox
        '
        Me.HeaterSetpointTextBox.Enabled = False
        Me.HeaterSetpointTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaterSetpointTextBox.Location = New System.Drawing.Point(17, 47)
        Me.HeaterSetpointTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterSetpointTextBox.Name = "HeaterSetpointTextBox"
        Me.HeaterSetpointTextBox.Size = New System.Drawing.Size(100, 34)
        Me.HeaterSetpointTextBox.TabIndex = 4
        Me.HeaterSetpointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CoolingSetpointTextBox
        '
        Me.CoolingSetpointTextBox.Enabled = False
        Me.CoolingSetpointTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolingSetpointTextBox.Location = New System.Drawing.Point(14, 49)
        Me.CoolingSetpointTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CoolingSetpointTextBox.Name = "CoolingSetpointTextBox"
        Me.CoolingSetpointTextBox.Size = New System.Drawing.Size(100, 34)
        Me.CoolingSetpointTextBox.TabIndex = 5
        Me.CoolingSetpointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PortsComboBox
        '
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(12, 12)
        Me.PortsComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(167, 24)
        Me.PortsComboBox.TabIndex = 7
        '
        'ComButton
        '
        Me.ComButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComButton.ForeColor = System.Drawing.Color.Black
        Me.ComButton.Location = New System.Drawing.Point(457, 12)
        Me.ComButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(125, 69)
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
        Me.ClockLabel.AutoSize = True
        Me.ClockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockLabel.Location = New System.Drawing.Point(74, 67)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(62, 25)
        Me.ClockLabel.TabIndex = 9
        Me.ClockLabel.Text = "Clock"
        '
        'SystemTempLabel
        '
        Me.SystemTempLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SystemTempLabel.AutoSize = True
        Me.SystemTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTempLabel.Location = New System.Drawing.Point(26, 35)
        Me.SystemTempLabel.Name = "SystemTempLabel"
        Me.SystemTempLabel.Size = New System.Drawing.Size(115, 46)
        Me.SystemTempLabel.TabIndex = 11
        Me.SystemTempLabel.Text = "00 °F"
        '
        'TempTimer
        '
        Me.TempTimer.Interval = 50
        '
        'HeaterRadioButton
        '
        Me.HeaterRadioButton.AutoSize = True
        Me.HeaterRadioButton.Location = New System.Drawing.Point(5, 21)
        Me.HeaterRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterRadioButton.Name = "HeaterRadioButton"
        Me.HeaterRadioButton.Size = New System.Drawing.Size(69, 20)
        Me.HeaterRadioButton.TabIndex = 12
        Me.HeaterRadioButton.Text = "Heater"
        Me.HeaterRadioButton.UseVisualStyleBackColor = True
        '
        'ACRadioButton
        '
        Me.ACRadioButton.AutoSize = True
        Me.ACRadioButton.Location = New System.Drawing.Point(5, 47)
        Me.ACRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.OffRadioButton.Location = New System.Drawing.Point(5, 73)
        Me.OffRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(44, 20)
        Me.OffRadioButton.TabIndex = 14
        Me.OffRadioButton.TabStop = True
        Me.OffRadioButton.Text = "Off"
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.OffRadioButton)
        Me.GroupBox1.Controls.Add(Me.ACRadioButton)
        Me.GroupBox1.Controls.Add(Me.HeaterRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(84, 103)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'FanTimer
        '
        Me.FanTimer.Interval = 5000
        '
        'DrawTimer
        '
        '
        'HeaterButtonsGroupBox
        '
        Me.HeaterButtonsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaterButtonsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.HeaterButtonsGroupBox.Controls.Add(Me.HeaterUpPictureBox)
        Me.HeaterButtonsGroupBox.Controls.Add(Me.HeaterDownPictureBox)
        Me.HeaterButtonsGroupBox.Controls.Add(Me.HeaterSetpointTextBox)
        Me.HeaterButtonsGroupBox.ForeColor = System.Drawing.Color.Black
        Me.HeaterButtonsGroupBox.Location = New System.Drawing.Point(325, 108)
        Me.HeaterButtonsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterButtonsGroupBox.Name = "HeaterButtonsGroupBox"
        Me.HeaterButtonsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterButtonsGroupBox.Size = New System.Drawing.Size(132, 214)
        Me.HeaterButtonsGroupBox.TabIndex = 23
        Me.HeaterButtonsGroupBox.TabStop = False
        Me.HeaterButtonsGroupBox.Text = "Heater Setpoint Control"
        '
        'HeaterUpPictureBox
        '
        Me.HeaterUpPictureBox.Location = New System.Drawing.Point(40, 89)
        Me.HeaterUpPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterUpPictureBox.Name = "HeaterUpPictureBox"
        Me.HeaterUpPictureBox.Size = New System.Drawing.Size(51, 50)
        Me.HeaterUpPictureBox.TabIndex = 18
        Me.HeaterUpPictureBox.TabStop = False
        '
        'HeaterDownPictureBox
        '
        Me.HeaterDownPictureBox.Location = New System.Drawing.Point(40, 144)
        Me.HeaterDownPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterDownPictureBox.Name = "HeaterDownPictureBox"
        Me.HeaterDownPictureBox.Size = New System.Drawing.Size(51, 50)
        Me.HeaterDownPictureBox.TabIndex = 20
        Me.HeaterDownPictureBox.TabStop = False
        '
        'ACButtonsGroupBox
        '
        Me.ACButtonsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ACButtonsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ACButtonsGroupBox.Controls.Add(Me.ACUpPictureBox)
        Me.ACButtonsGroupBox.Controls.Add(Me.ACDownPictureBox)
        Me.ACButtonsGroupBox.Controls.Add(Me.CoolingSetpointTextBox)
        Me.ACButtonsGroupBox.ForeColor = System.Drawing.Color.Black
        Me.ACButtonsGroupBox.Location = New System.Drawing.Point(462, 108)
        Me.ACButtonsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ACButtonsGroupBox.Name = "ACButtonsGroupBox"
        Me.ACButtonsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ACButtonsGroupBox.Size = New System.Drawing.Size(120, 214)
        Me.ACButtonsGroupBox.TabIndex = 24
        Me.ACButtonsGroupBox.TabStop = False
        Me.ACButtonsGroupBox.Text = "A/C Setpoint Control"
        '
        'ACUpPictureBox
        '
        Me.ACUpPictureBox.Location = New System.Drawing.Point(36, 87)
        Me.ACUpPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ACUpPictureBox.Name = "ACUpPictureBox"
        Me.ACUpPictureBox.Size = New System.Drawing.Size(51, 50)
        Me.ACUpPictureBox.TabIndex = 21
        Me.ACUpPictureBox.TabStop = False
        '
        'ACDownPictureBox
        '
        Me.ACDownPictureBox.Location = New System.Drawing.Point(36, 144)
        Me.ACDownPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ACDownPictureBox.Name = "ACDownPictureBox"
        Me.ACDownPictureBox.Size = New System.Drawing.Size(51, 50)
        Me.ACDownPictureBox.TabIndex = 22
        Me.ACDownPictureBox.TabStop = False
        '
        'RoomTempLabel
        '
        Me.RoomTempLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RoomTempLabel.AutoSize = True
        Me.RoomTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTempLabel.Location = New System.Drawing.Point(26, 35)
        Me.RoomTempLabel.Name = "RoomTempLabel"
        Me.RoomTempLabel.Size = New System.Drawing.Size(115, 46)
        Me.RoomTempLabel.TabIndex = 10
        Me.RoomTempLabel.Text = "00 °F"
        '
        'HeaterSetpointLabel
        '
        Me.HeaterSetpointLabel.AutoSize = True
        Me.HeaterSetpointLabel.Location = New System.Drawing.Point(314, 152)
        Me.HeaterSetpointLabel.Name = "HeaterSetpointLabel"
        Me.HeaterSetpointLabel.Size = New System.Drawing.Size(0, 16)
        Me.HeaterSetpointLabel.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.SystemTempLabel)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(147, 84)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System Temperature"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RoomTempLabel)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(164, 108)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(147, 83)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Room Temperature"
        '
        'PressureTimer
        '
        Me.PressureTimer.Interval = 10000
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(326, 14)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(125, 69)
        Me.SaveButton.TabIndex = 33
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Location = New System.Drawing.Point(238, 14)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(73, 69)
        Me.LogoPictureBox.TabIndex = 34
        Me.LogoPictureBox.TabStop = False
        '
        'FanPictureBox
        '
        Me.FanPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FanPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.FanPictureBox.Location = New System.Drawing.Point(250, 242)
        Me.FanPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FanPictureBox.Name = "FanPictureBox"
        Me.FanPictureBox.Size = New System.Drawing.Size(69, 70)
        Me.FanPictureBox.TabIndex = 26
        Me.FanPictureBox.TabStop = False
        '
        'ACPictureBox
        '
        Me.ACPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ACPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ACPictureBox.Location = New System.Drawing.Point(175, 242)
        Me.ACPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ACPictureBox.Name = "ACPictureBox"
        Me.ACPictureBox.Size = New System.Drawing.Size(69, 70)
        Me.ACPictureBox.TabIndex = 25
        Me.ACPictureBox.TabStop = False
        '
        'HeaterPictureBox
        '
        Me.HeaterPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.HeaterPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.HeaterPictureBox.Location = New System.Drawing.Point(100, 242)
        Me.HeaterPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeaterPictureBox.Name = "HeaterPictureBox"
        Me.HeaterPictureBox.Size = New System.Drawing.Size(69, 70)
        Me.HeaterPictureBox.TabIndex = 16
        Me.HeaterPictureBox.TabStop = False
        '
        'AlertPictureBox
        '
        Me.AlertPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.AlertPictureBox.Location = New System.Drawing.Point(12, 52)
        Me.AlertPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlertPictureBox.Name = "AlertPictureBox"
        Me.AlertPictureBox.Size = New System.Drawing.Size(56, 52)
        Me.AlertPictureBox.TabIndex = 6
        Me.AlertPictureBox.TabStop = False
        '
        'HVAC_Controller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 336)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.HeaterSetpointLabel)
        Me.Controls.Add(Me.FanPictureBox)
        Me.Controls.Add(Me.ACPictureBox)
        Me.Controls.Add(Me.ACButtonsGroupBox)
        Me.Controls.Add(Me.HeaterButtonsGroupBox)
        Me.Controls.Add(Me.HeaterPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClockLabel)
        Me.Controls.Add(Me.ComButton)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.AlertPictureBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HVAC_Controller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HVAC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.HeaterButtonsGroupBox.ResumeLayout(False)
        Me.HeaterButtonsGroupBox.PerformLayout()
        CType(Me.HeaterUpPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaterDownPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ACButtonsGroupBox.ResumeLayout(False)
        Me.ACButtonsGroupBox.PerformLayout()
        CType(Me.ACUpPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACDownPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlertPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaterSetpointTextBox As TextBox
    Friend WithEvents CoolingSetpointTextBox As TextBox
    Friend WithEvents AlertPictureBox As PictureBox
    Friend WithEvents QYBoardSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents ComButton As Button
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents ClockLabel As Label
    Friend WithEvents SystemTempLabel As Label
    Friend WithEvents TempTimer As Timer
    Friend WithEvents HeaterRadioButton As RadioButton
    Friend WithEvents ACRadioButton As RadioButton
    Friend WithEvents OffRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HeaterPictureBox As PictureBox
    Friend WithEvents FanTimer As Timer
    Friend WithEvents HeaterUpPictureBox As PictureBox
    Friend WithEvents HeaterDownPictureBox As PictureBox
    Friend WithEvents DrawTimer As Timer
    Friend WithEvents ACDownPictureBox As PictureBox
    Friend WithEvents ACUpPictureBox As PictureBox
    Friend WithEvents HeaterButtonsGroupBox As GroupBox
    Friend WithEvents ACButtonsGroupBox As GroupBox
    Friend WithEvents ACPictureBox As PictureBox
    Friend WithEvents FanPictureBox As PictureBox
    Friend WithEvents RoomTempLabel As Label
    Friend WithEvents HeaterSetpointLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PressureTimer As Timer
    Friend WithEvents SaveButton As Button
    Friend WithEvents LogoPictureBox As PictureBox
End Class
