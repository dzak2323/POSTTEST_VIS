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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        menuInputData = New ToolStripMenuItem()
        menuLihatKartu = New ToolStripMenuItem()
        menuSimpanData = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tabDataUtama = New TabPage()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        lblnama = New Label()
        GroupBox1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        cboDivisi = New ComboBox()
        dtpTglLahir = New DateTimePicker()
        txtId = New TextBox()
        txtNama = New TextBox()
        tabKontakInfo = New TabPage()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelp = New MaskedTextBox()
        tabProfilAktivitas = New TabPage()
        PictureBox6 = New PictureBox()
        grupPeran = New GroupBox()
        rbHelper = New RadioButton()
        rbStaff = New RadioButton()
        rbLeader = New RadioButton()
        grpWeapon = New GroupBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        btnSimpanCetak = New Button()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tabDataUtama.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        tabKontakInfo.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        tabProfilAktivitas.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        grupPeran.SuspendLayout()
        grpWeapon.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInputData, menuLihatKartu, menuSimpanData, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuInputData
        ' 
        menuInputData.Name = "menuInputData"
        menuInputData.Size = New Size(57, 24)
        menuInputData.Text = "Input"
        ' 
        ' menuLihatKartu
        ' 
        menuLihatKartu.Name = "menuLihatKartu"
        menuLihatKartu.Size = New Size(54, 24)
        menuLihatKartu.Text = "Card"
        ' 
        ' menuSimpanData
        ' 
        menuSimpanData.Name = "menuSimpanData"
        menuSimpanData.Size = New Size(54, 24)
        menuSimpanData.Text = "Save"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(45, 24)
        menuKeluar.Text = "out"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabDataUtama)
        TabControl1.Controls.Add(tabKontakInfo)
        TabControl1.Controls.Add(tabProfilAktivitas)
        TabControl1.Location = New Point(0, 31)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 407)
        TabControl1.TabIndex = 1
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = Color.SaddleBrown
        tabDataUtama.Controls.Add(PictureBox4)
        tabDataUtama.Controls.Add(Label4)
        tabDataUtama.Controls.Add(Label3)
        tabDataUtama.Controls.Add(Label2)
        tabDataUtama.Controls.Add(lblnama)
        tabDataUtama.Controls.Add(GroupBox1)
        tabDataUtama.Controls.Add(cboDivisi)
        tabDataUtama.Controls.Add(dtpTglLahir)
        tabDataUtama.Controls.Add(txtId)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Location = New Point(4, 29)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(792, 374)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Main Data"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(702, 6)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(82, 64)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(15, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 18)
        Label4.TabIndex = 10
        Label4.Text = "Birth Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(40, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 18)
        Label3.TabIndex = 9
        Label3.Text = "Division"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(40, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 18)
        Label2.TabIndex = 8
        Label2.Text = "ID"
        ' 
        ' lblnama
        ' 
        lblnama.AutoSize = True
        lblnama.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        lblnama.ForeColor = Color.Gold
        lblnama.Location = New Point(40, 86)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(56, 18)
        lblnama.TabIndex = 7
        lblnama.Text = "Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.Gold
        GroupBox1.Location = New Point(383, 146)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        rbPerempuan.Location = New Point(20, 60)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(93, 27)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Woman"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        rbLaki.Location = New Point(20, 30)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(66, 27)
        rbLaki.TabIndex = 4
        rbLaki.TabStop = True
        rbLaki.Text = "Man"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' cboDivisi
        ' 
        cboDivisi.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        cboDivisi.FormattingEnabled = True
        cboDivisi.Items.AddRange(New Object() {"Field Hunter", "Field Researcher", "Researcher", "Botanist", "Armory", "Cooks"})
        cboDivisi.Location = New Point(140, 206)
        cboDivisi.Name = "cboDivisi"
        cboDivisi.Size = New Size(200, 26)
        cboDivisi.TabIndex = 3
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        dtpTglLahir.Location = New Point(140, 286)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(250, 30)
        dtpTglLahir.TabIndex = 2
        ' 
        ' txtId
        ' 
        txtId.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        txtId.Location = New Point(140, 146)
        txtId.Name = "txtId"
        txtId.Size = New Size(200, 26)
        txtId.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        txtNama.Location = New Point(140, 86)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 26)
        txtNama.TabIndex = 0
        ' 
        ' tabKontakInfo
        ' 
        tabKontakInfo.BackColor = Color.SaddleBrown
        tabKontakInfo.Controls.Add(PictureBox5)
        tabKontakInfo.Controls.Add(Label7)
        tabKontakInfo.Controls.Add(Label6)
        tabKontakInfo.Controls.Add(Label5)
        tabKontakInfo.Controls.Add(txtAlamat)
        tabKontakInfo.Controls.Add(txtEmail)
        tabKontakInfo.Controls.Add(mtbTelp)
        tabKontakInfo.Location = New Point(4, 29)
        tabKontakInfo.Name = "tabKontakInfo"
        tabKontakInfo.Padding = New Padding(3)
        tabKontakInfo.Size = New Size(792, 374)
        tabKontakInfo.TabIndex = 1
        tabKontakInfo.Text = "Contact"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(704, 6)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(82, 64)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 17
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Gold
        Label7.Location = New Point(21, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 18)
        Label7.TabIndex = 5
        Label7.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label6.ForeColor = Color.Gold
        Label6.Location = New Point(21, 107)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 18)
        Label6.TabIndex = 4
        Label6.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(21, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 18)
        Label5.TabIndex = 3
        Label5.Text = "Phone Number"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Verdana", 9.0F)
        txtAlamat.Location = New Point(181, 167)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(300, 80)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Verdana", 9.0F)
        txtEmail.Location = New Point(181, 107)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 26)
        txtEmail.TabIndex = 1
        ' 
        ' mtbTelp
        ' 
        mtbTelp.Font = New Font("Verdana", 9.0F)
        mtbTelp.Location = New Point(181, 47)
        mtbTelp.Mask = "0000-0000-0000"
        mtbTelp.Name = "mtbTelp"
        mtbTelp.Size = New Size(250, 26)
        mtbTelp.TabIndex = 0
        ' 
        ' tabProfilAktivitas
        ' 
        tabProfilAktivitas.BackColor = Color.SaddleBrown
        tabProfilAktivitas.Controls.Add(PictureBox6)
        tabProfilAktivitas.Controls.Add(grupPeran)
        tabProfilAktivitas.Controls.Add(grpWeapon)
        tabProfilAktivitas.Controls.Add(btnSimpanCetak)
        tabProfilAktivitas.Controls.Add(btnBrowse)
        tabProfilAktivitas.Controls.Add(picProfil)
        tabProfilAktivitas.Location = New Point(4, 29)
        tabProfilAktivitas.Name = "tabProfilAktivitas"
        tabProfilAktivitas.Padding = New Padding(3)
        tabProfilAktivitas.Size = New Size(792, 374)
        tabProfilAktivitas.TabIndex = 2
        tabProfilAktivitas.Text = "Profile"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(704, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(82, 64)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 16
        PictureBox6.TabStop = False
        ' 
        ' grupPeran
        ' 
        grupPeran.Controls.Add(rbHelper)
        grupPeran.Controls.Add(rbStaff)
        grupPeran.Controls.Add(rbLeader)
        grupPeran.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        grupPeran.ForeColor = Color.Gold
        grupPeran.Location = New Point(209, 73)
        grupPeran.Name = "grupPeran"
        grupPeran.Size = New Size(200, 150)
        grupPeran.TabIndex = 15
        grupPeran.TabStop = False
        grupPeran.Text = "Role"
        ' 
        ' rbHelper
        ' 
        rbHelper.AutoSize = True
        rbHelper.Location = New Point(20, 100)
        rbHelper.Name = "rbHelper"
        rbHelper.Size = New Size(82, 22)
        rbHelper.TabIndex = 14
        rbHelper.TabStop = True
        rbHelper.Text = "Helper"
        rbHelper.UseVisualStyleBackColor = True
        ' 
        ' rbStaff
        ' 
        rbStaff.AutoSize = True
        rbStaff.Location = New Point(20, 65)
        rbStaff.Name = "rbStaff"
        rbStaff.Size = New Size(69, 22)
        rbStaff.TabIndex = 13
        rbStaff.TabStop = True
        rbStaff.Text = "Staff"
        rbStaff.UseVisualStyleBackColor = True
        ' 
        ' rbLeader
        ' 
        rbLeader.AutoSize = True
        rbLeader.Location = New Point(20, 30)
        rbLeader.Name = "rbLeader"
        rbLeader.Size = New Size(137, 22)
        rbLeader.TabIndex = 12
        rbLeader.TabStop = True
        rbLeader.Text = "Team Leader"
        rbLeader.UseVisualStyleBackColor = True
        ' 
        ' grpWeapon
        ' 
        grpWeapon.Controls.Add(CheckBox8)
        grpWeapon.Controls.Add(CheckBox7)
        grpWeapon.Controls.Add(CheckBox6)
        grpWeapon.Controls.Add(CheckBox5)
        grpWeapon.Controls.Add(CheckBox4)
        grpWeapon.Controls.Add(CheckBox3)
        grpWeapon.Controls.Add(CheckBox2)
        grpWeapon.Controls.Add(CheckBox1)
        grpWeapon.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
        grpWeapon.ForeColor = Color.Gold
        grpWeapon.Location = New Point(429, 73)
        grpWeapon.Name = "grpWeapon"
        grpWeapon.Size = New Size(300, 200)
        grpWeapon.TabIndex = 11
        grpWeapon.TabStop = False
        grpWeapon.Text = "Weapon"
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(150, 135)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(72, 22)
        CheckBox8.TabIndex = 10
        CheckBox8.Text = "None"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(150, 100)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(121, 22)
        CheckBox7.TabIndex = 9
        CheckBox7.Text = "Switch Axe"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(150, 65)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(135, 22)
        CheckBox6.TabIndex = 8
        CheckBox6.Text = "Insect glaive"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(150, 30)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(95, 22)
        CheckBox5.TabIndex = 7
        CheckBox5.Text = "Bowgun"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(20, 135)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(65, 22)
        CheckBox4.TabIndex = 6
        CheckBox4.Text = "Bow"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(20, 100)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(124, 22)
        CheckBox3.TabIndex = 5
        CheckBox3.Text = "Dual blades"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(20, 65)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(126, 22)
        CheckBox2.TabIndex = 4
        CheckBox2.Text = "Greatsword"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(20, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(120, 22)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Longsword"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(529, 333)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(200, 35)
        btnSimpanCetak.TabIndex = 2
        btnSimpanCetak.Text = "Save && Print"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(19, 253)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(150, 30)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.BorderStyle = BorderStyle.FixedSingle
        picProfil.Location = New Point(19, 73)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(150, 170)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Guild's Card maker"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tabKontakInfo.ResumeLayout(False)
        tabKontakInfo.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        tabProfilAktivitas.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        grupPeran.ResumeLayout(False)
        grupPeran.PerformLayout()
        grpWeapon.ResumeLayout(False)
        grpWeapon.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInputData As ToolStripMenuItem
    Friend WithEvents menuLihatKartu As ToolStripMenuItem
    Friend WithEvents menuSimpanData As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Protected WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontakInfo As TabPage
    Friend WithEvents tabProfilAktivitas As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents mtbTelp As MaskedTextBox
    Friend WithEvents cboDivisi As ComboBox
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents grupPeran As GroupBox
    Friend WithEvents rbLeader As RadioButton
    Friend WithEvents rbStaff As RadioButton
    Friend WithEvents rbHelper As RadioButton
    Friend WithEvents grpWeapon As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox

End Class