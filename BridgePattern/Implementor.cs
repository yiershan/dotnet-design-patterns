using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Implementor
    {
        public abstract void Operation();
    }
    public class ImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("我处理问题需要10s");
        }
    }
    public class ImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("我处理问题需要1s");
        }
    }
}
