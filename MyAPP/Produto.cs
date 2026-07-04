using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPP
{
    internal class Produto
    {

        public string nome;
        public double preco;
        public int quantidade;

        public int ValorTotalEmEstoque()
        {
            int total = ((int)preco * quantidade);
            return total;
        }








    }
}
