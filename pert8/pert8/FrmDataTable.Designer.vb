<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataTable
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
        lblCari = New Label()
        txtCari = New TextBox()
        btnRapikan = New Button()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 38)
        Label1.TabIndex = 0
        Label1.Text = "DataTable + BindingSource"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(39, 100)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(136, 25)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(193, 100)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(316, 31)
        txtCari.TabIndex = 2
        ' 
        ' btnRapikan
        ' 
        btnRapikan.Location = New Point(672, 93)
        btnRapikan.Name = "btnRapikan"
        btnRapikan.Size = New Size(170, 45)
        btnRapikan.TabIndex = 3
        btnRapikan.Text = "Rapikan Kolom"
        btnRapikan.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(39, 184)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersVisible = False
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(803, 225)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(39, 454)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(224, 25)
        lblJumlah.TabIndex = 5
        lblJumlah.Text = "Menampilkan 0 dari 0 data"
        ' 
        ' FrmDataTable
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(926, 546)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnRapikan)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDataTable"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataTable, BindingSource & Filter"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnRapikan As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
End Class
