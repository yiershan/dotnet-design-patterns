using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            new Invoker()
                .AddCommand(new CreateOrderCommand())
                .AddCommand(new ChangeStockCommand())
                .Excute(receiver);
            Console.ReadLine();
        }
    }
}
