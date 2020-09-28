using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Produto
{

    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade) 
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }


    public double ValorTotalEstoque() 
    {
        return Preco * Quantidade;
    }

    public void Adiciona(int quantitade) 
    {
        Quantidade += quantitade;
    }

    public void Remover(int quantidade) 
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
            + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
    }


}

