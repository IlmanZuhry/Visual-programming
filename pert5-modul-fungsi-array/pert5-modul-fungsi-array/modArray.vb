Module modArray
    Function Hitung(P As Integer, L As Integer) As Integer
        If P > 50 Then
            Return P * L
        Else
            Return 2 * P + 2 * L
        End If
    End Function

    Public nilai() As Integer = {70, 80, 90, 100}
End Module
