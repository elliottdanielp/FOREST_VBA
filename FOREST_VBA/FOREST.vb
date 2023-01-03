Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Data
Imports System.Net



Public Class FOREST
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If TreeView1.SelectedNode.Text.ToString() = "Handoff" Then
            Dim f2 As New SalesHandoff
            SalesHandoff.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Assign Engineer" Then
            Dim f2 As New AssignEngineer
            AssignEngineer.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Schedule Job" Then
            Dim f2 As New ScheduleJob
            ScheduleJob.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Engineering Schedule" Then
            Dim f2 As New EngineeringSchedule
            EngineeringSchedule.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Unit Arrival" Then
            Dim f2 As New UnitArrival
            UnitArrival.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Engineering Release" Then
            Dim f2 As New ReleaseEngineering
            ReleaseEngineering.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Production Handoff" Then
            Dim f2 As New ProductionHandOff
            ProductionHandOff.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Production Complete" Then
            Dim f2 As New ProductionComplete
            ProductionComplete.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Schedule Unit In" Then
            Dim f2 As New ScheduleUnitIn
            ScheduleUnitIn.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Unit In" Then
            Dim f2 As New UnitIn
            UnitIn.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Master Record" Then
            Dim f2 As New MasterRecord
            MasterRecord.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Ready To Ship" Then
            Dim f2 As New ReadyToShip
            ReadyToShip.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Testing" Then
            Dim f2 As New Testing
            Testing.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Unit Out" Then
            Dim f2 As New UnitOut
            UnitOut.Show(ParentForm)
        End If

        If TreeView1.SelectedNode.Text.ToString() = "Unit Shipped" Then
            Dim f2 As New Shipped
            Shipped.Show(ParentForm)
        End If


    End Sub

    Private Sub UnitLocationOutSide_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationOutSide.CellFormatting

        If UnitLocationOutSide.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationOutSide.Rows(0).Cells(0).Selected = False
            UnitLocationOutSide.Columns("Outside").Width = 65
            UnitLocationOutSide.Columns("APHOD").Visible = False
            UnitLocationOutSide.Columns("APCD").Visible = False
            UnitLocationOutSide.Columns("TestComplete").Visible = False
            UnitLocationOutSide.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationOutSide.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationOutSide.Rows(0).Cells(0).Selected = False
            UnitLocationOutSide.Columns("Outside").Width = 65
            UnitLocationOutSide.Columns("APHOD").Visible = False
            UnitLocationOutSide.Columns("APCD").Visible = False
            UnitLocationOutSide.Columns("TestComplete").Visible = False
            UnitLocationOutSide.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationOutSide.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationOutSide.Rows(0).Cells(0).Selected = False
            UnitLocationOutSide.Columns("Outside").Width = 65
            UnitLocationOutSide.Columns("APHOD").Visible = False
            UnitLocationOutSide.Columns("APCD").Visible = False
            UnitLocationOutSide.Columns("TestComplete").Visible = False
            UnitLocationOutSide.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationOutSide.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationOutSide.Rows(0).Cells(0).Selected = False
            UnitLocationOutSide.Columns("Outside").Width = 65
            UnitLocationOutSide.Columns("APHOD").Visible = False
            UnitLocationOutSide.Columns("APCD").Visible = False
            UnitLocationOutSide.Columns("TestComplete").Visible = False
            UnitLocationOutSide.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationOutSide.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationOutSide.Rows(0).Cells(0).Selected = False
            UnitLocationOutSide.Columns("Outside").Width = 65
            UnitLocationOutSide.Columns("APHOD").Visible = False
            UnitLocationOutSide.Columns("APCD").Visible = False
            UnitLocationOutSide.Columns("TestComplete").Visible = False
            UnitLocationOutSide.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay1.CellFormatting

        If UnitLocationBay1.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay1.Rows(0).Cells(0).Selected = False
            UnitLocationBay1.Columns("Bay1").Width = 65
            UnitLocationBay1.Columns("APHOD").Visible = False
            UnitLocationBay1.Columns("APCD").Visible = False
            UnitLocationBay1.Columns("TestComplete").Visible = False
            UnitLocationBay1.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay1.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay1.Rows(0).Cells(0).Selected = False
            UnitLocationBay1.Columns("Bay1").Width = 65
            UnitLocationBay1.Columns("APHOD").Visible = False
            UnitLocationBay1.Columns("APCD").Visible = False
            UnitLocationBay1.Columns("TestComplete").Visible = False
            UnitLocationBay1.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay1.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay1.Rows(0).Cells(0).Selected = False
            UnitLocationBay1.Columns("Bay1").Width = 65
            UnitLocationBay1.Columns("APHOD").Visible = False
            UnitLocationBay1.Columns("APCD").Visible = False
            UnitLocationBay1.Columns("TestComplete").Visible = False
            UnitLocationBay1.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay1.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay1.Rows(0).Cells(0).Selected = False
            UnitLocationBay1.Columns("Bay1").Width = 65
            UnitLocationBay1.Columns("APHOD").Visible = False
            UnitLocationBay1.Columns("APCD").Visible = False
            UnitLocationBay1.Columns("TestComplete").Visible = False
            UnitLocationBay1.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay1.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay1.Rows(0).Cells(0).Selected = False
            UnitLocationBay1.Columns("Bay1").Width = 65
            UnitLocationBay1.Columns("APHOD").Visible = False
            UnitLocationBay1.Columns("APCD").Visible = False
            UnitLocationBay1.Columns("TestComplete").Visible = False
            UnitLocationBay1.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay2A_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay2A.CellFormatting

        If UnitLocationBay2A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay2A.Rows(0).Cells(0).Selected = False
            UnitLocationBay2A.Columns("Bay2A").Width = 65
            UnitLocationBay2A.Columns("APHOD").Visible = False
            UnitLocationBay2A.Columns("APCD").Visible = False
            UnitLocationBay2A.Columns("TestComplete").Visible = False
            UnitLocationBay2A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay2A.Rows(0).Cells(0).Selected = False
            UnitLocationBay2A.Columns("Bay2A").Width = 65
            UnitLocationBay2A.Columns("APHOD").Visible = False
            UnitLocationBay2A.Columns("APCD").Visible = False
            UnitLocationBay2A.Columns("TestComplete").Visible = False
            UnitLocationBay2A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2A.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay2A.Rows(0).Cells(0).Selected = False
            UnitLocationBay2A.Columns("Bay2A").Width = 65
            UnitLocationBay2A.Columns("APHOD").Visible = False
            UnitLocationBay2A.Columns("APCD").Visible = False
            UnitLocationBay2A.Columns("TestComplete").Visible = False
            UnitLocationBay2A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2A.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay2A.Rows(0).Cells(0).Selected = False
            UnitLocationBay2A.Columns("Bay2A").Width = 65
            UnitLocationBay2A.Columns("APHOD").Visible = False
            UnitLocationBay2A.Columns("APCD").Visible = False
            UnitLocationBay2A.Columns("TestComplete").Visible = False
            UnitLocationBay2A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2A.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay2A.Rows(0).Cells(0).Selected = False
            UnitLocationBay2A.Columns("Bay2A").Width = 65
            UnitLocationBay2A.Columns("APHOD").Visible = False
            UnitLocationBay2A.Columns("APCD").Visible = False
            UnitLocationBay2A.Columns("TestComplete").Visible = False
            UnitLocationBay2A.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay2B_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay2B.CellFormatting

        If UnitLocationBay2B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay2B.Rows(0).Cells(0).Selected = False
            UnitLocationBay2B.Columns("Bay2B").Width = 65
            UnitLocationBay2B.Columns("APHOD").Visible = False
            UnitLocationBay2B.Columns("APCD").Visible = False
            UnitLocationBay2B.Columns("TestComplete").Visible = False
            UnitLocationBay2B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay2B.Rows(0).Cells(0).Selected = False
            UnitLocationBay2B.Columns("Bay2B").Width = 65
            UnitLocationBay2B.Columns("APHOD").Visible = False
            UnitLocationBay2B.Columns("APCD").Visible = False
            UnitLocationBay2B.Columns("TestComplete").Visible = False
            UnitLocationBay2B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2B.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay2B.Rows(0).Cells(0).Selected = False
            UnitLocationBay2B.Columns("Bay2B").Width = 65
            UnitLocationBay2B.Columns("APHOD").Visible = False
            UnitLocationBay2B.Columns("APCD").Visible = False
            UnitLocationBay2B.Columns("TestComplete").Visible = False
            UnitLocationBay2B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2B.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay2B.Rows(0).Cells(0).Selected = False
            UnitLocationBay2B.Columns("Bay2B").Width = 65
            UnitLocationBay2B.Columns("APHOD").Visible = False
            UnitLocationBay2B.Columns("APCD").Visible = False
            UnitLocationBay2B.Columns("TestComplete").Visible = False
            UnitLocationBay2B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay2B.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay2B.Rows(0).Cells(0).Selected = False
            UnitLocationBay2B.Columns("Bay2B").Width = 65
            UnitLocationBay2B.Columns("APHOD").Visible = False
            UnitLocationBay2B.Columns("APCD").Visible = False
            UnitLocationBay2B.Columns("TestComplete").Visible = False
            UnitLocationBay2B.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay3A_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay3A.CellFormatting

        If UnitLocationBay3A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay3A.Rows(0).Cells(0).Selected = False
            UnitLocationBay3A.Columns("Bay3A").Width = 65
            UnitLocationBay3A.Columns("APHOD").Visible = False
            UnitLocationBay3A.Columns("APCD").Visible = False
            UnitLocationBay3A.Columns("TestComplete").Visible = False
            UnitLocationBay3A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay3A.Rows(0).Cells(0).Selected = False
            UnitLocationBay3A.Columns("Bay3A").Width = 65
            UnitLocationBay3A.Columns("APHOD").Visible = False
            UnitLocationBay3A.Columns("APCD").Visible = False
            UnitLocationBay3A.Columns("TestComplete").Visible = False
            UnitLocationBay3A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3A.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay3A.Rows(0).Cells(0).Selected = False
            UnitLocationBay3A.Columns("Bay3A").Width = 65
            UnitLocationBay3A.Columns("APHOD").Visible = False
            UnitLocationBay3A.Columns("APCD").Visible = False
            UnitLocationBay3A.Columns("TestComplete").Visible = False
            UnitLocationBay3A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3A.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay3A.Rows(0).Cells(0).Selected = False
            UnitLocationBay3A.Columns("Bay3A").Width = 65
            UnitLocationBay3A.Columns("APHOD").Visible = False
            UnitLocationBay3A.Columns("APCD").Visible = False
            UnitLocationBay3A.Columns("TestComplete").Visible = False
            UnitLocationBay3A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3A.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay3A.Rows(0).Cells(0).Selected = False
            UnitLocationBay3A.Columns("Bay3A").Width = 65
            UnitLocationBay3A.Columns("APHOD").Visible = False
            UnitLocationBay3A.Columns("APCD").Visible = False
            UnitLocationBay3A.Columns("TestComplete").Visible = False
            UnitLocationBay3A.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay3B_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay3B.CellFormatting

        If UnitLocationBay3B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay3B.Rows(0).Cells(0).Selected = False
            UnitLocationBay3B.Columns("Bay3B").Width = 65
            UnitLocationBay3B.Columns("APHOD").Visible = False
            UnitLocationBay3B.Columns("APCD").Visible = False
            UnitLocationBay3B.Columns("TestComplete").Visible = False
            UnitLocationBay3B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay3B.Rows(0).Cells(0).Selected = False
            UnitLocationBay3B.Columns("Bay3B").Width = 65
            UnitLocationBay3B.Columns("APHOD").Visible = False
            UnitLocationBay3B.Columns("APCD").Visible = False
            UnitLocationBay3B.Columns("TestComplete").Visible = False
            UnitLocationBay3B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3B.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay3B.Rows(0).Cells(0).Selected = False
            UnitLocationBay3B.Columns("Bay3B").Width = 65
            UnitLocationBay3B.Columns("APHOD").Visible = False
            UnitLocationBay3B.Columns("APCD").Visible = False
            UnitLocationBay3B.Columns("TestComplete").Visible = False
            UnitLocationBay3B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3B.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay3B.Rows(0).Cells(0).Selected = False
            UnitLocationBay3B.Columns("Bay3B").Width = 65
            UnitLocationBay3B.Columns("APHOD").Visible = False
            UnitLocationBay3B.Columns("APCD").Visible = False
            UnitLocationBay3B.Columns("TestComplete").Visible = False
            UnitLocationBay3B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay3B.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay3B.Rows(0).Cells(0).Selected = False
            UnitLocationBay3B.Columns("Bay3B").Width = 65
            UnitLocationBay3B.Columns("APHOD").Visible = False
            UnitLocationBay3B.Columns("APCD").Visible = False
            UnitLocationBay3B.Columns("TestComplete").Visible = False
            UnitLocationBay3B.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay4A_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay4A.CellFormatting

        If UnitLocationBay4A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay4A.Rows(0).Cells(0).Selected = False
            UnitLocationBay4A.Columns("Bay4A").Width = 65
            UnitLocationBay4A.Columns("APHOD").Visible = False
            UnitLocationBay4A.Columns("APCD").Visible = False
            UnitLocationBay4A.Columns("TestComplete").Visible = False
            UnitLocationBay4A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4A.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay4A.Rows(0).Cells(0).Selected = False
            UnitLocationBay4A.Columns("Bay4A").Width = 65
            UnitLocationBay4A.Columns("APHOD").Visible = False
            UnitLocationBay4A.Columns("APCD").Visible = False
            UnitLocationBay4A.Columns("TestComplete").Visible = False
            UnitLocationBay4A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4A.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay4A.Rows(0).Cells(0).Selected = False
            UnitLocationBay4A.Columns("Bay4A").Width = 65
            UnitLocationBay4A.Columns("APHOD").Visible = False
            UnitLocationBay4A.Columns("APCD").Visible = False
            UnitLocationBay4A.Columns("TestComplete").Visible = False
            UnitLocationBay4A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4A.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay4A.Rows(0).Cells(0).Selected = False
            UnitLocationBay4A.Columns("Bay4A").Width = 65
            UnitLocationBay4A.Columns("APHOD").Visible = False
            UnitLocationBay4A.Columns("APCD").Visible = False
            UnitLocationBay4A.Columns("TestComplete").Visible = False
            UnitLocationBay4A.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4A.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay4A.Rows(0).Cells(0).Selected = False
            UnitLocationBay4A.Columns("Bay4A").Width = 65
            UnitLocationBay4A.Columns("APHOD").Visible = False
            UnitLocationBay4A.Columns("APCD").Visible = False
            UnitLocationBay4A.Columns("TestComplete").Visible = False
            UnitLocationBay4A.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay4B_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay4B.CellFormatting

        If UnitLocationBay4B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay4B.Rows(0).Cells(0).Selected = False
            UnitLocationBay4B.Columns("Bay4B").Width = 65
            UnitLocationBay4B.Columns("APHOD").Visible = False
            UnitLocationBay4B.Columns("APCD").Visible = False
            UnitLocationBay4B.Columns("TestComplete").Visible = False
            UnitLocationBay4B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4B.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay4B.Rows(0).Cells(0).Selected = False
            UnitLocationBay4B.Columns("Bay4B").Width = 65
            UnitLocationBay4B.Columns("APHOD").Visible = False
            UnitLocationBay4B.Columns("APCD").Visible = False
            UnitLocationBay4B.Columns("TestComplete").Visible = False
            UnitLocationBay4B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4B.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay4B.Rows(0).Cells(0).Selected = False
            UnitLocationBay4B.Columns("Bay4B").Width = 65
            UnitLocationBay4B.Columns("APHOD").Visible = False
            UnitLocationBay4B.Columns("APCD").Visible = False
            UnitLocationBay4B.Columns("TestComplete").Visible = False
            UnitLocationBay4B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4B.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay4B.Rows(0).Cells(0).Selected = False
            UnitLocationBay4B.Columns("Bay4B").Width = 65
            UnitLocationBay4B.Columns("APHOD").Visible = False
            UnitLocationBay4B.Columns("APCD").Visible = False
            UnitLocationBay4B.Columns("TestComplete").Visible = False
            UnitLocationBay4B.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay4B.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay4B.Rows(0).Cells(0).Selected = False
            UnitLocationBay4B.Columns("Bay4B").Width = 65
            UnitLocationBay4B.Columns("APHOD").Visible = False
            UnitLocationBay4B.Columns("APCD").Visible = False
            UnitLocationBay4B.Columns("TestComplete").Visible = False
            UnitLocationBay4B.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay5_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay5.CellFormatting

        If UnitLocationBay5.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay5.Rows(0).Cells(0).Selected = False
            UnitLocationBay5.Columns("Bay5").Width = 65
            UnitLocationBay5.Columns("APHOD").Visible = False
            UnitLocationBay5.Columns("APCD").Visible = False
            UnitLocationBay5.Columns("TestComplete").Visible = False
            UnitLocationBay5.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay5.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay5.Rows(0).Cells(0).Selected = False
            UnitLocationBay5.Columns("Bay5").Width = 65
            UnitLocationBay5.Columns("APHOD").Visible = False
            UnitLocationBay5.Columns("APCD").Visible = False
            UnitLocationBay5.Columns("TestComplete").Visible = False
            UnitLocationBay5.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay5.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay5.Rows(0).Cells(0).Selected = False
            UnitLocationBay5.Columns("Bay5").Width = 65
            UnitLocationBay5.Columns("APHOD").Visible = False
            UnitLocationBay5.Columns("APCD").Visible = False
            UnitLocationBay5.Columns("TestComplete").Visible = False
            UnitLocationBay5.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay5.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay5.Rows(0).Cells(0).Selected = False
            UnitLocationBay5.Columns("Bay5").Width = 65
            UnitLocationBay5.Columns("APHOD").Visible = False
            UnitLocationBay5.Columns("APCD").Visible = False
            UnitLocationBay5.Columns("TestComplete").Visible = False
            UnitLocationBay5.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay5.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay5.Rows(0).Cells(0).Selected = False
            UnitLocationBay5.Columns("Bay5").Width = 65
            UnitLocationBay5.Columns("APHOD").Visible = False
            UnitLocationBay5.Columns("APCD").Visible = False
            UnitLocationBay5.Columns("TestComplete").Visible = False
            UnitLocationBay5.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationBay6_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationBay6.CellFormatting

        If UnitLocationBay6.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationBay6.Rows(0).Cells(0).Selected = False
            UnitLocationBay6.Columns("Bay6").Width = 65
            UnitLocationBay6.Columns("APHOD").Visible = False
            UnitLocationBay6.Columns("APCD").Visible = False
            UnitLocationBay6.Columns("TestComplete").Visible = False
            UnitLocationBay6.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay6.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationBay6.Rows(0).Cells(0).Selected = False
            UnitLocationBay6.Columns("Bay6").Width = 65
            UnitLocationBay6.Columns("APHOD").Visible = False
            UnitLocationBay6.Columns("APCD").Visible = False
            UnitLocationBay6.Columns("TestComplete").Visible = False
            UnitLocationBay6.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay6.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationBay6.Rows(0).Cells(0).Selected = False
            UnitLocationBay6.Columns("Bay6").Width = 65
            UnitLocationBay6.Columns("APHOD").Visible = False
            UnitLocationBay6.Columns("APCD").Visible = False
            UnitLocationBay6.Columns("TestComplete").Visible = False
            UnitLocationBay6.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay6.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationBay6.Rows(0).Cells(0).Selected = False
            UnitLocationBay6.Columns("Bay6").Width = 65
            UnitLocationBay6.Columns("APHOD").Visible = False
            UnitLocationBay6.Columns("APCD").Visible = False
            UnitLocationBay6.Columns("TestComplete").Visible = False
            UnitLocationBay6.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationBay6.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationBay6.Rows(0).Cells(0).Selected = False
            UnitLocationBay6.Columns("Bay6").Width = 65
            UnitLocationBay6.Columns("APHOD").Visible = False
            UnitLocationBay6.Columns("APCD").Visible = False
            UnitLocationBay6.Columns("TestComplete").Visible = False
            UnitLocationBay6.Columns("ReadyToShip").Visible = False
        End If

    End Sub

    Private Sub UnitLocationComplete_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles UnitLocationComplete.CellFormatting

        If UnitLocationComplete.Rows(e.RowIndex).Cells("APHOD").Value.ToString() = "" Then
            UnitLocationComplete.Rows(0).Cells(0).Selected = False
            UnitLocationComplete.Columns("Complete").Width = 65
            UnitLocationComplete.Columns("APHOD").Visible = False
            UnitLocationComplete.Columns("APCD").Visible = False
            UnitLocationComplete.Columns("TestComplete").Visible = False
            UnitLocationComplete.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationComplete.Rows(e.RowIndex).Cells("APHOD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightGreen
            UnitLocationComplete.Rows(0).Cells(0).Selected = False
            UnitLocationComplete.Columns("Complete").Width = 65
            UnitLocationComplete.Columns("APHOD").Visible = False
            UnitLocationComplete.Columns("APCD").Visible = False
            UnitLocationComplete.Columns("TestComplete").Visible = False
            UnitLocationComplete.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationComplete.Rows(e.RowIndex).Cells("APCD").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.Orange
            UnitLocationComplete.Rows(0).Cells(0).Selected = False
            UnitLocationComplete.Columns("Complete").Width = 65
            UnitLocationComplete.Columns("APHOD").Visible = False
            UnitLocationComplete.Columns("APCD").Visible = False
            UnitLocationComplete.Columns("TestComplete").Visible = False
            UnitLocationComplete.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationComplete.Rows(e.RowIndex).Cells("TestComplete").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightCoral
            UnitLocationComplete.Rows(0).Cells(0).Selected = False
            UnitLocationComplete.Columns("Complete").Width = 65
            UnitLocationComplete.Columns("APHOD").Visible = False
            UnitLocationComplete.Columns("APCD").Visible = False
            UnitLocationComplete.Columns("TestComplete").Visible = False
            UnitLocationComplete.Columns("ReadyToShip").Visible = False
        End If

        If UnitLocationComplete.Rows(e.RowIndex).Cells("ReadyToShip").Value.ToString() > "" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
            UnitLocationComplete.Rows(0).Cells(0).Selected = False
            UnitLocationComplete.Columns("Complete").Width = 65
            UnitLocationComplete.Columns("APHOD").Visible = False
            UnitLocationComplete.Columns("APCD").Visible = False
            UnitLocationComplete.Columns("TestComplete").Visible = False
            UnitLocationComplete.Columns("ReadyToShip").Visible = False
        End If

    End Sub


    Private Sub FOREST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Font As New Font("Microsoft Sans Serif", 12)


        'AsOf Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim AsOftxt As String
            cmd.CommandText = "SELECT UpdateDate FROM forest.finance_master"
            AsOftxt = Convert.ToString(cmd.ExecuteScalar())

            AsOf.Text = AsOftxt

            conn.Close()

        End Using

        'WIP Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim WIPtxt As String
            cmd.CommandText = "SELECT WIP FROM forest.finance_master"
            WIPtxt = Convert.ToString(cmd.ExecuteScalar())

            WIP.Text = WIPtxt

            conn.Close()

        End Using

        'Shipments Text Box
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim Shipmentstxt As String
            cmd.CommandText = "SELECT Shipments FROM forest.finance_master"
            Shipmentstxt = Convert.ToString(cmd.ExecuteScalar())

            Shipments.Text = Shipmentstxt

            conn.Close()

        End Using

        'Shipments Text Box
        Total.Text = WIP.Text + Shipments.Text

        'Data Grid OutSide
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table0 As New DataTable()
        Dim adapter0 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Here'", connecttion)

        UnitLocationOutSide.Columns(0).DataPropertyName = "UnitID"

        adapter0.Fill(table0)

        UnitLocationOutSide.DataSource = table0

        'Data Grid Bay 1
        Dim table1 As New DataTable()
        Dim adapter1 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 1'", connecttion)

        UnitLocationBay1.Columns(0).DataPropertyName = "UnitID"

        adapter1.Fill(table1)

        UnitLocationBay1.DataSource = table1

        'Data Grid Bay 2A
        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 2A'", connecttion)

        UnitLocationBay2A.Columns(0).DataPropertyName = "UnitID"

        adapter2.Fill(table2)

        UnitLocationBay2A.DataSource = table2

        'Data Grid Bay 2B
        Dim table3 As New DataTable()
        Dim adapter3 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 2B'", connecttion)

        UnitLocationBay2B.Columns(0).DataPropertyName = "UnitID"

        adapter3.Fill(table3)

        UnitLocationBay2B.DataSource = table3

        'Data Grid Bay 3A
        Dim table4 As New DataTable()
        Dim adapter4 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 3A'", connecttion)

        UnitLocationBay3A.Columns(0).DataPropertyName = "UnitID"

        adapter4.Fill(table4)

        UnitLocationBay3A.DataSource = table4

        'Data Grid Bay 3B
        Dim table5 As New DataTable()
        Dim adapter5 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 3B'", connecttion)

        UnitLocationBay3B.Columns(0).DataPropertyName = "UnitID"

        adapter5.Fill(table5)

        UnitLocationBay3B.DataSource = table5

        'Data Grid Bay 4A
        Dim table6 As New DataTable()
        Dim adapter6 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 4A'", connecttion)

        UnitLocationBay4A.Columns(0).DataPropertyName = "UnitID"

        adapter6.Fill(table6)

        UnitLocationBay4A.DataSource = table6

        'Data Grid Bay 4B
        Dim table7 As New DataTable()
        Dim adapter7 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 4B'", connecttion)

        UnitLocationBay4B.Columns(0).DataPropertyName = "UnitID"

        adapter7.Fill(table7)

        UnitLocationBay4B.DataSource = table7

        'Data Grid Bay 5
        Dim table8 As New DataTable()
        Dim adapter8 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 5'", connecttion)

        UnitLocationBay5.Columns(0).DataPropertyName = "UnitID"

        adapter8.Fill(table8)

        UnitLocationBay5.DataSource = table8

        'Data Grid Bay 6
        Dim table9 As New DataTable()
        Dim adapter9 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 6'", connecttion)

        UnitLocationBay6.Columns(0).DataPropertyName = "UnitID"

        adapter9.Fill(table9)

        UnitLocationBay6.DataSource = table9

        'Data Grid Complete
        Dim table10 As New DataTable()
        Dim adapter10 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Complete'", connecttion)

        UnitLocationComplete.Columns(0).DataPropertyName = "UnitID"

        adapter10.Fill(table10)

        UnitLocationComplete.DataSource = table10

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click

        'Data Grid OutSide
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table0 As New DataTable()
        Dim adapter0 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Here'", connecttion)

        UnitLocationOutSide.Columns(0).DataPropertyName = "UnitID"

        adapter0.Fill(table0)

        UnitLocationOutSide.DataSource = table0

        'Data Grid Bay 1
        Dim table1 As New DataTable()
        Dim adapter1 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 1'", connecttion)

        UnitLocationBay1.Columns(0).DataPropertyName = "UnitID"

        adapter1.Fill(table1)

        UnitLocationBay1.DataSource = table1

        'Data Grid Bay 2A
        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 2A'", connecttion)

        UnitLocationBay2A.Columns(0).DataPropertyName = "UnitID"

        adapter2.Fill(table2)

        UnitLocationBay2A.DataSource = table2

        'Data Grid Bay 2B
        Dim table3 As New DataTable()
        Dim adapter3 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 2B'", connecttion)

        UnitLocationBay2B.Columns(0).DataPropertyName = "UnitID"

        adapter3.Fill(table3)

        UnitLocationBay2B.DataSource = table3

        'Data Grid Bay 3A
        Dim table4 As New DataTable()
        Dim adapter4 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 3A'", connecttion)

        UnitLocationBay3A.Columns(0).DataPropertyName = "UnitID"

        adapter4.Fill(table4)

        UnitLocationBay3A.DataSource = table4

        'Data Grid Bay 3B
        Dim table5 As New DataTable()
        Dim adapter5 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 3B'", connecttion)

        UnitLocationBay3B.Columns(0).DataPropertyName = "UnitID"

        adapter5.Fill(table5)

        UnitLocationBay3B.DataSource = table5

        'Data Grid Bay 4A
        Dim table6 As New DataTable()
        Dim adapter6 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 4A'", connecttion)

        UnitLocationBay4A.Columns(0).DataPropertyName = "UnitID"

        adapter6.Fill(table6)

        UnitLocationBay4A.DataSource = table6

        'Data Grid Bay 4B
        Dim table7 As New DataTable()
        Dim adapter7 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 4B'", connecttion)

        UnitLocationBay4B.Columns(0).DataPropertyName = "UnitID"

        adapter7.Fill(table7)

        UnitLocationBay4B.DataSource = table7

        'Data Grid Bay 5
        Dim table8 As New DataTable()
        Dim adapter8 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 5'", connecttion)

        UnitLocationBay5.Columns(0).DataPropertyName = "UnitID"

        adapter8.Fill(table8)

        UnitLocationBay5.DataSource = table8

        'Data Grid Bay 6
        Dim table9 As New DataTable()
        Dim adapter9 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Bay 6'", connecttion)

        UnitLocationBay6.Columns(0).DataPropertyName = "UnitID"

        adapter9.Fill(table9)

        UnitLocationBay6.DataSource = table9

        'Data Grid Complete
        Dim table10 As New DataTable()
        Dim adapter10 As New MySqlDataAdapter("SELECT UnitID, APHOD, APCD, TestComplete, ReadyToShip FROM forest.unit_master WHERE UnitLocation = 'Complete'", connecttion)

        UnitLocationComplete.Columns(0).DataPropertyName = "UnitID"

        adapter10.Fill(table10)

        UnitLocationComplete.DataSource = table10

    End Sub

    Private Sub UnitLocationOutSide_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationOutSide.CellContentClick

        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationOutSide.CurrentCell.Value.ToString

        fr2.Show()

    End Sub

    Private Sub UnitLocationBay1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay1.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay1.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay2A_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay2A.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay2A.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay2B_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay2B.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay2B.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay3A_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay3A.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay3A.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay3B_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay3B.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay3B.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay4A_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay4A.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay4A.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay4B_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay4B.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay4B.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay5.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay5.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationBay6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationBay6.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationBay6.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub UnitLocationComplete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnitLocationComplete.CellContentClick
        Dim fr2 As New MasterRecord
        fr2.getName = Me.UnitLocationComplete.CurrentCell.Value.ToString

        fr2.Show()
    End Sub

    Private Sub Total_TextChanged(sender As Object, e As EventArgs) Handles Total.TextChanged
        Dim amount As Integer = CType(Total.Text, Integer)
        Total.Text = amount.ToString("$##,##,###.00")
    End Sub
End Class
