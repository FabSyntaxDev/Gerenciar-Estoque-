using System;
using System.Globalization;


namespace MyAPP
{
    class App
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do Produto");
            p.nome = Console.ReadLine();
            Console.WriteLine("Preço");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no Estoque");
            p.quantidade = int.Parse(Console.ReadLine());
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