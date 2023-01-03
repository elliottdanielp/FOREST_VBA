<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesHandoff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesHandoff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalesEng = New System.Windows.Forms.ComboBox()
        Me.POAmount = New System.Windows.Forms.TextBox()
        Me.JobName = New System.Windows.Forms.TextBox()
        Me.Priority = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NationalAccount = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UnitInfo = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNumber1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RequestDate = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MasterNote = New System.Windows.Forms.RichTextBox()
        CType(Me.UnitInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PO Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Job Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Priority"
        '
        'SalesEng
        '
        Me.SalesEng.FormattingEnabled = True
        Me.SalesEng.Items.AddRange(New Object() {"Chris Beggs", "Chris Bloch", "Jason Pursell", "Christine Hoppes", "Ryan Houldsworth", "Matt Latchaw"})
        Me.SalesEng.Location = New System.Drawing.Point(107, 18)
        Me.SalesEng.Name = "SalesEng"
        Me.SalesEng.Size = New System.Drawing.Size(151, 21)
        Me.SalesEng.TabIndex = 7
        '
        'POAmount
        '
        Me.POAmount.Location = New System.Drawing.Point(107, 45)
        Me.POAmount.Name = "POAmount"
        Me.POAmount.Size = New System.Drawing.Size(125, 20)
        Me.POAmount.TabIndex = 8
        '
        'JobName
        '
        Me.JobName.Location = New System.Drawing.Point(104, 130)
        Me.JobName.Name = "JobName"
        Me.JobName.Size = New System.Drawing.Size(125, 20)
        Me.JobName.TabIndex = 9
        '
        'Priority
        '
        Me.Priority.FormattingEnabled = True
        Me.Priority.Items.AddRange(New Object() {"STD", "RED", "HOT"})
        Me.Priority.Location = New System.Drawing.Point(107, 101)
        Me.Priority.Name = "Priority"
        Me.Priority.Size = New System.Drawing.Size(151, 21)
        Me.Priority.TabIndex = 13
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(268, 43)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(342, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Request Date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 24)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NationalAccount
        '
        Me.NationalAccount.FormattingEnabled = True
        Me.NationalAccount.Location = New System.Drawing.Point(107, 74)
        Me.NationalAccount.Name = "NationalAccount"
        Me.NationalAccount.Size = New System.Drawing.Size(151, 21)
        Me.NationalAccount.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "National Account"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 28)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Add Unit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UnitInfo
        '
        Me.UnitInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.UnitInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UnitInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ModelNumber, Me.JobNumber, Me.Scope, Me.UnitNote})
        Me.UnitInfo.Location = New System.Drawing.Point(10, 234)
        Me.UnitInfo.Name = "UnitInfo"
        Me.UnitInfo.RowHeadersWidth = 51
        Me.UnitInfo.Size = New System.Drawing.Size(476, 120)
        Me.UnitInfo.TabIndex = 25
        '
        'UnitID
        '
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.MinimumWidth = 6
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Width = 65
        '
        'ModelNumber
        '
        Me.ModelNumber.HeaderText = "Model Number"
        Me.ModelNumber.MinimumWidth = 6
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.Width = 101
        '
        'JobNumber
        '
        Me.JobNumber.HeaderText = "Job Number"
        Me.JobNumber.MinimumWidth = 6
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Width = 89
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Scope.HeaderText = "Scope"
        Me.Scope.MinimumWidth = 6
        Me.Scope.Name = "Scope"
        '
        'UnitNote
        '
        Me.UnitNote.HeaderText = "Note"
        Me.UnitNote.MinimumWidth = 6
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.Width = 55
        '
        'JobNumber1
        '
        Me.JobNumber1.Location = New System.Drawing.Point(107, 156)
        Me.JobNumber1.Name = "JobNumber1"
        Me.JobNumber1.Size = New System.Drawing.Size(125, 20)
        Me.JobNumber1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Job Number"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Save Job"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RequestDate
        '
        Me.RequestDate.Location = New System.Drawing.Point(418, 18)
        Me.RequestDate.Margin = New System.Windows.Forms.Padding(2)
        Me.RequestDate.Name = "RequestDate"
        Me.RequestDate.ReadOnly = True
        Me.RequestDate.Size = New System.Drawing.Size(68, 20)
        Me.RequestDate.TabIndex = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 548)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(210, 24)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Job Note"
        '
        'MasterNote
        '
        Me.MasterNote.Location = New System.Drawing.Point(10, 389)
        Me.MasterNote.Name = "MasterNote"
        Me.MasterNote.Size = New System.Drawing.Size(476, 125)
        Me.MasterNote.TabIndex = 34
        Me.MasterNote.Text = ""
        '
        'SalesHandoff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(501, 584)
        Me.Controls.Add(Me.MasterNote)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RequestDate)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.JobNumber1)
        Me.Controls.Add(Me.UnitInfo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NationalAccount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Priority)
        Me.Controls.Add(Me.JobName)
        Me.Controls.Add(Me.POAmount)
        Me.Controls.Add(Me.SalesEng)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesHandoff"
        Me.Text = "Sales Handoff"
        CType(Me.UnitInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SalesEng As ComboBox
    Friend WithEvents POAmount As TextBox
    Friend WithEvents JobName As TextBox
    Friend WithEvents Priority As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NationalAccount As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents UnitInfo As DataGridView
    Friend WithEvents JobNumber1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents RequestDate As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents JobNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents MasterNote As RichTextBox
End Class
