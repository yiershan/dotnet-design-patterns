using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class CreateOrder : ICommand
    {
        public void Executed()
        {
            Console.WriteLine("创建了订单信息！");
        }
    }

    public class WriteLogDecorator : ICommand
    {
        private ICommand _command;
        public WriteLogDecorator(ICommand command) {
            _command = command;
        }
        public void Executed()
        {
            Console.WriteLine("记录了日志！");
            _command.Executed();
        }
    }

    public class PayDecorator : ICommand
    {
        private ICommand _command;
        public PayDecorator(ICommand command)
        {
            _command = command;
        }
        public void Executed()
        {
            _command.Executed();
            Console.WriteLine("支付了完成了！");
        }
    }
    public class StockDecorator : ICommand
    {
        private ICommand _command;
        public StockDecorator(ICommand command)
        {
            _command = command;
        }
        public void Executed()
        {
            _command.Executed();
            Console.WriteLine("扣减了库存！");
        }
    }
}
