<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtAngka = New TextBox()
        btnInput = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 25)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Angka :"
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(272, 98)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(78, 31)
        txtAngka.TabIndex = 1
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(204, 188)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(112, 34)
        btnInput.TabIndex = 2
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(377, 184)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(169, 254)
        lstHasil.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnInput)
        Controls.Add(txtAngka)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstHasil As ListBox

End Class
