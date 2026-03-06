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
        TextBoxTmbhJudul = New TextBox()
        TextBoxHpsJudul = New TextBox()
        TextBoxTambahgnre = New TextBox()
        ButtonHapus = New Button()
        ButtonTambah = New Button()
        ListBox = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxTmbhJudul
        ' 
        TextBoxTmbhJudul.Location = New Point(120, 28)
        TextBoxTmbhJudul.Name = "TextBoxTmbhJudul"
        TextBoxTmbhJudul.Size = New Size(173, 27)
        TextBoxTmbhJudul.TabIndex = 0
        ' 
        ' TextBoxHpsJudul
        ' 
        TextBoxHpsJudul.Location = New Point(130, 28)
        TextBoxHpsJudul.Name = "TextBoxHpsJudul"
        TextBoxHpsJudul.Size = New Size(173, 27)
        TextBoxHpsJudul.TabIndex = 1
        ' 
        ' TextBoxTambahgnre
        ' 
        TextBoxTambahgnre.Location = New Point(120, 72)
        TextBoxTambahgnre.Name = "TextBoxTambahgnre"
        TextBoxTambahgnre.Size = New Size(173, 27)
        TextBoxTambahgnre.TabIndex = 2
        ' 
        ' ButtonHapus
        ' 
        ButtonHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonHapus.Location = New Point(116, 154)
        ButtonHapus.Name = "ButtonHapus"
        ButtonHapus.Size = New Size(119, 84)
        ButtonHapus.TabIndex = 3
        ButtonHapus.Text = "Hapus"
        ButtonHapus.UseVisualStyleBackColor = True
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonTambah.Location = New Point(91, 152)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(119, 86)
        ButtonTambah.TabIndex = 4
        ButtonTambah.Text = "Tambah"
        ButtonTambah.UseVisualStyleBackColor = True
        ' 
        ' ListBox
        ' 
        ListBox.BackColor = SystemColors.Info
        ListBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox.FormattingEnabled = True
        ListBox.Location = New Point(60, 295)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(681, 228)
        ListBox.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(8, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 6
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(3, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 7
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 8
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 23)
        Label4.TabIndex = 9
        Label4.Text = "Tambah Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 23)
        Label5.TabIndex = 10
        Label5.Text = "Hapus Buku"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ButtonTambah)
        Panel1.Controls.Add(TextBoxTmbhJudul)
        Panel1.Controls.Add(TextBoxTambahgnre)
        Panel1.Location = New Point(60, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 256)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Info
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBoxHpsJudul)
        Panel2.Controls.Add(ButtonHapus)
        Panel2.Location = New Point(435, 23)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(306, 256)
        Panel2.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(817, 551)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ListBox)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBoxTmbhJudul As TextBox
    Friend WithEvents TextBoxHpsJudul As TextBox
    Friend WithEvents TextBoxTambahgnre As TextBox
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class
