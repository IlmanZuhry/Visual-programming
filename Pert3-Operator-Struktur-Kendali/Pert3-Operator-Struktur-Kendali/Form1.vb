Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Angka doang tod")
            txtNilai.Focus()
            Return

        End If
        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Nilai harus antara 0 dan 100")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian <= 50 Then
            picImage.Image = Image.FromFile("Assets\1.png")
        ElseIf nilaiUjian <= 75 Then
            picImage.Image = Image.FromFile("Assets\2.png")
        Else
            picImage.Image = Image.FromFile("Assets\3.png")
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged

    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
