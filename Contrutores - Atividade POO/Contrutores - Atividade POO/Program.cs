using System;
using System.Globalization;


namespace Contrutores___Atividade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque os dados do produto ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine());



            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Coloque o valor que será adicionado dos produtos:  ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dado Final: " + p);


            Console.WriteLine("Coloque o valor que será adicionado dos produtos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dado final: " + p);
        }
    }
}
    
