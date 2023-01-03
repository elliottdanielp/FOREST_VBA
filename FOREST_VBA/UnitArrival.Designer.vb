<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitArrival
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitArrival))
        Me.YetToArrive = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SerialNumber = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.AUAD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ArrivedDataGrid = New System.Windows.Forms.DataGridView()
        Me.ArrivedUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivedModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivedScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivedUnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivedEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.YetToArrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrivedDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YetToArrive
        '
        Me.YetToArrive.AllowUserToAddRows = False
        Me.YetToArrive.AllowUserToDeleteRows = False
        Me.YetToArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YetToArrive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer})
        Me.YetToArrive.Location = New System.Drawing.Point(12, 28)
        Me.YetToArrive.Name = "YetToArrive"
        Me.YetToArrive.ReadOnly = True
        Me.YetToArrive.RowHeadersWidth = 51
        Me.YetToArrive.Size = New System.Drawing.Size(722, 194)
        Me.YetToArrive.TabIndex = 0
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
        Me.UnitNote.HeaderText = "Unit Note"
        Me.UnitNote.MinimumWidth = 6
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.ReadOnly = True
        Me.UnitNote.Width = 77
        '
        'Engineer
        '
        Me.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Engineer.HeaderText = "Engineer"
        Me.Engineer.MinimumWidth = 6
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Width = 65
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(79, 228)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(121, 21)
        Me.JobNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Job Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serial Number"
        '
        'SerialNumber
        '
        Me.SerialNumber.Location = New System.Drawing.Point(308, 229)
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.Size = New System.Drawing.Size(252, 20)
        Me.SerialNumber.TabIndex = 4
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(659, 399)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 5
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'AUAD
        '
        Me.AUAD.Location = New System.Drawing.Point(539, 401)
        Me.AUAD.Name = "AUAD"
        Me.AUAD.ReadOnly = True
        Me.AUAD.Size = New System.Drawing.Size(75, 20)
        Me.AUAD.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Yet To Arrive"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(452, 403)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Unit Arrived"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 401)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(422, 20)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 9
        '
        'ArrivedDataGrid
        '
        Me.ArrivedDataGrid.AllowUserToAddRows = False
        Me.ArrivedDataGrid.AllowUserToDeleteRows = False
        Me.ArrivedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArrivedDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArrivedUnitID, Me.ArrivedModelNumber, Me.ArrivedScope, Me.ArrivedUnitNote, Me.ArrivedEngineer, Me.UnitLocation})
        Me.ArrivedDataGrid.Location = New System.Drawing.Point(13, 255)
        Me.ArrivedDataGrid.Name = "ArrivedDataGrid"
        Me.ArrivedDataGrid.ReadOnly = True
        Me.ArrivedDataGrid.Size = New System.Drawing.Size(721, 136)
        Me.ArrivedDataGrid.TabIndex = 10
        '
        'ArrivedUnitID
        '
        Me.ArrivedUnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ArrivedUnitID.HeaderText = "Unit ID"
        Me.ArrivedUnitID.Name = "ArrivedUnitID"
        Me.ArrivedUnitID.ReadOnly = True
        Me.ArrivedUnitID.Width = 65
        '
        'ArrivedModelNumber
        '
        Me.ArrivedModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArrivedModelNumber.HeaderText = "Model Number"
        Me.ArrivedModelNumber.Name = "ArrivedModelNumber"
        Me.ArrivedModelNumber.ReadOnly = True
        Me.ArrivedModelNumber.Width = 101
        '
        'ArrivedScope
        '
        Me.ArrivedScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArrivedScope.HeaderText = "Scope"
        Me.ArrivedScope.Name = "ArrivedScope"
        Me.ArrivedScope.ReadOnly = True
        Me.ArrivedScope.Width = 63
        '
        'ArrivedUnitNote
        '
        Me.ArrivedUnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArrivedUnitNote.HeaderText = "Unit Note"
        Me.ArrivedUnitNote.Name = "ArrivedUnitNote"
        Me.ArrivedUnitNote.ReadOnly = True
        Me.ArrivedUnitNote.Width = 77
        '
        'ArrivedEngineer
        '
        Me.ArrivedEngineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ArrivedEngineer.HeaderText = "Engineer"
        Me.ArrivedEngineer.Name = "ArrivedEngineer"
        Me.ArrivedEngineer.ReadOnly = True
        Me.ArrivedEngineer.Width = 65
        '
        'UnitLocation
        '
        Me.UnitLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitLocation.HeaderText = "Location"
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.ReadOnly = True
        Me.UnitLocation.Width = 65
        '
        'UnitArrival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 433)
        Me.Controls.Add(Me.ArrivedDataGrid)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AUAD)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.SerialNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.YetToArrive)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnitArrival"
        Me.Text = "Unit Arrival"
        CType(Me.YetToArrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrivedDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YetToArrive As DataGridView
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SerialNumber As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents AUAD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents ArrivedDataGrid As DataGridView
    Friend WithEvents ArrivedUnitID As DataGridViewTextBoxColumn
    Friend WithEvents ArrivedModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ArrivedScope As DataGridViewTextBoxColumn
    Friend WithEvents ArrivedUnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ArrivedEngineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocation As DataGridViewTextBoxColumn
End Class
