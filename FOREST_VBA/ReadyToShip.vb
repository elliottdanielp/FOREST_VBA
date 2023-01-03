Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class ReadyToShip

    Private Sub ReadyToShip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Enabled = False

        'Data Grid 
        Dim conn1 As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim str1SQL As String = "SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE ReadyToShip IS NULL"
        Dim adapter As New MySqlDataAdapter(str1SQL, conn1)

        YetToReady.Columns(0).DataPropertyName = "UnitID"
        YetToReady.Columns(1).DataPropertyName = "ModelNumber"
        YetToReady.Columns(2).DataPropertyName = "Scope"
        YetToReady.Columns(3).DataPropertyName = "UnitNote"
        YetToReady.Columns(4).DataPropertyName = "Engineer"
        YetToReady.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        YetToReady.DataSource = table

        'JobNumber Dropdown
        Dim conn2 As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim str2SQL As String = "SELECT UnitID FROM forest.unit_master WHERE ReadyToShip IS NULL"
        Dim da As New MySqlDataAdapter(str2SQL, conn2)
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

        Ready2Ship.Text = JobNumber.Text

        Dim HandoffJobNumber = JobNumber.Text

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, UnitNote, Engineer, UnitLocation FROM forest.unit_master WHERE UnitID = '" & HandoffJobNumber & "'", connecttion)

        ReadyDataGrid.Columns(0).DataPropertyName = "UnitID"
        ReadyDataGrid.Columns(1).DataPropertyName = "ModelNumber"
        ReadyDataGrid.Columns(2).DataPropertyName = "Scope"
        ReadyDataGrid.Columns(3).DataPropertyName = "UnitNote"
        ReadyDataGrid.Columns(4).DataPropertyName = "Engineer"
        ReadyDataGrid.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        ReadyDataGrid.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET ReadyToShip = @Ready2ShipDate" &
        " WHERE UnitID = @Ready2Ship"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@Ready2ShipDate", MySqlDbType.VarChar, 12).Value = Ready2ShipDate.Text
            cmd.Parameters.Add("@Ready2Ship", MySqlDbType.VarChar, 5).Value = Ready2Ship.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()

        Dim EmailJobNumber
        EmailJobNumber = Ready2Ship.Text

        'Table start.
        Dim EmailTable As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        EmailTable &= "<tr>"

        For Each column As DataGridViewColumn In ReadyDataGrid.Columns
            EmailTable &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        EmailTable &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In ReadyDataGrid.Rows
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
        msg.Subject = EmailJobNumber + " - Ready To Ship"
        msg.Body = "<html><p> Job: " + EmailJobNumber + " is ready to ship.</p>
                    <p> CUL and IOM have been applied Please Proceed in closing up Job: " + EmailJobNumber + " as soon as possible. </p>
                    <p> Please set up shipping for job. </p>
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

        Button1.Enabled = True
        Ready2ShipDate.Enabled = True

        Dim todaysdate As Date = Date.Today

        Ready2ShipDate.Text = todaysdate

    End Sub

    Private Sub YetToReady_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles YetToReady.CellContentClick
        Me.JobNumber.Text = Me.YetToReady(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub

End Class