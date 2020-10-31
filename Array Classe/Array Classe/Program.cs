using Array_Classe;
using System;
using System.Globalization;
using System.Linq;

namespace Exerc_Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Coloque a quantidade de produtos: ");   
            int n = int.Parse(Console.ReadLine());



            Produto[] prod = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Valor do produto:");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto { Nome = nome, Valor = valor };
            }


            double soma = 0.0; 
            for (int i = 0; i < n; i++)
            {
                soma += prod[i].Valor;
            }



            Console.WriteLine("Preço médio: " + soma / prod.Length);
        }
    }
}