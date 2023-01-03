<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionComplete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductionComplete))
        Me.CompleteDataGrid = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.APCD = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CompleteBTN = New System.Windows.Forms.Button()
        Me.CompleteJob = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.YetToComplete = New System.Windows.Forms.DataGridView()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseUnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompleteUnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CompleteDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YetToComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompleteDataGrid
        '
        Me.CompleteDataGrid.AllowUserToAddRows = False
        Me.CompleteDataGrid.AllowUserToDeleteRows = False
        Me.CompleteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompleteDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ReleaseModelNumber, Me.ReleaseScope, Me.ReleaseUnitNote, Me.ReleaseEngineer, Me.CompleteUnitLocation})
        Me.CompleteDataGrid.Location = New System.Drawing.Point(12, 248)
        Me.CompleteDataGrid.Name = "CompleteDataGrid"
        Me.CompleteDataGrid.ReadOnly = True
        Me.CompleteDataGrid.RowHeadersWidth = 51
        Me.CompleteDataGrid.Size = New System.Drawing.Size(829, 125)
        Me.CompleteDataGrid.TabIndex = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 389)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(353, 19)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 29
        '
        'APCD
        '
        Me.APCD.Location = New System.Drawing.Point(645, 388)
        Me.APCD.Name = "APCD"
        Me.APCD.ReadOnly = True
        Me.APCD.Size = New System.Drawing.Size(100, 20)
        Me.APCD.TabIndex = 28
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(385, 391)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Production Complete"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CompleteBTN
        '
        Me.CompleteBTN.Location = New System.Drawing.Point(766, 385)
        Me.CompleteBTN.Name = "CompleteBTN"
        Me.CompleteBTN.Size = New System.Drawing.Size(75, 23)
        Me.CompleteBTN.TabIndex = 26
        Me.CompleteBTN.Text = "Complete"
        Me.CompleteBTN.UseVisualStyleBackColor = True
        '
        'CompleteJob
        '
        Me.CompleteJob.Location = New System.Drawing.Point(524, 388)
        Me.CompleteJob.Name = "CompleteJob"
        Me.CompleteJob.ReadOnly = True
        Me.CompleteJob.Size = New System.Drawing.Size(100, 20)
        Me.CompleteJob.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Job Number Selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Yet To Be Completed"
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(15, 212)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(121, 21)
        Me.JobNumber.TabIndex = 22
        '
        'YetToComplete
        '
        Me.YetToComplete.AllowUserToAddRows = False
        Me.YetToComplete.AllowUserToDeleteRows = False
        Me.YetToComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YetToComplete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Job, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer, Me.UnitLocation})
        Me.YetToComplete.Location = New System.Drawing.Point(12, 34)
        Me.YetToComplete.Name = "YetToComplete"
        Me.YetToComplete.ReadOnly = True
        Me.YetToComplete.RowHeadersWidth = 51
        Me.YetToComplete.Size = New System.Drawing.Size(829, 150)
        Me.YetToComplete.TabIndex = 21
        '
        'Job
        '
        Me.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Job.HeaderText = "Unit ID"
        Me.Job.MinimumWidth = 6
        Me.Job.Name = "Job"
        Me.Job.ReadOnly = True
        Me.Job.Width = 80
        '
        'ModelNumber
        '
        Me.ModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelNumber.HeaderText = "Model Number"
        Me.ModelNumber.MinimumWidth = 6
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.ReadOnly = True
        Me.ModelNumber.Width = 101
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Scope.HeaderText = "Scope"
        Me.Scope.MinimumWidth = 6
        Me.Scope.Name = "Scope"
        Me.Scope.ReadOnly = True
        Me.Scope.Width = 63
        '
        'UnitNote
        '
        Me.UnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitNote.HeaderText = "Note"
        Me.UnitNote.MinimumWidth = 6
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.ReadOnly = True
        Me.UnitNote.Width = 55
        '
        'Engineer
        '
        Me.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Engineer.HeaderText = "Engineer"
        Me.Engineer.MinimumWidth = 6
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Width = 70
        '
        'UnitLocation
        '
        Me.UnitLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitLocation.HeaderText = "Location"
        Me.UnitLocation.MinimumWidth = 6
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.ReadOnly = True
        Me.UnitLocation.Width = 65
        '
        'UnitID
        '
        Me.UnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.MinimumWidth = 6
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Width = 65
        '
        'ReleaseModelNumber
        '
        Me.ReleaseModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseModelNumber.HeaderText = "Model Number"
        Me.ReleaseModelNumber.MinimumWidth = 6
        Me.ReleaseModelNumber.Name = "ReleaseModelNumber"
        Me.ReleaseModelNumber.ReadOnly = True
        Me.ReleaseModelNumber.Width = 101
        '
        'ReleaseScope
        '
        Me.ReleaseScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseScope.HeaderText = "Scope"
        Me.ReleaseScope.MinimumWidth = 6
        Me.ReleaseScope.Name = "ReleaseScope"
        Me.ReleaseScope.ReadOnly = True
        Me.ReleaseScope.Width = 63
        '
        'ReleaseUnitNote
        '
        Me.ReleaseUnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReleaseUnitNote.HeaderText = "Note"
        Me.ReleaseUnitNote.MinimumWidth = 6
        Me.ReleaseUnitNote.Name = "ReleaseUnitNote"
        Me.ReleaseUnitNote.ReadOnly = True
        Me.ReleaseUnitNote.Width = 55
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
        'CompleteUnitLocation
        '
        Me.CompleteUnitLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CompleteUnitLocation.HeaderText = "Location"
        Me.CompleteUnitLocation.MinimumWidth = 6
        Me.CompleteUnitLocation.Name = "CompleteUnitLocation"
        Me.CompleteUnitLocation.ReadOnly = True
        Me.CompleteUnitLocation.Width = 65
        '
        'ProductionComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 423)
        Me.Controls.Add(Me.CompleteDataGrid)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.APCD)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CompleteBTN)
        Me.Controls.Add(Me.CompleteJob)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.YetToComplete)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductionComplete"
        Me.Text = "Production Complete"
        CType(Me.CompleteDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YetToComplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CompleteDataGrid As DataGridView
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents APCD As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CompleteBTN As Button
    Friend WithEvents CompleteJob As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents YetToComplete As DataGridView
    Friend WithEvents Job As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocation As DataGridViewTextBoxColumn
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseScope As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseUnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseEngineer As DataGridViewTextBoxColumn
    Friend WithEvents CompleteUnitLocation As DataGridViewTextBoxColumn
End Class
