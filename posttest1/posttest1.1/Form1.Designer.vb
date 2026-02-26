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
        Label1 = New Label()
        LabelIPK = New Label()
        LabelPredikat = New Label()
        TextBoxIPS = New TextBox()
        ButtonTambah = New Button()
        ButtonReset = New Button()
        LabelSem = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(368, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 54)
        Label1.TabIndex = 0
        Label1.Text = "Penghitung IPK"
        ' 
        ' LabelIPK
        ' 
        LabelIPK.AutoSize = True
        LabelIPK.BackColor = Color.White
        LabelIPK.ForeColor = SystemColors.ActiveCaptionText
        LabelIPK.Location = New Point(349, 340)
        LabelIPK.Name = "LabelIPK"
        LabelIPK.Size = New Size(37, 20)
        LabelIPK.TabIndex = 1
        LabelIPK.Text = "IPK: "
        ' 
        ' LabelPredikat
        ' 
        LabelPredikat.AutoSize = True
        LabelPredikat.BackColor = Color.White
        LabelPredikat.ForeColor = SystemColors.ActiveCaptionText
        LabelPredikat.Location = New Point(615, 340)
        LabelPredikat.Name = "LabelPredikat"
        LabelPredikat.Size = New Size(63, 20)
        LabelPredikat.TabIndex = 2
        LabelPredikat.Text = "Predikat"
        ' 
        ' TextBoxIPS
        ' 
        TextBoxIPS.Location = New Point(441, 209)
        TextBoxIPS.Name = "TextBoxIPS"
        TextBoxIPS.Size = New Size(125, 27)
        TextBoxIPS.TabIndex = 3
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.Location = New Point(349, 279)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(94, 29)
        ButtonTambah.TabIndex = 4
        ButtonTambah.Text = "tambah"
        ButtonTambah.UseVisualStyleBackColor = True
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Location = New Point(574, 279)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(94, 29)
        ButtonReset.TabIndex = 5
        ButtonReset.Text = "Reset"
        ButtonReset.UseVisualStyleBackColor = True
        ' 
        ' LabelSem
        ' 
        LabelSem.AutoSize = True
        LabelSem.BackColor = Color.White
        LabelSem.ForeColor = SystemColors.ActiveCaptionText
        LabelSem.Location = New Point(476, 363)
        LabelSem.Name = "LabelSem"
        LabelSem.Size = New Size(99, 20)
        LabelSem.TabIndex = 6
        LabelSem.Text = "SemSekarang"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1159, 666)
        Controls.Add(LabelSem)
        Controls.Add(ButtonReset)
        Controls.Add(ButtonTambah)
        Controls.Add(TextBoxIPS)
        Controls.Add(LabelPredikat)
        Controls.Add(LabelIPK)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelIPK As Label
    Friend WithEvents LabelPredikat As Label
    Friend WithEvents TextBoxIPS As TextBox
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents LabelSem As Label

End Class
