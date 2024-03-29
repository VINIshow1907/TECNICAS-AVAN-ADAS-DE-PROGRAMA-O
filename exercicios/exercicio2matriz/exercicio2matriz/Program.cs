using System;
class Programa
{
    static void Main()
    {
        int[,] matriz = new int[2, 4];
        Console.WriteLine("Informe 8 elementos:");

        for (int l = 0; l < 2; l++) //Usado para ler linhas
        {
            for (int c = 0; c < 4; c++) //Usado para ler colunas
            {
                Console.WriteLine("Informe o elemento " + l + " X " + c);
                matriz[l, c] = int.Parse(Console.ReadLine());
            }
        }
        int quantPrimeira = 0;
        int quantSegunda = 0;
        int quantNumPar = 0;
        int soma = 0;
        float media;
        //Imprime a matriz
        for (int l = 0; l < 2; l++)
        {
            for (int c = 0; c < 4; c++)
            {
                if (matriz[l, c] > 12 && matriz[l, c] < 20)
                {
                    if (l == 0)
                    {
                        quantPrimeira++;
                    }
                    else if (l == 1)
                    {
                        quantSegunda++;
                    }
                }
                if (matriz[l, c] % 2 == 0)
                {
                    soma += matriz[l, c];
                    quantNumPar++;
                }
            }
        }

        Console.WriteLine();

        media = (float)soma / quantNumPar;
        Console.Write("A quantidade de elementos entre 12 e 20 na primeira linha é: " + quantPrimeira);
        Console.WriteLine();
        Console.Write("A quantidade de elementos entre 12 e 20 na segunda linha é: " + quantSegunda);
        Console.WriteLine();
        Console.Write("A média dos números pares é: " + media.ToString("0.00"));
    }
}
