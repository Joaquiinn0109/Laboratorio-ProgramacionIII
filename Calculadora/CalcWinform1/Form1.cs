using Calc.Core.Interfaces;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private LinkedList<Button> _lista = new LinkedList<Button>();
        private ICalc _calc;
        public Form1(ICalc calc)
        {
            _calc = calc;

            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Sumar(1, 1);

            label1.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Restar(2, 1);

            label2.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Multiplicar(3, 3);

            label3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Dividir(6, 2);

            label4.Text = resultado.ToString();
        }
        private void Calc_Procesando_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Procesando...";
        }
        private void Calc_Termino_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Termino!";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (_lista.Count() == 0)
            {
                int num = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        var b = new Button();
                        b.Text = num.ToString();

                        b.Location = new Point(90 * j, i * 22);

                        panelCalc.Controls.Add(b);
                        _lista.AddLast(b);
                        num++;
                    }
                }
                string[] array = { "+", "-", "*", "/" };
                for (int i = 0; i < array.Length; i++)
                {
                    var b = new Button() { Text = array[i] };
                    b.Location = new Point(300, 22 * i);
                    panelCalc.Controls.Add(b);
                    _lista.AddLast(b);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_lista.Count != 0)
            {
                if (_lista.Count() > 0)
                {
                    _lista.Remove(_lista.ElementAt(0));
                    panelCalc.Controls.RemoveAt(0);
                }
            }
        }
    }
}