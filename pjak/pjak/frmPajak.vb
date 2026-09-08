Public Class frmPajak
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim pajak As Double

        pendapatan = Val(txtPendapatan.Text)

        If pendapatan <= 5000000 Then
            pajak = pendapatan * 0
        ElseIf pendapatan <= 30000000 Then
            pajak = pendapatan * 0.1
        ElseIf pendapatan <= 100000000 Then
            pajak = pendapatan * 0.2
        Else
            pajak = pendapatan * 0.3
        End If

        MessageBox.Show("Pajak yang harus dibayar: Rp " & pajak.ToString("N0"))
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub frmPajak_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub
End Class