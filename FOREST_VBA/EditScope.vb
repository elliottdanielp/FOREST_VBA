Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports System.Net.Mail

Public Class EditScope

    Private Sub EditScope_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'JobNumber Text Box
        Dim SqlJobNumber = UnitID.Text
        Using conn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;")
            conn.Open()
            Dim cmd As New MySqlCommand("", conn)
            Dim ScopeText As String
            cmd.CommandText = "SELECT Scope FROM forest.unit_master WHERE UnitID = '" & SqlJobNumber & "'"
            ScopeText = Convert.ToString(cmd.ExecuteScalar())

            Scope.Text = ScopeText

            conn.Close()

        End Using

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox77.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox38.CheckedChanged, CheckBox95.CheckedChanged, CheckBox8.CheckedChanged, CheckBox88.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox89.CheckedChanged, CheckBox16.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged, CheckBox15.CheckedChanged, CheckBox13.CheckedChanged, CheckBox14.CheckedChanged, CheckBox39.CheckedChanged, CheckBox17.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox21.CheckedChanged, CheckBox23.CheckedChanged, CheckBox20.CheckedChanged, CheckBox90.CheckedChanged, CheckBox24.CheckedChanged, CheckBox26.CheckedChanged, CheckBox27.CheckedChanged, CheckBox29.CheckedChanged, CheckBox33.CheckedChanged, CheckBox96.CheckedChanged, CheckBox34.CheckedChanged, CheckBox91.CheckedChanged, CheckBox36.CheckedChanged, CheckBox35.CheckedChanged, CheckBox41.CheckedChanged, CheckBox46.CheckedChanged, CheckBox43.CheckedChanged, CheckBox44.CheckedChanged, CheckBox42.CheckedChanged, CheckBox45.CheckedChanged, CheckBox87.CheckedChanged, CheckBox73.CheckedChanged, CheckBox49.CheckedChanged, CheckBox50.CheckedChanged, CheckBox51.CheckedChanged, CheckBox52.CheckedChanged, CheckBox55.CheckedChanged, CheckBox54.CheckedChanged, CheckBox48.CheckedChanged, CheckBox63.CheckedChanged, CheckBox57.CheckedChanged, CheckBox56.CheckedChanged, CheckBox22.CheckedChanged, CheckBox58.CheckedChanged, CheckBox62.CheckedChanged, CheckBox59.CheckedChanged, CheckBox10.CheckedChanged, CheckBox60.CheckedChanged, CheckBox82.CheckedChanged, CheckBox85.CheckedChanged, CheckBox61.CheckedChanged, CheckBox37.CheckedChanged, CheckBox65.CheckedChanged, CheckBox25.CheckedChanged, CheckBox94.CheckedChanged, CheckBox31.CheckedChanged, CheckBox64.CheckedChanged, CheckBox80.CheckedChanged, CheckBox67.CheckedChanged, CheckBox66.CheckedChanged, CheckBox81.CheckedChanged, CheckBox68.CheckedChanged, CheckBox69.CheckedChanged, CheckBox86.CheckedChanged, CheckBox47.CheckedChanged, CheckBox70.CheckedChanged, CheckBox72.CheckedChanged, CheckBox71.CheckedChanged, CheckBox75.CheckedChanged, CheckBox78.CheckedChanged, CheckBox9.CheckedChanged, CheckBox76.CheckedChanged, CheckBox83.CheckedChanged, CheckBox84.CheckedChanged, CheckBox79.CheckedChanged, CheckBox92.CheckedChanged, CheckBox74.CheckedChanged, CheckBox32.CheckedChanged, CheckBox28.CheckedChanged, CheckBox53.CheckedChanged

        Dim ScopeText As String = String.Empty
        If CheckBox1.Checked Then ScopeText &= "100OA, "
        If CheckBox77.Checked Then ScopeText &= "3RConv, "
        If CheckBox2.Checked Then ScopeText &= "AcousticPkg, "
        If CheckBox3.Checked Then ScopeText &= "AFlowMod, "
        If CheckBox4.Checked Then ScopeText &= "AcousticEnc, "
        If CheckBox5.Checked Then ScopeText &= "BTank, "
        If CheckBox38.Checked Then ScopeText &= "CarbFilt, "
        If CheckBox95.Checked Then ScopeText &= "CFan, "
        If CheckBox8.Checked Then ScopeText &= "CFanStacks, "
        If CheckBox88.Checked Then ScopeText &= "CHWCoil, "
        If CheckBox7.Checked Then ScopeText &= "CompBlnkt, "
        If CheckBox6.Checked Then ScopeText &= "CompEnc, "
        If CheckBox89.Checked Then ScopeText &= "CondCoil, "
        If CheckBox16.Checked Then ScopeText &= "CPCtrl, "
        If CheckBox11.Checked Then ScopeText &= "CstmCoil, "
        If CheckBox12.Checked Then ScopeText &= "CstmCtrl, "
        If CheckBox15.Checked Then ScopeText &= "CstmHV, "
        If CheckBox13.Checked Then ScopeText &= "CstmRef, "
        If CheckBox14.Checked Then ScopeText &= "CstmSM, "
        If CheckBox39.Checked Then ScopeText &= "CustFilt, "
        If CheckBox17.Checked Then ScopeText &= "DesiHW, "
        If CheckBox19.Checked Then ScopeText &= "DFGas, "
        If CheckBox18.Checked Then ScopeText &= "DigScroll, "
        If CheckBox21.Checked Then ScopeText &= "DPatchDehum, "
        If CheckBox23.Checked Then ScopeText &= "DPP, "
        If CheckBox20.Checked Then ScopeText &= "DWall, "
        If CheckBox90.Checked Then ScopeText &= "DXCoil, "
        If CheckBox24.Checked Then ScopeText &= "Encl, "
        If CheckBox28.Checked Then ScopeText &= "ERVMod, "
        If CheckBox26.Checked Then ScopeText &= "ERW, "
        If CheckBox27.Checked Then ScopeText &= "ERWModule, "
        If CheckBox29.Checked Then ScopeText &= "EvapBP, "
        If CheckBox33.Checked Then ScopeText &= "Extend, "
        If CheckBox96.Checked Then ScopeText &= "FanStacks, "
        If CheckBox34.Checked Then ScopeText &= "FanWall, "
        If CheckBox91.Checked Then ScopeText &= "FBP, "
        If CheckBox36.Checked Then ScopeText &= "FFilt, "
        If CheckBox35.Checked Then ScopeText &= "FillStat, "
        If CheckBox41.Checked Then ScopeText &= "GHeat, "
        If CheckBox46.Checked Then ScopeText &= "GFHumid, "
        If CheckBox43.Checked Then ScopeText &= "HGBP, "
        If CheckBox44.Checked Then ScopeText &= "HGRH, "
        If CheckBox42.Checked Then ScopeText &= "HighStatic, "
        If CheckBox45.Checked Then ScopeText &= "HPConv, "
        If CheckBox87.Checked Then ScopeText &= "HWCoil, "
        If CheckBox73.Checked Then ScopeText &= "LCVAV, "
        If CheckBox49.Checked Then ScopeText &= "LowAF, "
        If CheckBox50.Checked Then ScopeText &= "LowAFSF, "
        If CheckBox51.Checked Then ScopeText &= "LowAmbient, "
        If CheckBox53.Checked Then ScopeText &= "MEHeat(I), "
        If CheckBox52.Checked Then ScopeText &= "MEHeat(R), "
        If CheckBox55.Checked Then ScopeText &= "MGH(H), "
        If CheckBox54.Checked Then ScopeText &= "MGH(R), "
        If CheckBox48.Checked Then ScopeText &= "MHGRH, "
        If CheckBox63.Checked Then ScopeText &= "Mon, "
        If CheckBox57.Checked Then ScopeText &= "MotorGM, "
        If CheckBox56.Checked Then ScopeText &= "MtrRR, "
        If CheckBox22.Checked Then ScopeText &= "MZ-DD, "
        If CheckBox58.Checked Then ScopeText &= "MZ-Mod, "
        If CheckBox62.Checked Then ScopeText &= "MZ-VAV, "
        If CheckBox59.Checked Then ScopeText &= "NatConv, "
        If CheckBox10.Checked Then ScopeText &= "NetPkg, "
        If CheckBox60.Checked Then ScopeText &= "OAFMS, "
        If CheckBox82.Checked Then ScopeText &= "OAHood, "
        If CheckBox85.Checked Then ScopeText &= "OALouver, "
        If CheckBox61.Checked Then ScopeText &= "OSMotor, "
        If CheckBox37.Checked Then ScopeText &= "PFilt, "
        If CheckBox65.Checked Then ScopeText &= "PipePkg, "
        If CheckBox25.Checked Then ScopeText &= "PlateHX, "
        If CheckBox94.Checked Then ScopeText &= "PLFrHX, "
        If CheckBox31.Checked Then ScopeText &= "PreEvap, "
        If CheckBox64.Checked Then ScopeText &= "PumpPkg, "
        If CheckBox80.Checked Then ScopeText &= "RFan, "
        If CheckBox67.Checked Then ScopeText &= "SCCR, "
        If CheckBox66.Checked Then ScopeText &= "ServLite, "
        If CheckBox81.Checked Then ScopeText &= "SFan, "
        If CheckBox68.Checked Then ScopeText &= "SparkRes, "
        If CheckBox69.Checked Then ScopeText &= "SSLube, "
        If CheckBox86.Checked Then ScopeText &= "SteamCoil, "
        If CheckBox47.Checked Then ScopeText &= "TOHumid, "
        If CheckBox70.Checked Then ScopeText &= "UVLights, "
        If CheckBox72.Checked Then ScopeText &= "VFD, "
        If CheckBox71.Checked Then ScopeText &= "VSComp, "
        If CheckBox75.Checked Then ScopeText &= "WCCond, "
        If CheckBox78.Checked Then ScopeText &= "WringGM, "
        If CheckBox9.Checked Then ScopeText &= "WSEcon, "
        If CheckBox76.Checked Then ScopeText &= "WSHPConv, "
        If CheckBox83.Checked Then ScopeText &= "XAHood, "
        If CheckBox84.Checked Then ScopeText &= "XALouver, "
        If CheckBox79.Checked Then ScopeText &= "XFan, "
        If CheckBox92.Checked Then ScopeText &= "Xfmr, "
        If CheckBox74.Checked Then ScopeText &= "XFVAV, "
        If CheckBox32.Checked Then ScopeText &= "XP, "

        Scope.Text = ScopeText

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SQLLine As String

        SQLLine = "UPDATE unit_master " &
        " SET Scope = @Scope" &
        " WHERE UnitID = @UnitID"

        Using cn As New MySqlConnection("server=192.168.1.122;" & "user id=delliott;" & "password=juice16#cliP;" & "database=forest;"),
              cmd As New MySqlCommand(SQLLine, cn)

            'Use actual column types/lengths from DB here
            cmd.Parameters.Add("@Scope", MySqlDbType.VarChar, 100).Value = Scope.Text
            cmd.Parameters.Add("@UnitID", MySqlDbType.VarChar, 8).Value = UnitID.Text

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        Me.Close()
        MessageBox.Show("Scope has been updated.")
        MasterRecord.TopMost = True

    End Sub

End Class