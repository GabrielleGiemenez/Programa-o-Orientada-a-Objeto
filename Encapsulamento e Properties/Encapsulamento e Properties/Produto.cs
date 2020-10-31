using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Encap_properties
{
    class Produto
    {
        string _nome;
        double _preco;
        int _quantidade;

        public Produto()
        {
        }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }
      
        public double Preco
        {
            get { return _preco; }
        }

        public int Qtde
        {
            get { return _quantidade; }
        }
        

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionaProduto(int qtde)
        {
            _quantidade += _quantidade;
        }

        public void RemoveProduto(int qtde)
        {
           _quantidade -= _quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}