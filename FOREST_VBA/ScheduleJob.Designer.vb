<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleJob))
        Me.UnscheduledJobData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.JobSchedule = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EUAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScheduleBtn = New System.Windows.Forms.Button()
        Me.JobNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.UnscheduledJobData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnscheduledJobData
        '
        Me.UnscheduledJobData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.UnscheduledJobData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UnscheduledJobData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnscheduledJobData.Location = New System.Drawing.Point(15, 39)
        Me.UnscheduledJobData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UnscheduledJobData.Name = "UnscheduledJobData"
        Me.UnscheduledJobData.RowHeadersWidth = 51
        Me.UnscheduledJobData.RowTemplate.Height = 24
        Me.UnscheduledJobData.Size = New System.Drawing.Size(992, 151)
        Me.UnscheduledJobData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unscheduled Jobs"
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(908, 430)
        Me.SubmitBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(100, 28)
        Me.SubmitBtn.TabIndex = 4
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'JobSchedule
        '
        Me.JobSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JobSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.EUAD, Me.SMHOD, Me.PHOD, Me.PCD, Me.ESD, Me.ScheduleType})
        Me.JobSchedule.Location = New System.Drawing.Point(15, 238)
        Me.JobSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JobSchedule.Name = "JobSchedule"
        Me.JobSchedule.RowHeadersWidth = 51
        Me.JobSchedule.Size = New System.Drawing.Size(993, 185)
        Me.JobSchedule.TabIndex = 5
        '
        'UnitID
        '
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.MinimumWidth = 6
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Width = 125
        '
        'EUAD
        '
        Me.EUAD.HeaderText = "EUAD"
        Me.EUAD.MinimumWidth = 6
        Me.EUAD.Name = "EUAD"
        Me.EUAD.Width = 125
        '
        'SMHOD
        '
        Me.SMHOD.HeaderText = "SMHOD"
        Me.SMHOD.MinimumWidth = 6
        Me.SMHOD.Name = "SMHOD"
        Me.SMHOD.Width = 125
        '
        'PHOD
        '
        Me.PHOD.HeaderText = "PHOD"
        Me.PHOD.MinimumWidth = 6
        Me.PHOD.Name = "PHOD"
        Me.PHOD.Width = 125
        '
        'PCD
        '
        Me.PCD.HeaderText = "PCD"
        Me.PCD.MinimumWidth = 6
        Me.PCD.Name = "PCD"
        Me.PCD.Width = 125
        '
        'ESD
        '
        Me.ESD.HeaderText = "ESD"
        Me.ESD.MinimumWidth = 6
        Me.ESD.Name = "ESD"
        Me.ESD.Width = 125
        '
        'ScheduleType
        '
        Me.ScheduleType.HeaderText = "Type"
        Me.ScheduleType.MinimumWidth = 6
        Me.ScheduleType.Name = "ScheduleType"
        Me.ScheduleType.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Job Schedule"
        '
        'ScheduleBtn
        '
        Me.ScheduleBtn.Location = New System.Drawing.Point(908, 204)
        Me.ScheduleBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleBtn.Name = "ScheduleBtn"
        Me.ScheduleBtn.Size = New System.Drawing.Size(100, 26)
        Me.ScheduleBtn.TabIndex = 7
        Me.ScheduleBtn.Text = "Schedule"
        Me.ScheduleBtn.UseVisualStyleBackColor = True
        '
        'JobNumber
        '
        Me.JobNumber.Location = New System.Drawing.Point(767, 204)
        Me.JobNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.ReadOnly = True
        Me.JobNumber.Size = New System.Drawing.Size(132, 22)
        Me.JobNumber.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(673, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Job Number"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 430)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(881, 28)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 10
        '
        'ScheduleJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 473)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.ScheduleBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JobSchedule)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnscheduledJobData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ScheduleJob"
        Me.Text = "Schedule Job"
        CType(Me.UnscheduledJobData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UnscheduledJobData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents JobSchedule As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ScheduleBtn As Button
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents EUAD As DataGridViewTextBoxColumn
    Friend WithEvents SMHOD As DataGridViewTextBoxColumn
    Friend WithEvents PHOD As DataGridViewTextBoxColumn
    Friend WithEvents PCD As DataGridViewTextBoxColumn
    Friend WithEvents ESD As DataGridViewTextBoxColumn
    Friend WithEvents ScheduleType As DataGridViewTextBoxColumn
    Friend WithEvents JobNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
