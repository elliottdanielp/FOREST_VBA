Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class AssignEngineer

    Private Sub SubmittalReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote FROM forest.unit_master WHERE Engineer IS NULL", connecttion)

        adapter.Fill(table)

        AssignEngineerData.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT JobNumber FROM forest.unit_master WHERE Engineer IS NULL"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With JobNumber
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "JobNumber"
            .ValueMember = "JobNumber"
            .SelectedIndex = 0
        End With



    End Sub

    'Private Sub SubmittalReportData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubmittalReportData.CellClick

    'Dim index As Integer
    '   index = e.RowIndex
    'Dim selectedRow As DataGridViewRow
    '   selectedRow = SubmittalReportData.Rows(index)

    'Dim f2 As New SubmittalDashboard
    '   SubmittalDashboard.Show(ParentForm)

    'Dim JobNumber As DataGridViewRow
    '   JobNumber = selectedRow.Cells(1).Value



    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub TextBoxes_TextChanged(
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
            JobNumber.TextChanged,
            Engineer.TextChanged,
            SubmittalPromiseDate.TextChanged,
            JobName.TextChanged,
            SubmittalNote.TextChanged,
            SubmittalBy.TextChanged

        Dim textBoxes = {JobNumber, Engineer, SubmittalPromiseDate, JobName, SubmittalBy, SubmittalNote}
        Button2.Enabled = textBoxes.All(Function(tb) tb.Text <> "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET Engineer= @Engineer, SubmittalPromiseDate= @SubmittalPromiseDate, SubmittalNote= @SubmittalNote, SubmittalBy= @SubmittalBy" &
        " WHERE JobNumber= @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@Engineer", MySqlDbType.VarChar, 3).Value = Engineer.Text
            cmd.Parameters.Add("@SubmittalPromiseDate", MySqlDbType.VarChar, 12).Value = SubmittalPromiseDate.Text
            cmd.Parameters.Add("@SubmittalNote", MySqlDbType.MediumText).Value = SubmittalNote.Text
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 5).Value = JobNumber.Text
            cmd.Parameters.Add("@SubmittalBy", MySqlDbType.VarChar, 3).Value = SubmittalBy.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Dim EmailJobNumber
        EmailJobNumber = JobNumber.Text

        Dim EmailJobName
        EmailJobName = JobName.Text

        Dim EmailEngineer
        EmailEngineer = Engineer.Text

        Dim EmailPromiseDate
        EmailPromiseDate = SubmittalPromiseDate.Text

        Dim EmailSubmittalNote
        EmailSubmittalNote = SubmittalNote.Text

        Dim EmailSubmittalBy
        EmailSubmittalBy = SubmittalBy.Text

        'Sending the DataGridView's HTML in Email.
        Dim msg As MailMessage = New MailMessage()
        msg.[To].Add(New MailAddress("delliott@fisenusa.com", "Dan"))
        'msg.CC.Add(New MailAddress("Another@anotherdomain.com", "Another"))
        msg.From = New MailAddress("FOREST@fisenusa.com", "FOREST")
        msg.Subject = EmailJobNumber + "F" + " - " + EmailJobName + " - Engineer and Submittal Promise"
        msg.Body = "<html><p>" + EmailEngineer + " will be the engineer and " + EmailSubmittalBy + " will be doing the Submittal for Job: " + EmailJobNumber + "F. </p>
            Submittal promise date is " + EmailPromiseDate + "</p><br>
            <font color=STEELBLUE size=3>Submittal Note:</font><br>" + EmailSubmittalNote + "</html>"

        msg.IsBodyHtml = True
        Dim client As SmtpClient = New SmtpClient()
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential("FOREST@fisenusa.com", "Fisen12345!")
        client.Port = 587
        client.Host = "smtp.office365.com"
        client.DeliveryMethod = SmtpDeliveryMethod.Network
        client.EnableSsl = True
        Try
            client.Send(msg)
            MessageBox.Show("Job has been updated and email has been sent.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
        FOREST.TopMost = True

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        SubmittalPromiseDate.Text = MonthCalendar1.SelectionEnd.ToShortDateString()

    End Sub

    Private Sub JobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobNumber.SelectedIndexChanged

        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim query As String
        Dim dadapter As New MySqlDataAdapter

        Dim JobNumberDropDown
        JobNumberDropDown = JobNumber.Text

        conn = New MySqlConnection
        conn.ConnectionString =
        "server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"
        Dim JobNameText As String

        Try
            conn.Open()
            query = "SELECT JobName FROM forest.job_master WHERE JobNumber = '" & JobNumberDropDown & "'"

            command = New MySqlCommand(query, conn)

            JobNameText = Convert.ToString(command.ExecuteScalar())

            JobName.Text = JobNameText

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub

End Class