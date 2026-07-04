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

        public Produto(string Nome, double Preco, int Quantidade)
        {
            nome = Nome;
            preco = Preco;
            quantidade = Quantidade;
        }


        public int ValorTotalEmEstoque()
        {
            int total = ((int)preco * quantidade);
            return total;
        }

        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + ", " + quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int Quantidade)
        {
            quantidade += Quantidade;
        }

        public void RemoverProdutos(int Quantidade)
        {
            quantidade -= Quantidade;
        }
}
}
