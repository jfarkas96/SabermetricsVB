<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputPitchingStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputPitchingStats))
        Me.cmbWin = New System.Windows.Forms.ComboBox()
        Me.cmbLoss = New System.Windows.Forms.ComboBox()
        Me.cmbStarted = New System.Windows.Forms.ComboBox()
        Me.cmbHits = New System.Windows.Forms.ComboBox()
        Me.cmbAB = New System.Windows.Forms.ComboBox()
        Me.cmbBB = New System.Windows.Forms.ComboBox()
        Me.cmbHBP = New System.Windows.Forms.ComboBox()
        Me.cmbER = New System.Windows.Forms.ComboBox()
        Me.cmbK = New System.Windows.Forms.ComboBox()
        Me.cmbCG = New System.Windows.Forms.ComboBox()
        Me.cmbSHO = New System.Windows.Forms.ComboBox()
        Me.cmbTP = New System.Windows.Forms.ComboBox()
        Me.cmbSave = New System.Windows.Forms.ComboBox()
        Me.cmbBS = New System.Windows.Forms.ComboBox()
        Me.dtpGame = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRuns = New System.Windows.Forms.ComboBox()
        Me.cmbIP = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbWin
        '
        Me.cmbWin.BackColor = System.Drawing.SystemColors.Window
        Me.cmbWin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWin.FormattingEnabled = True
        Me.cmbWin.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbWin.Location = New System.Drawing.Point(117, 40)
        Me.cmbWin.Name = "cmbWin"
        Me.cmbWin.Size = New System.Drawing.Size(58, 21)
        Me.cmbWin.TabIndex = 0
        '
        'cmbLoss
        '
        Me.cmbLoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoss.FormattingEnabled = True
        Me.cmbLoss.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbLoss.Location = New System.Drawing.Point(117, 67)
        Me.cmbLoss.Name = "cmbLoss"
        Me.cmbLoss.Size = New System.Drawing.Size(58, 21)
        Me.cmbLoss.TabIndex = 1
        '
        'cmbStarted
        '
        Me.cmbStarted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStarted.FormattingEnabled = True
        Me.cmbStarted.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbStarted.Location = New System.Drawing.Point(117, 94)
        Me.cmbStarted.Name = "cmbStarted"
        Me.cmbStarted.Size = New System.Drawing.Size(58, 21)
        Me.cmbStarted.TabIndex = 2
        '
        'cmbHits
        '
        Me.cmbHits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHits.FormattingEnabled = True
        Me.cmbHits.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbHits.Location = New System.Drawing.Point(117, 148)
        Me.cmbHits.Name = "cmbHits"
        Me.cmbHits.Size = New System.Drawing.Size(58, 21)
        Me.cmbHits.TabIndex = 4
        '
        'cmbAB
        '
        Me.cmbAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAB.FormattingEnabled = True
        Me.cmbAB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.cmbAB.Location = New System.Drawing.Point(117, 175)
        Me.cmbAB.Name = "cmbAB"
        Me.cmbAB.Size = New System.Drawing.Size(58, 21)
        Me.cmbAB.TabIndex = 5
        '
        'cmbBB
        '
        Me.cmbBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBB.FormattingEnabled = True
        Me.cmbBB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbBB.Location = New System.Drawing.Point(117, 202)
        Me.cmbBB.Name = "cmbBB"
        Me.cmbBB.Size = New System.Drawing.Size(58, 21)
        Me.cmbBB.TabIndex = 6
        '
        'cmbHBP
        '
        Me.cmbHBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHBP.FormattingEnabled = True
        Me.cmbHBP.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbHBP.Location = New System.Drawing.Point(117, 229)
        Me.cmbHBP.Name = "cmbHBP"
        Me.cmbHBP.Size = New System.Drawing.Size(58, 21)
        Me.cmbHBP.TabIndex = 7
        '
        'cmbER
        '
        Me.cmbER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbER.FormattingEnabled = True
        Me.cmbER.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbER.Location = New System.Drawing.Point(117, 283)
        Me.cmbER.Name = "cmbER"
        Me.cmbER.Size = New System.Drawing.Size(58, 21)
        Me.cmbER.TabIndex = 9
        '
        'cmbK
        '
        Me.cmbK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbK.FormattingEnabled = True
        Me.cmbK.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbK.Location = New System.Drawing.Point(117, 310)
        Me.cmbK.Name = "cmbK"
        Me.cmbK.Size = New System.Drawing.Size(58, 21)
        Me.cmbK.TabIndex = 10
        '
        'cmbCG
        '
        Me.cmbCG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCG.FormattingEnabled = True
        Me.cmbCG.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbCG.Location = New System.Drawing.Point(117, 337)
        Me.cmbCG.Name = "cmbCG"
        Me.cmbCG.Size = New System.Drawing.Size(58, 21)
        Me.cmbCG.TabIndex = 11
        '
        'cmbSHO
        '
        Me.cmbSHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSHO.FormattingEnabled = True
        Me.cmbSHO.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbSHO.Location = New System.Drawing.Point(117, 335)
        Me.cmbSHO.Name = "cmbSHO"
        Me.cmbSHO.Size = New System.Drawing.Size(58, 21)
        Me.cmbSHO.TabIndex = 11
        '
        'cmbTP
        '
        Me.cmbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTP.FormattingEnabled = True
        Me.cmbTP.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200"})
        Me.cmbTP.Location = New System.Drawing.Point(117, 362)
        Me.cmbTP.Name = "cmbTP"
        Me.cmbTP.Size = New System.Drawing.Size(58, 21)
        Me.cmbTP.TabIndex = 12
        '
        'cmbSave
        '
        Me.cmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSave.FormattingEnabled = True
        Me.cmbSave.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbSave.Location = New System.Drawing.Point(117, 389)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(58, 21)
        Me.cmbSave.TabIndex = 13
        '
        'cmbBS
        '
        Me.cmbBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBS.FormattingEnabled = True
        Me.cmbBS.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbBS.Location = New System.Drawing.Point(117, 416)
        Me.cmbBS.Name = "cmbBS"
        Me.cmbBS.Size = New System.Drawing.Size(58, 21)
        Me.cmbBS.TabIndex = 14
        '
        'dtpGame
        '
        Me.dtpGame.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGame.Location = New System.Drawing.Point(117, 443)
        Me.dtpGame.Name = "dtpGame"
        Me.dtpGame.Size = New System.Drawing.Size(112, 20)
        Me.dtpGame.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Win?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(69, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Loss?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Game Started?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(77, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Hits:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(82, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "AB:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(64, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Walks:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(72, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "HBP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Earned Runs:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(44, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Strikeouts:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(8, 311)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Complete Game?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(52, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Shutout?"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(27, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Total Pitches:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(65, 392)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Save?"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(28, 419)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Blown Save?"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(71, 446)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Date:"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(14, 9)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(0, 16)
        Me.lblPlayer.TabIndex = 42
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(12, 470)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 30)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(132, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 30)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(69, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Runs:"
        '
        'cmbRuns
        '
        Me.cmbRuns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRuns.FormattingEnabled = True
        Me.cmbRuns.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbRuns.Location = New System.Drawing.Point(117, 256)
        Me.cmbRuns.Name = "cmbRuns"
        Me.cmbRuns.Size = New System.Drawing.Size(58, 21)
        Me.cmbRuns.TabIndex = 8
        '
        'cmbIP
        '
        Me.cmbIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIP.FormattingEnabled = True
        Me.cmbIP.Items.AddRange(New Object() {"0", "0.333", "0.667", "1", "1.333", "1.667", "2", "2.333", "2.667", "3", "3.333", "3.667", "4", "4.333", "4.667", "5", "5.333", "5.667", "6", "6.333", "6.667", "7", "7.333", "7.667", "8", "8.333", "8.667", "9", "9.333", "9.667", "10", "10.333", "10.667", "11", "11.333", "11.667", "12", "12.333", "12.667", "13", "13.333", "13.667", "14", "14.333", "14.667", "15"})
        Me.cmbIP.Location = New System.Drawing.Point(117, 121)
        Me.cmbIP.Name = "cmbIP"
        Me.cmbIP.Size = New System.Drawing.Size(58, 21)
        Me.cmbIP.TabIndex = 3
        Me.cmbIP.Tag = "Decimal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Innings Pitched"
        '
        'frmInputPitchingStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(286, 268)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbIP)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpGame)
        Me.Controls.Add(Me.cmbBS)
        Me.Controls.Add(Me.cmbSave)
        Me.Controls.Add(Me.cmbTP)
        Me.Controls.Add(Me.cmbSHO)
        Me.Controls.Add(Me.cmbCG)
        Me.Controls.Add(Me.cmbK)
        Me.Controls.Add(Me.cmbER)
        Me.Controls.Add(Me.cmbRuns)
        Me.Controls.Add(Me.cmbHBP)
        Me.Controls.Add(Me.cmbBB)
        Me.Controls.Add(Me.cmbAB)
        Me.Controls.Add(Me.cmbHits)
        Me.Controls.Add(Me.cmbStarted)
        Me.Controls.Add(Me.cmbLoss)
        Me.Controls.Add(Me.cmbWin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInputPitchingStats"
        Me.Text = "Input Pitching Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbWin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoss As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStarted As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAB As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBB As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHBP As System.Windows.Forms.ComboBox
    Friend WithEvents cmbER As System.Windows.Forms.ComboBox
    Friend WithEvents cmbK As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCG As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSHO As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTP As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSave As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBS As System.Windows.Forms.ComboBox
    Friend WithEvents dtpGame As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbRuns As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIP As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
