<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shipped
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shipped))
        Me.ReadyToShipDGV = New System.Windows.Forms.DataGridView()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShippedDGV = New System.Windows.Forms.DataGridView()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sqlJobNumber = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ASD = New System.Windows.Forms.TextBox()
        CType(Me.ReadyToShipDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippedDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReadyToShipDGV
        '
        Me.ReadyToShipDGV.AllowUserToAddRows = False
        Me.ReadyToShipDGV.AllowUserToDeleteRows = False
        Me.ReadyToShipDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReadyToShipDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitID, Me.ModelNumber, Me.SerialNumber, Me.ESD})
        Me.ReadyToShipDGV.Location = New System.Drawing.Point(12, 41)
        Me.ReadyToShipDGV.Name = "ReadyToShipDGV"
        Me.ReadyToShipDGV.ReadOnly = True
        Me.ReadyToShipDGV.RowHeadersWidth = 51
        Me.ReadyToShipDGV.Size = New System.Drawing.Size(428, 117)
        Me.ReadyToShipDGV.TabIndex = 0
        '
        'UnitID
        '
        Me.UnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        'SerialNumber
        '
        Me.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerialNumber.HeaderText = "Serial Number"
        Me.SerialNumber.MinimumWidth = 6
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.ReadOnly = True
        Me.SerialNumber.Width = 98
        '
        'ESD
        '
        Me.ESD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESD.HeaderText = "ESD"
        Me.ESD.MinimumWidth = 6
        Me.ESD.Name = "ESD"
        Me.ESD.ReadOnly = True
        Me.ESD.Width = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ready To Ship"
        '
        'ShippedDGV
        '
        Me.ShippedDGV.AllowUserToAddRows = False
        Me.ShippedDGV.AllowUserToDeleteRows = False
        Me.ShippedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShippedDGV.Location = New System.Drawing.Point(12, 251)
        Me.ShippedDGV.Name = "ShippedDGV"
        Me.ShippedDGV.ReadOnly = True
        Me.ShippedDGV.RowHeadersWidth = 51
        Me.ShippedDGV.Size = New System.Drawing.Size(428, 113)
        Me.ShippedDGV.TabIndex = 2
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(365, 378)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 3
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(12, 191)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(121, 21)
        Me.JobNumber.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Unit Selection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Shipped"
        '
        'sqlJobNumber
        '
        Me.sqlJobNumber.Location = New System.Drawing.Point(274, 185)
        Me.sqlJobNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sqlJobNumber.Name = "sqlJobNumber"
        Me.sqlJobNumber.Size = New System.Drawing.Size(106, 20)
        Me.sqlJobNumber.TabIndex = 7
        Me.sqlJobNumber.Visible = False
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(156, 187)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(76, 27)
        Me.AddBtn.TabIndex = 8
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ASD
        '
        Me.ASD.Location = New System.Drawing.Point(304, 163)
        Me.ASD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ASD.Name = "ASD"
        Me.ASD.Size = New System.Drawing.Size(76, 20)
        Me.ASD.TabIndex = 9
        Me.ASD.Visible = False
        '
        'Shipped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 413)
        Me.Controls.Add(Me.ASD)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.sqlJobNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.ShippedDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReadyToShipDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Shipped"
        Me.Text = "Unit Shipped"
        CType(Me.ReadyToShipDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippedDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadyToShipDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents UnitID As DataGridViewTextBoxColumn
    Friend WithEvents ModelNumber As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumber As DataGridViewTextBoxColumn
    Friend WithEvents ESD As DataGridViewTextBoxColumn
    Friend WithEvents ShippedDGV As DataGridView
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sqlJobNumber As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents ASD As TextBox
End Class
