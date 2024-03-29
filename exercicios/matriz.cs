using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3]; //declara uma matriz 3x3
        Console.WriteLine("Informe 9 elementos:");
        for (int l=0; l < 3; l++) //usado para ler linhas 
        {
            for (int c=0; c <3; c++) //usado para ler colunas
            {
                Console.WriteLine("Informe o elemento " + l + " X " + c);
                matriz[l,c] = int.Parse(Console.ReadLine());
            }
        }
        //imprime a matriz
        Console.WriteLine("A matriz impressa: ");
        for(int l = 0; l < 3; l++)
        {
            for (int c=0; c <3;c++)
            {
                Console.WriteLine(" "+matriz[l, c]);
            }
            Console.WriteLine();
        }
        //imprimir o elementos da diagonal principal
        //indice de linha = indice de coluna
        Console.WriteLine("Imprimir elementos da diagonal principal: ");
        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                if(l==c)
                {
                    Console.Write(" " + matriz[l, c]);
                }
            }
        }
        //imprmir elementos da diagonal secundaria
        //indice de linha +coluna deve ser menor que a ordem da matriz -1
        Console.WriteLine("Imprimir elementos da diagonal secundaria: ");
        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                if (l+c==2)
                {
                    Console.Write(" " + matriz[l, c]);
                }
            }
        }

    }
}
