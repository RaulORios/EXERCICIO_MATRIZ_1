using System;

namespace EXERCICIO_MATRIZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;

            n = int.Parse(Console.ReadLine());
            a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonais principais: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i, i]);
            }
            Console.WriteLine();

            int totnegativo = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i,j] < 0)
                    {
                        totnegativo++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de negativos: {totnegativo}");
            
            Console.ReadKey();

        }
    }
}
