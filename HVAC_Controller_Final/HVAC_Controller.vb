Public Class HVAC_Controller
    Dim heaterSetpoint As Double = 75
    Dim coolingSetpoint As Double = 60
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
        HeaterSetpointTextBox.Text = $"{heaterSetpoint}"
        CoolingSetpointTextBox.Text = $"{coolingSetpoint}"
    End Sub
End Class
