Public Class frmClassExample

    Private Sub frmClassExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormReset()

    End Sub
    Private Sub FormReset()
        lstName.SelectedIndex = -1
        lstProject1.SelectedIndex = -1
        lstProject2.SelectedIndex = -1
        lstExam1.SelectedIndex = -1
        lstProject1.Enabled = False
        lstProject2.Enabled = False
        lstExam1.Enabled = False
        grpContainer.Visible = False
        btnReset.Visible = False
        lblOpeningMessage.Visible = True
        btnContinue.Visible = True
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        lblOpeningMessage.Visible = False
        btnContinue.Visible = False
        btnReset.Visible = True
        grpContainer.Visible = True
        Dim intCountOfItems As Int32
        intCountOfItems = lstName.Items.Count
        Dim dblProject1Sum As Double
        Dim dblProject2Sum As Double
        Dim dblExam1Sum As Double
        dblProject1Sum = 0
        dblProject2Sum = 0
        dblExam1Sum = 0

        Dim intLoopCounter As Int32
        For intLoopCounter = 0 To intCountOfItems - 1
            lstProject1.SelectedIndex = intLoopCounter
            lstProject2.SelectedIndex = intLoopCounter
            lstExam1.SelectedIndex = intLoopCounter
            dblProject1Sum += CType(lstProject1.SelectedItem, Double)
            dblProject2Sum += CType(lstProject2.SelectedItem, Double)
            dblExam1Sum += CType(lstExam1.SelectedItem, Double)
        Next
        lblProject1Average.Text = (dblProject1Sum / intCountOfItems).ToString("N2")
        lblProject2Average.Text = (dblProject2Sum / intCountOfItems).ToString("N2")
        lblExam1Average.Text = (dblExam1Sum / intCountOfItems).ToString("N2")
        lstProject1.SelectedIndex = -1
        lstProject2.SelectedIndex = -1
        lstExam1.SelectedIndex = -1
    End Sub

    Private Sub lstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstName.SelectedIndexChanged
        If (lstName.SelectedIndex = -1) Then
            Return
        End If
        lstProject1.SelectedIndex = lstName.SelectedIndex
        lstProject2.SelectedIndex = lstName.SelectedIndex
        lstExam1.SelectedIndex = lstName.SelectedIndex
        Dim dblTotalPossible, dblTotalPoints As Double
        dblTotalPossible = CType(lblPossiblePointsProject1.Text, Double) + CType(lblPossiblePointsProject2.Text, Double) + CType(lblPossiblePointsExam1.Text, Double)
        dblTotalPoints = CType(lstProject1.SelectedItem, Double) + CType(lstProject2.SelectedItem, Double) + CType(lstExam1.SelectedItem, Double)
        If (dblTotalPoints / dblTotalPossible >= 0.9) Then
            lblGradeOutput.Text = lstName.SelectedItem & " made " & (dblTotalPoints / dblTotalPossible).ToString("p1") & " or a grade of A"
        ElseIf (dblTotalPoints / dblTotalPossible >= 0.8) Then
            lblGradeOutput.Text = lstName.SelectedItem & " made " & (dblTotalPoints / dblTotalPossible).ToString("p1") & " or a grade of B"
        ElseIf (dblTotalPoints / dblTotalPossible >= 0.7) Then
            lblGradeOutput.Text = lstName.SelectedItem & " made " & (dblTotalPoints / dblTotalPossible).ToString("p1") & " or a grade of C"
        ElseIf (dblTotalPoints / dblTotalPossible >= 0.6) Then
            lblGradeOutput.Text = lstName.SelectedItem & " made " & (dblTotalPoints / dblTotalPossible).ToString("p1") & " or a grade of D"
        Else
            lblGradeOutput.Text = lstName.SelectedItem & " made " & (dblTotalPoints / dblTotalPossible).ToString("p1") & " or a grade of F"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        FormReset()
    End Sub
End Class
