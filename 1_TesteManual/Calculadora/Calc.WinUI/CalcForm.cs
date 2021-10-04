using Calc.Lib;
using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            decimal valorDigitado1 = Convert.ToDecimal(txtValor1.Text);
            decimal valorDigitado2 = Convert.ToDecimal(txtValor2.Text);

            var calc = new Calculos();
            decimal resultado = calc.EfetuarCalculo(valorDigitado1, valorDigitado2, '+');

            lblResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            decimal valorDigitado1 = Convert.ToDecimal(txtValor1.Text);
            decimal valorDigitado2 = Convert.ToDecimal(txtValor2.Text);

            var calc = new Calculos();
            decimal resultado = calc.EfetuarCalculo(valorDigitado1, valorDigitado2, '-');

            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            decimal valorDigitado1 = Convert.ToDecimal(txtValor1.Text);
            decimal valorDigitado2 = Convert.ToDecimal(txtValor2.Text);

            var calc = new Calculos();
            decimal resultado = calc.EfetuarCalculo(valorDigitado1, valorDigitado2, '*');

            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            decimal valorDigitado1 = Convert.ToDecimal(txtValor1.Text);
            decimal valorDigitado2 = Convert.ToDecimal(txtValor2.Text);

            var calc = new Calculos();
            decimal resultado = calc.EfetuarCalculo(valorDigitado1, valorDigitado2, '/');

            lblResultado.Text = resultado.ToString();
        }
    }
}
