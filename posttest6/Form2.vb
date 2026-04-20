Imports System.Windows.Forms

Public Class Form2
    ' Siapkan ErrorProvider untuk validasi
    Private WithEvents ErrorProvider1 As New ErrorProvider()
    Private editingID As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        ClearForm()

        ' Mempercantik warna tabel DataGridView1
        DataGridView1.BackgroundColor = Color.FromArgb(12, 10, 20)
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 25, 48)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 22, 42)
    End Sub

    ' ── Refresh Tabel (MySQL) ──
    Private Sub RefreshGrid(Optional filter As String = "")
        If filter = "" Then
            DataGridView1.DataSource = DataModule.GetAllQuests()
        Else
            DataGridView1.DataSource = DataModule.SearchQuests(filter)
        End If
    End Sub

    ' ── Saat Tabel Diklik ──
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim r As DataGridViewRow = DataGridView1.CurrentRow

        txtQID.Text = r.Cells("ID").Value?.ToString()
        txtQTitle.Text = r.Cells("Title").Value?.ToString()
        cmbQDifficulty.SelectedItem = r.Cells("Difficulty").Value?.ToString()
        cmbQType.SelectedItem = r.Cells("Type").Value?.ToString()
        txtQReward.Text = r.Cells("Reward").Value?.ToString()
        txtQLocation.Text = r.Cells("Location").Value?.ToString()
        cmbQStatus.SelectedItem = r.Cells("Status").Value?.ToString()
        txtQDesc.Text = r.Cells("Description").Value?.ToString()

        editingID = txtQID.Text
    End Sub

    ' ── TOMBOL POST QUEST ──
    Private Sub btnAddQ_Click(sender As Object, e As EventArgs) Handles btnAddQ.Click
        If Not Validate_() Then Return
        Dim newID As String = DataModule.GenerateQuestID()

        If DataModule.SimpanQuest(newID, txtQTitle.Text.Trim(), cmbQDifficulty.Text, cmbQType.Text, txtQReward.Text.Trim(), txtQLocation.Text.Trim(), cmbQStatus.Text, txtQDesc.Text.Trim()) Then
            MessageBox.Show("Quest berhasil diposting!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            ClearForm()
        End If
    End Sub

    ' ── TOMBOL UPDATE ──
    Private Sub btnEditQ_Click(sender As Object, e As EventArgs) Handles btnEditQ.Click
        If editingID = "" Then
            MessageBox.Show("Pilih Quest di tabel dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Validate_() Then Return

        If DataModule.UbahQuest(editingID, txtQTitle.Text.Trim(), cmbQDifficulty.Text, cmbQType.Text, txtQReward.Text.Trim(), txtQLocation.Text.Trim(), cmbQStatus.Text, txtQDesc.Text.Trim()) Then
            MessageBox.Show("Quest berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
        End If
    End Sub

    ' ── TOMBOL REMOVE ──
    Private Sub btnDeleteQ_Click(sender As Object, e As EventArgs) Handles btnDeleteQ.Click
        If editingID = "" Then Return
        Dim ok = MessageBox.Show("Yakin ingin menghapus Quest ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If ok = DialogResult.Yes Then
            If DataModule.HapusQuest(editingID) Then
                MessageBox.Show("Quest berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                ClearForm()
            End If
        End If
    End Sub

    ' ── TOMBOL PENCARIAN ──
    Private Sub btnSearchQ_Click(sender As Object, e As EventArgs) Handles btnSearchQ.Click
        RefreshGrid(txtSearchQ.Text.Trim())
    End Sub

    Private Sub btnClearQ_Click(sender As Object, e As EventArgs) Handles btnClearQ.Click
        txtSearchQ.Clear()
        RefreshGrid()
        ClearForm()
    End Sub

    ' ── Validasi Input (Modul 5) ──
    Private Function Validate_() As Boolean
        ErrorProvider1.Clear()
        Dim v1 As Boolean = ValidationModule.ValidasiTextBox(ErrorProvider1, txtQTitle, "Judul Quest wajib diisi!")

        If Not v1 OrElse String.IsNullOrWhiteSpace(cmbQDifficulty.Text) OrElse String.IsNullOrWhiteSpace(cmbQType.Text) OrElse String.IsNullOrWhiteSpace(cmbQStatus.Text) Then
            MessageBox.Show("Isi semua data yang wajib!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        txtQID.Clear()
        txtQTitle.Clear()
        cmbQDifficulty.SelectedIndex = -1
        cmbQType.SelectedIndex = -1
        txtQReward.Clear()
        txtQLocation.Clear()
        cmbQStatus.SelectedIndex = -1
        txtQDesc.Clear()
        editingID = ""
        ErrorProvider1.Clear()
    End Sub

    Private Sub cmbQDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQDifficulty.SelectedIndexChanged

    End Sub

    Private Sub txtQReward_TextChanged(sender As Object, e As EventArgs) Handles txtQReward.TextChanged

    End Sub

    Private Sub btnAddQ_Click_1(sender As Object, e As EventArgs) Handles btnAddQ.Click, btnSearchQ.Click, btnClearQ.Click

    End Sub
End Class