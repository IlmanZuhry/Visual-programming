
Option Strict On

Imports System.IO

Public Class FrmPeminjaman

    ' Menyimpan kode buku yang sedang dipinjam.
    Private ReadOnly daftarKodeBuku As New List(Of String)

    ' Menentukan lokasi file CSV di folder Documents.
    Private ReadOnly lokasiEkspor As String =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "peminjaman.csv"
        )



    ' Memeriksa seluruh input dan menandai semua kesalahan sekaligus.
    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True

        ' Memeriksa format kode buku.
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()

        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku,
                           "Kode harus berformat BK diikuti 4 digit, contoh BK0012.")
            valid = False
        ElseIf daftarKodeBuku.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' Memeriksa judul buku.
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        ' Memeriksa kategori buku.
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Pilih kategori buku.")
            valid = False
        End If

        ' Memeriksa nama peminjam.
        Dim nama As String = txtNamaPeminjam.Text.Trim()

        If nama.Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam,
                           "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        ' Memeriksa lama pinjam sebagai bilangan bulat 1 sampai 14.
        Dim lamaPinjam As Integer

        If Not Integer.TryParse(txtLamaPinjam.Text, lamaPinjam) OrElse
       lamaPinjam < 1 OrElse lamaPinjam > 14 Then

            errPinjam.SetError(txtLamaPinjam,
                           "Lama pinjam harus bilangan bulat 1 sampai 14 hari.")
            valid = False
        End If

        Return valid
    End Function
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda error."
            Return
        End If

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim lamaPinjam As Integer

        Integer.TryParse(txtLamaPinjam.Text, lamaPinjam)

        Dim tanggalKembali As String =
            Date.Today.AddDays(lamaPinjam).ToString("dd/MM/yyyy")

        Dim baris As String =
            kode & " | " & judul & " | " & kategori & " | " &
            nama & " | " & lamaPinjam.ToString() & " hari | kembali " &
            tanggalKembali

        lstPeminjaman.Items.Add(baris)
        daftarKodeBuku.Add(kode)

        lblStatus.Text =
            "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()

        BersihkanForm()
    End Sub


    ' Mengosongkan semua input dan menghapus tanda error.
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
        lblStatus.Text = "Form dibersihkan."
    End Sub


    ' Mengekspor daftar peminjaman ke file CSV di folder Documents.
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor.",
                        "Ekspor CSV",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            Return
        End If

        Dim penulis As StreamWriter = Nothing

        Try
            penulis = New StreamWriter(lokasiEkspor)

            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            For Each item As Object In lstPeminjaman.Items
                Dim baris As String = item.ToString()
                Dim bagian() As String = baris.Split("|"c)

                For i As Integer = 0 To bagian.Length - 1
                    bagian(i) = bagian(i).Trim()
                Next

                penulis.WriteLine(String.Join(";", bagian))
            Next

            lblStatus.Text = "Data berhasil diekspor ke " & lokasiEkspor

        Catch ex As IOException
            MessageBox.Show(
            "File tidak dapat ditulis. Tutup file peminjaman.csv jika sedang dibuka di Excel, lalu coba lagi." &
            vbCrLf & ex.Message,
            "Ekspor Gagal",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show(
            "Akses ke folder ekspor ditolak. Periksa izin akses folder Documents." &
            vbCrLf & ex.Message,
            "Akses Ditolak",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

        Finally
            If penulis IsNot Nothing Then
                penulis.Close()
            End If
        End Try
    End Sub

    ' Memeriksa format kode buku ketika fokus berpindah.
    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kode As String = txtKodeBuku.Text.Trim()

        If kode = "" Then
            errPinjam.SetError(txtKodeBuku, "")
        ElseIf Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku,
                           "Kode harus berformat BK diikuti 4 digit, contoh BK0012.")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub

End Class
