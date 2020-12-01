using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_ClasseAAbstratas_
{
    class Juridica : Conta
    {
        public double EmprestimoLimite { get; set; }

        public Juridica() { }

        public Juridica(int num, string titular, double saldo, double emprestimoLimite) : base(num, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
