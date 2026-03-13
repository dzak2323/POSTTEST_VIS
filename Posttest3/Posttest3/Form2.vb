Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.umur
        lbltLahir.Text = DataModule.Tglahir
        lblJk.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi
        lblNotelp.Text = DataModule.Notelpon
        PictureBox1.Image = Image.FromFile(DataModule.Foto)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblNotelp_Click(sender As Object, e As EventArgs) Handles lblNotelp.Click

    End Sub

    Private Sub lbltLahir_Click(sender As Object, e As EventArgs) Handles lbltLahir.Click

    End Sub
End Class