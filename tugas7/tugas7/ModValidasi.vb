
Option Strict On

' Module berisi fungsi untuk memvalidasi kode buku.
Public Module ModValidasi

    ' Memeriksa apakah kode buku diawali BK dan diikuti empat digit angka.
    Public Function KodeBukuValid(kode As String) As Boolean
        kode = kode.Trim().ToUpperInvariant()

        If kode.Length <> 6 Then Return False
        If Not kode.StartsWith("BK") Then Return False

        For Each karakter As Char In kode.Substring(2)
            If karakter < "0"c OrElse karakter > "9"c Then
                Return False
            End If
        Next

        Return True
    End Function

End Module
