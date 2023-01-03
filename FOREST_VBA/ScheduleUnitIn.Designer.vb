<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleUnitIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleUnitIn))
        Me.NotScheduledLocationDGV = New System.Windows.Forms.DataGridView()
        Me.JobNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnitLocation = New System.Windows.Forms.ComboBox()
        Me.ScheduledLocationDGV = New System.Windows.Forms.DataGridView()
        Me.ScheduledUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledUnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubmitBTN = New System.Windows.Forms.Button()
        Me.MoveIn = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PickScheduleDate = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.NotScheduledLocationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduledLocationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotScheduledLocationDGV
        '
        Me.NotScheduledLocationDGV.AllowUserToAddRows = False
        Me.NotScheduledLocationDGV.AllowUserToDeleteRows = False
        Me.NotScheduledLocationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotScheduledLocationDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobNumber, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer})
        Me.NotScheduledLocationDGV.Location = New System.Drawing.Point(20, 43)
        Me.NotScheduledLocationDGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NotScheduledLocationDGV.Name = "NotScheduledLocationDGV"
        Me.NotScheduledLocationDGV.ReadOnly = True
        Me.NotScheduledLocationDGV.RowHeadersWidth = 51
        Me.NotScheduledLocationDGV.Size = New System.Drawing.Size(1101, 246)
        Me.NotScheduledLocationDGV.TabIndex = 0
        '
        'JobNumber
        '
        Me.JobNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.JobNumber.HeaderText = "Unit ID"
        Me.JobNumber.MinimumWidth = 6
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.ReadOnly = True
        Me.JobNumber.Width = 65
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
        Me.Engineer.Width = 65
        '
        'UnitID
        '
        Me.UnitID.FormattingEnabled = True
        Me.UnitID.Location = New System.Drawing.Point(76, 511)
        Me.UnitID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Size = New System.Drawing.Size(145, 24)
        Me.UnitID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 514)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Unit ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 514)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Location"
        '
        'UnitLocation
        '
        Me.UnitLocation.FormattingEnabled = True
        Me.UnitLocation.Items.AddRange(New Object() {"Bay_1", "Bay_2A", "Bay_2B", "Bay_3A", "Bay_3B", "Bay_4A", "Bay_4B", "Bay_5", "Bay_6"})
        Me.UnitLocation.Location = New System.Drawing.Point(387, 511)
        Me.UnitLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.Size = New System.Drawing.Size(135, 24)
        Me.UnitLocation.TabIndex = 4
        '
        'ScheduledLocationDGV
        '
        Me.ScheduledLocationDGV.AllowUserToAddRows = False
        Me.ScheduledLocationDGV.AllowUserToDeleteRows = False
        Me.ScheduledLocationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduledLocationDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScheduledUnitID, Me.ScheduledModelNumber, Me.ScheduledScope, Me.ScheduledNote, Me.ScheduledEngineer, Me.ScheduledUnitLocation})
        Me.ScheduledLocationDGV.Location = New System.Drawing.Point(20, 321)
        Me.ScheduledLocationDGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduledLocationDGV.Name = "ScheduledLocationDGV"
        Me.ScheduledLocationDGV.ReadOnly = True
        Me.ScheduledLocationDGV.RowHeadersWidth = 51
        Me.ScheduledLocationDGV.Size = New System.Drawing.Size(1101, 159)
        Me.ScheduledLocationDGV.TabIndex = 5
        '
        'ScheduledUnitID
        '
        Me.ScheduledUnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ScheduledUnitID.HeaderText = "Unit ID"
        Me.ScheduledUnitID.MinimumWidth = 6
        Me.ScheduledUnitID.Name = "ScheduledUnitID"
        Me.ScheduledUnitID.ReadOnly = True
        Me.ScheduledUnitID.Width = 65
        '
        'ScheduledModelNumber
        '
        Me.ScheduledModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ScheduledModelNumber.HeaderText = "Model Number"
        Me.ScheduledModelNumber.MinimumWidth = 6
        Me.ScheduledModelNumber.Name = "ScheduledModelNumber"
        Me.ScheduledModelNumber.ReadOnly = True
        Me.ScheduledModelNumber.Width = 129
        '
        'ScheduledScope
        '
        Me.ScheduledScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ScheduledScope.HeaderText = "Scope"
        Me.ScheduledScope.MinimumWidth = 6
        Me.ScheduledScope.Name = "ScheduledScope"
        Me.ScheduledScope.ReadOnly = True
        Me.ScheduledScope.Width = 77
        '
        'ScheduledNote
        '
        Me.ScheduledNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ScheduledNote.HeaderText = "Note"
        Me.ScheduledNote.MinimumWidth = 6
        Me.ScheduledNote.Name = "ScheduledNote"
        Me.ScheduledNote.ReadOnly = True
        Me.ScheduledNote.Width = 67
        '
        'ScheduledEngineer
        '
        Me.ScheduledEngineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ScheduledEngineer.HeaderText = "Engineer"
        Me.ScheduledEngineer.MinimumWidth = 6
        Me.ScheduledEngineer.Name = "ScheduledEngineer"
        Me.ScheduledEngineer.ReadOnly = True
        Me.ScheduledEngineer.Width = 65
        '
        'ScheduledUnitLocation
        '
        Me.ScheduledUnitLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ScheduledUnitLocation.HeaderText = "Location"
        Me.ScheduledUnitLocation.MinimumWidth = 6
        Me.ScheduledUnitLocation.Name = "ScheduledUnitLocation"
        Me.ScheduledUnitLocation.ReadOnly = True
        Me.ScheduledUnitLocation.Width = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Location Not Scheduled"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Location Scheduled"
        '
        'SubmitBTN
        '
        Me.SubmitBTN.Location = New System.Drawing.Point(715, 636)
        Me.SubmitBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubmitBTN.Name = "SubmitBTN"
        Me.SubmitBTN.Size = New System.Drawing.Size(88, 26)
        Me.SubmitBTN.TabIndex = 8
        Me.SubmitBTN.Text = "Submit"
        Me.SubmitBTN.UseVisualStyleBackColor = True
        '
        'MoveIn
        '
        Me.MoveIn.Location = New System.Drawing.Point(699, 512)
        Me.MoveIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MoveIn.Name = "MoveIn"
        Me.MoveIn.ReadOnly = True
        Me.MoveIn.Size = New System.Drawing.Size(103, 22)
        Me.MoveIn.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(620, 608)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(176, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Schedule Unit Location"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 670)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(783, 25)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 11
        '
        'PickScheduleDate
        '
        Me.PickScheduleDate.Location = New System.Drawing.Point(819, 495)
        Me.PickScheduleDate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.PickScheduleDate.Name = "PickScheduleDate"
        Me.PickScheduleDate.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(595, 514)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Move In Date"
        '
        'ScheduleUnitIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 713)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PickScheduleDate)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MoveIn)
        Me.Controls.Add(Me.SubmitBTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ScheduledLocationDGV)
        Me.Controls.Add(Me.UnitLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitID)
        Me.Controls.Add(Me.NotScheduledLocationDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ScheduleUnitIn"
        Me.Text = "Schedule Unit In"
        CType(Me.NotScheduledLocationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduledLocationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotScheduledLocationDGV As DataGridView
    Friend WithEvents UnitID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnitLocation As ComboBox
    Friend WithEvents ScheduledLocationDGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents MoveIn As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents JobNumber As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents PickScheduleDate As MonthCalendar
    Friend WithEvents Label5 As Label
    Friend WithEvents ScheduledUnitID As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledScope As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledNote As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledEngineer As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledUnitLocation As DataGridViewTextBoxColumn
End Class
