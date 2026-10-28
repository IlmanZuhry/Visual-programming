Module modArray
    Function Hitung(P As Integer, L As Integer) As Integer
        If P > 50 Then
            Return P * L
        Else
            Return 2 * P + 2 * L
        End If
    End Function

    Public nilai() As Integer = {70, 80, 90, 100}
    Public nilai2D(,) As Integer = {
        {55, 58, 65},
        {40, 50, 70},
        {78, 69, 37}
    }
End Module
