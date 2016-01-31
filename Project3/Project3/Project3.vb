Public Class frmProject3
    Dim intSeconds As Int32
    Private Sub frmProject3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        If (MessageBox.Show("Do you want to reset all values?", "Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
            Return
        End If
        Reset()
    End Sub

    Private Sub Reset()
        Dim currentRow As String
        lstCourses.Items.Clear()
        Using theCoursesToBeRead As New Microsoft.VisualBasic.FileIO.TextFieldParser("Courses.txt")
            While Not theCoursesToBeRead.EndOfData
                Try
                    currentRow = theCoursesToBeRead.ReadLine
                    lstCourses.Items.Add(currentRow)
                Catch ex As Exception
                    MessageBox.Show("Values cannot be read, ending program.", "Courses File Error")
                    Return
                End Try
            End While
        End Using
        lstInstructors.Items.Clear()
        Using theInstructorsToBeRead As New Microsoft.VisualBasic.FileIO.TextFieldParser("Instructors.txt")
            While Not theInstructorsToBeRead.EndOfData
                Try
                    currentRow = theInstructorsToBeRead.ReadLine
                    lstInstructors.Items.Add(currentRow)
                Catch ex As Exception
                    MessageBox.Show("Values cannot be read, ending program.", "Instructors File Error")
                    Return
                End Try
            End While
        End Using
        lstNames.Items.Clear()
        Using theNamesToBeRead As New Microsoft.VisualBasic.FileIO.TextFieldParser("Names.txt")
            While Not theNamesToBeRead.EndOfData
                Try
                    currentRow = theNamesToBeRead.ReadLine
                    lstNames.Items.Add(currentRow)
                Catch ex As Exception
                    MessageBox.Show("Values cannot be read, ending program.", "Names File Error")
                    Return
                End Try
            End While
        End Using

        lblEnterFirstName.Enabled = True
        lblEnterLastName.Enabled = True
        lblEnter850ID.Enabled = True
        txtEnterFirstName.Enabled = True
        txtEnterFirstName.Text = String.Empty
        txtEnterLastName.Enabled = True
        txtEnterLastName.Text = String.Empty
        txtEnter850ID.Enabled = True
        txtEnter850ID.Text = String.Empty
        txtEnterFirstName.Focus()
        lblNameOutput.Text = String.Empty
        ContinueToolStripMenuItem.Enabled = True
        ActionToolStripMenuItem.Enabled = False
        ResetToolStripMenuItem.Enabled = False
        lstCourses.SelectedIndex = 0
        lstNames.SelectedIndex = 0
        lstInstructors.SelectedIndex = 0
        lstNames.Enabled = False
        lstInstructors.Enabled = False

        lstSelectedCourses.Items.Clear()

        intSeconds = 0
        Timer.Enabled = True

    End Sub

    Private Sub ContinueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContinueToolStripMenuItem.Click
        If (txtEnterFirstName.Text = String.Empty Or txtEnterLastName.Text = String.Empty Or txtEnter850ID.Text = String.Empty) Then
            MessageBox.Show("First name, last name, and 850 number must all be entered", "Entry Error")
            txtEnterFirstName.Focus()
            Return
        End If
        If (txtEnter850ID.Text.Length < 3) Then
            MessageBox.Show("Your 850 number must start with '850'", "850 Number")
            txtEnter850ID.Text = String.Empty
            txtEnter850ID.Focus()
            Return
        End If
        If (txtEnter850ID.Text.Substring(0, 3) <> "850") Then
            MessageBox.Show("Your 850 number must start with '850'", "850 Number")
            txtEnter850ID.Text = String.Empty
            txtEnter850ID.Focus()
            Return
        End If
        lblNameOutput.Text = WholeName(txtEnterFirstName.Text, txtEnterLastName.Text) & vbCrLf & txtEnter850ID.Text
        ContinueToolStripMenuItem.Enabled = False
        ActionToolStripMenuItem.Enabled = True
        ResetToolStripMenuItem.Enabled = True
        txtEnterFirstName.Enabled = False
        txtEnterLastName.Enabled = False
        txtEnter850ID.Enabled = False
    End Sub
    Function WholeName(ByRef First As String, ByRef Last As String) As String
        Dim strWholeName As String
        strWholeName = Last & ", " & First
        Return strWholeName
    End Function

    Private Sub AddToScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToScheduleToolStripMenuItem.Click
        If (lstCourses.SelectedIndex = -1) Then
            MessageBox.Show("You must choose a course to add to your schedule.", "Course Add Error")
            Return
        End If
        lstSelectedCourses.Items.Insert(0, lstCourses.SelectedItem)
    End Sub

    Private Sub RemoveFromScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFromScheduleToolStripMenuItem.Click
        If (lstSelectedCourses.SelectedIndex = -1) Then
            MessageBox.Show("You must choose a course to remove from your schedule.", "Course Add Error")
            Return
        End If
        lstSelectedCourses.Items.RemoveAt(lstSelectedCourses.SelectedIndex)
    End Sub

    Private Sub RemoveFromScheduleToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles RemoveFromScheduleToolStripMenuItem.MouseEnter
        RemoveFromScheduleToolStripMenuItem.Text = "This action cannot be reversed"
    End Sub

    Private Sub RemoveFromScheduleToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles RemoveFromScheduleToolStripMenuItem.MouseLeave
        RemoveFromScheduleToolStripMenuItem.Text = "Remove from Schedule"
    End Sub

    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        lstNames.SelectedIndex = lstCourses.SelectedIndex
        lstInstructors.SelectedIndex = lstCourses.SelectedIndex
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblSeconds.Text = intSeconds.ToString()
        intSeconds += 1
    End Sub
End Class
