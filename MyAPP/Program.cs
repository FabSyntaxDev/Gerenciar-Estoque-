using System;


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
            p.preco = Console.Read();
            Console.WriteLine("Quantidade no Estoque");
            p.quantidade = Console.Read();


        }
}
}