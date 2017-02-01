Imports System.Data.OleDb

Public Class frmInputBattingStats

    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim intSingles As Integer = Convert.ToInt32(cmbSingles.SelectedItem)
        Dim intDoubles As Integer = Convert.ToInt32(cmbDoubles.SelectedItem)
        Dim intTriples As Integer = Convert.ToInt32(cmbTriples.SelectedItem)
        Dim intHR As Integer = Convert.ToInt32(cmbHR.SelectedItem)
        Dim intRBI As Integer = Convert.ToInt32(cmbRBI.SelectedItem)
        Dim intRuns As Integer = Convert.ToInt32(cmbRuns.SelectedItem)
        Dim intGO As Integer = Convert.ToInt32(cmbGO.SelectedItem)
        Dim intFO As Integer = Convert.ToInt32(cmbFO.SelectedItem)
        Dim intK As Integer = Convert.ToInt32(cmbKs.SelectedItem)
        Dim intSH As Integer = Convert.ToInt32(cmbSHs.SelectedItem)
        Dim intSF As Integer = Convert.ToInt32(cmbSFs.SelectedItem)
        Dim intHBP As Integer = Convert.ToInt32(cmbHBP.SelectedItem)
        Dim intBB As Integer = Convert.ToInt32(cmbBB.SelectedItem)
        Dim intSB As Integer = Convert.ToInt32(cmbSB.SelectedItem)
        Dim intCS As Integer = Convert.ToInt32(cmbCS.SelectedItem)
        Dim intGIDP As Integer = Convert.ToInt32(cmbGIDP.SelectedItem)
        Dim chrGS As Char = Convert.ToChar(cmbStarted.SelectedItem)
        Dim strDate As String = dtpDate.Value.ToShortDateString
        Dim strTime As String = dupTime.SelectedItem
        Dim InsertQuery As String
        Dim SelectQuery As String
        SelectQuery = "SELECT * FROM BattingStats WHERE FirstName = @FirstName and LastName = @LastName and DatePlayed = @DatePlayed and Time = @Time"
        InsertQuery = "INSERT INTO BattingStats (FirstName,LastName,Singles,Doubles,Triples,Homeruns,RunsBattedIn,Runs,GroundOuts,FlyOuts,StrikeOuts,SacHits,SacFlys,HitByPitch,Walks,StolenBases,CaughtStealing,GroundedIntoDoublePlay,GameStarted,DatePlayed,Team,[Time]) VALUES(@FirstName,@LastName,@Singles,@Doubles,@Triples,@Homeruns,@RunsBattedIn,@Runs,@GroundOuts,@FlyOuts,@StrikeOuts,@SacHits,@SacFlys,@HitByPitch,@Walks,@StolenBases,@CaughtStealing,@GroundedIntoDoublePlay,@GameStarted,@DatePlayed,@Team,@Time)"
        Dim retval As Integer
        retval = MsgBox("Are you sure? These stats cannot be changed once inputed.", vbYesNo, "Warning")
        'yes = 6, no = 7
        If retval = 6 Then
            cnnOLEDB.Open()
            Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
            cmdSelect.Parameters.AddWithValue("@FirstName", playerFirstName)
            cmdSelect.Parameters.AddWithValue("@LastName", playerLastName)
            cmdSelect.Parameters.AddWithValue("@DatePlayed", strDate)
            cmdSelect.Parameters.AddWithValue("@Time", strTime)
            Dim dbRead As OleDbDataReader = cmdSelect.ExecuteReader
            If dbRead.HasRows() Then
                MsgBox("This player's stats for this day and time have already been added.", MsgBoxStyle.OkOnly, "Already Added")
                dtpDate.Value = Today
                cnnOLEDB.Close()
            Else
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
                cmd.Parameters.AddWithValue("@FirstName", playerFirstName)
                cmd.Parameters.AddWithValue("@LastName", playerLastName)
                cmd.Parameters.AddWithValue("@Singles", intSingles)
                cmd.Parameters.AddWithValue("@Doubles", intDoubles)
                cmd.Parameters.AddWithValue("@Triples", intTriples)
                cmd.Parameters.AddWithValue("@Homeruns", intHR)
                cmd.Parameters.AddWithValue("@RunsBattedIn", intRBI)
                cmd.Parameters.AddWithValue("@Runs", intRuns)
                cmd.Parameters.AddWithValue("@GroundOuts", intGO)
                cmd.Parameters.AddWithValue("@FlyOuts", intFO)
                cmd.Parameters.AddWithValue("@StrikeOuts", intK)
                cmd.Parameters.AddWithValue("@SacHits", intSH)
                cmd.Parameters.AddWithValue("@SacFlys", intSF)
                cmd.Parameters.AddWithValue("@HitByPitch", intHBP)
                cmd.Parameters.AddWithValue("@Walks", intBB)
                cmd.Parameters.AddWithValue("@StolenBases", intSB)
                cmd.Parameters.AddWithValue("@CaughtStealing", intCS)
                cmd.Parameters.AddWithValue("@GroundedIntoDoublePlay", intGIDP)
                If chrGS = "Y" Then
                    cmd.Parameters.AddWithValue("@GameStarted", 1)
                Else
                    cmd.Parameters.AddWithValue("@GameStarted", 0)
                End If
                cmd.Parameters.AddWithValue("@DatePlayed", strDate)
                cmd.Parameters.AddWithValue("@Team", team)
                cmd.Parameters.AddWithValue("@Time", strTime)
                cmd.ExecuteNonQuery()
                MsgBox("Stats have been saved.", MsgBoxStyle.OkOnly, "Saved")
                playerName = Nothing
                playerFirstName = Nothing
                playerLastName = Nothing
                frmAddGameStats.Show()
                Me.Close()
                cnnOLEDB.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmAddGameStats.Show()
        Me.Close()
        playerName = Nothing
        playerFirstName = Nothing
        playerLastName = Nothing
    End Sub

    Private Sub frmInputBattingStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblPlayer.Text = playerFirstName & " " & playerLastName & " - " & team
        cmbStarted.SelectedIndex = 1
        cmbSingles.SelectedIndex = 0
        cmbDoubles.SelectedIndex = 0
        cmbTriples.SelectedIndex = 0
        cmbHR.SelectedIndex = 0
        cmbRBI.SelectedIndex = 0
        cmbRuns.SelectedIndex = 0
        cmbGO.SelectedIndex = 0
        cmbFO.SelectedIndex = 0
        cmbKs.SelectedIndex = 0
        cmbSHs.SelectedIndex = 0
        cmbSFs.SelectedIndex = 0
        cmbHBP.SelectedIndex = 0
        cmbBB.SelectedIndex = 0
        cmbSB.SelectedIndex = 0
        cmbCS.SelectedIndex = 0
        cmbGIDP.SelectedIndex = 0
        dupTime.SelectedItem = "12:00 PM"
    End Sub
End Class