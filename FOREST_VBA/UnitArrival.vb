Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class UnitArrival
    Private Sub UnitArrival_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckBox1.Enabled = False
        SubmitBtn.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer FROM forest.unit_master WHERE AUAD IS NULL AND EUAD > 0 ", connecttion)

        YetToArrive.Columns(0).DataPropertyName = "UnitID"
        YetToArrive.Columns(1).DataPropertyName = "ModelNumber"
        YetToArrive.Columns(2).DataPropertyName = "Scope"
        YetToArrive.Columns(3).DataPropertyName = "UnitNote"
        YetToArrive.Columns(4).DataPropertyName = "Engineer"

        adapter.Fill(table)

        YetToArrive.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master WHERE AUAD IS NULL AND EUAD > 0 "
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        SubmitBtn.Enabled = True
        AUAD.Enabled = True

        Dim todaysdate As Date = Date.Today

        AUAD.Text = todaysdate

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET AUAD = @AUAD " &
        " WHERE UnitID = @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@AUAD", MySqlDbType.VarChar, 12).Value = AUAD.Text
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 5).Value = JobNumber.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = JobNumber.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In ArrivedDataGrid.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In ArrivedDataGrid.Rows
            EmailTable &= "<tr>"

            For Each cell As DataGridViewCell In row.Cells
                EmailTable &= "<td style='width:180px;border: 1px solid #ccc'>" & cell.Value & "</td>"
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
        msg.Subject = EmailJobNumber + " - Has Arrived To Fisen"
        msg.Body = "<html><p> Job: " + EmailJobNumber + " has arrived to Fisen. No Specific action is required at this time. </p>
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

    Private Sub JobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobNumber.SelectedIndexChanged


        Dim SQLLine As String
        Dim SqlUnitLocation = "Here"

        SQLLine = "UPDATE unit_master " &
        " SET UnitLocation = '" & SqlUnitLocation & "'" &
        " WHERE UnitID = @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@UnitLocation", MySqlDbType.VarChar, 15).Value = SqlUnitLocation
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 5).Value = JobNumber.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Dim ArrivedJobNumber = JobNumber.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE UnitID = '" & ArrivedJobNumber & "'", connecttion)

        ArrivedDataGrid.Columns(0).DataPropertyName = "UnitID"
        ArrivedDataGrid.Columns(1).DataPropertyName = "ModelNumber"
        ArrivedDataGrid.Columns(2).DataPropertyName = "Scope"
        ArrivedDataGrid.Columns(3).DataPropertyName = "UnitNote"
        ArrivedDataGrid.Columns(4).DataPropertyName = "Engineer"
        ArrivedDataGrid.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        ArrivedDataGrid.DataSource = table

    End Sub

    Private Sub SerialNumber_TextChanged(sender As Object, e As EventArgs) Handles SerialNumber.TextChanged

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET SerialNumber = @SerialNumber" &
        " WHERE UnitID = @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@SerialNumber", MySqlDbType.VarChar, 12).Value = SerialNumber.Text
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 5).Value = JobNumber.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        CheckBox1.Enabled = True

    End Sub

    Private Sub YetToArrive_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles YetToArrive.CellDoubleClick
        Me.JobNumber.Text = Me.YetToArrive(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub

End Class