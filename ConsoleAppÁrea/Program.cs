using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÁrea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha a forma geométrica[R-Retângulo,Q-Quadrado,T-Trapézio,L-Losango]:");
            string forma = Console.ReadLine().ToLower();

            switch (forma)
            {
                case "r":
                    Console.Write("Qual o tamnho da base em metros");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Qual o tamnho da base em metros");
                    double h = double.Parse(Console.ReadLine());
                    double result = b * h;
                    Console.Write("O resultado da área será: "+ result);
                    break;
                case "q":
                    Console.Write("Qual o tamnho da base em metros");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Qual o tamnho da altura em metros");
                    h = double.Parse(Console.ReadLine());
                    result = b * h;
                    Console.Write("O resultado da área será: " + result);
                    break;
                case "l":
                    Console.Write("Qual o valor da diagonal maior em metros:");
                    double d1 = double.Parse(Console.ReadLine());
                    Console.Write("Qual o valor da diagonal menor em metros:");
                    double d2 = double.Parse(Console.ReadLine());
                    result = d1 * d2 / 2;
                    Console.Write("O resultado da área será: " + result);
                    break;
                case "t":
                    Console.Write("Qual o valor da base maior em metros:");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.Write("Qual o valor da base menor em metros:");
                    double b2 = double.Parse(Console.ReadLine());
                    Console.Write("Qual o tamnho da altura em metros: ");
                    double alt = double.Parse(Console.ReadLine());
                    result = (b1 + b2)*alt / 2;
                    Console.Write("O resultado da área será: " + result);
                    break;
                default:
                    Console.Write("Opção inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
