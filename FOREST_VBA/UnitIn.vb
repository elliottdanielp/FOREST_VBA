Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class UnitIn
    Private Sub UnitIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UnitLocation.Enabled = False
        SubmitBTN.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE MoveIn IS NOT NULL AND MovedIn IS NULL", connecttion)

        ScheduledUnitDGV.Columns(0).DataPropertyName = "UnitID"
        ScheduledUnitDGV.Columns(1).DataPropertyName = "ModelNumber"
        ScheduledUnitDGV.Columns(2).DataPropertyName = "Scope"
        ScheduledUnitDGV.Columns(3).DataPropertyName = "UnitNote"
        ScheduledUnitDGV.Columns(4).DataPropertyName = "Engineer"
        ScheduledUnitDGV.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        ScheduledUnitDGV.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master WHERE MoveIn IS NOT NULL AND MovedIn IS NULL"
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

    Private Sub JobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitID.SelectedIndexChanged

        UnitLocation.Enabled = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitLocation.SelectedIndexChanged

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET UnitLocation = @UnitLocation" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@UnitLocation", MySqlDbType.VarChar, 12).Value = UnitLocation.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 10).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Dim MovedInJobNumber = UnitID.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE UnitID = '" & MovedInJobNumber & "'", connecttion)

        MovedInDGV.Columns(0).DataPropertyName = "UnitID"
        MovedInDGV.Columns(1).DataPropertyName = "ModelNumber"
        MovedInDGV.Columns(2).DataPropertyName = "Scope"
        MovedInDGV.Columns(3).DataPropertyName = "UnitNote"
        MovedInDGV.Columns(4).DataPropertyName = "Engineer"
        MovedInDGV.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        MovedInDGV.DataSource = table

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        SubmitBTN.Enabled = True

        Dim todaysdate As Date = Date.Today

        MovedIn.Text = todaysdate

    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET MovedIn = @MovedIn" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@MovedIn", MySqlDbType.VarChar, 12).Value = MovedIn.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 10).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = UnitID.Text

        Dim EmailUnitLocation
        EmailUnitLocation = UnitLocation.Text
        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In MovedInDGV.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In MovedInDGV.Rows
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
        msg.Subject = EmailJobNumber + " - Has Moved In"
        msg.Body = "<html><p> Job: " + EmailJobNumber + " has moved into " & EmailUnitLocation & ".</p>
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

    End Sub

    Private Sub ScheduledUnitDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ScheduledUnitDGV.CellDoubleClick
        Me.UnitID.Text = Me.ScheduledUnitDGV(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub

End Class