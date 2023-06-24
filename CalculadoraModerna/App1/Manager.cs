using Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
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
            Console.WriteLine($"[App1] Suma {_calc.Suma(1, 1)}");
        }
    }
}
