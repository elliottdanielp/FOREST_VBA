<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadyToShip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadyToShip))
        Me.YetToReady = New System.Windows.Forms.DataGridView()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.ReadyDataGrid = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseUnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompleteUnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Ready2Ship = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ready2ShipDate = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.YetToReady, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadyDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YetToReady
        '
        Me.YetToReady.AllowUserToAddRows = False
        Me.YetToReady.AllowUserToDeleteRows = False
        Me.YetToReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YetToReady.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Job, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer, Me.UnitLocation})
        Me.YetToReady.Location = New System.Drawing.Point(9, 31)
        Me.YetToReady.Margin = New System.Windows.Forms.Padding(2)
        Me.YetToReady.Name = "YetToReady"
        Me.YetToReady.ReadOnly = True
        Me.YetToReady.RowHeadersWidth = 51
        Me.YetToReady.RowTemplate.Height = 24
        Me.YetToReady.Size = New System.Drawing.Size(829, 150)
        Me.YetToReady.TabIndex = 0
        '
        'Job
        '
        Me.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ready"
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(9, 209)
        Me.JobNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(121, 21)
        Me.JobNumber.TabIndex = 2
        '
        'ReadyDataGrid
        '
        Me.ReadyDataGrid.AllowUserToAddRows = False
        Me.ReadyDataGrid.AllowUserToDeleteRows = False
        Me.ReadyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReadyDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ReleaseModelNumber, Me.ReleaseScope, Me.ReleaseUnitNote, Me.ReleaseEngineer, Me.CompleteUnitLocation})
        Me.ReadyDataGrid.Location = New System.Drawing.Point(9, 244)
        Me.ReadyDataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.ReadyDataGrid.Name = "ReadyDataGrid"
        Me.ReadyDataGrid.ReadOnly = True
        Me.ReadyDataGrid.RowHeadersWidth = 51
        Me.ReadyDataGrid.RowTemplate.Height = 24
        Me.ReadyDataGrid.Size = New System.Drawing.Size(829, 125)
        Me.ReadyDataGrid.TabIndex = 3
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(425, 392)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Ready To Ship"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Ready2Ship
        '
        Me.Ready2Ship.Location = New System.Drawing.Point(528, 390)
        Me.Ready2Ship.Name = "Ready2Ship"
        Me.Ready2Ship.ReadOnly = True
        Me.Ready2Ship.Size = New System.Drawing.Size(100, 20)
        Me.Ready2Ship.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(763, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Job Number Selection"
        '
        'Ready2ShipDate
        '
        Me.Ready2ShipDate.Location = New System.Drawing.Point(648, 390)
        Me.Ready2ShipDate.Name = "Ready2ShipDate"
        Me.Ready2ShipDate.ReadOnly = True
        Me.Ready2ShipDate.Size = New System.Drawing.Size(100, 20)
        Me.Ready2ShipDate.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 386)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(390, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'ReadyToShip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 423)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Ready2ShipDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Ready2Ship)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ReadyDataGrid)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YetToReady)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReadyToShip"
        Me.Text = "Ready To Ship"
        CType(Me.YetToReady, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadyDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YetToReady As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Job As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocation As DataGridViewTextBoxColumn
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents ReadyDataGrid As DataGridView
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseScope As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseUnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseEngineer As DataGridViewTextBoxColumn
    Friend WithEvents CompleteUnitLocation As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Ready2Ship As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Ready2ShipDate As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
