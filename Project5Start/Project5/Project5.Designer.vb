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
        Me.BusinessMajorsTableAdapter = New Project5.BusinessMajorsDataSetTableAdapters.BusinessMajorsTableAdapter()
        Me.lstAdvisors = New System.Windows.Forms.ListBox()
        Me.lblAllAdvisors = New System.Windows.Forms.Label()
        Me.Select_MIS_MajorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_MIS_MajorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_Class_1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me._ClassToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me._ClassToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Select_Class_1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_JuniorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_JuniorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_Hours_Greater_than_100ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_Hours_Greater_than_100ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_Senior_And_MKTToolStrip = New System.Windows.Forms.ToolStrip()
        Me._ClassToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me._ClassToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.MajorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MajorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Select_Senior_And_MKTToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ResetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Select_Senior_And_MKT1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Select_Senior_And_MKT1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.BusinessMajorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessMajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessMajorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Select_MIS_MajorToolStrip.SuspendLayout()
        Me.Select_Class_1ToolStrip.SuspendLayout()
        Me.Select_JuniorToolStrip.SuspendLayout()
        Me.Select_Hours_Greater_than_100ToolStrip.SuspendLayout()
        Me.Select_Senior_And_MKTToolStrip.SuspendLayout()
        Me.ResetToolStrip.SuspendLayout()
        Me.Select_Senior_And_MKT1ToolStrip.SuspendLayout()
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
        Me.BusinessMajorsDataGridView.Location = New System.Drawing.Point(473, 34)
        Me.BusinessMajorsDataGridView.Name = "BusinessMajorsDataGridView"
        Me.BusinessMajorsDataGridView.ReadOnly = True
        Me.BusinessMajorsDataGridView.Size = New System.Drawing.Size(607, 496)
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
        'BusinessMajorsTableAdapter
        '
        Me.BusinessMajorsTableAdapter.ClearBeforeFill = True
        '
        'lstAdvisors
        '
        Me.lstAdvisors.DataSource = Me.BusinessMajorsBindingSource
        Me.lstAdvisors.DisplayMember = "Advisor"
        Me.lstAdvisors.FormattingEnabled = True
        Me.lstAdvisors.Location = New System.Drawing.Point(22, 324)
        Me.lstAdvisors.Name = "lstAdvisors"
        Me.lstAdvisors.Size = New System.Drawing.Size(211, 160)
        Me.lstAdvisors.TabIndex = 1
        '
        'lblAllAdvisors
        '
        Me.lblAllAdvisors.AutoSize = True
        Me.lblAllAdvisors.Location = New System.Drawing.Point(27, 307)
        Me.lblAllAdvisors.Name = "lblAllAdvisors"
        Me.lblAllAdvisors.Size = New System.Drawing.Size(61, 13)
        Me.lblAllAdvisors.TabIndex = 2
        Me.lblAllAdvisors.Text = "All Advisors"
        '
        'Select_MIS_MajorToolStrip
        '
        Me.Select_MIS_MajorToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_MIS_MajorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_MIS_MajorToolStripButton})
        Me.Select_MIS_MajorToolStrip.Location = New System.Drawing.Point(9, 9)
        Me.Select_MIS_MajorToolStrip.Name = "Select_MIS_MajorToolStrip"
        Me.Select_MIS_MajorToolStrip.Size = New System.Drawing.Size(115, 25)
        Me.Select_MIS_MajorToolStrip.TabIndex = 3
        Me.Select_MIS_MajorToolStrip.Text = "Select_MIS_MajorToolStrip"
        '
        'Select_MIS_MajorToolStripButton
        '
        Me.Select_MIS_MajorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_MIS_MajorToolStripButton.Name = "Select_MIS_MajorToolStripButton"
        Me.Select_MIS_MajorToolStripButton.Size = New System.Drawing.Size(103, 22)
        Me.Select_MIS_MajorToolStripButton.Text = "Select_MIS_Major"
        '
        'Select_Class_1ToolStrip
        '
        Me.Select_Class_1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_Class_1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._ClassToolStripLabel, Me._ClassToolStripTextBox, Me.Select_Class_1ToolStripButton})
        Me.Select_Class_1ToolStrip.Location = New System.Drawing.Point(9, 84)
        Me.Select_Class_1ToolStrip.Name = "Select_Class_1ToolStrip"
        Me.Select_Class_1ToolStrip.Size = New System.Drawing.Size(241, 25)
        Me.Select_Class_1ToolStrip.TabIndex = 4
        Me.Select_Class_1ToolStrip.Text = "Select_Class_1ToolStrip"
        '
        '_ClassToolStripLabel
        '
        Me._ClassToolStripLabel.Name = "_ClassToolStripLabel"
        Me._ClassToolStripLabel.Size = New System.Drawing.Size(42, 22)
        Me._ClassToolStripLabel.Text = "_Class:"
        '
        '_ClassToolStripTextBox
        '
        Me._ClassToolStripTextBox.Name = "_ClassToolStripTextBox"
        Me._ClassToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Select_Class_1ToolStripButton
        '
        Me.Select_Class_1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_Class_1ToolStripButton.Name = "Select_Class_1ToolStripButton"
        Me.Select_Class_1ToolStripButton.Size = New System.Drawing.Size(85, 22)
        Me.Select_Class_1ToolStripButton.Text = "Select_Class_1"
        '
        'Select_JuniorToolStrip
        '
        Me.Select_JuniorToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_JuniorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_JuniorToolStripButton})
        Me.Select_JuniorToolStrip.Location = New System.Drawing.Point(9, 34)
        Me.Select_JuniorToolStrip.Name = "Select_JuniorToolStrip"
        Me.Select_JuniorToolStrip.Size = New System.Drawing.Size(91, 25)
        Me.Select_JuniorToolStrip.TabIndex = 5
        Me.Select_JuniorToolStrip.Text = "Select_JuniorToolStrip"
        '
        'Select_JuniorToolStripButton
        '
        Me.Select_JuniorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_JuniorToolStripButton.Name = "Select_JuniorToolStripButton"
        Me.Select_JuniorToolStripButton.Size = New System.Drawing.Size(79, 22)
        Me.Select_JuniorToolStripButton.Text = "Select_Junior"
        '
        'Select_Hours_Greater_than_100ToolStrip
        '
        Me.Select_Hours_Greater_than_100ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_Hours_Greater_than_100ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_Hours_Greater_than_100ToolStripButton})
        Me.Select_Hours_Greater_than_100ToolStrip.Location = New System.Drawing.Point(9, 59)
        Me.Select_Hours_Greater_than_100ToolStrip.Name = "Select_Hours_Greater_than_100ToolStrip"
        Me.Select_Hours_Greater_than_100ToolStrip.Size = New System.Drawing.Size(186, 25)
        Me.Select_Hours_Greater_than_100ToolStrip.TabIndex = 6
        Me.Select_Hours_Greater_than_100ToolStrip.Text = "Select_Hours_Greater_than_100ToolStrip"
        '
        'Select_Hours_Greater_than_100ToolStripButton
        '
        Me.Select_Hours_Greater_than_100ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_Hours_Greater_than_100ToolStripButton.Name = "Select_Hours_Greater_than_100ToolStripButton"
        Me.Select_Hours_Greater_than_100ToolStripButton.Size = New System.Drawing.Size(174, 22)
        Me.Select_Hours_Greater_than_100ToolStripButton.Text = "Select_Hours_Greater_than_100"
        '
        'Select_Senior_And_MKTToolStrip
        '
        Me.Select_Senior_And_MKTToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_Senior_And_MKTToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._ClassToolStripLabel1, Me._ClassToolStripTextBox1, Me.MajorToolStripLabel, Me.MajorToolStripTextBox, Me.Select_Senior_And_MKTToolStripButton})
        Me.Select_Senior_And_MKTToolStrip.Location = New System.Drawing.Point(9, 134)
        Me.Select_Senior_And_MKTToolStrip.Name = "Select_Senior_And_MKTToolStrip"
        Me.Select_Senior_And_MKTToolStrip.Size = New System.Drawing.Size(427, 25)
        Me.Select_Senior_And_MKTToolStrip.TabIndex = 7
        Me.Select_Senior_And_MKTToolStrip.Text = "Select_Senior_And_MKTToolStrip"
        '
        '_ClassToolStripLabel1
        '
        Me._ClassToolStripLabel1.Name = "_ClassToolStripLabel1"
        Me._ClassToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me._ClassToolStripLabel1.Text = "_Class:"
        '
        '_ClassToolStripTextBox1
        '
        Me._ClassToolStripTextBox1.Name = "_ClassToolStripTextBox1"
        Me._ClassToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'MajorToolStripLabel
        '
        Me.MajorToolStripLabel.Name = "MajorToolStripLabel"
        Me.MajorToolStripLabel.Size = New System.Drawing.Size(41, 22)
        Me.MajorToolStripLabel.Text = "Major:"
        '
        'MajorToolStripTextBox
        '
        Me.MajorToolStripTextBox.Name = "MajorToolStripTextBox"
        Me.MajorToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Select_Senior_And_MKTToolStripButton
        '
        Me.Select_Senior_And_MKTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_Senior_And_MKTToolStripButton.Name = "Select_Senior_And_MKTToolStripButton"
        Me.Select_Senior_And_MKTToolStripButton.Size = New System.Drawing.Size(128, 22)
        Me.Select_Senior_And_MKTToolStripButton.Text = "Select_Class_Or_Major"
        '
        'ResetToolStrip
        '
        Me.ResetToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ResetToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripButton})
        Me.ResetToolStrip.Location = New System.Drawing.Point(9, 159)
        Me.ResetToolStrip.Name = "ResetToolStrip"
        Me.ResetToolStrip.Size = New System.Drawing.Size(51, 25)
        Me.ResetToolStrip.TabIndex = 8
        Me.ResetToolStrip.Text = "ResetToolStrip"
        '
        'ResetToolStripButton
        '
        Me.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetToolStripButton.Name = "ResetToolStripButton"
        Me.ResetToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.ResetToolStripButton.Text = "Reset"
        '
        'Select_Senior_And_MKT1ToolStrip
        '
        Me.Select_Senior_And_MKT1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Select_Senior_And_MKT1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Select_Senior_And_MKT1ToolStripButton})
        Me.Select_Senior_And_MKT1ToolStrip.Location = New System.Drawing.Point(9, 109)
        Me.Select_Senior_And_MKT1ToolStrip.Name = "Select_Senior_And_MKT1ToolStrip"
        Me.Select_Senior_And_MKT1ToolStrip.Size = New System.Drawing.Size(155, 25)
        Me.Select_Senior_And_MKT1ToolStrip.TabIndex = 9
        Me.Select_Senior_And_MKT1ToolStrip.Text = "Select_Senior_And_MKT1ToolStrip"
        '
        'Select_Senior_And_MKT1ToolStripButton
        '
        Me.Select_Senior_And_MKT1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Select_Senior_And_MKT1ToolStripButton.Name = "Select_Senior_And_MKT1ToolStripButton"
        Me.Select_Senior_And_MKT1ToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.Select_Senior_And_MKT1ToolStripButton.Text = "Select_Senior_And_MKT1"
        '
        'frmProject5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 581)
        Me.Controls.Add(Me.Select_Senior_And_MKT1ToolStrip)
        Me.Controls.Add(Me.ResetToolStrip)
        Me.Controls.Add(Me.Select_Senior_And_MKTToolStrip)
        Me.Controls.Add(Me.Select_Hours_Greater_than_100ToolStrip)
        Me.Controls.Add(Me.Select_JuniorToolStrip)
        Me.Controls.Add(Me.Select_Class_1ToolStrip)
        Me.Controls.Add(Me.Select_MIS_MajorToolStrip)
        Me.Controls.Add(Me.lblAllAdvisors)
        Me.Controls.Add(Me.lstAdvisors)
        Me.Controls.Add(Me.BusinessMajorsDataGridView)
        Me.Name = "frmProject5"
        Me.Text = "Project 5"
        CType(Me.BusinessMajorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessMajorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessMajorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Select_MIS_MajorToolStrip.ResumeLayout(False)
        Me.Select_MIS_MajorToolStrip.PerformLayout()
        Me.Select_Class_1ToolStrip.ResumeLayout(False)
        Me.Select_Class_1ToolStrip.PerformLayout()
        Me.Select_JuniorToolStrip.ResumeLayout(False)
        Me.Select_JuniorToolStrip.PerformLayout()
        Me.Select_Hours_Greater_than_100ToolStrip.ResumeLayout(False)
        Me.Select_Hours_Greater_than_100ToolStrip.PerformLayout()
        Me.Select_Senior_And_MKTToolStrip.ResumeLayout(False)
        Me.Select_Senior_And_MKTToolStrip.PerformLayout()
        Me.ResetToolStrip.ResumeLayout(False)
        Me.ResetToolStrip.PerformLayout()
        Me.Select_Senior_And_MKT1ToolStrip.ResumeLayout(False)
        Me.Select_Senior_And_MKT1ToolStrip.PerformLayout()
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
    Friend WithEvents lstAdvisors As System.Windows.Forms.ListBox
    Friend WithEvents lblAllAdvisors As System.Windows.Forms.Label
    Friend WithEvents Select_MIS_MajorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_MIS_MajorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_Class_1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents _ClassToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents _ClassToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Select_Class_1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_JuniorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_JuniorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_Hours_Greater_than_100ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_Hours_Greater_than_100ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_Senior_And_MKTToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents _ClassToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents _ClassToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MajorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MajorToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Select_Senior_And_MKTToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResetToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ResetToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Select_Senior_And_MKT1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Select_Senior_And_MKT1ToolStripButton As System.Windows.Forms.ToolStripButton

End Class
