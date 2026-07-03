using System;
using User;


namespace MyAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte x = 100;
            int y = 99999999;
            long l = 99999999999L;
            int t = int.MaxValue;


            Class1 Valor1, Valor2;

            Valor1 = new Class1();
            Valor2 = new Class1();



            Console.WriteLine($"valores: {Valor1.valor1}");

            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(l);
            Console.WriteLine(t);


            string nomeInput;

            Console.WriteLine("Entre com as medidas do triangulo X");
            nomeInput = Console.ReadLine();
            Console.WriteLine(nomeInput);



            Console.WriteLine("----------------------------------");

            User11 nome, password, email;


            string dados = new User11().dados();

            nome = new User11();
            password = new User11();
            email = new User11();

            Console.WriteLine("Digita seu nome");
            nome.nome = Console.ReadLine();

            Console.WriteLine("------------------------------------");
            Console.WriteLine(dados);


        }
}
}