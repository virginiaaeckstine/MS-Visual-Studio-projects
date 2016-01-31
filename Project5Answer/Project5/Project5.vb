Public Class frmProject5

    Private Sub frmProject5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BusinessMajorsDataSet.BusinessMajors' table. You can move, or remove it, as needed.
        Me.BusinessMajorsTableAdapter.Fill(Me.BusinessMajorsDataSet.BusinessMajors)
    End Sub

    Private Sub Select_MIS_MajorsToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_MIS_MajorsToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_MIS_Majors(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_SeniorsToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_SeniorsToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Seniors(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_Hours_At_Least_100ToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_Hours_At_Least_100ToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Hours_At_Least_100(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ResetToolStripButton_Click(sender As Object, e As EventArgs) Handles ResetToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Reset(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCreateUniqueMajors_Click(sender As Object, e As EventArgs) Handles btnCreateUniqueMajors.Click
        If (lstAllMajors.Items.Count < 2) Then
            Return
        End If

        lstUniqueMajors.Items.Clear()
        ' the major is in the 2nd column and BusinessMajorsDataGridView(column, row)
        Dim intRowIndex As Int32
        For intRowIndex = 0 To BusinessMajorsDataGridView.RowCount - 1
            lstUniqueMajors.Items.Add(BusinessMajorsDataGridView.Item(1, intRowIndex).Value.ToString())
        Next

        lstUniqueMajors.Sorted = True

        Dim intLoopCounter As Int32
        Dim strOne, strTwo As String
        For intLoopCounter = lstUniqueMajors.Items.Count - 1 To 1 Step -1
            lstUniqueMajors.SelectedIndex = intLoopCounter
            strOne = lstUniqueMajors.SelectedItem
            lstUniqueMajors.SelectedIndex = intLoopCounter - 1
            strTwo = lstUniqueMajors.SelectedItem
            If (strOne = strTwo) Then
                lstUniqueMajors.Items.RemoveAt(intLoopCounter)
            End If
        Next
    End Sub
End Class
