Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Globalization

Public Class EngineeringSchedule

    Private Sub EngineeringSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LongLeadDD.Enabled = False
        SheetMetalDD.Enabled = False
        MechanicalDD.Enabled = False
        RefrigerationDD.Enabled = False
        HydronicsDD.Enabled = False
        PowerDD.Enabled = False
        ControlsDD.Enabled = False
        ProgramDD.Enabled = False
        BOMDD.Enabled = False
        IOMDD.Enabled = False
        CULDD.Enabled = False
        ECheckedDD.Enabled = False
        MCheckedDD.Enabled = False
        UnitIDDD.Enabled = False
        SubmitBTN.Enabled = False
        EngineeringComplteCHK.Enabled = False
        CompleteDate.Enabled = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EngineerSelection.SelectedIndexChanged

        UnitIDDD.Enabled = True

        'Data Grid 
        Dim EngineerDropDown
        EngineerDropDown = EngineerSelection.Text
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

        EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
        EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
        EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
        EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
        EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
        EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
        EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
        EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
        EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
        EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
        EngineerScheduleData.Columns(10).DataPropertyName = "Power"
        EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
        EngineerScheduleData.Columns(12).DataPropertyName = "Program"
        EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
        EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
        EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
        EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
        EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
        EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
        EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

        adapter.Fill(table)

        EngineerScheduleData.DataSource = table

        'Data Grid Unit Location
        Dim table1 As New DataTable()
        Dim adapter1 As New MySqlDataAdapter("SELECT UnitID, UnitLocation FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "' AND (forest.unit_master.UnitLocation='Bay 1' OR forest.unit_master.UnitLocation='Bay 2A' OR forest.unit_master.UnitLocation='Bay 2B' OR forest.unit_master.UnitLocation='Bay 3A' OR forest.unit_master.UnitLocation='Bay 3B' OR forest.unit_master.UnitLocation='Bay 4A' OR forest.unit_master.UnitLocation='Bay 4B' OR forest.unit_master.UnitLocation='Bay 5' OR forest.unit_master.UnitLocation='Bay 6' OR forest.unit_master.UnitLocation='Complete' OR forest.unit_master.UnitLocation='Here')", connecttion)

        UnitLocationTbl.Columns(0).DataPropertyName = "UnitID"
        UnitLocationTbl.Columns(1).DataPropertyName = "UnitLocation"

        adapter1.Fill(table1)

        UnitLocationTbl.DataSource = table1

        Dim SqlEngineer = EngineerSelection.Text

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT DISTINCT UnitID FROM forest.unit_master WHERE Engineer = '" & SqlEngineer & "'"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With UnitIDDD
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "UnitID"
            .ValueMember = "UnitID"
            .SelectedIndex = -1
        End With

        LongLeadDD.Enabled = False
        SheetMetalDD.Enabled = False
        MechanicalDD.Enabled = False
        RefrigerationDD.Enabled = False
        HydronicsDD.Enabled = False
        PowerDD.Enabled = False
        ControlsDD.Enabled = False
        ProgramDD.Enabled = False
        BOMDD.Enabled = False
        IOMDD.Enabled = False
        CULDD.Enabled = False
        ECheckedDD.Enabled = False
        MCheckedDD.Enabled = False
        EngineeringComplteCHK.Enabled = False

    End Sub

    Private Sub UnitIDDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitIDDD.SelectedIndexChanged

        If UnitIDDD.Text > "" Then

            LongLeadDD.Enabled = True
            SheetMetalDD.Enabled = True
            MechanicalDD.Enabled = True
            RefrigerationDD.Enabled = True
            HydronicsDD.Enabled = True
            PowerDD.Enabled = True
            ControlsDD.Enabled = True
            ProgramDD.Enabled = True
            BOMDD.Enabled = True
            IOMDD.Enabled = True
            CULDD.Enabled = True
            ECheckedDD.Enabled = True
            MCheckedDD.Enabled = True
            EngineeringComplteCHK.Enabled = True

        End If

    End Sub

    Private Sub EngineerScheduleData_CellFormatting(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
    Handles EngineerScheduleData.CellFormatting

        If e.ColumnIndex = EngineerScheduleData.Columns("LongLead").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("SheetMetal").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Mechanical").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Refrigeration").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Hydronics").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Power").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Control").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("Program").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("BOM").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("IOM").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("CUL").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("EChecked").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If

        If e.ColumnIndex = EngineerScheduleData.Columns("MChecked").Index Then
            If e.Value.ToString = "Not Started" Then
                e.CellStyle.BackColor = Color.Red
                e.Value = ""
            End If

            If e.Value.ToString = "In Process" Then
                e.CellStyle.BackColor = Color.Yellow
                e.Value = ""
            End If

            If e.Value.ToString = "Complete" Then
                e.CellStyle.BackColor = Color.Green
                e.Value = ""
            End If

            If e.Value.ToString = "Not Required" Then
                e.CellStyle.BackColor = Color.Gray
                e.Value = ""
            End If
        End If
    End Sub

    Private Sub MechanicalDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MechanicalDD.SelectedIndexChanged

        If MechanicalDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
            " SET Mechanical= @MechanicalDD" &
            " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
                  cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@MechanicalDD", MySqlDbType.VarChar, 12).Value = MechanicalDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        MechanicalDD.SelectedIndex = -1

    End Sub

    Private Sub BOMDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOMDD.SelectedIndexChanged

        If BOMDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET BOM= @BOMDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@BOMDD", MySqlDbType.VarChar, 12).Value = BOMDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        BOMDD.SelectedIndex = -1

    End Sub

    Private Sub PowerDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PowerDD.SelectedIndexChanged

        If PowerDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET Power= @PowerDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@PowerDD", MySqlDbType.VarChar, 12).Value = PowerDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        PowerDD.SelectedIndex = -1

    End Sub

    Private Sub LongLeadDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LongLeadDD.SelectedIndexChanged

        If LongLeadDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET LongLead= @LongLeadDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@LongLeadDD", MySqlDbType.VarChar, 12).Value = LongLeadDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        LongLeadDD.SelectedIndex = -1

    End Sub

    Private Sub ControlsDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ControlsDD.SelectedIndexChanged

        If ControlsDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET Controls= @ControlsDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@ControlsDD", MySqlDbType.VarChar, 12).Value = ControlsDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        ControlsDD.SelectedIndex = -1

    End Sub

    Private Sub IOMDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IOMDD.SelectedIndexChanged

        If IOMDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET IOM= @IOMDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@IOMDD", MySqlDbType.VarChar, 12).Value = IOMDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        IOMDD.SelectedIndex = -1

    End Sub

    Private Sub CULDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CULDD.SelectedIndexChanged

        If CULDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET CUL= @CULDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@CULDD", MySqlDbType.VarChar, 12).Value = CULDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        CULDD.SelectedIndex = -1

    End Sub

    Private Sub RefrigerationDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RefrigerationDD.SelectedIndexChanged

        If RefrigerationDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET Refrigeration= @RefrigerationDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@RefrigerationDD", MySqlDbType.VarChar, 12).Value = RefrigerationDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        RefrigerationDD.SelectedIndex = -1

    End Sub

    Private Sub ProgramDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgramDD.SelectedIndexChanged

        If ProgramDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET Program= @ProgramDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@ProgramDD", MySqlDbType.VarChar, 12).Value = ProgramDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        ProgramDD.SelectedIndex = -1

    End Sub

    Private Sub SheetMetalDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SheetMetalDD.SelectedIndexChanged

        If SheetMetalDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET SheetMetal= @SheetMetalDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@SheetMetalDD", MySqlDbType.VarChar, 12).Value = SheetMetalDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        SheetMetalDD.SelectedIndex = -1

    End Sub

    Private Sub HydronicsDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HydronicsDD.SelectedIndexChanged

        If HydronicsDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
            " SET Hydronics= @HydronicsDD" &
            " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
                  cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@HydronicsDD", MySqlDbType.VarChar, 12).Value = HydronicsDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        HydronicsDD.SelectedIndex = -1

    End Sub

    Private Sub ECheckedDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ECheckedDD.SelectedIndexChanged

        If ECheckedDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET EChecked= @ECheckedDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@ECheckedDD", MySqlDbType.VarChar, 12).Value = ECheckedDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        ECheckedDD.SelectedIndex = -1

    End Sub

    Private Sub MCheckedDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MCheckedDD.SelectedIndexChanged

        If MCheckedDD.Text > "" Then

            Dim SQLLine As String

            SQLLine = "UPDATE forest.unit_master " &
        " SET MChecked= @MCheckedDD" &
        " WHERE UnitID= @UnitIDDD"

            Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

                'Use actual column types/lengths from your DB here
                cmd.Parameters.Add("@MCheckedDD", MySqlDbType.VarChar, 12).Value = MCheckedDD.Text
                cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            'Data Grid 
            Dim EngineerDropDown
            EngineerDropDown = EngineerSelection.Text
            Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

            EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
            EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
            EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
            EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
            EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
            EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
            EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
            EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
            EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
            EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
            EngineerScheduleData.Columns(10).DataPropertyName = "Power"
            EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
            EngineerScheduleData.Columns(12).DataPropertyName = "Program"
            EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
            EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
            EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
            EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
            EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
            EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
            EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

            adapter.Fill(table)

            EngineerScheduleData.DataSource = table

        End If

        MCheckedDD.SelectedIndex = -1

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles EngineeringComplteCHK.CheckedChanged

        SubmitBTN.Enabled = True
        CompleteDate.Enabled = True

        Dim todaysdate As Date = Date.Today

        CompleteDate.Text = todaysdate

    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click

        'Dim todaysdate As Date = Date.Today

        'todaysdate.ToString("MM'/'dd'/'yyyy")

        Dim SQLLine As String

        SQLLine = "UPDATE forest.unit_master " &
        " SET ActualEngineeringCompleteDate = @CompleteDate " &
        " WHERE UnitID = @UnitIDDD"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
          cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from your DB here
            cmd.Parameters.Add("@CompleteDate", MySqlDbType.VarChar, 20).Value = CompleteDate.Text
            cmd.Parameters.Add("@UnitIDDD", MySqlDbType.VarChar, 10).Value = UnitIDDD.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        'Data Grid 
        Dim EngineerDropDown
        EngineerDropDown = EngineerSelection.Text
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, SubmittalPromiseDate, EngineeringReleaseDate, LongLead, SheetMetal, Mechanical, Refrigeration, Hydronics, Power, Controls, Program, BOM, IOM, CUL, EChecked, MChecked, ActualEngineeringCompleteDate, PHOD FROM forest.unit_master WHERE Engineer = '" & EngineerDropDown & "'", connecttion)

        EngineerScheduleData.Columns(0).DataPropertyName = "UnitID"
        EngineerScheduleData.Columns(1).DataPropertyName = "ModelNumber"
        EngineerScheduleData.Columns(2).DataPropertyName = "Scope"
        EngineerScheduleData.Columns(3).DataPropertyName = "SubmittalPromiseDate"
        EngineerScheduleData.Columns(4).DataPropertyName = "EngineeringReleaseDate"
        EngineerScheduleData.Columns(5).DataPropertyName = "LongLead"
        EngineerScheduleData.Columns(6).DataPropertyName = "SheetMetal"
        EngineerScheduleData.Columns(7).DataPropertyName = "Mechanical"
        EngineerScheduleData.Columns(8).DataPropertyName = "Refrigeration"
        EngineerScheduleData.Columns(9).DataPropertyName = "Hydronics"
        EngineerScheduleData.Columns(10).DataPropertyName = "Power"
        EngineerScheduleData.Columns(11).DataPropertyName = "Controls"
        EngineerScheduleData.Columns(12).DataPropertyName = "Program"
        EngineerScheduleData.Columns(13).DataPropertyName = "BOM"
        EngineerScheduleData.Columns(14).DataPropertyName = "IOM"
        EngineerScheduleData.Columns(15).DataPropertyName = "CUL"
        EngineerScheduleData.Columns(16).DataPropertyName = "EChecked"
        EngineerScheduleData.Columns(17).DataPropertyName = "MChecked"
        EngineerScheduleData.Columns(18).DataPropertyName = "ActualEngineeringCompleteDate"
        EngineerScheduleData.Columns(19).DataPropertyName = "PHOD"

        adapter.Fill(table)

        EngineerScheduleData.DataSource = table

    End Sub

    Private Sub EngineerScheduleData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EngineerScheduleData.CellDoubleClick
        Me.UnitIDDD.Text = Me.EngineerScheduleData(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub
End Class