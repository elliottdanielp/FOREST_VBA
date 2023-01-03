Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class Shipped
    Private Sub Shipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim todaysdate As Date = Date.Today
        ASD.Text = todaysdate

        AddBtn.Enabled = False
        SubmitBtn.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, SerialNumber, ESD FROM forest.unit_master WHERE ReadyToShip IS NOT NULL AND ASD IS NULL", connecttion)

        ReadyToShipDGV.Columns(0).DataPropertyName = "UnitID"
        ReadyToShipDGV.Columns(1).DataPropertyName = "ModelNumber"
        ReadyToShipDGV.Columns(2).DataPropertyName = "SerialNumber"
        ReadyToShipDGV.Columns(3).DataPropertyName = "ESD"

        adapter.Fill(table)

        ReadyToShipDGV.DataSource = table

    End Sub

    Private Sub ReadyToShipDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReadyToShipDGV.CellContentClick
        'Me.sqlJobNumber.Text = Me.ReadyToShipDGV(e.ColumnIndex, e.RowIndex).Value.ToString()

        Dim SQLunitID = Me.ReadyToShipDGV(e.ColumnIndex, e.RowIndex).Value.ToString()

        'JobNumber Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim JobNumbertxt As String
            cmd.CommandText = "SELECT JobNumber FROM forest.unit_master WHERE UnitID = '" & SQLunitID & "'"
            JobNumbertxt = Convert.ToString(cmd.ExecuteScalar())

            sqlJobNumber.Text = JobNumbertxt

            conn.Close()

        End Using

        Dim SQLnumber = sqlJobNumber.Text

        'JobNumber Dropdown
        Dim conn2 As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim str2SQL As String = "SELECT UnitID FROM forest.unit_master WHERE JobNumber = '" & SQLnumber & "' AND ASD IS NULL"
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

        AddBtn.Enabled = True

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        SubmitBtn.Enabled = True

        Dim SQLshipped = JobNumber.Text

        'Data Grid 
        Dim sql_connection As New MySqlConnection
        Dim sql_query As New MySqlCommand
        Dim sql_result As MySqlDataReader
        sql_connection.ConnectionString = "server=192.168.1.122; Database=forest; user id=delliott; Pwd=juice16#cliP;"
        sql_query.Connection = sql_connection
        sql_connection.Open()
        sql_query.CommandText = "SELECT UnitID, ModelNumber, SerialNumber, ESD FROM forest.unit_master WHERE UnitID = '" & SQLshipped & "'"
        sql_result = sql_query.ExecuteReader

        Do While sql_result.Read()

            Dim UnitIDtxt As String
            Dim ModelNumbertxt As String
            Dim SerialNumbertxt As String
            Dim ESDtxt As String

            UnitIDtxt = sql_result("UnitID")
            ModelNumbertxt = sql_result("ModelNumber")
            SerialNumbertxt = sql_result("SerialNumber")
            ESDtxt = sql_result("ESD")

            ShippedDGV.ColumnCount = 4
            ShippedDGV.Columns(0).Name = "Unit ID"
            ShippedDGV.Columns(1).Name = "Model Number"
            ShippedDGV.Columns(2).Name = "Serial Number"
            ShippedDGV.Columns(3).Name = "ESD"

            Dim row As String() = New String() {UnitIDtxt, ModelNumbertxt, SerialNumbertxt, ESDtxt}
            ShippedDGV.Rows.Add(row)
            'row = New String() {"2", "Product 2", "2000"}
            'ShippedDGV.Rows.Add(row)

        Loop

        Dim SQLLine As String

        SQLLine = "UPDATE forest.unit_master " &
        " SET ASD= @ASD" &
        " WHERE UnitID= @JobNumber"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@ASD", MySqlDbType.VarChar, 12).Value = ASD.Text
            cmd.Parameters.Add("@JobNumber", MySqlDbType.VarChar, 10).Value = JobNumber.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using


    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        FOREST.Show()
        Me.Close()
        FOREST.TopMost = True

    End Sub

End Class