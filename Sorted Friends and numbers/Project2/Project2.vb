Public Class frmProject2
    Dim dblNumbers(9) As Double
    Dim intCountOfNumbers As Int32 = 0

    Private Sub btnAddNameToList_Click(sender As Object, e As EventArgs) Handles btnAddNameToList.Click
        If (txtAddAName.Text = String.Empty) Then
            MessageBox.Show("You must enter a name to be added.", "Name Error")
            txtAddAName.Focus()
            Return
        End If
        lstNames.Items.Add(txtAddAName.Text)
        txtAddAName.Text = String.Empty
        txtAddAName.Focus()
    End Sub

    Private Sub btnRemoveNameFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveNameFromList.Click
        If (lstNames.SelectedIndex = -1) Then
            MessageBox.Show("You must select a name from the list to remove", "Removal Error")
            lstNames.Focus()
            Return
        End If
        lstNames.Items.RemoveAt(lstNames.SelectedIndex)
    End Sub

    Private Sub btnSortTheListNames_Click(sender As Object, e As EventArgs) Handles btnSortTheListNames.Click
        lstNames.Sorted = True
        lstNames.Sorted = False
    End Sub

    Private Sub btnAddTheNumberToTheArray_Click(sender As Object, e As EventArgs) Handles btnAddTheNumberToTheArray.Click
        Dim dblEnteredNumber As Double
        Try
            dblEnteredNumber = CType(txtAddANumberToBeIncluded.Text, Double)
        Catch ex As Exception
            MessageBox.Show("You must enter a number to be added to the list", "Error - Number")
            txtAddANumberToBeIncluded.Text = String.Empty
            txtAddANumberToBeIncluded.Focus()
            Return
        End Try
        intCountOfNumbers += 1
        If (intCountOfNumbers > 10) Then
            MessageBox.Show("Sorry, there is a maximum of 10 numbers that can be entered", "Error - Too Many Numbers Entered")
            intCountOfNumbers -= 1
            txtAddANumberToBeIncluded.Text = String.Empty
            Return
        End If
        dblNumbers(intCountOfNumbers - 1) = dblEnteredNumber
        txtAddANumberToBeIncluded.Text = String.Empty
        txtAddANumberToBeIncluded.Focus()
    End Sub

    Private Sub btnComputeStatistics_Click(sender As Object, e As EventArgs) Handles btnComputeStatistics.Click
        If (intCountOfNumbers < 1) Then
            MessageBox.Show("There are no numbers entered so statistics cannot be calculated.", "No Numbers Entered")
            Return
        End If
        Dim intCounter As Int32
        Dim dblTotal As Double
        Dim dblMinimum, dblMaximum As Double
        dblMinimum = dblNumbers(0)
        dblMaximum = dblNumbers(0)
        dblTotal = 0
        For intCounter = 0 To intCountOfNumbers - 1
            dblTotal += dblNumbers(intCounter)
            If (dblNumbers(intCounter) < dblMinimum) Then
                dblMinimum = dblNumbers(intCounter)
            End If
            If (dblNumbers(intCounter) > dblMaximum) Then
                dblMaximum = dblNumbers(intCounter)
            End If
        Next
        lblStatisticsOutput.Text = intCountOfNumbers.ToString & " numbers were entered" & vbCrLf
        lblStatisticsOutput.Text += "The highest number is " & dblMaximum.ToString & vbCrLf
        lblStatisticsOutput.Text += "The lowest number is " & dblMinimum.ToString & vbCrLf
        lblStatisticsOutput.Text += "The average is " & (dblTotal / intCountOfNumbers).ToString
    End Sub

    Private Sub btnResetTheForm_Click(sender As Object, e As EventArgs) Handles btnResetTheForm.Click
        txtAddAName.Text = String.Empty
        txtAddANumberToBeIncluded.Text = String.Empty
        txtAddAName.Focus()
        lstNames.Items.Clear()
        ResetNumbers()
        lblStatisticsOutput.Text = String.Empty
    End Sub
    Private Sub ResetNumbers()
        Dim intCounter As Int32
        For intCounter = 0 To 9
            dblNumbers(intCounter) = 0
        Next
        intCountOfNumbers = 0
    End Sub

End Class
