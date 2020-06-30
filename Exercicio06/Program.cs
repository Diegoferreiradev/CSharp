using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != y) {

               Console.WriteLine("Digite o 1º e 2º Valor ");

                if (x > y)
                {
                    Console.WriteLine($"Crescente:  {x} -  {y}");
                }
                else
                {
                    Console.WriteLine($"Decrescente: {y} -  {x}");
                }
                vet = Console.ReadLine().Split(' ');
                 x = int.Parse(vet[0]);
                 y = int.Parse(vet[1]);
            }

            Console.WriteLine($"Fim da Execução do programa: Você informou 2 valores Iguais:  {x} e {y}");
        }
    }
}
