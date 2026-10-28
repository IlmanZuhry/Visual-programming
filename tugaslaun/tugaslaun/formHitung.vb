Public Class formHitung
    Private Sub txtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBerat.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStat.SelectedIndex = 0
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtBerat.Clear()
        cmbStat.SelectedIndex = 0
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim berat As Double
        Dim hargaPerKg As Double = 7000
        Dim hargaLaundry As Double
        Dim diskon As Double
        Dim potongan As Double
        Dim totalBayar As Double

        If Not Double.TryParse(txtBerat.Text, berat) Then
            MessageBox.Show("Masukkan berat laundry terlebih dahulu!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtBerat.Focus()
            Exit Sub
        End If

        If berat <= 0 Then
            MessageBox.Show("Berat laundry harus lebih dari 0 kg!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtBerat.Focus()
            Exit Sub
        End If

        hargaLaundry = berat * hargaPerKg


        If berat < 6 Then
            diskon = 0

        ElseIf cmbStat.Text = "Member" Then
            diskon = 0.15

        Else
            diskon = 0.1

        End If

        potongan = hargaLaundry * diskon
        totalBayar = hargaLaundry - potongan

        MessageBox.Show(
            "Berat Laundry : " & berat.ToString("0.##") & " Kg" & vbCrLf &
            "Status         : " & cmbStat.Text & vbCrLf &
            "--------------------------------" & vbCrLf &
            "Harga Laundry  : Rp " & hargaLaundry.ToString("N0") & vbCrLf &
            "Diskon         : " & (diskon * 100).ToString("0") & "%" & vbCrLf &
            "Potongan       : Rp " & potongan.ToString("N0") & vbCrLf &
            "Total Bayar    : Rp " & totalBayar.ToString("N0"),
            "Hasil Perhitungan Laundry",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub
End Class
