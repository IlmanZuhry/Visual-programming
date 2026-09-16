Public Class frmLoop
    Private Sub txtAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAwal.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAkhir.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiAwal As Integer
        Dim nilaiAkhir As Integer

        If Not Integer.TryParse(txtAwal.Text, nilaiAwal) Then
            MessageBox.Show("Masukkan angka tod")
            txtAwal.Focus()
            Return
        End If

        If Not Integer.TryParse(txtAkhir.Text, nilaiAkhir) Then
            MessageBox.Show("Masukkan angka tod")
            txtAkhir.Focus()
            Return
        End If

        For i As Integer = nilaiAwal To nilaiAkhir
            lstHasil.Items.Add(i)
        Next
    End Sub
End Class
