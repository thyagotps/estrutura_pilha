Public Class Pilha

    Public pilha() As Integer = {0, 0, 0, 0, 0}
    Public posicao As Integer
    Public numero As Integer

    Public Sub New()
        posicao = -1
        numero = 0
    End Sub

    Public Sub Push()
        If (posicao < 4) Then
            posicao += 1
            pilha(posicao) = numero
            Console.WriteLine("Inserido !")
        Else
            Console.WriteLine("Fora da faixa !")
        End If
    End Sub

    Public Sub pop()
        If (posicao >= 0 And posicao <= 4) Then
            pilha(posicao) = 0
            posicao -= 1
            Console.WriteLine("Excluído !")
        Else
            Console.WriteLine("Fora da faixa !")
        End If
    End Sub

    Public Sub Imprimir()
        Console.WriteLine("Impressão:")
        For i As Integer = 0 To 4
            Console.WriteLine(pilha(i))
        Next
    End Sub

    Public Sub Menor()
        Dim temp As Integer
        For i As Integer = 0 To 4
            temp = pilha(i)
            For y As Integer = 0 To 4
                If (temp > pilha(y)) Then
                    temp = pilha(y)
                End If
            Next
        Next
        Console.WriteLine("Menor: " & temp)
    End Sub

End Class
