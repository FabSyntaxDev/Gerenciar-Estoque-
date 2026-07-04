using System;


namespace MyAPP
{
    class App
    {
        static void Main(string[] args)
        {

            Produto nome, preco, quantidade;

            nome = new Produto();
            preco = new Produto();
            quantidade = new Produto();



            Console.WriteLine("Entre com os dados do Produto");
            string nomeDoProduto = Console.ReadLine();
            Console.WriteLine("Preço");
            double precoDoProduto = Console.Read();
            Console.WriteLine("Quantidade no Estoque");
            int quantidadeDoProduto = Console.Read();


        }
}
}