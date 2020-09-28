using System;

namespace Peach
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Princesa peach", 6000.00, 1000.00);
            Console.WriteLine("Funcionario: " + funcionario.Nome + "," + funcionario.SalarioLiquido());

            Console.WriteLine("Digite a porcentagem para aumentar o salario.");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + funcionario.Nome + "," + funcionario.SalarioLiquido());

        }
    }
}