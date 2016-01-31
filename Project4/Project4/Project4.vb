Public Class frmProject4

    Dim intSeconds As Int32

    Private Sub ResetForm()
        Dim currentRow As String
        lstCourses.Items.Clear()
        Using theCoursesToBeRead As New Microsoft.VisualBasic.FileIO.TextFieldParser("Courses.txt")
            While Not theCoursesToBeRead.EndOfData
                Try

                    currentRow = theCoursesToBeRead.ReadLine
                    lstCourses.Items.Add(currentRow)
                    'lstCourses.Items.Add(currentRow)
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

        ActionToolStripMenuItem.Enabled = True
        ResetToolStripMenuItem.Enabled = True
        lstCourses.SelectedIndex = 0
        lstNames.SelectedIndex = 0
        lstInstructors.SelectedIndex = 0
        lstNames.Enabled = False
        lstInstructors.Enabled = False

        lstSelected.Items.Clear()

        intSeconds = 0

    End Sub

    Private Sub frmProject4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ResetForm()
    End Sub

    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        lstNames.SelectedIndex = lstCourses.SelectedIndex
        lstInstructors.SelectedIndex = lstCourses.SelectedIndex
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
 
    End Sub

    Private Sub AddToScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToScheduleToolStripMenuItem.Click

    End Sub

    Private Sub RemoveFromScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFromScheduleToolStripMenuItem.Click

    End Sub
End Class
