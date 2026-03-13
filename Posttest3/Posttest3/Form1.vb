Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Private Function CekData() As Boolean
        grupHobi = {cbgame, cbbaca, cbmancing, cbbake, cbgambar, cbjim, cbmasak, cbturu, cbmelamun, cbdesain, cbngoding, cbjogging}
        grupJK = {rbjantan, rbbetina}
        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtNo, "No Telepon Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(pbprofil, "Gambar Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {cbGame, cbBaca, cbMancing}
            grupJK = {rbjantan, rbbetina}
            Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(grupJK)
            DataModule.Nama = txtNama.Text
            DataModule.umur = txtUmur.Text
            DataModule.alamat = txtAlamat.Text
            DataModule.Notelpon = txtNo.Text
            DataModule.Hobi = Hobi_Selected
            DataModule.JK = jk_Selected
            DataModule.Tglahir = dtpLahir.Value.ToShortDateString()
            Form2.Show()
        End If
    End Sub

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
        If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                pbprofil.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress, txtAlamat.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNo.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGambar.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class