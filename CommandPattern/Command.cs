using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public abstract class Command
    {
        public abstract void Excute(Receiver receiver);
    }

    public class CreateOrderCommand : Command
    {
        public override void Excute(Receiver receiver)
        {
            Console.WriteLine("创建单据完成！");
        }
    }
    public class ChangeStockCommand : Command
    {
        public override void Excute(Receiver receiver)
        {
            Console.WriteLine("扣减库存完成！");
        }
    }
}
