using System;
using System.Collections.Generic;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a quantidade de funcionários: ");
            int qtda = int.Parse(Console.ReadLine());

            //Cria a lista de funcionarios
            List<Funcionario> funcionarios = new List<Funcionario>();

            //Cria o loop em razão do numero N de funcionarios
            for (int i = 0; i < qtda; i++)
            {
                //Funcionário instanciado
                Funcionario func = new Funcionario();

                //verifica a repetição do ID
                bool verificaId = false;

                //Verifica o ID do personagem
                do
                {
                    if (verificaId == true)
                    {
                        Console.WriteLine("Id já utilizado, informe outro: ");
                    }
                    Console.WriteLine("Informe o ID do funcionário: ");
                    func.Id = int.Parse(Console.ReadLine());
                    verificaId = funcionarios.Exists(x => x.Id == func.Id);

                } while (verificaId == true);


                Console.WriteLine("Informe o nome do funcionário: ");
                func.Nome = Console.ReadLine();


                Console.WriteLine("Informe o salário do funcionário: ");
                func.Salario = double.Parse(Console.ReadLine());

                //Adiciona o funcionario na lista criada
                funcionarios.Add(func);
            }

            //
            Console.WriteLine("Informe o ID do funcionário que receberá aumento: ");
            int id = int.Parse(Console.ReadLine());

            //Busca do ID do funcionário
            if (funcionarios.Exists(x => x.Id == id))
            {
                Console.WriteLine("Qual o aumento do funcionário: ");
                double porcent = double.Parse(Console.ReadLine());

                //Reserva o ido para fazer fazer o percentual
                int pos = funcionarios.FindIndex(x => x.Id == id);
                funcionarios[pos].aumentaSalario(porcent);
            }
            else
            {
                Console.ReadKey();
            }

            //Imprime elementos na tela 
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}