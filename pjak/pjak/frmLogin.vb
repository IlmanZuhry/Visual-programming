Public Class frmLogin
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets\staff.jpg")
        ElseIf cmbRole.Text = "Manager" Then
            picImage.Image = Image.FromFile("Assets\manager.jpg")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
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
    End Sub
End Class
