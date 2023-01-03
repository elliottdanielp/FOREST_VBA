Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Data
Imports System.Net

Public Class SalesHandoff

    Dim NewForm As ApplyScope

    Private Sub SalesHandoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Button2.Enabled = False
        Me.Button1.Enabled = False
        Me.Button3.Enabled = False

        NewForm = New ApplyScope

        conn = New MySqlConnection
        conn.ConnectionString = "server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"
        Dim NextJobNumber As String

        'MasterNote.Text = "Job Master Note Required"

        Try
            conn.Open()
            query = "SELECT JobNumber FROM job_master ORDER BY JobNumber DESC LIMIT 1"

            command = New MySqlCommand(query, conn)

            NextJobNumber = Convert.ToString(command.ExecuteScalar())

            JobNumber1.Text = NextJobNumber + 1

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub

    Private Sub TextBoxes_TextChanged(
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
            SalesEng.TextChanged,
            POAmount.TextChanged,
            Priority.TextChanged,
            JobName.TextChanged,
            JobNumber1.TextChanged,
            RequestDate.TextChanged,
            MasterNote.TextChanged

        Dim textBoxes = {SalesEng, POAmount, Priority, JobName, JobNumber1, RequestDate, MasterNote}
        Button3.Enabled = textBoxes.All(Function(tb) tb.Text <> "")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Button2.Enabled = True
        Me.Button3.Enabled = False
        Me.Button1.Enabled = False

        Dim ConnString As String
        ConnString = "server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"

        Dim SQLLine As String
        Dim cmd As MySqlCommand
        Dim conn As MySqlConnection

        conn = New MySqlConnection With {
            .ConnectionString = ConnString
        }

        conn.Open()
        SQLLine = "INSERT INTO job_master (JobNumber,JobName,SalesEng,POAmount,Priority,RequestDate,MasterNote) VALUES ('" & JobNumber1.Text & "','" & JobName.Text & "','" & SalesEng.Text & "','" & POAmount.Text & "','" & Priority.Text & "','" & RequestDate.Text & "','" & MasterNote.Text & "' )"

        cmd = New MySqlCommand With {
            .Connection = conn,
            .CommandText = SQLLine
        }
        'cmd.ExecuteNonQuery()

        If cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("Record insertion not successful! Please see Dan to remedy this situation.", "FOREST")
            ProgressBar1.Value = 0
            Button2.Enabled = False
        Else
            Button2.Enabled = True
            ProgressBar1.PerformStep()
        End If

        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewForm.Show()
        NewForm.Focus()

        Me.Button3.Enabled = False
        Me.Button1.Enabled = True

        ProgressBar1.Value = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = JobNumber1.Text

        Dim EmailJobName
        EmailJobName = JobName.Text

        Dim EmailRequestDate
        EmailRequestDate = RequestDate.Text

        Dim EmailMasterNote
        EmailMasterNote = MasterNote.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In UnitInfo.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In UnitInfo.Rows
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
        msg.Subject = EmailJobNumber + "F" + " - " + EmailJobName + " - Job Handoff"
        msg.Body = "<html><p> Job: " + EmailJobNumber + "F - " + EmailJobName + " - has been handed off from sales. </p>
            <p> Please review and assign an Engineer as soon as possible. Requested by: " + EmailRequestDate + "</p><br>
            <font color=STEELBLUE size=3>Job Info:</font><br>" + EmailTable + "<br><font color=STEELBLUE size=3>Job Note:</font><br>" + EmailMasterNote + "</html>"

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

        RequestDate.Text = MonthCalendar1.SelectionEnd.ToShortDateString()

    End Sub


    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim query As String
    Dim dadapter As New MySqlDataAdapter

End Class