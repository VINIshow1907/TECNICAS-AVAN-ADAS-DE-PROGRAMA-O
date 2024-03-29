
using System;
class Program
{
    static void Main()
    {
        int tamanhoVetor1 = 5;
        int[] vetor1 = new int[tamanhoVetor1];

        for (int i = 0; i < tamanhoVetor1; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out vetor1[i]))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                i--;
            }
        }
        int tamanhoVetor2 = 5;
        int[] vetor2 = new int[tamanhoVetor2];

        for (int i = 0; i < tamanhoVetor2; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out vetor2[i]))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                i--;
            }
        }
        int tamanhoVetor3 = 5;
        int[] vetor3 = new int[tamanhoVetor3];

        for (int i = 0; i < tamanhoVetor3; i++)
        {
            vetor3[i] = vetor1[i] + vetor2[i];
            Console.WriteLine($"Valor: {vetor3[i]}");
        }
    }
}