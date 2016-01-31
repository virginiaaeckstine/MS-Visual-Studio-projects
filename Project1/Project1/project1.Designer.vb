<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject1
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
        Me.txtEnterFirstName = New System.Windows.Forms.TextBox()
        Me.lblEnterLastName = New System.Windows.Forms.Label()
        Me.txtEnterLastName = New System.Windows.Forms.TextBox()
        Me.lblEnterFirstName = New System.Windows.Forms.Label()
        Me.lblEnterainteragerbetween1and0 = New System.Windows.Forms.Label()
        Me.txtEnteranIntegerbetween1and10 = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.LlbEnteradeciaml = New System.Windows.Forms.Label()
        Me.txtEnterAdecimalNumberbetween1and10 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'txtEnterFirstName
        '
        Me.txtEnterFirstName.Location = New System.Drawing.Point(162, 41)
        Me.txtEnterFirstName.Name = "txtEnterFirstName"
        Me.txtEnterFirstName.Size = New System.Drawing.Size(145, 20)
        Me.txtEnterFirstName.TabIndex = 1
        '
        'lblEnterLastName
        '
        Me.lblEnterLastName.AutoSize = true
        Me.lblEnterLastName.Location = New System.Drawing.Point(39, 77)
        Me.lblEnterLastName.Name = "lblEnterLastName"
        Me.lblEnterLastName.Size = New System.Drawing.Size(86, 13)
        Me.lblEnterLastName.TabIndex = 2
        Me.lblEnterLastName.Text = "Enter Last Name"
        '
        'txtEnterLastName
        '
        Me.txtEnterLastName.Location = New System.Drawing.Point(162, 77)
        Me.txtEnterLastName.Name = "txtEnterLastName"
        Me.txtEnterLastName.Size = New System.Drawing.Size(145, 20)
        Me.txtEnterLastName.TabIndex = 3
        '
        'lblEnterFirstName
        '
        Me.lblEnterFirstName.AutoSize = true
        Me.lblEnterFirstName.Location = New System.Drawing.Point(39, 41)
        Me.lblEnterFirstName.Name = "lblEnterFirstName"
        Me.lblEnterFirstName.Size = New System.Drawing.Size(85, 13)
        Me.lblEnterFirstName.TabIndex = 4
        Me.lblEnterFirstName.Text = "Enter First Name"
        '
        'lblEnterainteragerbetween1and0
        '
        Me.lblEnterainteragerbetween1and0.AutoSize = true
        Me.lblEnterainteragerbetween1and0.Location = New System.Drawing.Point(39, 120)
        Me.lblEnterainteragerbetween1and0.Name = "lblEnterainteragerbetween1and0"
        Me.lblEnterainteragerbetween1and0.Size = New System.Drawing.Size(168, 13)
        Me.lblEnterainteragerbetween1and0.TabIndex = 5
        Me.lblEnterainteragerbetween1and0.Text = "Enter A Integer Between 1 and 10"
        '
        'txtEnteranIntegerbetween1and10
        '
        Me.txtEnteranIntegerbetween1and10.Location = New System.Drawing.Point(255, 120)
        Me.txtEnteranIntegerbetween1and10.Name = "txtEnteranIntegerbetween1and10"
        Me.txtEnteranIntegerbetween1and10.Size = New System.Drawing.Size(72, 20)
        Me.txtEnteranIntegerbetween1and10.TabIndex = 6
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(75, 182)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(252, 44)
        Me.btnProcess.TabIndex = 7
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = true
        '
        'lbloutput
        '
        Me.lbloutput.BackColor = System.Drawing.Color.LightYellow
        Me.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloutput.Location = New System.Drawing.Point(44, 246)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(348, 121)
        Me.lbloutput.TabIndex = 8
        '
        'LlbEnteradeciaml
        '
        Me.LlbEnteradeciaml.AutoSize = True
        Me.LlbEnteradeciaml.Location = New System.Drawing.Point(41, 146)
        Me.LlbEnteradeciaml.Name = "LlbEnteradeciaml"
        Me.LlbEnteradeciaml.Size = New System.Drawing.Size(206, 13)
        Me.LlbEnteradeciaml.TabIndex = 9
        Me.LlbEnteradeciaml.Text = "Enter A Decimal Number between 0 and 1"
        '
        'txtEnterAdecimalNumberbetween1and10
        '
        Me.txtEnterAdecimalNumberbetween1and10.Location = New System.Drawing.Point(260, 149)
        Me.txtEnterAdecimalNumberbetween1and10.Name = "txtEnterAdecimalNumberbetween1and10"
        Me.txtEnterAdecimalNumberbetween1and10.Size = New System.Drawing.Size(66, 20)
        Me.txtEnterAdecimalNumberbetween1and10.TabIndex = 10
        '
        'frmProject1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 469)
        Me.Controls.Add(Me.txtEnterAdecimalNumberbetween1and10)
        Me.Controls.Add(Me.LlbEnteradeciaml)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.txtEnteranIntegerbetween1and10)
        Me.Controls.Add(Me.lblEnterainteragerbetween1and0)
        Me.Controls.Add(Me.lblEnterFirstName)
        Me.Controls.Add(Me.txtEnterLastName)
        Me.Controls.Add(Me.lblEnterLastName)
        Me.Controls.Add(Me.txtEnterFirstName)
        Me.Name = "frmProject1"
        Me.Text = "Project 1- Virginia Eckstine"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtEnterFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterLastName As System.Windows.Forms.Label
    Friend WithEvents txtEnterLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterFirstName As System.Windows.Forms.Label
    Friend WithEvents lblEnterainteragerbetween1and0 As System.Windows.Forms.Label
    Friend WithEvents txtEnteranIntegerbetween1and10 As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lbloutput As System.Windows.Forms.Label
    Friend WithEvents LlbEnteradeciaml As System.Windows.Forms.Label
    Friend WithEvents txtEnterAdecimalNumberbetween1and10 As System.Windows.Forms.TextBox

End Class
