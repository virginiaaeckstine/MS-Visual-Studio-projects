<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassExample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstProject1 = New System.Windows.Forms.ListBox()
        Me.lstProject2 = New System.Windows.Forms.ListBox()
        Me.lstExam1 = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProject1 = New System.Windows.Forms.Label()
        Me.lblProject2 = New System.Windows.Forms.Label()
        Me.lblExam1 = New System.Windows.Forms.Label()
        Me.lblPossiblePoints = New System.Windows.Forms.Label()
        Me.lblPossiblePointsProject1 = New System.Windows.Forms.Label()
        Me.lblPossiblePointsProject2 = New System.Windows.Forms.Label()
        Me.lblPossiblePointsExam1 = New System.Windows.Forms.Label()
        Me.grpContainer = New System.Windows.Forms.GroupBox()
        Me.lblGradeOutput = New System.Windows.Forms.Label()
        Me.lblExam1Average = New System.Windows.Forms.Label()
        Me.lblProject2Average = New System.Windows.Forms.Label()
        Me.lblProject1Average = New System.Windows.Forms.Label()
        Me.lblAverages = New System.Windows.Forms.Label()
        Me.lblOpeningMessage = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Items.AddRange(New Object() {"Alison, Lane", "Allison, Nigel", "Andrew, Edward", "Ashley, Brooke", "Bradley, Omar", "Brandi, Leigh", "Brian, Curtis", "Bryan, Christopher", "Caleb, Alexander", "Christopher, Andrew", "Daniel, Joseph", "Deloris, Bornjeo", "Derek, Allen", "Edward, Allen", "Ernest, Wallace", "Ethan, William", "Francis, Quoc", "Guillermo, Francisco", "Hilary, Anne", "Jason, Lawrence", "John, Thomas", "Joshua Stuart", "Joshua, Raymond", "Ken, Phi", "Konner, Aiping", "Kyle, Dennis", "Lee, Charles", "Mary, Yan", "Matthew, Braxton", "Nasha, Chanelle", "Nicholas, Brock", "Perry, Hinnesey", "Ryan, Michael", "Timothy, Craig", "William, Bryant", "William, Rahsha"})
        Me.lstName.Location = New System.Drawing.Point(8, 35)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(120, 69)
        Me.lstName.TabIndex = 0
        '
        'lstProject1
        '
        Me.lstProject1.FormattingEnabled = True
        Me.lstProject1.Items.AddRange(New Object() {"15.0", "14.0", "14.0", "15.0", "13.5", "8.5", "14.0", "14.5", "15.0", "14.0", "14.5", "14.5", "15.0", "15.0", "14.5", "14.5", "14.5", "14.5", "15.0", "14.0", "13.5", "14.5", "13.5", "14.5", "15.0", "15.0", "15.0", "15.0", "13.0", "13.0", "15.0", "15.0", "15.0", "15.0", "14.5", "12.0"})
        Me.lstProject1.Location = New System.Drawing.Point(152, 36)
        Me.lstProject1.Name = "lstProject1"
        Me.lstProject1.Size = New System.Drawing.Size(57, 69)
        Me.lstProject1.TabIndex = 1
        '
        'lstProject2
        '
        Me.lstProject2.FormattingEnabled = True
        Me.lstProject2.Items.AddRange(New Object() {"14.5", "14.5", "10.5", "13.0", "15.0", "10.0", "14.5", "15.0", "15.0", "15.0", "15.0", "15.0", "15.0", "15.0", "14.0", "13.5", "15.0", "14.0", "14.5", "14.0", "15.0", "15.0", "15.0", "15.0", "14.5", "15.0", "11.0", "14.5", "13.0", "6.0", "14.5", "15.0", "15.0", "11.5", "15.0", "13.5"})
        Me.lstProject2.Location = New System.Drawing.Point(244, 35)
        Me.lstProject2.Name = "lstProject2"
        Me.lstProject2.Size = New System.Drawing.Size(57, 69)
        Me.lstProject2.TabIndex = 2
        '
        'lstExam1
        '
        Me.lstExam1.FormattingEnabled = True
        Me.lstExam1.Items.AddRange(New Object() {"39.0", "40.0", "42.0", "46.0", "50.0", "40.0", "40.0", "46.0", "43.0", "49.0", "45.0", "39.0", "37.0", "45.0", "36.0", "39.0", "47.0", "43.0", "44.0", "47.0", "40.0", "47.0", "43.0", "39.0", "42.0", "48.0", "34.0", "48.0", "37.0", "40.0", "44.0", "47.0", "38.0", "46.0", "44.0", "36.0"})
        Me.lstExam1.Location = New System.Drawing.Point(336, 36)
        Me.lstExam1.Name = "lstExam1"
        Me.lstExam1.Size = New System.Drawing.Size(57, 69)
        Me.lstExam1.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(5, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(75, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Student Name"
        '
        'lblProject1
        '
        Me.lblProject1.AutoSize = True
        Me.lblProject1.Location = New System.Drawing.Point(149, 19)
        Me.lblProject1.Name = "lblProject1"
        Me.lblProject1.Size = New System.Drawing.Size(49, 13)
        Me.lblProject1.TabIndex = 5
        Me.lblProject1.Text = "Project 1"
        '
        'lblProject2
        '
        Me.lblProject2.AutoSize = True
        Me.lblProject2.Location = New System.Drawing.Point(241, 19)
        Me.lblProject2.Name = "lblProject2"
        Me.lblProject2.Size = New System.Drawing.Size(49, 13)
        Me.lblProject2.TabIndex = 6
        Me.lblProject2.Text = "Project 2"
        '
        'lblExam1
        '
        Me.lblExam1.AutoSize = True
        Me.lblExam1.Location = New System.Drawing.Point(333, 19)
        Me.lblExam1.Name = "lblExam1"
        Me.lblExam1.Size = New System.Drawing.Size(42, 13)
        Me.lblExam1.TabIndex = 7
        Me.lblExam1.Text = "Exam 1"
        '
        'lblPossiblePoints
        '
        Me.lblPossiblePoints.AutoSize = True
        Me.lblPossiblePoints.Location = New System.Drawing.Point(65, 106)
        Me.lblPossiblePoints.Name = "lblPossiblePoints"
        Me.lblPossiblePoints.Size = New System.Drawing.Size(78, 13)
        Me.lblPossiblePoints.TabIndex = 8
        Me.lblPossiblePoints.Text = "Possible Points"
        '
        'lblPossiblePointsProject1
        '
        Me.lblPossiblePointsProject1.AutoSize = True
        Me.lblPossiblePointsProject1.Location = New System.Drawing.Point(149, 106)
        Me.lblPossiblePointsProject1.Name = "lblPossiblePointsProject1"
        Me.lblPossiblePointsProject1.Size = New System.Drawing.Size(28, 13)
        Me.lblPossiblePointsProject1.TabIndex = 9
        Me.lblPossiblePointsProject1.Text = "15.0"
        '
        'lblPossiblePointsProject2
        '
        Me.lblPossiblePointsProject2.AutoSize = True
        Me.lblPossiblePointsProject2.Location = New System.Drawing.Point(241, 106)
        Me.lblPossiblePointsProject2.Name = "lblPossiblePointsProject2"
        Me.lblPossiblePointsProject2.Size = New System.Drawing.Size(28, 13)
        Me.lblPossiblePointsProject2.TabIndex = 10
        Me.lblPossiblePointsProject2.Text = "15.0"
        '
        'lblPossiblePointsExam1
        '
        Me.lblPossiblePointsExam1.AutoSize = True
        Me.lblPossiblePointsExam1.Location = New System.Drawing.Point(333, 106)
        Me.lblPossiblePointsExam1.Name = "lblPossiblePointsExam1"
        Me.lblPossiblePointsExam1.Size = New System.Drawing.Size(28, 13)
        Me.lblPossiblePointsExam1.TabIndex = 11
        Me.lblPossiblePointsExam1.Text = "50.0"
        '
        'grpContainer
        '
        Me.grpContainer.Controls.Add(Me.lblGradeOutput)
        Me.grpContainer.Controls.Add(Me.lblExam1Average)
        Me.grpContainer.Controls.Add(Me.lblProject2Average)
        Me.grpContainer.Controls.Add(Me.lblProject1Average)
        Me.grpContainer.Controls.Add(Me.lblAverages)
        Me.grpContainer.Controls.Add(Me.lstProject1)
        Me.grpContainer.Controls.Add(Me.lblPossiblePointsExam1)
        Me.grpContainer.Controls.Add(Me.lstName)
        Me.grpContainer.Controls.Add(Me.lblPossiblePointsProject2)
        Me.grpContainer.Controls.Add(Me.lstProject2)
        Me.grpContainer.Controls.Add(Me.lblPossiblePointsProject1)
        Me.grpContainer.Controls.Add(Me.lstExam1)
        Me.grpContainer.Controls.Add(Me.lblPossiblePoints)
        Me.grpContainer.Controls.Add(Me.lblName)
        Me.grpContainer.Controls.Add(Me.lblExam1)
        Me.grpContainer.Controls.Add(Me.lblProject1)
        Me.grpContainer.Controls.Add(Me.lblProject2)
        Me.grpContainer.Location = New System.Drawing.Point(45, 91)
        Me.grpContainer.Name = "grpContainer"
        Me.grpContainer.Size = New System.Drawing.Size(409, 213)
        Me.grpContainer.TabIndex = 12
        Me.grpContainer.TabStop = False
        '
        'lblGradeOutput
        '
        Me.lblGradeOutput.Location = New System.Drawing.Point(22, 154)
        Me.lblGradeOutput.Name = "lblGradeOutput"
        Me.lblGradeOutput.Size = New System.Drawing.Size(365, 47)
        Me.lblGradeOutput.TabIndex = 16
        '
        'lblExam1Average
        '
        Me.lblExam1Average.AutoSize = True
        Me.lblExam1Average.Location = New System.Drawing.Point(333, 129)
        Me.lblExam1Average.Name = "lblExam1Average"
        Me.lblExam1Average.Size = New System.Drawing.Size(0, 13)
        Me.lblExam1Average.TabIndex = 15
        '
        'lblProject2Average
        '
        Me.lblProject2Average.AutoSize = True
        Me.lblProject2Average.Location = New System.Drawing.Point(241, 129)
        Me.lblProject2Average.Name = "lblProject2Average"
        Me.lblProject2Average.Size = New System.Drawing.Size(0, 13)
        Me.lblProject2Average.TabIndex = 14
        '
        'lblProject1Average
        '
        Me.lblProject1Average.AutoSize = True
        Me.lblProject1Average.Location = New System.Drawing.Point(149, 129)
        Me.lblProject1Average.Name = "lblProject1Average"
        Me.lblProject1Average.Size = New System.Drawing.Size(0, 13)
        Me.lblProject1Average.TabIndex = 13
        '
        'lblAverages
        '
        Me.lblAverages.AutoSize = True
        Me.lblAverages.Location = New System.Drawing.Point(65, 129)
        Me.lblAverages.Name = "lblAverages"
        Me.lblAverages.Size = New System.Drawing.Size(79, 13)
        Me.lblAverages.TabIndex = 12
        Me.lblAverages.Text = "Average Points"
        '
        'lblOpeningMessage
        '
        Me.lblOpeningMessage.AutoSize = True
        Me.lblOpeningMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningMessage.Location = New System.Drawing.Point(17, 9)
        Me.lblOpeningMessage.Name = "lblOpeningMessage"
        Me.lblOpeningMessage.Size = New System.Drawing.Size(465, 24)
        Me.lblOpeningMessage.TabIndex = 13
        Me.lblOpeningMessage.Text = "Click on any name to display that student's letter grade."
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(116, 39)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(130, 27)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(252, 39)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(130, 27)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmClassExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 316)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblOpeningMessage)
        Me.Controls.Add(Me.grpContainer)
        Me.Name = "frmClassExample"
        Me.Text = "Class Example - March 18"
        Me.grpContainer.ResumeLayout(False)
        Me.grpContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents lstProject1 As System.Windows.Forms.ListBox
    Friend WithEvents lstProject2 As System.Windows.Forms.ListBox
    Friend WithEvents lstExam1 As System.Windows.Forms.ListBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblProject1 As System.Windows.Forms.Label
    Friend WithEvents lblProject2 As System.Windows.Forms.Label
    Friend WithEvents lblExam1 As System.Windows.Forms.Label
    Friend WithEvents lblPossiblePoints As System.Windows.Forms.Label
    Friend WithEvents lblPossiblePointsProject1 As System.Windows.Forms.Label
    Friend WithEvents lblPossiblePointsProject2 As System.Windows.Forms.Label
    Friend WithEvents lblPossiblePointsExam1 As System.Windows.Forms.Label
    Friend WithEvents grpContainer As System.Windows.Forms.GroupBox
    Friend WithEvents lblExam1Average As System.Windows.Forms.Label
    Friend WithEvents lblProject2Average As System.Windows.Forms.Label
    Friend WithEvents lblProject1Average As System.Windows.Forms.Label
    Friend WithEvents lblAverages As System.Windows.Forms.Label
    Friend WithEvents lblOpeningMessage As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblGradeOutput As System.Windows.Forms.Label

End Class
