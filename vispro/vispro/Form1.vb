Public Class Form1
    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAngka.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim angka As Integer

        If Not Integer.TryParse(txtAngka.Text, angka) Then
            MessageBox.Show("Masukkan angka yang valid!")
            txtAngka.Focus()
            Return
        End If

        lstHasil.Items.Clear()

        Dim i As Integer = 1

        Do While i <= 10
            lstHasil.Items.Add(angka & " x " & i & " = " & (angka * i))
            i += 1
        Loop

    End Sub
End Class
