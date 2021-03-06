﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_ClasseAAbstratas_
{
    class Poupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public Poupanca() { }

        public Poupanca(int num, string titular, double saldo, double taxaJuros) : base(num, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}