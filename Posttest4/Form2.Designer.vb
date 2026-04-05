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
        picKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblDivisi = New Label()
        lblTelp = New Label()
        lblWeapon = New Label()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picKartu
        ' 
        picKartu.BackgroundImageLayout = ImageLayout.Zoom
        picKartu.Location = New Point(43, 102)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(190, 251)
        picKartu.TabIndex = 0
        picKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Viner Hand ITC", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(323, 102)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(67, 29)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(323, 171)
        lblID.Name = "lblID"
        lblID.Size = New Size(63, 18)
        lblID.TabIndex = 2
        lblID.Text = "Label1"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDivisi.Location = New Point(323, 232)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(63, 18)
        lblDivisi.TabIndex = 3
        lblDivisi.Text = "Label1"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelp.Location = New Point(323, 282)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(63, 18)
        lblTelp.TabIndex = 4
        lblTelp.Text = "Label1"
        ' 
        ' lblWeapon
        ' 
        lblWeapon.AutoSize = True
        lblWeapon.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeapon.Location = New Point(323, 335)
        lblWeapon.Name = "lblWeapon"
        lblWeapon.Size = New Size(63, 18)
        lblWeapon.TabIndex = 5
        lblWeapon.Text = "Label1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(lblWeapon)
        Controls.Add(lblTelp)
        Controls.Add(lblDivisi)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(picKartu)
        Name = "Form2"
        Text = "Form2"
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblWeapon As Label
End Class
