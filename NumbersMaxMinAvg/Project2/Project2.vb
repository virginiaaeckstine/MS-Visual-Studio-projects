Public Class frmProject2

    Dim dblNumbers(9) As Double
    Dim intCountOfNumbers As Int32
    Private Sub frmProject2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        


    End Sub


    Private Sub ResetForm()
        ClearArray()
        txtEnterANumber.Text = String.Empty
        radAddtothelist.Checked = False
        radRemovefromthelist.Checked = False
        lstProcess.Items.Clear()
        chkMaximum.Checked = False
        chkMaximum.Checked = False
        chkAverage.Checked = False
        lblComputerStats.Text = String.Empty
        txtEnterANumber.Focus()
        btnProcess.Enabled = True
    End Sub
    Private Sub ClearArray()
        ReDim dblNumbers(9)
        intCountOfNumbers = 0
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        Dim dblEnterAName As Double
        If (radAddtothelist.Checked) Then
            Try
                dblEnterAName = CType(txtEnterANumber.Text, Double)
                intCountOfNumbers += 1
                dblNumbers(intCountOfNumbers - 1) = dblEnterAName
                lstProcess.Items.Add(dblEnterAName.ToString("N3"))
                txtEnterANumber.Text = String.Empty
                txtEnterANumber.Focus()
            Catch ex As Exception
                MessageBox.Show("You must enter a number", "Error   Number Entry")
                txtEnterANumber.Text = String.Empty
                txtEnterANumber.Focus()
                Return
            End Try
        ElseIf (radRemovefromthelist.Checked) Then
            If (lstProcess.SelectedIndex = -1) Then
                MessageBox.Show("Cannot remove an itm because no item was selected", "Error - Selected")
                txtEnterANumber.Focus()
                Return
            Else
                lstProcess.Items.RemoveAt(lstProcess.SelectedIndex)
            End If
        Else
            MessageBox.Show("No Action was taken because no action was selected", "Error - Action")
            txtEnterANumber.Focus()
            Return
        End If
    End Sub

    Private Sub btnComputerStatistics_Click(sender As Object, e As EventArgs) Handles btnComputerStatistics.Click
        If (intCountOfNumbers = 0) Then
            MessageBox.Show("Cannot compute statistics because no numbers have ben entered", "Error - Action")
            Return
        End If
        If (chkMaximum.Checked = False And chkMinimum.Checked = False And chkAverage.Checked = False) Then
            MessageBox.Show("You must choose at least one statistic to disply", "Error-Action")
            Return
        End If
        ReDim Preserve dblNumbers(intCountOfNumbers - 1)
        btnProcess.Enabled = False
        Dim dblMaximum As Double
        dblMaximum = dblNumbers(0)
        Dim dblMinimum As Double
        dblMinimum = dblNumbers(0)
        Array.Sort(dblNumbers)
        dblMaximum = dblNumbers(intCountOfNumbers - 1)
        dblMinimum = dblNumbers(0)
        Dim dblSum As Double
        dblSum = 0
        Dim dblAverage As Double
        dblAverage = 0
        Dim intCounter As Int32
        For intCounter = 0 To intCountOfNumbers - 1
            dblSum += dblNumbers(intCounter)
        Next
        dblAverage = dblSum / intCountOfNumbers
        lblComputerStats.Text = String.Empty
        If (chkMaximum.Checked) Then
            lblComputerStats.Text += vbCrLf & "Maximum is " & dblMaximum.ToString("N3")
        End If
        If (chkMinimum.Checked) Then
            lblComputerStats.Text += vbCrLf & "Minimum is " & dblMinimum.ToString("N3")
        End If
        If (chkAverage.Checked) Then
            lblComputerStats.Text += vbCrLf & "Average is " & dblAverage.ToString("N3")
        End If
    End Sub
End Class
