using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para iniciar digite um Número:");
            int x = int.Parse(Console.ReadLine());

            while (x != 0) {
                Console.WriteLine("Informe um novo Valor: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor Digitado: {x}");
            }

            Console.WriteLine($"Fim da Execução você informou o valor: {x}");
        }
    }
}
