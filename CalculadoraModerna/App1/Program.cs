using Calc.Core.Interfaces;
using CalcCore;

namespace App1
{
    public class Program
    {
        private static ICalc _calc;
        static void Main(String[] args)
        {
            _calc = new CalcSuperpower.CalcSuperpower();

            //Console.WriteLine($"[App1] Add {_calc.Suma(1, 1)}");

            var m = new Manager(_calc);
            m.Print();

            Console.ReadKey();
        }
    }
}