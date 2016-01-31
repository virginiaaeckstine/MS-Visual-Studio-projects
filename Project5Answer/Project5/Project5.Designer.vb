<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject5
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
        Me.BusinessMajorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessMajorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusinessMajorsDataSet = New Project5.BusinessMajorsDataSet()
        Me.Select_MIS_MajorsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_MIS_MajorsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_SeniorsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_SeniorsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_Hours_At_Least_100ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_Hours_At_Least_100ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ResetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BusinessMajorsTableAdapter = New Project5.BusinessMajorsDataSetTableAdapters.BusinessMajorsTableAdapter()
        Me.lblAllMajors = New System.Windows.Forms.Label()
        Me.lstAllMajors = New System.Windows.Forms.ListBox()
        Me.btnCreateUniqueMajors = New System.Windows.Forms.Button()
        Me.lblUniqueMajors = New System.Windows.Forms.Label()
        Me.lstUniqueMajors = New System.Windows.Forms.ListBox()
        CType(Me.BusinessMajorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessMajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessMajorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Select_MIS_MajorsToolStrip.SuspendLayout()
        Me.Select_SeniorsToolStrip.SuspendLayout()
        Me.Select_Hours_At_Least_100ToolStrip.SuspendLayout()
        Me.ResetToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BusinessMajorsDataGridView
        '
        Me.BusinessMajorsDataGridView.AllowUserToAddRows = False
        Me.BusinessMajorsDataGridView.AllowUserToDeleteRows = False
        Me.BusinessMajorsDataGridView.AutoGenerateColumns = False
        Me.BusinessMajorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusinessMajorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.AdvisorDataGridViewTextBoxColumn})
        Me.BusinessMajorsDataGridView.DataSource = Me.BusinessMajorsBindingSource
        Me.BusinessMajorsDataGridView.Location = New System.Drawing.Point(21, 63)
        Me.BusinessMajorsDataGridView.Name = "BusinessMajorsDataGridView"
        Me.BusinessMajorsDataGridView.ReadOnly = True
        Me.BusinessMajorsDataGridView.Size = New System.Drawing.Size(607, 107)
        Me.BusinessMajorsDataGridView.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MajorDataGridViewTextBoxColumn
        '
        Me.MajorDataGridViewTextBoxColumn.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn.Name = "MajorDataGridViewTextBoxColumn"
        Me.MajorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        Me.HoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdvisorDataGridViewTextBoxColumn
        '
        Me.AdvisorDataGridViewTextBoxColumn.DataPropertyName = "Advisor"
        Me.AdvisorDataGridViewTextBoxColumn.HeaderText = "Advisor"
        Me.AdvisorDataGridViewTextBoxColumn.Name = "AdvisorDataGridViewTextBoxColumn"
        Me.AdvisorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BusinessMajorsBindingSource
        '
        Me.BusinessMajorsBindingSource.DataMember = "BusinessMajors"
        Me.BusinessMajorsBindingSource.DataSource = Me.BusinessMajorsDataSet
        '
        'BusinessMajorsDataSet
        '
        Me.BusinessMajorsDataSet.DataSetName = "BusinessMajorsDataSet"
        Me.BusinessMajorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_MIS_MajorsToolStrip
        '
        Me.Select_MIS_MajorsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_MIS_MajorsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_MIS_MajorsToolStripButton})
        Me.Select_MIS_MajorsToolStrip.Location = New System.Drawing.Point(21, 9)
        Me.Select_MIS_MajorsToolStrip.Name = "Select_MIS_MajorsToolStrip"
        Me.Select_MIS_MajorsToolStrip.Size = New System.Drawing.Size(120, 25)
        Me.Select_MIS_MajorsToolStrip.TabIndex = 1
        Me.Select_MIS_MajorsToolStrip.Text = "Select_MIS_MajorsToolStrip"
        '
        'Select_MIS_MajorsToolStripButton
        '
        Me.Select_MIS_MajorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_MIS_MajorsToolStripButton.Name = "Select_MIS_MajorsToolStripButton"
        Me.Select_MIS_MajorsToolStripButton.Size = New System.Drawing.Size(108, 22)
        Me.Select_MIS_MajorsToolStripButton.Text = "Select_MIS_Majors"
        '
        'Select_SeniorsToolStrip
        '
        Me.Select_SeniorsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_SeniorsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_SeniorsToolStripButton})
        Me.Select_SeniorsToolStrip.Location = New System.Drawing.Point(181, 9)
        Me.Select_SeniorsToolStrip.Name = "Select_SeniorsToolStrip"
        Me.Select_SeniorsToolStrip.Size = New System.Drawing.Size(97, 25)
        Me.Select_SeniorsToolStrip.TabIndex = 2
        Me.Select_SeniorsToolStrip.Text = "Select_SeniorsToolStrip"
        '
        'Select_SeniorsToolStripButton
        '
        Me.Select_SeniorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_SeniorsToolStripButton.Name = "Select_SeniorsToolStripButton"
        Me.Select_SeniorsToolStripButton.Size = New System.Drawing.Size(85, 22)
        Me.Select_SeniorsToolStripButton.Text = "Select_Seniors"
        '
        'Select_Hours_At_Least_100ToolStrip
        '
        Me.Select_Hours_At_Least_100ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_Hours_At_Least_100ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_Hours_At_Least_100ToolStripButton})
        Me.Select_Hours_At_Least_100ToolStrip.Location = New System.Drawing.Point(316, 9)
        Me.Select_Hours_At_Least_100ToolStrip.Name = "Select_Hours_At_Least_100ToolStrip"
        Me.Select_Hours_At_Least_100ToolStrip.Size = New System.Drawing.Size(163, 25)
        Me.Select_Hours_At_Least_100ToolStrip.TabIndex = 3
        Me.Select_Hours_At_Least_100ToolStrip.Text = "Select_Hours_At_Least_100ToolStrip"
        '
        'Select_Hours_At_Least_100ToolStripButton
        '
        Me.Select_Hours_At_Least_100ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_Hours_At_Least_100ToolStripButton.Name = "Select_Hours_At_Least_100ToolStripButton"
        Me.Select_Hours_At_Least_100ToolStripButton.Size = New System.Drawing.Size(151, 22)
        Me.Select_Hours_At_Least_100ToolStripButton.Text = "Select_Hours_At_Least_100"
        '
        'ResetToolStrip
        '
        Me.ResetToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ResetToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripButton})
        Me.ResetToolStrip.Location = New System.Drawing.Point(511, 9)
        Me.ResetToolStrip.Name = "ResetToolStrip"
        Me.ResetToolStrip.Size = New System.Drawing.Size(51, 25)
        Me.ResetToolStrip.TabIndex = 4
        Me.ResetToolStrip.Text = "ResetToolStrip"
        '
        'ResetToolStripButton
        '
        Me.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetToolStripButton.Name = "ResetToolStripButton"
        Me.ResetToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.ResetToolStripButton.Text = "Reset"
        '
        'BusinessMajorsTableAdapter
        '
        Me.BusinessMajorsTableAdapter.ClearBeforeFill = True
        '
        'lblAllMajors
        '
        Me.lblAllMajors.AutoSize = True
        Me.lblAllMajors.Location = New System.Drawing.Point(22, 194)
        Me.lblAllMajors.Name = "lblAllMajors"
        Me.lblAllMajors.Size = New System.Drawing.Size(52, 13)
        Me.lblAllMajors.TabIndex = 5
        Me.lblAllMajors.Text = "All Majors"
        '
        'lstAllMajors
        '
        Me.lstAllMajors.DataSource = Me.BusinessMajorsBindingSource
        Me.lstAllMajors.DisplayMember = "Major"
        Me.lstAllMajors.FormattingEnabled = True
        Me.lstAllMajors.Location = New System.Drawing.Point(23, 209)
        Me.lstAllMajors.Name = "lstAllMajors"
        Me.lstAllMajors.Size = New System.Drawing.Size(69, 108)
        Me.lstAllMajors.TabIndex = 6
        '
        'btnCreateUniqueMajors
        '
        Me.btnCreateUniqueMajors.Location = New System.Drawing.Point(111, 231)
        Me.btnCreateUniqueMajors.Name = "btnCreateUniqueMajors"
        Me.btnCreateUniqueMajors.Size = New System.Drawing.Size(106, 68)
        Me.btnCreateUniqueMajors.TabIndex = 8
        Me.btnCreateUniqueMajors.Text = "Create Unique Majors"
        Me.btnCreateUniqueMajors.UseVisualStyleBackColor = True
        '
        'lblUniqueMajors
        '
        Me.lblUniqueMajors.AutoSize = True
        Me.lblUniqueMajors.Location = New System.Drawing.Point(234, 194)
        Me.lblUniqueMajors.Name = "lblUniqueMajors"
        Me.lblUniqueMajors.Size = New System.Drawing.Size(75, 13)
        Me.lblUniqueMajors.TabIndex = 9
        Me.lblUniqueMajors.Text = "Unique Majors"
        '
        'lstUniqueMajors
        '
        Me.lstUniqueMajors.FormattingEnabled = True
        Me.lstUniqueMajors.Location = New System.Drawing.Point(236, 209)
        Me.lstUniqueMajors.Margin = New System.Windows.Forms.Padding(2)
        Me.lstUniqueMajors.Name = "lstUniqueMajors"
        Me.lstUniqueMajors.Size = New System.Drawing.Size(69, 108)
        Me.lstUniqueMajors.TabIndex = 10
        '
        'frmProject5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 334)
        Me.Controls.Add(Me.lstUniqueMajors)
        Me.Controls.Add(Me.lblUniqueMajors)
        Me.Controls.Add(Me.btnCreateUniqueMajors)
        Me.Controls.Add(Me.lstAllMajors)
        Me.Controls.Add(Me.lblAllMajors)
        Me.Controls.Add(Me.ResetToolStrip)
        Me.Controls.Add(Me.Select_Hours_At_Least_100ToolStrip)
        Me.Controls.Add(Me.Select_SeniorsToolStrip)
        Me.Controls.Add(Me.Select_MIS_MajorsToolStrip)
        Me.Controls.Add(Me.BusinessMajorsDataGridView)
        Me.Name = "frmProject5"
        Me.Text = "Project 5"
        CType(Me.BusinessMajorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessMajorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessMajorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Select_MIS_MajorsToolStrip.ResumeLayout(False)
        Me.Select_MIS_MajorsToolStrip.PerformLayout()
        Me.Select_SeniorsToolStrip.ResumeLayout(False)
        Me.Select_SeniorsToolStrip.PerformLayout()
        Me.Select_Hours_At_Least_100ToolStrip.ResumeLayout(False)
        Me.Select_Hours_At_Least_100ToolStrip.PerformLayout()
        Me.ResetToolStrip.ResumeLayout(False)
        Me.ResetToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BusinessMajorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BusinessMajorsDataSet As Project5.BusinessMajorsDataSet
    Friend WithEvents BusinessMajorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusinessMajorsTableAdapter As Project5.BusinessMajorsDataSetTableAdapters.BusinessMajorsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdvisorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Select_MIS_MajorsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_MIS_MajorsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_SeniorsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_SeniorsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_Hours_At_Least_100ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_Hours_At_Least_100ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResetToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ResetToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblAllMajors As System.Windows.Forms.Label
    Friend WithEvents lstAllMajors As System.Windows.Forms.ListBox
    Friend WithEvents btnCreateUniqueMajors As System.Windows.Forms.Button
    Friend WithEvents lblUniqueMajors As System.Windows.Forms.Label
    Friend WithEvents lstUniqueMajors As System.Windows.Forms.ListBox

End Class
