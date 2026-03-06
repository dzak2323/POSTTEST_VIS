Public Module ModuleData

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0


    Public Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub


    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function


    Public Sub HapusDataBuku(ByVal index As Integer, ByRef status As Boolean)
        If index >= 0 And index < jumlahBuku Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            daftarBuku(jumlahBuku - 1, 0) = ""
            daftarBuku(jumlahBuku - 1, 1) = ""
            jumlahBuku -= 1

            status = True
        Else
            status = False
        End If
    End Sub
End Module