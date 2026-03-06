Public Class Form1

    Private Sub RefreshDaftarBuku()
        ListBox.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            ListBox.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim judul As String = TextBoxTmbhJudul.Text
        Dim genre As String = TextBoxTambahgnre.Text

        If judul <> "" And genre <> "" Then
            TambahDataBuku(judul, genre)

            RefreshDaftarBuku()

            TextBoxTmbhJudul.Clear()
            TextBoxTambahgnre.Clear()
            TextBoxTmbhJudul.Focus()
        Else
            MessageBox.Show("Jangan dikosongin kocak", "Peringatan")
        End If
    End Sub


    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim judulHapus As String = TextBoxHpsJudul.Text

        If judulHapus <> "" Then
            Dim index As Integer = CariIndexBuku(judulHapus)

            If index <> -1 Then
                Dim statusHapus As Boolean = False

                HapusDataBuku(index, statusHapus)

                If statusHapus Then
                    RefreshDaftarBuku()
                    TextBoxHpsJudul.Clear()
                    MessageBox.Show("Data buku berhasil dihapus.", "Informasi")
                End If
            Else
                MessageBox.Show("Buku dengan judul tersebut tidak ditemukan di daftar.", "Gagal")
            End If
        Else
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan")
        End If
    End Sub

End Class