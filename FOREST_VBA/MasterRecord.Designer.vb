<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterRecord))
        Me.JobNumberSql = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UnitNoteDGV = New System.Windows.Forms.DataGridView()
        Me.UnitNoteUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SubmittalNoteDGV = New System.Windows.Forms.DataGridView()
        Me.SubmittalNoteUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubmittalNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalesNote = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnitInfoDGV = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TestDGV = New System.Windows.Forms.DataGridView()
        Me.TestUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionItems = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ActualDGV = New System.Windows.Forms.DataGridView()
        Me.ActualUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ScheduleDGV = New System.Windows.Forms.DataGridView()
        Me.ScheduleUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EUAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.JobNumber = New System.Windows.Forms.TextBox()
        Me.JobName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SoldBy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Priority = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.POAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Engineer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UnitNoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubmittalNoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitInfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TestDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'JobNumberSql
        '
        Me.JobNumberSql.Location = New System.Drawing.Point(62, 6)
        Me.JobNumberSql.Name = "JobNumberSql"
        Me.JobNumberSql.Size = New System.Drawing.Size(73, 20)
        Me.JobNumberSql.TabIndex = 0
        Me.JobNumberSql.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 557)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UnitNoteDGV)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.SubmittalNoteDGV)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.SalesNote)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.UnitInfoDGV)
        Me.TabPage1.Controls.Add(Me.JobNumberSql)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UnitNoteDGV
        '
        Me.UnitNoteDGV.AllowUserToAddRows = False
        Me.UnitNoteDGV.AllowUserToDeleteRows = False
        Me.UnitNoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitNoteDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitNoteUnitID, Me.UnitNote})
        Me.UnitNoteDGV.Location = New System.Drawing.Point(6, 412)
        Me.UnitNoteDGV.Name = "UnitNoteDGV"
        Me.UnitNoteDGV.ReadOnly = True
        Me.UnitNoteDGV.Size = New System.Drawing.Size(721, 100)
        Me.UnitNoteDGV.TabIndex = 9
        '
        'UnitNoteUnitID
        '
        Me.UnitNoteUnitID.HeaderText = "Unit ID"
        Me.UnitNoteUnitID.Name = "UnitNoteUnitID"
        Me.UnitNoteUnitID.ReadOnly = True
        Me.UnitNoteUnitID.Width = 65
        '
        'UnitNote
        '
        Me.UnitNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnitNote.HeaderText = "Note"
        Me.UnitNote.Name = "UnitNote"
        Me.UnitNote.ReadOnly = True
        Me.UnitNote.Width = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Unit Notes"
        '
        'SubmittalNoteDGV
        '
        Me.SubmittalNoteDGV.AllowUserToAddRows = False
        Me.SubmittalNoteDGV.AllowUserToDeleteRows = False
        Me.SubmittalNoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubmittalNoteDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubmittalNoteUnitID, Me.SubmittalNote})
        Me.SubmittalNoteDGV.Location = New System.Drawing.Point(6, 276)
        Me.SubmittalNoteDGV.Name = "SubmittalNoteDGV"
        Me.SubmittalNoteDGV.ReadOnly = True
        Me.SubmittalNoteDGV.Size = New System.Drawing.Size(721, 98)
        Me.SubmittalNoteDGV.TabIndex = 7
        '
        'SubmittalNoteUnitID
        '
        Me.SubmittalNoteUnitID.HeaderText = "Unit ID"
        Me.SubmittalNoteUnitID.Name = "SubmittalNoteUnitID"
        Me.SubmittalNoteUnitID.ReadOnly = True
        Me.SubmittalNoteUnitID.Width = 65
        '
        'SubmittalNote
        '
        Me.SubmittalNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubmittalNote.HeaderText = "Note"
        Me.SubmittalNote.Name = "SubmittalNote"
        Me.SubmittalNote.ReadOnly = True
        Me.SubmittalNote.Width = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Submittal Notes"
        '
        'SalesNote
        '
        Me.SalesNote.BackColor = System.Drawing.SystemColors.Window
        Me.SalesNote.Location = New System.Drawing.Point(6, 159)
        Me.SalesNote.Name = "SalesNote"
        Me.SalesNote.ReadOnly = True
        Me.SalesNote.Size = New System.Drawing.Size(721, 84)
        Me.SalesNote.TabIndex = 5
        Me.SalesNote.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sales Note"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unit Info"
        '
        'UnitInfoDGV
        '
        Me.UnitInfoDGV.AllowUserToAddRows = False
        Me.UnitInfoDGV.AllowUserToDeleteRows = False
        Me.UnitInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitInfoDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.Tag, Me.ModelNumber, Me.SerialNumber, Me.Scope, Me.UnitLocation})
        Me.UnitInfoDGV.Location = New System.Drawing.Point(6, 28)
        Me.UnitInfoDGV.Name = "UnitInfoDGV"
        Me.UnitInfoDGV.ReadOnly = True
        Me.UnitInfoDGV.Size = New System.Drawing.Size(721, 103)
        Me.UnitInfoDGV.TabIndex = 2
        '
        'UnitID
        '
        Me.UnitID.HeaderText = "Unit ID"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Width = 65
        '
        'Tag
        '
        Me.Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tag.HeaderText = "Tag"
        Me.Tag.Name = "Tag"
        Me.Tag.ReadOnly = True
        Me.Tag.Width = 51
        '
        'ModelNumber
        '
        Me.ModelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelNumber.HeaderText = "Model Number"
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.ReadOnly = True
        Me.ModelNumber.Width = 101
        '
        'SerialNumber
        '
        Me.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerialNumber.HeaderText = "Serial Number"
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.ReadOnly = True
        Me.SerialNumber.Width = 98
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Scope.HeaderText = "Scope"
        Me.Scope.Name = "Scope"
        Me.Scope.ReadOnly = True
        Me.Scope.Width = 63
        '
        'UnitLocation
        '
        Me.UnitLocation.HeaderText = "Location"
        Me.UnitLocation.Name = "UnitLocation"
        Me.UnitLocation.ReadOnly = True
        Me.UnitLocation.Width = 65
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TestDGV)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.ActualDGV)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.ScheduleDGV)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TestDGV
        '
        Me.TestDGV.AllowUserToAddRows = False
        Me.TestDGV.AllowUserToDeleteRows = False
        Me.TestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestUnitID, Me.Tester, Me.TestDate, Me.ActionItems})
        Me.TestDGV.Location = New System.Drawing.Point(6, 317)
        Me.TestDGV.Name = "TestDGV"
        Me.TestDGV.ReadOnly = True
        Me.TestDGV.Size = New System.Drawing.Size(721, 99)
        Me.TestDGV.TabIndex = 5
        '
        'TestUnitID
        '
        Me.TestUnitID.HeaderText = "Unit ID"
        Me.TestUnitID.Name = "TestUnitID"
        Me.TestUnitID.ReadOnly = True
        Me.TestUnitID.Width = 65
        '
        'Tester
        '
        Me.Tester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tester.HeaderText = "Tester"
        Me.Tester.Name = "Tester"
        Me.Tester.ReadOnly = True
        Me.Tester.Width = 62
        '
        'TestDate
        '
        Me.TestDate.HeaderText = "Tested"
        Me.TestDate.Name = "TestDate"
        Me.TestDate.ReadOnly = True
        Me.TestDate.Width = 65
        '
        'ActionItems
        '
        Me.ActionItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ActionItems.HeaderText = "Action Items"
        Me.ActionItems.Name = "ActionItems"
        Me.ActionItems.ReadOnly = True
        Me.ActionItems.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActionItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ActionItems.Width = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Test Info"
        '
        'ActualDGV
        '
        Me.ActualDGV.AllowUserToAddRows = False
        Me.ActualDGV.AllowUserToDeleteRows = False
        Me.ActualDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActualDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActualUnitID, Me.AUAD, Me.APHOD, Me.APCD, Me.ASD})
        Me.ActualDGV.Location = New System.Drawing.Point(6, 178)
        Me.ActualDGV.Name = "ActualDGV"
        Me.ActualDGV.ReadOnly = True
        Me.ActualDGV.Size = New System.Drawing.Size(721, 99)
        Me.ActualDGV.TabIndex = 3
        '
        'ActualUnitID
        '
        Me.ActualUnitID.HeaderText = "Unit ID"
        Me.ActualUnitID.Name = "ActualUnitID"
        Me.ActualUnitID.ReadOnly = True
        Me.ActualUnitID.Width = 65
        '
        'AUAD
        '
        Me.AUAD.HeaderText = "AUAD"
        Me.AUAD.Name = "AUAD"
        Me.AUAD.ReadOnly = True
        Me.AUAD.Width = 65
        '
        'APHOD
        '
        Me.APHOD.HeaderText = "APHOD"
        Me.APHOD.Name = "APHOD"
        Me.APHOD.ReadOnly = True
        Me.APHOD.Width = 65
        '
        'APCD
        '
        Me.APCD.HeaderText = "APCD"
        Me.APCD.Name = "APCD"
        Me.APCD.ReadOnly = True
        Me.APCD.Width = 65
        '
        'ASD
        '
        Me.ASD.HeaderText = "ASD"
        Me.ASD.Name = "ASD"
        Me.ASD.ReadOnly = True
        Me.ASD.Width = 65
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Actual"
        '
        'ScheduleDGV
        '
        Me.ScheduleDGV.AllowUserToAddRows = False
        Me.ScheduleDGV.AllowUserToDeleteRows = False
        Me.ScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScheduleUnitID, Me.EUAD, Me.PHOD, Me.PCD, Me.ESD, Me.Type})
        Me.ScheduleDGV.Location = New System.Drawing.Point(6, 41)
        Me.ScheduleDGV.Name = "ScheduleDGV"
        Me.ScheduleDGV.ReadOnly = True
        Me.ScheduleDGV.Size = New System.Drawing.Size(721, 99)
        Me.ScheduleDGV.TabIndex = 1
        '
        'ScheduleUnitID
        '
        Me.ScheduleUnitID.HeaderText = "Unit ID"
        Me.ScheduleUnitID.Name = "ScheduleUnitID"
        Me.ScheduleUnitID.ReadOnly = True
        Me.ScheduleUnitID.Width = 65
        '
        'EUAD
        '
        Me.EUAD.HeaderText = "EUAD"
        Me.EUAD.Name = "EUAD"
        Me.EUAD.ReadOnly = True
        Me.EUAD.Width = 65
        '
        'PHOD
        '
        Me.PHOD.HeaderText = "PHOD"
        Me.PHOD.Name = "PHOD"
        Me.PHOD.ReadOnly = True
        Me.PHOD.Width = 65
        '
        'PCD
        '
        Me.PCD.HeaderText = "PCD"
        Me.PCD.Name = "PCD"
        Me.PCD.ReadOnly = True
        Me.PCD.Width = 65
        '
        'ESD
        '
        Me.ESD.HeaderText = "ESD"
        Me.ESD.Name = "ESD"
        Me.ESD.ReadOnly = True
        Me.ESD.Width = 65
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Schedule"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(733, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Change Order"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(733, 531)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Navigation"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(20, 250)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Edit PO Amount"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(20, 203)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Edit Location"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(20, 161)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Edit Scope"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Edit Serial Number"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit Model Number"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(20, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Test Notes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(603, 52)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(69, 23)
        Me.RefreshBtn.TabIndex = 10
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'JobNumber
        '
        Me.JobNumber.BackColor = System.Drawing.SystemColors.Window
        Me.JobNumber.Location = New System.Drawing.Point(12, 28)
        Me.JobNumber.MaxLength = 4
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(100, 20)
        Me.JobNumber.TabIndex = 4
        Me.JobNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JobName
        '
        Me.JobName.Location = New System.Drawing.Point(136, 28)
        Me.JobName.Name = "JobName"
        Me.JobName.ReadOnly = True
        Me.JobName.Size = New System.Drawing.Size(100, 20)
        Me.JobName.TabIndex = 4
        Me.JobName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Job Name"
        '
        'SoldBy
        '
        Me.SoldBy.Location = New System.Drawing.Point(390, 28)
        Me.SoldBy.Name = "SoldBy"
        Me.SoldBy.ReadOnly = True
        Me.SoldBy.Size = New System.Drawing.Size(100, 20)
        Me.SoldBy.TabIndex = 6
        Me.SoldBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sold By"
        '
        'Priority
        '
        Me.Priority.Location = New System.Drawing.Point(522, 28)
        Me.Priority.Name = "Priority"
        Me.Priority.ReadOnly = True
        Me.Priority.Size = New System.Drawing.Size(100, 20)
        Me.Priority.TabIndex = 8
        Me.Priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(519, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Priority"
        '
        'POAmount
        '
        Me.POAmount.Location = New System.Drawing.Point(653, 28)
        Me.POAmount.Name = "POAmount"
        Me.POAmount.ReadOnly = True
        Me.POAmount.Size = New System.Drawing.Size(100, 20)
        Me.POAmount.TabIndex = 10
        Me.POAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(650, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PO Amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(260, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Engineer"
        '
        'Engineer
        '
        Me.Engineer.Location = New System.Drawing.Point(263, 28)
        Me.Engineer.Name = "Engineer"
        Me.Engineer.ReadOnly = True
        Me.Engineer.Size = New System.Drawing.Size(100, 20)
        Me.Engineer.TabIndex = 12
        Me.Engineer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(678, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MasterRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 628)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Engineer)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.POAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Priority)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SoldBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.JobName)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MasterRecord"
        Me.Text = "Master Record"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.UnitNoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubmittalNoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitInfoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TestDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents JobNumberSql As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents UnitInfoDGV As DataGridView
    Friend WithEvents JobNumber As TextBox
    Friend WithEvents JobName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SoldBy As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Priority As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents POAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SalesNote As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UnitNoteDGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents SubmittalNoteDGV As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ActualDGV As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents ScheduleDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TestDGV As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Engineer As TextBox
    Friend WithEvents UnitNoteUnitID As DataGridViewTextBoxColumn
    Friend WithEvents UnitNote As DataGridViewTextBoxColumn
    Friend WithEvents SubmittalNoteUnitID As DataGridViewTextBoxColumn
    Friend WithEvents SubmittalNote As DataGridViewTextBoxColumn
    Friend WithEvents ActualUnitID As DataGridViewTextBoxColumn
    Friend WithEvents AUAD As DataGridViewTextBoxColumn
    Friend WithEvents APHOD As DataGridViewTextBoxColumn
    Friend WithEvents APCD As DataGridViewTextBoxColumn
    Friend WithEvents ASD As DataGridViewTextBoxColumn
    Friend WithEvents ScheduleUnitID As DataGridViewTextBoxColumn
    Friend WithEvents EUAD As DataGridViewTextBoxColumn
    Friend WithEvents PHOD As DataGridViewTextBoxColumn
    Friend WithEvents PCD As DataGridViewTextBoxColumn
    Friend WithEvents ESD As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents Tag As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumber As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocation As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents TestUnitID As DataGridViewTextBoxColumn
    Friend WithEvents Tester As DataGridViewTextBoxColumn
    Friend WithEvents TestDate As DataGridViewTextBoxColumn
    Friend WithEvents ActionItems As DataGridViewButtonColumn
    Friend WithEvents Button7 As Button
End Class
