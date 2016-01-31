Public Class frmProject1


    Private Sub frmproject1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEnterFirstName.Focus()

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If (txtEnterFirstName.Text = String.Empty) Then
            MessageBox.Show("You Must Enter A First Name", "First Name Error")
            txtEnterFirstName.Focus()
            Return
        End If
        If (txtEnterLastName.Text = String.Empty) Then
            MessageBox.Show("You Must Enter a Last Name", "Last Name Error")
            txtEnterLastName.Focus()
            Return
        End If
        Dim intEnteredInteger As Int32
        Try
            intEnteredInteger = CType(txtEnteranIntegerbetween1and10.Text, Int32)
        Catch ex As Exception
            MessageBox.Show("You Must Enter an integer between 1 and 10", "Integer Entered Error")
            txtEnteranIntegerbetween1and10.Text = String.Empty
            txtEnteranIntegerbetween1and10.Focus()
            Return
        End Try
        If (intEnteredInteger < 1) Then
            MessageBox.Show("You Must Enter an integer between 1 and 10", "Integer Entered Error")
            txtEnteranIntegerbetween1and10.Text = String.Empty
            txtEnteranIntegerbetween1and10.Focus()
            Return
        End If
        If (intEnteredInteger > 10) Then
            MessageBox.Show("You Must Enter an integer between 1 and 10", "Integer Entered Error")
            txtEnteranIntegerbetween1and10.Text = String.Empty
            txtEnteranIntegerbetween1and10.Focus()
            Return
        End If
        Dim dblEnteredDecimalNumber As Double
        Try
            dblEnteredDecimalNumber = CType(txtEnterAdecimalNumberbetween1and10.Text, Double)
        Catch ex As Exception
            MessageBox.Show("Must Enter a decimal Number between 0 and 1", "Decimal Number Error")
            txtEnterAdecimalNumberbetween1and10.Text = String.Empty
            txtEnterAdecimalNumberbetween1and10.Focus()
            Return
        End Try
        If (dblEnteredDecimalNumber < 0) Then
            MessageBox.Show("You Must Enter an integer between 1 and 10", "Integer Entered Error")
            txtEnteranIntegerbetween1and10.Text = String.Empty
            txtEnteranIntegerbetween1and10.Focus()
            Return
        End If
        If (dblEnteredDecimalNumber > 1) Then
            MessageBox.Show("You Must Enter an integer between 1 and 10", "Integer Entered Error")
            txtEnteranIntegerbetween1and10.Text = String.Empty
            txtEnteranIntegerbetween1and10.Focus()
            Return
        End If
        Dim dteNow As Date
        dteNow = Now
        lbloutput.Text = dteNow.ToLongDateString & vbCrLf
        lbloutput.Text += "Full name is " & txtEnterLastName.Text & ", " & txtEnterFirstName.Text & vbCrLf
        lbloutput.Text += "Initials are " & txtEnterFirstName.Text.Substring(0, 1) & txtEnterLastName.Text.Substring(0, 1) & vbCrLf
        Dim dblproduct As Double
        dblproduct = intEnteredInteger * dblEnteredDecimalNumber
        lbloutput.Text += "The product of multiplying the integer and the decimal number is " & dblproduct.ToString("N3")

    End Sub


End Class
