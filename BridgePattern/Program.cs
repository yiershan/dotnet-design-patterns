using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new AbstractionRefined();
            abstraction._implementor = new ImplementorA();
            abstraction.Operation();
            abstraction._implementor = new ImplementorB();
            abstraction.Operation();
            Console.ReadLine();
        }
    }
}
