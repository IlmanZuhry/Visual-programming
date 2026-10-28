Option Strict On

Public Module ModValidasi

    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False

        For Each karakter As Char In teks
            If Not Char.IsDigit(karakter) Then Return False
        Next

        Return True
    End Function

    Public Function Kosong(teks As String) As Boolean
        Return String.IsNullOrWhiteSpace(teks)
    End Function

    Public Function CobaDesimal(teks As String, ByRef hasil As Decimal) As Boolean
        teks = teks.Trim().Replace(","c, "."c)

        Return Decimal.TryParse(
        teks,
        Globalization.NumberStyles.AllowDecimalPoint,
        Globalization.CultureInfo.InvariantCulture,
        hasil
    )
    End Function

End Module