using Calc.Core.Interfaces;
using CalcCore;

namespace CalcApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new CalcCore.CalcNormal();

            Console.WriteLine($"[App2] Sumar {c.Sumar(1, 1)}");
            Console.WriteLine($"[App2] Restar {c.Restar(3, 1)}");
            Console.WriteLine($"[App2] Multiplicar {c.Multiplicar(3, 3)}");
            Console.WriteLine($"[App2] Dividir {c.Dividir(4, 2)}");

            Console.ReadKey();
        }
    }
}