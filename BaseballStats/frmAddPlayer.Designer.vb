<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPlayer))
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.cmbBats = New System.Windows.Forms.ComboBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cmbThrows = New System.Windows.Forms.ComboBox()
        Me.cmbNumber = New System.Windows.Forms.ComboBox()
        Me.lblBats = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblThrows = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(25, 40)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(71, 13)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(25, 66)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(71, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.White
        Me.lblNumber.Location = New System.Drawing.Point(42, 92)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(54, 13)
        Me.lblNumber.TabIndex = 6
        Me.lblNumber.Text = "Number:"
        '
        'cmbBats
        '
        Me.cmbBats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBats.FormattingEnabled = True
        Me.cmbBats.Items.AddRange(New Object() {"L", "R", "S"})
        Me.cmbBats.Location = New System.Drawing.Point(102, 116)
        Me.cmbBats.Name = "cmbBats"
        Me.cmbBats.Size = New System.Drawing.Size(52, 21)
        Me.cmbBats.TabIndex = 3
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(116, 15)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Add a new player"
        '
        'cmbThrows
        '
        Me.cmbThrows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbThrows.FormattingEnabled = True
        Me.cmbThrows.Items.AddRange(New Object() {"L", "R", "S"})
        Me.cmbThrows.Location = New System.Drawing.Point(102, 143)
        Me.cmbThrows.Name = "cmbThrows"
        Me.cmbThrows.Size = New System.Drawing.Size(52, 21)
        Me.cmbThrows.TabIndex = 4
        '
        'cmbNumber
        '
        Me.cmbNumber.DisplayMember = "1"
        Me.cmbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumber.FormattingEnabled = True
        Me.cmbNumber.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09"})
        Me.cmbNumber.Location = New System.Drawing.Point(102, 89)
        Me.cmbNumber.Name = "cmbNumber"
        Me.cmbNumber.Size = New System.Drawing.Size(52, 21)
        Me.cmbNumber.TabIndex = 2
        '
        'lblBats
        '
        Me.lblBats.AutoSize = True
        Me.lblBats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBats.ForeColor = System.Drawing.Color.White
        Me.lblBats.Location = New System.Drawing.Point(60, 119)
        Me.lblBats.Name = "lblBats"
        Me.lblBats.Size = New System.Drawing.Size(36, 13)
        Me.lblBats.TabIndex = 9
        Me.lblBats.Text = "Bats:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(102, 63)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblThrows
        '
        Me.lblThrows.AutoSize = True
        Me.lblThrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThrows.ForeColor = System.Drawing.Color.White
        Me.lblThrows.Location = New System.Drawing.Point(44, 146)
        Me.lblThrows.Name = "lblThrows"
        Me.lblThrows.Size = New System.Drawing.Size(52, 13)
        Me.lblThrows.TabIndex = 10
        Me.lblThrows.Text = "Throws:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(102, 37)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(137, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(32, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 50)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(143, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 50)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAddPlayer
        '
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(274, 241)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblThrows)
        Me.Controls.Add(Me.cmbBats)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblBats)
        Me.Controls.Add(Me.cmbThrows)
        Me.Controls.Add(Me.cmbNumber)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblHeading)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddPlayer"
        Me.Text = "Add Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents cmbBats As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cmbThrows As ComboBox
    Friend WithEvents cmbNumber As ComboBox
    Friend WithEvents lblBats As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblThrows As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
