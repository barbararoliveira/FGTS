using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Olá usuário, vou ajudá-lo a calcular o seu FGTS.");
            Console.WriteLine(" Pressione enter para continuar:");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe o seu salário atual em reais:");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("A parcela do seu FGTS é: ");
            double result = (salario * 8 / 100);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result);
            Console.WriteLine(" reais.");

            Console.ReadKey();
        }
    }
}
