Public Class Form2
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblID.Text = "Member ID: " & DataModule.IDAnggota
        lblDivisi.Text = "Division: " & DataModule.Divisi
        lblTelp.Text = "contact: " & DataModule.NoTelepon
        lblWeapon.Text = "Weapon: " & DataModule.Weapon

        picKartu.Image = Image.FromFile(DataModule.FotoProfil)
        picKartu.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class