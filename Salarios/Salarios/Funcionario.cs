using System;
using System.Collections.Generic;
using System.Text;

namespace Salario
{
    class Funcionario
    {
        int id;
        string nome;
        double salario = 0;


        public int Id { get => id; set => id = value; }

        public string Nome { get => nome; set => nome = value; }

        public double Salario { get => salario; set => salario = value; }

        //Porcentual de aumento de salario
        public void aumentaSalario(double porcent)
        {
            salario += salario * (porcent / 100);
        }


        //ToString para imprimir na tela as informações da lista
        public override string ToString()
        {
            return "ID: " + Id + "   Nome: " + Nome + "  Salário: " + Salario;
        }
    }
}