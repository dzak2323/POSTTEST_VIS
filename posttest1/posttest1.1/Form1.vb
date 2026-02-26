Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim ipsBaru As Double


        If Double.TryParse(TextBoxIPS.Text, ipsBaru) Then


            If ipsBaru >= 0 AndAlso ipsBaru <= 4.0 Then

                totalIPS += ipsBaru
                jumlahSemester += 1


                Dim ipk As Double = totalIPS / jumlahSemester
                LabelIPK.Text = "IPK = " & ipk.ToString("F2")
                LabelSem.Text = "Semeseter sekarang = " & jumlahSemester




                If ipk >= 3.01 Then
                    LabelPredikat.Text = "Predikat: Sangat Memuaskan"
                ElseIf ipk >= 2.76 Then
                    LabelPredikat.Text = "Predikat: Memuaskan"
                ElseIf ipk >= 2.0 Then
                    LabelPredikat.Text = "Predikat: Cukup"
                Else
                    LabelPredikat.Text = "Predikat: Kurang"
                End If


                TextBoxIPS.Clear()
                TextBoxIPS.Focus()
            Else
                MessageBox.Show("Masukkan nilai IP Semester antara 0.00 hingga 4.00!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("tolong masukan angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        totalIPS = 0
        jumlahSemester = 0


        LabelIPK.Text = "IPK: 0.00"
        LabelPredikat.Text = "Predikat: -"


        TextBoxIPS.Clear()
        TextBoxIPS.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelIPK_Click(sender As Object, e As EventArgs) Handles LabelIPK.Click

    End Sub

    Private Sub TextBoxIPS_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPS.TextChanged

    End Sub
End Class