Imports System.Data.OleDb

Public Class frmLogIn
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\BaseballProgram.accdb")
    Dim cmdSelectUsername As New OleDbCommand
    Dim cmdSelectPassword As New OleDbCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim selectUsernameQuery As String = "Select * FROM [Login] WHERE Username = @Username"
        Dim selectUserAndPassQuery As String = "Select * FROM [Login] WHERE Username = @Username AND Password = @Password"
        Dim selectTeamQuery As String = "Select Team FROM [Login] WHERE Username = @Username AND Password = @Password"
        cnnOLEDB.Open()

        Dim cmdSelectUsername As OleDbCommand = New OleDbCommand(selectUsernameQuery, cnnOLEDB)
        cmdSelectUsername.Parameters.AddWithValue("@Username", strUsername)
        Dim dbRead1 As OleDbDataReader = cmdSelectUsername.ExecuteReader
        If dbRead1.HasRows Then
            Dim cmdSelectUserAndPass As OleDbCommand = New OleDbCommand(selectUserAndPassQuery, cnnOLEDB)
            cmdSelectUserAndPass.Parameters.AddWithValue("@Username", strUsername)
            cmdSelectUserAndPass.Parameters.AddWithValue("@Password", strPassword)
            Dim dbRead2 As OleDbDataReader = cmdSelectUserAndPass.ExecuteReader

            If dbRead2.HasRows Then
                Dim cmdSelectTeam As OleDbCommand = New OleDbCommand(selectTeamQuery, cnnOLEDB)
                cmdSelectTeam.Parameters.AddWithValue("@Username", strUsername)
                cmdSelectTeam.Parameters.AddWithValue("@Password", strPassword)
                Dim dbRead3 As OleDbDataReader = cmdSelectTeam.ExecuteReader

                While (dbRead3.Read)
                    team = dbRead3.GetString(0)
                End While
                dbRead3.Close()
                dbRead2.Close()
                cnnOLEDB.Close()
                frmHome.Show()
                Me.Close()
            Else
                MsgBox("Password incorrect")
                txtPassword.Clear()
                dbRead2.Close()
            End If
            dbRead1.Close()
        Else
            MsgBox("This username does not exist")
            txtPassword.Clear()
            txtUsername.Clear()
            dbRead1.Close()
        End If
        cnnOLEDB.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateAccount.show()
        Me.Close()
    End Sub
End Class
