using System;

namespace DadosCasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome = "Diego";
            string profissao = "Engenheiro de Software";
            string empresa = "World";
            int a = 5;
            int b = 2;
            double resultado;

            Console.WriteLine("Meu nome é {0} Trabalho na {1} e minha profissão é {2}", nome, empresa, profissao);

            //resultado = a / b;

            resultado = (double) a / b;  // casting

            Console.WriteLine("Resultado " + resultado);
            
        }
    }
}
