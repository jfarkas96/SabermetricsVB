Imports System.Data.OleDb

Public Class frmEditRoster
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")
    'arRoster is an array that keeps the ID values of all the players being read in from the roster DB
    Dim arRoster As Double()

    Private Sub btnAddPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlayer.Click
        frmAddPlayer.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub frmEditRoster_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblRoster.Text = "Roster - " & team

        Me.RefreshTable()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        cnnOLEDB.Open()
        Dim RowNum As Integer = lstRoster.SelectedIndex
        If RowNum = -1 Then
            MsgBox("Please select the player you wish to delete.")
            cnnOLEDB.Close()
        Else
            Dim retval As Integer = MsgBox("Are you sure? This will permanently delete the player and all stats recorded for the player.", MsgBoxStyle.YesNo, "Warning")
            If retval = 6 Then
                'Gets ID of player in roster
                Dim ID As Integer = arRoster(RowNum)
                'Gets the first and last name of the player
                Dim SelectPlayerQuery As String = "SELECT FirstName, LastName FROM Roster WHERE ID = @ID"
                Dim cmdSelectPlayer As OleDbCommand = New OleDbCommand(SelectPlayerQuery, cnnOLEDB)
                cmdSelectPlayer.Parameters.AddWithValue("@ID", ID)
                Dim dbRead As OleDbDataReader = cmdSelectPlayer.ExecuteReader
                dbRead.Read()
                Dim strFirstName As String = dbRead(0).ToString
                Dim strLastName As String = dbRead(1).ToString
                dbRead.Close()

                'Deletes all batting and pitching stats from that player
                Dim deleteBattingStatsQuery As String = "DELETE FROM BattingStats WHERE FirstName = @FirstName AND LastName = @LastName"
                Dim cmdDeleteBattingStats As OleDbCommand = New OleDbCommand(deleteBattingStatsQuery, cnnOLEDB)
                Dim deletePitchingStatsQuery As String = "DELETE FROM PitchingStats WHERE FirstName = @FirstName AND LastName = @LastName"
                Dim cmdDeletePitchingStats As OleDbCommand = New OleDbCommand(deletePitchingStatsQuery, cnnOLEDB)
                cmdDeleteBattingStats.Parameters.AddWithValue("@FirstName", strFirstName)
                cmdDeleteBattingStats.Parameters.AddWithValue("@LastName", strLastName)
                cmdDeletePitchingStats.Parameters.AddWithValue("@FirstName", strFirstName)
                cmdDeletePitchingStats.Parameters.AddWithValue("@LastName", strLastName)
                cmdDeleteBattingStats.ExecuteNonQuery()
                cmdDeletePitchingStats.ExecuteNonQuery()

                'Deletes the player from the roster
                Dim DeleteCommand As String = "Delete from Roster WHERE ID = @ID"
                Dim cmdDelete As OleDbCommand = New OleDbCommand(DeleteCommand, cnnOLEDB)
                cmdDelete.Parameters.AddWithValue("@ID", ID)
                cmdDelete.ExecuteNonQuery()
            End If
            cnnOLEDB.Close()
        End If
        Me.RefreshTable()
    End Sub

    Private Sub frmEditRoster_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.RefreshTable()
    End Sub

    Private Sub RefreshTable()
        cnnOLEDB.Open()
        Dim SelectQuery As String = "Select * From Roster WHERE Team = '" & team & "' ORDER BY VAL([Number])"
        Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
        Dim totalRows As Long = CInt(cmdSelect.ExecuteScalar())
        ReDim arRoster(totalRows)
        Dim reader As OleDbDataReader = cmdSelect.ExecuteReader
        Dim i As Integer = 0
        lstRoster.Items.Clear()
        While reader.Read()
            lstRoster.Items.Add("#" + reader(3).ToString() + " - " + reader(1).ToString() + " " + reader(2).ToString() + " Throws: " + reader(4).ToString() + " Bats: " + reader(5).ToString())
            arRoster(i) = reader(0)
            i = i + 1
        End While
        reader.Close()
        cnnOLEDB.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cnnOLEDB.Open()
        Dim RowNum As Integer = lstRoster.SelectedIndex
        If RowNum = -1 Then
            MsgBox("Please select the player you wish to update")
            cnnOLEDB.Close()
        Else
            Dim id As Integer = arRoster(RowNum)
            Dim SelectCommand As String = "Select * from Roster WHERE ID = @ID"
            Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectCommand, cnnOLEDB)
            cmdSelect.Parameters.AddWithValue("@ID", id)
            Dim reader As OleDbDataReader = cmdSelect.ExecuteReader
            While reader.Read()
                playerId = reader(0)
                playerFirstName = reader(1).ToString()
                playerLastName = reader(2).ToString()
                playerNumber = reader(3)
                playerThrows = reader(4).ToString()
                playerBats = reader(5).ToString()
            End While
            frmUpdatePlayer.Show()
            Me.Close()
        End If
    End Sub
End Class