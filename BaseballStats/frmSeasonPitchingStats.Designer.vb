<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeasonPitchingStats
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeasonPitchingStats))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BaseballProgramDataSet = New BaseballProgram.BaseballProgramDataSet()
        Me.SeasonPitchingStatsCalcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonPitchingStatsCalcTableAdapter = New BaseballProgram.BaseballProgramDataSetTableAdapters.SeasonPitchingStatsCalcTableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HBPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ABDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BB9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BB7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KBBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERCDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WHIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseballProgramDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonPitchingStatsCalcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.BurlyWood
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(1054, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(126, 371)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Green
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GDataGridViewTextBoxColumn, Me.GSDataGridViewTextBoxColumn, Me.WDataGridViewTextBoxColumn, Me.LDataGridViewTextBoxColumn, Me.WDataGridViewTextBoxColumn1, Me.CGDataGridViewTextBoxColumn, Me.SHODataGridViewTextBoxColumn, Me.SVDataGridViewTextBoxColumn, Me.BSDataGridViewTextBoxColumn, Me.SVDataGridViewTextBoxColumn1, Me.IPDataGridViewTextBoxColumn, Me.TPDataGridViewTextBoxColumn, Me.PIPDataGridViewTextBoxColumn, Me.RDataGridViewTextBoxColumn, Me.ERDataGridViewTextBoxColumn, Me.HDataGridViewTextBoxColumn, Me.KDataGridViewTextBoxColumn, Me.BBDataGridViewTextBoxColumn, Me.HBPDataGridViewTextBoxColumn, Me.ABDataGridViewTextBoxColumn, Me.BFDataGridViewTextBoxColumn, Me.BADataGridViewTextBoxColumn, Me.K9DataGridViewTextBoxColumn, Me.K7DataGridViewTextBoxColumn, Me.BB9DataGridViewTextBoxColumn, Me.BB7DataGridViewTextBoxColumn, Me.H9DataGridViewTextBoxColumn, Me.H7DataGridViewTextBoxColumn, Me.KBBDataGridViewTextBoxColumn, Me.ERADataGridViewTextBoxColumn, Me.ERADataGridViewTextBoxColumn1, Me.ERCDataGridViewTextBoxColumn, Me.ERCDataGridViewTextBoxColumn1, Me.WHIPDataGridViewTextBoxColumn, Me.LOBDataGridViewTextBoxColumn, Me.PFRDataGridViewTextBoxColumn, Me.RADataGridViewTextBoxColumn, Me.RADataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.SeasonPitchingStatsCalcBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(1029, 371)
        Me.DataGridView1.TabIndex = 2
        '
        'BaseballProgramDataSet
        '
        Me.BaseballProgramDataSet.DataSetName = "BaseballProgramDataSet"
        Me.BaseballProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeasonPitchingStatsCalcBindingSource
        '
        Me.SeasonPitchingStatsCalcBindingSource.DataMember = "SeasonPitchingStatsCalc"
        Me.SeasonPitchingStatsCalcBindingSource.DataSource = Me.BaseballProgramDataSet
        '
        'SeasonPitchingStatsCalcTableAdapter
        '
        Me.SeasonPitchingStatsCalcTableAdapter.ClearBeforeFill = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 121
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 120
        '
        'GDataGridViewTextBoxColumn
        '
        Me.GDataGridViewTextBoxColumn.DataPropertyName = "G"
        Me.GDataGridViewTextBoxColumn.HeaderText = "G"
        Me.GDataGridViewTextBoxColumn.Name = "GDataGridViewTextBoxColumn"
        Me.GDataGridViewTextBoxColumn.ReadOnly = True
        Me.GDataGridViewTextBoxColumn.Width = 48
        '
        'GSDataGridViewTextBoxColumn
        '
        Me.GSDataGridViewTextBoxColumn.DataPropertyName = "GS"
        Me.GSDataGridViewTextBoxColumn.HeaderText = "GS"
        Me.GSDataGridViewTextBoxColumn.Name = "GSDataGridViewTextBoxColumn"
        Me.GSDataGridViewTextBoxColumn.ReadOnly = True
        Me.GSDataGridViewTextBoxColumn.Width = 60
        '
        'WDataGridViewTextBoxColumn
        '
        Me.WDataGridViewTextBoxColumn.DataPropertyName = "W"
        Me.WDataGridViewTextBoxColumn.HeaderText = "W"
        Me.WDataGridViewTextBoxColumn.Name = "WDataGridViewTextBoxColumn"
        Me.WDataGridViewTextBoxColumn.ReadOnly = True
        Me.WDataGridViewTextBoxColumn.Width = 50
        '
        'LDataGridViewTextBoxColumn
        '
        Me.LDataGridViewTextBoxColumn.DataPropertyName = "L"
        Me.LDataGridViewTextBoxColumn.HeaderText = "L"
        Me.LDataGridViewTextBoxColumn.Name = "LDataGridViewTextBoxColumn"
        Me.LDataGridViewTextBoxColumn.ReadOnly = True
        Me.LDataGridViewTextBoxColumn.Width = 44
        '
        'WDataGridViewTextBoxColumn1
        '
        Me.WDataGridViewTextBoxColumn1.DataPropertyName = "W%"
        Me.WDataGridViewTextBoxColumn1.HeaderText = "W%"
        Me.WDataGridViewTextBoxColumn1.Name = "WDataGridViewTextBoxColumn1"
        Me.WDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WDataGridViewTextBoxColumn1.Width = 65
        '
        'CGDataGridViewTextBoxColumn
        '
        Me.CGDataGridViewTextBoxColumn.DataPropertyName = "CG"
        Me.CGDataGridViewTextBoxColumn.HeaderText = "CG"
        Me.CGDataGridViewTextBoxColumn.Name = "CGDataGridViewTextBoxColumn"
        Me.CGDataGridViewTextBoxColumn.ReadOnly = True
        Me.CGDataGridViewTextBoxColumn.Width = 60
        '
        'SHODataGridViewTextBoxColumn
        '
        Me.SHODataGridViewTextBoxColumn.DataPropertyName = "SHO"
        Me.SHODataGridViewTextBoxColumn.HeaderText = "SHO"
        Me.SHODataGridViewTextBoxColumn.Name = "SHODataGridViewTextBoxColumn"
        Me.SHODataGridViewTextBoxColumn.ReadOnly = True
        Me.SHODataGridViewTextBoxColumn.Width = 72
        '
        'SVDataGridViewTextBoxColumn
        '
        Me.SVDataGridViewTextBoxColumn.DataPropertyName = "SV"
        Me.SVDataGridViewTextBoxColumn.HeaderText = "SV"
        Me.SVDataGridViewTextBoxColumn.Name = "SVDataGridViewTextBoxColumn"
        Me.SVDataGridViewTextBoxColumn.ReadOnly = True
        Me.SVDataGridViewTextBoxColumn.Width = 58
        '
        'BSDataGridViewTextBoxColumn
        '
        Me.BSDataGridViewTextBoxColumn.DataPropertyName = "BS"
        Me.BSDataGridViewTextBoxColumn.HeaderText = "BS"
        Me.BSDataGridViewTextBoxColumn.Name = "BSDataGridViewTextBoxColumn"
        Me.BSDataGridViewTextBoxColumn.ReadOnly = True
        Me.BSDataGridViewTextBoxColumn.Width = 58
        '
        'SVDataGridViewTextBoxColumn1
        '
        Me.SVDataGridViewTextBoxColumn1.DataPropertyName = "SV%"
        Me.SVDataGridViewTextBoxColumn1.HeaderText = "SV%"
        Me.SVDataGridViewTextBoxColumn1.Name = "SVDataGridViewTextBoxColumn1"
        Me.SVDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SVDataGridViewTextBoxColumn1.Width = 73
        '
        'IPDataGridViewTextBoxColumn
        '
        Me.IPDataGridViewTextBoxColumn.DataPropertyName = "IP"
        Me.IPDataGridViewTextBoxColumn.HeaderText = "IP"
        Me.IPDataGridViewTextBoxColumn.Name = "IPDataGridViewTextBoxColumn"
        Me.IPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IPDataGridViewTextBoxColumn.Width = 51
        '
        'TPDataGridViewTextBoxColumn
        '
        Me.TPDataGridViewTextBoxColumn.DataPropertyName = "TP"
        Me.TPDataGridViewTextBoxColumn.HeaderText = "TP"
        Me.TPDataGridViewTextBoxColumn.Name = "TPDataGridViewTextBoxColumn"
        Me.TPDataGridViewTextBoxColumn.ReadOnly = True
        Me.TPDataGridViewTextBoxColumn.Width = 55
        '
        'PIPDataGridViewTextBoxColumn
        '
        Me.PIPDataGridViewTextBoxColumn.DataPropertyName = "P/IP"
        Me.PIPDataGridViewTextBoxColumn.HeaderText = "P/IP"
        Me.PIPDataGridViewTextBoxColumn.Name = "PIPDataGridViewTextBoxColumn"
        Me.PIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIPDataGridViewTextBoxColumn.Width = 67
        '
        'RDataGridViewTextBoxColumn
        '
        Me.RDataGridViewTextBoxColumn.DataPropertyName = "R"
        Me.RDataGridViewTextBoxColumn.HeaderText = "R"
        Me.RDataGridViewTextBoxColumn.Name = "RDataGridViewTextBoxColumn"
        Me.RDataGridViewTextBoxColumn.ReadOnly = True
        Me.RDataGridViewTextBoxColumn.Width = 47
        '
        'ERDataGridViewTextBoxColumn
        '
        Me.ERDataGridViewTextBoxColumn.DataPropertyName = "ER"
        Me.ERDataGridViewTextBoxColumn.HeaderText = "ER"
        Me.ERDataGridViewTextBoxColumn.Name = "ERDataGridViewTextBoxColumn"
        Me.ERDataGridViewTextBoxColumn.ReadOnly = True
        Me.ERDataGridViewTextBoxColumn.Width = 59
        '
        'HDataGridViewTextBoxColumn
        '
        Me.HDataGridViewTextBoxColumn.DataPropertyName = "H"
        Me.HDataGridViewTextBoxColumn.HeaderText = "H"
        Me.HDataGridViewTextBoxColumn.Name = "HDataGridViewTextBoxColumn"
        Me.HDataGridViewTextBoxColumn.ReadOnly = True
        Me.HDataGridViewTextBoxColumn.Width = 47
        '
        'KDataGridViewTextBoxColumn
        '
        Me.KDataGridViewTextBoxColumn.DataPropertyName = "K"
        Me.KDataGridViewTextBoxColumn.HeaderText = "K"
        Me.KDataGridViewTextBoxColumn.Name = "KDataGridViewTextBoxColumn"
        Me.KDataGridViewTextBoxColumn.ReadOnly = True
        Me.KDataGridViewTextBoxColumn.Width = 45
        '
        'BBDataGridViewTextBoxColumn
        '
        Me.BBDataGridViewTextBoxColumn.DataPropertyName = "BB"
        Me.BBDataGridViewTextBoxColumn.HeaderText = "BB"
        Me.BBDataGridViewTextBoxColumn.Name = "BBDataGridViewTextBoxColumn"
        Me.BBDataGridViewTextBoxColumn.ReadOnly = True
        Me.BBDataGridViewTextBoxColumn.Width = 58
        '
        'HBPDataGridViewTextBoxColumn
        '
        Me.HBPDataGridViewTextBoxColumn.DataPropertyName = "HBP"
        Me.HBPDataGridViewTextBoxColumn.HeaderText = "HBP"
        Me.HBPDataGridViewTextBoxColumn.Name = "HBPDataGridViewTextBoxColumn"
        Me.HBPDataGridViewTextBoxColumn.ReadOnly = True
        Me.HBPDataGridViewTextBoxColumn.Width = 70
        '
        'ABDataGridViewTextBoxColumn
        '
        Me.ABDataGridViewTextBoxColumn.DataPropertyName = "AB"
        Me.ABDataGridViewTextBoxColumn.HeaderText = "AB"
        Me.ABDataGridViewTextBoxColumn.Name = "ABDataGridViewTextBoxColumn"
        Me.ABDataGridViewTextBoxColumn.ReadOnly = True
        Me.ABDataGridViewTextBoxColumn.Width = 58
        '
        'BFDataGridViewTextBoxColumn
        '
        Me.BFDataGridViewTextBoxColumn.DataPropertyName = "BF"
        Me.BFDataGridViewTextBoxColumn.HeaderText = "BF"
        Me.BFDataGridViewTextBoxColumn.Name = "BFDataGridViewTextBoxColumn"
        Me.BFDataGridViewTextBoxColumn.ReadOnly = True
        Me.BFDataGridViewTextBoxColumn.Width = 57
        '
        'BADataGridViewTextBoxColumn
        '
        Me.BADataGridViewTextBoxColumn.DataPropertyName = "BA"
        Me.BADataGridViewTextBoxColumn.HeaderText = "BA"
        Me.BADataGridViewTextBoxColumn.Name = "BADataGridViewTextBoxColumn"
        Me.BADataGridViewTextBoxColumn.ReadOnly = True
        Me.BADataGridViewTextBoxColumn.Width = 58
        '
        'K9DataGridViewTextBoxColumn
        '
        Me.K9DataGridViewTextBoxColumn.DataPropertyName = "K/9"
        Me.K9DataGridViewTextBoxColumn.HeaderText = "K/9"
        Me.K9DataGridViewTextBoxColumn.Name = "K9DataGridViewTextBoxColumn"
        Me.K9DataGridViewTextBoxColumn.ReadOnly = True
        Me.K9DataGridViewTextBoxColumn.Width = 60
        '
        'K7DataGridViewTextBoxColumn
        '
        Me.K7DataGridViewTextBoxColumn.DataPropertyName = "K/7"
        Me.K7DataGridViewTextBoxColumn.HeaderText = "K/7"
        Me.K7DataGridViewTextBoxColumn.Name = "K7DataGridViewTextBoxColumn"
        Me.K7DataGridViewTextBoxColumn.ReadOnly = True
        Me.K7DataGridViewTextBoxColumn.Width = 60
        '
        'BB9DataGridViewTextBoxColumn
        '
        Me.BB9DataGridViewTextBoxColumn.DataPropertyName = "BB/9"
        Me.BB9DataGridViewTextBoxColumn.HeaderText = "BB/9"
        Me.BB9DataGridViewTextBoxColumn.Name = "BB9DataGridViewTextBoxColumn"
        Me.BB9DataGridViewTextBoxColumn.ReadOnly = True
        Me.BB9DataGridViewTextBoxColumn.Width = 73
        '
        'BB7DataGridViewTextBoxColumn
        '
        Me.BB7DataGridViewTextBoxColumn.DataPropertyName = "BB/7"
        Me.BB7DataGridViewTextBoxColumn.HeaderText = "BB/7"
        Me.BB7DataGridViewTextBoxColumn.Name = "BB7DataGridViewTextBoxColumn"
        Me.BB7DataGridViewTextBoxColumn.ReadOnly = True
        Me.BB7DataGridViewTextBoxColumn.Width = 73
        '
        'H9DataGridViewTextBoxColumn
        '
        Me.H9DataGridViewTextBoxColumn.DataPropertyName = "H/9"
        Me.H9DataGridViewTextBoxColumn.HeaderText = "H/9"
        Me.H9DataGridViewTextBoxColumn.Name = "H9DataGridViewTextBoxColumn"
        Me.H9DataGridViewTextBoxColumn.ReadOnly = True
        Me.H9DataGridViewTextBoxColumn.Width = 62
        '
        'H7DataGridViewTextBoxColumn
        '
        Me.H7DataGridViewTextBoxColumn.DataPropertyName = "H/7"
        Me.H7DataGridViewTextBoxColumn.HeaderText = "H/7"
        Me.H7DataGridViewTextBoxColumn.Name = "H7DataGridViewTextBoxColumn"
        Me.H7DataGridViewTextBoxColumn.ReadOnly = True
        Me.H7DataGridViewTextBoxColumn.Width = 62
        '
        'KBBDataGridViewTextBoxColumn
        '
        Me.KBBDataGridViewTextBoxColumn.DataPropertyName = "K/BB"
        Me.KBBDataGridViewTextBoxColumn.HeaderText = "K/BB"
        Me.KBBDataGridViewTextBoxColumn.Name = "KBBDataGridViewTextBoxColumn"
        Me.KBBDataGridViewTextBoxColumn.ReadOnly = True
        Me.KBBDataGridViewTextBoxColumn.Width = 74
        '
        'ERADataGridViewTextBoxColumn
        '
        Me.ERADataGridViewTextBoxColumn.DataPropertyName = "ERA"
        Me.ERADataGridViewTextBoxColumn.HeaderText = "ERA"
        Me.ERADataGridViewTextBoxColumn.Name = "ERADataGridViewTextBoxColumn"
        Me.ERADataGridViewTextBoxColumn.ReadOnly = True
        Me.ERADataGridViewTextBoxColumn.Width = 71
        '
        'ERADataGridViewTextBoxColumn1
        '
        Me.ERADataGridViewTextBoxColumn1.DataPropertyName = "ERA+"
        Me.ERADataGridViewTextBoxColumn1.HeaderText = "ERA+"
        Me.ERADataGridViewTextBoxColumn1.Name = "ERADataGridViewTextBoxColumn1"
        Me.ERADataGridViewTextBoxColumn1.ReadOnly = True
        Me.ERADataGridViewTextBoxColumn1.Width = 81
        '
        'ERCDataGridViewTextBoxColumn
        '
        Me.ERCDataGridViewTextBoxColumn.DataPropertyName = "ERC"
        Me.ERCDataGridViewTextBoxColumn.HeaderText = "ERC"
        Me.ERCDataGridViewTextBoxColumn.Name = "ERCDataGridViewTextBoxColumn"
        Me.ERCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ERCDataGridViewTextBoxColumn.Width = 71
        '
        'ERCDataGridViewTextBoxColumn1
        '
        Me.ERCDataGridViewTextBoxColumn1.DataPropertyName = "ERC+"
        Me.ERCDataGridViewTextBoxColumn1.HeaderText = "ERC+"
        Me.ERCDataGridViewTextBoxColumn1.Name = "ERCDataGridViewTextBoxColumn1"
        Me.ERCDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ERCDataGridViewTextBoxColumn1.Width = 81
        '
        'WHIPDataGridViewTextBoxColumn
        '
        Me.WHIPDataGridViewTextBoxColumn.DataPropertyName = "WHIP"
        Me.WHIPDataGridViewTextBoxColumn.HeaderText = "WHIP"
        Me.WHIPDataGridViewTextBoxColumn.Name = "WHIPDataGridViewTextBoxColumn"
        Me.WHIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.WHIPDataGridViewTextBoxColumn.Width = 80
        '
        'LOBDataGridViewTextBoxColumn
        '
        Me.LOBDataGridViewTextBoxColumn.DataPropertyName = "LOB%"
        Me.LOBDataGridViewTextBoxColumn.HeaderText = "LOB%"
        Me.LOBDataGridViewTextBoxColumn.Name = "LOBDataGridViewTextBoxColumn"
        Me.LOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOBDataGridViewTextBoxColumn.Width = 84
        '
        'PFRDataGridViewTextBoxColumn
        '
        Me.PFRDataGridViewTextBoxColumn.DataPropertyName = "PFR"
        Me.PFRDataGridViewTextBoxColumn.HeaderText = "PFR"
        Me.PFRDataGridViewTextBoxColumn.Name = "PFRDataGridViewTextBoxColumn"
        Me.PFRDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFRDataGridViewTextBoxColumn.Width = 69
        '
        'RADataGridViewTextBoxColumn
        '
        Me.RADataGridViewTextBoxColumn.DataPropertyName = "RA"
        Me.RADataGridViewTextBoxColumn.HeaderText = "RA"
        Me.RADataGridViewTextBoxColumn.Name = "RADataGridViewTextBoxColumn"
        Me.RADataGridViewTextBoxColumn.ReadOnly = True
        Me.RADataGridViewTextBoxColumn.Width = 59
        '
        'RADataGridViewTextBoxColumn1
        '
        Me.RADataGridViewTextBoxColumn1.DataPropertyName = "RA+"
        Me.RADataGridViewTextBoxColumn1.HeaderText = "RA+"
        Me.RADataGridViewTextBoxColumn1.Name = "RADataGridViewTextBoxColumn1"
        Me.RADataGridViewTextBoxColumn1.ReadOnly = True
        Me.RADataGridViewTextBoxColumn1.Width = 69
        '
        'frmSeasonPitchingStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1200, 394)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnReturn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeasonPitchingStats"
        Me.Text = "Season Pitching Stats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseballProgramDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonPitchingStatsCalcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SVDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HBPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ABDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents K9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents K7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BB9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BB7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KBBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERCDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WHIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonPitchingStatsCalcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseballProgramDataSet As BaseballProgram.BaseballProgramDataSet
    Friend WithEvents SeasonPitchingStatsCalcTableAdapter As BaseballProgram.BaseballProgramDataSetTableAdapters.SeasonPitchingStatsCalcTableAdapter
End Class
