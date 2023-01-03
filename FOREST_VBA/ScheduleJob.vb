Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class ScheduleJob

    Dim NewForm As UnitSchedule

    Private Sub ScheduleJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SubmitBtn.Enabled = False

        NewForm = New UnitSchedule

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT JobNumber, UnitID, Scope FROM forest.unit_master Where EUAD IS NULL AND SMHOD IS NULL AND PHOD IS NULL AND PCD IS NULL AND ESD IS NULL", connecttion)

        adapter.Fill(table)

        UnscheduledJobData.DataSource = table

    End Sub

    Private Sub ScheduleBtn_Click(sender As Object, e As EventArgs) Handles ScheduleBtn.Click

        NewForm.Show()
        NewForm.Focus()

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = JobNumber.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In JobSchedule.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In JobSchedule.Rows
            EmailTable &= "<tr>"

            For Each cell As DataGridViewCell In row.Cells
                EmailTable &= "<td style='width:120px;border: 1px solid #ccc'>" & cell.Value & "</td>"
            Next

            EmailTable &= "</tr>"
        Next

        'Table end.
        EmailTable &= "</table>"

        'Sending the DataGridView's HTML in Email.
        Dim msg As MailMessage = New MailMessage()
        msg.[To].Add(New MailAddress("delliott@fisenusa.com", "Dan"))
        'msg.CC.Add(New MailAddress("Another@anotherdomain.com", "Another"))
        msg.From = New MailAddress("FOREST@fisenusa.com", "FOREST")
        msg.Subject = EmailJobNumber + "F" + " - Schedule"
        msg.Body = "<html><p> Job: " + EmailJobNumber + "F has been Scheduled as follows. </p>
                   <font color=STEELBLUE size=3>Schedule:</font><br>" + EmailTable + "</html>"

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

    Private Sub TextBoxes_TextChanged(
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
            JobNumber.TextChanged

        Dim textBoxes = {JobNumber}
        SubmitBtn.Enabled = textBoxes.All(Function(tb) tb.Text <> "")
    End Sub

    Private Sub UnscheduledJobData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnscheduledJobData.CellContentClick
        Me.JobNumber.Text = Me.UnscheduledJobData(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub
End Class