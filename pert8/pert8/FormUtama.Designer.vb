<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        btnDariArray = New Button()
        btnDariList = New Button()
        btnDataTable = New Button()
        btnCariList = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(192, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 38)
        Label1.TabIndex = 0
        Label1.Text = "Pertemuan 8"
        ' 
        ' btnDariArray
        ' 
        btnDariArray.Location = New Point(112, 94)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New Size(373, 39)
        btnDariArray.TabIndex = 1
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True
        ' 
        ' btnDariList
        ' 
        btnDariList.Location = New Point(112, 156)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New Size(373, 39)
        btnDariList.TabIndex = 2
        btnDariList.Text = "2. Binding List"
        btnDariList.UseVisualStyleBackColor = True
        ' 
        ' btnDataTable
        ' 
        btnDataTable.Location = New Point(112, 215)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New Size(373, 39)
        btnDataTable.TabIndex = 3
        btnDataTable.Text = "3. Data Tabel,Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True
        ' 
        ' btnCariList
        ' 
        btnCariList.Location = New Point(112, 276)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New Size(373, 39)
        btnCariList.TabIndex = 4
        btnCariList.Text = "4. Pencarian dengan perulangan"
        btnCariList.UseVisualStyleBackColor = True
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 408)
        Controls.Add(btnCariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnDariList)
        Controls.Add(btnDariArray)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDariArray As Button
    Friend WithEvents btnDariList As Button
    Friend WithEvents btnDataTable As Button
    Friend WithEvents btnCariList As Button

End Class
