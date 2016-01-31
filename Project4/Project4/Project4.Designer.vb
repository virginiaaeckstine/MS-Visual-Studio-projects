<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject4
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialogReset = New System.Windows.Forms.OpenFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblCourses = New System.Windows.Forms.Label()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstInstructors = New System.Windows.Forms.ListBox()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
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
        'OpenFileDialogReset
        '
        Me.OpenFileDialogReset.FileName = "OpenFileDialog1"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'lblCourses
        '
        Me.lblCourses.AutoSize = True
        Me.lblCourses.Location = New System.Drawing.Point(12, 54)
        Me.lblCourses.Name = "lblCourses"
        Me.lblCourses.Size = New System.Drawing.Size(45, 13)
        Me.lblCourses.TabIndex = 1
        Me.lblCourses.Text = "Courses"
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(10, 71)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(89, 82)
        Me.lstCourses.TabIndex = 2
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(115, 71)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(248, 82)
        Me.lstNames.TabIndex = 3
        '
        'lstInstructors
        '
        Me.lstInstructors.FormattingEnabled = True
        Me.lstInstructors.Location = New System.Drawing.Point(379, 71)
        Me.lstInstructors.Name = "lstInstructors"
        Me.lstInstructors.Size = New System.Drawing.Size(127, 82)
        Me.lstInstructors.TabIndex = 4
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(12, 170)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 5
        Me.lblSelected.Text = "Selected"
        '
        'lstSelected
        '
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.Location = New System.Drawing.Point(10, 186)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(89, 82)
        Me.lstSelected.TabIndex = 6
        '
        'lblWarning
        '
        Me.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(143, 189)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(131, 68)
        Me.lblWarning.TabIndex = 7
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProject4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 289)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lstInstructors)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.lblCourses)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmProject4"
        Me.Text = "Project 4"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialogReset As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblCourses As System.Windows.Forms.Label
    Friend WithEvents lstCourses As System.Windows.Forms.ListBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents lstInstructors As System.Windows.Forms.ListBox
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label

End Class
