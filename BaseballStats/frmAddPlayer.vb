Imports System.Data.OleDb

Public Class frmAddPlayer

    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdSelect As New OleDbCommand
    Dim cmdDelete As New OleDbCommand

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmEditRoster.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Then
            MsgBox("You need to fill out all of the fields")
        Else
            Dim strFirstName As String = txtFirstName.Text.Trim
            Dim strLastName As String = txtLastName.Text.Trim
            Dim intNumber As Integer = Convert.ToInt32(cmbNumber.SelectedItem)
            Dim chrBats As Char = Convert.ToChar(cmbBats.SelectedItem)
            Dim chrThrows As Char = Convert.ToChar(cmbThrows.SelectedItem)
            'Creates queries for inserting player into roster and one for selecting a player with a first and last
            'name that is the same as the one trying to be entered
            Dim InsertQuery As String = "INSERT INTO Roster(FirstName,LastName,[Number],Bats,Throws,Team) VALUES(@FirstName,@LastName,@Number,@Bats,@Throws,@Team)"
            Dim SelectQuery As String = "SELECT * FROM Roster WHERE FirstName = @FirstName and LastName = @LastName and Team = @Team"
            cnnOLEDB.Open()

            'Goes into the roster with the select query and tries to see if the player is already there
            Dim cmdSelect As OleDbCommand = New OleDbCommand(SelectQuery, cnnOLEDB)
            cmdSelect.Parameters.AddWithValue("@FirstName", strFirstName)
            cmdSelect.Parameters.AddWithValue("@LastName", strLastName)
            cmdSelect.Parameters.AddWithValue("@Team", team)
            Dim dbRead As OleDbDataReader = cmdSelect.ExecuteReader

            'If the player is there then dbRead will have rows and a message box will pop up and the form will reset
            'If not then the players information is added into the roster with the insert query
            If dbRead.HasRows() Then
                MsgBox("This player has already been added")
                txtFirstName.Text = Nothing
                txtLastName.Text = Nothing
                cmbNumber.SelectedItem = Nothing
                cmbBats.SelectedItem = Nothing
                cmbThrows.SelectedItem = Nothing
            Else
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)
                cmd.Parameters.AddWithValue("@FirstName", strFirstName.Trim)
                cmd.Parameters.AddWithValue("@LastName", strLastName.Trim)
                cmd.Parameters.AddWithValue("@Number", intNumber)
                cmd.Parameters.AddWithValue("@Bats", chrBats)
                cmd.Parameters.AddWithValue("@Throws", chrThrows)
                cmd.Parameters.AddWithValue("@Team", team)
                cmd.ExecuteNonQuery()
                frmEditRoster.Show()
                Me.Close()
            End If
            cnnOLEDB.Close()
        End If
    End Sub
End Class