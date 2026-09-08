# Penjelasan Kode Program

Program ini dibuat menggunakan **VB.NET Windows Forms**. Program terdiri dari dua form utama, yaitu `frmLogin` dan `frmPajak`.

## 1. Form Login (`frmLogin`)

Form Login digunakan untuk melakukan validasi pengguna sebelum masuk ke form pajak.

### Pemilihan Role

Program menyediakan dua role:

- Staff
- Manager

Ketika role dipilih, gambar pada `picImage` akan berubah sesuai role.

```vb
If cmbRole.Text = "Staff" Then
    picImage.Image = My.Resources.staff
ElseIf cmbRole.Text = "Manager" Then
    picImage.Image = My.Resources.manager
End If
```

`cmbRole.Text` digunakan untuk mendapatkan role yang sedang dipilih.

`picImage.Image` digunakan untuk mengubah gambar pada PictureBox.

### Default Role

Saat form pertama kali dibuka, role Staff dipilih secara otomatis.

```vb
Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmbRole.SelectedIndex = 0
End Sub
```

`SelectedIndex = 0` memilih item pertama pada ComboBox, yaitu Staff.

---

## 2. Validasi Nama

Nama hanya dapat diisi menggunakan huruf dan spasi.

```vb
If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
    e.Handled = True
End If
```

`Char.IsLetter()` digunakan untuk memeriksa apakah karakter merupakan huruf.

Spasi diperbolehkan agar nama yang terdiri dari beberapa kata dapat dimasukkan.

`ChrW(Keys.Back)` digunakan agar tombol Backspace tetap dapat digunakan.

`e.Handled = True` digunakan untuk menolak karakter yang tidak diperbolehkan.

---

## 3. Validasi NIM

NIM hanya dapat diisi menggunakan angka.

```vb
If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
    e.Handled = True
End If
```

`Char.IsDigit()` digunakan untuk memeriksa apakah karakter merupakan angka.

Selain angka, Backspace tetap diperbolehkan.

---

## 4. Proses Login

Login dilakukan dengan mencocokkan role, nama, dan NIM.

```vb
If cmbRole.Text = "Staff" AndAlso txtNama.Text.Trim().ToLower() = "cecep" AndAlso txtNim.Text = "24" Then
    frmPajak.Show()
    Me.Hide()
    txtNama.Clear()
    txtNim.Clear()

ElseIf cmbRole.Text = "Manager" AndAlso txtNama.Text.Trim().ToLower() = "ilman" AndAlso txtNim.Text = "241712047" Then
    frmPajak.Show()
    Me.Hide()
    txtNama.Clear()
    txtNim.Clear()

Else
    MessageBox.Show("Masukkan akun yang betol wy", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
End If
```

### `AndAlso`

`AndAlso` digunakan agar semua kondisi harus benar.

Contohnya, role harus sesuai dan nama serta NIM juga harus sesuai.

### `Trim()`

```vb
txtNama.Text.Trim()
```

Digunakan untuk menghapus spasi di awal dan akhir input.

### `ToLower()`

```vb
txtNama.Text.Trim().ToLower()
```

Mengubah input menjadi huruf kecil sehingga perbandingan nama tidak membedakan huruf besar dan kecil.

### `Show()` dan `Hide()`

```vb
frmPajak.Show()
Me.Hide()
```

`Show()` digunakan untuk menampilkan `frmPajak`.

`Me.Hide()` digunakan untuk menyembunyikan `frmLogin`.

### `Clear()`

```vb
txtNama.Clear()
txtNim.Clear()
```

Digunakan untuk mengosongkan TextBox setelah login berhasil.

---

# 5. Form Pajak (`frmPajak`)

Form Pajak digunakan untuk menghitung pajak berdasarkan pendapatan.

## Validasi Pendapatan

`txtPendapatan` hanya menerima angka.

```vb
If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
    e.Handled = True
End If
```

Kode ini memiliki fungsi yang sama dengan validasi NIM.

---

## 6. Variabel Perhitungan

Pada tombol Hitung digunakan dua variabel:

```vb
Dim pendapatan As Double
Dim pajak As Double
```

`Dim` digunakan untuk mendeklarasikan variabel.

- `pendapatan` menyimpan nilai pendapatan.
- `pajak` menyimpan hasil perhitungan pajak.

`Double` digunakan sebagai tipe data angka.

---

## 7. Mengambil Pendapatan

```vb
pendapatan = Val(txtPendapatan.Text)
```

`txtPendapatan.Text` mengambil nilai yang dimasukkan pengguna.

`Val()` mengubah nilai tersebut menjadi angka agar dapat digunakan dalam perhitungan.

---

## 8. Menentukan Persentase Pajak

```vb
If pendapatan <= 5000000 Then
    pajak = pendapatan * 0
ElseIf pendapatan <= 30000000 Then
    pajak = pendapatan * 0.1
ElseIf pendapatan <= 100000000 Then
    pajak = pendapatan * 0.2
Else
    pajak = pendapatan * 0.3
End If
```

Program memeriksa pendapatan secara berurutan.

### Pendapatan ≤ Rp5.000.000

```vb
pajak = pendapatan * 0
```

Tarif pajak adalah 0%.

### Pendapatan ≤ Rp30.000.000

```vb
pajak = pendapatan * 0.1
```

Tarif pajak adalah 10%.

### Pendapatan ≤ Rp100.000.000

```vb
pajak = pendapatan * 0.2
```

Tarif pajak adalah 20%.

### Pendapatan > Rp100.000.000

```vb
pajak = pendapatan * 0.3
```

Tarif pajak adalah 30%.

---

## 9. Menampilkan Hasil

```vb
MessageBox.Show("Pajak yang harus dibayar: Rp " & pajak.ToString("N0"))
```

`MessageBox.Show()` digunakan untuk menampilkan hasil kepada pengguna.

`ToString("N0")` digunakan untuk menampilkan angka dengan format numerik tanpa angka desimal.

Contoh:

```text
1000000
```

ditampilkan menjadi:

```text
1.000.000
```

`&` digunakan untuk menggabungkan teks dengan nilai pajak.

---

# 10. Tombol Keluar

Kode tombol Keluar:

```vb
Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()
End Sub
```

`Me.Close()` digunakan untuk menutup `frmPajak`.

Saat form ditutup, event `FormClosing` dijalankan.

```vb
Private Sub frmPajak_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    frmLogin.Show()
End Sub
```

`frmLogin.Show()` digunakan untuk menampilkan kembali form Login.

Dengan demikian, alurnya:

```text
frmLogin
    ↓
Login berhasil
    ↓
frmPajak.Show()
    ↓
frmLogin.Hide()
    ↓
frmPajak
    ↓
Keluar / X
    ↓
frmPajak.Close()
    ↓
frmLogin.Show()
```

# Kesimpulan

Program menggunakan konsep dasar VB.NET Windows Forms seperti:

- Variable dengan `Dim`
- Percabangan `If`, `ElseIf`, dan `Else`
- Operator `AndAlso`
- Event `Click`, `KeyPress`, `SelectedIndexChanged`, dan `FormClosing`
- `Show()`, `Hide()`, `Close()`, dan `Clear()`
- Validasi input menggunakan `Char.IsLetter()` dan `Char.IsDigit()`
- Konversi angka menggunakan `Val()`
- Formatting angka menggunakan `ToString("N0")`
- `MessageBox.Show()` untuk menampilkan informasi dan pesan error
