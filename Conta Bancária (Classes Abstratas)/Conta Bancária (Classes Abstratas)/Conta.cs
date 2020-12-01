using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_ClasseAAbstratas_
{
    abstract class Conta
    {

        public int Num { get; private set; }
        public string Proprietario { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() { }

        public Conta(int numero, string proprietario, double saldo)
        {
            Num = numero;
            Proprietario = proprietario;
            Saldo = saldo;
        }

        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}

