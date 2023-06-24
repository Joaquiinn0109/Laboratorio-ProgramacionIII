using Calc.Core.Interfaces;

namespace CalcCore
{
    public class Calc : ICalc
    {
        public int Suma(int x, int y) 
        {
            return x + y;
        }
        public int Resta(int x, int y)
        {
            return x - y;
        }
        public int Multiplicacion(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x/y;
        }
    }
}