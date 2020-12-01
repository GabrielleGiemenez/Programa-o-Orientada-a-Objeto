using System;
using System.Collections.Generic;
using System.Globalization;

namespace ContaBancaria_ClasseAAbstratas_
{
    class Program
    {
        static void Main(string[] args)
        {
           //Cria lista
            List<Conta> list = new List<Conta>();

            //Adiciona elemento na lista 
            list.Add(new Poupanca(1001, "Lucas", 500.0, 0.01));
            list.Add(new Juridica(1002, "Caio", 500.0, 400.0));
            list.Add(new Poupanca(1003, "Mariana", 500.0, 0.01));
            list.Add(new Juridica(1004, "Larissa", 500.0, 400.0));

            double sum = 0.0;
            //Executa instruções para cada conta
            foreach (Conta acc in list)
            {
                //Faz a somatório dos saldos da conta
                sum += acc.Saldo;
            }

            //Imprime na tela o toal do saldo de todas as contas
            Console.WriteLine("Todos os  saldos de todas as contas: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //Instancia os saque das contas
            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }

            //Imprime na tela os saldos das contas
            foreach (Conta acc in list)
            {
                Console.WriteLine("Novo saldo das contas: " + acc.Num + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }

            Juridica bacc = new Juridica(1002, "Beatriz", 0.0, 500.0);



            Conta acc1 = bacc;
            Conta acc2 = new Juridica(1003, "Maria", 0.0, 500.0);
            Conta acc3 = new Poupanca(1004, "Bruno", 0.0, 0.01);



            Juridica acc4 = (Juridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is Juridica)
            {
                Juridica acc5 = (Juridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is Poupanca)
            {
                Poupanca acc5 = acc3 as Poupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
