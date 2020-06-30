using System;
using System.Globalization;

namespace EntradaDeDadosPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2);

            //string nome = Console.ReadLine();
            //char sexo = char.Parse(Console.ReadLine());
            //int idade = int.Parse(Console.ReadLine());
            //double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("--- Dados do Usuário ---");

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);

        }
    }
}
