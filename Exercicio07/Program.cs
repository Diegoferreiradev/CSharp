using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine());
            double soma = 0;
            int cont = 0;
            double media;

            while (idade >= 0) {

                soma += idade;
                cont = cont + 1;
                Console.WriteLine("Informe a Idade");
                idade = double.Parse(Console.ReadLine());
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else 
            { 
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
