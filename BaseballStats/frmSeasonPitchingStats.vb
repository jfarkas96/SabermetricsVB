Public Class frmSeasonPitchingStats
    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub frmSeasonPitchingStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaseballProgramDataSet.SeasonPitchingStatsCalc' table. You can move, or remove it, as needed.
        Me.SeasonPitchingStatsCalcTableAdapter.FillByTeam(Me.BaseballProgramDataSet.SeasonPitchingStatsCalc, team)
    End Sub
End Class