<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariList
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
        lblJumlah = New Label()
        txtCari = New TextBox()
        dgvMahasiswa = New DataGridView()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 38)
        Label1.TabIndex = 0
        Label1.Text = "Mencari di List(Of Mahasiswa)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 1
        Label2.Text = "Cari nama/NIM:"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(29, 389)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(174, 25)
        lblJumlah.TabIndex = 2
        lblJumlah.Text = "Menampilkan 0 data"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(199, 82)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(399, 31)
        txtCari.TabIndex = 3
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(29, 134)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersVisible = False
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(773, 225)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' FrmCariList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 450)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtCari)
        Controls.Add(lblJumlah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pencarian dengan Perulangan"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents bsMahasiswa As BindingSource
End Class
