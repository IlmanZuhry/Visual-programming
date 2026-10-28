<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblNama = New Label()
        lblNim = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtJurusan = New TextBox()
        btnTambah = New Button()
        btnTampilkan = New Button()
        dgvMahasiswa = New DataGridView()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(473, 43)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(64, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama "
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(473, 105)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(46, 25)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(473, 189)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(71, 25)
        lblJurusan.TabIndex = 2
        lblJurusan.Text = "Jurusan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(593, 43)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 3
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(593, 105)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 4
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(593, 189)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(150, 31)
        txtJurusan.TabIndex = 5
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(593, 295)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(162, 295)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 7
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(57, 32)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.Size = New Size(360, 225)
        dgvMahasiswa.TabIndex = 8
        ' 
        ' FormMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTampilkan)
        Controls.Add(btnTambah)
        Controls.Add(txtJurusan)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Name = "FormMahasiswa"
        Text = "FormMahasiswa"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents dgvMahasiswa As DataGridView
End Class
