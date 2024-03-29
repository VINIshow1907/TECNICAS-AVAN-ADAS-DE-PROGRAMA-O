using System;

class Program
{
    static void Main()
    {
        int tamanhoVetor = 10;

        int[] vetor = new int[tamanhoVetor];

        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write($"Digite o número  {i + 1}");
            if (!int.TryParse( Console.ReadLine(), out vetor[i] ) )
            {
                Console.WriteLine("Valor inválido. Tente novamente");
                i--;
            }
        }

        Console.WriteLine($"Digite o número alvo:");
        int numAlvo = int.Parse( Console.ReadLine());
       
        int cont = 0;
   
        for (int i = 0; i<vetor.Length; i++)
        {
            if (vetor[i] == numAlvo)
            {
                cont++;
            }
        }

        if ( cont > 0 )
        {
            Console.WriteLine($"O número {numAlvo} está presente no vetor");
        }
        else
        {
            Console.WriteLine(" O valor não está presente no vetor");
        }
    }        
}