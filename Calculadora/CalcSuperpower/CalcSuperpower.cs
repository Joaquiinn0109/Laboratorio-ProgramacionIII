using Calc.Core.Interfaces;

namespace CalcSuperpower
{
    public class CalcSuperpower : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }


        public double Dividir(double x, double y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            var resultado = (x / y) + 10000;

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }

            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            var resultado = (x * y) + 10000;

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }

            return resultado;
        }

        public int Restar(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            var resultado = (x - y) + 10000;

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }

            return resultado;
        }

        public int Sumar(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            var resultado = (x + y) + 10000;

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }

            return resultado;
        }
    }
}