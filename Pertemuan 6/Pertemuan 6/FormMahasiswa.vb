Public Class FormMahasiswa
    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
        txtNim.Text,
        txtNama.Text,
        txtJurusan.Text) Then
            MessageBox.Show("Data berhasil ditambahkan", "Informasi")
        End If
        txtJurusan.Clear()
        txtNama.Clear()
        txtNim.Clear()
    End Sub
End Class