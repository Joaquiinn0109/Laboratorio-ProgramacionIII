using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Core.Interfaces
{
    public interface ICalc
    {
        EventHandler Procesando { get; set; }
        EventHandler Termino { get; set; }
        int Sumar(int x, int y);

        int Restar(int x, int y);

        int Multiplicar(int x, int y);

        double Dividir(double x, double y);
    }
}
