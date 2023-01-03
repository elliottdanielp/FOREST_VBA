<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitSchedule))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnitID = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar3 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar4 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar5 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ScheduleType = New System.Windows.Forms.ComboBox()
        Me.EUAD = New System.Windows.Forms.TextBox()
        Me.SMHOD = New System.Windows.Forms.TextBox()
        Me.PHOD = New System.Windows.Forms.TextBox()
        Me.PCD = New System.Windows.Forms.TextBox()
        Me.ESD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.JobNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit ID"
        '
        'UnitID
        '
        Me.UnitID.FormattingEnabled = True
        Me.UnitID.Location = New System.Drawing.Point(59, 11)
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Size = New System.Drawing.Size(121, 21)
        Me.UnitID.TabIndex = 1
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(16, 43)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(261, 43)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 3
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.Location = New System.Drawing.Point(506, 43)
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.TabIndex = 4
        '
        'MonthCalendar4
        '
        Me.MonthCalendar4.Location = New System.Drawing.Point(751, 43)
        Me.MonthCalendar4.Name = "MonthCalendar4"
        Me.MonthCalendar4.TabIndex = 5
        '
        'MonthCalendar5
        '
        Me.MonthCalendar5.Location = New System.Drawing.Point(996, 43)
        Me.MonthCalendar5.Name = "MonthCalendar5"
        Me.MonthCalendar5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "EUAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SMHOD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PHOD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(748, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PCD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(993, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ESD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Type"
        '
        'ScheduleType
        '
        Me.ScheduleType.FormattingEnabled = True
        Me.ScheduleType.Items.AddRange(New Object() {"Preliminary", "Revised"})
        Me.ScheduleType.Location = New System.Drawing.Point(295, 11)
        Me.ScheduleType.Name = "ScheduleType"
        Me.ScheduleType.Size = New System.Drawing.Size(121, 21)
        Me.ScheduleType.TabIndex = 13
        '
        'EUAD
        '
        Me.EUAD.Location = New System.Drawing.Point(56, 211)
        Me.EUAD.Name = "EUAD"
        Me.EUAD.ReadOnly = True
        Me.EUAD.Size = New System.Drawing.Size(100, 20)
        Me.EUAD.TabIndex = 14
        '
        'SMHOD
        '
        Me.SMHOD.Location = New System.Drawing.Point(311, 211)
        Me.SMHOD.Name = "SMHOD"
        Me.SMHOD.ReadOnly = True
        Me.SMHOD.Size = New System.Drawing.Size(100, 20)
        Me.SMHOD.TabIndex = 15
        '
        'PHOD
        '
        Me.PHOD.Location = New System.Drawing.Point(547, 211)
        Me.PHOD.Name = "PHOD"
        Me.PHOD.ReadOnly = True
        Me.PHOD.Size = New System.Drawing.Size(100, 20)
        Me.PHOD.TabIndex = 16
        '
        'PCD
        '
        Me.PCD.Location = New System.Drawing.Point(783, 211)
        Me.PCD.Name = "PCD"
        Me.PCD.ReadOnly = True
        Me.PCD.Size = New System.Drawing.Size(100, 20)
        Me.PCD.TabIndex = 17
        '
        'ESD
        '
        Me.ESD.Location = New System.Drawing.Point(1028, 211)
        Me.ESD.Name = "ESD"
        Me.ESD.ReadOnly = True
        Me.ESD.Size = New System.Drawing.Size(100, 20)
        Me.ESD.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1148, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'JobNumber
        '
        Me.JobNumber.Location = New System.Drawing.Point(1123, 11)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.ReadOnly = True
        Me.JobNumber.Size = New System.Drawing.Size(100, 20)
        Me.JobNumber.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1053, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Job Number"
        '
        'UnitSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 246)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ESD)
        Me.Controls.Add(Me.PCD)
        Me.Controls.Add(Me.PHOD)
        Me.Controls.Add(Me.SMHOD)
        Me.Controls.Add(Me.EUAD)
        Me.Controls.Add(Me.ScheduleType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthCalendar5)
        Me.Controls.Add(Me.MonthCalendar4)
        Me.Controls.Add(Me.MonthCalendar3)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.UnitID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnitSchedule"
        Me.Text = "UnitSchedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UnitID As ComboBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents MonthCalendar3 As MonthCalendar
    Friend WithEvents MonthCalendar4 As MonthCalendar
    Friend WithEvents MonthCalendar5 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ScheduleType As ComboBox
    Friend WithEvents EUAD As TextBox
    Friend WithEvents SMHOD As TextBox
    Friend WithEvents PHOD As TextBox
    Friend WithEvents PCD As TextBox
    Friend WithEvents ESD As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents JobNumber As TextBox
    Friend WithEvents Label8 As Label
End Class
