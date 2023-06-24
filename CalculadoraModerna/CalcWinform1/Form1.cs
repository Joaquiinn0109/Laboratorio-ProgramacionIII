using Calc.Core.Interfaces;
using CalcCore;

namespace CalcWinform1
{
    private ICalc _calc;
    public partial class Form1 : Form
    {
        public Form1(ICalc calc)
        {
            _calc = calc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultdo = _calc.Suma(1, 1);


        }
    }
}