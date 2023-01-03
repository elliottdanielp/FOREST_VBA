<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignEngineer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignEngineer))
        Me.AssignEngineerData = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.JobNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Engineer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SubmittalPromiseDate = New System.Windows.Forms.TextBox()
        Me.SubmittalNote = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JobName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SubmittalBy = New System.Windows.Forms.ComboBox()
        CType(Me.AssignEngineerData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignEngineerData
        '
        Me.AssignEngineerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AssignEngineerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssignEngineerData.Location = New System.Drawing.Point(13, 42)
        Me.AssignEngineerData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AssignEngineerData.Name = "AssignEngineerData"
        Me.AssignEngineerData.RowHeadersWidth = 51
        Me.AssignEngineerData.Size = New System.Drawing.Size(967, 167)
        Me.AssignEngineerData.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 474)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'JobNumber
        '
        Me.JobNumber.FormattingEnabled = True
        Me.JobNumber.Location = New System.Drawing.Point(205, 230)
        Me.JobNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(160, 24)
        Me.JobNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Job Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 233)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Engineer"
        '
        'Engineer
        '
        Me.Engineer.FormattingEnabled = True
        Me.Engineer.Items.AddRange(New Object() {"DJV", "DSC", "JAM", "JBL", "JRR", "SEM", "SRP"})
        Me.Engineer.Location = New System.Drawing.Point(485, 230)
        Me.Engineer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Engineer.Name = "Engineer"
        Me.Engineer.Size = New System.Drawing.Size(160, 24)
        Me.Engineer.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Promise Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Unassigned Jobs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Submittal Note"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(880, 474)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(680, 268)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        '
        'SubmittalPromiseDate
        '
        Me.SubmittalPromiseDate.Location = New System.Drawing.Point(777, 230)
        Me.SubmittalPromiseDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubmittalPromiseDate.Name = "SubmittalPromiseDate"
        Me.SubmittalPromiseDate.ReadOnly = True
        Me.SubmittalPromiseDate.Size = New System.Drawing.Size(201, 22)
        Me.SubmittalPromiseDate.TabIndex = 13
        '
        'SubmittalNote
        '
        Me.SubmittalNote.Location = New System.Drawing.Point(12, 305)
        Me.SubmittalNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubmittalNote.Name = "SubmittalNote"
        Me.SubmittalNote.Size = New System.Drawing.Size(639, 162)
        Me.SubmittalNote.TabIndex = 14
        Me.SubmittalNote.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Job Name"
        '
        'JobName
        '
        Me.JobName.Location = New System.Drawing.Point(205, 262)
        Me.JobName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JobName.Name = "JobName"
        Me.JobName.ReadOnly = True
        Me.JobName.Size = New System.Drawing.Size(160, 22)
        Me.JobName.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(387, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Submittal By"
        '
        'SubmittalBy
        '
        Me.SubmittalBy.FormattingEnabled = True
        Me.SubmittalBy.Items.AddRange(New Object() {"DJV", "DSC", "JAM", "JBL", "JRR", "SEM", "SRP"})
        Me.SubmittalBy.Location = New System.Drawing.Point(485, 265)
        Me.SubmittalBy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubmittalBy.Name = "SubmittalBy"
        Me.SubmittalBy.Size = New System.Drawing.Size(160, 24)
        Me.SubmittalBy.TabIndex = 18
        '
        'AssignEngineer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 513)
        Me.Controls.Add(Me.SubmittalBy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.JobName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SubmittalNote)
        Me.Controls.Add(Me.SubmittalPromiseDate)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Engineer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AssignEngineerData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AssignEngineer"
        Me.Text = "Assign Engineer"
        CType(Me.AssignEngineerData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssignEngineerData As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents JobNumber As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Engineer As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents SubmittalPromiseDate As TextBox
    Friend WithEvents SubmittalNote As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents JobName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SubmittalBy As ComboBox
End Class
