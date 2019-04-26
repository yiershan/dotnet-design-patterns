using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 记录日志、创建单据
            var cmd1 = new WriteLogDecorator(new CreateOrder());
            cmd1.Executed();
            // 记录日志、创建单据、扣减库存、支付
            var cmd2 = new WriteLogDecorator(new StockDecorator(new PayDecorator(new CreateOrder())));
            cmd2.Executed();
            Console.ReadLine();
        }
    }
}
