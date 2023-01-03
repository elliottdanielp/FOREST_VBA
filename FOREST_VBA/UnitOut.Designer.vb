<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitOut))
        Me.ShipItDGV = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Engineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitIDdd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnitOutDGV = New System.Windows.Forms.DataGridView()
        Me.UnitOutUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOutModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOutScope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOutEngineer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOutLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MovedOut = New System.Windows.Forms.TextBox()
        Me.SubmitBTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ShipItDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOutDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipItDGV
        '
        Me.ShipItDGV.AllowUserToAddRows = False
        Me.ShipItDGV.AllowUserToDeleteRows = False
        Me.ShipItDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShipItDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ModelNumber, Me.Scope, Me.Engineer, Me.UnitLocation})
        Me.ShipItDGV.Location = New System.Drawing.Point(12, 31)
        Me.ShipItDGV.Name = "ShipItDGV"
        Me.ShipItDGV.ReadOnly = True
        Me.ShipItDGV.Size = New System.Drawing.Size(776, 130)
        Me.ShipItDGV.TabIndex = 0
        '
        'UnitID
        '
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Width = 65
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
        'Engineer
        '
        Me.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Engineer.HeaderText = "Engineer"
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Width = 65
        '
        'UnitLocation
        '
        Me.UnitLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitLocation.HeaderText = "Location"
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.ReadOnly = True
        Me.UnitLocation.Width = 65
        '
        'UnitIDdd
        '
        Me.UnitIDdd.FormattingEnabled = True
        Me.UnitIDdd.Location = New System.Drawing.Point(79, 178)
        Me.UnitIDdd.Name = "UnitIDdd"
        Me.UnitIDdd.Size = New System.Drawing.Size(121, 21)
        Me.UnitIDdd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Job Number"
        '
        'UnitOutDGV
        '
        Me.UnitOutDGV.AllowUserToAddRows = False
        Me.UnitOutDGV.AllowUserToDeleteRows = False
        Me.UnitOutDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitOutDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitOutUnitID, Me.UnitOutModelNumber, Me.UnitOutScope, Me.UnitOutEngineer, Me.UnitOutLocation})
        Me.UnitOutDGV.Location = New System.Drawing.Point(12, 241)
        Me.UnitOutDGV.Name = "UnitOutDGV"
        Me.UnitOutDGV.ReadOnly = True
        Me.UnitOutDGV.Size = New System.Drawing.Size(776, 87)
        Me.UnitOutDGV.TabIndex = 3
        '
        'UnitOutUnitID
        '
        Me.UnitOutUnitID.HeaderText = "Unit ID"
        Me.UnitOutUnitID.Name = "UnitOutUnitID"
        Me.UnitOutUnitID.ReadOnly = True
        '
        'UnitOutModelNumber
        '
        Me.UnitOutModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitOutModelNumber.HeaderText = "Model Number"
        Me.UnitOutModelNumber.Name = "UnitOutModelNumber"
        Me.UnitOutModelNumber.ReadOnly = True
        Me.UnitOutModelNumber.Width = 101
        '
        'UnitOutScope
        '
        Me.UnitOutScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitOutScope.HeaderText = "Scope"
        Me.UnitOutScope.Name = "UnitOutScope"
        Me.UnitOutScope.ReadOnly = True
        Me.UnitOutScope.Width = 63
        '
        'UnitOutEngineer
        '
        Me.UnitOutEngineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitOutEngineer.HeaderText = "Engineer"
        Me.UnitOutEngineer.Name = "UnitOutEngineer"
        Me.UnitOutEngineer.ReadOnly = True
        Me.UnitOutEngineer.Width = 65
        '
        'UnitOutLocation
        '
        Me.UnitOutLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitOutLocation.HeaderText = "Location"
        Me.UnitOutLocation.Name = "UnitOutLocation"
        Me.UnitOutLocation.ReadOnly = True
        Me.UnitOutLocation.Width = 65
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(501, 344)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Moved Out"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MovedOut
        '
        Me.MovedOut.Location = New System.Drawing.Point(586, 344)
        Me.MovedOut.Name = "MovedOut"
        Me.MovedOut.Size = New System.Drawing.Size(100, 20)
        Me.MovedOut.TabIndex = 5
        '
        'SubmitBTN
        '
        Me.SubmitBTN.Location = New System.Drawing.Point(713, 344)
        Me.SubmitBTN.Name = "SubmitBTN"
        Me.SubmitBTN.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBTN.TabIndex = 6
        Me.SubmitBTN.Text = "Submit"
        Me.SubmitBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ready To Move Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unit Moving Out"
        '
        'UnitOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 379)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubmitBTN)
        Me.Controls.Add(Me.MovedOut)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.UnitOutDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitIDdd)
        Me.Controls.Add(Me.ShipItDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnitOut"
        Me.Text = "Unit Out"
        CType(Me.ShipItDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOutDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShipItDGV As DataGridView
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents Engineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocation As DataGridViewTextBoxColumn
    Friend WithEvents UnitIDdd As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UnitOutDGV As DataGridView
    Friend WithEvents UnitOutUnitID As DataGridViewTextBoxColumn
    Friend WithEvents UnitOutModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents UnitOutScope As DataGridViewTextBoxColumn
    Friend WithEvents UnitOutEngineer As DataGridViewTextBoxColumn
    Friend WithEvents UnitOutLocation As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MovedOut As TextBox
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
