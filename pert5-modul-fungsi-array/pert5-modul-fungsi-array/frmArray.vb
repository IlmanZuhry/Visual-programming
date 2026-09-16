Public Class frmArray
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click

        'MessageBox.Show(Hitung(txtPanjang.Text, txtLebar.Text))
        For i As Integer = 0 To nilai.Length - 1
            lstNilai.Items.Add(nilai(i))
        Next
    End Sub

    Private Sub txtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLebar.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class
