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
        pbprofil = New PictureBox()
        GroupBox1 = New GroupBox()
        rbbetina = New RadioButton()
        rbjantan = New RadioButton()
        GroupBox2 = New GroupBox()
        cbbaca = New CheckBox()
        cbbake = New CheckBox()
        cbmasak = New CheckBox()
        cbmelamun = New CheckBox()
        cbgambar = New CheckBox()
        cbdesain = New CheckBox()
        cbngoding = New CheckBox()
        cbturu = New CheckBox()
        cbjim = New CheckBox()
        cbjogging = New CheckBox()
        cbgame = New CheckBox()
        cbmancing = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNo = New TextBox()
        txtAlamat = New TextBox()
        dtpLahir = New DateTimePicker()
        btnCetak = New Button()
        btnGambar = New Button()
        Label6 = New Label()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        CType(pbprofil, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbprofil
        ' 
        pbprofil.Location = New Point(12, 12)
        pbprofil.Name = "pbprofil"
        pbprofil.Size = New Size(304, 442)
        pbprofil.TabIndex = 0
        pbprofil.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbbetina)
        GroupBox1.Controls.Add(rbjantan)
        GroupBox1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(55, 326)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(287, 234)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbbetina
        ' 
        rbbetina.AutoSize = True
        rbbetina.Location = New Point(6, 119)
        rbbetina.Name = "rbbetina"
        rbbetina.Size = New Size(83, 24)
        rbbetina.TabIndex = 1
        rbbetina.TabStop = True
        rbbetina.Text = "Wanita"
        rbbetina.UseVisualStyleBackColor = True
        ' 
        ' rbjantan
        ' 
        rbjantan.AutoSize = True
        rbjantan.Location = New Point(6, 52)
        rbjantan.Name = "rbjantan"
        rbjantan.Size = New Size(59, 24)
        rbjantan.TabIndex = 0
        rbjantan.TabStop = True
        rbjantan.Text = "Pria"
        rbjantan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbbaca)
        GroupBox2.Controls.Add(cbbake)
        GroupBox2.Controls.Add(cbmasak)
        GroupBox2.Controls.Add(cbmelamun)
        GroupBox2.Controls.Add(cbgambar)
        GroupBox2.Controls.Add(cbdesain)
        GroupBox2.Controls.Add(cbngoding)
        GroupBox2.Controls.Add(cbturu)
        GroupBox2.Controls.Add(cbjim)
        GroupBox2.Controls.Add(cbjogging)
        GroupBox2.Controls.Add(cbgame)
        GroupBox2.Controls.Add(cbmancing)
        GroupBox2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        GroupBox2.Location = New Point(348, 326)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(365, 234)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobi "
        ' 
        ' cbbaca
        ' 
        cbbaca.AutoSize = True
        cbbaca.Location = New Point(236, 193)
        cbbaca.Name = "cbbaca"
        cbbaca.Size = New Size(108, 24)
        cbbaca.TabIndex = 11
        cbbaca.Text = "baca buku"
        cbbaca.UseVisualStyleBackColor = True
        ' 
        ' cbbake
        ' 
        cbbake.AutoSize = True
        cbbake.Location = New Point(236, 138)
        cbbake.Name = "cbbake"
        cbbake.Size = New Size(109, 24)
        cbbake.TabIndex = 10
        cbbake.Text = "Masak kue"
        cbbake.UseVisualStyleBackColor = True
        ' 
        ' cbmasak
        ' 
        cbmasak.AutoSize = True
        cbmasak.Location = New Point(236, 85)
        cbmasak.Name = "cbmasak"
        cbmasak.Size = New Size(78, 24)
        cbmasak.TabIndex = 9
        cbmasak.Text = "Masak"
        cbmasak.UseVisualStyleBackColor = True
        ' 
        ' cbmelamun
        ' 
        cbmelamun.AutoSize = True
        cbmelamun.Location = New Point(236, 26)
        cbmelamun.Name = "cbmelamun"
        cbmelamun.Size = New Size(100, 24)
        cbmelamun.TabIndex = 8
        cbmelamun.Text = "Melamun"
        cbmelamun.UseVisualStyleBackColor = True
        ' 
        ' cbgambar
        ' 
        cbgambar.AutoSize = True
        cbgambar.Location = New Point(115, 193)
        cbgambar.Name = "cbgambar"
        cbgambar.Size = New Size(90, 24)
        cbgambar.TabIndex = 7
        cbgambar.Text = "Gambar"
        cbgambar.UseVisualStyleBackColor = True
        ' 
        ' cbdesain
        ' 
        cbdesain.AutoSize = True
        cbdesain.Location = New Point(115, 138)
        cbdesain.Name = "cbdesain"
        cbdesain.Size = New Size(82, 24)
        cbdesain.TabIndex = 6
        cbdesain.Text = "Desain"
        cbdesain.UseVisualStyleBackColor = True
        ' 
        ' cbngoding
        ' 
        cbngoding.AutoSize = True
        cbngoding.Location = New Point(115, 85)
        cbngoding.Name = "cbngoding"
        cbngoding.Size = New Size(97, 24)
        cbngoding.TabIndex = 5
        cbngoding.Text = "Ngoding"
        cbngoding.UseVisualStyleBackColor = True
        ' 
        ' cbturu
        ' 
        cbturu.AutoSize = True
        cbturu.Location = New Point(115, 26)
        cbturu.Name = "cbturu"
        cbturu.Size = New Size(70, 24)
        cbturu.TabIndex = 4
        cbturu.Text = "Tidur"
        cbturu.UseVisualStyleBackColor = True
        ' 
        ' cbjim
        ' 
        cbjim.AutoSize = True
        cbjim.Location = New Point(6, 193)
        cbjim.Name = "cbjim"
        cbjim.Size = New Size(56, 24)
        cbjim.TabIndex = 3
        cbjim.Text = "JIM"
        cbjim.UseVisualStyleBackColor = True
        ' 
        ' cbjogging
        ' 
        cbjogging.AutoSize = True
        cbjogging.Location = New Point(6, 138)
        cbjogging.Name = "cbjogging"
        cbjogging.Size = New Size(91, 24)
        cbjogging.TabIndex = 2
        cbjogging.Text = "Jogging"
        cbjogging.UseVisualStyleBackColor = True
        ' 
        ' cbgame
        ' 
        cbgame.AutoSize = True
        cbgame.Location = New Point(6, 85)
        cbgame.Name = "cbgame"
        cbgame.Size = New Size(73, 24)
        cbgame.TabIndex = 1
        cbgame.Text = "game"
        cbgame.UseVisualStyleBackColor = True
        ' 
        ' cbmancing
        ' 
        cbmancing.AutoSize = True
        cbmancing.Location = New Point(6, 26)
        cbmancing.Name = "cbmancing"
        cbmancing.Size = New Size(95, 24)
        cbmancing.TabIndex = 0
        cbmancing.Text = "Mancing"
        cbmancing.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label1.Location = New Point(28, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama sampean"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label2.Location = New Point(43, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label3.Location = New Point(43, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label4.Location = New Point(43, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 6
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Label5.Location = New Point(43, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 7
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(176, 20)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(174, 74)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(250, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(174, 198)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(250, 27)
        txtNo.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(174, 266)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(250, 27)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(174, 139)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(250, 27)
        dtpLahir.TabIndex = 12
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(12, 507)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(304, 29)
        btnCetak.TabIndex = 13
        btnCetak.Text = "Cetak kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnGambar
        ' 
        btnGambar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnGambar.Location = New Point(525, 238)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(169, 73)
        btnGambar.TabIndex = 14
        btnGambar.Text = "Aplod"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(534, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnGambar)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(538, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(716, 572)
        Panel1.TabIndex = 16
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackgroundImageLayout = ImageLayout.None
        GroupBox3.Controls.Add(dtpLahir)
        GroupBox3.Controls.Add(txtAlamat)
        GroupBox3.Controls.Add(txtNo)
        GroupBox3.Controls.Add(txtUmur)
        GroupBox3.Controls.Add(txtNama)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(55, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(426, 308)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Data Pribadi"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1266, 600)
        Controls.Add(Panel1)
        Controls.Add(btnCetak)
        Controls.Add(pbprofil)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(pbprofil, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbprofil As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbbetina As RadioButton
    Friend WithEvents rbjantan As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbmasak As CheckBox
    Friend WithEvents cbmelamun As CheckBox
    Friend WithEvents cbgambar As CheckBox
    Friend WithEvents cbdesain As CheckBox
    Friend WithEvents cbngoding As CheckBox
    Friend WithEvents cbturu As CheckBox
    Friend WithEvents cbjim As CheckBox
    Friend WithEvents cbjogging As CheckBox
    Friend WithEvents cbgame As CheckBox
    Friend WithEvents cbmancing As CheckBox
    Friend WithEvents cbbaca As CheckBox
    Friend WithEvents cbbake As CheckBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox

End Class
