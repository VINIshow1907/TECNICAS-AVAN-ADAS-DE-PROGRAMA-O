using System;
using System;

class Program
{
    static void Main()
    {
        // Definindo o tamanho do vetor
        int tamanhoVetor = 5;

        // Criando o vetor
        int[] vetor = new int[tamanhoVetor];

        for (int i = 0; i <tamanhoVetor; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out vetor[i])) //lê o valor
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                i--; // Permite ao usuário tentar novamente para a posição atual
            }
        }

        //imprimindo o vetor
        int maior = vetor[0];
        int menor = vetor[0];

        for (int i = 0; i < vetor.Length; i++)
        {
                if (vetor[i] < menor)
            {
                menor = vetor[i];
            }

            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        Console.WriteLine("O menor valor é:" + menor);
        Console.WriteLine("O maior valor é:" + maior);
      

    }
}


