using System;
using System.Globalization;

namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            Console.WriteLine("Informe a 1ª Nota");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a 2ª Nota");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;

            if (resultado >= 60.00)
            {
                Console.WriteLine("Aprovado - Nota = {0} Parabéns!", resultado);
            }
            else 
            {
                Console.WriteLine("Reprovado - Nota = {0} Você precisa estudar mais!", resultado);
            }
        }
    }
}
