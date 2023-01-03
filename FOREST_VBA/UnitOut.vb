Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class UnitOut
    Private Sub UnitOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubmitBTN.Enabled = False

        'Data Grid 
        Dim connecttion As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT UnitID, ModelNumber, Scope, Engineer, UnitLocation FROM forest.unit_master WHERE TestComplete IS NOT NULL AND MoveOut IS NULL", connecttion)

        ShipItDGV.Columns(0).DataPropertyName = "UnitID"
        ShipItDGV.Columns(1).DataPropertyName = "ModelNumber"
        ShipItDGV.Columns(2).DataPropertyName = "Scope"
        ShipItDGV.Columns(3).DataPropertyName = "Engineer"
        ShipItDGV.Columns(4).DataPropertyName = "UnitLocation"

        adapter.Fill(table)

        ShipItDGV.DataSource = table

        'JobNumber Dropdown
        Dim conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
        Dim strSQL As String = "SELECT UnitID FROM forest.unit_master WHERE TestComplete IS NOT NULL AND MoveOut IS NULL AND ReadyToShip IS NOT NULL"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "unit_master")
        With UnitIDdd
            .Items.Add("Select")
            .DataSource = ds.Tables("unit_master")
            .DisplayMember = "UnitID"
            .ValueMember = "UnitID"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub ShipItDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShipItDGV.CellDoubleClick
        Me.UnitIDdd.Text = Me.ShipItDGV(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub


End Class