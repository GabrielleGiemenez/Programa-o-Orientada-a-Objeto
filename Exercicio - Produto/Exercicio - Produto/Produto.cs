using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) //método construtor.
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEstoque() //calculo do valor de estoque.
        {
            return Preco * Quantidade;
        }

        public void Adiciona(int quantitade) //adiciona peças ao estoque.
        {
            Quantidade += quantitade;
        }

        public void Remover(int quantidade) //remove peças do estoque.
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() //método de ToString para impressão de informações.
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
