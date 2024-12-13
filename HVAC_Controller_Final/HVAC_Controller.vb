Imports System.Drawing.Text
Imports System.IO.Ports
Imports System.Threading.Thread
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Runtime.InteropServices
Imports System.IO

'Rahiel Rodriguez
'RCET 3371
'Fall 2024
'HVAC Final
'https://github.com/rahielrodriguez/HVAC_Controller.git
Public Class HVAC_Controller
    Dim heater_Off_Image As New Bitmap(My.Resources.heater_off)
    Dim heater_On_Image As New Bitmap(My.Resources.heater_on)
    Dim ac_Off_image As New Bitmap(My.Resources.air_conditioner_off)
    Dim ac_On_Image As New Bitmap(My.Resources.air_conditioner_on)
    Dim fan_Image As New Bitmap(My.Resources.fan)
    Dim service_Alert_Image As New Bitmap(My.Resources.service_alert)
    Dim logo As New Bitmap(My.Resources.logo)
    Dim heaterSetpoint As Double
    Dim coolingSetpoint As Double
    Dim roomTemp As Integer
    Dim systemTemp As Integer
    Dim overwriteHeater As Integer = 0
    Dim overwriteAC As Integer = 0
    Dim fanCycle As Integer = 0
    Dim pressureAlert As Boolean
    Dim settingsList As New List(Of String)
    '------------------------------------------------------------GUI Configuration---------------------------------------------------------------------------
    Sub newFont()
        'Takes file from resources changes the font of the program in general
        Dim customFont As New PrivateFontCollection
        customFont.AddFontFile($"C:\Users\Rahi\OneDrive\Desktop\ISU\Robotics\5th Semester\Programing\HVAC_Controller_Final\HVAC_Controller_Final\Resources\RobotoSlab-Medium.ttf")
        Me.Font = New Drawing.Font(customFont.Families(0), 10, FontStyle.Regular)
    End Sub
    Public Shared Function ResizeImage(ByVal InputBitmap As Bitmap, width As Integer, height As Integer) As Bitmap
        'takes images to transform them into bitmaps to change its size
        Return New Bitmap(InputBitmap, New Size(width, height)) 'takes the soccer ball image and changes its size to make it fit correctly in the picture box
    End Function
    '-----------------------------------------------------------Serial Com Configuration------------------------------------------------------------------------
    Sub SerialConnect(portName As String)
        QYBoardSerialPort.Close()
        QYBoardSerialPort.PortName = portName
        QYBoardSerialPort.BaudRate = 9600
        QYBoardSerialPort.Open()
    End Sub
    Sub GetPorts()
        'add all available ports to the port combobox
        PortsComboBox.Items.Clear()
        'If port 3 or 4 are detected, do not use them
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
        'Command to read digital inputs from the QY@ Board
        data(0) = &B110000
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub
    Sub Qy_ReadAnalogInPutA1()
        Dim data(0) As Byte
        'Command to analog input 1 from the QY@ Board
        data(0) = &B1010001
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub
    Sub Qy_ReadAnalogInPutA2()
        Dim data(0) As Byte
        'Command to analog input 2 from the QY@ Board
        data(0) = &B1010010
        QYBoardSerialPort.Write(data, 0, 1)
    End Sub
    '-----------------------------------------------------------Buttons and Form Events-----------------------------------------------------------
    Sub DrawHeaterTriangleUp()
        ' draw a filled equilateral triangle
        Dim g As Graphics = HeaterUpPictureBox.CreateGraphics
        Dim width As Integer = HeaterUpPictureBox.Width
        Dim height As Integer = HeaterUpPictureBox.Height

        ' define points for an equilateral triangle
        Dim points As Point() = {
            New Point(width \ 2, 10),                   ' Top vertex
            New Point(10, height - 10),                ' Bottom-left
            New Point(width - 10, height - 10)         ' bottom-right
        }

        ' fill the triangle with a color
        g.FillPolygon(Brushes.Red, points)
        'g.FillRectangle(Brushes.Green, 10, 10, 20, 20)
        g.Dispose()
    End Sub
    Sub DrawHeaterTriangleDown()
        ' Draw a filled downward-facing equilateral triangle
        Dim g As Graphics = HeaterDownPictureBox.CreateGraphics
        Dim width As Integer = HeaterDownPictureBox.Width
        Dim height As Integer = HeaterDownPictureBox.Height

        ' Define points for a downward-facing equilateral triangle
        Dim points As Point() = {
        New Point(width \ 2, height - 10),  ' Bottom vertex
        New Point(10, 10),                 ' Top-left
        New Point(width - 10, 10)          ' Top-right
    }

        ' Fill the triangle with a color
        g.FillPolygon(Brushes.Blue, points)

        g.Dispose()
    End Sub
    Sub DrawACTriangleUp()
        ' draw a filled equilateral triangle
        Dim g As Graphics = ACUpPictureBox.CreateGraphics
        Dim width As Integer = ACUpPictureBox.Width
        Dim height As Integer = ACUpPictureBox.Height

        ' define points for an equilateral triangle
        Dim points As Point() = {
            New Point(width \ 2, 10),                   ' Top vertex
            New Point(10, height - 10),                ' Bottom-left
            New Point(width - 10, height - 10)         ' bottom-right
        }

        ' fill the triangle with a color
        g.FillPolygon(Brushes.Red, points)
        'g.FillRectangle(Brushes.Green, 10, 10, 20, 20)
        g.Dispose()
    End Sub
    Sub DrawACTriangleDown()
        ' Draw a filled downward-facing equilateral triangle
        Dim g As Graphics = ACDownPictureBox.CreateGraphics
        Dim width As Integer = ACDownPictureBox.Width
        Dim height As Integer = ACDownPictureBox.Height

        ' Define points for a downward-facing equilateral triangle
        Dim points As Point() = {
        New Point(width \ 2, height - 10),  ' Bottom vertex
        New Point(10, 10),                 ' Top-left
        New Point(width - 10, 10)          ' Top-right
    }

        ' Fill the triangle with a color
        g.FillPolygon(Brushes.Blue, points)

        g.Dispose()
    End Sub
    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        GetPorts()
    End Sub

    Private Sub HVAC_Controller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp() As String
        Dim settings As String
        'Changes the font of the program
        newFont()
        'Brings the previous settings in for start up
        Try
            FileOpen(1, "..\..\..\HVACsettings.txt", OpenMode.Input)
        Catch ex As Exception

        End Try

        Do Until EOF(1)
            settings = LineInput(1)
            Me.settingsList.Add($"{settings}")
        Loop

        For Each value In settingsList
            temp = Split(settings, ",")
        Next
        heaterSetpoint = CInt(temp(1))
        coolingSetpoint = CInt(temp(2))
        FileClose()

        'Resizes images for future usage
        heater_Off_Image = ResizeImage(heater_Off_Image, HeaterPictureBox.Width, HeaterPictureBox.Height)
        heater_On_Image = ResizeImage(heater_On_Image, HeaterPictureBox.Width, HeaterPictureBox.Height)
        ac_Off_image = ResizeImage(ac_Off_image, ACPictureBox.Width, ACPictureBox.Height)
        ac_On_Image = ResizeImage(ac_On_Image, ACPictureBox.Width, ACPictureBox.Height)
        fan_Image = ResizeImage(fan_Image, FanPictureBox.Width, FanPictureBox.Height)
        service_Alert_Image = ResizeImage(service_Alert_Image, AlertPictureBox.Width, AlertPictureBox.Height)
        logo = ResizeImage(logo, LogoPictureBox.Width, LogoPictureBox.Height)
        LogoPictureBox.BackgroundImage = logo
        HeaterPictureBox.BackgroundImage = heater_Off_Image
        ACPictureBox.BackgroundImage = ac_Off_image
        FanPictureBox.BackColor = Color.Transparent
        AlertPictureBox.BackgroundImage = service_Alert_Image
        AlertPictureBox.BackColor = Color.Transparent

        HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        CoolingSetpointTextBox.Text = $"{coolingSetpoint}"

        GetPorts()
        'Sets Clock and starts all timers
        ClockLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
        ClockTimer.Start()
        TempTimer.Start()
        DrawTimer.Start()
        PressureTimer.Start()
    End Sub

    Private Sub PortsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortsComboBox.SelectedIndexChanged
        SerialConnect(PortsComboBox.SelectedItem)
    End Sub
    '--------------------------------------------CLOCK------------------------------------------------------------
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
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

        'Handles all digital input changes functions
        If dataDigital(0) = 254 Then 'Error Button Pressed
            OffRadioButton.Checked = True
            FanPictureBox.BackColor = Color.Transparent
            FanPictureBox.BackgroundImage = Nothing
            HeaterPictureBox.BackgroundImage = heater_Off_Image
            ACPictureBox.BackgroundImage = ac_Off_image
            AlertPictureBox.BackColor = Color.Red
            pressureAlert = False
        ElseIf dataDigital(0) = 253 Then 'Heater Enabled Button
            pressureAlert = False
            If fanCycle = 0 Then
                FanPictureBox.BackgroundImage = fan_Image
                FanPictureBox.BackColor = Color.Transparent
            Else
                FanPictureBox.BackColor = Color.Transparent
                FanPictureBox.BackgroundImage = Nothing
            End If
            overwriteHeater = 1
            overwriteAC = 0
            FanTimer.Start()
        ElseIf dataDigital(0) = 251 Then 'A/C Enabled Button
            pressureAlert = False
            If fanCycle = 0 Then
                FanPictureBox.BackgroundImage = fan_Image
                FanPictureBox.BackColor = Color.Transparent
            Else
                FanPictureBox.BackColor = Color.Transparent
                FanPictureBox.BackgroundImage = Nothing
            End If
            overwriteAC = 1
            overwriteHeater = 0
            FanTimer.Start()
        ElseIf dataDigital(0) = 247 Then 'Fan only button
            pressureAlert = False
            FanPictureBox.BackgroundImage = fan_Image
            FanPictureBox.BackColor = Color.Transparent
            HeaterPictureBox.BackgroundImage = heater_Off_Image
            ACPictureBox.BackgroundImage = ac_Off_image
            OffRadioButton.Checked = True
        ElseIf dataDigital(0) = 239 Then 'Pressure Sensor Button
            pressureAlert = True
        Else
            pressureAlert = False
            AlertPictureBox.BackColor = Color.Transparent
            fanCycle = 0
            If systemTemp > CInt(CoolingSetpointTextBox.Text) + 2 And HeaterRadioButton.Checked Then
                FanPictureBox.BackgroundImage = fan_Image
                FanPictureBox.BackColor = Color.Transparent
                FanTimer.Start()
            ElseIf systemTemp < CInt(HeaterSetpointTextBox.Text) - 2 And ACRadioButton.Checked Then
                FanPictureBox.BackgroundImage = fan_Image
                FanPictureBox.BackColor = Color.Transparent
                FanTimer.Start()
            Else

            End If

        End If

    End Sub

    Private Sub FanTimer_Tick(sender As Object, e As EventArgs) Handles FanTimer.Tick

        If overwriteHeater = 1 Then 'if fan is was already displayed and covered, handles displaying it again
            fanCycle = 1
            FanPictureBox.BackColor = Color.Transparent
            FanPictureBox.BackgroundImage = Nothing
            HeaterPictureBox.BackgroundImage = heater_On_Image
            ACPictureBox.BackgroundImage = ac_Off_image
            HeaterRadioButton.Checked = True
            If systemTemp < roomTemp And HeaterRadioButton.Checked Then
                AlertPictureBox.BackColor = Color.Red
            Else
                AlertPictureBox.BackColor = Color.Transparent
            End If
        ElseIf overwriteAC = 1 Then
            fanCycle = 1
            FanPictureBox.BackColor = Color.Transparent
            FanPictureBox.BackgroundImage = Nothing
            HeaterPictureBox.BackgroundImage = heater_Off_Image
            ACPictureBox.BackgroundImage = ac_On_Image
            ACRadioButton.Checked = True
            If systemTemp > roomTemp And ACRadioButton.Checked Then
                AlertPictureBox.BackColor = Color.Red
            Else
                AlertPictureBox.BackColor = Color.Transparent
            End If
        Else
            If systemTemp > CInt(CoolingSetpointTextBox.Text) + 2 And HeaterRadioButton.Checked Then 'Handles automatic heater and A/C activation
                FanPictureBox.BackColor = Color.Transparent
                FanPictureBox.BackgroundImage = Nothing
                HeaterPictureBox.BackgroundImage = heater_Off_Image
                ACPictureBox.BackgroundImage = ac_On_Image
                ACRadioButton.Checked = True
            ElseIf systemTemp < CInt(HeaterSetpointTextBox.Text) - 2 And ACRadioButton.Checked Then
                FanPictureBox.BackColor = Color.Transparent
                FanPictureBox.BackgroundImage = Nothing
                HeaterPictureBox.BackgroundImage = heater_On_Image
                ACPictureBox.BackgroundImage = ac_Off_image
                HeaterRadioButton.Checked = True
            End If

        End If
        overwriteHeater = 0
        overwriteAC = 0
        FanTimer.Stop()
    End Sub
    Private Sub HeaterUpPictureBox_Click(sender As Object, e As EventArgs) Handles HeaterUpPictureBox.Click
        If heaterSetpoint <= 90 And heaterSetpoint < coolingSetpoint Then
            heaterSetpoint += 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick
        DrawHeaterTriangleUp()
        DrawHeaterTriangleDown()
        DrawACTriangleUp()
        DrawACTriangleDown()
        DrawTimer.Stop()
    End Sub
    'Next 4 subs changes Heater and A/C Setpoints and do not let setpoints to exceed max and min temps
    Private Sub HeaterDownPictureBox_Click(sender As Object, e As EventArgs) Handles HeaterDownPictureBox.Click
        If heaterSetpoint >= 50 And heaterSetpoint < coolingSetpoint Then
            heaterSetpoint -= 0.5
            HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub ACUpPictureBox_Click(sender As Object, e As EventArgs) Handles ACUpPictureBox.Click
        If coolingSetpoint <= 90 And heaterSetpoint < coolingSetpoint Then
            coolingSetpoint += 0.5
            CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub ACDownPictureBox_Click(sender As Object, e As EventArgs) Handles ACDownPictureBox.Click
        If coolingSetpoint >= 50 And heaterSetpoint < coolingSetpoint Then
            coolingSetpoint -= 0.5
            CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
        Else
            MsgBox("Setpoints can go from 50 to 90 degrees. Please, select a valid value within range.", MsgBoxStyle.Exclamation, "Setpoint Error")
        End If
    End Sub

    Private Sub PressureTimer_Tick(sender As Object, e As EventArgs) Handles PressureTimer.Tick
        'If the timer ticks and the Pressure Button is being pressed, produces an "error"
        If pressureAlert = True Then
            OffRadioButton.Checked = True
            FanPictureBox.BackColor = Color.Transparent
            FanPictureBox.BackgroundImage = Nothing
            HeaterPictureBox.BackgroundImage = heater_Off_Image
            ACPictureBox.BackgroundImage = ac_Off_image
            AlertPictureBox.BackColor = Color.Red
        Else

        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Saves current Settings in file
        Try
            FileOpen(1, "..\..\..\HVACsettings.txt", OpenMode.Output)
            PrintLine(1, $"{PortsComboBox.Text},{HeaterSetpointTextBox.Text},{CoolingSetpointTextBox.Text}")
            FileClose()
        Catch ex As Exception

        End Try

    End Sub

End Class
