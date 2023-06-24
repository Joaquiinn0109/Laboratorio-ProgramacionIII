using Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp1
{
    public class Manager
    {
        private ICalc _calc;
        public Manager(ICalc calc) 
        {
            _calc = calc;
        }

        public void SetCalc(ICalc calc)
        {
            _calc = calc;
        }

        public void Print()
        {
            Console.WriteLine($"[App1] Sumar {_calc.Sumar(1, 1)}");
            Console.WriteLine($"[App1] Restar {_calc.Restar(3, 1)}");
            Console.WriteLine($"[App1] Multiplicar {_calc.Multiplicar(3, 3)}");
            Console.WriteLine($"[App1] Dividir {_calc.Dividir(4, 2)}");
        }
    }
}
