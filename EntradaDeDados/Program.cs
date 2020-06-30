using System;

namespace EntradaDeDados
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite alguma coisa: ");
            //string produto = Console.ReadLine();
            //Console.WriteLine("O Produto {0} no momento encontrasse em falta. ", produto);    


            Console.WriteLine("Informe 3 cores: ");

            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
