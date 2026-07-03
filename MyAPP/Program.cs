using System;


namespace MyAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte x = 100;
            int y = 99999999;
            long l = 99999999999L;
            string nome = "Jose";
            int t = int.MaxValue;


            Class1 Valor1, Valor2;

            Valor1 = new Class1();
            Valor2 = new Class1();



            Console.WriteLine($"valores: {Valor1.valor1}");

            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(l);
            Console.WriteLine(t);

            Console.WriteLine($"bem vindo {nome}");

            string nomeInput;

            Console.WriteLine("Entre com as medidas do triangulo X");
            nomeInput = Console.ReadLine();
            Console.WriteLine(nomeInput);




        }
}
}