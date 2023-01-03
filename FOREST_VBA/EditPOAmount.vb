Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class EditPOAmount
    Private Sub EditPOAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TopMost = True

        'JobNumber Text Box
        Dim SqlJobNumber = JobNumber.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim POAmountText As String
            cmd.CommandText = "SELECT POAmount FROM forest.job_master WHERE JobNumber = '" & SqlJobNumber & "'"
            POAmountText = Convert.ToString(cmd.ExecuteScalar())

            POAmount.Text = POAmountText

            conn.Close()

        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SQLLine As String

        SQLLine = "UPDATE job_master " &
        " SET POAmount = @POAmount" &
        " WHERE JobNumber = @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from DB here
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 100).Value = JobNumber.Text
            cmd.Parameters.Add("@POAmount", MySqlDbType.VarChar, 8).Value = POAmount.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Me.Close()
        MessageBox.Show("PO Amount has been updated.")
        MasterRecord.TopMost = True


    End Sub
End Class