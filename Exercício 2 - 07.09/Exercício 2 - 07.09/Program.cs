using System;
using System.Collections.Generic;
using System.Text;

namespace Peach
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public Funcionario(string nome, double SalarioBruto, double imposto)
        {
            this.Nome = Nome;
            this.SalarioBruto = SalarioBruto;
            this.imposto = imposto;

        }

        public double SalarioLiquido()
        {
            return this.SalarioBruto - this.imposto;

        }

        public void AumentarSalario(double porcentagem)
        {
            this.SalarioBruto = this.SalarioBruto + (porcentagem / 100);
        }
    }
}