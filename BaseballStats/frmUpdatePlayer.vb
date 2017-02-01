Imports System.Data.OleDb

Public Class frmUpdatePlayer
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")

    Private Sub frmUpdatePlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirstName.Text = playerFirstName
        txtLastName.Text = playerLastName
        cmbNumber.SelectedItem = playerNumber.ToString
        cmbBats.SelectedItem = playerBats.ToString
        cmbThrows.SelectedItem = playerThrows.ToString
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        playerBats = Nothing
        playerThrows = Nothing
        playerFirstName = Nothing
        playerLastName = Nothing
        playerNumber = Nothing
        frmEditRoster.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim intNumber As Integer = Convert.ToInt32(cmbNumber.SelectedItem)
        Dim chrBats As Char = Convert.ToChar(cmbBats.SelectedItem)
        Dim chrThrows As Char = Convert.ToChar(cmbThrows.SelectedItem)
        Dim retval As Integer = MsgBox("Are you sure you'd like to make these changes?", vbYesNo, "Warning")
        'yes = 6, no = 7 
        If retval = 6 Then
            cnnOLEDB.Open()
            Dim SelectQuery As String = "SELECT * FROM Roster WHERE FirstName = @FirstName and LastName = @LastName and Team = @Team"
            Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
            cmdSelect.Parameters.AddWithValue("@FirstName", strFirstName)
            cmdSelect.Parameters.AddWithValue("@LastName", strLastName)
            cmdSelect.Parameters.AddWithValue("@Team", team)
            Dim dbRead As OleDbDataReader = cmdSelect.ExecuteReader

            If dbRead.HasRows() Then
                MsgBox("This player already exists")
                txtFirstName.Text = playerFirstName
                txtLastName.Text = playerLastName
                cmbNumber.SelectedItem = playerNumber.ToString
                cmbBats.SelectedItem = playerBats.ToString
                cmbThrows.SelectedItem = playerThrows.ToString
            Else
                Dim updatePlayerQuery As String = "UPDATE Roster SET FirstName = @FirstName, LastName = @LastName, [Number] = @Number, Bats = @Bats, Throws = @Throws WHERE ID = @ID"
                Dim cmdUpdatePlayer As OleDbCommand = New OleDbCommand(updatePlayerQuery, cnnOLEDB)
                cmdUpdatePlayer.Parameters.AddWithValue("@FirstName", strFirstName.Trim)
                cmdUpdatePlayer.Parameters.AddWithValue("@LastName", strLastName.Trim)
                cmdUpdatePlayer.Parameters.AddWithValue("@Number", intNumber)
                cmdUpdatePlayer.Parameters.AddWithValue("@Throws", chrThrows)
                cmdUpdatePlayer.Parameters.AddWithValue("@Bats", chrBats)
                cmdUpdatePlayer.Parameters.AddWithValue("@ID", playerId)
                cmdUpdatePlayer.ExecuteNonQuery()
                If strFirstName <> playerFirstName Or strLastName <> playerLastName Then
                    Dim updateBattingStatsQuery As String = "UPDATE BattingStats SET FirstName=@FirstName, LastName=@LastName WHERE FirstName=@OldFirstName AND LastName=@OldLastName"
                    Dim cmdUpdateBattingStats As OleDbCommand = New OleDbCommand(updateBattingStatsQuery, cnnOLEDB)
                    Dim updatePitchingStatsQuery As String = "UPDATE PitchingStats SET Firstname=@FirstName, LastName=@LastName WHERE FirstName=@OldFirstName AND Lastname=@OldLastName"
                    Dim cmdUpdatePitchingStats As OleDbCommand = New OleDbCommand(updatePitchingStatsQuery, cnnOLEDB)
                    cmdUpdateBattingStats.Parameters.AddWithValue("@FirstName", strFirstName.Trim)
                    cmdUpdateBattingStats.Parameters.AddWithValue("@LastName", strLastName.Trim)
                    cmdUpdateBattingStats.Parameters.AddWithValue("@OldFirstName", playerFirstName)
                    cmdUpdateBattingStats.Parameters.AddWithValue("@OldLastName", playerLastName)
                    cmdUpdatePitchingStats.Parameters.AddWithValue("@FirstName", strFirstName.Trim)
                    cmdUpdatePitchingStats.Parameters.AddWithValue("@LastName", strLastName.Trim)
                    cmdUpdatePitchingStats.Parameters.AddWithValue("@OldFirstName", playerFirstName)
                    cmdUpdatePitchingStats.Parameters.AddWithValue("@OldLastName", playerLastName)
                    cmdUpdateBattingStats.ExecuteNonQuery()
                    cmdUpdatePitchingStats.ExecuteNonQuery()
                End If
            End If
            cnnOLEDB.Close()
            frmEditRoster.Show()
            Me.Close()
        End If
    End Sub
End Class