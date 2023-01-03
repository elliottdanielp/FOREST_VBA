Imports MySql.Data.MySqlClient

Public Class UnitSchedule
    Private Sub UnitSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master Where EUAD IS NULL AND SMHOD IS NULL AND PHOD IS NULL AND PCD IS NULL AND ESD IS NULL"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")

        With UnitID
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "UnitID"
            .ValueMember = "UnitID"
            .SelectedIndex = 0
        End With

        Me.Button1.Enabled = False

    End Sub

    Private Sub UnitSchedule_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ScheduleJob.JobNumber.Text = JobNumber.Text

        Dim SQLLine As String

        Dim sqlUnitID
        sqlUnitID = UnitID.Text

        SQLLine = "UPDATE forest.unit_master " &
        " SET EUAD= @EUAD, SMHOD= @SMHOD, PHOD= @PHOD, PCD= @PCD, ESD= @ESD, ScheduleType= @ScheduleType" &
        " WHERE UnitID= '" & sqlUnitID & "'"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@EUAD", MySqlDbType.VarChar, 12).Value = EUAD.Text
            cmd.Parameters.Add("@SMHOD", MySqlDbType.VarChar, 12).Value = SMHOD.Text
            cmd.Parameters.Add("@PHOD", MySqlDbType.VarChar, 12).Value = PHOD.Text
            cmd.Parameters.Add("@PCD", MySqlDbType.VarChar, 12).Value = PCD.Text
            cmd.Parameters.Add("@ESD", MySqlDbType.VarChar, 12).Value = ESD.Text
            cmd.Parameters.Add("@ScheduleType", MySqlDbType.VarChar, 12).Value = ScheduleType.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Dim nR As Integer = 0
        Dim Row As Integer = 0
        ScheduleJob.JobSchedule.Rows.Add()
        Row = ScheduleJob.JobSchedule.Rows.Count - 2

        ScheduleJob.JobSchedule("UnitID", Row).Value = UnitID.Text
        ScheduleJob.JobSchedule("EUAD", Row).Value = EUAD.Text
        ScheduleJob.JobSchedule("SMHOD", Row).Value = SMHOD.Text
        ScheduleJob.JobSchedule("PHOD", Row).Value = PHOD.Text
        ScheduleJob.JobSchedule("PCD", Row).Value = PCD.Text
        ScheduleJob.JobSchedule("ESD", Row).Value = ESD.Text
        ScheduleJob.JobSchedule("ScheduleType", Row).Value = ScheduleType.Text
        ScheduleJob.JobSchedule.Refresh()
        ScheduleJob.Show()
        Me.Close()

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        EUAD.Text = MonthCalendar1.SelectionEnd.ToShortDateString()
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        SMHOD.Text = MonthCalendar2.SelectionEnd.ToShortDateString()
    End Sub

    Private Sub MonthCalendar3_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar3.DateChanged
        PHOD.Text = MonthCalendar3.SelectionEnd.ToShortDateString()
    End Sub

    Private Sub MonthCalendar4_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar4.DateChanged
        PCD.Text = MonthCalendar4.SelectionEnd.ToShortDateString()
    End Sub

    Private Sub MonthCalendar5_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar5.DateChanged
        ESD.Text = MonthCalendar5.SelectionEnd.ToShortDateString()
    End Sub

    Private Sub UnitID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitID.SelectedIndexChanged
        Dim conn As MySqlConnection
        Dim command As MySqlCommand
        Dim query As String
        Dim dadapter As New MySqlDataAdapter

        Dim JobNumberTB
        JobNumberTB = UnitID.Text

        conn = New MySqlConnection
        conn.ConnectionString =
        "server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"
        'Dim JobNameText As String

        Try
            conn.Open()
            query = "SELECT JobNumber FROM forest.Unit_master WHERE UnitID = '" & JobNumberTB & "'"

            command = New MySqlCommand(query, conn)

            JobNumberTB = Convert.ToString(command.ExecuteScalar())

            JobNumber.Text = JobNumberTB

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub TextBoxes_TextChanged(
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
            ESD.TextChanged,
            SMHOD.TextChanged,
            PHOD.TextChanged,
            PCD.TextChanged,
            ESD.TextChanged,
            ScheduleType.TextChanged

        Dim textBoxes = {ESD, SMHOD, PHOD, PCD, ESD, ScheduleType}
        Button1.Enabled = textBoxes.All(Function(tb) tb.Text <> "")
    End Sub

End Class