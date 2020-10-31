using Encap_properties;
using System;
using System.Globalization;

namespace Encapsulamento_e_Properties

    {
        class Program
        {
            static void Main(string[] args)
            {
          
                Console.WriteLine("Digite os dados do produto: ");
                Console.WriteLine("nome");
                string nome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");
                Console.WriteLine("Quantidade: ");
                int qtde = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nome, preco, qtde);

                Console.WriteLine("Dados do produto: " + produto + "\n");

                Console.WriteLine("Coloque o valor que será adicionado ao produto: ");
                int _quantidade = int.Parse(Console.ReadLine());
                produto.AdicionaProduto(_quantidade);
                Console.WriteLine("Produto Final: " + produto + "\n");

        
                Console.WriteLine("Coloque o valor que será removido do produto: ");
                _quantidade = int.Parse(Console.ReadLine());
                produto.RemoveProduto(_quantidade);
                Console.WriteLine("Produto Final: " + produto + "\n");

            }
        }
    }
}
