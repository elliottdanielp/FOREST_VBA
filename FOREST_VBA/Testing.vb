Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class Testing
    
    Private Sub Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Enabled = False
        TestComplete.Enabled = False

        Dim todaysdate As Date = Date.Today

        TestDate.Text = todaysdate

        Dim UnitIDsql = SqlUnitID.Text

        'ModelNumber Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim ModelNumbertxt As String
            cmd.CommandText = "SELECT ModelNumber FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            ModelNumbertxt = Convert.ToString(cmd.ExecuteScalar())

            ModelNumber.Text = ModelNumbertxt

            conn.Close()

        End Using

        'SerialNumber Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SerialNumbertxt As String
            cmd.CommandText = "SELECT SerialNumber FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            SerialNumbertxt = Convert.ToString(cmd.ExecuteScalar())

            SerialNumber.Text = SerialNumbertxt

            conn.Close()

        End Using

        'Scope Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Scopetxt As String
            cmd.CommandText = "SELECT Scope FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            Scopetxt = Convert.ToString(cmd.ExecuteScalar())

            Scope.Text = Scopetxt

            conn.Close()

        End Using

        'Engineer Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Engineertxt As String
            cmd.CommandText = "SELECT Engineer FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            Engineertxt = Convert.ToString(cmd.ExecuteScalar())

            Engineer.Text = Engineertxt

            conn.Close()

        End Using

        'JobNumber Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim JobNumbertxt As String
            cmd.CommandText = "SELECT JobNumber FROM forest.unit_master WHERE UnitID = '" & UnitIDsql & "'"
            JobNumbertxt = Convert.ToString(cmd.ExecuteScalar())

            JobNumber.Text = JobNumbertxt

            conn.Close()

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ConnString As String
        ConnString = "server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"

        Dim SQLLine As String
        Dim cmd As MySqlCommand
        Dim conn As MySqlConnection

        conn = New MySqlConnection With {
            .ConnectionString = ConnString
        }

        conn.Open()
        SQLLine = "INSERT INTO test_master (JobNumber,UnitID,TestDate,Engineer,ActionItems) VALUES ('" & JobNumber.Text & "','" & SqlUnitID.Text & "','" & TestDate.Text & "','" & Engineer.Text & "','" & ActionItems.Text & "' )"

        cmd = New MySqlCommand With {
            .Connection = conn,
            .CommandText = SQLLine
        }
        'cmd.ExecuteNonQuery()

        If cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("Record insertion not successful! Please see Dan to remedy this situation.", "FOREST")
            ProgressBar1.Value = 0
        Else
            ProgressBar1.PerformStep()
        End If

        conn.Close()
        conn.Dispose()

        Dim EmailJobNumber = SqlUnitID.Text
        Dim EmailModelNumber = ModelNumber.Text
        Dim EmailSerialNumber = SerialNumber.Text
        Dim EmailScope = Scope.Text
        Dim EmailEngineer = Engineer.Text
        Dim EmailActionItems = ActionItems.Text

        'Sending the DataGridView's HTML in Email.
        Dim msg As MailMessage = New MailMessage()
        msg.[To].Add(New MailAddress("delliott@fisenusa.com", "Dan"))
        'msg.CC.Add(New MailAddress("Another@anotherdomain.com", "Another"))
        msg.From = New MailAddress("FOREST@fisenusa.com", "FOREST")
        msg.Subject = EmailJobNumber + " - Test Complete"
        msg.Body = "<html><p> Job: " + EmailJobNumber + " has Completed Test. Please proceed to addressing any action items. </p>
                   <font color=STEELBLUE size=3>Job Number: </font>" + EmailJobNumber + "<br> 
                   <font color=STEELBLUE size=3>Model Number: </font>" + EmailModelNumber + "<br> 
                   <font color=STEELBLUE size=3>Serial Number: </font>" + EmailSerialNumber + "<br> 
                   <font color=STEELBLUE size=3>Scope: </font>" + EmailScope + "<br>
                   <font color=STEELBLUE size=3>Engineer: </font>" + EmailEngineer + "<br><br>
                   <font color=STEELBLUE size=3>Action Items: </font>" + EmailActionItems + "<br></html>"

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
        MasterRecord.TopMost = True

    End Sub

    Private Sub ActionItems_TextChanged(sender As Object, e As EventArgs) Handles ActionItems.TextChanged

        TestComplete.Enabled = True

    End Sub

    Private Sub TestComplete_CheckedChanged(sender As Object, e As EventArgs) Handles TestComplete.CheckedChanged

        Button1.Enabled = True

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET TestComplete = @TestDate" &
        " WHERE UnitID = @SqlUnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@TestDate", MySqlDbType.VarChar, 10).Value = TestDate.Text
            cmd.Parameters.Add("@SqlUnitID", MySqlDbType.VarChar, 8).Value = SqlUnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

    End Sub


End Class