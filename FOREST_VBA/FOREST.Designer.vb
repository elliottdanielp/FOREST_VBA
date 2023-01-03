<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FOREST
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Handoff")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assign Engineer")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Engineering Schedule")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Engineering", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schedule Job")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Engineering Release")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production Handoff")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schedule Unit In")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Project Managment", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production Complete")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ready To Ship")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Testing")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unit Arrival")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unit In")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unit Out")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unit Shipped")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shipping", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master Record")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Records", New System.Windows.Forms.TreeNode() {TreeNode20})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FOREST))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UnitLocationBay1 = New System.Windows.Forms.DataGridView()
        Me.Bay1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay2A = New System.Windows.Forms.DataGridView()
        Me.Bay2A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay2B = New System.Windows.Forms.DataGridView()
        Me.Bay2B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay3A = New System.Windows.Forms.DataGridView()
        Me.Bay3A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay3B = New System.Windows.Forms.DataGridView()
        Me.Bay3B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay4A = New System.Windows.Forms.DataGridView()
        Me.Bay4A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay4B = New System.Windows.Forms.DataGridView()
        Me.Bay4B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay5 = New System.Windows.Forms.DataGridView()
        Me.Bay5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationBay6 = New System.Windows.Forms.DataGridView()
        Me.Bay6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationComplete = New System.Windows.Forms.DataGridView()
        Me.Complete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitLocationOutSide = New System.Windows.Forms.DataGridView()
        Me.OutSide = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AsOf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WIP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Shipments = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        CType(Me.UnitLocationBay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay2A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay2B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay3A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay3B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay4A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay4B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationBay6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLocationOutSide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(5, 11)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "SalesHandoff"
        TreeNode1.Text = "Handoff"
        TreeNode2.Name = "SalesRoot"
        TreeNode2.Text = "Sales"
        TreeNode3.Name = "AssignEngineer"
        TreeNode3.Text = "Assign Engineer"
        TreeNode4.Name = "EngineeringSchedule"
        TreeNode4.Text = "Engineering Schedule"
        TreeNode5.Name = "EngineeringRoot"
        TreeNode5.Text = "Engineering"
        TreeNode6.Name = "ScheduleJob"
        TreeNode6.Text = "Schedule Job"
        TreeNode7.Name = "Engineering Release"
        TreeNode7.Text = "Engineering Release"
        TreeNode8.Name = "ProductionHandOff"
        TreeNode8.Text = "Production Handoff"
        TreeNode9.Name = "ScheduleUnitIn"
        TreeNode9.Text = "Schedule Unit In"
        TreeNode10.Name = "ScheduleRoot"
        TreeNode10.Text = "Project Managment"
        TreeNode11.Name = "ProductionComplete"
        TreeNode11.Text = "Production Complete"
        TreeNode12.Name = "ReadyToShip"
        TreeNode12.Text = "Ready To Ship"
        TreeNode13.Name = "Testing"
        TreeNode13.Text = "Testing"
        TreeNode14.Name = "ProductionRoot"
        TreeNode14.Text = "Production"
        TreeNode15.Name = "UnitArrival"
        TreeNode15.Text = "Unit Arrival"
        TreeNode16.Name = "UnitIn"
        TreeNode16.Text = "Unit In"
        TreeNode17.Name = "UnitOut"
        TreeNode17.Text = "Unit Out"
        TreeNode18.Name = "Shipped"
        TreeNode18.Text = "Unit Shipped"
        TreeNode19.Name = "ShippingRoot"
        TreeNode19.Text = "Shipping"
        TreeNode20.Name = "MasterRecord"
        TreeNode20.Text = "Master Record"
        TreeNode21.Name = "RecordsRoot"
        TreeNode21.Text = "Records"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode10, TreeNode14, TreeNode19, TreeNode21})
        Me.TreeView1.Size = New System.Drawing.Size(170, 463)
        Me.TreeView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Job Location"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBtn.Location = New System.Drawing.Point(933, 454)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(65, 22)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGreen
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(188, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(18, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Orange
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(345, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(18, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightCoral
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(493, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(18, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(610, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(18, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "= Production Handed Off"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "= Production Complete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(511, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "= Test Complete"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(627, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "= Ready To Ship"
        '
        'UnitLocationBay1
        '
        Me.UnitLocationBay1.AllowUserToAddRows = False
        Me.UnitLocationBay1.AllowUserToDeleteRows = False
        Me.UnitLocationBay1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay1.DefaultCellStyle = DataGridViewCellStyle1
        Me.UnitLocationBay1.Location = New System.Drawing.Point(81, 5)
        Me.UnitLocationBay1.Name = "UnitLocationBay1"
        Me.UnitLocationBay1.ReadOnly = True
        Me.UnitLocationBay1.RowHeadersVisible = False
        Me.UnitLocationBay1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay1.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay1.TabIndex = 1
        '
        'Bay1
        '
        Me.Bay1.HeaderText = "Bay 1"
        Me.Bay1.Name = "Bay1"
        Me.Bay1.ReadOnly = True
        Me.Bay1.Width = 65
        '
        'UnitLocationBay2A
        '
        Me.UnitLocationBay2A.AllowUserToAddRows = False
        Me.UnitLocationBay2A.AllowUserToDeleteRows = False
        Me.UnitLocationBay2A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay2A.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay2A})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay2A.DefaultCellStyle = DataGridViewCellStyle2
        Me.UnitLocationBay2A.Location = New System.Drawing.Point(155, 5)
        Me.UnitLocationBay2A.Name = "UnitLocationBay2A"
        Me.UnitLocationBay2A.ReadOnly = True
        Me.UnitLocationBay2A.RowHeadersVisible = False
        Me.UnitLocationBay2A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay2A.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay2A.TabIndex = 2
        '
        'Bay2A
        '
        Me.Bay2A.HeaderText = "Bay 2A"
        Me.Bay2A.Name = "Bay2A"
        Me.Bay2A.ReadOnly = True
        Me.Bay2A.Width = 65
        '
        'UnitLocationBay2B
        '
        Me.UnitLocationBay2B.AllowUserToAddRows = False
        Me.UnitLocationBay2B.AllowUserToDeleteRows = False
        Me.UnitLocationBay2B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay2B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay2B})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay2B.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnitLocationBay2B.Location = New System.Drawing.Point(229, 5)
        Me.UnitLocationBay2B.Name = "UnitLocationBay2B"
        Me.UnitLocationBay2B.ReadOnly = True
        Me.UnitLocationBay2B.RowHeadersVisible = False
        Me.UnitLocationBay2B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay2B.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay2B.TabIndex = 3
        '
        'Bay2B
        '
        Me.Bay2B.HeaderText = "Bay 2B"
        Me.Bay2B.Name = "Bay2B"
        Me.Bay2B.ReadOnly = True
        Me.Bay2B.Width = 65
        '
        'UnitLocationBay3A
        '
        Me.UnitLocationBay3A.AllowUserToAddRows = False
        Me.UnitLocationBay3A.AllowUserToDeleteRows = False
        Me.UnitLocationBay3A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay3A.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay3A})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay3A.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnitLocationBay3A.Location = New System.Drawing.Point(303, 5)
        Me.UnitLocationBay3A.Name = "UnitLocationBay3A"
        Me.UnitLocationBay3A.ReadOnly = True
        Me.UnitLocationBay3A.RowHeadersVisible = False
        Me.UnitLocationBay3A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay3A.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay3A.TabIndex = 4
        '
        'Bay3A
        '
        Me.Bay3A.HeaderText = "Bay 3A"
        Me.Bay3A.Name = "Bay3A"
        Me.Bay3A.ReadOnly = True
        Me.Bay3A.Width = 65
        '
        'UnitLocationBay3B
        '
        Me.UnitLocationBay3B.AllowUserToAddRows = False
        Me.UnitLocationBay3B.AllowUserToDeleteRows = False
        Me.UnitLocationBay3B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay3B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay3B})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay3B.DefaultCellStyle = DataGridViewCellStyle5
        Me.UnitLocationBay3B.Location = New System.Drawing.Point(377, 5)
        Me.UnitLocationBay3B.Name = "UnitLocationBay3B"
        Me.UnitLocationBay3B.ReadOnly = True
        Me.UnitLocationBay3B.RowHeadersVisible = False
        Me.UnitLocationBay3B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay3B.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay3B.TabIndex = 5
        '
        'Bay3B
        '
        Me.Bay3B.HeaderText = "Bay 3B"
        Me.Bay3B.Name = "Bay3B"
        Me.Bay3B.ReadOnly = True
        Me.Bay3B.Width = 65
        '
        'UnitLocationBay4A
        '
        Me.UnitLocationBay4A.AllowUserToAddRows = False
        Me.UnitLocationBay4A.AllowUserToDeleteRows = False
        Me.UnitLocationBay4A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay4A.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay4A})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay4A.DefaultCellStyle = DataGridViewCellStyle6
        Me.UnitLocationBay4A.Location = New System.Drawing.Point(451, 5)
        Me.UnitLocationBay4A.Name = "UnitLocationBay4A"
        Me.UnitLocationBay4A.ReadOnly = True
        Me.UnitLocationBay4A.RowHeadersVisible = False
        Me.UnitLocationBay4A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay4A.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay4A.TabIndex = 6
        '
        'Bay4A
        '
        Me.Bay4A.HeaderText = "Bay 4A"
        Me.Bay4A.Name = "Bay4A"
        Me.Bay4A.ReadOnly = True
        Me.Bay4A.Width = 65
        '
        'UnitLocationBay4B
        '
        Me.UnitLocationBay4B.AllowUserToAddRows = False
        Me.UnitLocationBay4B.AllowUserToDeleteRows = False
        Me.UnitLocationBay4B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay4B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay4B})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay4B.DefaultCellStyle = DataGridViewCellStyle7
        Me.UnitLocationBay4B.Location = New System.Drawing.Point(525, 5)
        Me.UnitLocationBay4B.Name = "UnitLocationBay4B"
        Me.UnitLocationBay4B.ReadOnly = True
        Me.UnitLocationBay4B.RowHeadersVisible = False
        Me.UnitLocationBay4B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay4B.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay4B.TabIndex = 7
        '
        'Bay4B
        '
        Me.Bay4B.HeaderText = "Bay 4B"
        Me.Bay4B.Name = "Bay4B"
        Me.Bay4B.ReadOnly = True
        Me.Bay4B.Width = 65
        '
        'UnitLocationBay5
        '
        Me.UnitLocationBay5.AllowUserToAddRows = False
        Me.UnitLocationBay5.AllowUserToDeleteRows = False
        Me.UnitLocationBay5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay5.DefaultCellStyle = DataGridViewCellStyle8
        Me.UnitLocationBay5.Location = New System.Drawing.Point(599, 5)
        Me.UnitLocationBay5.Name = "UnitLocationBay5"
        Me.UnitLocationBay5.ReadOnly = True
        Me.UnitLocationBay5.RowHeadersVisible = False
        Me.UnitLocationBay5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay5.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay5.TabIndex = 8
        '
        'Bay5
        '
        Me.Bay5.HeaderText = "Bay 5"
        Me.Bay5.Name = "Bay5"
        Me.Bay5.ReadOnly = True
        Me.Bay5.Width = 65
        '
        'UnitLocationBay6
        '
        Me.UnitLocationBay6.AllowUserToAddRows = False
        Me.UnitLocationBay6.AllowUserToDeleteRows = False
        Me.UnitLocationBay6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationBay6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bay6})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationBay6.DefaultCellStyle = DataGridViewCellStyle9
        Me.UnitLocationBay6.Location = New System.Drawing.Point(673, 5)
        Me.UnitLocationBay6.Name = "UnitLocationBay6"
        Me.UnitLocationBay6.ReadOnly = True
        Me.UnitLocationBay6.RowHeadersVisible = False
        Me.UnitLocationBay6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationBay6.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationBay6.TabIndex = 9
        '
        'Bay6
        '
        Me.Bay6.HeaderText = "Bay 6"
        Me.Bay6.Name = "Bay6"
        Me.Bay6.ReadOnly = True
        Me.Bay6.Width = 65
        '
        'UnitLocationComplete
        '
        Me.UnitLocationComplete.AllowUserToAddRows = False
        Me.UnitLocationComplete.AllowUserToDeleteRows = False
        Me.UnitLocationComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationComplete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Complete})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UnitLocationComplete.DefaultCellStyle = DataGridViewCellStyle10
        Me.UnitLocationComplete.Location = New System.Drawing.Point(747, 5)
        Me.UnitLocationComplete.Name = "UnitLocationComplete"
        Me.UnitLocationComplete.ReadOnly = True
        Me.UnitLocationComplete.RowHeadersVisible = False
        Me.UnitLocationComplete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationComplete.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationComplete.TabIndex = 10
        '
        'Complete
        '
        Me.Complete.HeaderText = "Complete"
        Me.Complete.Name = "Complete"
        Me.Complete.ReadOnly = True
        Me.Complete.Width = 65
        '
        'UnitLocationOutSide
        '
        Me.UnitLocationOutSide.AllowUserToAddRows = False
        Me.UnitLocationOutSide.AllowUserToDeleteRows = False
        Me.UnitLocationOutSide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitLocationOutSide.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OutSide})
        Me.UnitLocationOutSide.Location = New System.Drawing.Point(7, 5)
        Me.UnitLocationOutSide.Name = "UnitLocationOutSide"
        Me.UnitLocationOutSide.ReadOnly = True
        Me.UnitLocationOutSide.RowHeadersVisible = False
        Me.UnitLocationOutSide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnitLocationOutSide.Size = New System.Drawing.Size(68, 365)
        Me.UnitLocationOutSide.TabIndex = 11
        '
        'OutSide
        '
        Me.OutSide.HeaderText = "Outside"
        Me.OutSide.Name = "OutSide"
        Me.OutSide.ReadOnly = True
        Me.OutSide.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OutSide.Width = 65
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UnitLocationOutSide)
        Me.Panel1.Controls.Add(Me.UnitLocationBay1)
        Me.Panel1.Controls.Add(Me.UnitLocationComplete)
        Me.Panel1.Controls.Add(Me.UnitLocationBay2A)
        Me.Panel1.Controls.Add(Me.UnitLocationBay2B)
        Me.Panel1.Controls.Add(Me.UnitLocationBay3A)
        Me.Panel1.Controls.Add(Me.UnitLocationBay6)
        Me.Panel1.Controls.Add(Me.UnitLocationBay3B)
        Me.Panel1.Controls.Add(Me.UnitLocationBay4A)
        Me.Panel1.Controls.Add(Me.UnitLocationBay5)
        Me.Panel1.Controls.Add(Me.UnitLocationBay4B)
        Me.Panel1.Location = New System.Drawing.Point(181, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 380)
        Me.Panel1.TabIndex = 12
        '
        'AsOf
        '
        Me.AsOf.Location = New System.Drawing.Point(220, 454)
        Me.AsOf.Name = "AsOf"
        Me.AsOf.ReadOnly = True
        Me.AsOf.Size = New System.Drawing.Size(100, 20)
        Me.AsOf.TabIndex = 13
        Me.AsOf.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "As Of"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(357, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "WIP"
        Me.Label7.Visible = False
        '
        'WIP
        '
        Me.WIP.Location = New System.Drawing.Point(391, 456)
        Me.WIP.Name = "WIP"
        Me.WIP.ReadOnly = True
        Me.WIP.Size = New System.Drawing.Size(100, 20)
        Me.WIP.TabIndex = 16
        Me.WIP.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(540, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Shipments"
        Me.Label8.Visible = False
        '
        'Shipments
        '
        Me.Shipments.Location = New System.Drawing.Point(602, 456)
        Me.Shipments.Name = "Shipments"
        Me.Shipments.ReadOnly = True
        Me.Shipments.Size = New System.Drawing.Size(100, 20)
        Me.Shipments.TabIndex = 18
        Me.Shipments.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(745, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total"
        Me.Label9.Visible = False
        '
        'Total
        '
        Me.Total.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Total.Location = New System.Drawing.Point(782, 454)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 20
        Me.Total.Visible = False
        '
        'FOREST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 486)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Shipments)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.WIP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AsOf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FOREST"
        Me.Text = "FOREST"
        CType(Me.UnitLocationBay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay2A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay2B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay3A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay3B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay4A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay4B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationBay6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLocationOutSide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UnitLocationOutSide As DataGridView
    Friend WithEvents UnitLocationComplete As DataGridView
    Friend WithEvents Complete As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay6 As DataGridView
    Friend WithEvents Bay6 As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay5 As DataGridView
    Friend WithEvents Bay5 As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay4B As DataGridView
    Friend WithEvents Bay4B As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay4A As DataGridView
    Friend WithEvents Bay4A As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay3B As DataGridView
    Friend WithEvents Bay3B As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay3A As DataGridView
    Friend WithEvents Bay3A As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay2B As DataGridView
    Friend WithEvents Bay2B As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay2A As DataGridView
    Friend WithEvents Bay2A As DataGridViewTextBoxColumn
    Friend WithEvents UnitLocationBay1 As DataGridView
    Friend WithEvents Bay1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OutSide As DataGridViewTextBoxColumn
    Friend WithEvents AsOf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WIP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Shipments As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Total As TextBox
End Class
