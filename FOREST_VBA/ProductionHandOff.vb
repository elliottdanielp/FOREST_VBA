Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class ProductionHandOff
    Private Sub ProductionHandOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HandoffBTN.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE APHOD IS NULL", connecttion)

        YetToHandoff.Columns(0).DataPropertyName = "UnitID"
        YetToHandoff.Columns(1).DataPropertyName = "ModelNumber"
        YetToHandoff.Columns(2).DataPropertyName = "Scope"
        YetToHandoff.Columns(3).DataPropertyName = "UnitNote"
        YetToHandoff.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        YetToHandoff.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master WHERE APHOD IS NULL"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With JobNumber
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "UnitID"
            .ValueMember = "UnitID"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub JobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobNumber.SelectedIndexChanged

        HandoffJob.Text = JobNumber.Text

        Dim HandoffJobNumber = JobNumber.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE UnitID = '" & HandoffJobNumber & "'", connecttion)

        HandoffDataGrid.Columns(0).DataPropertyName = "UnitID"
        HandoffDataGrid.Columns(1).DataPropertyName = "ModelNumber"
        HandoffDataGrid.Columns(2).DataPropertyName = "Scope"
        HandoffDataGrid.Columns(3).DataPropertyName = "UnitNote"
        HandoffDataGrid.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        HandoffDataGrid.DataSource = table


    End Sub

    Private Sub HandoffBTN_Click(sender As Object, e As EventArgs) Handles HandoffBTN.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET APHOD = @APHOD" &
        " WHERE UnitID = @HandoffJob"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@APHOD", MySqlDbType.VarChar, 12).Value = APHOD.Text
            cmd.Parameters.Add("@HandoffJob", MySqlDbType.VarChar, 5).Value = HandoffJob.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = HandoffJob.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In HandoffDataGrid.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In HandoffDataGrid.Rows
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
        msg.Subject = EmailJobNumber + "F" + " - Production Handoff"
        msg.Body = "<html><p> Job: " + EmailJobNumber + "F has been handed off to production.</p>
                    <p> No Specific action is required at this time. </p>
                    <font color=STEELBLUE size=3>Job Info:</font><br>" + EmailTable + "</html>"

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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        HandoffBTN.Enabled = True
        APHOD.Enabled = True

        Dim todaysdate As Date = Date.Today

        APHOD.Text = todaysdate

    End Sub

    Private Sub YetToHandoff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles YetToHandoff.CellContentClick
        Me.JobNumber.Text = Me.YetToHandoff(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub
End Class