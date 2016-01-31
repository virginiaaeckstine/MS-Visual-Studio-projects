
Public Class frmProject3

    Private Sub frmProject3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ResetForm()
        lstTemperatures.Items.Clear()
        lstTemperatures.Items.Add("65")
        lstTemperatures.Items.Add("70")
        lstTemperatures.Items.Add("75")
        lstTemperatures.Items.Add("80")
        lstTemperatures.Items.Add("85")
        lstTemperatures.Items.Add("90")
        lstTemperatures.Items.Add("95")
        lstTemperatures.SelectedIndex = 0
    End Sub


    Private Sub lstTemperatures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTemperatures.SelectedIndexChanged
        Dim dblF As Double
        Dim dblC As Double
        dblF = Convert.ToDouble(lstTemperatures.SelectedItem)
        dblC = TemperatureConversion(dblF)
        lblTemperatureOutput.Text = dblF.ToString("n0") & "F " & "equals " & dblC.ToString("n0") & "C"
    End Sub

    Function TemperatureConversion(ByVal dblOne As Double)
        Dim dblC As Double
        dblC = (dblOne - 32) / 1.8
        Return dblC
    End Function

    Private Sub radLondon_CheckedChanged(sender As Object, e As EventArgs) Handles radLondon.CheckedChanged
        If (radLondon.Checked) Then
            Dim dteDateNow As Date
            dteDateNow = Now.AddHours(5)
            lblTimeOutput.Text = dteDateNow.ToShortTimeString
        End If
    End Sub

    Private Sub radContinentalEurope_CheckedChanged(sender As Object, e As EventArgs) Handles radContinentalEurope.CheckedChanged
        If (radContinentalEurope.Checked) Then
            Dim dteDateNow As Date
            dteDateNow = Now.AddHours(6)
            lblTimeOutput.Text = dteDateNow.ToShortTimeString
        End If
    End Sub
End Class

