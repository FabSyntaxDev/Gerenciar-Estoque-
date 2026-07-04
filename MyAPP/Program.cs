using System;
using System.Globalization;


namespace MyAPP
{
    class App
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os dados do Produto");
            string nomeI = Console.ReadLine();
            Console.WriteLine("Preço");
            double precoI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no Estoque");
            int qntI = int.Parse(Console.ReadLine());

            Produto p = new Produto(nomeI, precoI, qntI);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a ser retirado do estoque");
            int qtr = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtr);
            Console.WriteLine("Dados atualizados: " + p);








        }
}
}