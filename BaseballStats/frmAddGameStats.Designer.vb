<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddGameStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddGameStats))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.btnAddPitch = New System.Windows.Forms.Button()
        Me.btnAddBat = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(159, 18)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Add new game stats"
        '
        'lstPlayers
        '
        Me.lstPlayers.BackColor = System.Drawing.Color.Green
        Me.lstPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayers.ForeColor = System.Drawing.Color.White
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.ItemHeight = 15
        Me.lstPlayers.Location = New System.Drawing.Point(12, 37)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(243, 109)
        Me.lstPlayers.TabIndex = 1
        '
        'btnAddPitch
        '
        Me.btnAddPitch.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAddPitch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPitch.Location = New System.Drawing.Point(261, 74)
        Me.btnAddPitch.Name = "btnAddPitch"
        Me.btnAddPitch.Size = New System.Drawing.Size(102, 59)
        Me.btnAddPitch.TabIndex = 3
        Me.btnAddPitch.Text = "Add Pitching Stats"
        Me.btnAddPitch.UseVisualStyleBackColor = False
        '
        'btnAddBat
        '
        Me.btnAddBat.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAddBat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBat.Location = New System.Drawing.Point(261, 9)
        Me.btnAddBat.Name = "btnAddBat"
        Me.btnAddBat.Size = New System.Drawing.Size(102, 59)
        Me.btnAddBat.TabIndex = 2
        Me.btnAddBat.Text = "Add Batting Stats"
        Me.btnAddBat.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(261, 139)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 26)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAddGameStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(375, 174)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBat)
        Me.Controls.Add(Me.btnAddPitch)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.lblHeading)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddGameStats"
        Me.Text = "Add Game Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddPitch As System.Windows.Forms.Button
    Friend WithEvents btnAddBat As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
