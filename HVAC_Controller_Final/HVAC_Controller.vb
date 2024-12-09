Imports System.Drawing.Text
Imports System.IO.Ports

Public Class HVAC_Controller
    Dim heaterSetpoint As Double = 75
    Dim coolingSetpoint As Double = 60
    '--------------------------------------------CLOCK------------------------------------------------------------
    Sub newFont()
        Dim customFont As New PrivateFontCollection
        customFont.AddFontFile("C:\Users\Rahi\OneDrive\Desktop\ISU\Robotics\5th Semester\Programing\HVAC_Controller_Final\RobotoSlab-VariableFont_wght.ttf")
        Me.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        HeaterSetpointTextBox.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        CoolingSetpointTextBox.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        HighTemp1Button.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        HighTemp2Button.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        CoolingTemp1Button.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        CoolingTemp2Button.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        ClockLabel.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        PortsComboBox.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        ComButton.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
    End Sub
    Sub SerialConnect(portName As String)
        QYBoardSerialPort.Close()
        QYBoardSerialPort.PortName = portName
        QYBoardSerialPort.BaudRate = 9600
        QYBoardSerialPort.Open()
    End Sub
    Sub GetPorts()
        'add all available ports to the port combobox
        PortsComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            PortsComboBox.Items.Add($"{s}")
        Next

        PortsComboBox.SelectedIndex = 0
    End Sub
    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        'GetComPorts()
        GetPorts()
    End Sub

    Private Sub HighTemp1Button_Click(sender As Object, e As EventArgs) Handles HighTemp1Button.Click
        If heaterSetpoint < 90 Then
            heaterSetpoint += 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub HighTemp2Button_Click(sender As Object, e As EventArgs) Handles HighTemp2Button.Click
        If heaterSetpoint > 50 Then
            heaterSetpoint -= 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub CoolingTemp1Button_Click(sender As Object, e As EventArgs) Handles CoolingTemp1Button.Click
        If coolingSetpoint < 90 Then
            coolingSetpoint += 0.5
            CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub CoolingTemp2Button_Click(sender As Object, e As EventArgs) Handles CoolingTemp2Button.Click
        If coolingSetpoint > 50 Then
            coolingSetpoint -= 0.5
            CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub HVAC_Controller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newFont()
        HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        GetPorts()
        ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss")
        ClockTimer.Start()
    End Sub

    Private Sub PortsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortsComboBox.SelectedIndexChanged
        SerialConnect(PortsComboBox.SelectedItem)
    End Sub
    '--------------------------------------------CLOCK------------------------------------------------------------
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

End Class
