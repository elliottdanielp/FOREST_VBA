Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class EditModelNumber
    Private Sub EditModelNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'JobNumber Text Box
        Dim SqlJobNumber = UnitID.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim ModelNumberText As String
            cmd.CommandText = "SELECT ModelNumber FROM forest.unit_master WHERE UnitID = '" & SqlJobNumber & "'"
            ModelNumberText = Convert.ToString(cmd.ExecuteScalar())

            ModelNumber.Text = ModelNumberText

            conn.Close()

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET ModelNumber = @ModelNumber" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from DB here
            cmd.Parameters.Add("@ModelNumber", MySqlDbType.VarChar, 100).Value = ModelNumber.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 8).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Me.Close()
        MessageBox.Show("Model Number has been updated.")
        MasterRecord.TopMost = True

    End Sub
End Class