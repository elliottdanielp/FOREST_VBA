<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EngineeringSchedule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EngineeringSchedule))
        Me.EngineerScheduleData = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubmittalPromise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineeringRelease = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongLead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SheetMetal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mechanical = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Refrigeration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hydronics = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EChecked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MChecked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineeringCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EngineerSelection = New System.Windows.Forms.ComboBox()
        Me.UnitIDDD = New System.Windows.Forms.ComboBox()
        Me.ECheckedDD = New System.Windows.Forms.ComboBox()
        Me.MCheckedDD = New System.Windows.Forms.ComboBox()
        Me.SheetMetalDD = New System.Windows.Forms.ComboBox()
        Me.IOMDD = New System.Windows.Forms.ComboBox()
        Me.MechanicalDD = New System.Windows.Forms.ComboBox()
        Me.CULDD = New System.Windows.Forms.ComboBox()
        Me.RefrigerationDD = New System.Windows.Forms.ComboBox()
        Me.ProgramDD = New System.Windows.Forms.ComboBox()
        Me.ControlsDD = New System.Windows.Forms.ComboBox()
        Me.PowerDD = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.HydronicsDD = New System.Windows.Forms.ComboBox()
        Me.BOMDD = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LongLeadDD = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EngineeringComplteCHK = New System.Windows.Forms.CheckBox()
        Me.SubmitBTN = New System.Windows.Forms.Button()
        Me.CompleteDate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UnitLocationTbl = New System.Windows.Forms.DataGridView()
        Me.InsideUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsideUnitLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EngineerScheduleData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EngineerScheduleData
        '
        Me.EngineerScheduleData.AllowUserToAddRows = False
        Me.EngineerScheduleData.AllowUserToDeleteRows = False
        Me.EngineerScheduleData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EngineerScheduleData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EngineerScheduleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EngineerScheduleData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.Model, Me.Scope, Me.SubmittalPromise, Me.EngineeringRelease, Me.LongLead, Me.SheetMetal, Me.Mechanical, Me.Refrigeration, Me.Hydronics, Me.Power, Me.Control, Me.Program, Me.BOM, Me.IOM, Me.CUL, Me.EChecked, Me.MChecked, Me.EngineeringCompleted, Me.PHOD})
        Me.EngineerScheduleData.Location = New System.Drawing.Point(12, 35)
        Me.EngineerScheduleData.Name = "EngineerScheduleData"
        Me.EngineerScheduleData.ReadOnly = True
        Me.EngineerScheduleData.Size = New System.Drawing.Size(1224, 436)
        Me.EngineerScheduleData.TabIndex = 0
        '
        'UnitID
        '
        Me.UnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitID.HeaderText = "Job"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitID.Width = 65
        '
        'Model
        '
        Me.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        Me.Model.Width = 61
        '
        'Scope
        '
        Me.Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Scope.HeaderText = "Scope"
        Me.Scope.Name = "Scope"
        Me.Scope.ReadOnly = True
        Me.Scope.Width = 63
        '
        'SubmittalPromise
        '
        Me.SubmittalPromise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubmittalPromise.HeaderText = "Sup Prom"
        Me.SubmittalPromise.Name = "SubmittalPromise"
        Me.SubmittalPromise.ReadOnly = True
        Me.SubmittalPromise.Width = 80
        '
        'EngineeringRelease
        '
        Me.EngineeringRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EngineeringRelease.HeaderText = "Realease"
        Me.EngineeringRelease.Name = "EngineeringRelease"
        Me.EngineeringRelease.ReadOnly = True
        Me.EngineeringRelease.Width = 80
        '
        'LongLead
        '
        Me.LongLead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LongLead.HeaderText = "LL"
        Me.LongLead.Name = "LongLead"
        Me.LongLead.ReadOnly = True
        Me.LongLead.Width = 30
        '
        'SheetMetal
        '
        Me.SheetMetal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SheetMetal.HeaderText = "SM"
        Me.SheetMetal.Name = "SheetMetal"
        Me.SheetMetal.ReadOnly = True
        Me.SheetMetal.Width = 30
        '
        'Mechanical
        '
        Me.Mechanical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Mechanical.HeaderText = "Mec"
        Me.Mechanical.Name = "Mechanical"
        Me.Mechanical.ReadOnly = True
        Me.Mechanical.Width = 35
        '
        'Refrigeration
        '
        Me.Refrigeration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Refrigeration.HeaderText = "Ref"
        Me.Refrigeration.Name = "Refrigeration"
        Me.Refrigeration.ReadOnly = True
        Me.Refrigeration.Width = 30
        '
        'Hydronics
        '
        Me.Hydronics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Hydronics.HeaderText = "Hyd"
        Me.Hydronics.Name = "Hydronics"
        Me.Hydronics.ReadOnly = True
        Me.Hydronics.Width = 30
        '
        'Power
        '
        Me.Power.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Power.HeaderText = "Pwr"
        Me.Power.Name = "Power"
        Me.Power.ReadOnly = True
        Me.Power.Width = 30
        '
        'Control
        '
        Me.Control.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Control.HeaderText = "Ctrl"
        Me.Control.Name = "Control"
        Me.Control.ReadOnly = True
        Me.Control.Width = 30
        '
        'Program
        '
        Me.Program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Program.HeaderText = "Prg"
        Me.Program.Name = "Program"
        Me.Program.ReadOnly = True
        Me.Program.Width = 30
        '
        'BOM
        '
        Me.BOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BOM.HeaderText = "BOM"
        Me.BOM.Name = "BOM"
        Me.BOM.ReadOnly = True
        Me.BOM.Width = 35
        '
        'IOM
        '
        Me.IOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IOM.HeaderText = "IOM"
        Me.IOM.Name = "IOM"
        Me.IOM.ReadOnly = True
        Me.IOM.Width = 30
        '
        'CUL
        '
        Me.CUL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CUL.HeaderText = "CUL"
        Me.CUL.Name = "CUL"
        Me.CUL.ReadOnly = True
        Me.CUL.Width = 35
        '
        'EChecked
        '
        Me.EChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EChecked.HeaderText = "ECk"
        Me.EChecked.Name = "EChecked"
        Me.EChecked.ReadOnly = True
        Me.EChecked.Width = 35
        '
        'MChecked
        '
        Me.MChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MChecked.HeaderText = "MCk"
        Me.MChecked.Name = "MChecked"
        Me.MChecked.ReadOnly = True
        Me.MChecked.Width = 35
        '
        'EngineeringCompleted
        '
        Me.EngineeringCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EngineeringCompleted.HeaderText = "Completed"
        Me.EngineeringCompleted.Name = "EngineeringCompleted"
        Me.EngineeringCompleted.ReadOnly = True
        Me.EngineeringCompleted.Width = 80
        '
        'PHOD
        '
        Me.PHOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PHOD.HeaderText = "PHOD"
        Me.PHOD.Name = "PHOD"
        Me.PHOD.ReadOnly = True
        Me.PHOD.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Engineer"
        '
        'EngineerSelection
        '
        Me.EngineerSelection.FormattingEnabled = True
        Me.EngineerSelection.Items.AddRange(New Object() {"DJV", "DSC", "JBL", "JAM", "SRP", "SEM"})
        Me.EngineerSelection.Location = New System.Drawing.Point(64, 6)
        Me.EngineerSelection.Name = "EngineerSelection"
        Me.EngineerSelection.Size = New System.Drawing.Size(121, 21)
        Me.EngineerSelection.TabIndex = 2
        '
        'UnitIDDD
        '
        Me.UnitIDDD.FormattingEnabled = True
        Me.UnitIDDD.Location = New System.Drawing.Point(278, 487)
        Me.UnitIDDD.Name = "UnitIDDD"
        Me.UnitIDDD.Size = New System.Drawing.Size(121, 21)
        Me.UnitIDDD.TabIndex = 4
        '
        'ECheckedDD
        '
        Me.ECheckedDD.FormattingEnabled = True
        Me.ECheckedDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.ECheckedDD.Location = New System.Drawing.Point(1112, 487)
        Me.ECheckedDD.Name = "ECheckedDD"
        Me.ECheckedDD.Size = New System.Drawing.Size(121, 21)
        Me.ECheckedDD.TabIndex = 5
        '
        'MCheckedDD
        '
        Me.MCheckedDD.FormattingEnabled = True
        Me.MCheckedDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.MCheckedDD.Location = New System.Drawing.Point(1112, 513)
        Me.MCheckedDD.Name = "MCheckedDD"
        Me.MCheckedDD.Size = New System.Drawing.Size(121, 21)
        Me.MCheckedDD.TabIndex = 6
        '
        'SheetMetalDD
        '
        Me.SheetMetalDD.FormattingEnabled = True
        Me.SheetMetalDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.SheetMetalDD.Location = New System.Drawing.Point(487, 514)
        Me.SheetMetalDD.Name = "SheetMetalDD"
        Me.SheetMetalDD.Size = New System.Drawing.Size(121, 21)
        Me.SheetMetalDD.TabIndex = 7
        '
        'IOMDD
        '
        Me.IOMDD.FormattingEnabled = True
        Me.IOMDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.IOMDD.Location = New System.Drawing.Point(874, 517)
        Me.IOMDD.Name = "IOMDD"
        Me.IOMDD.Size = New System.Drawing.Size(121, 21)
        Me.IOMDD.TabIndex = 8
        '
        'MechanicalDD
        '
        Me.MechanicalDD.FormattingEnabled = True
        Me.MechanicalDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.MechanicalDD.Location = New System.Drawing.Point(487, 541)
        Me.MechanicalDD.Name = "MechanicalDD"
        Me.MechanicalDD.Size = New System.Drawing.Size(121, 21)
        Me.MechanicalDD.TabIndex = 9
        '
        'CULDD
        '
        Me.CULDD.FormattingEnabled = True
        Me.CULDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.CULDD.Location = New System.Drawing.Point(874, 544)
        Me.CULDD.Name = "CULDD"
        Me.CULDD.Size = New System.Drawing.Size(121, 21)
        Me.CULDD.TabIndex = 10
        '
        'RefrigerationDD
        '
        Me.RefrigerationDD.FormattingEnabled = True
        Me.RefrigerationDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.RefrigerationDD.Location = New System.Drawing.Point(487, 568)
        Me.RefrigerationDD.Name = "RefrigerationDD"
        Me.RefrigerationDD.Size = New System.Drawing.Size(121, 21)
        Me.RefrigerationDD.TabIndex = 11
        '
        'ProgramDD
        '
        Me.ProgramDD.FormattingEnabled = True
        Me.ProgramDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.ProgramDD.Location = New System.Drawing.Point(686, 568)
        Me.ProgramDD.Name = "ProgramDD"
        Me.ProgramDD.Size = New System.Drawing.Size(121, 21)
        Me.ProgramDD.TabIndex = 12
        '
        'ControlsDD
        '
        Me.ControlsDD.FormattingEnabled = True
        Me.ControlsDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.ControlsDD.Location = New System.Drawing.Point(686, 541)
        Me.ControlsDD.Name = "ControlsDD"
        Me.ControlsDD.Size = New System.Drawing.Size(121, 21)
        Me.ControlsDD.TabIndex = 16
        '
        'PowerDD
        '
        Me.PowerDD.FormattingEnabled = True
        Me.PowerDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.PowerDD.Location = New System.Drawing.Point(686, 514)
        Me.PowerDD.Name = "PowerDD"
        Me.PowerDD.Size = New System.Drawing.Size(121, 21)
        Me.PowerDD.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Job Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1029, 490)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Elec. Checked"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1023, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Mech. Checked"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sheet Metal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(841, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "IOM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(635, 544)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Controls"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(840, 547)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "CUL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(634, 571)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Program"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(643, 517)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Power"
        '
        'HydronicsDD
        '
        Me.HydronicsDD.FormattingEnabled = True
        Me.HydronicsDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.HydronicsDD.Location = New System.Drawing.Point(686, 487)
        Me.HydronicsDD.Name = "HydronicsDD"
        Me.HydronicsDD.Size = New System.Drawing.Size(121, 21)
        Me.HydronicsDD.TabIndex = 34
        '
        'BOMDD
        '
        Me.BOMDD.FormattingEnabled = True
        Me.BOMDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.BOMDD.Location = New System.Drawing.Point(874, 487)
        Me.BOMDD.Name = "BOMDD"
        Me.BOMDD.Size = New System.Drawing.Size(121, 21)
        Me.BOMDD.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(626, 490)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Hydronics"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(837, 490)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "BOM"
        '
        'LongLeadDD
        '
        Me.LongLeadDD.FormattingEnabled = True
        Me.LongLeadDD.Items.AddRange(New Object() {"Not Started", "In Process", "Complete", "Not Required"})
        Me.LongLeadDD.Location = New System.Drawing.Point(487, 487)
        Me.LongLeadDD.Name = "LongLeadDD"
        Me.LongLeadDD.Size = New System.Drawing.Size(121, 21)
        Me.LongLeadDD.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(423, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Long Lead"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 544)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Mechanical"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(414, 571)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Refrigeration"
        '
        'EngineeringComplteCHK
        '
        Me.EngineeringComplteCHK.AutoSize = True
        Me.EngineeringComplteCHK.Location = New System.Drawing.Point(1052, 562)
        Me.EngineeringComplteCHK.Name = "EngineeringComplteCHK"
        Me.EngineeringComplteCHK.Size = New System.Drawing.Size(129, 17)
        Me.EngineeringComplteCHK.TabIndex = 40
        Me.EngineeringComplteCHK.Text = "Engineering Complete"
        Me.EngineeringComplteCHK.UseVisualStyleBackColor = True
        '
        'SubmitBTN
        '
        Me.SubmitBTN.Location = New System.Drawing.Point(1158, 585)
        Me.SubmitBTN.Name = "SubmitBTN"
        Me.SubmitBTN.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBTN.TabIndex = 41
        Me.SubmitBTN.Text = "Complete"
        Me.SubmitBTN.UseVisualStyleBackColor = True
        '
        'CompleteDate
        '
        Me.CompleteDate.Location = New System.Drawing.Point(1052, 585)
        Me.CompleteDate.Name = "CompleteDate"
        Me.CompleteDate.Size = New System.Drawing.Size(100, 20)
        Me.CompleteDate.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Unit Location"
        '
        'UnitLocationTbl
        '
        Me.UnitLocationTbl.AllowUserToAddRows = False
        Me.UnitLocationTbl.AllowUserToDeleteRows = False
        Me.UnitLocationTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InsideUnitID, Me.InsideUnitLocation})
        Me.UnitLocationTbl.Location = New System.Drawing.Point(12, 490)
        Me.UnitLocationTbl.Name = "UnitLocationTbl"
        Me.UnitLocationTbl.ReadOnly = True
        Me.UnitLocationTbl.Size = New System.Drawing.Size(190, 121)
        Me.UnitLocationTbl.TabIndex = 43
        '
        'InsideUnitID
        '
        Me.InsideUnitID.HeaderText = "Job"
        Me.InsideUnitID.Name = "InsideUnitID"
        Me.InsideUnitID.ReadOnly = True
        Me.InsideUnitID.Width = 65
        '
        'InsideUnitLocation
        '
        Me.InsideUnitLocation.HeaderText = "Location"
        Me.InsideUnitLocation.Name = "InsideUnitLocation"
        Me.InsideUnitLocation.ReadOnly = True
        Me.InsideUnitLocation.Width = 65
        '
        'EngineeringSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 620)
        Me.Controls.Add(Me.UnitLocationTbl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CompleteDate)
        Me.Controls.Add(Me.SubmitBTN)
        Me.Controls.Add(Me.EngineeringComplteCHK)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LongLeadDD)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BOMDD)
        Me.Controls.Add(Me.HydronicsDD)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PowerDD)
        Me.Controls.Add(Me.ControlsDD)
        Me.Controls.Add(Me.ProgramDD)
        Me.Controls.Add(Me.RefrigerationDD)
        Me.Controls.Add(Me.CULDD)
        Me.Controls.Add(Me.MechanicalDD)
        Me.Controls.Add(Me.IOMDD)
        Me.Controls.Add(Me.SheetMetalDD)
        Me.Controls.Add(Me.MCheckedDD)
        Me.Controls.Add(Me.ECheckedDD)
        Me.Controls.Add(Me.UnitIDDD)
        Me.Controls.Add(Me.EngineerSelection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EngineerScheduleData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EngineeringSchedule"
        Me.Text = "Engineering Schedule"
        CType(Me.EngineerScheduleData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EngineerScheduleData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents EngineerSelection As ComboBox
    Friend WithEvents UnitIDDD As ComboBox
    Friend WithEvents ECheckedDD As ComboBox
    Friend WithEvents MCheckedDD As ComboBox
    Friend WithEvents SheetMetalDD As ComboBox
    Friend WithEvents IOMDD As ComboBox
    Friend WithEvents MechanicalDD As ComboBox
    Friend WithEvents CULDD As ComboBox
    Friend WithEvents RefrigerationDD As ComboBox
    Friend WithEvents ProgramDD As ComboBox
    Friend WithEvents ControlsDD As ComboBox
    Friend WithEvents PowerDD As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents HydronicsDD As ComboBox
    Friend WithEvents BOMDD As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LongLeadDD As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Scope As DataGridViewTextBoxColumn
    Friend WithEvents SubmittalPromise As DataGridViewTextBoxColumn
    Friend WithEvents EngineeringRelease As DataGridViewTextBoxColumn
    Friend WithEvents LongLead As DataGridViewTextBoxColumn
    Friend WithEvents SheetMetal As DataGridViewTextBoxColumn
    Friend WithEvents Mechanical As DataGridViewTextBoxColumn
    Friend WithEvents Refrigeration As DataGridViewTextBoxColumn
    Friend WithEvents Hydronics As DataGridViewTextBoxColumn
    Friend WithEvents Power As DataGridViewTextBoxColumn
    Friend WithEvents Control As DataGridViewTextBoxColumn
    Friend WithEvents Program As DataGridViewTextBoxColumn
    Friend WithEvents BOM As DataGridViewTextBoxColumn
    Friend WithEvents IOM As DataGridViewTextBoxColumn
    Friend WithEvents CUL As DataGridViewTextBoxColumn
    Friend WithEvents EChecked As DataGridViewTextBoxColumn
    Friend WithEvents MChecked As DataGridViewTextBoxColumn
    Friend WithEvents EngineeringCompleted As DataGridViewTextBoxColumn
    Friend WithEvents PHOD As DataGridViewTextBoxColumn
    Friend WithEvents EngineeringComplteCHK As CheckBox
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents CompleteDate As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents UnitLocationTbl As DataGridView
    Friend WithEvents InsideUnitID As DataGridViewTextBoxColumn
    Friend WithEvents InsideUnitLocation As DataGridViewTextBoxColumn
End Class
