<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject3
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
        Me.lblClickOnListValue = New System.Windows.Forms.Label()
        Me.lstTemperatures = New System.Windows.Forms.ListBox()
        Me.lblTemperatureOutput = New System.Windows.Forms.Label()
        Me.grpLocationTime = New System.Windows.Forms.GroupBox()
        Me.radContinentalEurope = New System.Windows.Forms.RadioButton()
        Me.radLondon = New System.Windows.Forms.RadioButton()
        Me.lblTimeOutput = New System.Windows.Forms.Label()
        Me.grpLocationTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClickOnListValue
        '
        Me.lblClickOnListValue.Location = New System.Drawing.Point(13, 8)
        Me.lblClickOnListValue.Name = "lblClickOnListValue"
        Me.lblClickOnListValue.Size = New System.Drawing.Size(129, 48)
        Me.lblClickOnListValue.TabIndex = 0
        Me.lblClickOnListValue.Text = "Click On A List Value To See  Temperature Conversions"
        Me.lblClickOnListValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstTemperatures
        '
        Me.lstTemperatures.FormattingEnabled = True
        Me.lstTemperatures.Location = New System.Drawing.Point(35, 56)
        Me.lstTemperatures.Name = "lstTemperatures"
        Me.lstTemperatures.Size = New System.Drawing.Size(85, 95)
        Me.lstTemperatures.TabIndex = 1
        '
        'lblTemperatureOutput
        '
        Me.lblTemperatureOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTemperatureOutput.Location = New System.Drawing.Point(147, 56)
        Me.lblTemperatureOutput.Name = "lblTemperatureOutput"
        Me.lblTemperatureOutput.Size = New System.Drawing.Size(92, 71)
        Me.lblTemperatureOutput.TabIndex = 2
        Me.lblTemperatureOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpLocationTime
        '
        Me.grpLocationTime.Controls.Add(Me.radContinentalEurope)
        Me.grpLocationTime.Controls.Add(Me.radLondon)
        Me.grpLocationTime.Location = New System.Drawing.Point(24, 175)
        Me.grpLocationTime.Name = "grpLocationTime"
        Me.grpLocationTime.Size = New System.Drawing.Size(226, 71)
        Me.grpLocationTime.TabIndex = 3
        Me.grpLocationTime.TabStop = False
        Me.grpLocationTime.Text = "Choose A Location To See Current Time"
        '
        'radContinentalEurope
        '
        Me.radContinentalEurope.AutoSize = True
        Me.radContinentalEurope.Location = New System.Drawing.Point(56, 47)
        Me.radContinentalEurope.Name = "radContinentalEurope"
        Me.radContinentalEurope.Size = New System.Drawing.Size(115, 17)
        Me.radContinentalEurope.TabIndex = 1
        Me.radContinentalEurope.Text = "Continental Europe"
        Me.radContinentalEurope.UseVisualStyleBackColor = True
        '
        'radLondon
        '
        Me.radLondon.AutoSize = True
        Me.radLondon.Checked = True
        Me.radLondon.Location = New System.Drawing.Point(56, 24)
        Me.radLondon.Name = "radLondon"
        Me.radLondon.Size = New System.Drawing.Size(61, 17)
        Me.radLondon.TabIndex = 0
        Me.radLondon.TabStop = True
        Me.radLondon.Text = "London"
        Me.radLondon.UseVisualStyleBackColor = True
        '
        'lblTimeOutput
        '
        Me.lblTimeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeOutput.Location = New System.Drawing.Point(64, 257)
        Me.lblTimeOutput.Name = "lblTimeOutput"
        Me.lblTimeOutput.Size = New System.Drawing.Size(152, 32)
        Me.lblTimeOutput.TabIndex = 4
        Me.lblTimeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProject3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 325)
        Me.Controls.Add(Me.lblTimeOutput)
        Me.Controls.Add(Me.grpLocationTime)
        Me.Controls.Add(Me.lblTemperatureOutput)
        Me.Controls.Add(Me.lstTemperatures)
        Me.Controls.Add(Me.lblClickOnListValue)
        Me.Name = "frmProject3"
        Me.Text = "Project 3"
        Me.grpLocationTime.ResumeLayout(False)
        Me.grpLocationTime.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClickOnListValue As System.Windows.Forms.Label
    Friend WithEvents lstTemperatures As System.Windows.Forms.ListBox
    Friend WithEvents lblTemperatureOutput As System.Windows.Forms.Label
    Friend WithEvents grpLocationTime As System.Windows.Forms.GroupBox
    Friend WithEvents radContinentalEurope As System.Windows.Forms.RadioButton
    Friend WithEvents radLondon As System.Windows.Forms.RadioButton
    Friend WithEvents lblTimeOutput As System.Windows.Forms.Label

End Class
