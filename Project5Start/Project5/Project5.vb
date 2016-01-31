Public Class frmProject5

    Private Sub frmProject5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BusinessMajorsDataSet.BusinessMajors' table. You can move, or remove it, as needed.
        Me.BusinessMajorsTableAdapter.Fill(Me.BusinessMajorsDataSet.BusinessMajors)

    End Sub

    Private Sub Select_MIS_MajorToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_MIS_MajorToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_MIS_Major(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_ClassToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BusinessMajorsTableAdapter.Select_Class(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_Class_1ToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_Class_1ToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Class_1(Me.BusinessMajorsDataSet.BusinessMajors, _ClassToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_JuniorToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_JuniorToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Junior(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_Hours_Greater_than_100ToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_Hours_Greater_than_100ToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Hours_Greater_than_100(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Select_Senior_And_MKTToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_Senior_And_MKTToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Senior_And_MKT(Me.BusinessMajorsDataSet.BusinessMajors, _ClassToolStripTextBox1.Text, MajorToolStripTextBox.Text)
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

    Private Sub Select_Senior_And_MKT1ToolStripButton_Click(sender As Object, e As EventArgs) Handles Select_Senior_And_MKT1ToolStripButton.Click
        Try
            Me.BusinessMajorsTableAdapter.Select_Senior_And_MKT1(Me.BusinessMajorsDataSet.BusinessMajors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
