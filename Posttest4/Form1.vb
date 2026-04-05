Imports System.IO

Public Class Form1



    Private Sub MenuInputData_Click(sender As Object, e As EventArgs) Handles menuInputData.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    Private Sub MenuLihatKartu_Click(sender As Object, e As EventArgs) Handles MenuLihatKartu.Click
        If ValidasiSemuaInput() Then
            SimpanDataKeModule()
            Form2.Show()
        End If
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim tanya As DialogResult = MessageBox.Show("Yakin ingin keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidasiSemuaInput() As Boolean
        ErrorProvider1.Clear()
        Dim status As Boolean = True

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong")
            status = False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) Then
            ErrorProvider1.SetError(txtID, "ID Anggota tidak boleh kosong")
            status = False
        End If

        If Not mtbTelp.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelp, "Format nomor telepon tidak lengkap")
            status = False
        End If

        Return status
    End Function

    Private Sub SimpanDataKeModule()
        DataModule.Nama = txtNama.Text
        DataModule.IDAnggota = txtId.Text
        DataModule.TglLahir = dtpTglLahir.Value
        DataModule.Divisi = cboDivisi.Text
        DataModule.NoTelepon = mtbTelp.Text
        DataModule.Email = txtEmail.Text
        DataModule.Alamat = txtAlamat.Text

        Dim grupJK() As RadioButton = {rbLaki, rbPerempuan}
        DataModule.JenisKelamin = DataModule.GetSelectedRadioButton(grupJK)

        Dim grupPeran() As RadioButton = {rbLeader, rbStaff, rbHelper}
        DataModule.Peran = DataModule.GetSelectedRadioButton(grupPeran)

        Dim listHobi() As CheckBox = grpWeapon.Controls.OfType(Of CheckBox)().ToArray()
        DataModule.Weapon = DataModule.GetSelectedCheckBox(listHobi)
    End Sub

    ' --- 4. FITUR OPEN & SAVE FILE (MODUL 4) ---

    ' Upload Foto Profil
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
            ' Menyimpan path foto ke module (opsional bisa kirim Image-nya langsung)
            DataModule.FotoProfil = OpenFileDialog1.FileName
        End If
    End Sub

    ' Simpan Data ke .txt atau .csv
    Private Sub MenuSimpanData_Click(sender As Object, e As EventArgs) Handles menuSimpanData.Click
        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim konten As String = $"KARTU ANGGOTA{vbCrLf}Nama: {txtNama.Text}{vbCrLf}ID: {txtID.Text}"
            File.WriteAllText(SaveFileDialog1.FileName, konten)
            MessageBox.Show("Data berhasil disimpan ke file!")
        End If
    End Sub

    ' --- 5. TOMBOL PROSES AKHIR ---
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiSemuaInput() Then
            Dim konfirmasi As DialogResult = MessageBox.Show("Simpan dan cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                SimpanDataKeModule()
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class