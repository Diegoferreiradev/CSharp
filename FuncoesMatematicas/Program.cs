using System;

namespace FuncoesMatematicas
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine("Raiz quadrada de {0}  = {1}", x, A);
            Console.WriteLine("Raiz quadrada de {0} = {1}", y, B);
            Console.WriteLine("Raiz quadrada de 25 = {0}", C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine("{0} elevado a {1} = {2}", x, y, A);
            Console.WriteLine("{0} elevado ao quadrado = {1}", x, B);
            Console.WriteLine("5 elevado ao quadrado = {0}", C);

            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("Valor absoluto de {0} = {1}", y, A);
            Console.WriteLine("Valor absoluto de {0} = {1}", z, B);

        }
    }
}
