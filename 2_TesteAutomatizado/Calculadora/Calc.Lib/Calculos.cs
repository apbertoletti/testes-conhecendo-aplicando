﻿namespace Calc.Lib
{
    public class Calculos
    {
        public decimal EfetuarCalculo(decimal valor1, decimal valor2, char tipoOperacao)
        {
            decimal resultado = 0;

            switch (tipoOperacao)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;

                case '-':
                    resultado = valor1 - valor2;
                    break;

                case '*':
                    resultado = valor1 * valor2;
                    break;

                case '/':
                    resultado = valor1 / valor2;
                    break;
            }

            return resultado;
        }
    }
}
