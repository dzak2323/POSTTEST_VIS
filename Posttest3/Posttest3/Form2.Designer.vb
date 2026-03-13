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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lbltLahir = New Label()
        lblHobi = New Label()
        lblNotelp = New Label()
        lblJk = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(1, -9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 316)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = SystemColors.ControlLightLight
        lblNama.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(0, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(79, 31)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = SystemColors.ControlLightLight
        lblUmur.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(360, 220)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(60, 25)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lbltLahir
        ' 
        lbltLahir.AutoSize = True
        lbltLahir.BackColor = SystemColors.ControlLightLight
        lbltLahir.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltLahir.Location = New Point(261, 282)
        lbltLahir.Name = "lbltLahir"
        lbltLahir.Size = New Size(130, 25)
        lbltLahir.TabIndex = 3
        lbltLahir.Text = "Tanggal Lahir"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = SystemColors.ControlLightLight
        lblHobi.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobi.Location = New Point(284, 220)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(55, 25)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobi"
        ' 
        ' lblNotelp
        ' 
        lblNotelp.AutoSize = True
        lblNotelp.BackColor = SystemColors.ControlLightLight
        lblNotelp.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNotelp.Location = New Point(3, 4)
        lblNotelp.Name = "lblNotelp"
        lblNotelp.Size = New Size(129, 31)
        lblNotelp.TabIndex = 7
        lblNotelp.Text = "No Telpon"
        ' 
        ' lblJk
        ' 
        lblJk.AutoSize = True
        lblJk.BackColor = SystemColors.ControlLightLight
        lblJk.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJk.Location = New Point(609, 220)
        lblJk.Name = "lblJk"
        lblJk.Size = New Size(129, 25)
        lblJk.TabIndex = 5
        lblJk.Text = "Jenis Kelamin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 31)
        Label1.TabIndex = 8
        Label1.Text = "Alamat"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, -9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(817, 462)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblNama)
        Panel1.Location = New Point(1, 310)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(475, 143)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(388, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(51, 24)
        Panel2.TabIndex = 11
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblNotelp)
        Panel3.Location = New Point(379, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(253, 39)
        Panel3.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Controls.Add(lblHobi)
        Controls.Add(lblJk)
        Controls.Add(lbltLahir)
        Controls.Add(lblUmur)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lbltLahir As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblNotelp As Label
    Friend WithEvents lblJk As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
