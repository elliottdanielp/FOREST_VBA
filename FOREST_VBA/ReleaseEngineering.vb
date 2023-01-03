Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class ReleaseEngineering
    Private Sub ReleaseEngineering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReleaseBTN.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE EngineeringReleaseDate IS NULL", connecttion)

        YetToRelease.Columns(0).DataPropertyName = "UnitID"
        YetToRelease.Columns(1).DataPropertyName = "ModelNumber"
        YetToRelease.Columns(2).DataPropertyName = "Scope"
        YetToRelease.Columns(3).DataPropertyName = "UnitNote"
        YetToRelease.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        YetToRelease.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT DISTINCT JobNumber FROM forest.unit_master WHERE EngineeringReleaseDate IS NULL"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With JobNumber
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "JobNumber"
            .ValueMember = "JobNumber"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub JobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobNumber.SelectedIndexChanged

        ReleaseJob.Text = JobNumber.Text

        Dim ReleaseJobNumber = JobNumber.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE JobNumber = '" & ReleaseJobNumber & "'", connecttion)

        ReleaseDataGrid.Columns(0).DataPropertyName = "UnitID"
        ReleaseDataGrid.Columns(1).DataPropertyName = "ModelNumber"
        ReleaseDataGrid.Columns(2).DataPropertyName = "Scope"
        ReleaseDataGrid.Columns(3).DataPropertyName = "UnitNote"
        ReleaseDataGrid.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        ReleaseDataGrid.DataSource = table


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReleaseBTN.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET EngineeringReleaseDate= @EngineeringReleaseDate" &
        " WHERE JobNumber= @ReleaseJob"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@EngineeringReleaseDate", MySqlDbType.VarChar, 12).Value = EngineeringReleaseDate.Text
            cmd.Parameters.Add("@ReleaseJob", MySqlDbType.VarChar, 5).Value = ReleaseJob.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = ReleaseJob.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In ReleaseDataGrid.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In ReleaseDataGrid.Rows
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
        msg.Subject = EmailJobNumber + "F" + " - Released To Engineering"
        msg.Body = "<html><p> Job: " + EmailJobNumber + "F has been Released to Engineering. No Specific action is required at this time. </p>
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

        ReleaseBTN.Enabled = True
        EngineeringReleaseDate.Enabled = True

        Dim todaysdate As Date = Date.Today

        EngineeringReleaseDate.Text = todaysdate

    End Sub

    Private Sub YetToRelease_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles YetToRelease.CellContentClick

        Dim UnitIDsql = Me.YetToRelease(e.ColumnIndex, e.RowIndex).Value.ToString()

        'JobNumber Dropdown Populate from Table
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim UnitIDtxt As String
            cmd.CommandText = "SELECT JobNumber FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            UnitIDtxt = Convert.ToString(cmd.ExecuteScalar())

            JobNumber.Text = UnitIDtxt
            ReleaseJob.Text = UnitIDtxt

            conn.Close()

        End Using


    End Sub
End Class