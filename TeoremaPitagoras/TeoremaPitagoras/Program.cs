using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoremaPitagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo Teorema de Pitagoras");

            Console.WriteLine("Ingresa lado A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa lado B:");
            int b = int.Parse(Console.ReadLine());

            double C = Math.Pow(a, 2) + Math.Pow(b, 2);
            C = Math.Sqrt(C);
            Console.WriteLine("C = " + C);
            Console.ReadKey();
        }
    }
}
