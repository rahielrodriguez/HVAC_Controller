Imports System.Drawing.Text
Imports System.IO.Ports
Imports System.Threading.Thread
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Runtime.InteropServices

Public Class HVAC_Controller
    Dim heaterSetpoint As Double = 70
    Dim coolingSetpoint As Double = 80
    Dim roomTemp As Integer
    Dim systemTemp As Integer
    Dim overwriteHeater As Integer = 0
    Dim overwriteAC As Integer = 0
    Dim fanCycle As Integer = 0
    '------------------------------------------------------------GUI Configuration---------------------------------------------------------------------------
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
            If s = "COM3" Then

            ElseIf s = "COM4" Then

            Else
                PortsComboBox.Items.Add($"{s}")
            End If
        Next
        PortsComboBox.SelectedIndex = 0
    End Sub
    '----------------------------------------------------------------QY@ BOARD Functions----------------------------------------------------------------
    Sub Qy_ReadDigitalInputs()
        Dim data(0) As Byte
        data(0) = &B110000
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub
    Sub Qy_ReadAnalogInPutA1()
        Dim data(0) As Byte
        data(0) = &B1010001
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub
    Sub Qy_ReadAnalogInPutA2()
        Dim data(0) As Byte
        data(0) = &B1010010
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub

    '-----------------------------------------------------------Buttons and Form Events-----------------------------------------------------------
    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        'GetComPorts()
        GetPorts()
    End Sub

    Private Sub HighTemp1Button_Click(sender As Object, e As EventArgs) Handles HighTemp1Button.Click
        If heaterSetpoint <= 90 Then
            heaterSetpoint += 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub HighTemp2Button_Click(sender As Object, e As EventArgs) Handles HighTemp2Button.Click
        If heaterSetpoint >= 50 Then
            heaterSetpoint -= 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub CoolingTemp1Button_Click(sender As Object, e As EventArgs) Handles CoolingTemp1Button.Click
        If coolingSetpoint <= 90 Then
            coolingSetpoint += 0.5
            CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub CoolingTemp2Button_Click(sender As Object, e As EventArgs) Handles CoolingTemp2Button.Click
        If coolingSetpoint >= 50 Then
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
        TempTimer.Start()
    End Sub

    Private Sub PortsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortsComboBox.SelectedIndexChanged
        SerialConnect(PortsComboBox.SelectedItem)
    End Sub
    '--------------------------------------------CLOCK------------------------------------------------------------
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub TempTimer_Tick(sender As Object, e As EventArgs) Handles TempTimer.Tick
        Dim dataA1(QYBoardSerialPort.BytesToRead) As Byte
        Dim dataA2(QYBoardSerialPort.BytesToRead) As Byte
        Dim dataDigital(QYBoardSerialPort.BytesToRead) As Byte
        Qy_ReadAnalogInPutA1()
        Sleep(5)

        ReDim dataA1(QYBoardSerialPort.BytesToRead)
        QYBoardSerialPort.Read(dataA1, 0, QYBoardSerialPort.BytesToRead)
        RoomTempLabel.Text = $"{CInt((dataA1(0) / 6.4) + 50)} °F"
        roomTemp = CInt((dataA1(0) / 6.4) + 50)
        Qy_ReadAnalogInPutA2()
        Sleep(5)

        ReDim dataA2(QYBoardSerialPort.BytesToRead)
        QYBoardSerialPort.Read(dataA2, 0, QYBoardSerialPort.BytesToRead)
        SystemTempLabel.Text = $"{CInt((dataA2(0) / 6.4) + 50)} °F"
        systemTemp = CInt((dataA2(0) / 6.4) + 50)
        Qy_ReadDigitalInputs()
        Sleep(5)

        ReDim dataDigital(QYBoardSerialPort.BytesToRead)
        QYBoardSerialPort.Read(dataDigital, 0, QYBoardSerialPort.BytesToRead)

        If dataDigital(0) = 254 Then
            OffRadioButton.Checked = True
            FanPictureBox.BackColor = Color.Gray
            HVACPictureBox.BackColor = Color.Gray
            AlertPictureBox.BackColor = Color.Red
        ElseIf dataDigital(0) = 253 Then
            If fanCycle = 0 Then
                FanPictureBox.BackColor = Color.Lime
            Else
                FanPictureBox.BackColor = Color.Gray
            End If
            overwriteHeater = 1
            FanTimer.Start()
        ElseIf dataDigital(0) = 251 Then
            If fanCycle = 0 Then
                FanPictureBox.BackColor = Color.Lime
            Else
                FanPictureBox.BackColor = Color.Gray
            End If
            overwriteAC = 1
            FanTimer.Start()
        ElseIf dataDigital(0) = 247 Then
            FanPictureBox.BackColor = Color.Lime
            HVACPictureBox.BackColor = Color.Gray
        ElseIf dataDigital(0) = 239 Then
            OffRadioButton.Checked = True
            FanPictureBox.BackColor = Color.Gray
            HVACPictureBox.BackColor = Color.Gray
            AlertPictureBox.BackColor = Color.Red
        Else
            fanCycle = 0
            If systemTemp > CInt(CoolingSetpointTextBox.Text) + 2 And HeaterRadioButton.Checked Then
                FanPictureBox.BackColor = Color.Lime
                FanTimer.Start()
            ElseIf systemTemp < CInt(HeaterSetpointTextBox.Text) - 2 And ACRadioButton.Checked Then
                FanPictureBox.BackColor = Color.Lime
                FanTimer.Start()
            Else

            End If

        End If

    End Sub

    Private Sub FanTimer_Tick(sender As Object, e As EventArgs) Handles FanTimer.Tick

        If overwriteHeater = 1 Then
            fanCycle = 1
            FanPictureBox.BackColor = Color.Gray
            HVACPictureBox.BackColor = Color.IndianRed
            HeaterRadioButton.Checked = True
            If systemTemp < roomTemp And HeaterRadioButton.Checked Then
                AlertPictureBox.BackColor = Color.Red
            Else
                AlertPictureBox.BackColor = Color.Gray
            End If
        ElseIf overwriteAC = 1 Then
            fanCycle = 1
            FanPictureBox.BackColor = Color.Gray
            HVACPictureBox.BackColor = Color.Cyan
            ACRadioButton.Checked = True
            If systemTemp > roomTemp And ACRadioButton.Checked Then
                AlertPictureBox.BackColor = Color.Red
            Else
                AlertPictureBox.BackColor = Color.Gray
            End If
        Else
            If systemTemp > CInt(CoolingSetpointTextBox.Text) + 2 And HeaterRadioButton.Checked Then
                FanPictureBox.BackColor = Color.Gray
                HVACPictureBox.BackColor = Color.Cyan
                ACRadioButton.Checked = True
            ElseIf systemTemp < CInt(HeaterSetpointTextBox.Text) - 2 And ACRadioButton.Checked Then
                FanPictureBox.BackColor = Color.Gray
                HVACPictureBox.BackColor = Color.IndianRed
                HeaterRadioButton.Checked = True
            End If

        End If
        overwriteHeater = 0
        overwriteAC = 0
        FanTimer.Stop()
    End Sub

End Class
