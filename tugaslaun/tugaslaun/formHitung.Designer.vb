<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHitung
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
        Label1 = New Label()
        Label2 = New Label()
        txtBerat = New TextBox()
        Label3 = New Label()
        cmbStat = New ComboBox()
        Label4 = New Label()
        btnHitung = New Button()
        btnBatal = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(35, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 25)
        Label1.TabIndex = 0
        Label1.Text = "Berat Laundry :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 25)
        Label2.TabIndex = 1
        Label2.Text = "Kg"
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(179, 165)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(82, 31)
        txtBerat.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Status    :"
        ' 
        ' cmbStat
        ' 
        cmbStat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStat.FormattingEnabled = True
        cmbStat.Items.AddRange(New Object() {"Member", "Non Member"})
        cmbStat.Location = New Point(179, 230)
        cmbStat.Name = "cmbStat"
        cmbStat.Size = New Size(147, 33)
        cmbStat.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(78, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(389, 38)
        Label4.TabIndex = 5
        Label4.Text = "Harga Laundry Rp.7000 / Kg"
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.Lime
        btnHitung.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(106, 341)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 44)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Red
        btnBatal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(258, 341)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 44)
        btnBatal.TabIndex = 7
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' formHitung
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 513)
        Controls.Add(btnBatal)
        Controls.Add(btnHitung)
        Controls.Add(Label4)
        Controls.Add(cmbStat)
        Controls.Add(Label3)
        Controls.Add(txtBerat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "formHitung"
        Text = "Laundry Hebat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBatal As Button

End Class
