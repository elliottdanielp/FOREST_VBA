Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class ScheduleUnitIn
    Private Sub ScheduleUnitIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubmitBTN.Enabled = False
        UnitLocation.Enabled = False
        'CheckBox1.Enabled = False

        Dim SqlUnitLocation = "Here"

        'Data Grid 
        Dim conn1 As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim str1SQL As String = "SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE UnitLocation = '" & SqlUnitLocation & "'"
        Dim adapter As New MySqlDataAdapter(str1SQL, conn1)

        NotScheduledLocationDGV.Columns(0).DataPropertyName = "UnitID"
        NotScheduledLocationDGV.Columns(1).DataPropertyName = "ModelNumber"
        NotScheduledLocationDGV.Columns(2).DataPropertyName = "Scope"
        NotScheduledLocationDGV.Columns(3).DataPropertyName = "UnitNote"
        NotScheduledLocationDGV.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        NotScheduledLocationDGV.DataSource = table


        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master WHERE UnitLocation = '" & SqlUnitLocation & "'"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With UnitID
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "UnitID"
            .ValueMember = "UnitID"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub UnitID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitID.SelectedIndexChanged

        UnitLocation.Enabled = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        SubmitBTN.Enabled = True

    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET MoveIn = @MoveIn" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@MoveIn", MySqlDbType.VarChar, 12).Value = MoveIn.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 10).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = UnitID.Text

        Dim EmailJobLocation
        EmailJobLocation = UnitLocation.Text

        Dim EmailMoveDate
        EmailMoveDate = MoveIn.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In ScheduledLocationDGV.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In ScheduledLocationDGV.Rows
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
        msg.Subject = EmailJobNumber + " - Move In"
        msg.Body = "<html><p> Job: " + EmailJobNumber + " Moving into " + EmailJobLocation + " on " + EmailMoveDate + ".</p>
                    <p>Andy - Please have production technicians coordinate handoff with engineering.</p>
                    <p>Shipping - Please move " + EmailJobNumber + " into " + EmailJobLocation + "</P
                    <p>Bruce/Dan F - Please make sure pick are complete, notify if there are any material issues.</p>
                    <p>Cara - Please make sure that the traveler is printed for this project.</p>

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
        'FOREST.TopMost = True

    End Sub

    Private Sub PickScheduleDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles PickScheduleDate.DateChanged

        MoveIn.Text = PickScheduleDate.SelectionEnd.ToShortDateString()

    End Sub

    Private Sub Location_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitLocation.SelectedIndexChanged

        PickScheduleDate.Enabled = True

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET UnitLocation = @UnitLocation" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@UnitLocation", MySqlDbType.VarChar, 15).Value = UnitLocation.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 5).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Dim HandoffJobNumber = UnitID.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE UnitID = '" & HandoffJobNumber & "'", connecttion)

        ScheduledLocationDGV.Columns(0).DataPropertyName = "UnitID"
        ScheduledLocationDGV.Columns(1).DataPropertyName = "ModelNumber"
        ScheduledLocationDGV.Columns(2).DataPropertyName = "Scope"
        ScheduledLocationDGV.Columns(3).DataPropertyName = "UnitNote"
        ScheduledLocationDGV.Columns(4).DataPropertyName = "Engineer"
        ScheduledLocationDGV.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        ScheduledLocationDGV.DataSource = table

    End Sub

    Private Sub NotScheduledLocationDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NotScheduledLocationDGV.CellContentClick
        Me.UnitID.Text = Me.NotScheduledLocationDGV(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub
End Class