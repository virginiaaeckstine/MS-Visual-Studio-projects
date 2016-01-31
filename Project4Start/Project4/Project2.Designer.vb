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
        Me.lblListOfNames = New System.Windows.Forms.Label()
        Me.lstListOfNames = New System.Windows.Forms.ListBox()
        Me.lblEnterAName = New System.Windows.Forms.Label()
        Me.txtEnterAName = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ListboxActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortTheListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblListOfNames
        '
        Me.lblListOfNames.AutoSize = True
        Me.lblListOfNames.Location = New System.Drawing.Point(12, 76)
        Me.lblListOfNames.Name = "lblListOfNames"
        Me.lblListOfNames.Size = New System.Drawing.Size(71, 13)
        Me.lblListOfNames.TabIndex = 0
        Me.lblListOfNames.Text = "List of Names"
        '
        'lstListOfNames
        '
        Me.lstListOfNames.FormattingEnabled = True
        Me.lstListOfNames.Location = New System.Drawing.Point(11, 92)
        Me.lstListOfNames.Name = "lstListOfNames"
        Me.lstListOfNames.Size = New System.Drawing.Size(97, 173)
        Me.lstListOfNames.TabIndex = 1
        '
        'lblEnterAName
        '
        Me.lblEnterAName.AutoSize = True
        Me.lblEnterAName.Location = New System.Drawing.Point(129, 78)
        Me.lblEnterAName.Name = "lblEnterAName"
        Me.lblEnterAName.Size = New System.Drawing.Size(72, 13)
        Me.lblEnterAName.TabIndex = 2
        Me.lblEnterAName.Text = "Enter a Name"
        '
        'txtEnterAName
        '
        Me.txtEnterAName.Location = New System.Drawing.Point(132, 94)
        Me.txtEnterAName.Name = "txtEnterAName"
        Me.txtEnterAName.Size = New System.Drawing.Size(116, 20)
        Me.txtEnterAName.TabIndex = 3
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(132, 120)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(116, 20)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(291, 92)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(138, 173)
        Me.lblOutput.TabIndex = 5
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListboxActionsToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(448, 24)
        Me.mnuMenuStrip.TabIndex = 6
        '
        'ListboxActionsToolStripMenuItem
        '
        Me.ListboxActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatisticsToolStripMenuItem, Me.SortTheListToolStripMenuItem, Me.NameToolStripMenuItem})
        Me.ListboxActionsToolStripMenuItem.Name = "ListboxActionsToolStripMenuItem"
        Me.ListboxActionsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ListboxActionsToolStripMenuItem.Text = "Listbox Actions"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'SortTheListToolStripMenuItem
        '
        Me.SortTheListToolStripMenuItem.Name = "SortTheListToolStripMenuItem"
        Me.SortTheListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SortTheListToolStripMenuItem.Text = "Sort the list"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'frmProject2
        '
        Me.AcceptButton = Me.btnContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 284)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtEnterAName)
        Me.Controls.Add(Me.lblEnterAName)
        Me.Controls.Add(Me.lstListOfNames)
        Me.Controls.Add(Me.lblListOfNames)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmProject2"
        Me.Text = "Project 4"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblListOfNames As System.Windows.Forms.Label
    Friend WithEvents lstListOfNames As System.Windows.Forms.ListBox
    Friend WithEvents lblEnterAName As System.Windows.Forms.Label
    Friend WithEvents txtEnterAName As System.Windows.Forms.TextBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents mnuMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ListboxActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortTheListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
