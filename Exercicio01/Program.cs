using System;
using System.Globalization;

namespace Exercicio01
{
    public class Program
    {
         static void Main(string[] args)
        {
            double area, largura, comprimento, preco, precoMetroQdr;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQdr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQdr;

            Console.WriteLine("Área = {0}", area);
            Console.WriteLine("Preço = {0}", preco);
            
        }
    }
}
