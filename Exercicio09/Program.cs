using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor para a Tabuada de Multiplicação: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine($"{i} X {N} = {resultado}");
            }
        }
    }
}
