<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariArray
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
        dgvMahasiswa = New DataGridView()
        colNim = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJurusan = New DataGridViewTextBoxColumn()
        colAngkatan = New DataGridViewTextBoxColumn()
        colIpk = New DataGridViewTextBoxColumn()
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJumlah = New Label()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New Point(43, 85)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersVisible = False
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(705, 258)
        dgvMahasiswa.TabIndex = 0
        ' 
        ' colNim
        ' 
        colNim.HeaderText = "NIM"
        colNim.MinimumWidth = 8
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colJurusan
        ' 
        colJurusan.HeaderText = "Jurusan"
        colJurusan.MinimumWidth = 8
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True
        ' 
        ' colAngkatan
        ' 
        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.MinimumWidth = 8
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True
        ' 
        ' colIpk
        ' 
        colIpk.HeaderText = "IPK"
        colIpk.MinimumWidth = 8
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.Location = New Point(71, 377)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 47)
        btnTampilkan.TabIndex = 1
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnKosongkan
        ' 
        btnKosongkan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKosongkan.Location = New Point(233, 377)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(121, 47)
        btnKosongkan.TabIndex = 2
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(578, 382)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(126, 25)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' FrmDariArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 448)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(dgvMahasiswa)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents colNim As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents colIpk As DataGridViewTextBoxColumn
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJumlah As Label
End Class
