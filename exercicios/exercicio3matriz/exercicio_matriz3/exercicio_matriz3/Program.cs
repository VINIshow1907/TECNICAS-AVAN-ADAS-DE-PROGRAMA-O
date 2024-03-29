using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];
        Console.WriteLine("Informe 100 elementos:");

        for (int l = 0; l < 10; l++) //Usado para ler linhas
        {
            for (int c = 0; c < 10; c++) //Usado para ler colunas
            {
                Console.WriteLine("Informe o elemento " + l + " X " + c);
                matriz[l, c] = int.Parse(Console.ReadLine());
            }
        }

        int totalPrincipal = 0;
        int somaPrincipal = 0;
        float mediaPrincipal;

        int totalSecundaria = 0;
        int somaSecundaria = 0;
        float mediaSecundaria;

        //Imprime a matriz
        for (int l = 0; l < 10; l++)
        {
            for (int c = 0; c < 10; c++)
            {
                if (l == c)
                {
                    somaPrincipal += matriz[l, c];
                    totalPrincipal++;
                }

                if (l + c == 9)
                {
                    somaSecundaria += matriz[l, c];
                    totalSecundaria++;
                }
            }

        }
        Console.WriteLine();

        mediaPrincipal = (float)somaPrincipal / totalPrincipal;
        mediaSecundaria = (float)somaSecundaria / totalSecundaria;
        Console.Write("A média dos elementos da diagonal principal é: " + mediaPrincipal);
        Console.WriteLine();
        Console.Write("A média dos elementos da diagonal secundária é: " + mediaSecundaria);


    }
}
