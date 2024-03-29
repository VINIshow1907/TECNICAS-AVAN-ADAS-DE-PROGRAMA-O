using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        Console.WriteLine("Informe 25 elementos:");

        for (int l = 0; l < 5; l++) //Usado para ler linhas
        {
            for (int c = 0; c < 5; c++) //Usado para ler colunas
            {
                Console.WriteLine("Informe o elemento " + l + " X " + c);
                matriz[l, c] = int.Parse(Console.ReadLine());
            }
        }

        int quantNumNeg = 0;
        int soma = 0;
        //Imprime a matriz
        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 5; c++)
            {
                if (matriz[l, c] < 0)
                {
                    quantNumNeg++;
                }

                if (matriz[l, c] > 0)
                {
                    soma += matriz[l, c];
                }

                int control = 0;
                if (matriz[l, c] > 1)
                {
                    for (int i = 5; i < matriz[l, c] + 1; i++)
                    {
                        if (matriz[l, c] % i == 0)
                        {
                            control++;
                        }
                    }
                }

                if (control == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(matriz[l, c] + " é primo!");
                }

            }
        }

        Console.WriteLine();
        Console.Write("A quantidade de números negativos é: " + quantNumNeg);
        Console.WriteLine();
        Console.Write("A soma dos números positivos é: " + soma);


    }
}