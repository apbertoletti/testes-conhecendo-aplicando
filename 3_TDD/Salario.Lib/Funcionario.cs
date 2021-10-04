using System;

namespace Salario
{
    public class Funcionario
    {
        public decimal CalculaSalario(string cargo, decimal salarioBruto)
        {
            if (cargo == "DEV")
            {
                if (salarioBruto <= 3000)
                    return salarioBruto * 0.90m;

                return salarioBruto * 0.80m;
            }

            return salarioBruto;
        }
    }
}
