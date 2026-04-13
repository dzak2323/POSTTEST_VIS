Imports System.Windows.Forms

Public Class Form1
    ' Siapkan ErrorProvider dari Modul 5
    Private WithEvents ErrorProvider1 As New ErrorProvider()
    Private editingID As String = ""

    ' ── Saat Form Dimuat ──
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        ClearForm()

        ' Mempercantik warna tabel DataGridView1 bawaanmu agar bertema gelap
        DataGridView1.BackgroundColor = Color.FromArgb(12, 10, 20)
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 25, 48)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 22, 42)
    End Sub

    ' ── Refresh Tabel (MySQL) ──
    Private Sub RefreshGrid(Optional filter As String = "")
        If filter = "" Then
            DataGridView1.DataSource = DataModule.GetAllHunters()
        Else
            DataGridView1.DataSource = DataModule.SearchHunters(filter)
        End If
    End Sub

    ' ── Saat Tabel Diklik ──
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim r As DataGridViewRow = DataGridView1.CurrentRow

        ' Menarik data dari tabel ke TextBox
        txtID.Text = r.Cells("ID").Value?.ToString()
        txtName.Text = r.Cells("Name").Value?.ToString()
        cmbRank.SelectedItem = r.Cells("Rank").Value?.ToString()
        cmbSpecialization.SelectedItem = r.Cells("Specialization").Value?.ToString()
        txtLevel.Text = r.Cells("Level").Value?.ToString()
        txtRegion.Text = r.Cells("Region").Value?.ToString()

        editingID = txtID.Text
    End Sub

    ' ── TOMBOL TAMBAH ──
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not Validate_() Then Return
        Dim newID As String = DataModule.GenerateHunterID()

        If DataModule.SimpanHunter(newID, txtName.Text.Trim(), cmbRank.Text, cmbSpecialization.Text, CInt(txtLevel.Text), txtRegion.Text.Trim()) Then
            MessageBox.Show("Hunter berhasil disimpan ke MySQL!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            ClearForm()
        End If
    End Sub

    ' ── TOMBOL UBAH ──
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If editingID = "" Then
            MessageBox.Show("Pilih data di tabel dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Validate_() Then Return

        If DataModule.UbahHunter(editingID, txtName.Text.Trim(), cmbRank.Text, cmbSpecialization.Text, CInt(txtLevel.Text), txtRegion.Text.Trim()) Then
            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
        End If
    End Sub

    ' ── TOMBOL HAPUS ──
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If editingID = "" Then Return
        Dim ok = MessageBox.Show("Yakin ingin menghapus Hunter ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If ok = DialogResult.Yes Then
            If DataModule.HapusHunter(editingID) Then
                MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                ClearForm()
            End If
        End If
    End Sub

    ' ── TOMBOL PENCARIAN ──
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RefreshGrid(txtSearch.Text.Trim())
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        RefreshGrid()
        ClearForm()
    End Sub

    ' ── TOMBOL PINDAH FORM ──
    Private Sub btnOpenQuest_Click(sender As Object, e As EventArgs) Handles btnOpenQuest.Click
        ' Jika nama form keduamu bukan Form2, silakan ganti tulisannya di bawah ini
        ' Form2.Show()
    End Sub

    ' ── Validasi Input (Modul 5) ──
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        ValidationModule.HanyaHuruf(e)
    End Sub

    Private Sub txtLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLevel.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Function Validate_() As Boolean
        ErrorProvider1.Clear()
        Dim v1 As Boolean = ValidationModule.ValidasiTextBox(ErrorProvider1, txtName, "Wajib diisi!")
        Dim v2 As Boolean = ValidationModule.ValidasiTextBox(ErrorProvider1, txtLevel, "Wajib diisi!")

        If Not (v1 And v2) OrElse String.IsNullOrWhiteSpace(cmbRank.Text) Then
            MessageBox.Show("Isi semua data yang penting!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        txtID.Clear()
        txtName.Clear()
        cmbRank.SelectedIndex = -1
        cmbSpecialization.SelectedIndex = -1
        txtLevel.Clear()
        txtRegion.Clear()
        editingID = ""
        ErrorProvider1.Clear()
    End Sub
End Class