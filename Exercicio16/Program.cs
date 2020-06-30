using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]); 
                }
            }

            int[] vet2 = new int[M];

            for (int i = 0; i < M; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }

                vet2[i] = soma;
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vet2[i]);
            }

        }
    }
}
