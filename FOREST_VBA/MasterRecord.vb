Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class MasterRecord
    Dim JobNumberRecord As String = String.Empty

    Public Property getName As String

        Get
            Return JobNumberRecord
        End Get

        Set(ByVal value As String)
            JobNumberRecord = value
        End Set

    End Property

    Private Sub UnitInfoDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitInfoDGV.CellFormatting

        UnitInfoDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub SubmittalDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles SubmittalNoteDGV.CellFormatting

        SubmittalNoteDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub UnitNoteDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitNoteDGV.CellFormatting

        UnitNoteDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub ScheduleDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ScheduleDGV.CellFormatting

        ScheduleDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub ActualDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ActualDGV.CellFormatting

        ActualDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub TestDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TestDGV.CellFormatting

        TestDGV.Rows(0).Cells(0).Selected = False

    End Sub

    Private Sub MasterRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        JobNumberSql.Text = getName

        'JobNumber Text Box
        Dim SqlJobNumber = JobNumberSql.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim JobNumbertxt As String
            cmd.CommandText = "SELECT JobNumber FROM forest.unit_master WHERE UnitID = '" & SqlJobNumber & "'"
            JobNumbertxt = Convert.ToString(cmd.ExecuteScalar())

            JobNumber.Text = JobNumbertxt

            conn.Close()

        End Using

        'JobName Text Box
        Dim SQLJob = JobNumber.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim JobNametxt As String
            cmd.CommandText = "SELECT JobName FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            JobNametxt = Convert.ToString(cmd.ExecuteScalar())

            JobName.Text = JobNametxt

            conn.Close()

        End Using

        'Engineer Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Engineertxt As String
            cmd.CommandText = "SELECT Engineer FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'"
            Engineertxt = Convert.ToString(cmd.ExecuteScalar())

            Engineer.Text = Engineertxt

            conn.Close()

        End Using

        'SoldBy Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SalesEngtxt As String
            cmd.CommandText = "SELECT SalesEng FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            SalesEngtxt = Convert.ToString(cmd.ExecuteScalar())

            SoldBy.Text = SalesEngtxt

            conn.Close()

        End Using

        'Priority Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Prioritytxt As String
            cmd.CommandText = "SELECT Priority FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            Prioritytxt = Convert.ToString(cmd.ExecuteScalar())

            Priority.Text = Prioritytxt

            conn.Close()

        End Using

        'PO Amount Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim POAmounttxt As String
            cmd.CommandText = "SELECT POAmount FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            POAmounttxt = Convert.ToString(cmd.ExecuteScalar())

            POAmount.Text = POAmounttxt

            conn.Close()

        End Using

        'Unit Info Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, Tag, ModelNumber, SerialNumber, Scope, UnitLocation FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", connecttion)

        UnitInfoDGV.Columns(0).DataPropertyName = "UnitID"
        UnitInfoDGV.Columns(1).DataPropertyName = "Tag"
        UnitInfoDGV.Columns(2).DataPropertyName = "ModelNumber"
        UnitInfoDGV.Columns(3).DataPropertyName = "SerialNumber"
        UnitInfoDGV.Columns(4).DataPropertyName = "Scope"
        UnitInfoDGV.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        UnitInfoDGV.DataSource = table

        'Sales Note Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SalesNotetxt As String
            cmd.CommandText = "SELECT MasterNote FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            SalesNotetxt = Convert.ToString(cmd.ExecuteScalar())

            SalesNote.Text = SalesNotetxt

            conn.Close()

        End Using

        'Submittal Note Data Grid 
        Dim SNconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim SNtable As New DataTable()
        Dim SNadapter As New MySqlDataAdapter("SELECT UnitID, SubmittalNote FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", SNconnecttion)

        SubmittalNoteDGV.Columns(0).DataPropertyName = "UnitID"
        SubmittalNoteDGV.Columns(1).DataPropertyName = "SubmittalNote"

        SNadapter.Fill(SNtable)

        SubmittalNoteDGV.DataSource = SNtable

        'Unit Note Data Grid 
        Dim UNconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim UNtable As New DataTable()
        Dim UNadapter As New MySqlDataAdapter("SELECT UnitID, UnitNote FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", UNconnecttion)

        UnitNoteDGV.Columns(0).DataPropertyName = "UnitID"
        UnitNoteDGV.Columns(1).DataPropertyName = "UnitNote"

        UNadapter.Fill(UNtable)

        UnitNoteDGV.DataSource = UNtable

        'Schedule Data Grid 
        Dim SKDconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim SKDtable As New DataTable()
        Dim SKDadapter As New MySqlDataAdapter("SELECT UnitID, EUAD, PHOD, PCD, ESD, ScheduleType FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", SKDconnecttion)

        ScheduleDGV.Columns(0).DataPropertyName = "UnitID"
        ScheduleDGV.Columns(1).DataPropertyName = "EUAD"
        ScheduleDGV.Columns(2).DataPropertyName = "PHOD"
        ScheduleDGV.Columns(3).DataPropertyName = "PCD"
        ScheduleDGV.Columns(4).DataPropertyName = "ESD"
        ScheduleDGV.Columns(5).DataPropertyName = "ScheduleType"

        SKDadapter.Fill(SKDtable)

        ScheduleDGV.DataSource = SKDtable

        'Actual Data Grid 
        Dim ACTconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim ACTtable As New DataTable()
        Dim ACTadapter As New MySqlDataAdapter("SELECT UnitID, AUAD, APHOD, APCD, ASD FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", ACTconnecttion)

        ActualDGV.Columns(0).DataPropertyName = "UnitID"
        ActualDGV.Columns(1).DataPropertyName = "AUAD"
        ActualDGV.Columns(2).DataPropertyName = "APHOD"
        ActualDGV.Columns(3).DataPropertyName = "APCD"
        ActualDGV.Columns(4).DataPropertyName = "ASD"

        ACTadapter.Fill(ACTtable)

        ActualDGV.DataSource = ACTtable

        'Test Info Data Grid 
        Dim TIconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim TItable As New DataTable()
        Dim TIadapter As New MySqlDataAdapter("SELECT UnitID, Tester, TestDate, ActionItems FROM forest.test_master WHERE JobNumber = '" & SQLJob & "'", TIconnecttion)

        TestDGV.Columns(0).DataPropertyName = "UnitID"
        TestDGV.Columns(1).DataPropertyName = "Tester"
        TestDGV.Columns(2).DataPropertyName = "TestDate"
        TestDGV.Columns(3).DataPropertyName = "ActionItems"

        TIadapter.Fill(TItable)

        TestDGV.DataSource = TItable


    End Sub

    Private Sub POAmount_TextChanged(sender As Object, e As EventArgs) Handles POAmount.TextChanged
        Dim amount As Integer = CType(POAmount.Text, Integer)
        POAmount.Text = amount.ToString("$##,##,###.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'JobName Text Box
        Dim SQLJob = JobNumber.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim JobNametxt As String
            cmd.CommandText = "SELECT JobName FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            JobNametxt = Convert.ToString(cmd.ExecuteScalar())

            JobName.Text = JobNametxt

            conn.Close()

        End Using

        'Engineer Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Engineertxt As String
            cmd.CommandText = "SELECT Engineer FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'"
            Engineertxt = Convert.ToString(cmd.ExecuteScalar())

            Engineer.Text = Engineertxt

            conn.Close()

        End Using

        'SoldBy Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SalesEngtxt As String
            cmd.CommandText = "SELECT SalesEng FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            SalesEngtxt = Convert.ToString(cmd.ExecuteScalar())

            SoldBy.Text = SalesEngtxt

            conn.Close()

        End Using

        'Priority Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Prioritytxt As String
            cmd.CommandText = "SELECT Priority FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            Prioritytxt = Convert.ToString(cmd.ExecuteScalar())

            Priority.Text = Prioritytxt

            conn.Close()

        End Using

        'PO Amount Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim POAmounttxt As String
            cmd.CommandText = "SELECT POAmount FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            POAmounttxt = Convert.ToString(cmd.ExecuteScalar())

            POAmount.Text = POAmounttxt

            conn.Close()

        End Using

        'Unit Info Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, Tag, ModelNumber, SerialNumber, Scope, UnitLocation FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", connecttion)

        UnitInfoDGV.Columns(0).DataPropertyName = "UnitID"
        UnitInfoDGV.Columns(1).DataPropertyName = "Tag"
        UnitInfoDGV.Columns(2).DataPropertyName = "ModelNumber"
        UnitInfoDGV.Columns(3).DataPropertyName = "SerialNumber"
        UnitInfoDGV.Columns(4).DataPropertyName = "Scope"
        UnitInfoDGV.Columns(5).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        UnitInfoDGV.DataSource = table

        'Sales Note Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim SalesNotetxt As String
            cmd.CommandText = "SELECT MasterNote FROM forest.job_master WHERE JobNumber = '" & SQLJob & "'"
            SalesNotetxt = Convert.ToString(cmd.ExecuteScalar())

            SalesNote.Text = SalesNotetxt

            conn.Close()

        End Using

        'Submittal Note Data Grid 
        Dim SNconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim SNtable As New DataTable()
        Dim SNadapter As New MySqlDataAdapter("SELECT UnitID, SubmittalNote FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", SNconnecttion)

        SubmittalNoteDGV.Columns(0).DataPropertyName = "UnitID"
        SubmittalNoteDGV.Columns(1).DataPropertyName = "SubmittalNote"

        SNadapter.Fill(SNtable)

        SubmittalNoteDGV.DataSource = SNtable

        'Unit Note Data Grid 
        Dim UNconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim UNtable As New DataTable()
        Dim UNadapter As New MySqlDataAdapter("SELECT UnitID, UnitNote FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", UNconnecttion)

        UnitNoteDGV.Columns(0).DataPropertyName = "UnitID"
        UnitNoteDGV.Columns(1).DataPropertyName = "UnitNote"

        UNadapter.Fill(UNtable)

        UnitNoteDGV.DataSource = UNtable

        'Schedule Data Grid 
        Dim SKDconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim SKDtable As New DataTable()
        Dim SKDadapter As New MySqlDataAdapter("SELECT UnitID, EUAD, PHOD, PCD, ESD, ScheduleType FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", SKDconnecttion)

        ScheduleDGV.Columns(0).DataPropertyName = "UnitID"
        ScheduleDGV.Columns(1).DataPropertyName = "EUAD"
        ScheduleDGV.Columns(2).DataPropertyName = "PHOD"
        ScheduleDGV.Columns(3).DataPropertyName = "PCD"
        ScheduleDGV.Columns(4).DataPropertyName = "ESD"
        ScheduleDGV.Columns(5).DataPropertyName = "ScheduleType"

        SKDadapter.Fill(SKDtable)

        ScheduleDGV.DataSource = SKDtable

        'Actual Data Grid 
        Dim ACTconnecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim ACTtable As New DataTable()
        Dim ACTadapter As New MySqlDataAdapter("SELECT UnitID, AUAD, APHOD, APCD, ASD FROM forest.unit_master WHERE JobNumber = '" & SQLJob & "'", ACTconnecttion)

        ActualDGV.Columns(0).DataPropertyName = "UnitID"
        ActualDGV.Columns(1).DataPropertyName = "AUAD"
        ActualDGV.Columns(2).DataPropertyName = "APHOD"
        ActualDGV.Columns(3).DataPropertyName = "APCD"
        ActualDGV.Columns(4).DataPropertyName = "ASD"

        ACTadapter.Fill(ACTtable)

        ActualDGV.DataSource = ACTtable

    End Sub

    'Direct Cast Unit ID To Form
    Private Sub JobNumberSql_TextChanged_1(sender As Object, e As EventArgs) Handles JobNumberSql.TextChanged

        Testing.SqlUnitID.Text = DirectCast(sender, TextBox).Text
        EditModelNumber.UnitID.Text = DirectCast(sender, TextBox).Text
        EditSerialNumber.UnitID.Text = DirectCast(sender, TextBox).Text
        EditScope.UnitID.Text = DirectCast(sender, TextBox).Text
        EditLocation.UnitID.Text = DirectCast(sender, TextBox).Text

    End Sub

    'Direct Cast Job Number to Form
    Private Sub JobNumber_TextChanged(sender As Object, e As EventArgs) Handles JobNumber.TextChanged

        EditPOAmount.JobNumber.Text = DirectCast(sender, TextBox).Text

    End Sub

    'Test Notes Navigation Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Testing.Show()
    End Sub

    'Edit Model Number Navigation Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditModelNumber.Show()
    End Sub

    'Edit Serial NUmber Navigation Button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EditSerialNumber.Show()
    End Sub

    'Edit Scope Navigation Button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EditScope.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EditLocation.show()
    End Sub

    'Refresh Unit Info DGV
    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MasterRecord_Load(e, e) 'Load everything in form, load event again

    End Sub

    'Edit PO Amount Navigation Button
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EditPOAmount.Show()
    End Sub

End Class