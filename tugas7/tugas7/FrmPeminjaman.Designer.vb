<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblKode = New Label()
        txtKodeBuku = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        Label2 = New Label()
        cboKategori = New ComboBox()
        Label3 = New Label()
        txtNamaPeminjam = New TextBox()
        Label4 = New Label()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        lstPeminjaman = New ListBox()
        lblStatus = New Label()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 38)
        Label1.TabIndex = 0
        Label1.Text = "Peminjaman Buku"
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(47, 95)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(97, 25)
        lblKode.TabIndex = 1
        lblKode.Text = "Kode Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(47, 132)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(256, 31)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(47, 188)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(97, 25)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(47, 231)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(256, 31)
        txtJudul.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 289)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 5
        Label2.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(47, 330)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(256, 33)
        cboKategori.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 25)
        Label3.TabIndex = 7
        Label3.Text = "Nama Peminjaman"
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(47, 437)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(256, 31)
        txtNamaPeminjam.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 498)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 25)
        Label4.TabIndex = 9
        Label4.Text = "Lama Pinjam (hari)"
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(47, 539)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(256, 31)
        txtLamaPinjam.TabIndex = 10
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(47, 612)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(112, 41)
        btnPinjam.TabIndex = 11
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(245, 612)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 41)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(446, 615)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(112, 38)
        btnEkspor.TabIndex = 13
        btnEkspor.Text = "Ekspor CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.Location = New Point(390, 132)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(553, 429)
        lstPeminjaman.TabIndex = 14
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(47, 680)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(189, 25)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Jumlah peminjaman: 0"
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' FrmPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 723)
        Controls.Add(lblStatus)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(Label4)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(Label3)
        Controls.Add(cboKategori)
        Controls.Add(Label2)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKode)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPeminjaman"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents errPinjam As ErrorProvider

End Class
