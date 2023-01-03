<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReleaseEngineering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReleaseEngineering))
        Me.YetToRelease = New System.Windows.Forms.DataGridView()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReleaseJob = New System.Windows.Forms.TextBox()
        Me.ReleaseBTN = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EngineeringReleaseDate = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ReleaseDataGrid = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseUnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.YetToRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReleaseDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YetToRelease
        '
        Me.YetToRelease.AllowUserToAddRows = False
        Me.YetToRelease.AllowUserToDeleteRows = False
        Me.YetToRelease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YetToRelease.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Job, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer})
        Me.YetToRelease.Location = New System.Drawing.Point(16, 38)
        Me.YetToRelease.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.YetToRelease.Name = "YetToRelease"
        Me.YetToRelease.ReadOnly = True
        Me.YetToRelease.RowHeadersWidth = 51
        Me.YetToRelease.Size = New System.Drawing.Size(1035, 185)
        Me.YetToRelease.TabIndex = 0
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
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(20, 257)
        Me.JobNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(160, 24)
        Me.JobNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Yet To Release"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 238)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Job Number Selection"
        '
        'ReleaseJob
        '
        Me.ReleaseJob.Location = New System.Drawing.Point(628, 469)
        Me.ReleaseJob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReleaseJob.Name = "ReleaseJob"
        Me.ReleaseJob.ReadOnly = True
        Me.ReleaseJob.Size = New System.Drawing.Size(132, 22)
        Me.ReleaseJob.TabIndex = 4
        '
        'ReleaseBTN
        '
        Me.ReleaseBTN.Location = New System.Drawing.Point(951, 465)
        Me.ReleaseBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReleaseBTN.Name = "ReleaseBTN"
        Me.ReleaseBTN.Size = New System.Drawing.Size(100, 28)
        Me.ReleaseBTN.TabIndex = 5
        Me.ReleaseBTN.Text = "Release"
        Me.ReleaseBTN.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(507, 473)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Release Job"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EngineeringReleaseDate
        '
        Me.EngineeringReleaseDate.Location = New System.Drawing.Point(789, 469)
        Me.EngineeringReleaseDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EngineeringReleaseDate.Name = "EngineeringReleaseDate"
        Me.EngineeringReleaseDate.ReadOnly = True
        Me.EngineeringReleaseDate.Size = New System.Drawing.Size(132, 22)
        Me.EngineeringReleaseDate.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 470)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(480, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 9
        '
        'ReleaseDataGrid
        '
        Me.ReleaseDataGrid.AllowUserToAddRows = False
        Me.ReleaseDataGrid.AllowUserToDeleteRows = False
        Me.ReleaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReleaseDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ReleaseModelNumber, Me.ReleaseScope, Me.ReleaseUnitNote, Me.ReleaseEngineer})
        Me.ReleaseDataGrid.Location = New System.Drawing.Point(16, 302)
        Me.ReleaseDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReleaseDataGrid.Name = "ReleaseDataGrid"
        Me.ReleaseDataGrid.ReadOnly = True
        Me.ReleaseDataGrid.RowHeadersWidth = 51
        Me.ReleaseDataGrid.Size = New System.Drawing.Size(1035, 154)
        Me.ReleaseDataGrid.TabIndex = 10
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
        'ReleaseEngineering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 517)
        Me.Controls.Add(Me.ReleaseDataGrid)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.EngineeringReleaseDate)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ReleaseBTN)
        Me.Controls.Add(Me.ReleaseJob)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.YetToRelease)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReleaseEngineering"
        Me.Text = "ReleaseEngineering"
        CType(Me.YetToRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReleaseDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YetToRelease As DataGridView
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReleaseJob As TextBox
    Friend WithEvents ReleaseBTN As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents EngineeringReleaseDate As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ReleaseDataGrid As DataGridView
    Friend WithEvents Job As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseScope As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseUnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseEngineer As DataGridViewTextBoxColumn
End Class
