Imports System.Data.OleDb


Public Class frmAddGameStats

    'cnnOLEDB creates a connection to a MS Access DB with the rosters and game data
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")

    Private Sub frmAddGameStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Select Query is a query for the DB that grabs all of the players in "Roster and orders them
        Dim SelectQuery As String = "Select * From Roster WHERE Team = '" & team & "' ORDER BY LastName,FirstName"

        'Opens DB connection
        cnnOLEDB.Open()

        'Creates OleDbCommand with the select query then makes a DataReader from it by calling ExecuteReader
        Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
        Dim reader As OleDbDataReader = cmdSelect.ExecuteReader

        'Clears list then adds the roster into the list via the DataReader
        lstPlayers.Items.Clear()
        While reader.Read()
            lstPlayers.Items.Add(reader(1).ToString() + " " + reader(2).ToString())
        End While

        'Closese the reader and the DB connection and sets starting index of the list to 0
        reader.Close()
        cnnOLEDB.Close()
        If lstPlayers.Items.Count <> 0 Then
            lstPlayers.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAddBat_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBat.Click
        If lstPlayers.SelectedIndex = -1 Then
            MsgBox("You need to have players to add stats!")
        Else
            'TODO fix this stuff that tries to break up names for next form. Doesn't work with people who have
            'hypenated names or middle initials/names
            playerName = Convert.ToString(lstPlayers.SelectedItem)
            playerFirstName = playerName.Substring(0, playerName.LastIndexOf(" "))
            playerLastName = playerName.Substring(playerName.LastIndexOf(" ") + 1, playerName.Length - playerName.LastIndexOf(" ") - 1)
            Dim frmBatStats As New frmInputBattingStats
            frmBatStats.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAddPitch_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPitch.Click
        If lstPlayers.SelectedIndex = -1 Then
            MsgBox("You need to have players to add stats!")
        Else
            'TODO fix this stuff that tries to break up names for next form. Doesn't work with people who have
            'hypenated names or middle initials/names
            playerName = Convert.ToString(lstPlayers.SelectedItem)
            playerFirstName = playerName.Substring(0, playerName.IndexOf(" "))
            playerLastName = playerName.Substring(playerName.LastIndexOf(" ") + 1, playerName.Length - playerName.LastIndexOf(" ") - 1)
            team = playerName.Substring(playerName.IndexOf("-") + 1)
            frmInputPitchingStats.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmHome.Show()
        Me.Close()
    End Sub
End Class