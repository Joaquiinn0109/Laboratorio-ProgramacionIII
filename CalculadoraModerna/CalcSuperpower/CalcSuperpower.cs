using Calc.Core.Interfaces;

namespace CalcSuperpower
{
    public class CalcSuperpower : ICalc
    {
        public EventHandler Procesando { get; set; }

        public EventHandler Termino { get; set; }   

        public int Suma(int x, int y)
        {
            Procesando.Invoke(this, new EventArgs());

            var resultado = x + y + 10000;

            Termino.Invoke(this, new EventArgs());

            return resultado;

        }
        public int Resta(int x, int y)
        {
            return x - y + 10000;
        }
        public int Multiplicacion(int x, int y)
        {
            return x * y + 10000;
        }
        public int Division(int x, int y)
        {
            return x / y + 10000;
        }
    }
}