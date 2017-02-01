<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBattingStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputBattingStats))
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbStarted = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbGIDP = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbCS = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSB = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbBB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbHBP = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSFs = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSHs = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbKs = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbFO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbGO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRuns = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRBI = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbHR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTriples = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDoubles = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSingles = New System.Windows.Forms.ComboBox()
        Me.lblSingles = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.dupTime = New System.Windows.Forms.DomainUpDown()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(126, 491)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpDate.TabIndex = 18
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(80, 494)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 13)
        Me.lblDate.TabIndex = 80
        Me.lblDate.Text = "Date:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(132, 543)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(114, 27)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(12, 543)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 27)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbStarted
        '
        Me.cmbStarted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStarted.FormattingEnabled = True
        Me.cmbStarted.Items.AddRange(New Object() {"Y", "N"})
        Me.cmbStarted.Location = New System.Drawing.Point(126, 463)
        Me.cmbStarted.Name = "cmbStarted"
        Me.cmbStarted.Size = New System.Drawing.Size(49, 21)
        Me.cmbStarted.TabIndex = 17
        Me.cmbStarted.Tag = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 466)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Started Game?"
        '
        'cmbGIDP
        '
        Me.cmbGIDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGIDP.FormattingEnabled = True
        Me.cmbGIDP.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbGIDP.Location = New System.Drawing.Point(126, 436)
        Me.cmbGIDP.Name = "cmbGIDP"
        Me.cmbGIDP.Size = New System.Drawing.Size(49, 21)
        Me.cmbGIDP.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(71, 439)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "GIDPs:"
        '
        'cmbCS
        '
        Me.cmbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCS.FormattingEnabled = True
        Me.cmbCS.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbCS.Location = New System.Drawing.Point(126, 409)
        Me.cmbCS.Name = "cmbCS"
        Me.cmbCS.Size = New System.Drawing.Size(49, 21)
        Me.cmbCS.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 412)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Caught Stealings:"
        '
        'cmbSB
        '
        Me.cmbSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSB.FormattingEnabled = True
        Me.cmbSB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbSB.Location = New System.Drawing.Point(126, 382)
        Me.cmbSB.Name = "cmbSB"
        Me.cmbSB.Size = New System.Drawing.Size(49, 21)
        Me.cmbSB.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Stolen Bases:"
        '
        'cmbBB
        '
        Me.cmbBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBB.FormattingEnabled = True
        Me.cmbBB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbBB.Location = New System.Drawing.Point(126, 355)
        Me.cmbBB.Name = "cmbBB"
        Me.cmbBB.Size = New System.Drawing.Size(49, 21)
        Me.cmbBB.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Walks:"
        '
        'cmbHBP
        '
        Me.cmbHBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHBP.FormattingEnabled = True
        Me.cmbHBP.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbHBP.Location = New System.Drawing.Point(126, 328)
        Me.cmbHBP.Name = "cmbHBP"
        Me.cmbHBP.Size = New System.Drawing.Size(49, 21)
        Me.cmbHBP.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Hit By Pitches:"
        '
        'cmbSFs
        '
        Me.cmbSFs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSFs.FormattingEnabled = True
        Me.cmbSFs.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbSFs.Location = New System.Drawing.Point(126, 301)
        Me.cmbSFs.Name = "cmbSFs"
        Me.cmbSFs.Size = New System.Drawing.Size(49, 21)
        Me.cmbSFs.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Sacrifice Flys:"
        '
        'cmbSHs
        '
        Me.cmbSHs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSHs.FormattingEnabled = True
        Me.cmbSHs.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbSHs.Location = New System.Drawing.Point(126, 274)
        Me.cmbSHs.Name = "cmbSHs"
        Me.cmbSHs.Size = New System.Drawing.Size(49, 21)
        Me.cmbSHs.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Sacrifice Hits:"
        '
        'cmbKs
        '
        Me.cmbKs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKs.FormattingEnabled = True
        Me.cmbKs.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbKs.Location = New System.Drawing.Point(126, 247)
        Me.cmbKs.Name = "cmbKs"
        Me.cmbKs.Size = New System.Drawing.Size(49, 21)
        Me.cmbKs.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Strike Outs:"
        '
        'cmbFO
        '
        Me.cmbFO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFO.FormattingEnabled = True
        Me.cmbFO.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbFO.Location = New System.Drawing.Point(126, 220)
        Me.cmbFO.Name = "cmbFO"
        Me.cmbFO.Size = New System.Drawing.Size(49, 21)
        Me.cmbFO.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Fly Outs:"
        '
        'cmbGO
        '
        Me.cmbGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGO.FormattingEnabled = True
        Me.cmbGO.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbGO.Location = New System.Drawing.Point(126, 193)
        Me.cmbGO.Name = "cmbGO"
        Me.cmbGO.Size = New System.Drawing.Size(49, 21)
        Me.cmbGO.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Ground Outs:"
        '
        'cmbRuns
        '
        Me.cmbRuns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRuns.FormattingEnabled = True
        Me.cmbRuns.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbRuns.Location = New System.Drawing.Point(126, 166)
        Me.cmbRuns.Name = "cmbRuns"
        Me.cmbRuns.Size = New System.Drawing.Size(49, 21)
        Me.cmbRuns.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Runs:"
        '
        'cmbRBI
        '
        Me.cmbRBI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRBI.FormattingEnabled = True
        Me.cmbRBI.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cmbRBI.Location = New System.Drawing.Point(126, 139)
        Me.cmbRBI.Name = "cmbRBI"
        Me.cmbRBI.Size = New System.Drawing.Size(49, 21)
        Me.cmbRBI.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "RBI:"
        '
        'cmbHR
        '
        Me.cmbHR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHR.FormattingEnabled = True
        Me.cmbHR.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbHR.Location = New System.Drawing.Point(126, 112)
        Me.cmbHR.Name = "cmbHR"
        Me.cmbHR.Size = New System.Drawing.Size(49, 21)
        Me.cmbHR.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Homeruns:"
        '
        'cmbTriples
        '
        Me.cmbTriples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTriples.FormattingEnabled = True
        Me.cmbTriples.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbTriples.Location = New System.Drawing.Point(126, 85)
        Me.cmbTriples.Name = "cmbTriples"
        Me.cmbTriples.Size = New System.Drawing.Size(49, 21)
        Me.cmbTriples.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Triples:"
        '
        'cmbDoubles
        '
        Me.cmbDoubles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoubles.FormattingEnabled = True
        Me.cmbDoubles.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbDoubles.Location = New System.Drawing.Point(126, 58)
        Me.cmbDoubles.Name = "cmbDoubles"
        Me.cmbDoubles.Size = New System.Drawing.Size(49, 21)
        Me.cmbDoubles.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Doubles:"
        '
        'cmbSingles
        '
        Me.cmbSingles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSingles.FormattingEnabled = True
        Me.cmbSingles.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbSingles.Location = New System.Drawing.Point(126, 31)
        Me.cmbSingles.Name = "cmbSingles"
        Me.cmbSingles.Size = New System.Drawing.Size(49, 21)
        Me.cmbSingles.TabIndex = 1
        '
        'lblSingles
        '
        Me.lblSingles.AutoSize = True
        Me.lblSingles.Location = New System.Drawing.Point(68, 34)
        Me.lblSingles.Name = "lblSingles"
        Me.lblSingles.Size = New System.Drawing.Size(52, 13)
        Me.lblSingles.TabIndex = 42
        Me.lblSingles.Text = "Singles:"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(14, 9)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(0, 16)
        Me.lblPlayer.TabIndex = 41
        '
        'dupTime
        '
        Me.dupTime.Items.Add("7:00 AM")
        Me.dupTime.Items.Add("7:05 AM")
        Me.dupTime.Items.Add("7:10 AM")
        Me.dupTime.Items.Add("7:15 AM")
        Me.dupTime.Items.Add("7:20 AM")
        Me.dupTime.Items.Add("7:25 AM")
        Me.dupTime.Items.Add("7:30 AM")
        Me.dupTime.Items.Add("7:35 AM")
        Me.dupTime.Items.Add("7:40 AM")
        Me.dupTime.Items.Add("7:45 AM")
        Me.dupTime.Items.Add("7:50 AM")
        Me.dupTime.Items.Add("7:55 AM")
        Me.dupTime.Items.Add("8:00 AM")
        Me.dupTime.Items.Add("8:05 AM")
        Me.dupTime.Items.Add("8:10 AM")
        Me.dupTime.Items.Add("8:15 AM")
        Me.dupTime.Items.Add("8:20 AM")
        Me.dupTime.Items.Add("8:25 AM")
        Me.dupTime.Items.Add("8:30 AM")
        Me.dupTime.Items.Add("8:35 AM")
        Me.dupTime.Items.Add("8:40 AM")
        Me.dupTime.Items.Add("8:45 AM")
        Me.dupTime.Items.Add("8:50 AM")
        Me.dupTime.Items.Add("8:55 AM")
        Me.dupTime.Items.Add("9:00 AM")
        Me.dupTime.Items.Add("9:05 AM")
        Me.dupTime.Items.Add("9:10 AM")
        Me.dupTime.Items.Add("9:15 AM")
        Me.dupTime.Items.Add("9:20 AM")
        Me.dupTime.Items.Add("9:25 AM")
        Me.dupTime.Items.Add("9:30 AM")
        Me.dupTime.Items.Add("9:35 AM")
        Me.dupTime.Items.Add("9:40 AM")
        Me.dupTime.Items.Add("9:45 AM")
        Me.dupTime.Items.Add("9:50 AM")
        Me.dupTime.Items.Add("9:55 AM")
        Me.dupTime.Items.Add("10:00 AM")
        Me.dupTime.Items.Add("10:05 AM")
        Me.dupTime.Items.Add("10:10 AM")
        Me.dupTime.Items.Add("10:15 AM")
        Me.dupTime.Items.Add("10:20 AM")
        Me.dupTime.Items.Add("10:25 AM")
        Me.dupTime.Items.Add("10:30 AM")
        Me.dupTime.Items.Add("10:35 AM")
        Me.dupTime.Items.Add("10:40 AM")
        Me.dupTime.Items.Add("10:45 AM")
        Me.dupTime.Items.Add("10:50 AM")
        Me.dupTime.Items.Add("10:55 AM")
        Me.dupTime.Items.Add("11:00 AM")
        Me.dupTime.Items.Add("11:05 AM")
        Me.dupTime.Items.Add("11:10 AM")
        Me.dupTime.Items.Add("11:15 AM")
        Me.dupTime.Items.Add("11:20 AM")
        Me.dupTime.Items.Add("11:25 AM")
        Me.dupTime.Items.Add("11:30 AM")
        Me.dupTime.Items.Add("11:35 AM")
        Me.dupTime.Items.Add("11:40 AM")
        Me.dupTime.Items.Add("11:45 AM")
        Me.dupTime.Items.Add("11:50 AM")
        Me.dupTime.Items.Add("11:55 AM")
        Me.dupTime.Items.Add("12:00 PM")
        Me.dupTime.Items.Add("12:05 PM")
        Me.dupTime.Items.Add("12:10 PM")
        Me.dupTime.Items.Add("12:15 PM")
        Me.dupTime.Items.Add("12:20 PM")
        Me.dupTime.Items.Add("12:25 PM")
        Me.dupTime.Items.Add("12:30 PM")
        Me.dupTime.Items.Add("12:35 PM")
        Me.dupTime.Items.Add("12:40 PM")
        Me.dupTime.Items.Add("12:45 PM")
        Me.dupTime.Items.Add("12:50 PM")
        Me.dupTime.Items.Add("12:55 PM")
        Me.dupTime.Items.Add("1:00 PM")
        Me.dupTime.Items.Add("1:05 PM")
        Me.dupTime.Items.Add("1:10 PM")
        Me.dupTime.Items.Add("1:15 PM")
        Me.dupTime.Items.Add("1:20 PM")
        Me.dupTime.Items.Add("1:25 PM")
        Me.dupTime.Items.Add("1:30 PM")
        Me.dupTime.Items.Add("1:35 PM")
        Me.dupTime.Items.Add("1:40 PM")
        Me.dupTime.Items.Add("1:45 PM")
        Me.dupTime.Items.Add("1:50 PM")
        Me.dupTime.Items.Add("1:55 PM")
        Me.dupTime.Items.Add("2:00 PM")
        Me.dupTime.Items.Add("2:05 PM")
        Me.dupTime.Items.Add("2:10 PM")
        Me.dupTime.Items.Add("2:15 PM")
        Me.dupTime.Items.Add("2:20 PM")
        Me.dupTime.Items.Add("2:25 PM")
        Me.dupTime.Items.Add("2:30 PM")
        Me.dupTime.Items.Add("2:35 PM")
        Me.dupTime.Items.Add("2:40 PM")
        Me.dupTime.Items.Add("2:45 PM")
        Me.dupTime.Items.Add("2:50 PM")
        Me.dupTime.Items.Add("2:55 PM")
        Me.dupTime.Items.Add("3:00 PM")
        Me.dupTime.Items.Add("3:05 PM")
        Me.dupTime.Items.Add("3:10 PM")
        Me.dupTime.Items.Add("3:15 PM")
        Me.dupTime.Items.Add("3:20 PM")
        Me.dupTime.Items.Add("3:25 PM")
        Me.dupTime.Items.Add("3:30 PM")
        Me.dupTime.Items.Add("3:35 PM")
        Me.dupTime.Items.Add("3:40 PM")
        Me.dupTime.Items.Add("3:45 PM")
        Me.dupTime.Items.Add("3:50 PM")
        Me.dupTime.Items.Add("3:55 PM")
        Me.dupTime.Items.Add("4:00 PM")
        Me.dupTime.Items.Add("4:05 PM")
        Me.dupTime.Items.Add("4:10 PM")
        Me.dupTime.Items.Add("4:15 PM")
        Me.dupTime.Items.Add("4:20 PM")
        Me.dupTime.Items.Add("4:25 PM")
        Me.dupTime.Items.Add("4:30 PM")
        Me.dupTime.Items.Add("4:35 PM")
        Me.dupTime.Items.Add("4:40 PM")
        Me.dupTime.Items.Add("4:45 PM")
        Me.dupTime.Items.Add("4:50 PM")
        Me.dupTime.Items.Add("4:55 PM")
        Me.dupTime.Items.Add("5:00 PM")
        Me.dupTime.Items.Add("5:05 PM")
        Me.dupTime.Items.Add("5:10 PM")
        Me.dupTime.Items.Add("5:15 PM")
        Me.dupTime.Items.Add("5:20 PM")
        Me.dupTime.Items.Add("5:25 PM")
        Me.dupTime.Items.Add("5:30 PM")
        Me.dupTime.Items.Add("5:35 PM")
        Me.dupTime.Items.Add("5:40 PM")
        Me.dupTime.Items.Add("5:45 PM")
        Me.dupTime.Items.Add("5:50 PM")
        Me.dupTime.Items.Add("5:55 PM")
        Me.dupTime.Items.Add("6:00 PM")
        Me.dupTime.Items.Add("6:05 PM")
        Me.dupTime.Items.Add("6:10 PM")
        Me.dupTime.Items.Add("6:15 PM")
        Me.dupTime.Items.Add("6:20 PM")
        Me.dupTime.Items.Add("6:25 PM")
        Me.dupTime.Items.Add("6:30 PM")
        Me.dupTime.Items.Add("6:35 PM")
        Me.dupTime.Items.Add("6:40 PM")
        Me.dupTime.Items.Add("6:45 PM")
        Me.dupTime.Items.Add("6:50 PM")
        Me.dupTime.Items.Add("6:55 PM")
        Me.dupTime.Items.Add("7:00 PM")
        Me.dupTime.Items.Add("7:05 PM")
        Me.dupTime.Items.Add("7:10 PM")
        Me.dupTime.Items.Add("7:15 PM")
        Me.dupTime.Items.Add("7:20 PM")
        Me.dupTime.Items.Add("7:25 PM")
        Me.dupTime.Items.Add("7:30 PM")
        Me.dupTime.Items.Add("7:35 PM")
        Me.dupTime.Items.Add("7:40 PM")
        Me.dupTime.Items.Add("7:45 PM")
        Me.dupTime.Items.Add("7:50 PM")
        Me.dupTime.Items.Add("7:55 PM")
        Me.dupTime.Items.Add("8:00 PM")
        Me.dupTime.Items.Add("8:05 PM")
        Me.dupTime.Items.Add("8:10 PM")
        Me.dupTime.Items.Add("8:15 PM")
        Me.dupTime.Items.Add("8:20 PM")
        Me.dupTime.Items.Add("8:25 PM")
        Me.dupTime.Items.Add("8:30 PM")
        Me.dupTime.Items.Add("8:35 PM")
        Me.dupTime.Items.Add("8:40 PM")
        Me.dupTime.Items.Add("8:45 PM")
        Me.dupTime.Items.Add("8:50 PM")
        Me.dupTime.Items.Add("8:55 PM")
        Me.dupTime.Items.Add("9:00 PM")
        Me.dupTime.Items.Add("9:05 PM")
        Me.dupTime.Items.Add("9:10 PM")
        Me.dupTime.Items.Add("9:15 PM")
        Me.dupTime.Items.Add("9:20 PM")
        Me.dupTime.Items.Add("9:25 PM")
        Me.dupTime.Items.Add("9:30 PM")
        Me.dupTime.Items.Add("9:35 PM")
        Me.dupTime.Items.Add("9:40 PM")
        Me.dupTime.Items.Add("9:45 PM")
        Me.dupTime.Items.Add("9:50 PM")
        Me.dupTime.Items.Add("9:55 PM")
        Me.dupTime.Items.Add("10:00 PM")
        Me.dupTime.Items.Add("10:05 PM")
        Me.dupTime.Items.Add("10:10 PM")
        Me.dupTime.Items.Add("10:15 PM")
        Me.dupTime.Items.Add("10:20 PM")
        Me.dupTime.Items.Add("10:25 PM")
        Me.dupTime.Items.Add("10:30 PM")
        Me.dupTime.Items.Add("10:35 PM")
        Me.dupTime.Items.Add("10:40 PM")
        Me.dupTime.Items.Add("10:45 PM")
        Me.dupTime.Items.Add("10:50 PM")
        Me.dupTime.Items.Add("10:55 PM")
        Me.dupTime.Items.Add("11:00 PM")
        Me.dupTime.Location = New System.Drawing.Point(126, 517)
        Me.dupTime.Name = "dupTime"
        Me.dupTime.ReadOnly = True
        Me.dupTime.Size = New System.Drawing.Size(120, 20)
        Me.dupTime.TabIndex = 19
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(80, 519)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(38, 13)
        Me.lblTime.TabIndex = 81
        Me.lblTime.Text = "Time:"
        '
        'frmInputBattingStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(272, 577)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.dupTime)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbStarted)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbGIDP)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbCS)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbSB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbBB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbHBP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbSFs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbSHs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbKs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbFO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbGO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbRuns)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbRBI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbHR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTriples)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDoubles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSingles)
        Me.Controls.Add(Me.lblSingles)
        Me.Controls.Add(Me.lblPlayer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInputBattingStats"
        Me.Text = "Input Batting Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbStarted As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbGIDP As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbCS As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbSB As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbBB As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbHBP As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbSFs As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbSHs As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbKs As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbFO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbRuns As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbRBI As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbHR As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTriples As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDoubles As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSingles As System.Windows.Forms.ComboBox
    Friend WithEvents lblSingles As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents dupTime As System.Windows.Forms.DomainUpDown
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
