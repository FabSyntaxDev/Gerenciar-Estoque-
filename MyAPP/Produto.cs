using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPP
{
    internal class Produto
    {

        string nome;
        double preco;
        int quantidade;

        public int ValorTotalEmEstoque()
        {
            int total = ((int)preco * quantidade);
            return total;
        }







    }
}
