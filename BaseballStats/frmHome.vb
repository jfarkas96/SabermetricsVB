Public Class frmHome

    Private Sub btnEditRoster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoster.Click
        frmEditRoster.Show()
        Me.Close()
    End Sub

    Private Sub btnGlossaryOfAbbreviations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlossaryOfAbbreviations.Click
        frmGlossaryOfAbbreviations.Show()
    End Sub

    Private Sub btnFormulasForsStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulasForsStatistics.Click
        frmFormulasForStatistics.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmLogIn.Show()
        Me.Close()
    End Sub

    Private Sub btnAddGameStats_Click(sender As System.Object, e As System.EventArgs) Handles btnAddGameStats.Click
        frmAddGameStats.Show()
        Me.Close()
    End Sub

    Private Sub btnStatisticsExplained_Click(sender As System.Object, e As System.EventArgs) Handles btnStatisticsExplained.Click
        frmStatsExplained.Show()
    End Sub

    Private Sub btnSeasonBattingStats_Click(sender As System.Object, e As System.EventArgs) Handles btnSeasonBattingStats.Click
        frmSeasonBattingStats.Show()
        Me.Close()
    End Sub

    Private Sub btnSeasonPitchingStats_Click(sender As System.Object, e As System.EventArgs) Handles btnSeasonPitchingStats.Click
        frmSeasonPitchingStats.Show()
        Me.Close()
    End Sub
End Class