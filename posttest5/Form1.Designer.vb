<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        btnOpenQuest = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        btnClear = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        cmbSpecialization = New ComboBox()
        cmbRank = New ComboBox()
        txtRegion = New TextBox()
        txtLevel = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        Panel1.Controls.Add(btnOpenQuest)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1262, 80)
        Panel1.TabIndex = 0
        ' 
        ' btnOpenQuest
        ' 
        btnOpenQuest.BackColor = Color.FromArgb(CByte(180), CByte(120), CByte(255))
        btnOpenQuest.FlatStyle = FlatStyle.Flat
        btnOpenQuest.Location = New Point(1115, 5)
        btnOpenQuest.Name = "btnOpenQuest"
        btnOpenQuest.Size = New Size(135, 29)
        btnOpenQuest.TabIndex = 0
        btnOpenQuest.Text = "📜 Quest Log ▶"
        btnOpenQuest.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(60))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 20)
        Label1.TabIndex = 0
        Label1.Text = "⚔ HUNTER'S GUILD"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(742, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(520, 673)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleName = "dgvHunters"
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 215)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(520, 458)
        DataGridView1.TabIndex = 2
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(373, 150)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(16, 152)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(6, 85)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(502, 27)
        txtSearch.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnEdit)
        Panel3.Controls.Add(btnAdd)
        Panel3.Controls.Add(cmbSpecialization)
        Panel3.Controls.Add(cmbRank)
        Panel3.Controls.Add(txtRegion)
        Panel3.Controls.Add(txtLevel)
        Panel3.Controls.Add(txtName)
        Panel3.Controls.Add(txtID)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(742, 673)
        Panel3.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(220), CByte(60), CByte(80))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(550, 581)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(157, 29)
        btnDelete.TabIndex = 3
        btnDelete.Text = "✖ DELETE HUNTER"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(180), CByte(120), CByte(255))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Location = New Point(304, 581)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(158, 29)
        btnEdit.TabIndex = 3
        btnEdit.Text = "✎ UPDATE HUNTER"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(60), CByte(200), CByte(130))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(53, 581)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(139, 29)
        btnAdd.TabIndex = 3
        btnAdd.Text = "✚ ADD HUNTER"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' cmbSpecialization
        ' 
        cmbSpecialization.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        cmbSpecialization.FlatStyle = FlatStyle.Flat
        cmbSpecialization.ForeColor = Color.White
        cmbSpecialization.FormattingEnabled = True
        cmbSpecialization.Location = New Point(12, 295)
        cmbSpecialization.Name = "cmbSpecialization"
        cmbSpecialization.Size = New Size(695, 28)
        cmbSpecialization.TabIndex = 2
        ' 
        ' cmbRank
        ' 
        cmbRank.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        cmbRank.FlatStyle = FlatStyle.Flat
        cmbRank.ForeColor = Color.White
        cmbRank.FormattingEnabled = True
        cmbRank.Location = New Point(12, 215)
        cmbRank.Name = "cmbRank"
        cmbRank.Size = New Size(695, 28)
        cmbRank.TabIndex = 2
        ' 
        ' txtRegion
        ' 
        txtRegion.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtRegion.BorderStyle = BorderStyle.FixedSingle
        txtRegion.ForeColor = Color.White
        txtRegion.Location = New Point(12, 452)
        txtRegion.Name = "txtRegion"
        txtRegion.Size = New Size(695, 27)
        txtRegion.TabIndex = 1
        ' 
        ' txtLevel
        ' 
        txtLevel.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtLevel.BorderStyle = BorderStyle.FixedSingle
        txtLevel.ForeColor = Color.White
        txtLevel.Location = New Point(12, 380)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(695, 27)
        txtLevel.TabIndex = 1
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.ForeColor = Color.White
        txtName.Location = New Point(12, 152)
        txtName.Name = "txtName"
        txtName.Size = New Size(695, 27)
        txtName.TabIndex = 1
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.FromArgb(CByte(30), CByte(25), CByte(48))
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.ForeColor = Color.White
        txtID.Location = New Point(12, 85)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(695, 27)
        txtID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(60))
        Label2.Location = New Point(12, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 0
        Label2.Text = "HUNTER'S PROFILE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(12), CByte(10), CByte(20))
        ClientSize = New Size(1262, 753)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOpenQuest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbSpecialization As ComboBox
    Friend WithEvents cmbRank As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button

End Class
