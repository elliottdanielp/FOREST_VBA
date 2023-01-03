<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionHandOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductionHandOff))
        Me.HandoffDataGrid = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseUnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.APHOD = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.HandoffBTN = New System.Windows.Forms.Button()
        Me.HandoffJob = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.YetToHandoff = New System.Windows.Forms.DataGridView()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HandoffDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YetToHandoff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HandoffDataGrid
        '
        Me.HandoffDataGrid.AllowUserToAddRows = False
        Me.HandoffDataGrid.AllowUserToDeleteRows = False
        Me.HandoffDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HandoffDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ReleaseModelNumber, Me.ReleaseScope, Me.ReleaseUnitNote, Me.ReleaseEngineer})
        Me.HandoffDataGrid.Location = New System.Drawing.Point(16, 305)
        Me.HandoffDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HandoffDataGrid.Name = "HandoffDataGrid"
        Me.HandoffDataGrid.ReadOnly = True
        Me.HandoffDataGrid.RowHeadersWidth = 51
        Me.HandoffDataGrid.Size = New System.Drawing.Size(1035, 154)
        Me.HandoffDataGrid.TabIndex = 20
        '
        'UnitID
        '
        Me.UnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.MinimumWidth = 6
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Width = 63
        '
        'ReleaseModelNumber
        '
        Me.ReleaseModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseModelNumber.HeaderText = "Model Number"
        Me.ReleaseModelNumber.MinimumWidth = 6
        Me.ReleaseModelNumber.Name = "ReleaseModelNumber"
        Me.ReleaseModelNumber.ReadOnly = True
        Me.ReleaseModelNumber.Width = 129
        '
        'ReleaseScope
        '
        Me.ReleaseScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseScope.HeaderText = "Scope"
        Me.ReleaseScope.MinimumWidth = 6
        Me.ReleaseScope.Name = "ReleaseScope"
        Me.ReleaseScope.ReadOnly = True
        Me.ReleaseScope.Width = 77
        '
        'ReleaseUnitNote
        '
        Me.ReleaseUnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseUnitNote.HeaderText = "Note"
        Me.ReleaseUnitNote.MinimumWidth = 6
        Me.ReleaseUnitNote.Name = "ReleaseUnitNote"
        Me.ReleaseUnitNote.ReadOnly = True
        Me.ReleaseUnitNote.Width = 67
        '
        'ReleaseEngineer
        '
        Me.ReleaseEngineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ReleaseEngineer.HeaderText = "Engineer"
        Me.ReleaseEngineer.MinimumWidth = 6
        Me.ReleaseEngineer.Name = "ReleaseEngineer"
        Me.ReleaseEngineer.ReadOnly = True
        Me.ReleaseEngineer.Width = 60
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 474)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(480, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 19
        '
        'APHOD
        '
        Me.APHOD.Location = New System.Drawing.Point(789, 473)
        Me.APHOD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.APHOD.Name = "APHOD"
        Me.APHOD.ReadOnly = True
        Me.APHOD.Size = New System.Drawing.Size(132, 22)
        Me.APHOD.TabIndex = 18
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(507, 476)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 21)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Handoff Job"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'HandoffBTN
        '
        Me.HandoffBTN.Location = New System.Drawing.Point(951, 469)
        Me.HandoffBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HandoffBTN.Name = "HandoffBTN"
        Me.HandoffBTN.Size = New System.Drawing.Size(100, 28)
        Me.HandoffBTN.TabIndex = 16
        Me.HandoffBTN.Text = "Handoff"
        Me.HandoffBTN.UseVisualStyleBackColor = True
        '
        'HandoffJob
        '
        Me.HandoffJob.Location = New System.Drawing.Point(628, 473)
        Me.HandoffJob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HandoffJob.Name = "HandoffJob"
        Me.HandoffJob.ReadOnly = True
        Me.HandoffJob.Size = New System.Drawing.Size(132, 22)
        Me.HandoffJob.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 241)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Job Number Selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Yet To Handoff"
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(20, 261)
        Me.JobNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(160, 24)
        Me.JobNumber.TabIndex = 12
        '
        'YetToHandoff
        '
        Me.YetToHandoff.AllowUserToAddRows = False
        Me.YetToHandoff.AllowUserToDeleteRows = False
        Me.YetToHandoff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YetToHandoff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Job, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer})
        Me.YetToHandoff.Location = New System.Drawing.Point(16, 42)
        Me.YetToHandoff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.YetToHandoff.Name = "YetToHandoff"
        Me.YetToHandoff.ReadOnly = True
        Me.YetToHandoff.RowHeadersWidth = 51
        Me.YetToHandoff.Size = New System.Drawing.Size(1035, 185)
        Me.YetToHandoff.TabIndex = 11
        '
        'Job
        '
        Me.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Job.HeaderText = "Unit ID"
        Me.Job.MinimumWidth = 6
        Me.Job.Name = "Job"
        Me.Job.ReadOnly = True
        Me.Job.Width = 65
        '
        'ModelNumber
        '
        Me.ModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelNumber.HeaderText = "Model Number"
        Me.ModelNumber.MinimumWidth = 6
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.ReadOnly = True
        Me.ModelNumber.Width = 129
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Scope.HeaderText = "Scope"
        Me.Scope.MinimumWidth = 6
        Me.Scope.Name = "Scope"
        Me.Scope.ReadOnly = True
        Me.Scope.Width = 77
        '
        'UnitNote
        '
        Me.UnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitNote.HeaderText = "Note"
        Me.UnitNote.MinimumWidth = 6
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.ReadOnly = True
        Me.UnitNote.Width = 67
        '
        'Engineer
        '
        Me.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Engineer.HeaderText = "Engineer"
        Me.Engineer.MinimumWidth = 6
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Width = 60
        '
        'ProductionHandOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 521)
        Me.Controls.Add(Me.HandoffDataGrid)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.APHOD)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.HandoffBTN)
        Me.Controls.Add(Me.HandoffJob)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.YetToHandoff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProductionHandOff"
        Me.Text = "Production Handoff"
        CType(Me.HandoffDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YetToHandoff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HandoffDataGrid As DataGridView
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseScope As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseUnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseEngineer As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents APHOD As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents HandoffBTN As Button
    Friend WithEvents HandoffJob As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents YetToHandoff As DataGridView
    Friend WithEvents Job As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
End Class
