Public Class frmProject2

    Private Sub frmProject2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ResetForm()
        lstListOfNames.Items.Clear()
        lstListOfNames.Items.Add("Anderson")
        lstListOfNames.Items.Add("Cierra")
        lstListOfNames.Items.Add("Lina")
        lstListOfNames.Items.Add("Anne")
        lstListOfNames.Items.Add("Jose")
        txtEnterAName.Text = String.Empty
        txtEnterAName.BackColor = Color.White
        lblOutput.Text = String.Empty
        lblEnterAName.Enabled = False
        txtEnterAName.Enabled = False
        btnContinue.Enabled = False
    End Sub

    Private Sub txtEnterAName_Enter(sender As Object, e As EventArgs) Handles txtEnterAName.Enter
        txtEnterAName.BackColor = Color.Yellow
    End Sub


    Private Sub txtEnterAName_Leave(sender As Object, e As EventArgs) Handles txtEnterAName.Leave
        txtEnterAName.BackColor = Color.White
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ResetForm()
    End Sub

    Private Sub StatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem.Click
        lblOutput.Text = lstListOfNames.Items.Count.ToString()
        If (lstListOfNames.Items.Count = 0) Then
            MessageBox.Show("Listbox must contain a Name", "Error - No name")
            Return
        End If
        Dim intShortest, intLongest As Int32
        lstListOfNames.SelectedIndex = 0
        intLongest = Len(lstListOfNames.SelectedItem)
        intShortest = Len(lstListOfNames.SelectedItem)
        Dim intCounter As Int32
        Dim strCurrentString As String
        For intCounter = 0 To lstListOfNames.Items.Count = 1
            strCurrentString = lstListOfNames.Items(intCounter)
            If (strCurrentString.Length > intLongest) Then
                intLongest = strCurrentString.Length
            End If
            If (strCurrentString.Length < intShortest) Then
                intShortest = strCurrentString.Length
            End If
        Next
        lblOutput.Text += vbCrLf & "Longest Name(s)" & vbCrLf
        For intCounter = 0 To lstListOfNames.Items.Count - 1
            lstListOfNames.SelectedIndex = intCounter
            If (Len(lstListOfNames.SelectedItem) = intLongest) Then
                lblOutput.Text += "  " & lstListOfNames.SelectedItem.ToString & vbCrLf
            End If
        Next
        lblOutput.Text += vbCrLf & "Shortest Name(s)" & vbCrLf
        For intCounter = 0 To lstListOfNames.Items.Count - 1
            lstListOfNames.SelectedIndex = intCounter
            If (Len(lstListOfNames.SelectedItem) = intShortest) Then
                lblOutput.Text += "  " & lstListOfNames.SelectedItem.ToString & vbCrLf
            End If
        Next
    End Sub

    Private Sub SortTheListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortTheListToolStripMenuItem.Click
        lstListOfNames.Sorted = True
        lstListOfNames.Sorted = False
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        lblEnterAName.Enabled = True
        txtEnterAName.Enabled = True
        btnContinue.Enabled = True
        mnuMenuStrip.Enabled = False
        txtEnterAName.Focus()
    End Sub
    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If (lstListOfNames.SelectedIndex = -1) Then
            MessageBox.Show("Name has not been selected", "error")
            Return
        End If
        lstListOfNames.Items.RemoveAt(lstListOfNames.SelectedIndex)
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (txtEnterAName.Text = String.Empty) Then
            MessageBox.Show("You must enter a name for the lsit", "Error- Needs A Name")
            txtEnterAName.Focus()
            Return
        End If
        Dim intCounter As Int32
        Dim bolMatch As Boolean
        bolMatch = False
        For intCounter = 0 To lstListOfNames.Items.Count - 1
            lstListOfNames.SelectedIndex = intCounter
            If (txtEnterAName.Text.ToLower = lstListOfNames.SelectedItem.ToString.ToLower) Then
                bolMatch = True
            End If
        Next
        If (bolMatch) Then
            If (MessageBox.Show("That Name is already in the listbox, do you want to add it anyway?", "warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                lstListOfNames.Items.Add(txtEnterAName.Text.ToString)
            End If
        Else
            lstListOfNames.Items.Add(txtEnterAName.Text.ToString)
            txtEnterAName.Text = String.Empty
            lblListOfNames.Enabled = False
            txtEnterAName.Enabled = False
            btnContinue.Enabled = False
            mnuMenuStrip.Enabled = True
        End If

    End Sub

   
    Private Sub txtEnterAName_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEnterAName_TextChanged(sender As Object, e As EventArgs)
        txtEnterAName.BackColor = Color.Yellow
    End Sub

    Private Sub txtEnterAName_MouseLeave(sender As Object, e As EventArgs)
        txtEnterAName.BackColor = Color.White
    End Sub
End Class
