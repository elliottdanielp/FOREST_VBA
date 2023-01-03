Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class EditSerialNumber
    Private Sub EditSerialNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'JobNumber Text Box
        Dim SqlJobNumber = UnitID.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SerialNumberText As String
            cmd.CommandText = "SELECT SerialNumber FROM forest.unit_master WHERE UnitID = '" & SqlJobNumber & "'"
            SerialNumberText = Convert.ToString(cmd.ExecuteScalar())

            SerialNumber.Text = SerialNumberText

            conn.Close()

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET SerialNumber = @SerialNumber" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from DB here
            cmd.Parameters.Add("@SerialNumber", MySqlDbType.VarChar, 100).Value = SerialNumber.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 8).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Me.Close()
        MessageBox.Show("Serial Number has been updated.")
        MasterRecord.TopMost = True

    End Sub
End Class