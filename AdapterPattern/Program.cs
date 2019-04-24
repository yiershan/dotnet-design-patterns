using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget t = new Adapter();
            t.Request();
            Console.ReadLine();
        }
    }
}
