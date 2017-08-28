Module Module1

    Sub Main()

        Dim pilha As New Pilha()
        Dim opcao As Integer

        Do
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("Estrutura de dados Pilha")
            Console.WriteLine("Opções:")
            Console.WriteLine("1 - Inserir")
            Console.WriteLine("2 - Excluir")
            Console.WriteLine("3 - Imprimir")
            Console.WriteLine("4 - Menor")
            Console.WriteLine("0 - Sair")
            Console.WriteLine("Digite a opção: ")
            opcao = Console.ReadLine()

            If (opcao = 1) Then
                Console.WriteLine("")
                Console.WriteLine("Digite um número: ")
                pilha.numero = Console.ReadLine()
                pilha.Push()
            End If

            If (opcao = 2) Then
                pilha.pop()
            End If

            If (opcao = 3) Then
                pilha.Imprimir()
            End If

            If (opcao = 4) Then
                pilha.Menor()
            End If

        Loop While opcao > 0
    End Sub



End Module
