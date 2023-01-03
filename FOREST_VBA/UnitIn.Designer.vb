<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitIn))
        Me.ScheduledUnitDGV = New System.Windows.Forms.DataGridView()
        Me.ScheduledUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MovedInDGV = New System.Windows.Forms.DataGridView()
        Me.MovingInUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingInModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingInScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingInNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingInEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingInLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnitID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnitLocation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubmitBTN = New System.Windows.Forms.Button()
        Me.MovedIn = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.ScheduledUnitDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovedInDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScheduledUnitDGV
        '
        Me.ScheduledUnitDGV.AllowUserToAddRows = False
        Me.ScheduledUnitDGV.AllowUserToDeleteRows = False
        Me.ScheduledUnitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduledUnitDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScheduledUnitID, Me.ModelNumber, Me.Scope, Me.UnitNote, Me.Engineer, Me.Location})
        Me.ScheduledUnitDGV.Location = New System.Drawing.Point(12, 33)
        Me.ScheduledUnitDGV.Name = "ScheduledUnitDGV"
        Me.ScheduledUnitDGV.ReadOnly = True
        Me.ScheduledUnitDGV.Size = New System.Drawing.Size(776, 109)
        Me.ScheduledUnitDGV.TabIndex = 0
        '
        'ScheduledUnitID
        '
        Me.ScheduledUnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ScheduledUnitID.HeaderText = "Unit ID"
        Me.ScheduledUnitID.Name = "ScheduledUnitID"
        Me.ScheduledUnitID.ReadOnly = True
        Me.ScheduledUnitID.Width = 65
        '
        'ModelNumber
        '
        Me.ModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelNumber.HeaderText = "Model Number"
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.ReadOnly = True
        Me.ModelNumber.Width = 101
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Scope.HeaderText = "Scope"
        Me.Scope.Name = "Scope"
        Me.Scope.ReadOnly = True
        Me.Scope.Width = 63
        '
        'UnitNote
        '
        Me.UnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitNote.HeaderText = "Note"
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.ReadOnly = True
        Me.UnitNote.Width = 55
        '
        'Engineer
        '
        Me.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Engineer.HeaderText = "Engineer"
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Width = 65
        '
        'Location
        '
        Me.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        Me.Location.ReadOnly = True
        Me.Location.Width = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scheduled Unit In"
        '
        'MovedInDGV
        '
        Me.MovedInDGV.AllowUserToAddRows = False
        Me.MovedInDGV.AllowUserToDeleteRows = False
        Me.MovedInDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovedInDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovingInUnitID, Me.MovingInModelNumber, Me.MovingInScope, Me.MovingInNote, Me.MovingInEngineer, Me.MovingInLocation})
        Me.MovedInDGV.Location = New System.Drawing.Point(12, 198)
        Me.MovedInDGV.Name = "MovedInDGV"
        Me.MovedInDGV.ReadOnly = True
        Me.MovedInDGV.Size = New System.Drawing.Size(776, 100)
        Me.MovedInDGV.TabIndex = 2
        '
        'MovingInUnitID
        '
        Me.MovingInUnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MovingInUnitID.HeaderText = "Unit ID"
        Me.MovingInUnitID.Name = "MovingInUnitID"
        Me.MovingInUnitID.ReadOnly = True
        Me.MovingInUnitID.Width = 65
        '
        'MovingInModelNumber
        '
        Me.MovingInModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovingInModelNumber.HeaderText = "Model Number"
        Me.MovingInModelNumber.Name = "MovingInModelNumber"
        Me.MovingInModelNumber.ReadOnly = True
        Me.MovingInModelNumber.Width = 101
        '
        'MovingInScope
        '
        Me.MovingInScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovingInScope.HeaderText = "Scope"
        Me.MovingInScope.Name = "MovingInScope"
        Me.MovingInScope.ReadOnly = True
        Me.MovingInScope.Width = 63
        '
        'MovingInNote
        '
        Me.MovingInNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MovingInNote.HeaderText = "Note"
        Me.MovingInNote.Name = "MovingInNote"
        Me.MovingInNote.ReadOnly = True
        Me.MovingInNote.Width = 55
        '
        'MovingInEngineer
        '
        Me.MovingInEngineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MovingInEngineer.HeaderText = "Engineer"
        Me.MovingInEngineer.Name = "MovingInEngineer"
        Me.MovingInEngineer.ReadOnly = True
        Me.MovingInEngineer.Width = 65
        '
        'MovingInLocation
        '
        Me.MovingInLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MovingInLocation.HeaderText = "Location"
        Me.MovingInLocation.Name = "MovingInLocation"
        Me.MovingInLocation.ReadOnly = True
        Me.MovingInLocation.Width = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unit Moving In"
        '
        'UnitID
        '
        Me.UnitID.FormattingEnabled = True
        Me.UnitID.Location = New System.Drawing.Point(82, 153)
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Size = New System.Drawing.Size(87, 21)
        Me.UnitID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Job Number"
        '
        'UnitLocation
        '
        Me.UnitLocation.FormattingEnabled = True
        Me.UnitLocation.Items.AddRange(New Object() {"Bay 1", "Bay 2A", "Bay 2B", "Bay 3A", "Bay 3B", "Bay 4A", "Bay 4B", "Bay 5", "Bay 6"})
        Me.UnitLocation.Location = New System.Drawing.Point(263, 153)
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.Size = New System.Drawing.Size(87, 21)
        Me.UnitLocation.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Location"
        '
        'SubmitBTN
        '
        Me.SubmitBTN.Location = New System.Drawing.Point(718, 315)
        Me.SubmitBTN.Name = "SubmitBTN"
        Me.SubmitBTN.Size = New System.Drawing.Size(70, 22)
        Me.SubmitBTN.TabIndex = 8
        Me.SubmitBTN.Text = "Submit"
        Me.SubmitBTN.UseVisualStyleBackColor = True
        '
        'MovedIn
        '
        Me.MovedIn.Location = New System.Drawing.Point(623, 317)
        Me.MovedIn.Name = "MovedIn"
        Me.MovedIn.ReadOnly = True
        Me.MovedIn.Size = New System.Drawing.Size(73, 20)
        Me.MovedIn.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(537, 319)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Move In"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 313)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(491, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 11
        '
        'UnitIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 348)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MovedIn)
        Me.Controls.Add(Me.SubmitBTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UnitLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UnitID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MovedInDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScheduledUnitDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnitIn"
        Me.Text = "Unit In"
        CType(Me.ScheduledUnitDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovedInDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScheduledUnitDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MovedInDGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents UnitID As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UnitLocation As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MovingInUnitID As DataGridViewTextBoxColumn
    Friend WithEvents MovingInModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents MovingInScope As DataGridViewTextBoxColumn
    Friend WithEvents MovingInNote As DataGridViewTextBoxColumn
    Friend WithEvents MovingInEngineer As DataGridViewTextBoxColumn
    Friend WithEvents MovingInLocation As DataGridViewTextBoxColumn
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents MovedIn As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ScheduledUnitID As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
End Class
