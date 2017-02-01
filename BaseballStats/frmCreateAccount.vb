Imports System.Data.OleDb

Public Class frmCreateAccount
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BaseballProgram.accdb")
    Dim cmdSelectUsername As New OleDbCommand
    Dim cmdCreateAcc As New OleDbCommand

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        If (txtPassConfirm.Text = Nothing Or txtPassword.Text = Nothing Or txtUsername.Text = Nothing Or txtTeam.Text = Nothing) Then
            MsgBox("Please fill out all fields")
        ElseIf (txtPassword.Text <> txtPassConfirm.Text) Then
            MsgBox("The passwords entered do not match")
            txtPassConfirm.Clear()
            txtPassword.Clear()
        Else
            Dim strUsername As String = txtUsername.Text
            Dim strPassword As String = txtPassword.Text
            Dim strTeam As String = txtTeam.Text
            Dim selectUsernameQuery As String = "Select * FROM [Login] WHERE Username = @Username"
            cnnOLEDB.Open()

            Dim cmdSelectUsername As OleDbCommand = New OleDbCommand(selectUsernameQuery, cnnOLEDB)
            cmdSelectUsername.Parameters.AddWithValue("@Username", strUsername)
            Dim dbRead1 As OleDbDataReader = cmdSelectUsername.ExecuteReader
            If dbRead1.HasRows Then
                MsgBox("This username already exists")
                txtPassConfirm.Clear()
                txtPassword.Clear()
                txtUsername.Clear()
                txtTeam.Clear()
            Else
                Dim createAccQuery As String = "Insert INTO [Login] (Username, [Password], Team) VALUES (@Username, @Password, @Team)"
                Dim retval As Integer = MsgBox("Are you sure? This account cannot be changed once created.", vbYesNo, "Warning")
                'yes = 6, no = 7 
                If retval = 6 Then
                    Dim cmdCreateAcc As OleDbCommand = New OleDbCommand(createAccQuery, cnnOLEDB)
                    cmdCreateAcc.Parameters.AddWithValue("@Username", strUsername)
                    cmdCreateAcc.Parameters.AddWithValue("@Password", strPassword)
                    cmdCreateAcc.Parameters.AddWithValue("@Team", strTeam)
                    cmdCreateAcc.ExecuteNonQuery()
                    MsgBox("Account created.")
                    cnnOLEDB.Close()
                    frmLogIn.Show()
                    Me.Close()
                End If
            End If
            cnnOLEDB.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmLogIn.Show()
        Me.Close()
    End Sub
End Class