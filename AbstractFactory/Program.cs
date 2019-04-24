using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = new Client(new FactoryA1());
            client1.Run();
            var client2 = new Client(new FactoryB2());
            client2.Run();
            Console.ReadLine();
        }
    }
}
