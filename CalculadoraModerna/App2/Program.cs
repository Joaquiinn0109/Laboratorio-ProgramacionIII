using Calc.Core.Interfaces;
using CalcCore;

namespace App2
{
    public class Program
    {
        static void Main(String[] args)
        {
            var c = new Calc();

            Console.WriteLine($"[App2] Suma {c.Suma(1, 1)}");

            Console.ReadKey();
        }
    }
}

