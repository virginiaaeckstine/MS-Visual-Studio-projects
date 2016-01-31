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
        Me.lblEnterANumber = New System.Windows.Forms.Label()
        Me.txtEnterANumber = New System.Windows.Forms.TextBox()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.radRemovefromthelist = New System.Windows.Forms.RadioButton()
        Me.radAddtothelist = New System.Windows.Forms.RadioButton()
        Me.grpChooseStatistics = New System.Windows.Forms.GroupBox()
        Me.chkAverage = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnComputerStatistics = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblComputerStats = New System.Windows.Forms.Label()
        Me.lstProcess = New System.Windows.Forms.ListBox()
        Me.grpAction.SuspendLayout()
        Me.grpChooseStatistics.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterANumber
        '
        Me.lblEnterANumber.AutoSize = True
        Me.lblEnterANumber.Location = New System.Drawing.Point(31, 36)
        Me.lblEnterANumber.Name = "lblEnterANumber"
        Me.lblEnterANumber.Size = New System.Drawing.Size(82, 13)
        Me.lblEnterANumber.TabIndex = 0
        Me.lblEnterANumber.Text = "Enter A Number"
        '
        'txtEnterANumber
        '
        Me.txtEnterANumber.Location = New System.Drawing.Point(139, 33)
        Me.txtEnterANumber.Name = "txtEnterANumber"
        Me.txtEnterANumber.Size = New System.Drawing.Size(189, 20)
        Me.txtEnterANumber.TabIndex = 1
        '
        'grpAction
        '
        Me.grpAction.BackColor = System.Drawing.Color.LightYellow
        Me.grpAction.Controls.Add(Me.radRemovefromthelist)
        Me.grpAction.Controls.Add(Me.radAddtothelist)
        Me.grpAction.Location = New System.Drawing.Point(38, 88)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(201, 94)
        Me.grpAction.TabIndex = 2
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "Action"
        '
        'radRemovefromthelist
        '
        Me.radRemovefromthelist.AutoSize = True
        Me.radRemovefromthelist.Location = New System.Drawing.Point(19, 54)
        Me.radRemovefromthelist.Name = "radRemovefromthelist"
        Me.radRemovefromthelist.Size = New System.Drawing.Size(132, 17)
        Me.radRemovefromthelist.TabIndex = 1
        Me.radRemovefromthelist.TabStop = True
        Me.radRemovefromthelist.Text = "Remove From The List"
        Me.radRemovefromthelist.UseVisualStyleBackColor = True
        '
        'radAddtothelist
        '
        Me.radAddtothelist.AutoSize = True
        Me.radAddtothelist.Location = New System.Drawing.Point(19, 19)
        Me.radAddtothelist.Name = "radAddtothelist"
        Me.radAddtothelist.Size = New System.Drawing.Size(97, 17)
        Me.radAddtothelist.TabIndex = 0
        Me.radAddtothelist.TabStop = True
        Me.radAddtothelist.Text = "Add To the List"
        Me.radAddtothelist.UseVisualStyleBackColor = True
        '
        'grpChooseStatistics
        '
        Me.grpChooseStatistics.BackColor = System.Drawing.Color.PaleGreen
        Me.grpChooseStatistics.Controls.Add(Me.chkAverage)
        Me.grpChooseStatistics.Controls.Add(Me.chkMinimum)
        Me.grpChooseStatistics.Controls.Add(Me.chkMaximum)
        Me.grpChooseStatistics.Location = New System.Drawing.Point(44, 245)
        Me.grpChooseStatistics.Name = "grpChooseStatistics"
        Me.grpChooseStatistics.Size = New System.Drawing.Size(194, 97)
        Me.grpChooseStatistics.TabIndex = 3
        Me.grpChooseStatistics.TabStop = False
        Me.grpChooseStatistics.Text = "Choose Statistics"
        '
        'chkAverage
        '
        Me.chkAverage.AutoSize = True
        Me.chkAverage.Location = New System.Drawing.Point(13, 68)
        Me.chkAverage.Name = "chkAverage"
        Me.chkAverage.Size = New System.Drawing.Size(66, 17)
        Me.chkAverage.TabIndex = 2
        Me.chkAverage.Text = "Average"
        Me.chkAverage.UseVisualStyleBackColor = True
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(13, 44)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 1
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(13, 20)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 0
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(318, 117)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(182, 64)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnComputerStatistics
        '
        Me.btnComputerStatistics.Location = New System.Drawing.Point(325, 279)
        Me.btnComputerStatistics.Name = "btnComputerStatistics"
        Me.btnComputerStatistics.Size = New System.Drawing.Size(174, 80)
        Me.btnComputerStatistics.TabIndex = 5
        Me.btnComputerStatistics.Text = "Computer Statistics"
        Me.btnComputerStatistics.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(329, 416)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(169, 34)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblComputerStats
        '
        Me.lblComputerStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComputerStats.Location = New System.Drawing.Point(585, 277)
        Me.lblComputerStats.Name = "lblComputerStats"
        Me.lblComputerStats.Size = New System.Drawing.Size(159, 172)
        Me.lblComputerStats.TabIndex = 8
        '
        'lstProcess
        '
        Me.lstProcess.FormattingEnabled = True
        Me.lstProcess.Location = New System.Drawing.Point(573, 25)
        Me.lstProcess.Name = "lstProcess"
        Me.lstProcess.Size = New System.Drawing.Size(151, 160)
        Me.lstProcess.TabIndex = 7
        '
        'frmProject2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 487)
        Me.Controls.Add(Me.lblComputerStats)
        Me.Controls.Add(Me.lstProcess)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnComputerStatistics)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.grpChooseStatistics)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.txtEnterANumber)
        Me.Controls.Add(Me.lblEnterANumber)
        Me.Name = "frmProject2"
        Me.Text = "Project 2 - Virginia Eckstine"
        Me.grpAction.ResumeLayout(False)
        Me.grpAction.PerformLayout()
        Me.grpChooseStatistics.ResumeLayout(False)
        Me.grpChooseStatistics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterANumber As System.Windows.Forms.Label
    Friend WithEvents txtEnterANumber As System.Windows.Forms.TextBox
    Friend WithEvents grpAction As System.Windows.Forms.GroupBox
    Friend WithEvents radRemovefromthelist As System.Windows.Forms.RadioButton
    Friend WithEvents radAddtothelist As System.Windows.Forms.RadioButton
    Friend WithEvents grpChooseStatistics As System.Windows.Forms.GroupBox
    Friend WithEvents chkAverage As System.Windows.Forms.CheckBox
    Friend WithEvents chkMinimum As System.Windows.Forms.CheckBox
    Friend WithEvents chkMaximum As System.Windows.Forms.CheckBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnComputerStatistics As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblComputerStats As System.Windows.Forms.Label
    Friend WithEvents lstProcess As System.Windows.Forms.ListBox

End Class
