<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Testing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Testing))
        Me.SqlUnitID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModelNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialNumber = New System.Windows.Forms.TextBox()
        Me.Scope = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Engineer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ActionItems = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.JobNumber = New System.Windows.Forms.TextBox()
        Me.TestDate = New System.Windows.Forms.TextBox()
        Me.TestComplete = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'SqlUnitID
        '
        Me.SqlUnitID.Location = New System.Drawing.Point(9, 31)
        Me.SqlUnitID.Name = "SqlUnitID"
        Me.SqlUnitID.Size = New System.Drawing.Size(49, 20)
        Me.SqlUnitID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job"
        '
        'ModelNumber
        '
        Me.ModelNumber.Location = New System.Drawing.Point(64, 31)
        Me.ModelNumber.Name = "ModelNumber"
        Me.ModelNumber.Size = New System.Drawing.Size(222, 20)
        Me.ModelNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Model Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serial Number"
        '
        'SerialNumber
        '
        Me.SerialNumber.Location = New System.Drawing.Point(292, 31)
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.Size = New System.Drawing.Size(160, 20)
        Me.SerialNumber.TabIndex = 5
        '
        'Scope
        '
        Me.Scope.Location = New System.Drawing.Point(458, 31)
        Me.Scope.Multiline = True
        Me.Scope.Name = "Scope"
        Me.Scope.Size = New System.Drawing.Size(218, 20)
        Me.Scope.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Scope"
        '
        'Engineer
        '
        Me.Engineer.Location = New System.Drawing.Point(682, 31)
        Me.Engineer.Name = "Engineer"
        Me.Engineer.Size = New System.Drawing.Size(46, 20)
        Me.Engineer.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(679, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Engineer"
        '
        'ActionItems
        '
        Me.ActionItems.Location = New System.Drawing.Point(9, 83)
        Me.ActionItems.Name = "ActionItems"
        Me.ActionItems.Size = New System.Drawing.Size(719, 202)
        Me.ActionItems.TabIndex = 10
        Me.ActionItems.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Action Items"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(653, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 301)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(525, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.TabIndex = 13
        '
        'JobNumber
        '
        Me.JobNumber.Location = New System.Drawing.Point(80, 57)
        Me.JobNumber.Name = "JobNumber"
        Me.JobNumber.Size = New System.Drawing.Size(100, 20)
        Me.JobNumber.TabIndex = 14
        Me.JobNumber.Visible = False
        '
        'TestDate
        '
        Me.TestDate.Location = New System.Drawing.Point(186, 57)
        Me.TestDate.Name = "TestDate"
        Me.TestDate.Size = New System.Drawing.Size(100, 20)
        Me.TestDate.TabIndex = 15
        Me.TestDate.Visible = False
        '
        'TestComplete
        '
        Me.TestComplete.AutoSize = True
        Me.TestComplete.Location = New System.Drawing.Point(553, 305)
        Me.TestComplete.Name = "TestComplete"
        Me.TestComplete.Size = New System.Drawing.Size(94, 17)
        Me.TestComplete.TabIndex = 16
        Me.TestComplete.Text = "Test Complete"
        Me.TestComplete.UseVisualStyleBackColor = True
        '
        'Testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 339)
        Me.Controls.Add(Me.TestComplete)
        Me.Controls.Add(Me.TestDate)
        Me.Controls.Add(Me.JobNumber)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ActionItems)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Engineer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Scope)
        Me.Controls.Add(Me.SerialNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ModelNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SqlUnitID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Testing"
        Me.Text = "Test Notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlUnitID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ModelNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SerialNumber As TextBox
    Friend WithEvents Scope As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Engineer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ActionItems As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents JobNumber As TextBox
    Friend WithEvents TestDate As TextBox
    Friend WithEvents TestComplete As CheckBox
End Class
