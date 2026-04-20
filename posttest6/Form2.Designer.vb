<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        cmbQType = New ComboBox()
        cmbQDifficulty = New ComboBox()
        txtQID = New TextBox()
        txtQTitle = New TextBox()
        txtQReward = New TextBox()
        txtQLocation = New TextBox()
        cmbQStatus = New ComboBox()
        txtQDesc = New TextBox()
        btnAddQ = New Button()
        btnEditQ = New Button()
        btnDeleteQ = New Button()
        txtSearchQ = New TextBox()
        btnSearchQ = New Button()
        btnClearQ = New Button()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(18), CByte(35))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1472, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(60))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 0
        Label1.Text = " QUEST LOG"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(22), CByte(18), CByte(35))
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(1152, 125)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(320, 610)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(btnDeleteQ)
        Panel3.Controls.Add(btnEditQ)
        Panel3.Controls.Add(btnClearQ)
        Panel3.Controls.Add(btnSearchQ)
        Panel3.Controls.Add(btnAddQ)
        Panel3.Controls.Add(cmbQStatus)
        Panel3.Controls.Add(cmbQType)
        Panel3.Controls.Add(cmbQDifficulty)
        Panel3.Controls.Add(txtQDesc)
        Panel3.Controls.Add(txtQLocation)
        Panel3.Controls.Add(txtSearchQ)
        Panel3.Controls.Add(txtQReward)
        Panel3.Controls.Add(txtQID)
        Panel3.Controls.Add(txtQTitle)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 125)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1152, 610)
        Panel3.TabIndex = 2
        ' 
        ' cmbQType
        ' 
        cmbQType.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        cmbQType.FormattingEnabled = True
        cmbQType.Items.AddRange(New Object() {"Monster Hunt", "Gathering", "Exploring", "Escort"})
        cmbQType.Location = New Point(12, 240)
        cmbQType.Name = "cmbQType"
        cmbQType.Size = New Size(151, 28)
        cmbQType.TabIndex = 2
        ' 
        ' cmbQDifficulty
        ' 
        cmbQDifficulty.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        cmbQDifficulty.FormattingEnabled = True
        cmbQDifficulty.Items.AddRange(New Object() {"S-Ranks", "A-Ranks", "B-Ranks", "C-Ranks", "D-Ranks", "E-Ranks", "Kentangs"})
        cmbQDifficulty.Location = New Point(12, 177)
        cmbQDifficulty.Name = "cmbQDifficulty"
        cmbQDifficulty.Size = New Size(151, 28)
        cmbQDifficulty.TabIndex = 2
        ' 
        ' txtQID
        ' 
        txtQID.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtQID.BorderStyle = BorderStyle.FixedSingle
        txtQID.Location = New Point(12, 48)
        txtQID.Name = "txtQID"
        txtQID.ReadOnly = True
        txtQID.Size = New Size(125, 27)
        txtQID.TabIndex = 1
        ' 
        ' txtQTitle
        ' 
        txtQTitle.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtQTitle.BorderStyle = BorderStyle.FixedSingle
        txtQTitle.Location = New Point(12, 107)
        txtQTitle.Name = "txtQTitle"
        txtQTitle.Size = New Size(125, 27)
        txtQTitle.TabIndex = 0
        ' 
        ' txtQReward
        ' 
        txtQReward.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtQReward.BorderStyle = BorderStyle.FixedSingle
        txtQReward.Location = New Point(277, 48)
        txtQReward.Name = "txtQReward"
        txtQReward.ReadOnly = True
        txtQReward.Size = New Size(279, 27)
        txtQReward.TabIndex = 1
        ' 
        ' txtQLocation
        ' 
        txtQLocation.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtQLocation.BorderStyle = BorderStyle.FixedSingle
        txtQLocation.Location = New Point(277, 107)
        txtQLocation.Name = "txtQLocation"
        txtQLocation.ReadOnly = True
        txtQLocation.Size = New Size(279, 27)
        txtQLocation.TabIndex = 1
        ' 
        ' cmbQStatus
        ' 
        cmbQStatus.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        cmbQStatus.FormattingEnabled = True
        cmbQStatus.Items.AddRange(New Object() {"Available", "In Progress", "completed", "failed", "cancelled"})
        cmbQStatus.Location = New Point(12, 313)
        cmbQStatus.Name = "cmbQStatus"
        cmbQStatus.Size = New Size(151, 28)
        cmbQStatus.TabIndex = 2
        ' 
        ' txtQDesc
        ' 
        txtQDesc.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtQDesc.BorderStyle = BorderStyle.FixedSingle
        txtQDesc.Location = New Point(277, 178)
        txtQDesc.Multiline = True
        txtQDesc.Name = "txtQDesc"
        txtQDesc.ReadOnly = True
        txtQDesc.Size = New Size(279, 163)
        txtQDesc.TabIndex = 1
        ' 
        ' btnAddQ
        ' 
        btnAddQ.BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(130))
        btnAddQ.FlatStyle = FlatStyle.Flat
        btnAddQ.Location = New Point(15, 385)
        btnAddQ.Name = "btnAddQ"
        btnAddQ.Size = New Size(86, 32)
        btnAddQ.TabIndex = 3
        btnAddQ.Text = "Tambah"
        btnAddQ.UseVisualStyleBackColor = False
        ' 
        ' btnEditQ
        ' 
        btnEditQ.BackColor = Color.FromArgb(CByte(255), CByte(140), CByte(60))
        btnEditQ.FlatStyle = FlatStyle.Flat
        btnEditQ.Location = New Point(240, 385)
        btnEditQ.Name = "btnEditQ"
        btnEditQ.Size = New Size(86, 32)
        btnEditQ.TabIndex = 3
        btnEditQ.Text = "Edit"
        btnEditQ.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteQ
        ' 
        btnDeleteQ.BackColor = Color.FromArgb(CByte(220), CByte(60), CByte(80))
        btnDeleteQ.FlatStyle = FlatStyle.Flat
        btnDeleteQ.Location = New Point(470, 385)
        btnDeleteQ.Name = "btnDeleteQ"
        btnDeleteQ.Size = New Size(86, 32)
        btnDeleteQ.TabIndex = 3
        btnDeleteQ.Text = "Delete"
        btnDeleteQ.UseVisualStyleBackColor = False
        ' 
        ' txtSearchQ
        ' 
        txtSearchQ.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtSearchQ.BorderStyle = BorderStyle.FixedSingle
        txtSearchQ.Location = New Point(657, 48)
        txtSearchQ.Name = "txtSearchQ"
        txtSearchQ.ReadOnly = True
        txtSearchQ.Size = New Size(355, 27)
        txtSearchQ.TabIndex = 1
        ' 
        ' btnSearchQ
        ' 
        btnSearchQ.BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(130))
        btnSearchQ.FlatStyle = FlatStyle.Flat
        btnSearchQ.Location = New Point(657, 107)
        btnSearchQ.Name = "btnSearchQ"
        btnSearchQ.Size = New Size(86, 32)
        btnSearchQ.TabIndex = 3
        btnSearchQ.Text = "cari"
        btnSearchQ.UseVisualStyleBackColor = False
        ' 
        ' btnClearQ
        ' 
        btnClearQ.BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(130))
        btnClearQ.FlatStyle = FlatStyle.Flat
        btnClearQ.Location = New Point(926, 107)
        btnClearQ.Name = "btnClearQ"
        btnClearQ.Size = New Size(86, 32)
        btnClearQ.TabIndex = 3
        btnClearQ.Text = "bersihkan"
        btnClearQ.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(657, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(367, 309)
        DataGridView1.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1472, 735)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtQTitle As TextBox
    Friend WithEvents txtQID As TextBox
    Friend WithEvents cmbQType As ComboBox
    Friend WithEvents cmbQDifficulty As ComboBox
    Friend WithEvents txtQLocation As TextBox
    Friend WithEvents txtQReward As TextBox
    Friend WithEvents btnDeleteQ As Button
    Friend WithEvents btnEditQ As Button
    Friend WithEvents btnAddQ As Button
    Friend WithEvents cmbQStatus As ComboBox
    Friend WithEvents txtQDesc As TextBox
    Friend WithEvents txtSearchQ As TextBox
    Friend WithEvents btnClearQ As Button
    Friend WithEvents btnSearchQ As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
