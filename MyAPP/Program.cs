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

            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(l);
            Console.WriteLine(t);

            Console.WriteLine($"bem vindo {nome}");
        }
}
}