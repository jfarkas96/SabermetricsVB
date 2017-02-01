Public Class frmSeasonBattingStats
    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub frmSeasonBattingStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaseballProgramDataSet1.BattingStats' table. You can move, or remove it, as needed.
        Me.SeasonBattingStatsCalcTableAdapter.FillByTeam(Me.BaseballProgramDataSet.SeasonBattingStatsCalc, team)
    End Sub
End Class