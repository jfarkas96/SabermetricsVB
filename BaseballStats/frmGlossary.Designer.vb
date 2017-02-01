<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGlossaryOfAbbreviations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlossaryOfAbbreviations))
        Me.lblBattingStatisticsAbbreviations = New System.Windows.Forms.Label()
        Me.lblBattingStatistics = New System.Windows.Forms.Label()
        Me.lblPitchingStatisticsAbbreviations = New System.Windows.Forms.Label()
        Me.lblPitchingStatistics = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBattingStatisticsAbbreviations
        '
        Me.lblBattingStatisticsAbbreviations.AutoSize = True
        Me.lblBattingStatisticsAbbreviations.BackColor = System.Drawing.Color.Transparent
        Me.lblBattingStatisticsAbbreviations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBattingStatisticsAbbreviations.ForeColor = System.Drawing.Color.BurlyWood
        Me.lblBattingStatisticsAbbreviations.Location = New System.Drawing.Point(12, 12)
        Me.lblBattingStatisticsAbbreviations.Name = "lblBattingStatisticsAbbreviations"
        Me.lblBattingStatisticsAbbreviations.Size = New System.Drawing.Size(246, 18)
        Me.lblBattingStatisticsAbbreviations.TabIndex = 1
        Me.lblBattingStatisticsAbbreviations.Text = "Batting Statistics Abbreviations:"
        '
        'lblBattingStatistics
        '
        Me.lblBattingStatistics.AutoSize = True
        Me.lblBattingStatistics.BackColor = System.Drawing.Color.Transparent
        Me.lblBattingStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBattingStatistics.ForeColor = System.Drawing.Color.White
        Me.lblBattingStatistics.Location = New System.Drawing.Point(12, 30)
        Me.lblBattingStatistics.Name = "lblBattingStatistics"
        Me.lblBattingStatistics.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lblBattingStatistics.Size = New System.Drawing.Size(378, 726)
        Me.lblBattingStatistics.TabIndex = 2
        Me.lblBattingStatistics.Text = resources.GetString("lblBattingStatistics.Text")
        '
        'lblPitchingStatisticsAbbreviations
        '
        Me.lblPitchingStatisticsAbbreviations.AutoSize = True
        Me.lblPitchingStatisticsAbbreviations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchingStatisticsAbbreviations.ForeColor = System.Drawing.Color.BurlyWood
        Me.lblPitchingStatisticsAbbreviations.Location = New System.Drawing.Point(12, 744)
        Me.lblPitchingStatisticsAbbreviations.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.lblPitchingStatisticsAbbreviations.Name = "lblPitchingStatisticsAbbreviations"
        Me.lblPitchingStatisticsAbbreviations.Size = New System.Drawing.Size(254, 18)
        Me.lblPitchingStatisticsAbbreviations.TabIndex = 3
        Me.lblPitchingStatisticsAbbreviations.Text = "Pitching Statistics Abbreviations:"
        '
        'lblPitchingStatistics
        '
        Me.lblPitchingStatistics.AutoSize = True
        Me.lblPitchingStatistics.BackColor = System.Drawing.Color.Transparent
        Me.lblPitchingStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchingStatistics.ForeColor = System.Drawing.Color.White
        Me.lblPitchingStatistics.Location = New System.Drawing.Point(12, 764)
        Me.lblPitchingStatistics.Name = "lblPitchingStatistics"
        Me.lblPitchingStatistics.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lblPitchingStatistics.Size = New System.Drawing.Size(351, 614)
        Me.lblPitchingStatistics.TabIndex = 4
        Me.lblPitchingStatistics.Text = resources.GetString("lblPitchingStatistics.Text")
        '
        'frmGlossaryOfAbbreviations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(392, 345)
        Me.Controls.Add(Me.lblPitchingStatistics)
        Me.Controls.Add(Me.lblPitchingStatisticsAbbreviations)
        Me.Controls.Add(Me.lblBattingStatistics)
        Me.Controls.Add(Me.lblBattingStatisticsAbbreviations)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGlossaryOfAbbreviations"
        Me.Text = "Glossary of Abbreviations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBattingStatisticsAbbreviations As System.Windows.Forms.Label
    Friend WithEvents lblBattingStatistics As System.Windows.Forms.Label
    Friend WithEvents lblPitchingStatisticsAbbreviations As System.Windows.Forms.Label
    Friend WithEvents lblPitchingStatistics As System.Windows.Forms.Label
End Class
