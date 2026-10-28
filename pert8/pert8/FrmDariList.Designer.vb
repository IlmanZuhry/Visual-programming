<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariList
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        txtNim = New TextBox()
        Label3 = New Label()
        txtNama = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        cboJurusan = New ComboBox()
        Label6 = New Label()
        txtAngkatan = New TextBox()
        Label7 = New Label()
        txtIpk = New TextBox()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        errInput = New ErrorProvider(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(492, 38)
        Label1.TabIndex = 0
        Label1.Text = "List(Of Mahasiswa) + BindingSource"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(51, 138)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(266, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
        Label3.TabIndex = 3
        Label3.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(266, 138)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(292, 31)
        txtNama.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(417, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(613, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 25)
        Label5.TabIndex = 6
        Label5.Text = "Jurusan"
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(613, 138)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(223, 33)
        cboJurusan.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(51, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 25)
        Label6.TabIndex = 8
        Label6.Text = "Angkatan"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(51, 245)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(150, 31)
        txtAngkatan.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(266, 199)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 25)
        Label7.TabIndex = 10
        Label7.Text = "IPK"
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(266, 245)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(150, 31)
        txtIpk.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(501, 240)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 40)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(56, 313)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersVisible = False
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(823, 241)
        dgvMahasiswa.TabIndex = 13
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(56, 577)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(126, 25)
        lblJumlah.TabIndex = 14
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmDariList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(945, 621)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(txtIpk)
        Controls.Add(Label7)
        Controls.Add(txtAngkatan)
        Controls.Add(Label6)
        Controls.Add(cboJurusan)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(txtNim)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents errInput As ErrorProvider
End Class
