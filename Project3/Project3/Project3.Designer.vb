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
        Me.components = New System.ComponentModel.Container()
        Me.lblEnterFirstName = New System.Windows.Forms.Label()
        Me.txtEnterFirstName = New System.Windows.Forms.TextBox()
        Me.txtEnterLastName = New System.Windows.Forms.TextBox()
        Me.lblEnterLastName = New System.Windows.Forms.Label()
        Me.txtEnter850ID = New System.Windows.Forms.TextBox()
        Me.lblEnter850ID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContinueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNameOutput = New System.Windows.Forms.Label()
        Me.lblPossibleCourses = New System.Windows.Forms.Label()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstInstructors = New System.Windows.Forms.ListBox()
        Me.lblSelectedCourses = New System.Windows.Forms.Label()
        Me.lstSelectedCourses = New System.Windows.Forms.ListBox()
        Me.OpenFileDialogReset = New System.Windows.Forms.OpenFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterFirstName
        '
        Me.lblEnterFirstName.AutoSize = True
        Me.lblEnterFirstName.Location = New System.Drawing.Point(10, 43)
        Me.lblEnterFirstName.Name = "lblEnterFirstName"
        Me.lblEnterFirstName.Size = New System.Drawing.Size(85, 13)
        Me.lblEnterFirstName.TabIndex = 0
        Me.lblEnterFirstName.Text = "Enter First Name"
        '
        'txtEnterFirstName
        '
        Me.txtEnterFirstName.Location = New System.Drawing.Point(102, 42)
        Me.txtEnterFirstName.Name = "txtEnterFirstName"
        Me.txtEnterFirstName.Size = New System.Drawing.Size(106, 20)
        Me.txtEnterFirstName.TabIndex = 1
        '
        'txtEnterLastName
        '
        Me.txtEnterLastName.Location = New System.Drawing.Point(102, 68)
        Me.txtEnterLastName.Name = "txtEnterLastName"
        Me.txtEnterLastName.Size = New System.Drawing.Size(106, 20)
        Me.txtEnterLastName.TabIndex = 3
        '
        'lblEnterLastName
        '
        Me.lblEnterLastName.AutoSize = True
        Me.lblEnterLastName.Location = New System.Drawing.Point(10, 69)
        Me.lblEnterLastName.Name = "lblEnterLastName"
        Me.lblEnterLastName.Size = New System.Drawing.Size(86, 13)
        Me.lblEnterLastName.TabIndex = 2
        Me.lblEnterLastName.Text = "Enter Last Name"
        '
        'txtEnter850ID
        '
        Me.txtEnter850ID.Location = New System.Drawing.Point(102, 94)
        Me.txtEnter850ID.Name = "txtEnter850ID"
        Me.txtEnter850ID.Size = New System.Drawing.Size(106, 20)
        Me.txtEnter850ID.TabIndex = 5
        '
        'lblEnter850ID
        '
        Me.lblEnter850ID.AutoSize = True
        Me.lblEnter850ID.Location = New System.Drawing.Point(10, 95)
        Me.lblEnter850ID.Name = "lblEnter850ID"
        Me.lblEnter850ID.Size = New System.Drawing.Size(67, 13)
        Me.lblEnter850ID.TabIndex = 4
        Me.lblEnter850ID.Text = "Enter 850 ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContinueToolStripMenuItem, Me.ActionToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContinueToolStripMenuItem
        '
        Me.ContinueToolStripMenuItem.Name = "ContinueToolStripMenuItem"
        Me.ContinueToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ContinueToolStripMenuItem.Text = "Continue"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToScheduleToolStripMenuItem, Me.RemoveFromScheduleToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'AddToScheduleToolStripMenuItem
        '
        Me.AddToScheduleToolStripMenuItem.Name = "AddToScheduleToolStripMenuItem"
        Me.AddToScheduleToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AddToScheduleToolStripMenuItem.Text = "Add to Schedule"
        '
        'RemoveFromScheduleToolStripMenuItem
        '
        Me.RemoveFromScheduleToolStripMenuItem.Name = "RemoveFromScheduleToolStripMenuItem"
        Me.RemoveFromScheduleToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RemoveFromScheduleToolStripMenuItem.Text = "Remove from Schedule"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'lblNameOutput
        '
        Me.lblNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNameOutput.Location = New System.Drawing.Point(246, 42)
        Me.lblNameOutput.Name = "lblNameOutput"
        Me.lblNameOutput.Size = New System.Drawing.Size(166, 72)
        Me.lblNameOutput.TabIndex = 7
        Me.lblNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPossibleCourses
        '
        Me.lblPossibleCourses.AutoSize = True
        Me.lblPossibleCourses.Location = New System.Drawing.Point(7, 136)
        Me.lblPossibleCourses.Name = "lblPossibleCourses"
        Me.lblPossibleCourses.Size = New System.Drawing.Size(87, 13)
        Me.lblPossibleCourses.TabIndex = 8
        Me.lblPossibleCourses.Text = "Possible Courses"
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(12, 153)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(93, 69)
        Me.lstCourses.TabIndex = 9
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(111, 153)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(279, 69)
        Me.lstNames.TabIndex = 10
        '
        'lstInstructors
        '
        Me.lstInstructors.FormattingEnabled = True
        Me.lstInstructors.Location = New System.Drawing.Point(396, 153)
        Me.lstInstructors.Name = "lstInstructors"
        Me.lstInstructors.Size = New System.Drawing.Size(143, 69)
        Me.lstInstructors.TabIndex = 11
        '
        'lblSelectedCourses
        '
        Me.lblSelectedCourses.AutoSize = True
        Me.lblSelectedCourses.Location = New System.Drawing.Point(10, 230)
        Me.lblSelectedCourses.Name = "lblSelectedCourses"
        Me.lblSelectedCourses.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedCourses.TabIndex = 12
        Me.lblSelectedCourses.Text = "Selected Courses"
        '
        'lstSelectedCourses
        '
        Me.lstSelectedCourses.FormattingEnabled = True
        Me.lstSelectedCourses.Location = New System.Drawing.Point(13, 246)
        Me.lstSelectedCourses.Name = "lstSelectedCourses"
        Me.lstSelectedCourses.Size = New System.Drawing.Size(80, 69)
        Me.lstSelectedCourses.TabIndex = 13
        '
        'OpenFileDialogReset
        '
        Me.OpenFileDialogReset.FileName = "OpenFileDialog1"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(404, 250)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(0, 13)
        Me.lblSeconds.TabIndex = 14
        '
        'frmProject3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 321)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lstSelectedCourses)
        Me.Controls.Add(Me.lblSelectedCourses)
        Me.Controls.Add(Me.lstInstructors)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.lblPossibleCourses)
        Me.Controls.Add(Me.lblNameOutput)
        Me.Controls.Add(Me.txtEnter850ID)
        Me.Controls.Add(Me.lblEnter850ID)
        Me.Controls.Add(Me.txtEnterLastName)
        Me.Controls.Add(Me.lblEnterLastName)
        Me.Controls.Add(Me.txtEnterFirstName)
        Me.Controls.Add(Me.lblEnterFirstName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProject3"
        Me.Text = "Project 3 - George Schell"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterFirstName As System.Windows.Forms.Label
    Friend WithEvents txtEnterFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterLastName As System.Windows.Forms.Label
    Friend WithEvents txtEnter850ID As System.Windows.Forms.TextBox
    Friend WithEvents lblEnter850ID As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContinueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNameOutput As System.Windows.Forms.Label
    Friend WithEvents lblPossibleCourses As System.Windows.Forms.Label
    Friend WithEvents lstCourses As System.Windows.Forms.ListBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents lstInstructors As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectedCourses As System.Windows.Forms.Label
    Friend WithEvents lstSelectedCourses As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialogReset As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblSeconds As System.Windows.Forms.Label

End Class
