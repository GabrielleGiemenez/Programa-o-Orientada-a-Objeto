using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Escreva o nome de uma pessoa");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Escreva a idade da pessoa");
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o nome da segunda pessoa");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Escreva a idade da pessoa");
            B.Idade = int.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine("A pessoa mais velha é :" + A.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é :" + B.Nome);
            }



        }   
    }
}
