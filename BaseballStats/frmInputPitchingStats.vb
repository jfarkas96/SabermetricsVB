Imports System.Data.OleDb

Public Class frmInputPitchingStats
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim chrWin As Char = Convert.ToChar(cmbWin.SelectedItem)
        Dim chrLoss As Char = Convert.ToChar(cmbLoss.SelectedItem)
        Dim chrStarted As Char = Convert.ToChar(cmbStarted.SelectedItem)
        Dim intIP As Integer = Convert.ToInt32(cmbIP.SelectedItem)
        Dim intHits As Integer = Convert.ToInt32(cmbHits.SelectedItem)
        Dim intAB As Integer = Convert.ToInt32(cmbAB.SelectedItem)
        Dim intBB As Integer = Convert.ToInt32(cmbBB.SelectedItem)
        Dim intHBP As Integer = Convert.ToInt32(cmbHBP.SelectedItem)
        Dim intRuns As Integer = Convert.ToInt32(cmbRuns.SelectedItem)
        Dim intER As Integer = Convert.ToInt32(cmbER.SelectedItem)
        Dim intK As Integer = Convert.ToInt32(cmbK.SelectedItem)
        Dim chrCG As Char = Convert.ToChar(cmbCG.SelectedItem)
        Dim chrSHO As Char = Convert.ToChar(cmbSHO.SelectedItem)
        Dim intTP As Integer = Convert.ToInt32(cmbTP.SelectedItem)
        Dim chrSave As Char = Convert.ToChar(cmbSave.SelectedItem)
        Dim chrBS As Char = Convert.ToChar(cmbBS.SelectedItem)
        Dim strDate As String = dtpGame.Value.ToShortDateString
        Dim InsertQuery As String
        Dim SelectQuery As String
        SelectQuery = "SELECT * FROM PitchingStats WHERE FirstName = @FirstName and LastName = @LastName and DatePlayed = @DatePlayed"
        InsertQuery = "INSERT INTO PitchingStats (FirstName,LastName,Win,Loss,GameStarted,InningsPitched,Hits,AtBats,Walks,HitByPitch,Runs,EarnedRuns,Strikeouts,CompleteGame,Shutout,TotalPitches,Save,BlownSave,DatePlayed,Team) VALUES(@FirstName,@LastName,@Win,@Loss,@GameStarted,@InningsPitched,@Hits,@AtBats,@Walks,@HitByPitch,@Runs,@EarnedRuns,@Strikeouts,@CompleteGame,@Shutout,@TotalPitches,@Save,@BlownSave,@DatePlayed,@Team)"
        Dim retval As Integer
        retval = MsgBox("Are you sure? These stats cannot be changed once inputed.", vbYesNo, "Warning")
        'yes = 6, no = 7
        If retval = 6 Then
            cnnOLEDB.Open()
            Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
            cmdSelect.Parameters.AddWithValue("@FirstName", playerFirstName)
            cmdSelect.Parameters.AddWithValue("@LastName", playerLastName)
            cmdSelect.Parameters.AddWithValue("@DatePlayed", strDate)
            Dim dbRead As OleDbDataReader = cmdSelect.ExecuteReader
            If dbRead.HasRows() Then
                MsgBox("This player's stats for this day have already been added.", MsgBoxStyle.OkOnly, "Already Added")
                dtpGame.Value = Today
                cnnOLEDB.Close()
            Else
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
                cmd.Parameters.AddWithValue("@FirstName", playerFirstName)
                cmd.Parameters.AddWithValue("@LastName", playerLastName)
                If chrWin = "Y" Then
                    cmd.Parameters.AddWithValue("@Win", 1)
                Else
                    cmd.Parameters.AddWithValue("@Win", 0)
                End If
                If chrLoss = "Y" Then
                    cmd.Parameters.AddWithValue("@Loss", 1)
                Else
                    cmd.Parameters.AddWithValue("@Loss", 0)
                End If
                If chrStarted = "Y" Then
                    cmd.Parameters.AddWithValue("@GameStarted", 1)
                Else
                    cmd.Parameters.AddWithValue("@GameStarted", 0)
                End If
                cmd.Parameters.AddWithValue("@InningsPitched", intIP)
                cmd.Parameters.AddWithValue("@Hits", intHits)
                cmd.Parameters.AddWithValue("@AtBats", intAB)
                cmd.Parameters.AddWithValue("@Walks", intBB)
                cmd.Parameters.AddWithValue("@HitByPitch", intHBP)
                cmd.Parameters.AddWithValue("@Runs", intRuns)
                cmd.Parameters.AddWithValue("@EarnedRuns", intER)
                cmd.Parameters.AddWithValue("@Strikeouts", intK)
                If chrCG = "Y" Then
                    cmd.Parameters.AddWithValue("@CompleteGame", 1)
                Else
                    cmd.Parameters.AddWithValue("@CompleteGame", 0)
                End If
                If chrSHO = "Y" Then
                    cmd.Parameters.AddWithValue("@Shutout", 1)
                Else
                    cmd.Parameters.AddWithValue("@Shutout", 0)
                End If
                cmd.Parameters.AddWithValue("@TotalPitches", intTP)
                If chrSave = "Y" Then
                    cmd.Parameters.AddWithValue("@Save", 1)
                Else
                    cmd.Parameters.AddWithValue("@Save", 0)
                End If
                If chrBS = "Y" Then
                    cmd.Parameters.AddWithValue("@BlownSave", 1)
                Else
                    cmd.Parameters.AddWithValue("@BlownSave", 0)
                End If
                cmd.Parameters.AddWithValue("@DatePlayed", strDate)
                cmd.Parameters.AddWithValue("@Team", team)
                cmd.ExecuteNonQuery()
                MsgBox("Stats have been saved.", MsgBoxStyle.OkOnly, "Saved")
                playerName = Nothing
                playerFirstName = Nothing
                playerLastName = Nothing
                frmAddGameStats.Show()
                Me.Close()
            End If
            cnnOLEDB.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmAddGameStats.Show()
        Me.Close()
        playerName = Nothing
        playerFirstName = Nothing
        playerLastName = Nothing
    End Sub

    Private Sub frmInputPitchingStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblPlayer.Text = playerFirstName & " " & playerLastName & " - " & team
        cmbStarted.SelectedIndex = 1
        cmbWin.SelectedIndex = 1
        cmbLoss.SelectedIndex = 1
        cmbHits.SelectedIndex = 0
        cmbAB.SelectedIndex = 0
        cmbBB.SelectedIndex = 0
        cmbHBP.SelectedIndex = 0
        cmbRuns.SelectedIndex = 0
        cmbER.SelectedIndex = 0
        cmbK.SelectedIndex = 0
        cmbCG.SelectedIndex = 1
        cmbSHO.SelectedIndex = 1
        cmbTP.SelectedIndex = 0
        cmbSave.SelectedIndex = 1
        cmbBS.SelectedIndex = 1
        cmbIP.SelectedIndex = 0
    End Sub
End Class