using System;
using System.Globalization;

namespace Exercicio04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;

            if (minutos > 100) 
            {
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a Pagar: R$ {0}", conta, CultureInfo.InvariantCulture);
        }
    }
}
