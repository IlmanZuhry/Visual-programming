<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoop
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
        txtAwal = New TextBox()
        txtAkhir = New TextBox()
        btnInput = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' txtAwal
        ' 
        txtAwal.Location = New Point(284, 158)
        txtAwal.Name = "txtAwal"
        txtAwal.Size = New Size(187, 31)
        txtAwal.TabIndex = 0
        ' 
        ' txtAkhir
        ' 
        txtAkhir.Location = New Point(284, 228)
        txtAkhir.Name = "txtAkhir"
        txtAkhir.Size = New Size(187, 31)
        txtAkhir.TabIndex = 1
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(317, 329)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(112, 34)
        btnInput.TabIndex = 2
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 4
        Label1.Text = "Nilai Awal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(133, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 5
        Label2.Text = "Nilai Akhir"
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(565, 158)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(149, 129)
        lstHasil.TabIndex = 6
        ' 
        ' frmLoop
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 493)
        Controls.Add(lstHasil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnInput)
        Controls.Add(txtAkhir)
        Controls.Add(txtAwal)
        Name = "frmLoop"
        Text = "Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAwal As TextBox
    Friend WithEvents txtAkhir As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstHasil As ListBox

End Class
