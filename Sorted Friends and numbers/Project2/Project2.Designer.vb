<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject2
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
        Me.lblAddAName = New System.Windows.Forms.Label()
        Me.txtAddAName = New System.Windows.Forms.TextBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnAddNameToList = New System.Windows.Forms.Button()
        Me.btnRemoveNameFromList = New System.Windows.Forms.Button()
        Me.lblAddANumberToBeIncluded = New System.Windows.Forms.Label()
        Me.txtAddANumberToBeIncluded = New System.Windows.Forms.TextBox()
        Me.btnComputeStatistics = New System.Windows.Forms.Button()
        Me.lblStatisticsOutput = New System.Windows.Forms.Label()
        Me.btnResetTheForm = New System.Windows.Forms.Button()
        Me.btnSortTheListNames = New System.Windows.Forms.Button()
        Me.btnAddTheNumberToTheArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAddAName
        '
        Me.lblAddAName.AutoSize = True
        Me.lblAddAName.Location = New System.Drawing.Point(0, 9)
        Me.lblAddAName.Name = "lblAddAName"
        Me.lblAddAName.Size = New System.Drawing.Size(123, 13)
        Me.lblAddAName.TabIndex = 0
        Me.lblAddAName.Text = "Add A Name Of A Friend"
        '
        'txtAddAName
        '
        Me.txtAddAName.Location = New System.Drawing.Point(129, 5)
        Me.txtAddAName.Name = "txtAddAName"
        Me.txtAddAName.Size = New System.Drawing.Size(133, 20)
        Me.txtAddAName.TabIndex = 1
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(284, 6)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(81, 121)
        Me.lstNames.TabIndex = 2
        '
        'btnAddNameToList
        '
        Me.btnAddNameToList.Location = New System.Drawing.Point(129, 33)
        Me.btnAddNameToList.Name = "btnAddNameToList"
        Me.btnAddNameToList.Size = New System.Drawing.Size(132, 32)
        Me.btnAddNameToList.TabIndex = 3
        Me.btnAddNameToList.Text = "Add Name To List"
        Me.btnAddNameToList.UseVisualStyleBackColor = True
        '
        'btnRemoveNameFromList
        '
        Me.btnRemoveNameFromList.Location = New System.Drawing.Point(129, 73)
        Me.btnRemoveNameFromList.Name = "btnRemoveNameFromList"
        Me.btnRemoveNameFromList.Size = New System.Drawing.Size(133, 32)
        Me.btnRemoveNameFromList.TabIndex = 4
        Me.btnRemoveNameFromList.Text = "Remove Name From List"
        Me.btnRemoveNameFromList.UseVisualStyleBackColor = True
        '
        'lblAddANumberToBeIncluded
        '
        Me.lblAddANumberToBeIncluded.AutoSize = True
        Me.lblAddANumberToBeIncluded.Location = New System.Drawing.Point(11, 160)
        Me.lblAddANumberToBeIncluded.Name = "lblAddANumberToBeIncluded"
        Me.lblAddANumberToBeIncluded.Size = New System.Drawing.Size(152, 13)
        Me.lblAddANumberToBeIncluded.TabIndex = 5
        Me.lblAddANumberToBeIncluded.Text = "Add A Number To Be Included"
        '
        'txtAddANumberToBeIncluded
        '
        Me.txtAddANumberToBeIncluded.Location = New System.Drawing.Point(169, 156)
        Me.txtAddANumberToBeIncluded.Name = "txtAddANumberToBeIncluded"
        Me.txtAddANumberToBeIncluded.Size = New System.Drawing.Size(132, 20)
        Me.txtAddANumberToBeIncluded.TabIndex = 6
        '
        'btnComputeStatistics
        '
        Me.btnComputeStatistics.Location = New System.Drawing.Point(53, 256)
        Me.btnComputeStatistics.Name = "btnComputeStatistics"
        Me.btnComputeStatistics.Size = New System.Drawing.Size(132, 35)
        Me.btnComputeStatistics.TabIndex = 7
        Me.btnComputeStatistics.Text = "Compute Statistics"
        Me.btnComputeStatistics.UseVisualStyleBackColor = True
        '
        'lblStatisticsOutput
        '
        Me.lblStatisticsOutput.BackColor = System.Drawing.Color.LightGreen
        Me.lblStatisticsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatisticsOutput.Location = New System.Drawing.Point(201, 256)
        Me.lblStatisticsOutput.Name = "lblStatisticsOutput"
        Me.lblStatisticsOutput.Size = New System.Drawing.Size(164, 111)
        Me.lblStatisticsOutput.TabIndex = 8
        '
        'btnResetTheForm
        '
        Me.btnResetTheForm.Location = New System.Drawing.Point(3, 380)
        Me.btnResetTheForm.Name = "btnResetTheForm"
        Me.btnResetTheForm.Size = New System.Drawing.Size(372, 31)
        Me.btnResetTheForm.TabIndex = 9
        Me.btnResetTheForm.Text = "&Reset The Form"
        Me.btnResetTheForm.UseVisualStyleBackColor = True
        '
        'btnSortTheListNames
        '
        Me.btnSortTheListNames.Location = New System.Drawing.Point(128, 111)
        Me.btnSortTheListNames.Name = "btnSortTheListNames"
        Me.btnSortTheListNames.Size = New System.Drawing.Size(133, 32)
        Me.btnSortTheListNames.TabIndex = 10
        Me.btnSortTheListNames.Text = "Sort The List Names"
        Me.btnSortTheListNames.UseVisualStyleBackColor = True
        '
        'btnAddTheNumberToTheArray
        '
        Me.btnAddTheNumberToTheArray.Location = New System.Drawing.Point(169, 182)
        Me.btnAddTheNumberToTheArray.Name = "btnAddTheNumberToTheArray"
        Me.btnAddTheNumberToTheArray.Size = New System.Drawing.Size(132, 44)
        Me.btnAddTheNumberToTheArray.TabIndex = 11
        Me.btnAddTheNumberToTheArray.Text = "Add Number To The Array"
        Me.btnAddTheNumberToTheArray.UseVisualStyleBackColor = True
        '
        'frmProject2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 423)
        Me.Controls.Add(Me.btnAddTheNumberToTheArray)
        Me.Controls.Add(Me.btnSortTheListNames)
        Me.Controls.Add(Me.btnResetTheForm)
        Me.Controls.Add(Me.lblStatisticsOutput)
        Me.Controls.Add(Me.btnComputeStatistics)
        Me.Controls.Add(Me.txtAddANumberToBeIncluded)
        Me.Controls.Add(Me.lblAddANumberToBeIncluded)
        Me.Controls.Add(Me.btnRemoveNameFromList)
        Me.Controls.Add(Me.btnAddNameToList)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.txtAddAName)
        Me.Controls.Add(Me.lblAddAName)
        Me.Name = "frmProject2"
        Me.Text = "Project 2 - Virginia Eckstine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddAName As System.Windows.Forms.Label
    Friend WithEvents txtAddAName As System.Windows.Forms.TextBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNameToList As System.Windows.Forms.Button
    Friend WithEvents btnRemoveNameFromList As System.Windows.Forms.Button
    Friend WithEvents lblAddANumberToBeIncluded As System.Windows.Forms.Label
    Friend WithEvents txtAddANumberToBeIncluded As System.Windows.Forms.TextBox
    Friend WithEvents btnComputeStatistics As System.Windows.Forms.Button
    Friend WithEvents lblStatisticsOutput As System.Windows.Forms.Label
    Friend WithEvents btnResetTheForm As System.Windows.Forms.Button
    Friend WithEvents btnSortTheListNames As System.Windows.Forms.Button
    Friend WithEvents btnAddTheNumberToTheArray As System.Windows.Forms.Button

End Class
