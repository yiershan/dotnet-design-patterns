using System;

namespace SingletionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletion = Singletion.GetInstance();
            Console.WriteLine( singletion.GetName());
            Console.ReadLine();
        }
    }
}
